using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CapaEntidades;

namespace CapaDatos
{
    public class Compras_Datos
    {
        // Método para registrar una compra completa en una sola transacción.
        public int Registrar(Compra objCompra, out string mensaje)
        {
            int idCompraGenerada = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("PROC_REGISTRAR_COMPRA_TRANSACCION", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Creamos un DataTable para enviar los detalles de la compra a SQL Server
                    DataTable dtDetalles = new DataTable();
                    dtDetalles.Columns.Add("id_producto", typeof(int));
                    dtDetalles.Columns.Add("cantidad", typeof(int));
                    dtDetalles.Columns.Add("precio_unitario", typeof(decimal));

                    // Llenamos el DataTable con los datos de los detalles de la compra
                    foreach (DetalleCompra dc in objCompra.detalles)
                    {
                        dtDetalles.Rows.Add(new object[] { dc.objProducto.id_producto, dc.cantidad, dc.precio_unitario });
                    }

                    // Asignamos los parámetros del procedimiento almacenado
                    cmd.Parameters.AddWithValue("@id_proveedor", objCompra.objProveedor.id_proveedor);
                    cmd.Parameters.AddWithValue("@total_compra", objCompra.total);
                    // Pasamos el DataTable como un parámetro de tipo tabla
                    cmd.Parameters.AddWithValue("@detalles_compra", dtDetalles);

                    // Parámetros de salida del procedimiento
                    cmd.Parameters.Add("@id_compra_generado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    idCompraGenerada = Convert.ToInt32(cmd.Parameters["@id_compra_generado"].Value);
                    mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idCompraGenerada = 0;
                mensaje = "Error en la capa de datos: " + ex.Message;
            }

            return idCompraGenerada;
        }

        public List<Compra> Listar()
        {
            List<Compra> lista = new List<Compra>();
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    // Se utiliza una consulta JOIN para obtener los datos de compra, usuario y proveedor
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("SELECT c.id_compra, c.fecha_compra, c.total_compra,");
                    sb.AppendLine("p.id_proveedor, p.nombre_proveedor");
                    sb.AppendLine("FROM Compras c");
                    sb.AppendLine("INNER JOIN Proveedores p ON c.id_proveedor = p.id_proveedor;");
                    
                    SqlCommand cmd = new SqlCommand(sb.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Compra()
                            {
                                id_compra = Convert.ToInt32(dr["id_compra"]),
                                fecha_compra = Convert.ToDateTime(dr["fecha_compra"]),
                                total = Convert.ToDecimal(dr["total_compra"]),
                                objProveedor = new Proveedor()
                                {
                                    id_proveedor = Convert.ToInt32(dr["id_proveedor"]),
                                    nombre_proveedor = dr["nombre_proveedor"].ToString()
                                }
                            });
                        }
                    }
                }
            }
            catch (Exception)
            {
                lista = new List<Compra>();
            }
            return lista;
        }
    }
}