using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CapaEntidades;

namespace CapaDatos
{
    public class Compras_Datos
    {
        // Método para registrar una compra completa en una sola transacción.
        public int Registrar(Compra objCompra, out string mensaje)
        {
            int idCompraGenerada = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("PROC_REGISTRAR_COMPRA_TRANSACCION", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Creamos un DataTable para enviar los detalles de la compra a SQL Server
                    DataTable dtDetalles = new DataTable();
                    dtDetalles.Columns.Add("id_producto", typeof(int));
                    dtDetalles.Columns.Add("cantidad", typeof(int));
                    dtDetalles.Columns.Add("precio_unitario", typeof(decimal));

                    // Llenamos el DataTable con los datos de los detalles de la compra
                    foreach (DetalleCompra dc in objCompra.detalles)
                    {
                        dtDetalles.Rows.Add(new object[] { dc.objProducto.id_producto, dc.cantidad, dc.precio_unitario });
                    }

                    // Asignamos los parámetros del procedimiento almacenado
                    cmd.Parameters.AddWithValue("@id_proveedor", objCompra.objProveedor.id_proveedor);
                    cmd.Parameters.AddWithValue("@total", objCompra.total);
                    // Pasamos el DataTable como un parámetro de tipo tabla
                    cmd.Parameters.AddWithValue("@detalles_compra", dtDetalles);

                    // Parámetros de salida del procedimiento
                    cmd.Parameters.Add("@id_compra_generado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    idCompraGenerada = Convert.ToInt32(cmd.Parameters["@id_compra_generado"].Value);
                    mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idCompraGenerada = 0;
                mensaje = "Error en la capa de datos: " + ex.Message;
            }

            return idCompraGenerada;
        }

        public List<Compra> Listar()
        {
            List<Compra> lista = new List<Compra>();
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    // Se utiliza una consulta JOIN para obtener los datos de compra, usuario y proveedor
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("SELECT c.id_compra, c.fecha_compra, c.total,");
                    sb.AppendLine("p.id_proveedor, p.nombre_proveedor, p.baja_proveedor"); // MODIFICACIÓN: AÑADIR baja_proveedor
                    sb.AppendLine("FROM Compras c");
                    sb.AppendLine("INNER JOIN Proveedores p ON c.id_proveedor = p.id_proveedor;");

                    SqlCommand cmd = new SqlCommand(sb.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Compra()
                            {
                                id_compra = Convert.ToInt32(dr["id_compra"]),
                                fecha_compra = Convert.ToDateTime(dr["fecha_compra"]),
                                total = Convert.ToDecimal(dr["total"]),
                                objProveedor = new Proveedor()
                                {
                                    id_proveedor = Convert.ToInt32(dr["id_proveedor"]),
                                    nombre_proveedor = dr["nombre_proveedor"].ToString(),
                                    baja_proveedor = Convert.ToBoolean(dr["baja_proveedor"]) // MODIFICACIÓN: Leer y mapear el estado de baja
                                }
                            });
                        }
                    }
                }
            }
            catch (Exception)
            {
                lista = new List<Compra>();
            }
            return lista;
        }

        public List<Compra> Listar(string fecha = null, int idProveedor = 0)
        {
            List<Compra> lista = new List<Compra>();

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    StringBuilder sb = new StringBuilder();

                    // 1. CORRECCIÓN: Quitamos u.nombre y Usuarios
                    // 2. PROTECCIÓN: Usamos ISNULL en baja_proveedor por si acaso (basado en la imagen)
                    sb.AppendLine("SELECT c.id_compra, c.fecha_compra, c.total,");
                    sb.AppendLine("p.id_proveedor, p.nombre_proveedor, ISNULL(p.baja_proveedor, 0) as baja_proveedor");
                    sb.AppendLine("FROM Compras c");

                    // 3. CORRECCIÓN: Eliminamos la línea "INNER JOIN Usuarios..." que causa el error
                    sb.AppendLine("INNER JOIN Proveedores p ON c.id_proveedor = p.id_proveedor");

                    // ... (El resto de la lógica del WHERE se mantiene igual) ...
                    bool hayFiltro = false;
                    if (!string.IsNullOrEmpty(fecha))
                    {
                        sb.AppendLine("WHERE CONVERT(date, c.fecha_compra) = CONVERT(date, @fecha)");
                        hayFiltro = true;
                    }
                    if (idProveedor != 0)
                    {
                        // Nota: Corregimos la lógica del AND aquí por si acaso
                        if (hayFiltro)
                            sb.AppendLine("AND p.id_proveedor = @idProveedor");
                        else
                            sb.AppendLine("WHERE p.id_proveedor = @idProveedor");
                    }

                    SqlCommand cmd = new SqlCommand(sb.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    if (!string.IsNullOrEmpty(fecha)) cmd.Parameters.AddWithValue("@fecha", fecha);
                    if (idProveedor != 0) cmd.Parameters.AddWithValue("@idProveedor", idProveedor);

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Compra()
                            {
                                id_compra = Convert.ToInt32(dr["id_compra"]),
                                fecha_compra = Convert.ToDateTime(dr["fecha_compra"]),
                                total = Convert.ToDecimal(dr["total"]),

                                // Eliminamos el mapeo de objUsuario

                                objProveedor = new Proveedor()
                                {
                                    id_proveedor = Convert.ToInt32(dr["id_proveedor"]),
                                    nombre_proveedor = dr["nombre_proveedor"].ToString(),
                                    // Lectura segura
                                    baja_proveedor = Convert.ToBoolean(dr["baja_proveedor"])
                                }
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // IMPORTANTE: Descomente esto si sigue sin ver datos para ver el error real
                System.Windows.Forms.MessageBox.Show("Error SQL: " + ex.Message);
                lista = new List<Compra>();
            }
            return lista;
        }
        // Nuevo método para buscar compras de forma general
        // Nuevo método para buscar compras de forma general
        public List<Compra> BuscarComprasGeneral(string filtro)
        {
            List<Compra> lista = new List<Compra>();
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    StringBuilder sb = new StringBuilder();

                    // 1. CORRECCIÓN: Quitamos referencia a Usuarios y protegemos el booleano
                    sb.AppendLine("SELECT c.id_compra, c.fecha_compra, c.total,");
                    sb.AppendLine("p.id_proveedor, p.nombre_proveedor, ISNULL(p.baja_proveedor, 0) as baja_proveedor");
                    sb.AppendLine("FROM Compras c");

                    // 2. CORRECCIÓN: Eliminamos el JOIN con Usuarios
                    sb.AppendLine("INNER JOIN Proveedores p ON c.id_proveedor = p.id_proveedor");

                    if (!string.IsNullOrEmpty(filtro))
                    {
                        // 3. CORRECCIÓN: Quitamos el filtro por nombre de usuario (u.nombre)
                        sb.AppendLine("WHERE p.nombre_proveedor LIKE @filtro");
                    }

                    SqlCommand cmd = new SqlCommand(sb.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    if (!string.IsNullOrEmpty(filtro))
                    {
                        cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                    }

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Compra()
                            {
                                id_compra = Convert.ToInt32(dr["id_compra"]),
                                fecha_compra = Convert.ToDateTime(dr["fecha_compra"]),
                                total = Convert.ToDecimal(dr["total"]),

                                // No mapeamos usuario

                                objProveedor = new Proveedor()
                                {
                                    id_proveedor = Convert.ToInt32(dr["id_proveedor"]),
                                    nombre_proveedor = dr["nombre_proveedor"].ToString(),
                                    // Lectura segura
                                    baja_proveedor = Convert.ToBoolean(dr["baja_proveedor"])
                                }
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Descomentar para depurar si es necesario
                // System.Windows.Forms.MessageBox.Show("Error en Búsqueda: " + ex.Message);
                lista = new List<Compra>();
            }
            return lista;
        }



        // Nuevo método para obtener los detalles de una compra específica
        public Compra ObtenerDetalleCompra(int idCompra, out string mensaje)
        {
            // Inicializar a null si la compra no existe
            Compra objCompra = null;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    StringBuilder sb = new StringBuilder();

                    // 1. PRIMERA CONSULTA: Cabecera de Compra y Proveedor (incluye baja_proveedor)
                    sb.AppendLine("SELECT c.id_compra, c.fecha_compra, c.total, ");
                    sb.AppendLine("p.id_proveedor, p.nombre_proveedor, p.baja_proveedor "); // <-- AÑADIDO: baja_proveedor
                    sb.AppendLine("FROM Compras c INNER JOIN Proveedores p ON c.id_proveedor = p.id_proveedor ");
                    sb.AppendLine("WHERE c.id_compra = @idCompra;");

                    // 2. SEGUNDA CONSULTA: Detalles de Compra y Producto
                    // Asumimos que la tabla DetalleCompra tiene un campo id_producto que se une a Productos
                    sb.AppendLine("SELECT dc.id_producto, dc.cantidad, dc.precio_unitario, pr.nombre_producto, pr.cod_producto ");
                    sb.AppendLine("FROM DetallesCompras dc INNER JOIN Productos pr ON dc.id_producto = pr.id_producto ");
                    sb.AppendLine("WHERE dc.id_compra = @idCompra;");

                    SqlCommand cmd = new SqlCommand(sb.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@idCompra", idCompra);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        // 1. Lectura del primer resultado (Cabecera y Proveedor)
                        if (dr.Read())
                        {
                            objCompra = new Compra()
                            {
                                id_compra = Convert.ToInt32(dr["id_compra"]),
                                fecha_compra = Convert.ToDateTime(dr["fecha_compra"]),
                                total = Convert.ToDecimal(dr["total"]),
                                objProveedor = new Proveedor()
                                {
                                    id_proveedor = Convert.ToInt32(dr["id_proveedor"]),
                                    nombre_proveedor = dr["nombre_proveedor"].ToString(),
                                    baja_proveedor = Convert.ToBoolean(dr["baja_proveedor"]) // Mapeo de la baja del proveedor
                                },
                                detalles = new List<DetalleCompra>() // Inicializar la lista de detalles
                            };
                        }

                        // 2. Mover al siguiente conjunto de resultados (Detalles de Compra)
                        if (objCompra != null && dr.NextResult())
                        {
                            while (dr.Read())
                            {
                                objCompra.detalles.Add(new DetalleCompra()
                                {
                                    cantidad = Convert.ToInt32(dr["cantidad"]),
                                    precio_unitario = Convert.ToDecimal(dr["precio_unitario"]),

                                    // Mapeo del Producto asociado al detalle
                                    objProducto = new Producto()
                                    {
                                        id_producto = Convert.ToInt32(dr["id_producto"]),
                                        nombre_producto = dr["nombre_producto"].ToString(),
                                        cod_producto = Convert.ToInt32(dr["cod_producto"])
                                    }
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                objCompra = null;
                mensaje = "Error al obtener detalles de la compra: " + ex.Message;
            }
            return objCompra;
        }

        // Nuevo método para obtener los detalles de los productos de una compra
        public List<DetalleCompra> ObtenerProductosCompra(int idCompra)
        {
            List<DetalleCompra> lista = new List<DetalleCompra>();
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("SELECT dc.id_producto, dc.cantidad, dc.precio_unitario, p.nombre_producto");
                    sb.AppendLine("FROM DetallesCompras dc");
                    sb.AppendLine("INNER JOIN Productos p ON dc.id_producto = p.id_producto");
                    sb.AppendLine("WHERE dc.id_compra = @idCompra");

                    SqlCommand cmd = new SqlCommand(sb.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@idCompra", idCompra);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new DetalleCompra()
                            {
                                objProducto = new Producto()
                                {
                                    id_producto = Convert.ToInt32(dr["id_producto"]),
                                    nombre_producto = dr["nombre_producto"].ToString()
                                },
                                cantidad = Convert.ToInt32(dr["cantidad"]),
                                precio_unitario = Convert.ToDecimal(dr["precio_unitario"])
                            });
                        }
                    }
                }
            }
            catch (Exception)
            {
                lista = new List<DetalleCompra>();
            }
            return lista;
        }
    }
}