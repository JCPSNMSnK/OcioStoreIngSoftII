using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Categoria_negocio
    {
        private Categoria_Datos objCategoria_datos = new Categoria_Datos();

        public List<Categoria> Listar()
        {
            return objCategoria_datos.Listar();
        }
    }
}
