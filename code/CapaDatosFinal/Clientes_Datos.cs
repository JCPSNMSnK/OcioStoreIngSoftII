using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class Cliente_Datos
    {
        public int Registrar(Cliente obj, out string mensaje)
        {
            int idClienteGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("PROC_REGISTRAR_CLIENTE", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros de entrada
                    cmd.Parameters.AddWithValue("dni_cliente", obj.dni_cliente);
                    cmd.Parameters.AddWithValue("nombre_cliente", obj.nombre_cliente);
                    cmd.Parameters.AddWithValue("apellido_cliente", obj.apellido_cliente);
                    cmd.Parameters.AddWithValue("telefono_cliente", obj.telefono_cliente);
                    cmd.Parameters.AddWithValue("email_cliente", obj.email_cliente);
                    cmd.Parameters.AddWithValue("direccion_cliente", obj.direccion_cliente);
                    cmd.Parameters.AddWithValue("localidad_cliente", obj.localidad_cliente);
                    cmd.Parameters.AddWithValue("provincia_cliente", obj.provincia_cliente);

                    // Parámetros de salida
                    cmd.Parameters.Add("id_cliente_generado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    idClienteGenerado = Convert.ToInt32(cmd.Parameters["id_cliente_generado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idClienteGenerado = 0;
                mensaje = "Error en la capa de datos: " + ex.Message;
            }

            return idClienteGenerado;
        }
        public bool Editar(Cliente obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("PROC_MODIFICAR_CLIENTE", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros
                    cmd.Parameters.AddWithValue("id_cliente", obj.id_cliente);
                    cmd.Parameters.AddWithValue("nombre_cliente", obj.nombre_cliente);
                    cmd.Parameters.AddWithValue("apellido_cliente", obj.apellido_cliente);
                    cmd.Parameters.AddWithValue("telefono_cliente", obj.telefono_cliente);
                    cmd.Parameters.AddWithValue("email_cliente", obj.email_cliente);
                    cmd.Parameters.AddWithValue("direccion_cliente", obj.direccion_cliente);
                    cmd.Parameters.AddWithValue("localidad_cliente", obj.localidad_cliente);
                    cmd.Parameters.AddWithValue("provincia_cliente", obj.provincia_cliente);

                    // Parámetro de salida
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                    respuesta = mensaje.Contains("exitosamente"); // Asumimos éxito si el mensaje contiene esta palabra
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = "Error en la capa de datos: " + ex.Message;
            }

            return respuesta;
        }
        public List<Cliente> Buscar(int dni = 0, string nombre = null, string apellido = null, string localidad = null, string provincia = null, string email = null, string telefono = null)
        {
            List<Cliente> lista = new List<Cliente>();

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("PROC_BUSCAR_CLIENTE", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros de búsqueda (los valores nulos se manejarán en el Procedimiento Almacenado)
                    cmd.Parameters.AddWithValue("dni_cliente", dni);
                    cmd.Parameters.AddWithValue("nombre_cliente", nombre);
                    cmd.Parameters.AddWithValue("apellido_cliente", apellido);
                    cmd.Parameters.AddWithValue("localidad_cliente", localidad);
                    cmd.Parameters.AddWithValue("provincia_cliente", provincia);
                    cmd.Parameters.AddWithValue("email_cliente", email);
                    cmd.Parameters.AddWithValue("telefono_cliente", telefono);

                    oconexion.Open();

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            lista.Add(new Cliente()
                            {
                                id_cliente = Convert.ToInt32(dataReader["id_cliente"]),
                                dni_cliente = Convert.ToInt32(dataReader["dni_cliente"]),
                                nombre_cliente = dataReader["nombre_cliente"].ToString(),
                                apellido_cliente = dataReader["apellido_cliente"].ToString(),
                                telefono_cliente = dataReader["telefono_cliente"].ToString(),
                                email_cliente = dataReader["email_cliente"].ToString(),
                                direccion_cliente = dataReader["direccion_cliente"].ToString(),
                                localidad_cliente = dataReader["localidad_cliente"].ToString(),
                                provincia_cliente = dataReader["provincia_cliente"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lista = new List<Cliente>(); //lista vacia por error en la busqueda
            }

            return lista;
        }
    }
}