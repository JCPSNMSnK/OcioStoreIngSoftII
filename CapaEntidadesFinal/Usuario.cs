using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Usuario
    {
        public int id_usuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Perfil objPerfil { get; set; }
        public string baja { get; set; }
        public string user { get; set; }
        public string pass { get; set; }
        public string email { get; set; }
        public string domicilio { get; set; }
        public int CP { get; set; }
    }
}
