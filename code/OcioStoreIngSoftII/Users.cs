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

using CapaDatos;
using CapaEntidades;
using CapaNegocio;
using CapaNegocio.Seguridad;

using OcioStoreIngSoftII.Utillidades;

namespace OcioStoreIngSoftII
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private Usuario_negocio objUNegocio = new Usuario_negocio();

        //Carga Inicial de Datos
        private void Users_Load(object sender, EventArgs e)
        {

            CBestado.Items.Add(new OpcionSelect() { Valor = 1, Texto = "Baja" });
            CBestado.Items.Add(new OpcionSelect() { Valor = 0, Texto = "Alta" });
            CBestado.DisplayMember = "Texto";
            CBestado.ValueMember = "Valor";
            CBestado.SelectedIndex = 0;

            CBModificarEstado.Items.Add(new OpcionSelect() { Valor = 1, Texto = "Baja" });
            CBModificarEstado.Items.Add(new OpcionSelect() { Valor = 0, Texto = "Alta" });
            CBModificarEstado.DisplayMember = "Texto";
            CBModificarEstado.ValueMember = "Valor";

            List<Roles> listaRoles = new Roles_negocio().Listar();
            foreach (Roles item in listaRoles)
            {
                CBroles.Items.Add(new OpcionSelect() { Valor = item.id_rol, Texto = item.nombre_rol });
                CBModificarRoles.Items.Add(new OpcionSelect() { Valor = item.id_rol, Texto = item.nombre_rol });
            }
            CBroles.DisplayMember = "Texto";
            CBroles.ValueMember = "Valor";
            CBroles.SelectedIndex = 0;

            CBModificarRoles.DisplayMember = "Texto";
            CBModificarRoles.ValueMember = "Valor";
            CBModificarRoles.SelectedIndex = 0;

            actualizarDatosTabla();
        }

        private void actualizarDatosTabla(string filtros = null)
        {
            if (filtros == null)
            {
                filtros = "";
            }

            List<Usuario> resultados = objUNegocio.BuscarUsuariosGeneral(filtros);
            usuariosDataGridView.AutoGenerateColumns = false;
            usuariosDataGridView.DataSource = null;
            usuariosDataGridView.DataSource = resultados;
        }

        private void VaciarCampos()
        {
            TApellido.Content = "";
            TNombre.Content = "";
            TDni.Content = "";
            TEmail.Content = "";
            TUser.Content = "";
            TPass.Content = "";
            TPassConf.Content = "";
            CBroles.SelectedIndex = 0;
            CBestado.SelectedIndex = 0;
            TDireccion.Content = "";
            TLocalidad.Content = "";
            TProvincia.Content = "";
            TTelefono.Content = "";

            TModificarAp.Content = "";
            TModificarNombre.Content = "";
            TModificarDni.Content = "";
            TModificarEmail.Content = "";
            TModificarUser.Content = "";
            CBModificarRoles.SelectedIndex = 0;
            CBModificarEstado.SelectedIndex = 0;
            TModificarPass.Content = "";
            TModificarConfirmPass.Content = "";
            TModificarDireccion.Content = "";
            TModificarLocalidad.Content = "";
            TModificarProvincia.Content = "";
            TModificarTelefono.Content = "";

        }

        //DGV - Dibujo del botón Seleccionar
        private void usuariosDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        //DGV - Texto para la columna estado
        private void usuariosDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in usuariosDataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                var valor = row.Cells["estadoValor"].Value;
                if (valor != null && valor != DBNull.Value)
                {
                    bool estado = Convert.ToBoolean(valor);
                    row.Cells["estado"].Value = estado ? "Dado de Baja" : "Alta";
                }
                else
                {
                    row.Cells["estado"].Value = "Desconocido";
                }
            }
            usuariosDataGridView.ClearSelection();
            usuariosDataGridView.CurrentCell = null;
        }

        //Evento Selección
        private void usuariosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (usuariosDataGridView.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                Usuario usuarioSeleccionado = (Usuario)usuariosDataGridView.Rows[e.RowIndex].DataBoundItem;

                if (usuarioSeleccionado != null)
                {
                    TCUsuarios.SelectedIndex = 1;
                    TModificarIndice.Content = e.RowIndex.ToString();
                    TModificarID_user.Content = usuarioSeleccionado.id_user.ToString();
                    TModificarAp.Content = usuarioSeleccionado.apellido;
                    TModificarNombre.Content = usuarioSeleccionado.nombre;
                    TModificarDni.Content = usuarioSeleccionado.dni.ToString();
                    TModificarEmail.Content = usuarioSeleccionado.mail;
                    TModificarUser.Content = usuarioSeleccionado.username;
                    TModificarPass.Content = "";
                    TModificarConfirmPass.Content = "";
                    CBModificarRoles.SelectedValue = usuarioSeleccionado.objRoles.nombre_rol;
                    TModificarDireccion.Content = usuarioSeleccionado.direccion_user;
                    TModificarLocalidad.Content = usuarioSeleccionado.localidad_user;
                    TModificarProvincia.Content = usuarioSeleccionado.provincia_user;
                    TModificarTelefono.Content = usuarioSeleccionado.telefono_user;

                    string valorASeleccionar = usuarioSeleccionado.baja_user ? "1" : "0";
                    for (int i = 0; i < CBModificarEstado.Items.Count; i++)
                    {
                        OpcionSelect opcion = (OpcionSelect)CBModificarEstado.Items[i];
                        if (opcion.Valor.ToString() == valorASeleccionar)
                        {
                            CBModificarEstado.SelectedIndex = i;
                            break;
                        }
                    }

                    CBModificarEstado.SelectedValue = valorASeleccionar;


                    LayoutUsuarios.ScrollControlIntoView(TCUsuarios);
                }
            }
        }

        //Buscar
        private void BBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();

            List<Usuario> resultados = objUNegocio.BuscarUsuariosGeneral(filtro);
            usuariosDataGridView.DataSource = null;
            usuariosDataGridView.DataSource = resultados;
        }

        //Modificar Usuario
        private void BModificar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (ValidacionesUsuario(TModificarNombre.Content, TModificarAp.Content, TModificarDni.Content, TModificarEmail.Content, TModificarUser.Content,
                TModificarPass.Content, TModificarConfirmPass.Content, (OpcionSelect)CBModificarRoles.SelectedItem, (OpcionSelect)CBModificarEstado.SelectedItem,
                Convert.ToInt32(TModificarID_user.Content), TModificarTelefono.Content, TModificarDireccion.Content, TModificarLocalidad.Content, TModificarProvincia.Content,
                out string mensajeError))
            {
                string contraseña = TModificarPass.Content;
                string contraseñaHasheada = PasswordHasher.HashPassword(contraseña);

                //Creación de un nuevo Usuario
                Usuario objUser = new Usuario()
                {
                    id_user = Convert.ToInt32(TModificarID_user.Content),
                    apellido = TModificarAp.Content,
                    nombre = TModificarNombre.Content,
                    dni = Convert.ToInt32(TModificarDni.Content),
                    mail = TModificarEmail.Content,
                    username = TModificarUser.Content,
                    pass = contraseñaHasheada,
                    baja_user = Convert.ToInt32(((OpcionSelect)CBModificarEstado.SelectedItem).Valor) == 1,
                    objRoles = new Roles() { id_rol = Convert.ToInt32(((OpcionSelect)CBModificarRoles.SelectedItem).Valor) },
                    telefono_user = TModificarTelefono.Content,
                    direccion_user = TModificarDireccion.Content,
                    localidad_user = TModificarLocalidad.Content,
                    provincia_user = TModificarProvincia.Content
                };

                bool resultado = new Usuario_negocio().Editar(objUser, out string mensaje);

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

        //Registrar Usuario
        private void BRegisterUser_Click(object sender, EventArgs e)
        {
            if (ValidacionesUsuario(TNombre.Content, TApellido.Content, TDni.Content, TEmail.Content, TUser.Content,
                TPass.Content, TPassConf.Content, (OpcionSelect)CBroles.SelectedItem, (OpcionSelect)CBestado.SelectedItem,
                0, TTelefono.Content, TDireccion.Content, TLocalidad.Content, TProvincia.Content, out string mensajeError))
            {
                const int comparacion = 1;
                bool estadoSeleccionado = (Convert.ToInt32(((OpcionSelect)CBestado.SelectedItem).Valor) == comparacion);
                string contraseña = TPass.Content;
                string contraseñaHasheada = PasswordHasher.HashPassword(contraseña);

                //Ahora si, creación del user
                Usuario objUser = new Usuario(
                    TApellido.Content,
                    TNombre.Content,
                    Convert.ToInt32(TDni.Content),
                    TEmail.Content,
                    TUser.Content,
                    contraseñaHasheada,
                    estadoSeleccionado,
                   new Roles()
                   {
                       id_rol = Convert.ToInt32(((OpcionSelect)CBroles.SelectedItem).Valor),
                       descripcion = ((OpcionSelect)CBroles.SelectedItem).Texto
                   },
                    TDireccion.Content,
                    TLocalidad.Content,
                    TProvincia.Content,
                    TTelefono.Content
                );

                int idusuarioregistrado = objUNegocio.Registrar(objUser, out string mensaje);

                if (idusuarioregistrado != 0)
                {
                    VaciarCampos();

                    actualizarDatosTabla();

                    MessageBox.Show("Usuario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //Mega ultra requete hiper giga validaciones
        private bool ValidacionesUsuario(string nombre, string apellido, string dni, string email, string user,
            string pass, string passConf, OpcionSelect rol, OpcionSelect estado, int idUsuarioActual,
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


            //Roles
            if (rol == null)
            {
                mensajeError = "Debe seleccionar un perfil.";
                return false;
            }

            //Estado
            if (estado == null)
            {
                mensajeError = "Debe seleccionar un estado.";
                return false;
            }

            //Usuario
            if (string.IsNullOrWhiteSpace(user))
            {
                mensajeError = "El campo Usuario es obligatorio.";
                return false;
            }

            //Contraseña
            if (string.IsNullOrWhiteSpace(pass) || pass.Length < 6)
            {
                mensajeError = "La contraseña debe tener al menos 6 caracteres.";
                return false;
            }
            if (pass != passConf)
            {
                mensajeError = "Las contraseñas no coinciden. Por favor, verifíquelas.";
                TPass.Content = "";
                TPassConf.Content = "";
                TPass.Focus(); // Pone el cursor de vuelta en el primer campo de contraseña, epico
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
                BBuscar_Click(BBuscar, EventArgs.Empty);

                // Evita el sonido "ding" de Windows al presionar Enter en algunos contextos
                e.SuppressKeyPress = true;
            }
        }
    }
}
