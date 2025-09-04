using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Factura
    {
        public int id_factura { get; set; }
        public Ventas objVenta { get; set; } // Mapeo de la clave foránea a un objeto
        public FacturaTipo objTipoFactura { get; set; } // Mapeo de la clave foránea a un objeto
        public DateTime fecha_emision { get; set; }

        public Factura()
        {
        }

        public Factura(Ventas venta, FacturaTipo tipoFactura, DateTime fechaEmision)
        {
            this.id_factura = 0; // El ID se generará en la base de datos
            this.objVenta = venta;
            this.objTipoFactura = tipoFactura;
            this.fecha_emision = fechaEmision;
        }

        public Factura(int idFactura, Ventas venta, FacturaTipo tipoFactura, DateTime fechaEmision)
        {
            this.id_factura = idFactura;
            this.objVenta = venta;
            this.objTipoFactura = tipoFactura;
            this.fecha_emision = fechaEmision;
        }
    }
}