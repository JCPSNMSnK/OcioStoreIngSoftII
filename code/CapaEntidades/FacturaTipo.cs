using System;

namespace CapaEntidades
{
    public class FacturaTipo
    {
        public int id_tipo_factura { get; set; }
        public string nombre_tipo_factura { get; set; }

        public FacturaTipo()
        {
        }

        public FacturaTipo(string nombreTipoFactura)
        {
            this.id_tipo_factura = 0; // ID se autogenerará
            this.nombre_tipo_factura = nombreTipoFactura;
        }

        public FacturaTipo(int idTipoFactura, string nombreTipoFactura)
        {
            this.id_tipo_factura = idTipoFactura;
            this.nombre_tipo_factura = nombreTipoFactura;
        }
    }
}