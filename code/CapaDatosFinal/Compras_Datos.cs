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
                    cmd.Parameters.AddWithValue("@total_compra", objCompra.total);
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
                    sb.AppendLine("SELECT c.id_compra, c.fecha_compra, c.total_compra,");
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
                                total = Convert.ToDecimal(dr["total_compra"]),
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

                    // MODIFICACIÓN DE LA CONSULTA SQL: Añadir p.baja_proveedor
                    sb.AppendLine("SELECT c.id_compra, c.fecha_compra, c.total_compra, u.nombre AS nombre_usuario,");
                    sb.AppendLine("p.id_proveedor, p.nombre_proveedor, p.baja_proveedor"); // <-- AÑADIDO: id_proveedor y baja_proveedor
                    sb.AppendLine("FROM Compras c");
                    sb.AppendLine("INNER JOIN Usuarios u ON c.id_usuario = u.id_user");
                    sb.AppendLine("INNER JOIN Proveedores p ON c.id_proveedor = p.id_proveedor");

                    // ... (Cláusula WHERE dinámica sigue igual) ...

                    // Construimos la cláusula WHERE dinámicamente
                    bool hayFiltro = false;

                    if (!string.IsNullOrEmpty(fecha))
                    {
                        sb.AppendLine("WHERE CONVERT(date, c.fecha_compra) = CONVERT(date, @fecha)");
                        hayFiltro = true;
                    }

                    if (idProveedor != 0)
                    {
                        if (!hayFiltro)
                        {
                            sb.AppendLine("WHERE p.id_proveedor = @idProveedor");
                        }
                        else
                        {
                            sb.AppendLine("AND p.id_proveedor = @idProveedor");
                        }
                    }

                    SqlCommand cmd = new SqlCommand(sb.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    // ... (Añadimos los parámetros de forma segura sigue igual) ...
                    if (!string.IsNullOrEmpty(fecha))
                    {
                        cmd.Parameters.AddWithValue("@fecha", fecha);
                    }
                    if (idProveedor != 0)
                    {
                        cmd.Parameters.AddWithValue("@idProveedor", idProveedor);
                    }

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            // Nota: Si la entidad Compra tiene objUsuario, necesitarías mapearlo también.

                            lista.Add(new Compra()
                            {
                                id_compra = Convert.ToInt32(dr["id_compra"]),
                                fecha_compra = Convert.ToDateTime(dr["fecha_compra"]),
                                total = Convert.ToDecimal(dr["total_compra"]),

                                // Mapeo del Proveedor
                                objProveedor = new Proveedor()
                                {
                                    // CORRECCIÓN/AÑADIDO: Mapeamos el ID y la baja lógica
                                    id_proveedor = Convert.ToInt32(dr["id_proveedor"]),
                                    nombre_proveedor = dr["nombre_proveedor"].ToString(),
                                    baja_proveedor = Convert.ToBoolean(dr["baja_proveedor"]) // <-- AÑADIDO: Lectura del estado de baja
                                }

                                // Si tu entidad Compra tiene un objeto Usuario:
                                /*
                                objUsuario = new Usuario()
                                {
                                    nombre = dr["nombre_usuario"].ToString()
                                }
                                */
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

                    // MODIFICACIÓN DE LA CONSULTA SQL: Añadir id_proveedor y baja_proveedor
                    sb.AppendLine("SELECT c.id_compra, c.fecha_compra, c.total_compra, u.nombre AS nombre_usuario,");
                    sb.AppendLine("p.id_proveedor, p.nombre_proveedor, p.baja_proveedor"); // <-- AÑADIDOS
                    sb.AppendLine("FROM Compras c");
                    sb.AppendLine("INNER JOIN Usuarios u ON c.id_usuario = u.id_user");
                    sb.AppendLine("INNER JOIN Proveedores p ON c.id_proveedor = p.id_proveedor");

                    // Si el filtro no está vacío, agregamos la cláusula WHERE
                    if (!string.IsNullOrEmpty(filtro))
                    {
                        // NOTA: Se asume que el filtro debe ser LIKE '%' + @filtro + '%' para funcionar correctamente
                        sb.AppendLine("WHERE p.nombre_proveedor LIKE @filtro OR u.nombre LIKE @filtro");
                    }

                    SqlCommand cmd = new SqlCommand(sb.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    // Si el filtro no está vacío, agregamos el parámetro
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
                                total = Convert.ToDecimal(dr["total_compra"]),
                                objProveedor = new Proveedor()
                                {
                                    // AÑADIDO: Mapeamos el ID y la Baja Lógica
                                    id_proveedor = Convert.ToInt32(dr["id_proveedor"]),
                                    nombre_proveedor = dr["nombre_proveedor"].ToString(),
                                    baja_proveedor = Convert.ToBoolean(dr["baja_proveedor"]) // <-- AÑADIDO: Lectura del estado de baja
                                }
                                // Si tu entidad Compra tiene objUsuario, podrías mapearlo aquí
                                /*
                                objUsuario = new Usuario()
                                {
                                    nombre = dr["nombre_usuario"].ToString()
                                }
                                */
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
                    sb.AppendLine("SELECT c.id_compra, c.fecha_compra, c.total_compra, ");
                    sb.AppendLine("p.id_proveedor, p.nombre_proveedor, p.baja_proveedor "); // <-- AÑADIDO: baja_proveedor
                    sb.AppendLine("FROM Compras c INNER JOIN Proveedores p ON c.id_proveedor = p.id_proveedor ");
                    sb.AppendLine("WHERE c.id_compra = @idCompra;");

                    // 2. SEGUNDA CONSULTA: Detalles de Compra y Producto
                    // Asumimos que la tabla DetalleCompra tiene un campo id_producto que se une a Productos
                    sb.AppendLine("SELECT dc.id_producto, dc.cantidad, dc.precio_unitario, pr.nombre_producto, pr.cod_producto ");
                    sb.AppendLine("FROM DetalleCompra dc INNER JOIN Productos pr ON dc.id_producto = pr.id_producto ");
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
                                total = Convert.ToDecimal(dr["total_compra"]),
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
                    sb.AppendLine("FROM DetalleCompra dc");
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