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
                    query.AppendLine("SELECT pr.id_perfiles, p.nombreAcceso FROM permiso p");
                    query.AppendLine("INNER JOIN perfiles pr ON pr.id_perfiles = p.id_perfil");
                    query.AppendLine("INNER JOIN usuarios u ON u.perfil_id = pr.id_perfiles");
                    query.AppendLine("WHERE u.id = @idusuario");

                    using (SqlCommand cmd = new SqlCommand(query.ToString(), oconexion))
                    {
                        cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = idusuario; // Ajusta SqlDbType según el tipo de idusuario
                        cmd.CommandType = CommandType.Text;

                        oconexion.Open();

                        using (SqlDataReader dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                lista.Add(new Permiso()
                                {
                                    objPerfil = new Perfil() { id_perfil = Convert.ToInt32(dataReader["id_perfiles"]) },
                                    nombreAcceso = dataReader["nombreAcceso"].ToString(),
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
