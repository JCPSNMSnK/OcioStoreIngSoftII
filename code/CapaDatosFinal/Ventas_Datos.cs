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
                    query.AppendLine("SELECT id_venta,total,id_medio,id_user,fecha_venta FROM ventas v");

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

        public bool RegistrarVenta(Ventas obj, MediosPago objMetPago, out int idVentaRegistrada, out string Mensaje)//crearVenta ()
        {

            idVentaRegistrada = 0;
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

                    // 1. REGISTRAR LA VENTA PRINCIPAL
                    using (SqlCommand cmdVenta = new SqlCommand("PROC_REGISTRAR_VENTA", oconexion, transaction)) // Asocia el comando a la transacción
                    {
                        cmdVenta.Parameters.AddWithValue("total", obj.total);
                        cmdVenta.Parameters.AddWithValue("@id_medio", obj.objMediosPago.id_medioPago);
                        cmdVenta.Parameters.AddWithValue("@id_user", obj.objUsuario.id_user);
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

                    // 2. REGISTRAR LOS DETALLES DE LA VENTA (AHORA CON TRANSACCIÓN)
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

                                // No es necesario un try-catch interno si un fallo de un detalle debe hacer rollback de todo
                                // Si se desea loggear errores por detalle sin abortar la transacción inmediatamente,
                                // se podría añadir un try-catch aquí y luego decidir si se hace rollback al final.
                                cmdDetalle.ExecuteNonQuery();

                                string mensajeActualDetalle = cmdDetalle.Parameters["mensaje"].Value.ToString();
                                if (!string.IsNullOrEmpty(mensajeActualDetalle))
                                {
                                    mensajesDetalle.Add($"Detalle Producto ID {detalle.objProducto.id_producto}: {mensajeActualDetalle}");
                                    // Si el procedimiento de detalle devuelve un mensaje de error, podrías lanzar una excepción
                                    // o marcar un flag para un rollback posterior.
                                    // Por simplicidad, aquí asumimos que un mensaje no vacío podría ser un error si el Proc Almac lo indica.
                                    // Si el Proc Almac de detalle retorna '0' o un flag para error, úsalo.
                                }
                            }
                            
                        }
                    }
                    else
                    {
                        mensajesDetalle.Add("La venta no tiene detalles de producto para registrar.");
                    }

                    // Si llegamos hasta aquí, todas las operaciones fueron exitosas
                    transaction.Commit(); // Confirma la transacción: todos los cambios se hacen permanentes
                    exito = true;
                    mensajeSalida += Environment.NewLine + string.Join(Environment.NewLine, mensajesDetalle); // Agrega mensajes de detalles
                }
                catch (SqlException sqlEx)
                {
                    // Un error SQL específico ocurrió
                    transaction?.Rollback(); // Deshace todos los cambios realizados en la transacción
                    mensajeSalida = $"Error de base de datos: {sqlEx.Message}";
                    idVentaRegistrada = 0; // Asegura que el ID de venta sea 0 en caso de fallo
                                           // Se puede loggear sqlEx.Number, sqlEx.State para depuración
                }
                catch (Exception ex)
                {
                    // Cualquier otro tipo de error
                    transaction?.Rollback(); // Deshace todos los cambios
                    mensajeSalida = $"Error general al guardar la venta: {ex.Message}";
                    idVentaRegistrada = 0;
                }
                finally
                {
                    // La conexión se cierra automáticamente por el 'using' block de SqlConnection
                }
            }

            Mensaje = mensajeSalida;
            return exito;
        }

    }
}
