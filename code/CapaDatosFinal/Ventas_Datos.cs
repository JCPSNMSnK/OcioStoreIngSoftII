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

        public bool RegistrarVenta(Ventas obj, MediosPago objMetPago, out string Mensaje)//crearVenta ()
        {

            int idVentaRegistrada = 0;
            String mensajeSalida = string.Empty;

            /*try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("PROC_REGISTRAR_VENTA", oconexion);
                    cmd.Parameters.AddWithValue("total", obj.total);
                    cmd.Parameters.AddWithValue("id_medioPago", obj.objMediosPago);
                    cmd.Parameters.AddWithValue("id_usuario", obj.objUsuario);
                    cmd.Parameters.AddWithValue("fecha_venta", obj.fecha_venta);

                    cmd.Parameters.Add("id_venta_registrada", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    id_venta_registrada = Convert.ToInt32(cmd.Parameters["id_venta_registrada"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();

                    for (int i = 0; i < obj.detalles.Count; i++)
                    {
                        SqlCommand cmd = new SqlCommand("PROC_REGISTRAR_DETALLE", oconexion);

                        cmd.Parameters.AddWithValue("id_venta_registrada", id_venta_registrada);
                        cmd.Parameters.AddWithValue("id_producto", obj.detalles[i].objProducto.id_producto);
                        cmd.Parameters.AddWithValue("cantidad", obj.detalles[i].cantidad);
                        cmd.Parameters.AddWithValue("subtotal", obj.detalles[i].subtotal);
                        cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                        cmd.CommandType = CommandType.StoredProcedure;

                        oconexion.Open();
                        cmd.ExecuteNonQuery();

                        Mensaje = cmd.Parameters["mensaje"].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                id_venta_registrada = 0;
                Mensaje = ex.Message;
            }

            return id_venta_registrada;*/

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
                        // Asegúrate de que objMediosPago y objUsuario son válidos y tienen su ID accesible
                        cmdVenta.Parameters.AddWithValue("id_medioPago", obj.objMediosPago.id_medioPago); // Acceso al ID
                        cmdVenta.Parameters.AddWithValue("id_usuario", obj.objUsuario.id_user); // Acceso al ID
                        cmdVenta.Parameters.AddWithValue("fecha_venta", obj.fecha_venta);

                        cmdVenta.Parameters.Add("id_venta_registrada", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmdVenta.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                        cmdVenta.CommandType = CommandType.StoredProcedure;

                        cmdVenta.ExecuteNonQuery();

                        idVentaRegistrada = Convert.ToInt32(cmdVenta.Parameters["id_venta_registrada"].Value);
                        mensajeSalida = cmdVenta.Parameters["mensaje"].Value.ToString();

                        // Si la venta principal no se registró correctamente, lanzar excepción para hacer rollback
                        if (idVentaRegistrada == 0) // O alguna otra condición que indique fallo
                        {
                            throw new Exception($"Error al registrar la venta principal: {mensajeSalida}");
                        }
                    }

                    // 2. REGISTRAR LOS DETALLES DE LA VENTA (TU BUCLE ORIGINAL, AHORA CON TRANSACCIÓN)
                    if (obj.detalles != null && obj.detalles.Any()) // Asegurarse de que hay detalles
                    {
                        foreach (var detalle in obj.detalles)
                        {
                            using (SqlCommand cmdDetalle = new SqlCommand("PROC_REGISTRAR_DETALLE", oconexion, transaction)) // ¡Asocia a la misma transacción!
                            {
                                cmdDetalle.Parameters.AddWithValue("id_venta_registrada", idVentaRegistrada);
                                // Asegúrate de que objProducto es válido y tiene su ID accesible
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
                                    // Si tu Proc Almac de detalle retorna '0' o un flag para error, úsalo.
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
                                           // Puedes loggear sqlEx.Number, sqlEx.State para depuración
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

            Mensaje = null;
            return exito;
        }

    }
}
