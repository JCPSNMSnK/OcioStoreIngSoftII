using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Consulta_Datos
    {
        public List<Consulta> Listar()
        {
            List<Consulta> lista = new List<Consulta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select id,usuario,nombre,apellido,correo,mensaje,leido,created_at,updated_at,respuesta from consultas c");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            lista.Add(new Consulta()
                            {
                                id_consulta = Convert.ToInt32(dataReader["id"]),
                                usuarioCliente = dataReader["usuario"].ToString(),
                                nombreCliente = dataReader["nombre"].ToString(),
                                apellidoCliente = dataReader["apellido"].ToString(),
                                correoCliente = dataReader["correo"].ToString(),
                                mensaje = dataReader["mensaje"].ToString(),
                                created_at = dataReader["created_at"].ToString(),
                                updated_at = dataReader["updated_at"].ToString(),
                                respuesta = dataReader["respuesta"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Consulta>();
                }
            }
            return lista;
        }
        public bool Registrar(Consulta obj, out string Consulta)
        {
            bool resultado = false;
            Consulta = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("PROC_REGISTRAR_RESPUESTA_CONSULTA", oconexion);
                    cmd.Parameters.AddWithValue("id_consulta", obj.id_consulta);
                    cmd.Parameters.AddWithValue("respuesta", obj.respuesta);
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    Consulta = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                resultado = false;
                Consulta = ex.Message;
            }

            return resultado;
        }
    }
}
