using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Informe
    {
        private int id_informe { get; set; }
        private string titulo { get; set; }
        private string descripcion { get; set; }
        private DateTime fecha_generacion
        { get; set; }
        private string tipo_informe { get; set; }
        private Usuario objUsuario { get; set; }
        private List<Ventas> ventas { get; set; }
    }
}
