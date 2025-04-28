using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Producto_negocio
    {
        private Producto_Datos objProduct_datos = new Producto_Datos();

        public List<Producto> Listar()
        {
            return objProduct_datos.Listar();
        }

        public int Registrar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.nombre == "")
            {
                Mensaje += "Debe ingresar un nombre\n";
            }

            if (obj.descripcion == "")
            {
                Mensaje += "Debe ingresar una descripion\n";
            }

            if (obj.marca == "")
            {
                Mensaje += "Debe ingresar un marca\n";
            }

            if (obj.modelo == "")
            {
                Mensaje += "Debe ingresar una contraseña\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objProduct_datos.Registrar(obj, out Mensaje);
            }

        }
        public bool Editar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.nombre == "")
            {
                Mensaje += "Debe ingresar un nombre\n";
            }

            if (obj.descripcion == "")
            {
                Mensaje += "Debe ingresar una descripion\n";
            }

            if (obj.marca == "")
            {
                Mensaje += "Debe ingresar un marca\n";
            }

            if (obj.modelo == "")
            {
                Mensaje += "Debe ingresar una contraseña\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objProduct_datos.Editar(obj, out Mensaje);
            }
        }
        public bool Eliminar(Producto obj, out string Mensaje)
        {
            return objProduct_datos.Eliminar(obj, out Mensaje);
        }
    }
}
