using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Proveedor
    {
        public int id_proveedor { get; set; }
        public string nombre_proveedor { get; set; }
        public string telefono_proveedor { get; set; }
        public string cuit_proveedor { get; set; }
        
        // AÑADIDO: Propiedad para manejar la baja lógica (BIT en SQL -> bool en C#)
        public bool baja_proveedor { get; set; }

        public Proveedor()
        {
            // Aseguramos que el estado de baja por defecto sea false (Activo)
            this.baja_proveedor = false; 
        }

        // Constructor para registrar (sin ID ni estado de baja, se asume activo)
        public Proveedor(string nombre, string telefono, string cuit)
        {
            this.id_proveedor = 0; // Se autogenerará en la base de datos
            this.nombre_proveedor = nombre;
            this.telefono_proveedor = telefono;
            this.cuit_proveedor = cuit;
            this.baja_proveedor = false; // Nuevo proveedor siempre inicia activo
        }

        // Constructor para traer desde la DB (recibe todos los campos, incluyendo la baja)
        public Proveedor(int id, string nombre, string telefono, string cuit, bool baja)
        {
            this.id_proveedor = id;
            this.nombre_proveedor = nombre;
            this.telefono_proveedor = telefono;
            this.cuit_proveedor = cuit;
            this.baja_proveedor = baja; // Asigna el estado de baja recuperado de la DB
        }
    }
}