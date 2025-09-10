using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CapaEntidades;

namespace CapaDatos
{
    public class Factura_Datos
    {
        public List<FacturaTipo> ListarTiposFactura()
        {
            List<FacturaTipo> lista = new List<FacturaTipo>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Llamamos al nuevo procedimiento
                    SqlCommand cmd = new SqlCommand("PROC_LISTAR_TIPOS_FACTURA", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new FacturaTipo()
                            {
                                id_tipo_factura = Convert.ToInt32(dr["id_tipo_factura"]),
                                nombre_tipo_factura = dr["nombre_tipo_factura"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<FacturaTipo>(); // Devuelve lista vacía en caso de error
                }
            }
            return lista;
        }

        // Método para generar una nueva factura
        public int GenerarFactura(int idVenta, int idTipoFactura, out string mensaje)
        {
            int idFacturaGenerada = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("PROC_GENERAR_FACTURA", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros de entrada
                    cmd.Parameters.AddWithValue("@id_venta", idVenta);
                    cmd.Parameters.AddWithValue("@id_tipo_factura", idTipoFactura);

                    // Parámetros de salida
                    cmd.Parameters.Add("@id_factura_generada", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    idFacturaGenerada = Convert.ToInt32(cmd.Parameters["@id_factura_generada"].Value);
                    mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idFacturaGenerada = 0;
                mensaje = "Error en la capa de datos: " + ex.Message;
            }

            return idFacturaGenerada;
        }

        // Método para listar/buscar facturas con filtros
        public List<Factura> BuscarFacturas(int idCliente, DateTime fechaInicio, DateTime fechaFin, int idTipoFactura)
        {
            List<Factura> lista = new List<Factura>();

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("PROC_BUSCAR_FACTURAS", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Asignamos los parámetros, manejando los valores nulos con DBNull.Value
                    cmd.Parameters.AddWithValue("@id_cliente", (idCliente == 0) ? (object)DBNull.Value : idCliente);
                    cmd.Parameters.AddWithValue("@fecha_inicio", (fechaInicio == DateTime.MinValue) ? (object)DBNull.Value : fechaInicio);
                    cmd.Parameters.AddWithValue("@fecha_fin", (fechaFin == DateTime.MinValue) ? (object)DBNull.Value : fechaFin);
                    cmd.Parameters.AddWithValue("@id_tipo_factura", (idTipoFactura == 0) ? (object)DBNull.Value : idTipoFactura);

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Factura()
                            {
                                id_factura = Convert.ToInt32(dr["id_factura"]),
                                fecha_emision = Convert.ToDateTime(dr["fecha_emision"]),
                                // Mapeo de la Venta
                                objVenta = new Ventas()
                                {
                                    total = Convert.ToDecimal(dr["total_venta"]),
                                    // Mapeo del Cliente
                                    objCliente = new Cliente()
                                    {
                                        nombre_cliente = dr["nombre_cliente"].ToString(),
                                        apellido_cliente = dr["apellido_cliente"].ToString()
                                    }
                                },
                                // Mapeo del Tipo de Factura
                                objTipoFactura = new FacturaTipo()
                                {
                                    nombre_tipo_factura = dr["nombre_tipo_factura"].ToString()
                                }
                            });
                        }
                    }
                }
            }
            catch (Exception)
            {
                lista = new List<Factura>();
            }

            return lista;
        }

         public Factura ObtenerFacturaCompleta(int idFactura)
        {
            Factura objFactura = null;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("PROC_OBTENER_FACTURA_COMPLETA", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_factura", idFactura);

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            objFactura = new Factura()
                            {
                                id_factura = Convert.ToInt32(dr["id_factura"]),
                                fecha_emision = Convert.ToDateTime(dr["fecha_emision"]),
                                objVenta = new Ventas()
                                {
                                    id_venta = Convert.ToInt32(dr["id_venta"]),
                                    total = Convert.ToDecimal(dr["total"]),
                                    objCliente = new Cliente()
                                    {
                                        id_cliente = Convert.ToInt32(dr["id_cliente"]),
                                        dni_cliente = Convert.ToInt32(dr["dni_cliente"]),
                                        nombre_cliente = dr["nombre_cliente"].ToString(),
                                        apellido_cliente = dr["apellido_cliente"].ToString()
                                    }
                                },
                                objTipoFactura = new FacturaTipo()
                                {
                                    id_tipo_factura = Convert.ToInt32(dr["id_tipo_factura"]),
                                    nombre_tipo_factura = dr["nombre_tipo_factura"].ToString(),
                                }
                            };
                        }
                    }
                }
            }
            catch (Exception)
            {
                objFactura = null;
            }

            return objFactura;
        }
    }
}