using System;
using System.Collections.Generic;
using CapaDatos;
using CapaEntidades;
using System.IO;

namespace CapaNegocio
{
    public class Factura_Negocio
    {
        private readonly Factura_Datos objFacturaDatos;
        private readonly Venta_Datos objVentaDatos;

        public Factura_Negocio()
        {
            objFacturaDatos = new Factura_Datos();
            objVentaDatos = new Venta_Datos();
        }


        public int GenerarFactura(Venta objVenta, FacturaTipo objTipoFactura, out string mensaje)
        {
            mensaje = string.Empty;
            int idFacturaGenerada = 0;

            // Validación 1: Verificar que la venta exista.
            if (objVenta == null || objVenta.id_venta <= 0)
            {
                mensaje = "Debe seleccionar una venta válida para generar la factura.";
                return 0;
            }

            // Validación 2: Verificar que el tipo de factura sea válido.
            if (objTipoFactura == null || objTipoFactura.id_tipo_factura <= 0)
            {
                mensaje = "Debe seleccionar un tipo de factura válido.";
                return 0;
            }

            // Si todas las validaciones de negocio pasan, se delega a la capa de datos.
            idFacturaGenerada = objFacturaDatos.GenerarFactura(
                objVenta.id_venta,
                objTipoFactura.id_tipo_factura,
                out mensaje
            );

            return idFacturaGenerada;
        }

        // Método para delegar la búsqueda de facturas a la capa de datos.
        public List<Factura> BuscarFacturas(int idCliente, DateTime fechaInicio, DateTime fechaFin, int idTipoFactura)
        {
            // Puedes agregar aquí validaciones de negocio adicionales si las necesitas.
            // Por ejemplo, que el rango de fechas sea lógico.

            return objFacturaDatos.BuscarFacturas(idCliente, fechaInicio, fechaFin, idTipoFactura);
        }

        /*public byte[] GenerarPDF(int idFactura, out string mensaje)
        {
            mensaje = string.Empty;
            byte[] pdfBytes = null;

            // 1. Validar el ID de la factura
            if (idFactura <= 0)
            {
                mensaje = "ID de factura no válido.";
                return null;
            }

            // 2. Obtener los datos completos de la factura desde la capa de datos
            Factura factura = objFacturaDatos.ObtenerFacturaCompleta(idFactura);

            if (factura == null)
            {
                mensaje = "No se encontró la factura.";
                return null;
            }

            // 3. Obtener los detalles de la venta (productos, cantidades, etc.)
            Venta venta = objVentaDatos.ObtenerVentaCompleta(factura.objVenta.id_venta);

            if (venta == null || venta.detalles == null || venta.detalles.Count == 0)
            {
                mensaje = "No se encontraron los detalles de la venta para la factura.";
                return null;
            }

            try
            {
                // 4. Crear el documento PDF en memoria
                using (MemoryStream ms = new MemoryStream())
                {
                    // La lógica para generar el PDF (usando iText, Syncfusion, etc.)
                    // Esta parte es específica de la biblioteca
                    // Aquí es donde ensambla el PDF con el encabezado, los datos de la factura,
                    // la tabla de productos, el total, etc.

                    // Ejemplo simplificado (lógica conceptual)
                    // Documento pdf = new Document(ms);
                    // pdf.Add(new Paragraph("Factura #" + factura.id_factura));
                    // pdf.Add(new Paragraph("Fecha: " + factura.fecha_emision.ToShortDateString()));
                    // pdf.Add(new Paragraph("Cliente: " + venta.objCliente.nombre_cliente));
                    // ... (crear la tabla con los detalles de venta) ...
                    // pdf.Close();

                    // Por ahora, devolveremos un array de bytes de ejemplo
                    pdfBytes = ms.ToArray();
                }

                mensaje = "PDF generado exitosamente.";
                return pdfBytes;
            }
            catch (Exception ex)
            {
                mensaje = "Error al generar el PDF: " + ex.Message;
                return null;
            }
        }*/
    }
}