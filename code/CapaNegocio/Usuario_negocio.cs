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

        public List<Usuario> Listar()//mostrarUsuarios -> mostrarEmpleados
        {
            return objUser_datos.Listar();
        }

        public int Registrar(Usuario obj, out string Mensaje)//crearUsuario
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


            if (obj.pass == "")
            {
                Mensaje += "Debe ingresar una contraseña\n";
            }

            if (obj.username == "")
            {
                Mensaje += "Debe ingresar un nombre de usuario\n";
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
        public bool Editar(Usuario obj, out string Mensaje)//editarUsuario
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

            if (obj.pass == "")
            {
                Mensaje += "Debe ingresar una contraseña\n";
            }

            if (obj.username == "")
            {
                Mensaje += "Debe ingresar un nombre de usuario\n";
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
        public bool Eliminar(Usuario obj, out string Mensaje)//eliminarUsuario
        {
            return objUser_datos.Eliminar(obj, out Mensaje);
        }
    }


}
