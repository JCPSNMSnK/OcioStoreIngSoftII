using CapaEntidades;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System;

namespace CapaDatos
{
    public class Informes_Datos
    {

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


    }
}