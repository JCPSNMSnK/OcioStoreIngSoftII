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

        public List<Categoria> Listar()//mostrarCategorias
        {
            return objCategoria_datos.Listar();
        }

        public bool Modificar(Categoria categoria, out string mensaje)
        {
            mensaje = string.Empty;

            // Validación: El nombre de la categoría no puede estar vacío
            if (string.IsNullOrWhiteSpace(categoria.nombre_categoria))
            {
                mensaje = "El nombre de la categoría no puede ser vacío.";
                return false;
            }

            // Validación: El nuevo nombre no puede ser un duplicado de otra categoría existente.
            if (objCategoria_datos.NombreExiste(categoria.id_categoria, categoria.nombre_categoria))
            {
                mensaje = "Ya existe una categoría con el mismo nombre.";
                return false;
            }

            // Si las validaciones pasan, se llama a la capa de datos.
            return objCategoria_datos.ModificarCategoria(categoria, out mensaje);
        }

        public bool DarDeBaja(int id_categoria, out string mensaje)
        {
            mensaje = string.Empty;

            // Se delega toda la lógica de baja a la capa de datos.
            return objCategoria_datos.DarDeBajaCategoria(id_categoria, out mensaje);
        }

    }
}
