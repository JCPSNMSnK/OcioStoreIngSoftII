using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class SubCategoria
    {
        public int id_subcategoria { get; set; }
        public Categoria objCategoria_subCat { get; set;}
        public string descripcion_subcategoria { get; set; }
    }
}
