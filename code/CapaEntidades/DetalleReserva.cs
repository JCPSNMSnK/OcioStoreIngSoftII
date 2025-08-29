using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class DetalleReserva
    {
        public int id_detalle_reserva { get; set; }
        public Reserva objReserva { get; set; }
        public Producto objProducto { get; set; }
        public int cantidad { get; set; }

        public DetalleReserva()
        {
        }

        public DetalleReserva(Reserva reserva, Producto producto, int cantidad)
        {
            this.id_detalle_reserva = 0; // Se autogenerará en la base de datos
            this.objReserva = reserva;
            this.objProducto = producto;
            this.cantidad = cantidad;
        }

        public DetalleReserva(int idDetalle, Reserva reserva, Producto producto, int cantidad)
        {
            this.id_detalle_reserva = idDetalle;
            this.objReserva = reserva;
            this.objProducto = producto;
            this.cantidad = cantidad;
        }
    }
}