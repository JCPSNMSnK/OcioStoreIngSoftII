using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Informe
    {
        public int id_informe { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public string fecha_generacion { get; set; }
        public string tipo_informe { get; set; }
        public Usuario objUsuario { get; set; }
    }
}
