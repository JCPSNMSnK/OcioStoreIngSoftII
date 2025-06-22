using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Usuario
    {
        private int id_user { get; set; }
        private string apellido { get; set; }
        private string nombre { get; set; }
        private int dni { get; set; }
        private string mail { get; set; }
        private string username { get; set; }
        private string pass { get; set; }
        private bool baja_user { get; set; }
        private Roles objRoles { get; set; }
    }
}
