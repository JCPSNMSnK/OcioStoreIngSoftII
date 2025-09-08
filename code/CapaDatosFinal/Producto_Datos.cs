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
using System.Windows.Forms;

namespace CapaDatos
{
    public class Producto_Datos
    {
        public List<Producto> BuscarProductosGeneral(string busqueda)
        {
            var diccionarioProductos = new Dictionary<int, Producto>();
            List<Producto> lista = new List<Producto>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PROC_BUSCAR_PRODUCTO", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@busqueda_general", string.IsNullOrEmpty(busqueda) ? (object)DBNull.Value : busqueda);

                    oconexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idProducto = Convert.ToInt32(reader["id_producto"]);
                            Producto productoExistente;

                            if (!diccionarioProductos.TryGetValue(idProducto, out productoExistente))
                            {
                                productoExistente = new Producto()
                                {
                                    id_producto = Convert.ToInt32(reader["id_producto"]),
                                    nombre_producto = reader["nombre_producto"].ToString(),
                                    fechaIngreso = Convert.ToDateTime(reader["fechaIngreso"]),
                                    precioLista = Convert.ToDecimal(reader["precioLista"]),
                                    precioVenta = Convert.ToDecimal(reader["precioVenta"]),
                                    baja_producto = Convert.ToBoolean(reader["baja_producto"]),
                                    stock = Convert.ToInt32(reader["stock"]),
                                    stock_min = Convert.ToInt32(reader["stock_min"]),
                                    descripcion = reader["descripcion"].ToString(),
                                    cod_producto = reader["cod_producto"] == DBNull.Value ? 0 : Convert.ToInt32(reader["cod_producto"]),
                                    id_proveedor = reader["id_proveedor"] == DBNull.Value ? 0 : Convert.ToInt32(reader["id_proveedor"]),
                                    categorias = new List<Categoria>()
                                };
                                diccionarioProductos.Add(idProducto, productoExistente);
                            }
                            if (reader["id_categoria"] != DBNull.Value)
                            {
                                productoExistente.categorias.Add(new Categoria()
                                {
                                    id_categoria = Convert.ToInt32(reader["id_categoria"]),
                                    nombre_categoria = reader["nombre_categoria"].ToString()
                                });
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<Producto>();
                    throw;
                }
            }
            return diccionarioProductos.Values.ToList();
        }

        public List<Producto> Listar()//mostrarProductos
        {
            List<Producto> lista = new List<Producto>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.id_producto, p.nombre_producto, p.fechaIngreso, p.descripcion, p.precioLista, p.precioVenta,");
                    query.AppendLine("p.stock, p.stock_min, p.baja_producto, c.id_categoria, c.nombre_categoria, p.cod_producto, p.id_proveedor");
                    query.AppendLine("FROM Productos p ");
                    query.AppendLine("LEFT JOIN ProductosCategorias pc ON p.id_producto = pc.id_producto ");
                    query.AppendLine("LEFT JOIN Categorias c ON pc.id_categoria = c.id_categoria ");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dataReader = cmd.ExecuteReader())

                    {
                        while (dataReader.Read())
                        {
                            lista.Add(new Producto()
                            {

                                id_producto = Convert.ToInt32(dataReader["id_producto"]),
                                nombre_producto = dataReader["nombre_producto"].ToString(),
                                fechaIngreso = dataReader["fechaIngreso"] != DBNull.Value
                                ? Convert.ToDateTime(dataReader["fechaIngreso"])
                                : DateTime.Now,

                                precioLista = Convert.ToDecimal(dataReader["precioLista"]),
                                precioVenta = Convert.ToDecimal(dataReader["precioVenta"]),
                                baja_producto = Convert.ToBoolean(dataReader["baja_producto"]),
                                stock_min = Convert.ToInt32(dataReader["stock_min"]),
                                stock = Convert.ToInt32(dataReader["stock"]),
                                descripcion = dataReader["descripcion"] != DBNull.Value
                                    ? dataReader["descripcion"].ToString()
                                    : string.Empty,
                                cod_producto = Convert.ToInt32(dataReader["cod_producto"]),
                                id_proveedor = Convert.ToInt32(dataReader["id_proveedor"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {

                    lista = new List<Producto>();
                    string Mensaje = ex.Message;
                }
            }
            return lista;
        }

        public int Registrar(Producto obj, out string Mensaje)//crearProducto
        {
            int id_producto_generado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("PROC_REGISTRAR_PRODUCTO", oconexion);
                    cmd.Parameters.AddWithValue("nombre_producto", obj.nombre_producto);
                    cmd.Parameters.AddWithValue("fechaIngreso", obj.fechaIngreso);
                    cmd.Parameters.AddWithValue("precioLista", obj.precioLista);
                    cmd.Parameters.AddWithValue("precioVenta", obj.precioVenta);
                    cmd.Parameters.AddWithValue("baja_producto", obj.baja_producto);
                    cmd.Parameters.AddWithValue("stock", obj.stock);
                    cmd.Parameters.AddWithValue("stock_min", obj.stock_min);
                    cmd.Parameters.AddWithValue("descripcion", obj.descripcion);

                    cmd.Parameters.AddWithValue("cod_producto", obj.cod_producto);
                    cmd.Parameters.AddWithValue("id_proveedor", obj.id_proveedor);

                    cmd.Parameters.Add("id_producto_resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    SqlCommand cmdCategorias = new SqlCommand("PROC_ACTUALIZAR_CATEGORIAS_PRODUCTO", oconexion);
                    cmdCategorias.CommandType = CommandType.StoredProcedure;
                    cmdCategorias.Parameters.AddWithValue("@id_producto", obj.id_producto);

                    DataTable dtCategorias = new DataTable();
                    dtCategorias.Columns.Add("ID", typeof(int));
                    if (obj.categorias != null)
                    {
                        foreach (var cat in obj.categorias)
                        {
                            dtCategorias.Rows.Add(cat.id_categoria);
                        }
                    }
                    SqlParameter paramCategorias = cmdCategorias.Parameters.AddWithValue("@nuevas_categorias", dtCategorias);
                    paramCategorias.SqlDbType = SqlDbType.Structured;

                    cmdCategorias.ExecuteNonQuery();

                    id_producto_generado = Convert.ToInt32(cmd.Parameters["id_producto_resultado"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                id_producto_generado = 0;
                Mensaje = ex.Message;
            }

            return id_producto_generado;
        }

        
        public bool Editar(Producto obj, out string Mensaje)//modificarProducto
        {
            bool resultado = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("PROC_EDITAR_PRODUCTO", oconexion);
                    cmd.Parameters.AddWithValue("id_producto", obj.id_producto);
                    cmd.Parameters.AddWithValue("nombre_producto", obj.nombre_producto);
                    cmd.Parameters.AddWithValue("precioLista", obj.precioLista);
                    cmd.Parameters.AddWithValue("precioVenta", obj.precioVenta);
                    cmd.Parameters.AddWithValue("baja_producto", obj.baja_producto);
                    cmd.Parameters.AddWithValue("stock", obj.stock);
                    cmd.Parameters.AddWithValue("stock_min", obj.stock_min);
                    cmd.Parameters.AddWithValue("descripcion", obj.descripcion);
                    cmd.Parameters.AddWithValue("cod_producto", obj.cod_producto);
                    cmd.Parameters.AddWithValue("id_proveedor", obj.id_proveedor);

                    cmd.Parameters.Add("respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    SqlCommand cmdCategorias = new SqlCommand("PROC_ACTUALIZAR_CATEGORIAS_PRODUCTO", oconexion);
                    cmdCategorias.CommandType = CommandType.StoredProcedure;
                    cmdCategorias.Parameters.AddWithValue("@id_producto", obj.id_producto);

                    //Crea tabla de ids 
                    DataTable dtCategorias = new DataTable();
                    dtCategorias.Columns.Add("ID", typeof(int));
                    if (obj.categorias != null)
                    {
                        foreach (var cat in obj.categorias)
                        {
                            dtCategorias.Rows.Add(cat.id_categoria);
                        }
                    }
                    // Lo pasamos como un parámetro de tipo tabla
                    SqlParameter paramCategorias = cmdCategorias.Parameters.AddWithValue("@nuevas_categorias", dtCategorias);
                    paramCategorias.SqlDbType = SqlDbType.Structured;

                    cmdCategorias.ExecuteNonQuery();

                    resultado = Convert.ToBoolean(cmd.Parameters["respuesta"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                resultado = false;
                Mensaje = ex.Message;
            }

            return resultado;
        }
        

        public Producto obtenerProducto(int id_producto)
        {
            Producto productoObtenido = null;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("PROC_OBTENER_PRODUCTO_COMPLETO", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_producto", id_producto);

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        // 1. Leer el primer conjunto de resultados (datos del producto)
                        if (dr.Read())
                        {
                            productoObtenido = new Producto()
                            {
                                id_producto = Convert.ToInt32(dr["id_producto"]),
                                nombre_producto = dr["nombre_producto"].ToString(),
                                fechaIngreso = Convert.ToDateTime(dr["fechaIngreso"]),
                                precioLista = Convert.ToDecimal(dr["precioLista"]),
                                precioVenta = Convert.ToDecimal(dr["precioVenta"]),
                                baja_producto = Convert.ToBoolean(dr["baja_producto"]),
                                stock = Convert.ToInt32(dr["stock"]),
                                stock_min = Convert.ToInt32(dr["stock_min"]),
                                descripcion = dr["descripcion"].ToString(),
                                cod_producto = Convert.ToInt32(dr["cod_producto"]),
                                id_proveedor = Convert.ToInt32(dr["id_proveedor"]),

                                // Inicializar la lista de categorías
                                categorias = new List<Categoria>()
                            };
                        }

                        // 2. Mover al siguiente conjunto de resultados (categorías)
                        if (dr.NextResult())
                        {
                            while (dr.Read())
                            {
                                // Agregar cada categoría a la lista del producto
                                productoObtenido.categorias.Add(new Categoria()
                                {
                                    id_categoria = Convert.ToInt32(dr["id_categoria"]),
                                    nombre_categoria = dr["nombre_categoria"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                productoObtenido = null;
            }

            return productoObtenido;
        }


        public List<Producto> ListarProductosConStockBajo()
        {
            List<Producto> lista = new List<Producto>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Este SP debería seleccionar productos donde StockActual <= StockMinimo
                    string query = "EXEC PROC_LISTAR_PRODUCTOS_STOCK_BAJO";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Producto()
                            {
                                nombre_producto = reader["nombre_producto"].ToString(),
                                stock = Convert.ToInt32(reader["stock"]),
                                stock_min = Convert.ToInt32(reader["stock_min"])
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error desconocido al generar notificación de Stock Bajo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return lista;
                }
            }
            return lista;
        }
    }
}

