using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //modificar categoría
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

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    exito = true;
                    mensaje = "Categoría modificada exitosamente.";
                }
                catch (Exception ex)
                {
                    exito = false;
                    mensaje = "Error al modificar la categoría: " + ex.Message;
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

        public bool DarDeBajaCategoria(int idCategoria, out string mensaje)
        {
            bool exito = false;
            mensaje = string.Empty;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PROC_DAR_DE_BAJA_CATEGORIA", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros de entrada
                    cmd.Parameters.AddWithValue("@id_categoria", idCategoria);

                    // Parámetro de salida para el mensaje del procedimiento
                    SqlParameter mensajeParam = new SqlParameter("@mensaje", SqlDbType.NVarChar, 100);
                    mensajeParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(mensajeParam);

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    exito = true;
                    mensaje = mensajeParam.Value.ToString();
                }
                catch (Exception ex)
                {
                    exito = false;
                    mensaje = "Error al dar de baja la categoría: " + ex.Message;
                }
            }
            return exito;
        }
    }

}

