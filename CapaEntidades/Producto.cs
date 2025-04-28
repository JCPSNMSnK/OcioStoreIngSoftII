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
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public decimal precio { get; set; }
        public int stock { get; set; }
        public bool baja { get; set; }
        public Categoria objCategoria { get; set; }
        public SubCategoria objSubCategoria { get; set; }
    }
}
