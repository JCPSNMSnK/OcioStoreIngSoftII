using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Ventas
    {
        private int id_venta { get; set; }
        private float total { get; set; }
        private MediosPago objMediosPago { get; set; }
        private Usuario objUsuario { get; set; }
        private DateTime fecha_venta { get; set; }
    }
}
