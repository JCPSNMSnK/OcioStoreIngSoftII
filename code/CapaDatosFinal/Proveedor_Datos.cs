using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class Proveedor_Datos
    {
        // Método para listar todos los proveedores
        public List<Proveedor> Listar()
        {
            List<Proveedor> lista = new List<Proveedor>();

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SELECT id_proveedor, nombre_proveedor, telefono_proveedor, cuit_proveedor FROM Proveedores", oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Proveedor()
                            {
                                id_proveedor = Convert.ToInt32(dr["id_proveedor"]),
                                nombre_proveedor = dr["nombre_proveedor"].ToString(),
                                telefono_proveedor = dr["telefono_proveedor"].ToString(),
                                cuit_proveedor = dr["cuit_proveedor"].ToString(),
                            });
                        }
                    }
                }
            }
            catch (Exception)
            {
                lista = new List<Proveedor>();
            }

            return lista;
        }

        // Método para registrar un nuevo proveedor
        public int Registrar(Proveedor obj, out string mensaje)
        {
            int idProveedorGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("PROC_REGISTRAR_PROVEEDOR", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("nombre_proveedor", obj.nombre_proveedor);
                    cmd.Parameters.AddWithValue("telefono_proveedor", obj.telefono_proveedor);
                    cmd.Parameters.AddWithValue("cuit_proveedor", obj.cuit_proveedor);

                    // Parámetros de salida
                    cmd.Parameters.Add("id_proveedor_generado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    idProveedorGenerado = Convert.ToInt32(cmd.Parameters["id_proveedor_generado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idProveedorGenerado = 0;
                mensaje = "Error al registrar en la capa de datos: " + ex.Message;
            }

            return idProveedorGenerado;
        }

        // Método para editar un proveedor existente
        public bool Editar(Proveedor obj, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("PROC_MODIFICAR_PROVEEDOR", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("id_proveedor", obj.id_proveedor);
                    cmd.Parameters.AddWithValue("nombre_proveedor", obj.nombre_proveedor);
                    cmd.Parameters.AddWithValue("telefono_proveedor", obj.telefono_proveedor);
                    cmd.Parameters.AddWithValue("cuit_proveedor", obj.cuit_proveedor);

                    // Parámetro de salida
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                    resultado = mensaje.Contains("exitosamente");
                }
            }
            catch (Exception ex)
            {
                resultado = false;
                mensaje = "Error al editar en la capa de datos: " + ex.Message;
            }

            return resultado;
        }

        // Método para verificar la existencia de un CUIT, excluyendo un ID específico
        public bool VerificarExistencia(string cuit, int idProveedor)
        {
            bool existe = false;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    // La consulta verifica si el CUIT existe y si el ID del registro no es el que estamos editando
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Proveedores WHERE cuit_proveedor = @cuit AND id_proveedor != @id", oconexion);
                    cmd.Parameters.AddWithValue("@cuit", cuit);
                    cmd.Parameters.AddWithValue("@id", idProveedor);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    int count = (int)cmd.ExecuteScalar();
                    existe = count > 0;
                }
            }
            catch (Exception)
            {
                existe = false;
            }

            return existe;
        }

        public Proveedor ObtenerProveedorPorId(int idProveedor)
        {
            Proveedor proveedor = null;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PROC_OBTENER_PROVEEDOR_POR_ID", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Agregar el parámetro con el ID del proveedor
                    cmd.Parameters.AddWithValue("@id_proveedor", idProveedor);

                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Leer la única fila que se espera del resultado
                        if (reader.Read())
                        {
                            proveedor = new Proveedor()
                            {
                                id_proveedor = Convert.ToInt32(reader["id_proveedor"]),
                                nombre_proveedor = reader["nombre_proveedor"].ToString(),
                                cuit_proveedor = reader["cuit_proveedor"].ToString(),
                                telefono_proveedor = reader["telefono_proveedor"].ToString()
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones: Puedes loguear el error o lanzarlo a una capa superior.
                    // Aquí, simplemente devolvemos null para indicar que no se encontró el proveedor.
                    proveedor = null;
                }
            }
            return proveedor;
        }
    }
}