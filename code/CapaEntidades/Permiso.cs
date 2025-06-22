using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Permiso
    {
        public int id_permiso { get; set; }
        public Roles objRoles { get; set; }
        public string nombreAcceso { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Permiso(string nombreAcceso)
        {
            this.id_permiso = 0; // ID por defecto, asumirá uno real al persistir
            this.objRoles = null; // Rol por defecto en null, se asignará después o en otro constructor
            this.nombreAcceso = nombreAcceso;
            this.FechaRegistro = DateTime.Now; // La fecha de registro se establece en el momento actual
        }

        public Permiso(int idPermiso, Roles rol, string nombreAcceso, DateTime fechaRegistro)
        {
            this.id_permiso = idPermiso;
            this.objRoles = rol;
            this.nombreAcceso = nombreAcceso;
            this.FechaRegistro = fechaRegistro;
        }

        public Permiso()
        { 
        }

    }
}
