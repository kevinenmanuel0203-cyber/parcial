using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial_1_Impuestos
{
    internal class Conexion_base_datos
    {
        private readonly string cadenaConexion =
             @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbacademica.mdf;Integrated Security=True";

        private DataSet ds;
        internal SqlConnection objConexion;

        public DataSet crearDs()
        {
            ds = new DataSet();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            using (SqlCommand comando = new SqlCommand(
                @"SELECT [idUsuario], [usuario], [clave], [nombre],
                         [direccion], [telefono]
                  FROM [usuarios_usss148726]
                  ORDER BY [idUsuario]", conexion))
            using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
            {
                adaptador.Fill(ds, "usuarios_usss148726");
            }

            return ds;
        }

        public DataSet obtenerDatos()
        {
            return crearDs();
        }

        public int procesar(string sql, params SqlParameter[] parametros)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            using (SqlCommand comando = new SqlCommand(sql, conexion))
            {
                if (parametros != null && parametros.Length > 0)
                    comando.Parameters.AddRange(parametros);

                conexion.Open();
                return comando.ExecuteNonQuery();
            }
        }

        public string mantenimiento_usuarios_usss148726(
            string[] datos, string accion)
        {
            try
            {
                string sql;
                SqlParameter[] parametros;

                if (accion == "nuevo")
                {
                    sql = @"INSERT INTO [usuarios_usss148726]
                            ([usuario], [clave], [nombre], [direccion], [telefono])
                            VALUES (@usuario, @clave, @nombre, @direccion, @telefono)";

                    parametros = new SqlParameter[]
                    {
                        new SqlParameter("@usuario", SqlDbType.VarChar, 35) { Value = datos[1] },
                        new SqlParameter("@clave", SqlDbType.VarChar, 35) { Value = datos[2] },
                        new SqlParameter("@nombre", SqlDbType.VarChar, 65) { Value = datos[3] },
                        new SqlParameter("@direccion", SqlDbType.VarChar, 85) { Value = datos[4] },
                        new SqlParameter("@telefono", SqlDbType.VarChar, 9) { Value = datos[5] }
                    };
                }
                else if (accion == "modificar")
                {
                    sql = @"UPDATE [usuarios_usss148726]
                            SET [usuario] = @usuario,
                                [clave] = @clave,
                                [nombre] = @nombre,
                                [direccion] = @direccion,
                                [telefono] = @telefono
                            WHERE [idUsuario] = @id";

                    parametros = new SqlParameter[]
                    {
                        new SqlParameter("@id", SqlDbType.Int) { Value = int.Parse(datos[0]) },
                        new SqlParameter("@usuario", SqlDbType.VarChar, 35) { Value = datos[1] },
                        new SqlParameter("@clave", SqlDbType.VarChar, 35) { Value = datos[2] },
                        new SqlParameter("@nombre", SqlDbType.VarChar, 65) { Value = datos[3] },
                        new SqlParameter("@direccion", SqlDbType.VarChar, 85) { Value = datos[4] },
                        new SqlParameter("@telefono", SqlDbType.VarChar, 9) { Value = datos[5] }
                    };
                }
                else if (accion == "eliminar")
                {
                    sql = @"DELETE FROM [usuarios_usss148726]
                            WHERE [idUsuario] = @id";

                    parametros = new SqlParameter[]
                    {
                        new SqlParameter("@id", SqlDbType.Int) { Value = int.Parse(datos[0]) }
                    };
                }
                else
                {
                    return "La operación solicitada no es válida.";
                }

                int filas = procesar(sql, parametros);

                return filas == 1
                    ? "1"
                    : "No se pudo completar la operación.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string administrarDatosUsuarios(string[] datos, string accion)
        {
            return mantenimiento_usuarios_usss148726(datos, accion);
        }

        public bool validarLogin(string usuario, string clave)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            using (SqlCommand comando = new SqlCommand(
                @"SELECT COUNT(*)
                  FROM [usuarios_usss075226]
                  WHERE [usuario] = @usuario AND [clave] = @clave",
                conexion))
            {
                comando.Parameters.Add("@usuario", SqlDbType.VarChar, 35).Value = usuario;
                comando.Parameters.Add("@clave", SqlDbType.VarChar, 35).Value = clave;

                conexion.Open();

                return Convert.ToInt32(comando.ExecuteScalar()) > 0;
            }
        }

        internal string administrarDatosAlumnos(string[] strings, string v)
        {
            throw new NotImplementedException();
        }

        internal DataSet crearDsUsuarios()
        {
            throw new NotImplementedException();
        }

        internal string mantenimiento_usuarios_USSS075226(string[] datos, string v)
        {
            throw new NotImplementedException();
        }

        internal string mantenimiento_usuarios_usss075226(string[] datos, string v)
        {
            throw new NotImplementedException();
        }
    }
}