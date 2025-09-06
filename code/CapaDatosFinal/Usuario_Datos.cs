using CapaEntidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class Usuario_Datos
    {
        public Usuario ObtenerUsuarioLogin(string username)
        {
            Usuario usuario = null;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                string query = @"
            SELECT u.id_user, u.apellido, u.nombre, u.dni, u.mail, u.username, u.pass, u.baja_user,
                 u.telefono_user, u.direccion_user, u.localidad_user, u.provincia_user,
                 r.id_rol, r.nombre_rol, r.descripcion
            FROM Users u
            INNER JOIN Roles r ON r.id_rol = u.id_rol
            WHERE u.username = @username COLLATE Latin1_General_CS_AS"; // case-sensitive

                SqlCommand cmd = new SqlCommand(query, oconexion);
                cmd.Parameters.AddWithValue("@username", username);

                try
                {
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new Usuario()
                            {
                                id_user = Convert.ToInt32(reader["id_user"]),
                                apellido = reader["apellido"].ToString(),
                                nombre = reader["nombre"].ToString(),
                                dni = Convert.ToInt32(reader["dni"]),
                                mail = reader["mail"].ToString(),
                                username = reader["username"].ToString(),
                                pass = reader["pass"].ToString(),
                                baja_user = Convert.ToBoolean(reader["baja_user"]),
                                objRoles = new Roles()
                                {
                                    id_rol = Convert.ToInt32(reader["id_rol"]),
                                    nombre_rol = reader["nombre_rol"].ToString(),
                                    descripcion = reader["descripcion"].ToString()
                                },
                                telefono_user = reader["telefono_user"].ToString(),
                                direccion_user = reader["direccion_user"].ToString(),
                                localidad_user = reader["localidad_user"].ToString(),
                                provincia_user = reader["provincia_user"].ToString()
                            };
                        }
                    }
                }
                catch
                {
                    throw; // Propagar la excepción a la capa de negocio
                }
            }

            return usuario;
        }



        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT u.id_user, u.apellido, u.nombre, u.dni, u.mail, u.username, u.pass, u.baja_user, " +
                        "u.telefono_user, u.direccion_user, u.localidad_user, u.provincia_user," +
                        "r.id_rol, r.nombre_rol, r.descripcion");
                    query.AppendLine("FROM Users u");
                    query.AppendLine("INNER JOIN Roles r ON r.id_rol = u.id_rol;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                id_user = Convert.ToInt32(dataReader["id_user"]),
                                apellido = dataReader["apellido"].ToString(),
                                nombre = dataReader["nombre"].ToString(),
                                dni = Convert.ToInt32(dataReader["dni"]),
                                mail = dataReader["mail"].ToString(),
                                username = dataReader["username"].ToString(),
                                pass = dataReader["pass"].ToString(),
                                baja_user = Convert.ToBoolean(dataReader["baja_user"]),
                                objRoles = new Roles()
                                {
                                    id_rol = Convert.ToInt32(dataReader["id_rol"]),
                                    nombre_rol = dataReader["nombre_rol"].ToString(),
                                    descripcion = dataReader["descripcion"].ToString()
                                },
                                telefono_user = dataReader["telefono_user"].ToString(),
                                direccion_user = dataReader["direccion_user"].ToString(),
                                localidad_user = dataReader["localidad_user"].ToString(),
                                provincia_user = dataReader["provincia_user"].ToString()
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Usuario>();
                    string Mensaje = ex.Message;
                }
            }
            return lista;
        }

        public List<Usuario> BuscarUsuarios(Usuario filtros)
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PROC_BUSCAR_USUARIO", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_user", filtros.id_user == 0 ? (object)DBNull.Value : filtros.id_user);
                    cmd.Parameters.AddWithValue("@apellido", string.IsNullOrEmpty(filtros.apellido) ? (object)DBNull.Value : filtros.apellido);
                    cmd.Parameters.AddWithValue("@nombre", string.IsNullOrEmpty(filtros.nombre) ? (object)DBNull.Value : filtros.nombre);
                    cmd.Parameters.AddWithValue("@dni", filtros.dni == 0 ? (object)DBNull.Value : filtros.dni);
                    cmd.Parameters.AddWithValue("@mail", string.IsNullOrEmpty(filtros.mail) ? (object)DBNull.Value : filtros.mail);
                    cmd.Parameters.AddWithValue("@username", string.IsNullOrEmpty(filtros.username) ? (object)DBNull.Value : filtros.username);

                    if (filtros.objRoles != null && filtros.objRoles.id_rol != 0)
                    {
                        cmd.Parameters.AddWithValue("@id_rol", filtros.objRoles.id_rol);
                        cmd.Parameters.AddWithValue("@nombre_rol", string.IsNullOrEmpty(filtros.objRoles.nombre_rol) ? (object)DBNull.Value : filtros.objRoles.nombre_rol);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@id_rol", (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@nombre_rol", (object)DBNull.Value);
                    }

                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                id_user = Convert.ToInt32(reader["id_user"]),
                                apellido = reader["apellido"].ToString(),
                                nombre = reader["nombre"].ToString(),
                                dni = Convert.ToInt32(reader["dni"]),
                                mail = reader["mail"].ToString(),
                                username = reader["username"].ToString(),
                                pass = reader["pass"].ToString(),
                                baja_user = Convert.ToBoolean(reader["baja_user"]),
                                objRoles = new Roles()
                                {
                                    id_rol = Convert.ToInt32(reader["id_rol"]),
                                    nombre_rol = reader["nombre_rol"].ToString()
                                },
                                telefono_user = reader["telefono_user"].ToString(),
                                direccion_user = reader["direccion_user"].ToString(),
                                localidad_user = reader["localidad_user"].ToString(),
                                provincia_user = reader["provincia_user"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                    "Ocurrió un error al buscar los usuarios:\n\n" + ex.ToString(),
                    "Error de Base de Datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    lista = new List<Usuario>();
                }
            }
            return lista;
        }

        public List<Usuario> BuscarUsuariosGeneral(string busqueda)
        {
            List<Usuario> lista = new List<Usuario>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PROC_BUSCAR_USUARIO", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@busqueda_general", busqueda);

                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                id_user = Convert.ToInt32(reader["id_user"]),
                                apellido = reader["apellido"].ToString(),
                                nombre = reader["nombre"].ToString(),
                                dni = Convert.ToInt32(reader["dni"]),
                                mail = reader["mail"].ToString(),
                                username = reader["username"].ToString(),
                                pass = reader["pass"].ToString(),
                                baja_user = Convert.ToBoolean(reader["baja_user"]),
                                objRoles = new Roles()
                                {
                                    id_rol = Convert.ToInt32(reader["id_rol"]),
                                    nombre_rol = reader["nombre_rol"].ToString()
                                },
                                telefono_user = reader["telefono_user"].ToString(),
                                direccion_user = reader["direccion_user"].ToString(),
                                localidad_user = reader["localidad_user"].ToString(),
                                provincia_user = reader["provincia_user"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                    "Ocurrió un error al buscar los usuarios:\n\n" + ex.ToString(),
                    "Error de Base de Datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    lista = new List<Usuario>();
                }
            }
            return lista;
        }


        public int Registrar(Usuario obj, out string Mensaje)
        {
            int idusuariogenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("PROC_REGISTRAR_USUARIO", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("nombre", obj.nombre);
                    cmd.Parameters.AddWithValue("apellido", obj.apellido);
                    cmd.Parameters.AddWithValue("dni", obj.dni);
                    cmd.Parameters.AddWithValue("mail", obj.mail);
                    cmd.Parameters.AddWithValue("username", obj.username);
                    cmd.Parameters.AddWithValue("pass", obj.pass);
                    cmd.Parameters.AddWithValue("baja_user", obj.baja_user);
                    cmd.Parameters.AddWithValue("id_rol", obj.objRoles.id_rol); // Asumiendo que Roles tiene id_rol
                    cmd.Parameters.AddWithValue("telefono_user", obj.telefono_user);
                    cmd.Parameters.AddWithValue("direccion_user", obj.direccion_user);
                    cmd.Parameters.AddWithValue("localidad_user", obj.localidad_user);
                    cmd.Parameters.AddWithValue("provincia_user", obj.provincia_user);

                    cmd.Parameters.Add("id_user_resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    idusuariogenerado = Convert.ToInt32(cmd.Parameters["id_user_resultado"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idusuariogenerado = 0;
                Mensaje = ex.Message;
            }

            return idusuariogenerado;
        }

        public bool Editar(Usuario obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("PROC_EDITAR_USUARIO", oconexion);
                    cmd.Parameters.AddWithValue("id_user", obj.id_user);
                    cmd.Parameters.AddWithValue("nombre", obj.nombre);
                    cmd.Parameters.AddWithValue("apellido", obj.apellido);
                    cmd.Parameters.AddWithValue("dni", obj.dni);
                    cmd.Parameters.AddWithValue("mail", obj.mail);
                    cmd.Parameters.AddWithValue("username", obj.username);
                    cmd.Parameters.AddWithValue("pass", obj.pass);
                    cmd.Parameters.AddWithValue("id_rol", obj.objRoles.id_rol); // Asumiendo que existe esta propiedad
                    cmd.Parameters.AddWithValue("baja_user", obj.baja_user);
                    cmd.Parameters.AddWithValue("telefono_user", obj.telefono_user);
                    cmd.Parameters.AddWithValue("direccion_user", obj.direccion_user);
                    cmd.Parameters.AddWithValue("localidad_user", obj.localidad_user);
                    cmd.Parameters.AddWithValue("provincia_user", obj.provincia_user);

                    cmd.Parameters.Add("respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["respuesta"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }
    }
}
