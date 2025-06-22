using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Permiso
    {
        public int id_permiso { get; private set; }
        public Roles objRoles { get; private set; }
        public string NombreAcceso { get; private set; } // Corregido: asumido que el nombre del acceso es un string
        public DateTime FechaRegistro { get; private set; }

        public Permiso(string nombreAcceso)
        {
            this.id_permiso = 0; // ID por defecto, asumirá uno real al persistir
            this.objRoles = null; // Rol por defecto en null, se asignará después o en otro constructor
            this.NombreAcceso = nombreAcceso;
            this.FechaRegistro = DateTime.Now; // La fecha de registro se establece en el momento actual
        }

        public Permiso(int idPermiso, Roles rol, string nombreAcceso, DateTime fechaRegistro)
        {
            this.id_permiso = idPermiso;
            this.objRoles = rol;
            this.NombreAcceso = nombreAcceso;
            this.FechaRegistro = fechaRegistro;
        }

    }
}
