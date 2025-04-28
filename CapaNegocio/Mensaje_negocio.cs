using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Mensaje_negocio
    {
        private Mensaje_Datos objMensaje_datos = new Mensaje_Datos();

        public List<Mensaje> Listar()
        {
            return objMensaje_datos.Listar();
        }

        public bool Registrar(Mensaje obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            return objMensaje_datos.Registrar(obj, out Mensaje);

        }
    }
}
