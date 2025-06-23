using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class Ventas_negocio
    {
        private Ventas_Datos objVentas_datos = new Ventas_Datos();

        public List<Ventas> ListarVentas()
        {
            try
            {
                return objVentas_datos.ListarVentas();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("No se pudo obtener la lista de ventas. Por favor, intente de nuevo más tarde.", ex);
            }
        }

        public Ventas IniciarVenta(Usuario usuario, out string mensaje)
        {
            mensaje = string.Empty;
            if (usuario == null || usuario.id_user == 0)
            {
                mensaje = "Debe proporcionar un usuario válido para iniciar la venta.";
                return null;
            }

            try
            {
                Ventas nuevaVenta = new Ventas(usuario);
                mensaje = "Venta iniciada exitosamente. Por favor seleccione los productos.";
                return nuevaVenta;
            }
            catch (Exception ex)
            {
                // Loggear la excepción
                mensaje = "Error al iniciar la venta: " + ex.Message;
                return null;
            }
        }

        public bool ProcesarDetalles(Ventas ventaActual, List<DetalleVenta> detallesNuevos, out string mensaje)
        {
            mensaje = string.Empty;
            List<string> errores = new List<string>();

            if (ventaActual == null)
            {
                errores.Add("La venta actual no puede ser nula.");
            }
            if (detallesNuevos == null || !detallesNuevos.Any())
            {
                errores.Add("Debe proporcionar al menos un detalle de producto.");
            }

            if (errores.Any())
            {
                mensaje = string.Join(Environment.NewLine, errores);
                return false;
            }

            // Limpiar los detalles existentes y agregar los nuevos (asumiendo que la UI envía la lista completa cada vez)
            // Si la UI envía solo los nuevos para agregar, ajustar esta lógica.
            ventaActual.detalles.Clear(); // Limpiar antes de agregar si es una actualización total

            // Validar y agregar cada detalle
            int i = 0;
            foreach (var detalleDto in detallesNuevos) // Renombrado a detalleDto para indicar que puede venir incompleto
            {
                i++;
                if (detalleDto == null)
                {
                    errores.Add($"Detalle {i}: El detalle no puede ser nulo.");
                    continue;
                }
                if (detalleDto.objProducto == null || detalleDto.objProducto.id_producto == 0)
                {
                    errores.Add($"Detalle {i}: Debe especificar un producto válido para el detalle.");
                    continue; // No podemos seguir sin un producto
                }
                if (!this.verificarStock(detalleDto.cantidad, detalleDto.objProducto, i, mensajeStock))
                {
                    errores.Add("Error al verificar Stock: " + mensajeStock);
                }

                try
                {
                    ventaActual.AgregarDetalle(detalleDto); // Usa el método de la entidad Venta
                }
                catch (Exception ex)
                {
                    // Loggear el error de un detalle específico
                    errores.Add($"Detalle {i}: Error al procesar el producto {detalleDto.objProducto.id_producto}: {ex.Message}");
                }
            }

            if (errores.Any())
            {
                mensaje = string.Join(Environment.NewLine, errores);
                return false;
            }

            mensaje = "Detalles de venta procesados y total calculado.";
            return true;
        }

        public bool SeleccionarMedioPagoYCalcular(Ventas ventaActual, MediosPago mediosPago, out string mensaje)
        {
            mensaje = string.Empty;
            List<string> errores = new List<string>();

            if (ventaActual == null)
            {
                errores.Add("La venta actual no puede ser nula.");
            }
            if (mediosPago.id_medioPago <= 0)
            {
                errores.Add("Debe seleccionar un medio de pago válido.");
            }

            if (errores.Any())
            {
                mensaje = string.Join(Environment.NewLine, errores);
                return false;
            }

            try
            {

                if (mediosPago == null)
                {
                    errores.Add("El medio de pago seleccionado no es válido o no existe.");
                }
                else
                {
                    ventaActual.AsignarMedioPago(mediosPago); // Usa el método de la entidad Venta
                }
            }
            catch (Exception ex)
            {
                // Loggear la excepción
                errores.Add("Error al obtener el medio de pago: " + ex.Message);
            }

            if (errores.Any())
            {
                mensaje = string.Join(Environment.NewLine, errores);
                return false;
            }

            mensaje = "Medio de pago asignado y total recalculado con comisión.";
            return true;
        }

        public bool RegistrarVenta(Ventas objVenta, out int idVentaGenerada, out string mensaje) //se utiliza solo para persistencia en la DB
        {
            idVentaGenerada = 0;
            mensaje = string.Empty;
            List<string> errores = new List<string>();

            if (objVenta == null)
            {
                errores.Add("El objeto Venta no puede ser nulo.");
            }
            else
            {

                if (objVenta.detalles == null || !objVenta.detalles.Any())
                {
                    errores.Add("La venta debe tener al menos un detalle de producto.");
                }
                else
                {
                    // Validar cada detalle de la venta
                    int i = 0;
                    foreach (var detalle in objVenta.detalles)
                    {
                        i++;
                        if (detalle == null)
                        {
                            errores.Add($"Detalle {i}: El detalle no puede ser nulo.");
                            continue;
                        }
                        if (detalle.objProducto == null || detalle.objProducto.id_producto == 0)
                        {
                            errores.Add($"Detalle {i}: Debe especificar un producto válido para el detalle.");
                        }
                        if (!this.verificarStock(detalle.cantidad, detalle.objProducto, i))
                        {
                            errores.Add("Error al verificar Stock");
                        }

                    }
                }

                // Aquí puedes calcular el total de la venta si no viene calculado
                // o validar que el total proporcionado coincide con la suma de los subtotales de los detalles.
                objVenta.total = objVenta.detalles.Sum(d => (decimal)d.subtotal);
                if (objVenta.total != objVenta.detalles.Sum(d => (decimal)d.subtotal))
                {
                    errores.Add("El total de la venta no coincide con la suma de los subtotales de los detalles.");
                }
            }


            if (errores.Any())
            {
                mensaje = string.Join(Environment.NewLine, errores);
                return false;
            }
            else
            {
                try
                {

                    //Persistencia de la venta exitosa
                    // La capa de negocio invoca al método de la capa de datos que maneja la transacción
                    bool registroExitoso = objVentas_datos.RegistrarVenta(objVenta, objVenta.objMediosPago, out mensaje);

                    if (!registroExitoso)
                    {
                        // Si el registro indica que falló, el mensaje de error ya viene de la capa de datos
                        return false;
                    }
                    else
                    {
                        // Operaciones adicionales de negocio después de un registro exitoso
                        // Ej: Actualizar stock de productos (llamando a un servicio de Productos) modificarproducto()
                        // _productoService.ActualizarStock(objVenta.Detalles);

                        return true;
                    }
                }
                catch (Exception ex)
                {
                    // Loggear la excepción (fundamental para entender qué falló)
                    // Log.Error(ex, "Error inesperado al registrar la venta en la capa de negocio.");
                    mensaje = "Ocurrió un error inesperado al registrar la venta. Por favor, inténtelo de nuevo más tarde.";
                    idVentaGenerada = 0;
                    return false;
                }
            }
        }

        public bool verificarStock(int cantidad, Producto producto, int i, out string mensaje)
        {
            String mensaje = string.Empty;
            int index = i;
            bool verificado = true;

            if (cantidad <= 0)
            {
                mensaje = $"Detalle {index}: La cantidad del producto debe ser mayor a cero.";
                verificado = false;
            }
            if (cantidad >= producto.stock)
            {
                mensaje = $"Detalle {index}: La cantidad del producto excede la cantidad disponible.";
                verificado = false;
            }
            if ((producto.stock - cantidad) <= producto.stock_min)
            {
                mensaje = $"Detalle {index}: La cantidad del producto excede la cantidad disponible para stock minimo.";
                verificado = false;
            }

            return verificado;
        }

        public bool verificacionPago(Ventas ventaAVerificar, out string mensaje)
        {
            mensaje = string.Empty;

            if (ventaAVerificar == null)
            {
                mensaje = "El objeto de venta para verificar el pago no puede ser nulo.";
                return false;
            }
            if (ventaAVerificar.total <= 0)
            {
                mensaje = "El total de la venta debe ser mayor a cero para procesar el pago.";
                return false;
            }
            if (ventaAVerificar.objMediosPago == null || ventaAVerificar.objMediosPago.id_medioPago == 0)
            {
                mensaje = "No se ha seleccionado un medio de pago para esta venta.";
                return false;
            }

            // Aquí puedes añadir más lógica de simulación basada en el tipo de medio de pago
            // Por ejemplo, simular que ciertos medios de pago fallan más a menudo.
            // if (ventaAVerificar.objMediosPago.nombre_medio.Contains("Tarjeta")) { /* Lógica específica */ }

            try
            {
                // Simulación de una llamada a una API externa o POS
                // Generamos un número aleatorio entre 0 y 99.
                // Simulamos un 80% de éxito, 20% de fallo.
                int resultadoSimulacion = _random.Next(100); // Genera un número entre 0 y 99

                if (resultadoSimulacion < 80) // 80% de probabilidad de éxito
                {
                    // Puedes añadir un pequeño retraso para simular el tiempo de respuesta de una API real
                    // System.Threading.Thread.Sleep(500); // Retraso de 500 milisegundos
                    RegistrarVenta(ventaAVerificar, idVentaRegistrada, mensajeDeRegistro);
                    mensaje = $"Pago de {ventaAVerificar.total:C} con '{ventaAVerificar.objMediosPago.nombre_medio}' verificado exitosamente." + 
                    "\tLa venta nro {idVentaRegistrada} tuvo el siguiente mensaje al ser registrada en la DB: " + mensajeDeRegistro;
                    return true;
                }
                else
                {
                    // Simular diferentes razones de fallo
                    if (resultadoSimulacion < 90)
                    {
                        mensaje = "Pago rechazado por la entidad bancaria. Fondos insuficientes.";
                    }
                    else if (resultadoSimulacion < 95)
                    {
                        mensaje = "Error de conexión con la pasarela de pagos. Intente de nuevo.";
                    }
                    else
                    {
                        mensaje = "Pago denegado. Tarjeta inválida o expirada.";
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Loggear la excepción real si ocurriera algo inesperado en la simulación
                // Log.Error(ex, "Error inesperado durante la simulación de verificación de pago.");
                mensaje = "Ocurrió un error interno al intentar verificar el pago: " + ex.Message;
                return false;
            }
        }
    }
}