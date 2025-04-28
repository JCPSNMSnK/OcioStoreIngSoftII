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
    public class Mensaje_Datos
    {
        public List<Mensaje> Listar()
        {
            List<Mensaje> lista = new List<Mensaje>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT id,nombre,correo,mensaje,leido,created_at,updated_at,respuesta FROM mensajes");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            lista.Add(new Mensaje()
                            {
                                id_mensaje = Convert.ToInt32(dataReader["id"]),
                                nombreCliente = dataReader["nombre"].ToString(),
                                emailCliente = dataReader["correo"].ToString(),
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
                    lista = new List<Mensaje>();
                }
            }
            return lista;
        }
        public bool Registrar(Mensaje obj, out string Mensaje)
        {
            bool resultado = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("PROC_REGISTRAR_RESPUESTA", oconexion);
                    cmd.Parameters.AddWithValue("id_mensaje", obj.id_mensaje);
                    cmd.Parameters.AddWithValue("respuesta", obj.respuesta);
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                resultado = false;
                Mensaje = ex.Message;
            }

            return resultado;
        }
    }
}
