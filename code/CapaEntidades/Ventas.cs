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
        public float total { get; set; }
        public MediosPago objMediosPago { get; set; }
        public Usuario objUsuario { get; set; }
        public DateTime fecha_venta { get; set; }
    }
}
