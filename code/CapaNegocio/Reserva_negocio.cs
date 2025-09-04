using System;
using System.Collections.Generic;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class Reserva_negocio
    {
        private readonly Reserva_Datos objReservasDatos;
        private readonly Ventas_Datos objVentaDatos;

        public Reserva_negocio()
        {
            objReservasDatos = new Reserva_Datos();
            objVentaDatos = new Ventas_Datos();
        }

        public int RegistrarReserva(Reserva objReserva, out string mensaje)
        {
            mensaje = string.Empty;
            int idReservaGenerada = 0;

            // Validación 1: El cliente no puede ser nulo o tener un ID vacío.
            if (objReserva.objCliente == null || objReserva.objCliente.id_cliente == 0)
            {
                mensaje = "Debe seleccionar un cliente para la reserva.";
                return 0;
            }

            // Validación 2: La reserva debe tener al menos un producto.
            if (objReserva.detalles == null || objReserva.detalles.Count < 1)
            {
                mensaje = "La reserva debe tener al menos un producto.";
                return 0;
            }

            // Validación 3: Las fechas de la reserva deben ser lógicas.
            if (objReserva.fecha_emision_reserva > objReserva.fecha_retiro_reserva)
            {
                mensaje = "La fecha de retiro no puede ser anterior a la fecha de emisión de la reserva.";
                return 0;
            }

            // Validación 4: Las cantidades de los productos no pueden ser cero o negativas.
            foreach (DetalleReserva dr in objReserva.detalles)
            {
                if (dr.cantidad <= 0)
                {
                    mensaje = "La cantidad de los productos no puede ser cero o negativa.";
                    return 0;
                }
            }

            // Validación 5: Verificar que hay suficiente stock disponible para la reserva.
            // A diferencia del caso anterior, el stock_reservado ya no existe.
            foreach (DetalleReserva dr in objReserva.detalles)
            {
                // Usamos la capa de datos de Producto para obtener el stock
                Producto_Datos objProductoDatos = new Producto_Datos();
                Producto producto = objProductoDatos.ObtenerProducto(dr.id_producto);
                if (producto != null)
                {
                    if (producto.stock < dr.cantidad)
                    {
                        mensaje = $"No hay suficiente stock para el producto '{producto.nombre_producto}'. Stock disponible: {producto.stock}.";
                        return 0;
                    }
                }
                else
                {
                    mensaje = "Uno de los productos en la reserva no existe.";
                    return 0;
                }
            }

            // Si todas las validaciones pasan, se delega a la capa de datos.
            idReservaGenerada = objReservasDatos.Registrar(objReserva, out mensaje);

            return idReservaGenerada;
        }

        public bool FinalizarReserva(int idReserva, out string mensaje)
        {
            // La capa de negocio valida que el ID sea válido antes de enviar la solicitud.
            if (idReserva <= 0)
            {
                mensaje = "El ID de la reserva no es válido.";
                return false;
            }
            // Delega la operación de finalización a la capa de datos.
            return objReservasDatos.FinalizarReserva(idReserva, out mensaje);
        }

        public bool CancelarReserva(int idReserva, out string mensaje)
        {
            // La capa de negocio valida que el ID sea válido antes de enviar la solicitud.
            if (idReserva <= 0)
            {
                mensaje = "El ID de la reserva no es válido.";
                return false;
            }
            // Delega la operación de cancelación a la capa de datos.
            return objReservasDatos.CancelarReserva(idReserva, out mensaje);
        }

        public List<Reserva> ListarReservas()
        {
            return objReservasDatos.Listar();
        }

        public bool TransformarAReservaEnVenta(Reserva reserva, MediosPago mediosPago, Usuario user, out string mensaje)
        {
            mensaje = string.Empty;

            // 1. 
            if (reserva.id_reserva == null || reserva.id_reserva < 1)
            {
                mensaje = "La reserva no existe.";
                return false;
            }

            // 2. Obtener el método de pago para calcular la comisión
            if (mediosPago == null)
            {
                mensaje = "El método de pago no existe o no fue asignado correctamente.";
                return false;
            }

            // 3. Recalcular el total de la venta con la comisión
            decimal totalOriginal = reserva.total_reserva;
            decimal totalFinal = totalOriginal * (1 + (mediosPago.comision / 100));

            // 4. Llamar a la capa de datos para ejecutar la transacción en la base de datos
            return objVentaDatos.FinalizarReservaComoVenta(
                reserva.id_reserva,
                totalFinal,
                mediosPago.id_medioPago,
                user.id_user,
                reserva.objCliente.id_cliente,
                out mensaje
            );
        }

    }
}