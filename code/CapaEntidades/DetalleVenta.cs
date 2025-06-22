using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class DetalleVenta
    {
        private Ventas objVentas { get; set; }
        private Producto objProducto { get; set;}
        private int cantidad { get; set; }
    }
}
