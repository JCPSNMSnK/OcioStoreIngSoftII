using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class Ventas_Datos
    {
        public List<Ventas> ListarVentas()//mostrarVentas
        {
            List<Ventas> lista = new List<Ventas>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT id_venta,total,id_medio,id_user, id_cliente, fecha_venta FROM ventas v");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            lista.Add(new Ventas()
                            {
                                id_venta = Convert.ToInt32(dataReader["id_venta"]),
                                total = Convert.ToDecimal(dataReader["total"]),
                                objMediosPago = new MediosPago()
                                {
                                    id_medioPago = Convert.ToInt32(dataReader["id_medioPago"]),
                                    nombre_medio = dataReader["nombre_medio"].ToString(),
                                    comision = Convert.ToDecimal(dataReader["comision"]),
                                },

                                objUsuario = new Usuario()
                                {
                                    id_user = Convert.ToInt32(dataReader["id_user"]),
                                    apellido = dataReader["apellido"].ToString(),
                                    nombre = dataReader["nombre"].ToString(),
                                    dni = Convert.ToInt32(dataReader["dni"]),
                                    mail = dataReader["mail"].ToString(),
                                    username = dataReader["username"].ToString(),
                                    pass = dataReader["pass"].ToString(),
                                    baja_user = Convert.ToBoolean(dataReader["baja_user"]),
                                    objRoles = new Roles()
                                    {
                                        id_rol = Convert.ToInt32(dataReader["id_rol"]),
                                        nombre_rol = dataReader["nombre_rol"].ToString(),
                                    }
                                },

                                objCliente = new Cliente()
                                {
                                    id_cliente = Convert.ToInt32(dataReader["id_cliente"]),
                                    apellido_cliente = dataReader["apellido_cliente"].ToString(),
                                    nombre_cliente = dataReader["nombre_cliente"].ToString(),
                                    dni_cliente = Convert.ToInt32(dataReader["dni_cliente"]),
                                    email_cliente = dataReader["email_cliente"].ToString(),
                                    direccion_cliente = dataReader["direccion_cliente"].ToString(),
                                    telefono_cliente = dataReader["telefono_cliente"].ToString(),
                                    localidad_cliente = dataReader["localidad_cliente"].ToString(),
                                    provincia_cliente = dataReader["provincia_cliente"].ToString()
                                },


                                fecha_venta = Convert.ToDateTime(dataReader["fecha_venta"]),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Ventas>();
                    string Mensaje = ex.Message;
                }
            }
            return lista;
        }


        public List<Ventas> BuscarVentasConFiltros(DateTime inicio, DateTime fin, int idVendedor, int idCliente, int nroFactura)
        {
            List<Ventas> lista = new List<Ventas>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PROC_LISTAR_VENTAS_FILTRADAS", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fecha_inicio", inicio);
                    cmd.Parameters.AddWithValue("@fecha_fin", fin);
                    cmd.Parameters.AddWithValue("@id_vendedor", idVendedor);
                    cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                    cmd.Parameters.AddWithValue("@nro_factura", nroFactura);

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Ventas()
                            {
                                id_venta = Convert.ToInt32(dr["id_venta"]),
                                total = Convert.ToDecimal(dr["total"]),
                                fecha_venta = Convert.ToDateTime(dr["fecha_venta"]),
                                IdFacturaAsociada = dr["id_factura"] != DBNull.Value ? Convert.ToInt32(dr["id_factura"]) : 0,

                                objMediosPago = new MediosPago()
                                {
                                    id_medioPago = Convert.ToInt32(dr["id_medio"]),
                                    nombre_medio = dr["nombre_medio"].ToString(),
                                    comision = Convert.ToDecimal(dr["comision"])
                                },

                                objUsuario = new Usuario()
                                {
                                    id_user = Convert.ToInt32(dr["id_user"]),
                                    nombre = dr["nombre"].ToString(),
                                    apellido = dr["apellido"].ToString(),
                                    dni = Convert.ToInt32(dr["dni"]),
                                    mail = dr["mail"].ToString(),
                                    username = dr["username"].ToString(),
                                    
                                    objRoles = new Roles()
                                    {
                                        id_rol = Convert.ToInt32(dr["id_rol"]),
                                        nombre_rol = dr["nombre_rol"].ToString()
                                    }
                                },

                                objCliente = new Cliente()
                                {
                                    id_cliente = Convert.ToInt32(dr["id_cliente"]),
                                    nombre_cliente = dr["nombre_cliente"].ToString(),
                                    apellido_cliente = dr["apellido_cliente"].ToString(),
                                    dni_cliente = Convert.ToInt32(dr["dni_cliente"]),
                                    email_cliente = dr["email_cliente"].ToString()
                                }
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error en BD: " + ex.Message);
                    lista = new List<Ventas>();
                }
            }
            return lista;
        }


        public bool RegistrarVenta(Ventas obj, MediosPago objMetPago, Factura objFactura, out int idVentaRegistrada, out int idFacturaRegistrada, out string Mensaje)
        {

            idVentaRegistrada = 0;
            idFacturaRegistrada = 0;
            String mensajeSalida = string.Empty;
            bool exito = false;
            List<string> mensajesDetalle = new List<string>(); // Para recopilar mensajes de detalles

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                oconexion.Open(); // Abre la conexión una sola vez

                SqlTransaction transaction = null; // Declara la transacción

                try
                {
                    transaction = oconexion.BeginTransaction(); // Inicia la transacción

                    // REGISTRAR LA VENTA PRINCIPAL
                    using (SqlCommand cmdVenta = new SqlCommand("PROC_REGISTRAR_VENTA", oconexion, transaction)) // Asocia el comando a la transacción
                    {
                        cmdVenta.Parameters.AddWithValue("total", obj.total);
                        cmdVenta.Parameters.AddWithValue("@id_medio", obj.objMediosPago.id_medioPago);
                        cmdVenta.Parameters.AddWithValue("@id_user", obj.objUsuario.id_user);
                        cmdVenta.Parameters.AddWithValue("@id_cliente", obj.objCliente.id_cliente);
                        cmdVenta.Parameters.AddWithValue("fecha_venta", obj.fecha_venta);

                        cmdVenta.Parameters.Add("id_venta_registrada", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmdVenta.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                        cmdVenta.CommandType = CommandType.StoredProcedure;

                        cmdVenta.ExecuteNonQuery();

                        idVentaRegistrada = Convert.ToInt32(cmdVenta.Parameters["id_venta_registrada"].Value);
                        mensajeSalida = cmdVenta.Parameters["mensaje"].Value.ToString();

                        // Si la venta principal no se registró correctamente, lanzar excepción para hacer rollback
                        if (idVentaRegistrada == 0)
                        {
                            throw new Exception($"Error al registrar la venta principal: {mensajeSalida}");
                        }
                    }

                    // REGISTRAR LOS DETALLES DE LA VENTA
                    if (obj.detalles != null && obj.detalles.Any()) // Asegurarse de que hay detalles
                    {
                        foreach (var detalle in obj.detalles)
                        {
                            using (SqlCommand cmdDetalle = new SqlCommand("PROC_REGISTRAR_DETALLE", oconexion, transaction)) // ¡Asocia a la misma transacción!
                            {
                                cmdDetalle.Parameters.AddWithValue("id_venta_registrada", idVentaRegistrada);
                                cmdDetalle.Parameters.AddWithValue("id_producto", detalle.objProducto.id_producto);
                                cmdDetalle.Parameters.AddWithValue("cantidad", detalle.cantidad);
                                cmdDetalle.Parameters.AddWithValue("subtotal", detalle.subtotal);
                                cmdDetalle.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                                cmdDetalle.CommandType = CommandType.StoredProcedure;

                                // Si se desea loggear errores por detalle sin abortar la transacción inmediatamente,
                                // se podría añadir un try-catch acá y luego decidir si se hace rollback al final.
                                cmdDetalle.ExecuteNonQuery();

                                string mensajeActualDetalle = cmdDetalle.Parameters["mensaje"].Value.ToString();
                                if (!string.IsNullOrEmpty(mensajeActualDetalle))
                                {
                                    mensajesDetalle.Add($"Detalle Producto ID {detalle.objProducto.id_producto}: {mensajeActualDetalle}");
                                }
                            }

                        }
                    }
                    else
                    {
                        mensajesDetalle.Add("La venta no tiene detalles de producto para registrar.");
                    }

                    using (SqlCommand cmdFactura = new SqlCommand("PROC_REGISTRAR_FACTURA", oconexion, transaction))
                    {
                        cmdFactura.CommandType = CommandType.StoredProcedure;
                        cmdFactura.Parameters.AddWithValue("@id_venta", idVentaRegistrada);
                        cmdFactura.Parameters.AddWithValue("@id_cliente", obj.objCliente.id_cliente);
                        // Usamos el ID del tipo de factura que viene en el objeto Factura
                        cmdFactura.Parameters.AddWithValue("@id_tipo_factura", objFactura.objTipoFactura.id_tipo_factura);
                        cmdFactura.Parameters.AddWithValue("@fecha_emision", DateTime.Now); // O objFactura.fecha_emision

                        cmdFactura.Parameters.Add("@id_factura_generada", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmdFactura.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                        cmdFactura.ExecuteNonQuery();

                        int idFacturaGenerada = Convert.ToInt32(cmdFactura.Parameters["@id_factura_generada"].Value);
                        string msgFactura = cmdFactura.Parameters["@mensaje"].Value.ToString();

                        // Si la factura falla (ID 0), lanzamos excepción para deshacer todo (venta y detalles incluidos)
                        if (idFacturaGenerada == 0)
                        {
                            throw new Exception($"Error al generar la factura: {msgFactura}");
                        }
                    }

                    // Si llegamos aquí, Venta, Detalles y Factura están OK.
                    transaction.Commit();
                    exito = true;
                    //mensajeSalida += Environment.NewLine + string.Join(Environment.NewLine, mensajesDetalle); // Agrega mensajes de detalles
                    Mensaje = "Venta y Factura registradas con éxito. Nro Venta: " + idVentaRegistrada;
                }
                catch (SqlException sqlEx)
                {
                    // Un error SQL específico ocurrió
                    transaction?.Rollback(); // Deshace todos los cambios realizados en la transacción
                    mensajeSalida = $"Error de base de datos: {sqlEx.Message}";
                    idVentaRegistrada = 0; // Asegura que el ID de venta sea 0 en caso de fallo
                    exito = false;
                }
                catch (Exception ex)
                {
                    transaction?.Rollback();
                    mensajeSalida = $"Error general al guardar la venta: {ex.Message}";
                    idVentaRegistrada = 0;
                    exito = false;
                }
                finally
                {
                    // La conexión se cierra automáticamente por el 'using' block de SqlConnection
                }
            }

            Mensaje = mensajeSalida;
            return exito;
        }

        public Ventas ObtenerVentaCompleta(int idVenta)
        {
            Ventas objVenta = null;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("PROC_OBTENER_VENTA_COMPLETA", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_venta", idVenta);

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        // Leer el primer conjunto de resultados (Detalles de Venta)
                        List<DetalleVenta> detalles = new List<DetalleVenta>();
                        while (dr.Read())
                        {
                            detalles.Add(new DetalleVenta()
                            {
                                // Aquí se crea el objeto DetalleVenta
                                objProducto = new Producto()
                                {
                                    id_producto = Convert.ToInt32(dr["id_producto"]),
                                    cod_producto = dr["cod_producto"] != DBNull.Value ? Convert.ToInt32(dr["cod_producto"]) : 0, //Esto puesto que pueden haber productos sin código
                                    nombre_producto = dr["nombre_producto"].ToString(),
                                    precioVenta = Convert.ToDecimal(dr["precioVenta"])
                                },
                                cantidad = Convert.ToInt32(dr["cantidad"]),
                                subtotal = Convert.ToDecimal(dr["subtotal"])
                            });
                        }

                        // Mover al siguiente conjunto de resultados (Datos de la Venta y el Cliente)
                        if (dr.NextResult())
                        {
                            if (dr.Read())
                            {
                                // Crear el objeto Venta y asignarle los detalles
                                objVenta = new Ventas()
                                {
                                    id_venta = Convert.ToInt32(dr["id_venta"]),
                                    total = Convert.ToDecimal(dr["total"]),
                                    fecha_venta = Convert.ToDateTime(dr["fecha_venta"]),

                                    objCliente = new Cliente()
                                    {
                                        id_cliente = Convert.ToInt32(dr["id_cliente"]),
                                        dni_cliente = Convert.ToInt32(dr["dni_cliente"]),
                                        nombre_cliente = dr["nombre_cliente"].ToString(),
                                        apellido_cliente = dr["apellido_cliente"].ToString()
                                    },

                                    objMediosPago = new MediosPago()
                                    {
                                        id_medioPago = Convert.ToInt32(dr["id_medio"]),
                                        nombre_medio = dr["nombre_medio"].ToString(),
                                        comision = Convert.ToDecimal(dr["comision"])
                                    },

                                    objUsuario = new Usuario()
                                    {
                                        id_user = Convert.ToInt32(dr["id_user"]),
                                        nombre = dr["nombre_usuario"].ToString(),
                                        apellido = dr["apellido_usuario"].ToString()
                                    },

                                    detalles = detalles
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                objVenta = null;
                throw new Exception("Error al obtener venta: " + ex.Message);
            }

            return objVenta;
        }

        public bool FinalizarReservaComoVenta(int idReserva, decimal totalFinal, int idMedioPago, int idUser, int idCliente, out string mensaje)
        {
            mensaje = string.Empty;
            bool exito = false;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("PROC_FINALIZAR_RESERVA_A_VENTA", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Asignar los parámetros que se pasan a la base de datos
                    cmd.Parameters.AddWithValue("@id_reserva", idReserva);
                    cmd.Parameters.AddWithValue("@total_venta", totalFinal);
                    cmd.Parameters.AddWithValue("@id_medio", idMedioPago);
                    cmd.Parameters.AddWithValue("@id_user", idUser);
                    cmd.Parameters.AddWithValue("@id_cliente", idCliente);

                    // Parámetro de salida del procedimiento para el mensaje de éxito o error
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    exito = !mensaje.Contains("Error");
                }
            }
            catch (Exception ex)
            {
                exito = false;
                mensaje = "Error en la capa de datos: " + ex.Message;
            }

            return exito;
        }
    }
}
