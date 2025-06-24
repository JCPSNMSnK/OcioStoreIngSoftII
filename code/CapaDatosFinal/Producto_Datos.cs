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
            string nombre_producto = null,
            string descripcion = null,
            string nombre_categoria = null,
            int? id_producto = null,
            DateTime? fechaIngreso = null,
            decimal? precioLista = null,
            decimal? precioVenta = null,
            bool? baja_producto = null,
            int? stock = null,
            int? stock_min = null,
            int? id_categoria = null,
            out string mensaje // Para la retroalimentación de errores
        )
        {
            List<Producto> lista = new List<Producto>();
            mensaje = string.Empty; // Inicializa el mensaje

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Especificamos el nombre del procedimiento almacenado
                    SqlCommand cmd = new SqlCommand("BUSCAR_PRODUCTO", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure; // Indicamos que es un procedimiento almacenado

                    // Añadir todos los parámetros, incluyendo los que pueden ser nulos.
                    // AddWithValue maneja automáticamente los valores 'null' de C# convirtiéndolos a DBNull.Value.
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
                            lista.Add(new Producto()
                            {
                                id_producto = Convert.ToInt32(dataReader["id_producto"]),
                                nombre_producto = dataReader["nombre_producto"].ToString(),
                                fechaIngreso = dataReader["fechaIngreso"] != DBNull.Value
                                    ? Convert.ToDateTime(dataReader["fechaIngreso"])
                                    : DateTime.MinValue, // O un valor por defecto que prefieras si es nulo

                                descripcion = dataReader["descripcion"] != DBNull.Value
                                    ? dataReader["descripcion"].ToString()
                                    : string.Empty,

                                precioLista = Convert.ToDecimal(dataReader["precioLista"]),
                                precioVenta = Convert.ToDecimal(dataReader["precioVenta"]),
                                stock = Convert.ToInt32(dataReader["stock"]),
                                stock_min = Convert.ToInt32(dataReader["stock_min"]),
                                baja_producto = Convert.ToBoolean(dataReader["baja_producto"]),

                                // Asegúrate de que tu clase Producto tenga una propiedad para la Categoría
                                // Y que el DataReader contenga 'id_categoria' y 'nombre_categoria'
                                // Si estas propiedades existen en tu clase Producto, asume que se rellenan
                                // Aquí se crea una nueva instancia de Categoría para el producto

                                ObjCategoria = dataReader["id_categoria"] != DBNull.Value ? new Categoria()
                                {
                                    id_categoria = Convert.ToInt32(dataReader["id_categoria"]),
                                    nombre_categoria = dataReader["nombre_categoria"].ToString(),
                                    // Asume que no necesitas 'baja_categoria' de la categoría para el producto
                                    // Si la necesitaras, el SP también debería devolverla y la leerías aquí.
                                } : null // Asigna null si no hay categoría asociada
                            });
                        }
                    }
                    mensaje = "Búsqueda de productos realizada exitosamente.";
                }
                catch (Exception ex)
                {
                    lista = new List<Producto>(); // Devuelve una lista vacía en caso de error
                    mensaje = "Error al listar productos: " + ex.Message;
                    // Aquí podrías loggear el error completo para depuración
                }
            }
            return lista;
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

