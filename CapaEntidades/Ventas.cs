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
        public MedioPago objMedioPago { get; set; }
        public Usuario objUsuario { get; set; }
        public string fecha_venta { get; set; }
    }
}
