using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Cliente
    {
        public int id_cliente { get; set; }
        public int dni_cliente { get; set; }
        public string nombre_cliente { get; set; }
        public string apellido_cliente { get; set; }
        public string telefono_cliente { get; set; }
        public string email_cliente { get; set; }
        public string direccion_cliente { get; set; }
        public string localidad_cliente { get; set; }
        public string provincia_cliente { get; set; }

        public Cliente()
        {
        }

        public Cliente(int dni, string nombre, string apellido, string telefono, string email, string direccion, string localidad, string provincia)
        {
            this.id_cliente = 0; // Se autogenerará en la base de datos
            this.dni_cliente = dni;
            this.nombre_cliente = nombre;
            this.apellido_cliente = apellido;
            this.telefono_cliente = telefono;
            this.email_cliente = email;
            this.direccion_cliente = direccion;
            this.localidad_cliente = localidad;
            this.provincia_cliente = provincia;
        }
        
        public Cliente(int id, int dni, string nombre, string apellido, string telefono, string email, string direccion, string localidad, string provincia)
        {
            this.id_cliente = id;
            this.dni_cliente = dni;
            this.nombre_cliente = nombre;
            this.apellido_cliente = apellido;
            this.telefono_cliente = telefono;
            this.email_cliente = email;
            this.direccion_cliente = direccion;
            this.localidad_cliente = localidad;
            this.provincia_cliente = provincia;
        }
    }
}