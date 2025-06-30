using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class MediosPago
    {
        public int id_medioPago { get; set; }
        public string nombre_medio { get; set; }
        public decimal comision { get; set; }

        public MediosPago(int idMedioPago, string nombreMedio, decimal comisionAplicable)
        {
            this.id_medioPago = idMedioPago;
            this.nombre_medio = nombreMedio;
            this.comision = comisionAplicable;
        }

        public MediosPago()
        {
        }

        public bool verificacionPago(MediosPago pagoVerificar, out string mensaje)
        {
            int medioSeleccionado = this.id_medioPago;

            try
            {
                // Simulación de una llamada a una API externa o POS
                // Generamos un número aleatorio entre 0 y 99.
                // Simulamos un 80% de éxito, 20% de fallo.
                Random _random = new Random();
                int resultadoSimulacion = _random.Next(100); // Genera un número entre 0 y 99

                if (resultadoSimulacion < 80) // 80% de probabilidad de éxito
                {
                    mensaje = "Pago exitoso! ";
                    return true;
                }
                else if (medioSeleccionado != 1)
                {
                    // Simular diferentes razones de fallo
                    if (resultadoSimulacion < 90 && medioSeleccionado == 2)
                    {
                        mensaje = "Pago denegado. Tarjeta inválida o expirada.";
                    }
                    else if (resultadoSimulacion < 95 && medioSeleccionado == 2)
                    {
                        mensaje = "Pago rechazado por la entidad bancaria. Fondos insuficientes.";
                    }
                    else
                    {
                        mensaje = "Pago rechazado por la entidad bancaria. Fondos insuficientes.";
                    }
                    return false;
                }
                else
                {
                    mensaje = "Error de conexión. Intente de nuevo.";
                    return false;
                }    
            }
            catch (Exception ex)
            {
                mensaje = "Ocurrió un error interno al intentar verificar el pago: " + ex.Message;
                return false;
            }
        }

    }
}
