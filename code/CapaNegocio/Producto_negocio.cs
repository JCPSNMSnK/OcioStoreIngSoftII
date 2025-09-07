using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;

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

        public int Registrar(Producto objProducto, Categoria objCategoria, out string mensaje)
        {
            mensaje = string.Empty;

            // **Validaciones de Reglas de Negocio (nuevas y existentes)**
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

            if (objProducto.cod_producto == 0)
            {
                mensaje += "El código de producto es obligatorio.\n";
            }

            if (objProducto.id_proveedor == 0)
            {
                mensaje += "Debe asignar un proveedor al producto.\n";
            }

            // Si hay mensajes de validación, se retorna 0 (fallo)
            if (!string.IsNullOrEmpty(mensaje))
            {
                return 0;
            }

            // Si las validaciones de negocio pasan, se delega a la capa de datos
            // La capa de datos se encargará de validar la unicidad del código de producto con la DB
            return _objProductoDatos.Registrar(objProducto, objCategoria, out mensaje);
        }

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

            if (objProducto.cod_producto == 0)
            {
                mensaje += "El código de producto es obligatorio.\n";
            }

            if (objProducto.id_proveedor == 0)
            {
                mensaje += "Debe asignar un proveedor al producto.\n";
            }
            // -------------------------

            // Si hay mensajes de validación, se retorna false (fallo)
            if (!string.IsNullOrEmpty(mensaje))
            {
                return false;
            }

            // Si las validaciones de negocio pasan, se delega a la capa de datos
            return _objProductoDatos.Editar(objProducto, objCategoria, out mensaje);
        }

        //Metodo para notificar cuando un producto llegó a stock minimo o por debajo.
        public List<Producto> ObtenerProductosConStockBajo()
        {
            return _objProductoDatos.ListarProductosConStockBajo();
        }

        public List<Producto> BuscarProductosGeneral(string filtros)
        {
            return _objProductoDatos.BuscarProductosGeneral(filtros);
        }

    }
}