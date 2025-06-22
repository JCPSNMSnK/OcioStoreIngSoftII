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

        public bool RegistrarVenta(Ventas objVenta, out int idVentaGenerada, out string mensaje)
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
                if (objVenta.objUsuario == null || objVenta.objUsuario.id_user == 0)
                {
                    errores.Add("Debe especificar un usuario válido para la venta.");
                }

                if (objVenta.objMediosPago == null || objVenta.objMediosPago.id_medioPago == 0)
                {
                    errores.Add("Debe especificar un medio de pago válido para la venta.");
                }

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
                        /*//verificarStock() sería esto
                        if (detalle.cantidad <= 0)
                        {
                            errores.Add($"Detalle {i}: La cantidad del producto debe ser mayor a cero.");
                        }
                        if (detalle.cantidad <= detalle.objProducto.stock)
                        {
                            errores.Add($"Detalle {i}: La cantidad del producto excede la cantidad disponible.");
                        }
                        if ((detalle.objProducto.stock - detalle.cantidad) >= detalle.objProducto.stockMin)
                        {
                            errores.Add($"Detalle {i}: La cantidad del producto excede la cantidad disponible para stock minimo.");
                        }*/
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

                    MediosPago objMetPago = new MediosPago();
                    //Seleccionar Medios Pago
                    //Calcular recargo según la comisión
                    //Verificar Pago Medio de Pago
                    //imprimirInfo de la Venta
                    //Generar Factura de la venta

                    //Persistencia de la venta exitosa
                    // La capa de negocio invoca al método de la capa de datos que maneja la transacción
                    bool registroExitoso = objVentas_datos.RegistrarVenta(objVenta, objMetPago, out mensaje);

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

        public bool verificarStock(int cantidad, Producto producto, int i)
        {
            String mensaje = string.Empty;
            int index = i;
            bool verificado = true;

            if (cantidad <= 0)
            {
                mensaje = $"Detalle {index}: La cantidad del producto debe ser mayor a cero.";
                verificado = false;
            }
            if (cantidad <= producto.stock)
            {
                mensaje = $"Detalle {index}: La cantidad del producto excede la cantidad disponible.";
                verificado = false;
            }
            if ((producto.stock - cantidad) >= producto.stock_min)
            {
                mensaje = $"Detalle {index}: La cantidad del producto excede la cantidad disponible para stock minimo.";
                verificado = false;
            }

            return verificado;
        }
    }
}