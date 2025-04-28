using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class SubCategoria_negocio
    {
        private SubCategoria_Datos objSubCategoria_datos = new SubCategoria_Datos();

        public List<SubCategoria> Listar()
        {
            return objSubCategoria_datos.Listar();
        }
    }
}
