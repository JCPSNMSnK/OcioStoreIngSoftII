using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Mensaje
    {
        public int id_mensaje { get; set; }
        public string nombreCliente { get; set; }
        public string emailCliente { get; set; }
        public string mensaje { get; set; }
        public bool leido { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string respuesta { get; set; }
    }
}
