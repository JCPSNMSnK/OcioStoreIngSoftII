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
    public class SubCategoria_Datos
    {
        public List<SubCategoria> Listar()
        {
            List<SubCategoria> lista = new List<SubCategoria>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select c.id_categoria, c.descripcion_categoria, s.id_subcategoria, s.descripcion_subcategoria from subcategorias_pc s");
                    query.AppendLine("inner join categorias_pc c on c.id_categoria = s.id_categoria");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            lista.Add(new SubCategoria()
                            {
                                id_subcategoria = Convert.ToInt32(dataReader["id_subcategoria"]),
                                objCategoria_subCat = new Categoria()
                                {
                                    id_categoria = dataReader["id_categoria"] != DBNull.Value ? Convert.ToInt32(dataReader["id_categoria"]) : 0,
                                    descripcion_categoria = dataReader["descripcion_categoria"] != DBNull.Value ? dataReader["descripcion_categoria"].ToString() : string.Empty
                                },
                                descripcion_subcategoria = dataReader["descripcion_subcategoria"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<SubCategoria>();
                }
            }
            return lista;
        }
    }
}
