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

namespace CapaDatos
{
    public class Producto_Datos
    {
        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.id, p.nombre, p.descripcion, p.marca, p.modelo, p.precio, p.stock, p.baja, c.id_categoria, c.descripcion_categoria, s.id_subcategoria, s.descripcion_subcategoria FROM productos_pc p");
                    query.AppendLine("left join categorias_pc c on c.id_categoria = p.id_categoria");
                    query.AppendLine("left join subcategorias_pc s on s.id_categoria = c.id_categoria and s.id_subcategoria = p.id_subcategoria");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            lista.Add(new Producto()
                            {
                                id_producto = Convert.ToInt32(dataReader["id"]),
                                nombre = dataReader["nombre"].ToString(),
                                descripcion = dataReader["descripcion"].ToString(),
                                marca = dataReader["marca"].ToString(),
                                modelo = dataReader["modelo"].ToString(),
                                precio = Convert.ToDecimal(dataReader["precio"]),
                                stock = Convert.ToInt32(dataReader["stock"]),
                                baja = Convert.ToBoolean(dataReader["baja"]),
                                objCategoria = new Categoria()
                                {
                                    id_categoria = dataReader["id_categoria"] != DBNull.Value ? Convert.ToInt32(dataReader["id_categoria"]) : 0,
                                    descripcion_categoria = dataReader["descripcion_categoria"] != DBNull.Value ? dataReader["descripcion_categoria"].ToString() : string.Empty
                                },
                                objSubCategoria = new SubCategoria()
                                {
                                    id_subcategoria = dataReader["id_subcategoria"] != DBNull.Value ? Convert.ToInt32(dataReader["id_subcategoria"]) : 0,
                                    objCategoria_subCat = new Categoria()
                                    {
                                        id_categoria = dataReader["id_categoria"] != DBNull.Value ? Convert.ToInt32(dataReader["id_categoria"]) : 0,
                                        descripcion_categoria = dataReader["descripcion_categoria"] != DBNull.Value ? dataReader["descripcion_categoria"].ToString() : string.Empty
                                    },
                                    descripcion_subcategoria = dataReader["descripcion_subcategoria"] != DBNull.Value ? dataReader["descripcion_subcategoria"].ToString() : string.Empty
                                },
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Producto>();
                }
            }
            return lista;
        }

        public List<Producto> BuscarProductos(string criterio)
        {
            List<Producto> lista = new List<Producto>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.id,p.nombre,p.descripcion,p.marca,p.modelo,p.precio,p.stock,p.baja,c.id_categoria, c.descripcion_categoria, s.id_subcategoria, s.descripcion_subcategoria FROM productos_pc p");
                    query.AppendLine("left join categorias_pc c on c.id_categoria = p.id_categoria");
                    query.AppendLine("left join subcategorias_pc s on s.id_categoria = c.id_categoria and s.id_subcategoria = p.id_subcategoria");
                    query.AppendLine("where p.nombre LIKE @criterio OR p.descripcion LIKE @criterio OR p.marca LIKE @criterio OR p.modelo LIKE @criterio OR p.precio LIKE @criterio OR c.descripcion_categoria LIKE @criterio OR s.descripcion_subcategoria LIKE @criterio;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@criterio", "%" + criterio + "%");

                    oconexion.Open();

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            lista.Add(new Producto()
                            {
                                id_producto = Convert.ToInt32(dataReader["id"]),
                                nombre = dataReader["nombre"].ToString(),
                                descripcion = dataReader["descripcion"].ToString(),
                                marca = dataReader["marca"].ToString(),
                                modelo = dataReader["modelo"].ToString(),
                                precio = Convert.ToDecimal(dataReader["precio"]),
                                stock = Convert.ToInt32(dataReader["stock"]),
                                baja = Convert.ToBoolean(dataReader["baja"]),
                                objCategoria = new Categoria()
                                {
                                    id_categoria = dataReader["id_categoria"] != DBNull.Value ? Convert.ToInt32(dataReader["id_categoria"]) : 0,
                                    descripcion_categoria = dataReader["descripcion_categoria"] != DBNull.Value ? dataReader["descripcion_categoria"].ToString() : string.Empty
                                },
                                objSubCategoria = new SubCategoria()
                                {
                                    id_subcategoria = dataReader["id_subcategoria"] != DBNull.Value ? Convert.ToInt32(dataReader["id_subcategoria"]) : 0,
                                    objCategoria_subCat = new Categoria()
                                    {
                                        id_categoria = dataReader["id_categoria"] != DBNull.Value ? Convert.ToInt32(dataReader["id_categoria"]) : 0,
                                        descripcion_categoria = dataReader["descripcion_categoria"] != DBNull.Value ? dataReader["descripcion_categoria"].ToString() : string.Empty
                                    },
                                    descripcion_subcategoria = dataReader["descripcion_subcategoria"] != DBNull.Value ? dataReader["descripcion_subcategoria"].ToString() : string.Empty
                                },
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Producto>();
                }
            }
            return lista;
        }
        public int Registrar(Producto obj, out string Mensaje)
        {
            int id_producto_generado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("PROC_REGISTRAR_PRODUCTO", oconexion);
                    cmd.Parameters.AddWithValue("nombre", obj.nombre);
                    cmd.Parameters.AddWithValue("descripcion", obj.descripcion);
                    cmd.Parameters.AddWithValue("marca", obj.marca);
                    cmd.Parameters.AddWithValue("modelo", obj.modelo);
                    cmd.Parameters.AddWithValue("precio", obj.precio);
                    cmd.Parameters.AddWithValue("stock", obj.stock);
                    cmd.Parameters.AddWithValue("baja", obj.baja);
                    cmd.Parameters.AddWithValue("id_categoria", obj.objCategoria.id_categoria);
                    cmd.Parameters.AddWithValue("id_subcategoria", obj.objSubCategoria.id_subcategoria);

                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    id_producto_generado = Convert.ToInt32(cmd.Parameters["resultado"].Value);
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

        public bool Editar(Producto obj, out string Mensaje)
        {
            bool resultado = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("PROC_EDITAR_PRODUCTO", oconexion);
                    cmd.Parameters.AddWithValue("id_prod", obj.id_producto);
                    cmd.Parameters.AddWithValue("nombre", obj.nombre);
                    cmd.Parameters.AddWithValue("descripcion", obj.descripcion);
                    cmd.Parameters.AddWithValue("marca", obj.marca);
                    cmd.Parameters.AddWithValue("modelo", obj.modelo);
                    cmd.Parameters.AddWithValue("precio", obj.precio);
                    cmd.Parameters.AddWithValue("stock", obj.stock);
                    cmd.Parameters.AddWithValue("baja", obj.baja);
                    cmd.Parameters.AddWithValue("id_categoria", obj.objCategoria.id_categoria);
                    cmd.Parameters.AddWithValue("id_subcategoria", obj.objSubCategoria.id_subcategoria);

                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
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

        public bool Eliminar(Producto obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("PROC_ELIMINAR_PRODUCTO", oconexion);
                    cmd.Parameters.AddWithValue("id_prod", obj.id_producto);
                    cmd.Parameters.Add("respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["respuesta"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }
    }

}

