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

        // El método Listar ahora acepta todos los parámetros de búsqueda como opcionales
        public List<Producto> Listar(
            //out string mensaje,
            int? id_producto = null,
            string nombre_producto = null,
            DateTime? fechaIngreso = null,
            decimal? precioLista = null,
            decimal? precioVenta = null,
            bool? baja_producto = null,
            int? stock = null,
            int? stock_min = null,
            string descripcion = null,
            int? id_categoria = null, // Este id_categoria podría ser usado para filtrar la búsqueda inicial
            string nombre_categoria = null // Este nombre_categoria también para filtrar la búsqueda inicial
            
        )
        {
            // Usamos un Dictionary para almacenar los productos únicos por su ID
            // y luego convertiremos sus valores a una List<Producto>
            Dictionary<int, Producto> productosMap = new Dictionary<int, Producto>();
            //mensaje = string.Empty;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("BUSCAR_PRODUCTO", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Añadir todos los parámetros para el procedimiento almacenado
                    cmd.Parameters.AddWithValue("@id_producto", (object)id_producto ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@nombre_producto", (object)nombre_producto ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@fechaIngreso", (object)fechaIngreso ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@precioLista", (object)precioLista ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@precioVenta", (object)precioVenta ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@baja_producto", (object)baja_producto ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@stock", (object)stock ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@stock_min", (object)stock_min ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@descripcion", (object)descripcion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@id_categoria", (object)id_categoria ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@nombre_categoria", (object)nombre_categoria ?? DBNull.Value);

                    oconexion.Open();

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            int currentProductId = Convert.ToInt32(dataReader["id_producto"]);

                            // Verificar si el producto ya ha sido agregado al diccionario
                            if (!productosMap.ContainsKey(currentProductId))
                            {
                                // Si no está, crear una nueva instancia de Producto
                                Producto nuevoProducto = new Producto()
                                {
                                    id_producto = currentProductId,
                                    nombre_producto = dataReader["nombre_producto"].ToString(),
                                    fechaIngreso = dataReader["fechaIngreso"] != DBNull.Value
                                        ? Convert.ToDateTime(dataReader["fechaIngreso"])
                                        : DateTime.MinValue, // O un valor por defecto que prefieras

                                    descripcion = dataReader["descripcion"] != DBNull.Value
                                        ? dataReader["descripcion"].ToString()
                                        : string.Empty,

                                    precioLista = Convert.ToDecimal(dataReader["precioLista"]),
                                    precioVenta = Convert.ToDecimal(dataReader["precioVenta"]),
                                    stock = Convert.ToInt32(dataReader["stock"]),
                                    stock_min = Convert.ToInt32(dataReader["stock_min"]),
                                    baja_producto = Convert.ToBoolean(dataReader["baja_producto"]),
                                    // Inicializa la lista de categorías para este nuevo producto
                                    categoria = new List<Categoria>()
                                };
                                productosMap.Add(currentProductId, nuevoProducto);
                            }

                            // Obtener la instancia del producto (ya sea recién creada o existente)
                            Producto productoActual = productosMap[currentProductId];

                            // Añadir la categoría actual a la lista de categorías del producto
                            // Solo si la categoría no es nula (puede ocurrir si un producto no tiene categoría o el LEFT JOIN no encuentra match)
                            // Y si la categoría no ha sido ya agregada a la lista de este producto (para evitar duplicados si el SP devuelve múltiples filas para el mismo producto-categoría).
                            if (dataReader["id_categoria"] != DBNull.Value)
                            {
                                int currentCategoryId = Convert.ToInt32(dataReader["id_categoria"]);
                                // Verifica si esta categoría ya está en la lista del producto (por si el SP devuelve filas duplicadas o se repite la misma categoría por algún JOIN adicional)
                                if (!productoActual.categoria.Any(c => c.id_categoria == currentCategoryId))
                                {
                                    productoActual.categoria.Add(new Categoria()
                                    {
                                        id_categoria = currentCategoryId,
                                        nombre_categoria = dataReader["nombre_categoria"].ToString(),
                                        // Asegúrate de que baja_categoria de la categoría se incluya si es relevante
                                        baja_categoria = dataReader["baja_categoria"] != DBNull.Value ? Convert.ToBoolean(dataReader["baja_categoria"]) : false // Asume false si nulo
                                    });
                                }
                            }
                        }
                    }
                    //mensaje = "Búsqueda de productos realizada exitosamente.";
                }
                catch (Exception ex)
                {
                    productosMap.Clear(); // Limpia el diccionario en caso de error
                    String mensaje = "Error al listar productos: " + ex.Message;
                    // Loggear el error completo aquí
                }
            }
            // Devuelve la lista de productos únicos (los valores del diccionario)
            return productosMap.Values.ToList();
        }

        public int Registrar(Producto obj, Categoria objCat, out string Mensaje)//crearProducto
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
                    cmd.Parameters.AddWithValue("id_categoria", objCat.id_categoria);

                    cmd.Parameters.Add("id_producto_resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

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

        public bool Editar(Producto obj, Categoria objCat, out string Mensaje)//modificarProducto
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
                    cmd.Parameters.AddWithValue("id_categoria", objCat.id_categoria);

                    cmd.Parameters.Add("respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

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
    }
}

