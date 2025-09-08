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
        private readonly Ventas_Datos objVentaDatos;

        public Factura_Negocio()
        {
            objFacturaDatos = new Factura_Datos();
            objVentaDatos = new Ventas_Datos();
        }


        public int GenerarFactura(Ventas objVenta, FacturaTipo objTipoFactura, out string mensaje)
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
    }
}