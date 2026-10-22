using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial_1_Impuestos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Conexion_base_datos objConexion = new Conexion_base_datos();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();
        public int posicion = 0;
        public string accion = "nuevo";

        private void actualizarDs()
        {
            objDs.Clear();
            objDs = objConexion.obtenerDatos();
            objDt = objDs.Tables["alumnos"];

            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idAlumnos"] };


            configurarColumnasGrid();

            grdAlumnos.DataSource = objDt.DefaultView;
            mostrarDatos();
        }

        private void mostrarDatos()
        {
            throw new NotImplementedException();
        }

        private void configurarColumnasGrid()
        {
            try
            {

                if (grdAlumnos.Columns.Contains("idAlumnos"))
                    grdAlumnos.Columns["idAlumnos"].DataPropertyName = "idAlumnos";

                if (grdAlumnos.Columns.Contains("código"))
                    grdAlumnos.Columns["código"].DataPropertyName = "código";
                else if (grdAlumnos.Columns.Contains("codigo"))
                    grdAlumnos.Columns["codigo"].DataPropertyName = "código";

                if (grdAlumnos.Columns.Contains("nombre"))
                    grdAlumnos.Columns["nombre"].DataPropertyName = "nombre";

                if (grdAlumnos.Columns.Contains("direccion"))
                    grdAlumnos.Columns["direccion"].DataPropertyName = "direccion";

                if (grdAlumnos.Columns.Contains("telefono"))
                    grdAlumnos.Columns["telefono"].DataPropertyName = "telefono";
            }
            catch
            {

            }
        }

        private void MostrarDatos()
        {
            if (objDt.Rows.Count > 0 && posicion >= 0 && posicion < objDt.Rows.Count)
            {
                idAlumno.Text = objDt.Rows[posicion]["idAlumnos"].ToString();
                txtCodigoAlumno.Text = objDt.Rows[posicion]["código"].ToString();
                txtNombreAlumno.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtDireccionAlumno.Text = objDt.Rows[posicion]["direccion"].ToString();
                txtTelefonoAlumno.Text = objDt.Rows[posicion]["telefono"].ToString();

                lblnRegistrosAlumno.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }

        private void btnSiguienteAlumno_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el ultimo registro.", "Navegacion de Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorAlumno_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el primer registro.", "Navegacion de Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoAlumno_Click(object sender, EventArgs e)
        {
            if (objDt.Rows.Count > 0)
            {
                posicion = objDt.Rows.Count - 1;
                mostrarDatos();
            }
        }

        private void btnPrimeroAlumno_Click(object sender, EventArgs e)
        {
            if (objDt.Rows.Count > 0)
            {
                posicion = 0;
                mostrarDatos();
            }
        }

        private void estadoControles(Boolean estado)
        {
            grbDatosAlumno.Enabled = estado;
            grbNavegacionAlumno.Enabled = !estado;
            btnEliminarAlumno.Enabled = !estado;
        }

        private void limpiarControles()
        {
            idAlumno.Text = "";
            txtCodigoAlumno.Text = "";
            txtNombreAlumno.Text = "";
            txtDireccionAlumno.Text = "";
            txtTelefonoAlumno.Text = "";
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            if (btnAgregarAlumno.Text == "Nuevo")
            {
                btnAgregarAlumno.Text = "Guardar";
                btnModificarAlumno.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";
                limpiarControles();
            }
            else
            { // Guardar
                String[] alumnos = {
                    idAlumno.Text, txtCodigoAlumno.Text, txtNombreAlumno.Text, txtDireccionAlumno.Text,
                    txtTelefonoAlumno.Text
                };
                String respuesta = objConexion.administrarDatosAlumnos(alumnos, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar alumnos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estadoControles(false);
                    btnAgregarAlumno.Text = "Nuevo";
                    btnModificarAlumno.Text = "Modificar";
                    actualizarDs();
                }
            }
        }

        private void btnModificarAlumno_Click(object sender, EventArgs e)
        {
            if (btnModificarAlumno.Text == "Modificar")
            {
                btnAgregarAlumno.Text = "Guardar";
                btnModificarAlumno.Text = "Cancelar";
                estadoControles(true);
                accion = "modificar";
            }
            else
            { // Cancelar
                mostrarDatos();
                estadoControles(false);
                btnAgregarAlumno.Text = "Nuevo";
                btnModificarAlumno.Text = "Modificar";
            }
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreAlumno.Text,
                "Eliminando alumnos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String respuesta = objConexion.administrarDatosAlumnos(
                    new String[] { idAlumno.Text, "", "", "", "" }, "eliminar"
                );
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar alumnos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                }
            }
        }

        private void txtBuscarAlumnos_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                filtrarDatos(txtBuscarAlumnos.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filtrarDatos(String valor)
        {
            try
            {
                DataView objDv = objDt.DefaultView;


                objDv.RowFilter = "código like '%" + valor + "%' OR nombre like '%" + valor + "%'";

                grdAlumnos.DataSource = objDv;
                seleccionarAlumno();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void seleccionarAlumno()
        {
            try
            {
                if (grdAlumnos.CurrentRow == null)
                {
                    return;
                }

                string id = "";

                if (grdAlumnos.Columns.Contains("idAlumnos") && grdAlumnos.CurrentRow.Cells["idAlumnos"].Value != null)
                {
                    id = grdAlumnos.CurrentRow.Cells["idAlumnos"].Value.ToString();
                }
                else if (grdAlumnos.CurrentRow.Cells[0].Value != null)
                {
                    id = grdAlumnos.CurrentRow.Cells[0].Value.ToString();
                }

                if (!string.IsNullOrEmpty(id))
                {
                    DataRow dr = objDt.Rows.Find(id);
                    if (dr != null)
                    {
                        posicion = objDt.Rows.IndexOf(dr);
                        mostrarDatos();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void grdAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarAlumno();
        }

        private void grbDatosAlumno_Enter(object sender, EventArgs e)
        {

        }
    }
}
    
