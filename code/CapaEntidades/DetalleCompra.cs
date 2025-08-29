using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class DetalleCompra
    {
        public int id_detalle_compra { get; set; }
        public Compra objCompra { get; set; }
        public Producto objProducto { get; set; }
        public int cantidad { get; set; }
        public decimal subtotal { get; set; }

        public DetalleCompra()
        {
        }
        
        public DetalleCompra(Compra compra, Producto producto, int cantidad, decimal subtotal)
        {
            this.id_detalle_compra = 0; // Se autogenerará en la base de datos
            this.objCompra = compra;
            this.objProducto = producto;
            this.cantidad = cantidad;
            this.subtotal = subtotal;
        }

        public DetalleCompra(int idDetalleCompra, Compra compra, Producto producto, int cantidad, decimal subtotal)
        {
            this.id_detalle_compra = idDetalleCompra;
            this.objCompra = compra;
            this.objProducto = producto;
            this.cantidad = cantidad;
            this.subtotal = subtotal;
        }
    }
}