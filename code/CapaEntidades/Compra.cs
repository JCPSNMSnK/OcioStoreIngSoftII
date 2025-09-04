using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Compra
    {
        public int id_compra { get; set; }
        public Proveedor objProveedor { get; set; } // Mapeo de la clave foránea a un objeto
        public DateTime fecha_compra { get; set; }
        public decimal total { get; set; }
        public List<DetalleCompra> detalles { get; set; }

        public Compra()
        {
        }

        public Compra(Proveedor proveedor, DateTime fechaCompra, decimal total, List<DetalleCompra> detalles)
        {
            this.id_compra = 0; // ID se autogenerará
            this.objProveedor = proveedor;
            this.fecha_compra = fechaCompra;
            this.detalles = detalles ?? new List<DetalleCompra>(); // Si se pasa null, inicializa una nueva lista
            this.total = total;
        }

        public Compra(int idCompra, Proveedor proveedor, DateTime fechaCompra, decimal total, List<DetalleCompra> detalles)
        {
            this.id_compra = idCompra;
            this.objProveedor = proveedor;
            this.fecha_compra = fechaCompra;
            this.total = total;
            this.detalles = detalles ?? new List<DetalleCompra>(); // Si se pasa null, inicializa una nueva lista
        }
    }
}

