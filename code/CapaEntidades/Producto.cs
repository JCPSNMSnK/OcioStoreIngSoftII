using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Producto
    {
        public int id_producto { get; set; }
        public string nombre_producto { get; set; }
        public string fechaIngreso { get; set; }
        public decimal precioLista { get; set; }
        public decimal precioVenta { get; set; }
        public bool baja_producto { get; set; }
        public int stock { get; set; }
        public int stock_min { get; set; }
        public string descripcion { get; set; }
    }
}
