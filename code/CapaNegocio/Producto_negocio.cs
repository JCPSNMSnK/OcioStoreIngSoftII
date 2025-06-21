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

        public List<Producto> Listar()//mostrarProducto
        {
            return objProduct_datos.Listar();
        }

        public int Registrar(Producto obj, Categoria objCat, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(obj.nombre_producto))
                Mensaje += "Debe ingresar un nombre.\n";

            if (string.IsNullOrWhiteSpace(obj.descripcion))
                Mensaje += "Debe ingresar una descripción.\n";

            if (Mensaje != string.Empty)
                return 0;

            return objProduct_datos.Registrar(obj, objCat, out Mensaje);
        }

        public bool Editar(Producto obj, Categoria objCat, out string Mensaje)
        {//modificarProducto
            Mensaje = string.Empty;

            if (obj.nombre_producto == "")
            {
                Mensaje += "Debe ingresar un nombre\n";
            }

            if (obj.descripcion == "")
            {
                Mensaje += "Debe ingresar una descripion\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objProduct_datos.Editar(obj, objCat,out Mensaje);
            }
        }
        public bool Eliminar(Producto obj, out string Mensaje)
        {//quitarProducto
            return objProduct_datos.Eliminar(obj, out Mensaje);
        }
    }
}
