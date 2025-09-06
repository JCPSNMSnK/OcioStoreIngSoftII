using CapaEntidades;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System;

namespace CapaDatos
{
    public class Informes_Datos
    {

        public class VentaDetalle
        {
            public int id_venta { get; set; }
            public DateTime fecha_venta { get; set; }
            public decimal total_venta { get; set; }
            public string nombre_vendedor { get; set; }
            public string nombre_cliente { get; set; }
        }

        public bool RegistrarInforme(Informe informe, out string mensaje)
        {
            bool exito = false;
            mensaje = string.Empty;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PROC_REGISTRAR_INFORME", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros de entrada
                    cmd.Parameters.AddWithValue("@titulo", informe.titulo);
                    cmd.Parameters.AddWithValue("@descripcion", informe.descripcion);
                    cmd.Parameters.AddWithValue("@tipo_informe", informe.tipo_informe);
                    cmd.Parameters.AddWithValue("@id_usuario", informe.objUsuario.id_user);

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    exito = true;
                    mensaje = "Registro de informe guardado exitosamente.";
                }
                catch (Exception ex)
                {
                    exito = false;
                    mensaje = "Error al registrar el informe: " + ex.Message;
                }
            }
            return exito;
        }

        public List<ProductoVendido> ObtenerProductosMasVendidos(DateTime fechaInicio, DateTime fechaFin)
        {
            List<ProductoVendido> lista = new List<ProductoVendido>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PROC_INFORME_PRODUCTOS_MAS_VENDIDOS", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros de entrada para el rango de fechas
                    cmd.Parameters.AddWithValue("@fecha_inicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@fecha_fin", fechaFin);

                    oconexion.Open();
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            lista.Add(new ProductoVendido()
                            {
                                nombre_producto = dataReader["nombre_producto"].ToString(),
                                cantidad_vendida = Convert.ToInt32(dataReader["cantidad_vendida"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    lista = new List<ProductoVendido>();
                }
            }
            return lista;
        }

        public List<VentaPorPeriodo> ObtenerFluctuacionDeVentas(DateTime fechaInicio, DateTime fechaFin)
        {
            List<VentaPorPeriodo> lista = new List<VentaPorPeriodo>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PROC_INFORME_FLUCTUACION_VENTAS", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros de entrada para el rango de fechas
                    cmd.Parameters.AddWithValue("@fecha_inicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@fecha_fin", fechaFin);

                    oconexion.Open();
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            lista.Add(new VentaPorPeriodo()
                            {
                                fecha_periodo = Convert.ToDateTime(dataReader["fecha_periodo"]),
                                total_ventas = Convert.ToDecimal(dataReader["total_ventas"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    lista = new List<VentaPorPeriodo>();
                }
            }
            return lista;
        }

        public List<CategoriaMasVendida> ObtenerCategoriasMasVendidas(DateTime fechaInicio, DateTime fechaFin)
        {
            List<CategoriaMasVendida> lista = new List<CategoriaMasVendida>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PROC_INFORME_CATEGORIAS_MAS_VENDIDAS", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@fecha_inicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@fecha_fin", fechaFin);

                    oconexion.Open();
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            lista.Add(new CategoriaMasVendida()
                            {
                                nombre_categoria = dataReader["nombre_categoria"].ToString(),
                                cantidad_vendida = Convert.ToInt32(dataReader["cantidad_vendida"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<CategoriaMasVendida>();
                }
            }
            return lista;
        }

        public List<VendedorConMasVentas> ObtenerVendedoresConMasVentas(DateTime fechaInicio, DateTime fechaFin)
        {
            List<VendedorConMasVentas> lista = new List<VendedorConMasVentas>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PROC_INFORME_VENDEDORES_MAS_VENTAS", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@fecha_inicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@fecha_fin", fechaFin);

                    oconexion.Open();
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            lista.Add(new VendedorConMasVentas()
                            {
                                nombre_vendedor = dataReader["nombre_vendedor"].ToString(),
                                total_ventas = Convert.ToDecimal(dataReader["total_ventas"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<VendedorConMasVentas>();
                }
            }
            return lista;
        }

        public List<VentaDetalle> ObtenerVentasVendedor(int id_vendedor, DateTime fechaInicio, DateTime fechaFin)
        {
            List<VentaDetalle> listaVentas = new List<VentaDetalle>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PROC_INFORME_VENDEDOR_VENTAS", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Ahora enviamos el ID del vendedor como parámetro
                    cmd.Parameters.AddWithValue("@id_user", id_vendedor);
                    cmd.Parameters.AddWithValue("@fecha_inicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@fecha_fin", fechaFin);

                    oconexion.Open();
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        // Recorremos cada fila del resultado
                        while (dataReader.Read())
                        {
                            VentaDetalle venta = new VentaDetalle()
                            {
                                id_venta = Convert.ToInt32(dataReader["id_venta"]),
                                fecha_venta = Convert.ToDateTime(dataReader["fecha_venta"]),
                                total_venta = Convert.ToDecimal(dataReader["total_venta"]),
                                nombre_vendedor = dataReader["nombre_vendedor"].ToString(),
                                nombre_cliente = dataReader["nombre_cliente"].ToString()
                            };
                            listaVentas.Add(venta);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return listaVentas;
        }


    }
}