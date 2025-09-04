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
        public Producto objProducto { get; set; }
        public int cantidad { get; set; }
        public decimal precio_unitario { get; set; }

        public DetalleCompra()
        {
        }
        
        public DetalleCompra(Producto producto, int cantidad, decimal precio_unitario)
        {
            this.id_detalle_compra = 0; // Se autogenerará en la base de datos
            this.objProducto = producto;
            this.cantidad = cantidad;
            this.precio_unitario = precio_unitario;
        }

        public DetalleCompra(int idDetalleCompra, Producto producto, int cantidad, decimal precio_unitario)
        {
            this.id_detalle_compra = idDetalleCompra;
            this.objProducto = producto;
            this.cantidad = cantidad;
            this.precio_unitario = precio_unitario;
        }
    }
}