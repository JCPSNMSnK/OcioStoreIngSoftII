using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Roles_negocio
    {
        private Roles_Datos objRoles_datos = new Roles_Datos();

        public List<Roles> Listar()
        {
            return objRoles_datos.Listar();
        }
    }
}
