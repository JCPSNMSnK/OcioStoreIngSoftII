using CapaDatos; // Asegúrate de que este using sea correcto
using CapaEntidades;
using System;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class Producto_negocio
    {
        // Instancia de la Capa de Datos (dependencia)
        // Se recomienda inyectar esta dependencia, pero para simplificar, se instancia directamente.
        private readonly Producto_Datos _objProductoDatos;

        public Producto_negocio()
        {
            _objProductoDatos = new Producto_Datos();
        }


        public List<Producto> Listar()
        {
            return _objProductoDatos.Listar();
        }

        public int Registrar(Producto objProducto, Categoria objCategoria, out string mensaje)
        {
            mensaje = string.Empty;

            // **Validaciones de Reglas de Negocio (obligatorias y lógicas)**
            if (string.IsNullOrWhiteSpace(objProducto.nombre_producto))
            {
                mensaje += "El nombre del producto es obligatorio.\n";
            }
            if (string.IsNullOrWhiteSpace(objProducto.descripcion))
            {
                mensaje += "La descripción del producto es obligatoria.\n";
            }
            if (objProducto.precioLista < 0)
            {
                mensaje += "El precio de lista no puede ser negativo.\n";
            }
            if (objProducto.precioVenta < 0)
            {
                mensaje += "El precio de venta no puede ser negativo.\n";
            }
            if (objProducto.stock < 0)
            {
                mensaje += "El stock no puede ser negativo.\n";
            }
            if (objProducto.stock_min < 0)
            {
                mensaje += "El stock mínimo no puede ser negativo.\n";
            }
            // Regla de negocio: El precio de venta no puede ser menor que el precio de lista
            if (objProducto.precioVenta < objProducto.precioLista)
            {
                mensaje += "El precio de venta no puede ser menor que el precio de lista.\n";
            }
            // Regla de negocio: El stock mínimo no puede ser mayor que el stock actual
            if (objProducto.stock_min > objProducto.stock)
            {
                mensaje += "El stock mínimo no puede ser mayor que el stock actual.\n";
            }

            // Si hay mensajes de validación de negocio, se retorna 0 (fallo)
            if (!string.IsNullOrEmpty(mensaje))
            {
                return 0;
            }

            // Si las validaciones de negocio pasan, se delega a la capa de datos
            return _objProductoDatos.Registrar(objProducto, objCategoria, out mensaje);
        }

        /// <summary>
        /// Edita un producto existente, aplicando las reglas de negocio.
        /// </summary>
        /// <param name="objProducto">Objeto Producto con los datos actualizados.</param>
        /// <param name="objCategoria">Objeto Categoria asociado al producto.</param>
        /// <param name="mensaje">Mensaje de éxito o error de la operación.</param>
        /// <returns>True si la edición fue exitosa, False en caso contrario.</returns>
        public bool Editar(Producto objProducto, Categoria objCategoria, out string mensaje)
        {
            mensaje = string.Empty;

            // **Validaciones de Reglas de Negocio (las mismas que para registrar)**
            if (string.IsNullOrWhiteSpace(objProducto.nombre_producto))
            {
                mensaje += "El nombre del producto es obligatorio.\n";
            }
            if (string.IsNullOrWhiteSpace(objProducto.descripcion))
            {
                mensaje += "La descripción del producto es obligatoria.\n";
            }
            if (objProducto.precioLista < 0)
            {
                mensaje += "El precio de lista no puede ser negativo.\n";
            }
            if (objProducto.precioVenta < 0)
            {
                mensaje += "El precio de venta no puede ser negativo.\n";
            }
            if (objProducto.stock < 0)
            {
                mensaje += "El stock no puede ser negativo.\n";
            }
            if (objProducto.stock_min < 0)
            {
                mensaje += "El stock mínimo no puede ser negativo.\n";
            }
            if (objProducto.precioVenta < objProducto.precioLista)
            {
                mensaje += "El precio de venta no puede ser menor que el precio de lista.\n";
            }
            if (objProducto.stock_min > objProducto.stock)
            {
                mensaje += "El stock mínimo no puede ser mayor que el stock actual.\n";
            }

            // Si hay mensajes de validación de negocio, se retorna false (fallo)
            if (!string.IsNullOrEmpty(mensaje))
            {
                return false;
            }

            // Si las validaciones de negocio pasan, se delega a la capa de datos
            return _objProductoDatos.Editar(objProducto, objCategoria, out mensaje);
        }
    }
}