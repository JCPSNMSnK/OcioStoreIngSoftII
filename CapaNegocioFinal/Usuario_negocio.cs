using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class Usuario_negocio
    {
        private Usuario_Datos objUser_datos = new Usuario_Datos();

        public List<Usuario> Listar()
        {
            return objUser_datos.Listar();
        }
    }


}
