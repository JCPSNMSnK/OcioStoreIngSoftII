using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class DetalleVenta
    {
        public Ventas objVentas { get; set; }
        public Producto objProducto { get; set; }
        public int cantidad { get; set; }
        public decimal subtotal { get; set; }

        public DetalleVenta(Ventas venta, Producto producto, int cantidad)
        {
            this.objVentas = venta;
            this.objProducto = producto;
            this.cantidad = cantidad;
            this.subtotal = cantidad * producto.precioVenta; 
        }

        public DetalleVenta(Ventas venta, Producto producto, int cantidad, decimal subtotal)
        {
            this.objVentas = venta;
            this.objProducto = producto;
            this.cantidad = cantidad;
            this.subtotal = subtotal;
        }
        
    }
}
