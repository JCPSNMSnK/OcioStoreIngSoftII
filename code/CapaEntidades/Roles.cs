using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Roles
    {
        public int id_rol { get; set; }
        public string nombre_rol { get; set; }
        public string descripcion { get; set; }

        public Roles(int idRol, string nombreRol, string descripcionRol)
        {
            this.id_rol = idRol;
            this.nombre_rol = nombreRol;
            this.descripcion = descripcionRol;
        }

        
    }
}
