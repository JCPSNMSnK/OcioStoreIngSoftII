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
        public List<Producto> Listar()//mostrarProductos
        {
            List<Producto> lista = new List<Producto>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.id_producto, p.nombre_producto, p.fechaIngreso, p.descripcion, p.precioLista, p.precioVenta,");
                    query.AppendLine("p.stock, p.stock_min, p.baja_producto, c.id_categoria, c.nombre_categoria");
                    query.AppendLine("FROM Productos p ");
                    query.AppendLine("LEFT JOIN ProductosCategorias pc ON p.id_producto = pc.id_producto ");
                    query.AppendLine("LEFT JOIN Categorias c ON pc.id_categoria = c.id_categoria ");
                    //query.AppendLine("WHERE p.baja_producto = 0"); // Filtro para productos activos

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

        //public List<Producto> BuscarProductos(string criterio)
        //{
        //    List<Producto> lista = new List<Producto>();

        //    using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
        //    {
        //        try
        //        {
        //            StringBuilder query = new StringBuilder();
        //            query.AppendLine("select p.id,p.nombre,p.descripcion,p.marca,p.modelo,p.precio,p.stock,p.baja,c.id_categoria, c.descripcion_categoria, s.id_subcategoria, s.descripcion_subcategoria FROM productos_pc p");
        //            query.AppendLine("left join categorias_pc c on c.id_categoria = p.id_categoria");
        //            query.AppendLine("left join subcategorias_pc s on s.id_categoria = c.id_categoria and s.id_subcategoria = p.id_subcategoria");
        //            query.AppendLine("where p.nombre LIKE @criterio OR p.descripcion LIKE @criterio OR p.marca LIKE @criterio OR p.modelo LIKE @criterio OR p.precio LIKE @criterio OR c.descripcion_categoria LIKE @criterio OR s.descripcion_subcategoria LIKE @criterio;");

        //            SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
        //            cmd.CommandType = CommandType.Text;
        //            cmd.Parameters.AddWithValue("@criterio", "%" + criterio + "%");

        //            oconexion.Open();

        //            using (SqlDataReader dataReader = cmd.ExecuteReader())
        //            {
        //                while (dataReader.Read())
        //                {
        //                    lista.Add(new Producto()
        //                    {
        //                        id_producto = Convert.ToInt32(dataReader["id"]),
        //                        nombre = dataReader["nombre"].ToString(),
        //                        descripcion = dataReader["descripcion"].ToString(),
        //                        marca = dataReader["marca"].ToString(),
        //                        modelo = dataReader["modelo"].ToString(),
        //                        precio = Convert.ToDecimal(dataReader["precio"]),
        //                        stock = Convert.ToInt32(dataReader["stock"]),
        //                        baja = Convert.ToBoolean(dataReader["baja"]),
        //                        objCategoria = new Categoria()
        //                        {
        //                            id_categoria = dataReader["id_categoria"] != DBNull.Value ? Convert.ToInt32(dataReader["id_categoria"]) : 0,
        //                            descripcion_categoria = dataReader["descripcion_categoria"] != DBNull.Value ? dataReader["descripcion_categoria"].ToString() : string.Empty
        //                        },
        //                        objSubCategoria = new SubCategoria()
        //                        {
        //                            id_subcategoria = dataReader["id_subcategoria"] != DBNull.Value ? Convert.ToInt32(dataReader["id_subcategoria"]) : 0,
        //                            objCategoria_subCat = new Categoria()
        //                            {
        //                                id_categoria = dataReader["id_categoria"] != DBNull.Value ? Convert.ToInt32(dataReader["id_categoria"]) : 0,
        //                                descripcion_categoria = dataReader["descripcion_categoria"] != DBNull.Value ? dataReader["descripcion_categoria"].ToString() : string.Empty
        //                            },
        //                            descripcion_subcategoria = dataReader["descripcion_subcategoria"] != DBNull.Value ? dataReader["descripcion_subcategoria"].ToString() : string.Empty
        //                        },
        //                    });
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            lista = new List<Producto>();
        //        }
        //    }
        //    return lista;
        //}
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

