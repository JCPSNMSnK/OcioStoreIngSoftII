using CapaDatos;
using CapaDatosFinal;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ProductoCategoria_negocio
    {
        private ProductoCategoria_Datos objProductoCategoria_datos = new ProductoCategoria_Datos();

        public List<ProductosCategorias> Listar()//mostrarCategorias
        {
            return objProductoCategoria_datos.Listar();
        }

    }
}
