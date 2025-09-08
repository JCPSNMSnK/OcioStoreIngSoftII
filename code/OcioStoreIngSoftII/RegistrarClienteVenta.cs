using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OcioStoreIngSoftII
{
    public partial class RegistrarClienteVenta : Form
    {
        public Cliente ClienteRegistrado
        {
            get; private set;
        }

        private Clientes_negocio objCNegocio = new Clientes_negocio();

        public RegistrarClienteVenta()
        {
            InitializeComponent();
        }


        //Registrar Cliente
        private void BRegisterClient_Click(object sender, EventArgs e)
        {
            if (ValidacionesCliente(TNombre.Content, TApellido.Content, TDni.Content, TEmail.Content,
                0, TTelefono.Content, TDireccion.Content, TLocalidad.Content, TProvincia.Content, out string mensajeError))
            {
                //Ahora si, creación del user
                Cliente objCliente = new Cliente(
                    Convert.ToInt32(TDni.Content),
                    TNombre.Content,
                    TApellido.Content,
                    TTelefono.Content,
                    TEmail.Content,
                    TDireccion.Content,
                    TLocalidad.Content,
                    TProvincia.Content
                );

                int idclienteregistrado = objCNegocio.RegistrarCliente(objCliente, out string mensaje);

                if (idclienteregistrado != 0)
                {
                    MessageBox.Show("Cliente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }
            else
            {
                MessageBox.Show(mensajeError, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Giga validaciones
        private bool ValidacionesCliente(string nombre, string apellido, string dni, string email, int idUsuarioActual,
            string telefono, string direccion, string localidad, string provincia, out string mensajeError)
        {
            mensajeError = string.Empty;

            //ARRANCAN LAS GIGAVALIDACIONES
            //Nombre
            if (string.IsNullOrWhiteSpace(nombre))
            {
                mensajeError = "El campo Nombre es obligatorio.";
                return false;
            }
            if (nombre.Any(char.IsDigit))
            {
                mensajeError = "El campo Nombre no puede contener números.";
                return false;
            }
            if (nombre.Length > 30)
            {
                mensajeError = "El nombre no puede tener más de 30 caracteres.";
                return false;
            }

            //Apellido
            if (string.IsNullOrWhiteSpace(apellido))
            {
                mensajeError = "El campo Apellido es obligatorio.";
                return false;
            }
            if (apellido.Any(char.IsDigit))
            {
                mensajeError = "El campo Apellido no puede contener números.";
                return false;
            }
            if (apellido.Length > 30)
            {
                mensajeError = "El Apellido no puede tener más de 30 caracteres.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(dni))
            {
                mensajeError = "El campo DNI es obligatorio.";
                return false;
            }
            if (!dni.All(char.IsDigit))
            {
                mensajeError = "El campo DNI solo puede contener números, sin puntos.";
                return false;
            }

            //Email
            //Me tomé la molestia de buscar una expresión regular para que pegue el formato
            var emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,6})+)$");
            if (!emailRegex.IsMatch(email))
            {
                mensajeError = "El formato del correo electrónico no es válido.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                mensajeError = "El campo Email es obligatorio.";
                return false;
            }

            //Telefono
            if (telefono.Length < 7)
            {
                mensajeError = "El número de teléfono es demasiado corto.";
                return false;
            }
            if (!telefono.All(char.IsDigit))
            {
                mensajeError = "El campo telefono solo puede contener números, sin guiones o " + ".";
                return false;
            }

            //Direccion
            if (string.IsNullOrWhiteSpace(direccion))
            {
                mensajeError = "El campo Dirección es obligatorio.";
                return false;
            }

            //Localidad
            if (string.IsNullOrWhiteSpace(localidad))
            {
                mensajeError = "El campo Localidad es obligatorio.";
                return false;
            }

            //Provincia
            if (string.IsNullOrWhiteSpace(provincia))
            {
                mensajeError = "El campo Provincia es obligatorio.";
                return false;
            }
            return true;

        }

    }
}
