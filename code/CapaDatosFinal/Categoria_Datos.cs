using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class Categoria_Datos
    {
        public List<Categoria> Listar()//mostrarCategorías
        {
            List<Categoria> lista = new List<Categoria>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT id_categoria, nombre_categoria, baja_categoria FROM Categorias;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            lista.Add(new Categoria()
                            {
                                id_categoria = Convert.ToInt32(dataReader["id_categoria"]),
                                nombre_categoria = dataReader["nombre_categoria"].ToString(),
                                baja_categoria = Convert.ToBoolean(dataReader["baja_categoria"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Categoria>();
                    string Mensaje = ex.Message;
                }
            }
            return lista;
        }

        public bool registrarCategoria(Categoria categoria, out string mensaje)
        {
            bool exito = false;
            mensaje = string.Empty;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Comando para llamar al procedimiento almacenado
                    SqlCommand cmd = new SqlCommand("PROC_REGISTRAR_CATEGORIA", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Añadir el parámetro de entrada para el nombre de la categoría
                    // Asumiendo que 'nombre_categoria' es una propiedad pública en tu clase Categoria
                    cmd.Parameters.AddWithValue("@nombre_categoria", categoria.nombre_categoria);

                    oconexion.Open();
                    cmd.ExecuteNonQuery(); // Ejecuta el procedimiento almacenado

                    exito = true; // Si no hay excepción, asumimos que fue exitoso
                    mensaje = "Categoría registrada exitosamente.";
                }
                catch (Exception ex)
                {
                    exito = false;
                    mensaje = "Error al registrar la categoría: " + ex.Message;
                }
            }
            return exito;
        }

        // Método para modificar una categoría en la base de datos
        public bool ModificarCategoria(Categoria categoria, out string mensaje)
        {
            bool exito = false;
            mensaje = string.Empty;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PROC_MODIFICAR_CATEGORIA", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros de entrada
                    cmd.Parameters.AddWithValue("@id_categoria", categoria.id_categoria);
                    cmd.Parameters.AddWithValue("@nombre_categoria", categoria.nombre_categoria);
                    // Nuevo parámetro de entrada para el estado
                    cmd.Parameters.AddWithValue("@baja_categoria", categoria.baja_categoria);

                    // Parámetro de salida para el mensaje del procedimiento almacenado
                    SqlParameter mensajeParam = new SqlParameter("@mensaje", SqlDbType.NVarChar, 100);
                    mensajeParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(mensajeParam);

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    // Obtener el mensaje devuelto por el procedimiento almacenado
                    mensaje = mensajeParam.Value.ToString();
                    exito = !mensaje.Contains("Error"); // Determinar el éxito en base al mensaje
                }
                catch (Exception ex)
                {
                    exito = false;
                    mensaje = "Error en la capa de datos al modificar la categoría: " + ex.Message;
                }
            }
            return exito;
        }

        public bool NombreExiste(int idCategoria, string nombreCategoria)
        {
            bool existe = false;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PROC_NOMBRE_CATEGORIA_EXISTE", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros de entrada para el procedimiento
                    cmd.Parameters.AddWithValue("@id_categoria", idCategoria);
                    cmd.Parameters.AddWithValue("@nombre_categoria", nombreCategoria);

                    // Parámetro de salida para el resultado
                    SqlParameter existeParam = new SqlParameter("@existe", SqlDbType.Bit);
                    existeParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(existeParam);

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    // Leer el valor del parámetro de salida
                    existe = Convert.ToBoolean(existeParam.Value);
                }
                catch
                {
                    existe = false;
                }
            }
            return existe;
        }

        public List<Categoria> BuscarCategoriasGeneral(string busqueda)
        {
            List<Categoria> lista = new List<Categoria>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PROC_BUSCAR_CATEGORIA", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@busqueda_general", busqueda);

                    oconexion.Open();

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            lista.Add(new Categoria()
                            {
                                id_categoria = Convert.ToInt32(dataReader["id_categoria"]),
                                nombre_categoria = dataReader["nombre_categoria"].ToString(),
                                baja_categoria = Convert.ToBoolean(dataReader["baja_categoria"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                    "Ocurrió un error al buscar las categorias:\n\n" + ex.ToString(),
                    "Error de Base de Datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    lista = new List<Categoria>();
                }
            }
            return lista;
        }

        public Dictionary<int, int> ContarProductosPorCategoria()
        {
            Dictionary<int, int> conteoProductos = new Dictionary<int, int>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PROC_CONTAR_PRODUCTOS_POR_CATEGORIA", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            // Se lee el ID de la categoría y la cantidad de productos
                            int idCategoria = Convert.ToInt32(dataReader["id_categoria"]);
                            int cantidadProductos = Convert.ToInt32(dataReader["cantidad_productos"]);

                            // Se añade la pareja de valores al diccionario
                            conteoProductos.Add(idCategoria, cantidadProductos);
                        }
                    }
                }
                catch (Exception)
                {
                    // En la capa de datos, es mejor lanzar la excepción
                    // para que una capa superior (negocio o presentación) la maneje.
                    throw;
                }
            }
            return conteoProductos;
        }
    }

}

