using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CapaNegocio
{
    public class Producto_negocio
    {
        private readonly Producto_Datos _objProductoDatos;

        public Producto_negocio()
        {
            _objProductoDatos = new Producto_Datos();
        }

        public List<Producto> Listar()
        {
            return _objProductoDatos.Listar();
        }

        public int Registrar(Producto objProducto, out string mensaje)
        {
            mensaje = string.Empty;

            // --- Validaciones de Reglas de Negocio (nuevas y existentes) ---

            // ... (Validaciones de nombre, descripción, precios, stocks, etc. se mantienen igual)
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
            // ... (restantes validaciones de valores) ...
            if (objProducto.cod_producto == 0)
            {
                mensaje += "El código de producto es obligatorio.\n";
            }

            // --- MODIFICACIÓN DE LA VALIDACIÓN DEL PROVEEDOR ---
            // ANTES: objProducto.id_proveedor == 0
            // AHORA: Verificar que la lista de proveedores no sea nula y contenga al menos un elemento.
            if (objProducto.proveedores == null || objProducto.proveedores.Count == 0)
            {
                mensaje += "Debe asignar al menos un proveedor al producto.\n";
            }
            else
            {
                // Validación de negocio: Asegurar que al menos uno de los proveedores asociados esté ACTIVO.
                // Opcional, pero recomendado: No permitir registrar un producto si todos sus proveedores están de baja.
                if (objProducto.proveedores.All(p => p.baja_proveedor == true))
                {
                    mensaje += "Al menos uno de los proveedores asignados debe estar activo.\n";
                }
            }


            // Si hay mensajes de validación, se retorna 0 (fallo)
            if (!string.IsNullOrEmpty(mensaje))
            {
                return 0;
            }

            // Si las validaciones de negocio pasan, se delega a la capa de datos.
            // La DAL ya sabe cómo manejar el objeto Producto, incluyendo List<Proveedor>.
            return _objProductoDatos.Registrar(objProducto, out mensaje);
        }

        public bool Editar(Producto objProducto, out string mensaje)
        {
            mensaje = string.Empty;
            // **Validaciones de Reglas de Negocio (las mismas que para registrar)**

            // --- Validaciones básicas (se mantienen igual) ---
            if (string.IsNullOrWhiteSpace(objProducto.nombre_producto))
            {
                mensaje += "El nombre del producto es obligatorio.\n";
            }
            if (string.IsNullOrWhiteSpace(objProducto.descripcion))
            {
                mensaje += "La descripción del producto es obligatoria.\n";
            }
            // ... (restantes validaciones de precios, stocks, etc. se mantienen igual) ...
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
            if (objProducto.cod_producto == 0)
            {
                mensaje += "El código de producto es obligatorio.\n";
            }

            // --- MODIFICACIÓN DE LA VALIDACIÓN DEL PROVEEDOR (NUEVA LÓGICA) ---

            // ELIMINADO: if (objProducto.id_proveedor == 0) { ... }

            if (objProducto.proveedores == null || objProducto.proveedores.Count == 0)
            {
                mensaje += "Debe asignar al menos un proveedor al producto.\n";
            }
            else
            {
                // Regla de Negocio: Asegurar que al menos uno de los proveedores asociados esté ACTIVO.
                // Esto es especialmente importante durante la edición, ya que los proveedores podrían haberse dado de baja.
                if (objProducto.proveedores.All(p => p.baja_proveedor == true))
                {
                    mensaje += "Al menos uno de los proveedores asignados debe estar activo.\n";
                }
            }

            // -------------------------
            // Si hay mensajes de validación, se retorna false (fallo)
            if (!string.IsNullOrEmpty(mensaje))
            {
                return false;
            }

            // Si las validaciones de negocio pasan, se delega a la capa de datos
            // La DAL (_objProductoDatos.Editar) ya sabe cómo manejar el objeto Producto completo, 
            // incluyendo la lista de proveedores.
            return _objProductoDatos.Editar(objProducto, out mensaje);
        }

        //Metodo para notificar cuando un producto llegó a stock minimo o por debajo.
        public List<Producto> ObtenerProductosConStockBajo()
        {
            return _objProductoDatos.ListarProductosConStockBajo();
        }

        public List<Producto> BuscarProductosGeneral(string filtros, int idCategoria)
        {
            return _objProductoDatos.BuscarProductosGeneral(filtros, idCategoria);
        }

        // EN ProductoBLL.cs
        public Producto ObtenerProductoPorCodigo(int codigo)
        {
            // Llama al método que acabamos de crear en la DAL
            return _objProductoDatos.BuscarPorCodigo(codigo);
        }

    }
}