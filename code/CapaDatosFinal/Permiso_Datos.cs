using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CapaDatos
{
    public class Permiso_Datos
    {
        public List<Permiso> Listar(int idusuario)
        {
            List<Permiso> lista = new List<Permiso>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT r.id_rol, p.nombre_acceso FROM permisos p");
                    query.AppendLine("INNER JOIN roles r ON r.id_rol = p.id_rol");
                    query.AppendLine("INNER JOIN users u ON u.id_rol = r.id_rol");
                    query.AppendLine("WHERE u.id_user = @idusuario;");

                    using (SqlCommand cmd = new SqlCommand(query.ToString(), oconexion))
                    {
                        cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = idusuario;
                        cmd.CommandType = CommandType.Text;

                        oconexion.Open();

                        using (SqlDataReader dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                lista.Add(new Permiso()
                                {
                                    objRoles = new Roles() { id_rol = Convert.ToInt32(dataReader["id_rol"]) },
                                    nombreAcceso = dataReader["nombre_acceso"].ToString(),
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Permiso>();
                }
            }
            return lista;
        }
    }
}
