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
        public string telefono_user { get; set; }
        public string direccion_user { get; set; }
        public string localidad_user { get; set; }
        public string provincia_user { get; set; }

        public string NombreRol
        {
            get { return objRoles != null ? objRoles.nombre_rol : ""; }
        }

        public Usuario(string apellido, string nombre, int dni, string mail, string username, string pass, Roles rol, string telefono_user, string direccion_user, string localidad_user, string provincia_user)
        {
            this.id_user = 0; // ID por defecto, asumirá uno real al persistir
            this.apellido = apellido;
            this.nombre = nombre;
            this.dni = dni;
            this.mail = mail;
            this.username = username;
            this.pass = pass;
            this.baja_user = false; // Por defecto, un usuario nuevo no está de baja
            this.objRoles = rol;
            this.telefono_user = telefono_user;
            this.direccion_user = direccion_user;
            this.localidad_user = localidad_user;
            this.provincia_user = provincia_user;
        }

        public Usuario(string apellido, string nombre, int dni, string mail, string username, string pass, bool bajaUser, Roles rol, string telefono_user, string direccion_user, string localidad_user, string provincia_user)
        {
            this.id_user = 0; // ID por defecto, asumirá uno real al persistir
            this.apellido = apellido;
            this.nombre = nombre;
            this.dni = dni;
            this.mail = mail;
            this.username = username;
            this.pass = pass;
            this.baja_user = bajaUser;
            this.objRoles = rol;
            this.telefono_user = telefono_user;
            this.direccion_user = direccion_user;
            this.localidad_user = localidad_user;
            this.provincia_user = provincia_user;
        }

        public Usuario(int idUser, string apellido, string nombre, int dni, string mail, string username, string pass, bool bajaUser, Roles rol, string telefono_user, string direccion_user, string localidad_user, string provincia_user)
        {
            this.id_user = idUser;
            this.apellido = apellido;
            this.nombre = nombre;
            this.dni = dni;
            this.mail = mail;
            this.username = username;
            this.pass = pass;
            this.baja_user = bajaUser;
            this.objRoles = rol;
            this.telefono_user = telefono_user;
            this.direccion_user = direccion_user;
            this.localidad_user = localidad_user;
            this.provincia_user = provincia_user;
        }

        public Usuario() { }
    }
}
