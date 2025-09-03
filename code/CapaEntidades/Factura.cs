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
        public Venta objVenta { get; set; } // Mapeo de la clave foránea a un objeto
        public TipoFactura objTipoFactura { get; set; } // Mapeo de la clave foránea a un objeto
        public DateTime fecha_emision { get; set; }

        public Factura()
        {
        }

        public Factura(Venta venta, TipoFactura tipoFactura, DateTime fechaEmision)
        {
            this.id_factura = 0; // El ID se generará en la base de datos
            this.objVenta = venta;
            this.objTipoFactura = tipoFactura;
            this.fecha_emision = fechaEmision;
        }

        public Factura(int idFactura, Venta venta, TipoFactura tipoFactura, DateTime fechaEmision)
        {
            this.id_factura = idFactura;
            this.objVenta = venta;
            this.objTipoFactura = tipoFactura;
            this.fecha_emision = fechaEmision;
        }
    }
}