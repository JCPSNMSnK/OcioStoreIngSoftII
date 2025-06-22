using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class MediosPago
    {
        public int id_medioPago { get; private set; }
        public string nombre_medio { get; private set; }
        public decimal comision { get; private set; }

        public MediosPago(int idMedioPago, string nombreMedio, decimal comisionAplicable)
        {
            this.id_medioPago = idMedioPago;
            this.nombre_medio = nombreMedio;
            this.comision = comisionAplicable;
        }
    }
}
