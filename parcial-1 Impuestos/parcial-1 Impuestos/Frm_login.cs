using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial_1_Impuestos
{
    public partial class Frm_login : Form
    {
        private Conexion_base_datos conexion;

        public Frm_login()
        {
            InitializeComponent();
            conexion = new Conexion_base_datos();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Frm_usuario ventanaUsuario = new Frm_usuario();
            ventanaUsuario.Show();
            this.Hide();
            string usuario = txtusuario.Text.Trim();
            string clave = txtclave.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Por favor, ingrese el usuario y la contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                
                string query = "SELECT COUNT(*) FROM usuarios_USSS075226 WHERE usuario = @usuario AND clave = @clave";

                SqlCommand cmd = new SqlCommand(query, conexion.objConexion);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@clave", clave);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());

                if (resultado > 0)
                {
                    MessageBox.Show("¡Acceso concedido! Bienvenido al sistema.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm_usuario formUsuario = new Frm_usuario();
                    formUsuario.Show();
                    this.Hide(); 
                }
                else
                {
                    
                    MessageBox.Show("Acceso denegado. El usuario no está registrado o la clave es incorrecta.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusuario.Clear();
                    txtclave.Clear();
                    txtusuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
 