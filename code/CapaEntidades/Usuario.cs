using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Usuario
    {
        public int id_user { get; private set; }
        public string apellido { get; private set; }
        public string nombre { get; private set; }
        public int dni { get; private set; }
        public string mail { get; private set; }
        public string username { get; private set; }
        public string pass { get; private set; }
        public bool baja_user { get; private set; }
        public Roles objRoles { get; private set; }

        public Usuario(string apellido, string nombre, int dni, string mail, string username, string pass, Roles rol)
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
        }

        public Usuario(int idUser, string apellido, string nombre, int dni, string mail, string username, string pass, bool bajaUser, Roles rol)
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
        }

        
    }
}
