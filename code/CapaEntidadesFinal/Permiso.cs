using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Permiso
    {
        public int id_permiso { get; set; }
        public Perfil objPerfil { get; set; }
        public string nombreAcceso { get; set; }
        public string fecha_registro { get; set; }
    }
}
