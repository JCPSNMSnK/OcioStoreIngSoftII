using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Reserva
    {
        public int id_reserva { get; set; }
        public Cliente objCliente { get; set; }
        public DateTime fecha_emision_reserva { get; set; }
        public DateTime fecha_vencimiento_reserva { get; set; }
        public float total_reserva { get; set; }

        public Reserva()
        {
        }

        public Reserva(Cliente cliente, DateTime fechaEmision, DateTime fechaVencimiento, float total)
        {
            this.id_reserva = 0; // Se autogenerará en la base de datos
            this.objCliente = cliente;
            this.fecha_emision_reserva = fechaEmision;
            this.fecha_vencimiento_reserva = fechaVencimiento;
            this.total_reserva = total;
        }

        public Reserva(int idReserva, Cliente cliente, DateTime fechaEmision, DateTime fechaVencimiento, float total)
        {
            this.id_reserva = idReserva;
            this.objCliente = cliente;
            this.fecha_emision_reserva = fechaEmision;
            this.fecha_vencimiento_reserva = fechaVencimiento;
            this.total_reserva = total;
        }
    }
}