using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Producto
    {
        private int id_producto { get; set; }
        private string nombre_producto { get; set; }
        private DateTime fechaIngreso { get; set; }
        private float precioLista { get; set; }
        private float precioVenta { get; set; }
        private bool baja_producto { get; set; }
        private int stock { get; set; }
        private int stock_min { get; set; }
        private string descripcion { get; set; }
        private List<Categoria> categoria { get; set; }
    }
}
