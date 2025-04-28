using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Permiso_negocio
    {
        private Permiso_Datos objPermiso_datos = new Permiso_Datos();

        public List<Permiso> Listar(int idusuario)
        {
            return objPermiso_datos.Listar(idusuario);
        }
    }
}
