using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Perfil_negocio
    {
        private Perfiles_Datos objPerfil_datos = new Perfiles_Datos();

        public List<Perfil> Listar()
        {
            return objPerfil_datos.Listar();
        }
    }
}
