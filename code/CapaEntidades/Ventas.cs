using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Ventas
    {
        public int id_venta { get; set; }
        public decimal total { get; set; }
        public MediosPago objMediosPago { get; set; }
        public Usuario objUsuario { get; set; }
        public DateTime fecha_venta { get; set; }
        public List<DetalleVenta> detalles { get; set; }

        public Ventas(Usuario usuario)
        {
            this.id_venta = 0; // O un valor que indique que aún no tiene ID
            this.total = 0; // Inicializa el total en 0
            this.objMediosPago = null; // Inicializa el medio de pago en null
            this.objUsuario = usuario; // Asigna el usuario proporcionado
            this.fecha_venta = DateTime.Now; // Toma la fecha y hora actual
            this.detalles = new List<DetalleVenta>(); // Inicializa la lista de detalles
        }

        public Ventas(int idVenta, decimal totalVenta, MediosPago mediosPago, Usuario usuario, DateTime fechaVenta, List<DetalleVenta> detallesVenta)
        {
            this.id_venta = idVenta;
            this.total = totalVenta;
            this.objMediosPago = mediosPago;
            this.objUsuario = usuario;
            this.fecha_venta = fechaVenta;
            this.detalles = detallesVenta ?? new List<DetalleVenta>(); // Si se pasa null, inicializa una nueva lista
        }

        public Ventas() { }

        public void AgregarDetalle(DetalleVenta detalle)
        {
            if (detalle == null) throw new ArgumentNullException(nameof(detalle));
            this.detalles.Add(detalle);
            RecalcularTotal(); // Recalcula el total de la venta
        }

        public void AsignarMedioPago(MediosPago medioPago)
        {
            this.objMediosPago = medioPago;
            RecalcularTotal(); // Recalcula el total de la venta con la comisión del nuevo medio de pago
        }

        private void RecalcularTotal()
        {
            // Suma los subtotales de todos los detalles
            decimal subtotalSinComision = detalles.Sum(d => (decimal)d.subtotal); // Asume DetalleVenta.subtotal es float/decimal

            decimal totalCalculado = subtotalSinComision;

            // Aplica la comisión si hay un medio de pago asignado
            if (objMediosPago != null && objMediosPago.comision > 0)
            {
                totalCalculado *= (1 + (objMediosPago.comision / 100m)); // ✅ dividido por 100
            }

            this.total = totalCalculado; // Asigna el total recalculado (cuidado con float vs decimal)
        }
    }
}
