using System;
using System.Collections.Generic;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class Clientes_negocio
    {
        private readonly Cliente_Datos objClienteDatos;

        public Clientes_negocio()
        {
            objClienteDatos = new Cliente_Datos();
        }

        // Método para listar todos los clientes
        public List<Cliente> ListarClientes()
        {
            return objClienteDatos.Buscar(); // El método Buscar sin parámetros trae todos los clientes
        }

        public int RegistrarCliente(Cliente objCliente, out string mensaje)
        {
            mensaje = string.Empty;

            // Validación de campos obligatorios
            if (objCliente.dni_cliente == 0)
            {
                mensaje += "El DNI del cliente es obligatorio.\n";
            }
            if (string.IsNullOrWhiteSpace(objCliente.nombre_cliente))
            {
                mensaje += "El nombre del cliente es obligatorio.\n";
            }
            if (string.IsNullOrWhiteSpace(objCliente.apellido_cliente))
            {
                mensaje += "El apellido del cliente es obligatorio.\n";
            }
            if (string.IsNullOrWhiteSpace(objCliente.nombre_cliente))
            {
                mensaje += "El EMAIL del cliente es obligatorio.\n";
            }
            if (string.IsNullOrWhiteSpace(objCliente.telefono_cliente))
            {
                mensaje += "El TELEFONO del cliente es obligatorio.\n";
            }
            if (string.IsNullOrWhiteSpace(objCliente.direccion_cliente))
            {
                mensaje += "La DIRECCIÓN del cliente es obligatorio.\n";
            }
            if (string.IsNullOrWhiteSpace(objCliente.localidad_cliente))
            {
                mensaje += "La LOCALIDAD del cliente es obligatorio.\n";
            }
            if (string.IsNullOrWhiteSpace(objCliente.provincia_cliente))
            {
                mensaje += "La PROVINCIA del cliente es obligatorio.\n";
            }

            // Si hay errores de validación, se detiene y se devuelve 0.
            if (!string.IsNullOrEmpty(mensaje))
            {
                return 0;
            }

            // Validación de regla de negocio: verificar si el DNI ya existe
            if (verificarExistencia(objCliente.dni_cliente))
            {
                mensaje = "Ya existe un cliente registrado con el mismo DNI.";
                return 0;
            }

            // Si todas las validaciones pasan, se delega a la capa de datos.
            return objClienteDatos.Registrar(objCliente, out mensaje);
        }

        public bool ModificarCliente(Cliente objCliente, out string mensaje)
        {
            mensaje = string.Empty;

            // Validación de ID (necesario para la modificación)
            if (objCliente.id_cliente == 0)
            {
                mensaje = "El ID del cliente es obligatorio para la modificación.";
                return false;
            }

            // Validación de campos obligatorios
            if (string.IsNullOrWhiteSpace(objCliente.nombre_cliente))
            {
                mensaje += "El nombre del cliente es obligatorio.\n";
            }
            if (string.IsNullOrWhiteSpace(objCliente.apellido_cliente))
            {
                mensaje += "El apellido del cliente es obligatorio.\n";
            }
            if (string.IsNullOrWhiteSpace(objCliente.nombre_cliente))
            {
                mensaje += "El EMAIL del cliente es obligatorio.\n";
            }
            if (string.IsNullOrWhiteSpace(objCliente.telefono_cliente))
            {
                mensaje += "El TELEFONO del cliente es obligatorio.\n";
            }
            if (string.IsNullOrWhiteSpace(objCliente.direccion_cliente))
            {
                mensaje += "La DIRECCIÓN del cliente es obligatorio.\n";
            }
            if (string.IsNullOrWhiteSpace(objCliente.localidad_cliente))
            {
                mensaje += "La LOCALIDAD del cliente es obligatorio.\n";
            }
            if (string.IsNullOrWhiteSpace(objCliente.provincia_cliente))
            {
                mensaje += "La PROVINCIA del cliente es obligatorio.\n";
            }
            
            if (!string.IsNullOrEmpty(mensaje))
            {
                return false;
            }

            // Validación de regla de negocio: El DNI no puede pertenecer a otro cliente
            // La capa de datos debe manejar este caso
            // Se asume que el método de editar en la capa de datos ya maneja la validación de unicidad
            // para evitar duplicados de DNI de otros clientes.

            // Si las validaciones pasan, se delega a la capa de datos.
            return objClienteDatos.Editar(objCliente, out mensaje);
        }

        public bool verificarExistencia(int dni)
        {
            List<Cliente> clientesEncontrados = objClienteDatos.Buscar(dni: dni);
            return clientesEncontrados.Count > 0; //retorna TRUE si hay DNI ya registrado en DB
        }
    }
}