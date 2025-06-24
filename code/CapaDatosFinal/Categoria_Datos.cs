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
    }
}
