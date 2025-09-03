using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CapaEntidades;

namespace CapaDatos
{
    public class Reservas_Datos
    {
        // Método para registrar una reserva completa en una sola transacción
        public int Registrar(Reserva objReserva, out string mensaje)
        {
            int idReservaGenerada = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("PROC_REGISTRAR_RESERVA_TRANSACCION", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Creamos un DataTable para enviar los detalles de la reserva a SQL Server
                    DataTable dtDetalles = new DataTable();
                    dtDetalles.Columns.Add("id_producto", typeof(int));
                    dtDetalles.Columns.Add("cantidad", typeof(int));
                    dtDetalles.Columns.Add("precio_unitario", typeof(decimal));

                    // Llenamos el DataTable con los datos de los detalles de la reserva
                    foreach (DetalleReserva dr in objReserva.detalles)
                    {
                        dtDetalles.Rows.Add(new object[] { dr.id_producto, dr.cantidad, dr.precio_unitario });
                    }

                    // Asignamos los parámetros del procedimiento almacenado
                    cmd.Parameters.AddWithValue("@id_cliente", objReserva.objCliente.id_cliente);
                    cmd.Parameters.AddWithValue("@fecha_emision_reserva", objReserva.fecha_emision_reserva);
                    cmd.Parameters.AddWithValue("@fecha_retiro_reserva", objReserva.fecha_retiro_reserva);
                    cmd.Parameters.AddWithValue("@total_reserva", objReserva.total_reserva);
                    cmd.Parameters.AddWithValue("@detalles_reserva", dtDetalles);

                    // Parámetros de salida del procedimiento
                    cmd.Parameters.Add("@id_reserva_generada", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    idReservaGenerada = Convert.ToInt32(cmd.Parameters["@id_reserva_generada"].Value);
                    mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idReservaGenerada = 0;
                mensaje = "Error en la capa de datos: " + ex.Message;
            }

            return idReservaGenerada;
        }

        // Método para listar todas las reservas
        public List<Reserva> Listar()
        {
            List<Reserva> lista = new List<Reserva>();
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    // Consulta para obtener los datos de la reserva y el cliente
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("SELECT r.id_reserva, r.fecha_emision_reserva, r.fecha_retiro_reserva, r.total_reserva,");
                    sb.AppendLine("c.id_cliente, c.dni_cliente, c.nombre_cliente, c.apellido_cliente");
                    sb.AppendLine("FROM Reservas r");
                    sb.AppendLine("INNER JOIN Clientes c ON r.id_cliente = c.id_cliente;");

                    SqlCommand cmd = new SqlCommand(sb.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Reserva()
                            {
                                id_reserva = Convert.ToInt32(dr["id_reserva"]),
                                fecha_emision_reserva = Convert.ToDateTime(dr["fecha_emision_reserva"]),
                                fecha_retiro_reserva = Convert.ToDateTime(dr["fecha_retiro_reserva"]),
                                total_reserva = Convert.ToDecimal(dr["total_reserva"]),
                                objCliente = new Cliente()
                                {
                                    id_cliente = Convert.ToInt32(dr["id_cliente"]),
                                    dni_cliente = Convert.ToInt32(dr["dni_cliente"]),
                                    nombre_cliente = dr["nombre_cliente"].ToString(),
                                    apellido_cliente = dr["apellido_cliente"].ToString()
                                }
                            });
                        }
                    }
                }
            }
            catch (Exception)
            {
                lista = new List<Reserva>();
            }
            return lista;
        }

        public bool FinalizarReserva(int idReserva, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("PROC_FINALIZAR_RESERVA", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Pass the input parameters
                    cmd.Parameters.AddWithValue("@id_reserva", idReserva);
                    cmd.Parameters.AddWithValue("@fecha_retiro_reserva", DateTime.Now);

                    // Define the output parameter
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    resultado = mensaje.Contains("exitosamente");
                }
            }
            catch (Exception ex)
            {
                resultado = false;
                mensaje = "Error en la capa de datos: " + ex.Message;
            }

            return resultado;
        }

        public bool CancelarReserva(int idReserva, out string mensaje)
        {
            bool exito = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("PROC_CANCELAR_RESERVA_TRANSACCION", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetro de entrada: el ID de la reserva a cancelar
                    cmd.Parameters.AddWithValue("@id_reserva", idReserva);

                    // Parámetro de salida para el mensaje de éxito o error
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    // Leer el mensaje de salida del procedimiento almacenado
                    mensaje = cmd.Parameters["@mensaje"].Value.ToString();

                    // El resultado es exitoso si el mensaje no contiene la palabra "Error"
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