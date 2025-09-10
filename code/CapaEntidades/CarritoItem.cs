using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CarritoItem
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal => Precio * Cantidad; // Propiedad calculada
    }
}
