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

        public bool Editar(Producto objProducto, Categoria objCategoria, out string mensaje)
        {
            mensaje = string.Empty;

            // **Business Validations** - Same rules apply for editing as for registering.
            if (objProducto.precioLista < 0)
            {
                mensaje = "El precio de lista no puede ser negativo.";
                return false;
            }
            if (objProducto.precioVenta < 0)
            {
                mensaje = "El precio de venta no puede ser negativo.";
                return false;
            }
            if (objProducto.stock < 0)
            {
                mensaje = "El stock no puede ser negativo.";
                return false;
            }
            if (objProducto.stock_min < 0)
            {
                mensaje = "El stock mínimo no puede ser negativo.";
                return false;
            }
            if (objProducto.precioVenta < objProducto.precioLista)
            {
                mensaje = "El precio de venta no puede ser menor que el precio de lista.";
                return false;
            }
            if (objProducto.stock_min > objProducto.stock)
            {
                mensaje = "El stock mínimo no puede ser mayor que el stock actual.";
                return false;
            }
            if (objProducto.nombre_producto == "")
            {
                mensaje += "Debe ingresar un nombre\n";
            }

            if (objProducto.descripcion == "")
            {
                mensaje += "Debe ingresar una descripion\n";
            }

            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objProduct_datos.Editar(objProducto, objCategoria, out mensaje);
            }

        }
    }
}
