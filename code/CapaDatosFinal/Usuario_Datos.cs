using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidades;
using System.Collections;
using System.Reflection.Emit;

namespace CapaDatos
{
    public class Usuario_Datos
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT u.id_user, u.apellido, u.nombre, u.dni, u.mail, u.username, u.pass, u.baja_user, r.id_rol, r.nombre_rol, r.descripcion");
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
                                }
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Usuario>();
                }
            }
            return lista;
        }

        //public List<Usuario> BuscarUsuarios(string criterio)
        //{
        //    List<Usuario> lista = new List<Usuario>();

        //    using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
        //    {
        //        try
        //        {
        //            StringBuilder query = new StringBuilder();
        //            query.AppendLine("select u.id,u.nombre,u.apellido,u.zipcode,u.domicilio,u.email,u.usuario,u.pass,p.id_perfiles,p.descripcion,u.baja from usuarios u");
        //            query.AppendLine("inner join perfiles p on p.id_perfiles = u.perfil_id");
        //            query.AppendLine("where u.nombre LIKE @criterio OR u.apellido LIKE @criterio OR u.email LIKE @criterio OR u.usuario LIKE @criterio OR u.domicilio LIKE @criterio OR u.zipcode LIKE @criterio;");

        //            SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
        //            cmd.CommandType = CommandType.Text;
        //            cmd.Parameters.AddWithValue("@criterio", "%" + criterio + "%");

        //            oconexion.Open();

        //            using (SqlDataReader dataReader = cmd.ExecuteReader())
        //            {
        //                while (dataReader.Read())
        //                {
        //                    lista.Add(new Usuario()
        //                    {
        //                        id_usuario = Convert.ToInt32(dataReader["id"]),
        //                        nombre = dataReader["nombre"].ToString(),
        //                        apellido = dataReader["apellido"].ToString(),
        //                        CP = Convert.ToInt32(dataReader["zipcode"]),
        //                        domicilio = dataReader["domicilio"].ToString(),
        //                        email = dataReader["email"].ToString(),
        //                        user = dataReader["usuario"].ToString(),
        //                        pass = dataReader["pass"].ToString(),
        //                        objPerfil = new Perfil() { id_perfil = Convert.ToInt32(dataReader["id_perfiles"]), descripcion = dataReader["descripcion"].ToString() },
        //                        baja = Convert.ToBoolean(dataReader["baja"]),
        //                    });
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            lista = new List<Usuario>();
        //        }
        //    }
        //    return lista;
        //}

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
                    cmd.Parameters.AddWithValue("id_rol", obj.objRoles.id_rol); // Asumiendo que existe esta propiedad
                    cmd.Parameters.AddWithValue("baja_user", obj.baja_user);

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
