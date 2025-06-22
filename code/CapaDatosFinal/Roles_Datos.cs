using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class Roles_Datos
    {
        public List<Roles> Listar()
        {
            List<Roles> lista = new List<Roles>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT id_rol, nombre_rol, descripcion FROM Roles");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    using (oconexion)
                    {
                        oconexion.Open();

                        using (SqlDataReader dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                lista.Add(new Roles()
                                {
                                    id_rol = Convert.ToInt32(dataReader["id_rol"]),
                                    nombre_rol = dataReader["nombre_rol"].ToString(),
                                    descripcion = dataReader["descripcion"] != DBNull.Value
                                                        ? dataReader["descripcion"].ToString()
                                                        : string.Empty
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Roles>();
                    string Mensaje = ex.Message;
                }
            }
            return lista;
        }
    }
}
