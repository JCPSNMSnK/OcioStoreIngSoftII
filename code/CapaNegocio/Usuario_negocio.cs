using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
        
        public int Registrar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.nombre == "")
            {
                Mensaje += "Debe ingresar un nombre\n";
            }

            if (obj.apellido == "")
            {
                Mensaje += "Debe ingresar un apellido\n";
            }

            if (obj.email == "")
            {
                Mensaje += "Debe ingresar un email\n";
            }

            if (obj.pass == "")
            {
                Mensaje += "Debe ingresar una contraseña\n";
            }

            if (obj.user == "")
            {
                Mensaje += "Debe ingresar un nombre de usuario\n";
            }

            if (obj.domicilio == "")
            {
                Mensaje += "Debe ingresar un domicilio\n";
            }

            if (obj.CP == 0)
            {
                Mensaje += "Debe ingresar Código postal\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objUser_datos.Registrar(obj, out Mensaje);
            }

        }
        public bool Editar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.nombre == "")
            {
                Mensaje += "Debe ingresar un nombre\n";
            }

            if (obj.apellido == "")
            {
                Mensaje += "Debe ingresar un apellido\n";
            }

            if (obj.email == "")
            {
                Mensaje += "Debe ingresar un email\n";
            }

            if (obj.pass == "")
            {
                Mensaje += "Debe ingresar una contraseña\n";
            }

            if (obj.user == "")
            {
                Mensaje += "Debe ingresar un nombre de usuario\n";
            }

            if (obj.domicilio == "")
            {
                Mensaje += "Debe ingresar un domicilio\n";
            }

            if (obj.CP == 0)
            {
                Mensaje += "Debe ingresar Código postal\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objUser_datos.Editar(obj, out Mensaje);
            }
        }
        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            return objUser_datos.Eliminar(obj, out Mensaje);
        }
    }


}
