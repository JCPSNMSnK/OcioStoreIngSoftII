using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Permiso
    {
        private int id_permiso { get; set; }
        private Roles objRoles { get; set; }
        private DateTime nombreAcceso { get; set; }
        private string fecha_registro { get; set; }
    }
}
