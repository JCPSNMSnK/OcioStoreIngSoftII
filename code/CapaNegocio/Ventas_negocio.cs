using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

// Para System.Drawing
using System.Drawing;
using System.Drawing.Imaging;

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

        public List<Ventas> BuscarVentasConFiltros(DateTime inicio, DateTime fin, int idVendedor, int idCliente, int nroFactura)
        {
            return objVentas_datos.BuscarVentasConFiltros(inicio, fin, idVendedor, idCliente, nroFactura);
        }

        public Ventas ObtenerVentaCompleta(int idVenta)
        {
            return objVentas_datos.ObtenerVentaCompleta(idVenta);
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

            // Limpiar los detalles existentes y agregar los nuevos (asumiendo que la UI envía la lista completa cada vez)
            ventaActual.detalles.Clear(); // Limpiar antes de agregar si es una actualización total

            // Validar y agregar cada detalle
            int i = 0;
            string mensajeStock = "";
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
                if (!this.verificarStock(detalleDto.cantidad, detalleDto.objProducto, i, out mensajeStock))
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

        public bool AsignarClienteSeleccionado(Ventas ventaActual, MediosPago mediosPago, Cliente cliente, out string mensaje)
        {
            mensaje = string.Empty;
            List<string> errores = new List<string>();

            if (ventaActual == null)
            {
                errores.Add("La venta actual no puede ser nula.");
            }
            if (cliente.id_cliente <= 0)
            {
                errores.Add("Debe seleccionar un cliente válido.");
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
                    ventaActual.AsignarCliente(cliente); // Usa el método de la entidad Venta
                }
            }
            catch (Exception ex)
            {
                // Loggear la excepción
                errores.Add("Error al asignar el cliente: " + ex.Message);
            }

            if (errores.Any())
            {
                mensaje = string.Join(Environment.NewLine, errores);
                return false;
            }

            mensaje = "Cliente asignado correctamente.";
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

        public bool RegistrarVenta(Ventas objVenta, Factura objFactura, out int idVentaGenerada, out int idFacturaGenerada, out string mensaje) 
        {
            idVentaGenerada = 0;
            idFacturaGenerada = 0;
            mensaje = string.Empty;
            List<string> errores = new List<string>();


            if (errores.Any())
            {
                mensaje = string.Join(Environment.NewLine, errores);
                return false;
            }
            else
            {
                try
                {
                    bool registroExitoso = objVentas_datos.RegistrarVenta(objVenta, objVenta.objMediosPago, objFactura, out idVentaGenerada, out idFacturaGenerada, out mensaje);

                    if (!registroExitoso)
                    {
                        // Si el registro indica que falló, el mensaje de error ya viene de la capa de datos
                        return false;
                    }
                    else
                    {

                        return true;
                    }
                }
                catch (Exception)
                {

                    mensaje = "Ocurrió un error inesperado al registrar la venta. Por favor, inténtelo de nuevo más tarde.";
                    idVentaGenerada = 0;
                    return false;
                }
            }
        }

        public bool verificarStock(int cantidad, Producto producto, int i, out string mensaje)
        {
            mensaje = string.Empty;
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

            return verificado;
        }

        public bool verificacionPago(Ventas ventaAVerificar, Factura facturaAVerificar,out string mensaje, out int idVentaGen, out int idFacturaGen)
        {
            mensaje = string.Empty;
            idVentaGen = 0;
            idFacturaGen = 0;

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

            bool resultadoVerifPago = ventaAVerificar.objMediosPago.verificacionPago(ventaAVerificar.objMediosPago, out mensaje);

            if (resultadoVerifPago)
            {
                RegistrarVenta(ventaAVerificar, facturaAVerificar, out idVentaGen, out idFacturaGen, out mensaje);

                mensaje = $"Pago de ${ventaAVerificar.total} verificado. Venta #{idVentaGen}, Factura #{idFacturaGen} \n " +
                    $"Esto tuvo el siguiente mensaje al ser registrado en la DB: " + mensaje;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}