using CapaEntidades;
using CapaNegocio;
using CapaNegocio.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace OcioStoreIngSoftII
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private Clientes_negocio objCNegocio = new Clientes_negocio();

        private void Clientes_Load(object sender, EventArgs e)
        {
            actualizarDatosTabla();
        }

        private void actualizarDatosTabla(string filtros = null)
        {
            if (filtros == null)
            {
                filtros = "";
            }

            List<Cliente> resultados = objCNegocio.BuscarClienteGeneral(filtros);
            ClientesDataGridView.AutoGenerateColumns = false;
            ClientesDataGridView.DataSource = null;
            ClientesDataGridView.DataSource = resultados;
        }

        private void VaciarCampos()
        {
            TApellido.Content = "";
            TNombre.Content = "";
            TDni.Content = "";
            TEmail.Content = "";
            TDireccion.Content = "";
            TLocalidad.Content = "";
            TProvincia.Content = "";
            TTelefono.Content = "";

            TModificarAp.Content = "";
            TModificarNombre.Content = "";
            TModificarDni.Content = "";
            TModificarEmail.Content = "";
            TModificarDireccion.Content = "";
            TModificarLocalidad.Content = "";
            TModificarProvincia.Content = "";
            TModificarTelefono.Content = "";

        }

        private void ClientesDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = OcioStoreIngSoftII.Properties.Resources.checkbox.Width;
                var h = OcioStoreIngSoftII.Properties.Resources.checkbox.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - w) / 2;

                e.Graphics.DrawImage(Properties.Resources.checkbox, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }


        //Evento Selección
        private void ClientesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (ClientesDataGridView.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                Cliente clienteSeleccionado = (Cliente)ClientesDataGridView.Rows[e.RowIndex].DataBoundItem;

                if (clienteSeleccionado != null)
                {
                    TCCliente.SelectedIndex = 1;
                    TModificarIndice.Content = e.RowIndex.ToString();
                    TModificarID_Client.Content = clienteSeleccionado.id_cliente.ToString();
                    TModificarAp.Content = clienteSeleccionado.apellido_cliente;
                    TModificarNombre.Content = clienteSeleccionado.nombre_cliente;
                    TModificarDni.Content = clienteSeleccionado.dni_cliente.ToString();
                    TModificarEmail.Content = clienteSeleccionado.email_cliente;
                    TModificarDireccion.Content = clienteSeleccionado.direccion_cliente;
                    TModificarLocalidad.Content = clienteSeleccionado.localidad_cliente;
                    TModificarProvincia.Content = clienteSeleccionado.provincia_cliente;
                    TModificarTelefono.Content = clienteSeleccionado.telefono_cliente;


                    LayoutClientes.ScrollControlIntoView(TCCliente);
                }
            }
        }

        private void BBuscarCliente_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();

            List<Cliente> resultados = objCNegocio.BuscarClienteGeneral(filtro);
            ClientesDataGridView.DataSource = null;
            ClientesDataGridView.DataSource = resultados;
        }


        //Modificar Cliente
        private void BModificarCliente_Click(object sender, EventArgs e)
        {
            // Validaciones

            if (ValidacionesCliente(TModificarNombre.Content, TModificarAp.Content, TModificarDni.Content, TModificarEmail.Content,
                Convert.ToInt32(TModificarID_Client.Content), TModificarTelefono.Content, TModificarDireccion.Content, TModificarLocalidad.Content, 
                TModificarProvincia.Content, out string mensajeError))
            {
                //Creación de un nuevo Usuario
                Cliente objCliente = new Cliente()
                {
                    id_cliente = Convert.ToInt32(TModificarID_Client.Content),
                    dni_cliente = Convert.ToInt32(TModificarDni.Content),
                    nombre_cliente = TModificarNombre.Content,
                    apellido_cliente = TModificarAp.Content,
                    telefono_cliente = TModificarTelefono.Content,
                    email_cliente = TModificarEmail.Content,
                    direccion_cliente = TModificarDireccion.Content,
                    localidad_cliente = TModificarLocalidad.Content,
                    provincia_cliente = TModificarProvincia.Content
                };

                bool resultado = new Clientes_negocio().ModificarCliente(objCliente, out string mensaje);

                if (resultado)
                {
                    VaciarCampos();
                    actualizarDatosTabla();
                    MessageBox.Show("Usuario modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    VaciarCampos();

                    actualizarDatosTabla();

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


        //Que el enter sirva para buscar
        private void Users_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BBuscarCliente_Click(BBuscarCliente, EventArgs.Empty);

                // Evita el sonido "ding" de Windows al presionar Enter en algunos contextos
                e.SuppressKeyPress = true;
            }
        }

    }
}
