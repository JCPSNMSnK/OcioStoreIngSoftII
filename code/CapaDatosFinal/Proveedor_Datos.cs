using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class Proveedor_Datos
    {
        // Método para listar todos los proveedores (activos e inactivos)
        public List<Proveedor> Listar()
        {
            List<Proveedor> lista = new List<Proveedor>();

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    // 1. MODIFICACIÓN: Incluir la columna 'baja_proveedor' en el SELECT
                    SqlCommand cmd = new SqlCommand("SELECT id_proveedor, nombre_proveedor, telefono_proveedor, cuit_proveedor, baja_proveedor FROM Proveedores", oconexion);
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
                                // 2. MODIFICACIÓN: Leer y mapear el nuevo campo
                                baja_proveedor = Convert.ToBoolean(dr["baja_proveedor"])
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

        // Método para listar SOLO los proveedores activos (llamando al SP)
        public List<Proveedor> ListarActivos()
        {
            List<Proveedor> lista = new List<Proveedor>();

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    // Llamar al nuevo procedimiento almacenado
                    SqlCommand cmd = new SqlCommand("PROC_LISTAR_PROVEEDORES_ACTIVOS", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

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
                                cuit_proveedor = dr["cuit_proveedor"].ToString()
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

                    // AÑADIDO: Parámetro para el estado de baja lógica
                    // Este es el campo más importante. Se mapea directamente desde la entidad C#
                    cmd.Parameters.AddWithValue("baja_proveedor", obj.baja_proveedor);

                    // Parámetro de salida
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    mensaje = cmd.Parameters["mensaje"].Value.ToString();

                    // La lógica del SP en SQL Server ahora devuelve un mensaje de éxito
                    // para la modificación o para la baja.
                    resultado = mensaje.Contains("éxito") || mensaje.Contains("exitosamente");
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

        public List<Proveedor> BuscarProveedores(string busqueda, bool incluirInactivos)
        {
            List<Proveedor> lista = new List<Proveedor>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PROC_BUSCAR_PROVEEDORES", oConexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    string textoBuscar = busqueda?.Trim();

                    if (string.IsNullOrWhiteSpace(textoBuscar))
                    {
                        // Si está vacío, mandamos todo en NULL para que traiga todo
                        cmd.Parameters.AddWithValue("@nombre_proveedor", DBNull.Value);
                        cmd.Parameters.AddWithValue("@cuit_proveedor", DBNull.Value);
                    }
                    else
                    {
                        // Verificamos si parece un CUIT (solo números y guiones)
                        // Quitamos los guiones para ver si lo que queda son solo números
                        string soloNumeros = textoBuscar.Replace("-", "");
                        bool esNumeroOCuit = long.TryParse(soloNumeros, out _);

                        if (esNumeroOCuit)
                        {
                            // Lo mandamos al parámetro de CUIT
                            cmd.Parameters.AddWithValue("@cuit_proveedor", textoBuscar);
                            cmd.Parameters.AddWithValue("@nombre_proveedor", DBNull.Value); // Nombre en NULL
                        }
                        else
                        {
                            // Lo mandamos al parámetro de Nombre
                            cmd.Parameters.AddWithValue("@nombre_proveedor", textoBuscar);
                            cmd.Parameters.AddWithValue("@cuit_proveedor", DBNull.Value); // Cuit en NULL
                        }
                    }
                    cmd.Parameters.AddWithValue("@telefono_proveedor", DBNull.Value);
                    cmd.Parameters.AddWithValue("@incluir_inactivos", incluirInactivos);

                    oConexion.Open();

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
                                baja_proveedor = Convert.ToBoolean(dr["baja_proveedor"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Proveedor>();
                    throw ex;
                }
            }
            return lista;
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
                            // Usamos el constructor que creamos en la entidad Proveedor
                            proveedor = new Proveedor(
                                id: Convert.ToInt32(reader["id_proveedor"]),
                                nombre: reader["nombre_proveedor"].ToString(),
                                telefono: reader["telefono_proveedor"].ToString(),
                                cuit: reader["cuit_proveedor"].ToString(),
                                baja: Convert.ToBoolean(reader["baja_proveedor"]) // <-- AÑADIDO: Lectura del nuevo campo BIT
                            );
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    // Es buena práctica usar un log aquí para registrar 'ex'
                    proveedor = null;
                }
            }
            return proveedor;
        }
    }
}