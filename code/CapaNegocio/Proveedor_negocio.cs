using System;
using System.Collections.Generic;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class Proveedores_negocio
    {
        private readonly Proveedor_Datos objProveedorDatos;

        public Proveedores_negocio()
        {
            objProveedorDatos = new Proveedor_Datos();
        }

        public List<Proveedor> ListarProveedores()
        {
            // Este método asume que la capa de datos tiene un método para listar todos los proveedores.
            return objProveedorDatos.Listar();
        }

        public int RegistrarProveedor(Proveedor objProveedor, out string mensaje)
        {
            mensaje = string.Empty;

            // Validación de campos obligatorios
            if (string.IsNullOrWhiteSpace(objProveedor.nombre_proveedor))
            {
                mensaje += "El nombre del proveedor es obligatorio.\n";
            }
            if (string.IsNullOrWhiteSpace(objProveedor.telefono_proveedor))
            {
                mensaje += "El teléfono del proveedor es obligatorio.\n";
            }
            if (string.IsNullOrWhiteSpace(objProveedor.cuit_proveedor))
            {
                mensaje += "El CUIT del proveedor es obligatorio.\n";
            }

            if (!string.IsNullOrEmpty(mensaje))
            {
                return 0; // Retorna 0 si las validaciones iniciales fallan
            }

            // Validación de regla de negocio: el CUIT debe ser único
            if (VerificarExistencia(objProveedor.cuit_proveedor, 0))
            {
                mensaje = "Ya existe un proveedor registrado con el mismo CUIT.";
                return 0;
            }

            // Si todas las validaciones pasan, se delega a la capa de datos
            return objProveedorDatos.Registrar(objProveedor, out mensaje);
        }

        public bool ModificarProveedor(Proveedor objProveedor, out string mensaje)
        {
            mensaje = string.Empty;

            // Validación: El ID del proveedor es obligatorio para la modificación
            if (objProveedor.id_proveedor == 0)
            {
                mensaje = "El ID del proveedor es obligatorio para la modificación.";
                return false;
            }

            // Validación de campos obligatorios
            if (string.IsNullOrWhiteSpace(objProveedor.nombre_proveedor))
            {
                mensaje += "El nombre del proveedor es obligatorio.\n";
            }
            if (string.IsNullOrWhiteSpace(objProveedor.telefono_proveedor))
            {
                mensaje += "El teléfono del proveedor es obligatorio.\n";
            }
            if (string.IsNullOrWhiteSpace(objProveedor.cuit_proveedor))
            {
                mensaje += "El CUIT del proveedor es obligatorio.\n";
            }

            if (!string.IsNullOrEmpty(mensaje))
            {
                return false;
            }

            // Validación de regla de negocio: el CUIT modificado no puede pertenecer a otro proveedor
            if (VerificarExistencia(objProveedor.cuit_proveedor, objProveedor.id_proveedor))
            {
                mensaje = "Ya existe otro proveedor con el mismo CUIT.";
                return false;
            }

            // Si todas las validaciones pasan, se delega a la capa de datos
            return objProveedorDatos.Editar(objProveedor, out mensaje);
        }

        public bool VerificarExistencia(string cuit, int idProveedor = 0)
        {
            // Este método verifica si un CUIT ya existe en la base de datos,
            // excluyendo al proveedor con el ID especificado (útil para la modificación).
            // Se asume que la capa de datos tiene un método para esta validación.
            return objProveedorDatos.VerificarExistencia(cuit, idProveedor);
        }
    }
}