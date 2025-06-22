using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatosFinal
{
    public class ProductoCategoria_Datos
    {
        public List<ProductosCategorias> Listar() // mostrarCategorías
        {
            List<ProductosCategorias> lista = new List<ProductosCategorias>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT c.id_categoria, c.nombre_categoria, p.id_producto, p.nombre_producto");
                    query.AppendLine("FROM ProductosCategorias pc");
                    query.AppendLine("INNER JOIN Categorias c ON c.id_categoria = pc.id_categoria");
                    query.AppendLine("INNER JOIN Productos p ON p.id_producto = pc.id_producto");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            ProductosCategorias relacion = new ProductosCategorias()
                            {
                                objCategoria = new Categoria()
                                {
                                    id_categoria = Convert.ToInt32(dataReader["id_categoria"]),
                                    nombre_categoria = dataReader["nombre_categoria"].ToString()
                                },
                                objProducto = new Producto()
                                {
                                    id_producto = Convert.ToInt32(dataReader["id_producto"]),
                                    nombre_producto = dataReader["nombre_producto"].ToString()
                                }
                            };

                            lista.Add(relacion);
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ProductosCategorias>();
                    string Mensaje = ex.Message; // Lo podés loguear si querés
                }
            }

            return lista;
        }

    }

}

