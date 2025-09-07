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

        public bool Registrar(Categoria categoria, out string mensaje)
        {
            mensaje = string.Empty;

            // Validación 1: El nombre de la categoría no puede estar vacío.
            if (string.IsNullOrWhiteSpace(categoria.nombre_categoria))
            {
                mensaje = "El nombre de la categoría no puede ser vacío.";
                return false; // Se retorna 0 si la validación falla
            }

            // Validación 2: El nombre no puede ser un duplicado de una categoría existente.
            // Para un nuevo registro, el ID es 0, por lo que la función de validación
            // en la capa de datos debe manejar este caso correctamente.
            if (objCategoria_datos.NombreExiste(0, categoria.nombre_categoria))
            {
                mensaje = "Ya existe una categoría con el mismo nombre.";
                return false; // Se retorna 0 si la validación falla
            }

            // Si las validaciones de negocio pasan, se delega el registro a la capa de datos.
            return objCategoria_datos.registrarCategoria(categoria, out mensaje);
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

        public List<Categoria> BuscarCategoriasGeneral(string filtros)
        {
            return objCategoria_datos.BuscarCategoriasGeneral(filtros);
        }

        public Dictionary<int, int> ContarProductosPorCategoria()
        {
            // La capa de negocio invoca el método de la capa de datos
            // y devuelve directamente el resultado.
            return objCategoria_datos.ContarProductosPorCategoria();
        }

    }
}
