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
        public List<Producto> BuscarProductosGeneral(string busqueda, int idCategoria)
        {
            // Usamos el diccionario para evitar duplicados de productos (clave: id_producto)
            var diccionarioProductos = new Dictionary<int, Producto>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PROC_BUSCAR_PRODUCTO", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Los parámetros ahora deben incluir id_proveedor_filtro si fuera necesario, 
                    // pero nos enfocamos en los que ya tenías:
                    cmd.Parameters.AddWithValue("@busqueda_general", string.IsNullOrEmpty(busqueda) ? (object)DBNull.Value : busqueda);
                    // El parámetro id_categoria se mantiene, ya que sigue siendo un filtro.
                    cmd.Parameters.AddWithValue("@id_categoria", idCategoria == 0 ? (object)DBNull.Value : idCategoria);

                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idProducto = Convert.ToInt32(reader["id_producto"]);
                            Producto productoExistente;

                            // --- 1. Mapeo del Producto Principal ---
                            if (!diccionarioProductos.TryGetValue(idProducto, out productoExistente))
                            {
                                // Si es la primera vez que vemos este producto (la clave del diccionario no existe)
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

                                    // ELIMINADO: id_proveedor = reader["id_proveedor"]...
                                    // ELIMINADO: nombre_proveedor = reader["nombre_proveedor"].ToString(),

                                    // Inicializar las colecciones de la entidad Producto
                                    categorias = new List<Categoria>(),
                                    proveedores = new List<Proveedor>() // AÑADIDO: Inicializar lista de proveedores
                                };
                                diccionarioProductos.Add(idProducto, productoExistente);
                            }

                            // --- 2. Mapeo de Categorías (Lógica Existente) ---
                            // Esto evita duplicar categorías en la lista si la misma categoría aparece en varias filas.
                            if (reader["id_categoria"] != DBNull.Value)
                            {
                                int idCat = Convert.ToInt32(reader["id_categoria"]);
                                if (!productoExistente.categorias.Any(c => c.id_categoria == idCat))
                                {
                                    productoExistente.categorias.Add(new Categoria()
                                    {
                                        id_categoria = idCat,
                                        nombre_categoria = reader["nombre_categoria"].ToString()
                                    });
                                }
                            }

                            // --- 3. Mapeo de Proveedores (NUEVA LÓGICA) ---
                            // Mismo patrón que categorías para desnormalizar y evitar duplicados de proveedores.
                            if (reader["id_proveedor"] != DBNull.Value)
                            {
                                int idProv = Convert.ToInt32(reader["id_proveedor"]);
                                if (!productoExistente.proveedores.Any(p => p.id_proveedor == idProv))
                                {
                                    productoExistente.proveedores.Add(new Proveedor()
                                    {
                                        id_proveedor = idProv,
                                        nombre_proveedor = reader["nombre_proveedor"].ToString(),
                                        baja_proveedor = Convert.ToBoolean(reader["baja_proveedor"]) // Mapeamos el estado de baja
                                                                                                     // Nota: Otros campos del Proveedor (CUIT, Teléfono) no se devuelven aquí
                                    });
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones (usaste throw, lo mantengo)
                    // Aquí puedes loguear ex.Message
                    throw ex;
                }
            }
            // Devolver la lista final de productos únicos.
            return diccionarioProductos.Values.ToList();
        }

        public List<Producto> Listar() // mostrarProductos
        {
            // Usamos el diccionario para desnormalizar y almacenar productos únicos
            var diccionarioProductos = new Dictionary<int, Producto>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    // MODIFICACIÓN DE LA CONSULTA SQL DIRECTA:
                    // 1. ELIMINAR p.id_proveedor
                    // 2. AÑADIR JOIN a ProductosProveedores (pp) y Proveedores (pr)
                    // 3. SELECCIONAR DATOS DEL PROVEEDOR
                    query.AppendLine("SELECT p.id_producto, p.nombre_producto, p.fechaIngreso, p.descripcion, p.precioLista, p.precioVenta,");
                    query.AppendLine("p.stock, p.stock_min, p.baja_producto, p.cod_producto,");
                    query.AppendLine("c.id_categoria, c.nombre_categoria,");
                    query.AppendLine("pr.id_proveedor, pr.nombre_proveedor, pr.baja_proveedor"); // AÑADIDO: Datos del proveedor
                    query.AppendLine("FROM Productos p ");
                    query.AppendLine("LEFT JOIN ProductosCategorias pc ON p.id_producto = pc.id_producto ");
                    query.AppendLine("LEFT JOIN Categorias c ON pc.id_categoria = c.id_categoria ");
                    query.AppendLine("LEFT JOIN ProductosProveedores pp ON p.id_producto = pp.id_producto "); // NUEVO JOIN
                    query.AppendLine("LEFT JOIN Proveedores pr ON pp.id_proveedor = pr.id_proveedor ");      // NUEVO JOIN

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            int idProducto = Convert.ToInt32(dataReader["id_producto"]);
                            Producto productoExistente;

                            // --- 1. Mapeo del Producto Principal ---
                            if (!diccionarioProductos.TryGetValue(idProducto, out productoExistente))
                            {
                                // Mapeo del objeto Producto (solo la primera vez)
                                productoExistente = new Producto()
                                {
                                    id_producto = Convert.ToInt32(dataReader["id_producto"]),
                                    nombre_producto = dataReader["nombre_producto"].ToString(),
                                    fechaIngreso = dataReader["fechaIngreso"] != DBNull.Value ? Convert.ToDateTime(dataReader["fechaIngreso"]) : DateTime.Now,
                                    precioLista = Convert.ToDecimal(dataReader["precioLista"]),
                                    precioVenta = Convert.ToDecimal(dataReader["precioVenta"]),
                                    baja_producto = Convert.ToBoolean(dataReader["baja_producto"]),
                                    stock_min = Convert.ToInt32(dataReader["stock_min"]),
                                    stock = Convert.ToInt32(dataReader["stock"]),
                                    descripcion = dataReader["descripcion"] != DBNull.Value ? dataReader["descripcion"].ToString() : string.Empty,
                                    cod_producto = Convert.ToInt32(dataReader["cod_producto"]),
                                    // ELIMINADO: id_proveedor = Convert.ToInt32(dataReader["id_proveedor"])

                                    // Inicializar colecciones
                                    categorias = new List<Categoria>(),
                                    proveedores = new List<Proveedor>() // AÑADIDO: Inicializar lista
                                };
                                diccionarioProductos.Add(idProducto, productoExistente);
                            }

                            // --- 2. Mapeo de Categorías (Lógica existente) ---
                            if (dataReader["id_categoria"] != DBNull.Value)
                            {
                                int idCat = Convert.ToInt32(dataReader["id_categoria"]);
                                // Agregar solo si la categoría no ha sido añadida ya
                                if (!productoExistente.categorias.Any(c => c.id_categoria == idCat))
                                {
                                    productoExistente.categorias.Add(new Categoria()
                                    {
                                        id_categoria = idCat,
                                        nombre_categoria = dataReader["nombre_categoria"].ToString()
                                    });
                                }
                            }

                            // --- 3. Mapeo de Proveedores (NUEVA LÓGICA) ---
                            if (dataReader["id_proveedor"] != DBNull.Value)
                            {
                                int idProv = Convert.ToInt32(dataReader["id_proveedor"]);
                                // Agregar solo si el proveedor no ha sido añadido ya
                                if (!productoExistente.proveedores.Any(p => p.id_proveedor == idProv))
                                {
                                    productoExistente.proveedores.Add(new Proveedor()
                                    {
                                        id_proveedor = idProv,
                                        nombre_proveedor = dataReader["nombre_proveedor"].ToString(),
                                        baja_proveedor = Convert.ToBoolean(dataReader["baja_proveedor"]) // Mapear estado de baja
                                    });
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepción
                    string Mensaje = ex.Message;
                    diccionarioProductos = new Dictionary<int, Producto>();
                }
            }
            // Devolver la lista de productos únicos
            return diccionarioProductos.Values.ToList();
        }

        public int Registrar(Producto obj, out string Mensaje)//crearProducto
        {
            int id_producto_generado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("PROC_CREAR_PRODUCTO", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // --- PARÁMETROS BÁSICOS (NO AFECTADOS) ---
                    cmd.Parameters.AddWithValue("nombre_producto", obj.nombre_producto);
                    cmd.Parameters.AddWithValue("fechaIngreso", obj.fechaIngreso);
                    cmd.Parameters.AddWithValue("precioLista", obj.precioLista);
                    cmd.Parameters.AddWithValue("precioVenta", obj.precioVenta);
                    cmd.Parameters.AddWithValue("eliminado", obj.baja_producto);
                    cmd.Parameters.AddWithValue("stock", obj.stock);
                    cmd.Parameters.AddWithValue("stock_min", obj.stock_min);
                    cmd.Parameters.AddWithValue("descripcion", obj.descripcion);
                    cmd.Parameters.AddWithValue("cod_producto", obj.cod_producto);
                    // ELIMINADO: cmd.Parameters.AddWithValue("id_proveedor", obj.id_proveedor);

                    // --- PARÁMETRO 1: CATEGORÍAS (Lógica existente) ---
                    DataTable dtCategorias = new DataTable();
                    dtCategorias.Columns.Add("ID", typeof(int)); // Importante: Debe coincidir con el nombre de columna del Table Type 'TipoIds'

                    if (obj.categorias != null)
                    {
                        foreach (var cat in obj.categorias)
                        {
                            dtCategorias.Rows.Add(cat.id_categoria);
                        }
                    }
                    // Pasamos el DataTable como un parámetro de tipo tabla estructurado
                    SqlParameter paramCategorias = cmd.Parameters.AddWithValue("@id_categorias", dtCategorias);
                    paramCategorias.SqlDbType = SqlDbType.Structured;
                    // Asegúrate de que el tipo de tabla en SQL Server sea 'TipoIds'
                    paramCategorias.TypeName = "dbo.TipoIds";


                    // --- PARÁMETRO 2: PROVEEDORES (NUEVA LÓGICA) ---
                    DataTable dtProveedores = new DataTable();
                    dtProveedores.Columns.Add("ID", typeof(int)); // Debe coincidir con el Table Type 'TipoIds'

                    if (obj.proveedores != null) // Usamos la nueva propiedad List<Proveedor>
                    {
                        foreach (var prov in obj.proveedores)
                        {
                            dtProveedores.Rows.Add(prov.id_proveedor); // Añadimos el ID del proveedor
                        }
                    }

                    // Pasamos el DataTable de proveedores como un parámetro de tipo tabla estructurado
                    SqlParameter paramProveedores = cmd.Parameters.AddWithValue("@id_proveedores", dtProveedores);
                    paramProveedores.SqlDbType = SqlDbType.Structured;
                    paramProveedores.TypeName = "dbo.TipoIds"; // El mismo tipo de tabla que categorías


                    // --- PARÁMETROS DE SALIDA ---
                    // Nota: Se asume que el SP devuelve id_producto_generado, pero en el código C#
                    // estás usando "id_producto_resultado". Lo mantendré coherente con tu DB:
                    cmd.Parameters.Add("id_producto_generado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    // Usar el nombre de parámetro correcto de salida de la DB
                    id_producto_generado = Convert.ToInt32(cmd.Parameters["id_producto_generado"].Value);
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
                    cmd.CommandType = CommandType.StoredProcedure;

                    // --- PARÁMETROS BÁSICOS (DE PROPIEDADES SIMPLES) ---
                    cmd.Parameters.AddWithValue("@id_producto", obj.id_producto);
                    cmd.Parameters.AddWithValue("@nombre_producto", obj.nombre_producto);
                    cmd.Parameters.AddWithValue("@precioLista", obj.precioLista);
                    cmd.Parameters.AddWithValue("@precioVenta", obj.precioVenta);
                    cmd.Parameters.AddWithValue("@baja_producto", obj.baja_producto);
                    cmd.Parameters.AddWithValue("@stock", obj.stock);
                    cmd.Parameters.AddWithValue("@stock_min", obj.stock_min);
                    cmd.Parameters.AddWithValue("@descripcion", obj.descripcion);
                    cmd.Parameters.AddWithValue("@cod_producto", obj.cod_producto);

                    // ELIMINADO: cmd.Parameters.AddWithValue("@id_proveedor", obj.id_proveedor); <-- YA NO EXISTE

                    // --- 1. PARÁMETRO DE CATEGORÍAS (Lógica existente) ---
                    DataTable dtCategorias = new DataTable();
                    dtCategorias.Columns.Add("ID", typeof(int));
                    if (obj.categorias != null)
                    {
                        foreach (var cat in obj.categorias)
                        {
                            dtCategorias.Rows.Add(cat.id_categoria);
                        }
                    }
                    SqlParameter paramCategorias = cmd.Parameters.AddWithValue("@nuevas_categorias", dtCategorias);
                    paramCategorias.SqlDbType = SqlDbType.Structured;
                    paramCategorias.TypeName = "dbo.TipoIds"; // Configurar el nombre del Table Type


                    // --- 2. PARÁMETRO DE PROVEEDORES (NUEVA LÓGICA) ---
                    DataTable dtProveedores = new DataTable();
                    dtProveedores.Columns.Add("ID", typeof(int)); // Debe coincidir con 'TipoIds'
                    if (obj.proveedores != null) // Usamos la nueva propiedad List<Proveedor>
                    {
                        foreach (var prov in obj.proveedores)
                        {
                            dtProveedores.Rows.Add(prov.id_proveedor); // Añadimos el ID del proveedor
                        }
                    }
                    SqlParameter paramProveedores = cmd.Parameters.AddWithValue("@nuevos_proveedores", dtProveedores);
                    paramProveedores.SqlDbType = SqlDbType.Structured;
                    paramProveedores.TypeName = "dbo.TipoIds"; // Configurar el nombre del Table Type


                    // Parámetros de salida
                    cmd.Parameters.Add("respuesta", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

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
                                // ELIMINADO: id_proveedor = Convert.ToInt32(dr["id_proveedor"]), <-- Eliminado

                                // Inicializar las listas
                                categorias = new List<Categoria>(),
                                proveedores = new List<Proveedor>() // AÑADIDO: Inicializar lista de proveedores
                            };
                        }

                        // 2. Mover al siguiente conjunto de resultados (categorías)
                        if (productoObtenido != null && dr.NextResult())
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

                        // 3. Mover al siguiente conjunto de resultados (proveedores) - NUEVA LÓGICA
                        if (productoObtenido != null && dr.NextResult())
                        {
                            while (dr.Read())
                            {
                                // Agregar cada proveedor a la lista del producto
                                productoObtenido.proveedores.Add(new Proveedor()
                                {
                                    id_proveedor = Convert.ToInt32(dr["id_proveedor"]),
                                    nombre_proveedor = dr["nombre_proveedor"].ToString(),
                                    baja_proveedor = Convert.ToBoolean(dr["baja_proveedor"]) // Mapear el estado de baja
                                                                                             // Solo leemos los campos que devuelve este SELECT
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

        public Producto BuscarPorCodigo(int codigo)
        {
            // Utilizamos un diccionario para garantizar que solo tengamos un objeto Producto.
            // La clave es el id_producto y el valor es el objeto Producto.
            Dictionary<int, Producto> productosEncontrados = new Dictionary<int, Producto>();

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    // Llamar al nuevo procedimiento almacenado
                    SqlCommand cmd = new SqlCommand("PROC_BUSCAR_PRODUCTO_POR_CODIGO", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetro de entrada
                    cmd.Parameters.AddWithValue("@cod_producto", codigo);

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            int idProducto = Convert.ToInt32(dr["id_producto"]);

                            // --- 1. Mapeo del Producto (si aún no está en el diccionario) ---
                            if (!productosEncontrados.ContainsKey(idProducto))
                            {
                                productosEncontrados.Add(idProducto, new Producto()
                                {
                                    id_producto = idProducto,
                                    nombre_producto = dr["nombre_producto"].ToString(),
                                    fechaIngreso = Convert.ToDateTime(dr["fechaIngreso"]),
                                    descripcion = dr["descripcion"].ToString(),
                                    precioLista = Convert.ToDecimal(dr["precioLista"]),
                                    precioVenta = Convert.ToDecimal(dr["precioVenta"]),
                                    stock = Convert.ToInt32(dr["stock"]),
                                    stock_min = Convert.ToInt32(dr["stock_min"]),
                                    baja_producto = Convert.ToBoolean(dr["baja_producto"]),
                                    cod_producto = Convert.ToInt32(dr["cod_producto"]), // Mantenemos como string si el campo lo es

                                    // Inicializar listas internas
                                    categorias = new List<Categoria>(),
                                    proveedores = new List<Proveedor>()
                                });
                            }

                            Producto productoActual = productosEncontrados[idProducto];

                            // --- 2. Mapeo de Categoría (Relación M:N) ---
                            if (dr["id_categoria"] != DBNull.Value)
                            {
                                int idCategoria = Convert.ToInt32(dr["id_categoria"]);
                                // Agregar si la categoría no ha sido agregada ya (evitando duplicados)
                                if (!productoActual.categorias.Any(c => c.id_categoria == idCategoria))
                                {
                                    productoActual.categorias.Add(new Categoria()
                                    {
                                        id_categoria = idCategoria,
                                        nombre_categoria = dr["nombre_categoria"].ToString()
                                    });
                                }
                            }

                            // --- 3. Mapeo de Proveedor (Relación M:N) ---
                            if (dr["id_proveedor"] != DBNull.Value)
                            {
                                int idProveedor = Convert.ToInt32(dr["id_proveedor"]);
                                // Agregar si el proveedor no ha sido agregado ya (evitando duplicados)
                                if (!productoActual.proveedores.Any(pr => pr.id_proveedor == idProveedor))
                                {
                                    productoActual.proveedores.Add(new Proveedor()
                                    {
                                        id_proveedor = idProveedor,
                                        nombre_proveedor = dr["nombre_proveedor"].ToString(),
                                        // Nota: baja_proveedor es opcional aquí, pero útil para la validación
                                        baja_proveedor = Convert.ToBoolean(dr["baja_proveedor"])
                                    });
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // En caso de error, puedes loguear la excepción y retornar un producto nulo
                Console.WriteLine(ex.Message);
                return null;
            }

            // El resultado del diccionario solo puede ser uno (o cero).
            // Si se encontró, devuelve el único valor; si no, devuelve null.
            return productosEncontrados.Values.FirstOrDefault();
        }
    }
}

