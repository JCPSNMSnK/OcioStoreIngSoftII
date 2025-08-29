using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Proveedor
    {
        public int id_proveedor { get; set; }
        public string nombre_proveedor { get; set; }
        public string telefono_proveedor { get; set; }
        public string cuit_proveedor { get; set; }

        public Proveedor()
        {
        }

        public Proveedor(string nombre, string telefono, string cuit)
        {
            this.id_proveedor = 0; // Se autogenerará en la base de datos
            this.nombre_proveedor = nombre;
            this.telefono_proveedor = telefono;
            this.cuit_proveedor = cuit;
        }

        public Proveedor(int id, string nombre, string telefono, string cuit)
        {
            this.id_proveedor = id;
            this.nombre_proveedor = nombre;
            this.telefono_proveedor = telefono;
            this.cuit_proveedor = cuit;
        }
    }
}