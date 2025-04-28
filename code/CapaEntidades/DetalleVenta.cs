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
        public Producto objProducto { get; set;}
        public int cantidad { get; set; }
    }
}
