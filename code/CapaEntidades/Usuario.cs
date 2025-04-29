using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Usuario
    {
        public int id_user { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public int dni { get; set; }
        public string mail { get; set; }
        public string username { get; set; }
        public string pass { get; set; }
        public bool baja_user { get; set; }
        public Roles objRoles { get; set; }
    }
}
