using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class InformeDetalle
    {
        public int id_informeDetalle { get; set; }
        public Informe objInforme { get; set; }
        public Ventas objVenta { get; set; }
        public Usuario objUsuario { get; set; }
        public Producto objProducto { get; set; }
        public Categoria objCategoria { get; set; }
    }
}
