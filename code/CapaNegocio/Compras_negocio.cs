using System;
using System.Collections.Generic;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class Compras_negocio
    {
        private readonly Compras_Datos objComprasDatos;

        public Compras_negocio()
        {
            objComprasDatos = new Compras_Datos();
        }

        public int RegistrarCompra(Compra objCompra, List<DetalleCompra> DetallesCompra, out string mensaje)
        {
            mensaje = string.Empty;
            int idCompraGenerada = 0;

            // Validación 1: El proveedor no puede ser nulo o tener un ID vacío.
            if (objCompra.objProveedor == null || objCompra.objProveedor.id_proveedor == 0)
            {
                mensaje = "Debe seleccionar un proveedor para la compra.";
                return 0;
            }

            // Validación 2: La compra debe tener al menos un producto.
            if (DetallesCompra == null || DetallesCompra.Count < 1)
            {
                mensaje = "La compra debe tener al menos un producto.";
                return 0;
            }

            // Validación 3: Las cantidades de los productos no pueden ser cero o negativas.
            foreach (DetalleCompra dc in DetallesCompra)
            {
                if (dc.cantidad <= 0)
                {
                    mensaje = "La cantidad de los productos no puede ser cero o negativa.";
                    return 0;
                }
            }

            // Si todas las validaciones de negocio pasan, se delega a la capa de datos.
            // La capa de datos se encargará de la transacción completa (registro y stock).
            objCompra.detalles = DetallesCompra;
            idCompraGenerada = objComprasDatos.Registrar(objCompra, out mensaje);

            return idCompraGenerada;
        }

        // Método para listar todas las compras, ahora con filtros opcionales.
        public List<Compra> ListarCompras(string fecha = null, int idProveedor = 0)
        {
            return objComprasDatos.Listar(fecha, idProveedor);
        }

        // Nuevo método para la búsqueda general de compras.
        public List<Compra> BuscarComprasGeneral(string filtro)
        {
            return objComprasDatos.BuscarComprasGeneral(filtro);
        }

        // Nuevo método para obtener los detalles de una compra específica.
        public Compra ObtenerDetalleCompra(int idCompra, out string mensaje)
        {
            mensaje = string.Empty;
            if (idCompra <= 0)
            {
                mensaje = "ID de compra no válido.";
                return null;
            }

            return objComprasDatos.ObtenerDetalleCompra(idCompra, out mensaje);
        }

        // Nuevo método para obtener los productos de una compra específica.
        public List<DetalleCompra> ObtenerProductosCompra(int idCompra)
        {
            if (idCompra <= 0)
            {
                return new List<DetalleCompra>();
            }

            return objComprasDatos.ObtenerProductosCompra(idCompra);
        }
    }
}