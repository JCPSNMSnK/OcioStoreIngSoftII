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

using OcioStoreIngSoftII.Utillidades;

namespace OcioStoreIngSoftII
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        private void Users_Load(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Users' Puede moverla o quitarla según sea necesario.
            //this.usersTableAdapter.Fill(this.dataSet1.Users);

            CBEstado.Items.Add(new OpcionSelect() { Valor = 1, Texto = "Alta" });
            CBEstado.Items.Add(new OpcionSelect() { Valor = 0, Texto = "Baja" });
            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "Valor";
            CBEstado.SelectedIndex = 0;

            CBModificarEstado.Items.Add(new OpcionSelect() { Valor = 1, Texto = "Alta" });
            CBModificarEstado.Items.Add(new OpcionSelect() { Valor = 0, Texto = "Baja" });
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
        
        private void actualizarDatosTabla()
        {
            this.pROC_BUSCAR_USUARIOTableAdapter.Fill(
                this.dataSet1.PROC_BUSCAR_USUARIO,
                null, null, null, null, null, null, null, null, null
            );

            foreach (DataGridViewRow row in usuariosDataGridView.Rows)
            {
                if (row.Cells["estadoValor"].Value is bool estado)
                {
                    row.Cells["estado"].Value = estado ? "Alta" : "Baja";
                }
            }
        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();

            // Si está vacío, muestra todos
            if (string.IsNullOrEmpty(filtro))
            {
                this.pROC_BUSCAR_USUARIOTableAdapter.Fill(
                    this.dataSet1.PROC_BUSCAR_USUARIO,
                    null, null, null, null, null, null, null, null, null
                );
                return;
            }

            // Intentar buscar por id_user si es numérico
            if (int.TryParse(filtro, out int idVal))
            {
                this.pROC_BUSCAR_USUARIOTableAdapter.Fill(
                    this.dataSet1.PROC_BUSCAR_USUARIO,
                    idVal, null, null, null, null, null, null, null, null
                );
                return;
            }

            // Si no es numérico, intenta por los campos de texto

            this.pROC_BUSCAR_USUARIOTableAdapter.Fill(
                this.dataSet1.PROC_BUSCAR_USUARIO,
                null, filtro, null, null, null, null, null, null, null // apellido
            );

            if (this.dataSet1.PROC_BUSCAR_USUARIO.Rows.Count == 0)
            {
                this.pROC_BUSCAR_USUARIOTableAdapter.Fill(this.dataSet1.PROC_BUSCAR_USUARIO, null, null, filtro, null, null, null, null, null, null); // nombre
            }
            if (this.dataSet1.PROC_BUSCAR_USUARIO.Rows.Count == 0)
            {
                this.pROC_BUSCAR_USUARIOTableAdapter.Fill(this.dataSet1.PROC_BUSCAR_USUARIO, null, null, null, filtro, null, null, null, null, null); // dni
            }
            if (this.dataSet1.PROC_BUSCAR_USUARIO.Rows.Count == 0)
            {
                this.pROC_BUSCAR_USUARIOTableAdapter.Fill(this.dataSet1.PROC_BUSCAR_USUARIO, null, null, null, null, filtro, null, null, null, null); // mail
            }
            if (this.dataSet1.PROC_BUSCAR_USUARIO.Rows.Count == 0)
            {
                this.pROC_BUSCAR_USUARIOTableAdapter.Fill(this.dataSet1.PROC_BUSCAR_USUARIO, null, null, null, null, null, filtro, null, null, null); // username
            }
            if (this.dataSet1.PROC_BUSCAR_USUARIO.Rows.Count == 0)
            {
                this.pROC_BUSCAR_USUARIOTableAdapter.Fill(this.dataSet1.PROC_BUSCAR_USUARIO, null, null, null, null, null, null, null, null, filtro); // username
            }

        }


        //private void CargarUsuariosEnDataGridView(List<Usuario> listaUsuario)
        //{
        //    // Limpia las filas del DataGridView antes de agregar datos nuevos
        //    usuariosDataGridView.Rows.Clear();

        //    foreach (Usuario item in listaUsuario)
        //    {
        //        usuariosDataGridView.Rows.Add(new object[] {
        //            "",
        //            item.id_usuario,
        //            item.nombre,
        //            item.apellido,
        //            item.objPerfil.id_perfil,
        //            item.objPerfil.descripcion,
        //            item.baja ? 1 : 0,
        //            item.baja ? "Dado de Baja" : "Dado de Alta",
        //            item.user,
        //            item.pass,
        //            item.email,
        //            item.domicilio,
        //            item.CP
        //        });
        //    }
        //}

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

        private void BRegisterUser_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(TNombre.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TApellido.Text))
            {
                MessageBox.Show("El campo Apellido es obligatorio.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TDni.Text))
            {
                MessageBox.Show("El campo Apellido es obligatorio.");
                return;
            }

            if (CBroles.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un perfil.");
                return;
            }

            if (CBEstado.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un estado.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TUser.Text))
            {
                MessageBox.Show("El campo Usuario es obligatorio.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TPass.Text) || TPass.Text.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TEmail.Text) || !TEmail.Text.Contains("@"))
            {
                MessageBox.Show("Debe ingresar un correo electrónico válido.");
                return;
            }

            Usuario objUser = new Usuario()
            {
                id_user = Convert.ToInt32(TID_user.Text),
                apellido = TApellido.Text,
                nombre = TNombre.Text,
                dni = Convert.ToInt32(TDni.Text),
                mail = TEmail.Text,
                username = TUser.Text,
                pass = TPass.Text,
                baja_user = Convert.ToInt32(((OpcionSelect)CBEstado.SelectedItem).Valor) == 1 ? true : false,
                objRoles = new Roles() { 
                                            id_rol = Convert.ToInt32(((OpcionSelect)CBroles.SelectedItem).Valor), 
                                            descripcion = ((OpcionSelect)CBroles.SelectedItem).Texto 
                                        },
            };

            if (objUser.id_user == 0)
            {
                int idusuarioregistrado = new Usuario_negocio().Registrar(objUser, out mensaje);

                if (idusuarioregistrado != 0)
                {
                    VaciarCampos();

                    actualizarDatosTabla();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new Usuario_negocio().Editar(objUser, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = usuariosDataGridView.Rows[Convert.ToInt32(TIndice.Text)];

                    row.Cells["id_user"].Value = TModificarID_user.Text;
                    row.Cells["apellido"].Value = TModificarAp.Text;
                    row.Cells["dni"].Value = TModificarDni.Text;
                    row.Cells["nombre"].Value = TModificarNombre.Text;
                    row.Cells["email"].Value = TModificarEmail.Text;
                    row.Cells["user"].Value = TModificarUser.Text;
                    row.Cells["id_rol"].Value = ((OpcionSelect)CBModificarRoles.SelectedItem).Valor.ToString();
                    row.Cells["rol"].Value = ((OpcionSelect)CBModificarRoles.SelectedItem).Texto.ToString();
                    row.Cells["estadoValor"].Value = ((OpcionSelect)CBModificarEstado.SelectedItem).Valor.ToString();
                    row.Cells["estado"].Value = ((OpcionSelect)CBModificarEstado.SelectedItem).Texto.ToString();

                    VaciarCampos();

                    actualizarDatosTabla();

                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }

        private void VaciarCampos()
        {
            TID_user.Text = "0";
            TApellido.Text = "";
            TNombre.Text = "";
            TDni.Text = "";
            TEmail.Text = "";
            TUser.Text = "";
            TPass.Text = "";
            TPassConf.Text = "";
            CBroles.SelectedIndex = 0;
            CBEstado.SelectedIndex = 0;

            TModificarID_user.Text = "0";
            TModificarAp.Text = "";
            TModificarNombre.Text = "";
            TModificarDni.Text = "";
            TModificarEmail.Text = "";
            TModificarUser.Text = "";
            CBModificarRoles.SelectedIndex = 0;
            CBModificarEstado.SelectedIndex = 0;
            //TModificarPass.Text = "";
            //TModificarConfirmPass.Text = "";
        }


        private void usuariosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (usuariosDataGridView.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    TCUsuarios.SelectedIndex = 1;

                    TBModificarIndice.Text = indice.ToString();

                    TModificarID_user.Text = usuariosDataGridView.Rows[indice].Cells["id_user"].Value.ToString();
                    TModificarAp.Text = usuariosDataGridView.Rows[indice].Cells["apellido"].Value.ToString();
                    TModificarNombre.Text = usuariosDataGridView.Rows[indice].Cells["nombre"].Value.ToString();
                    TModificarDni.Text = usuariosDataGridView.Rows[indice].Cells["dni"].Value.ToString();
                    TModificarEmail.Text = usuariosDataGridView.Rows[indice].Cells["email"].Value.ToString();
                    TModificarUser.Text = usuariosDataGridView.Rows[indice].Cells["user"].Value.ToString();

                    foreach (OpcionSelect opcionSelect in CBModificarRoles.Items)
                    {
                        if (Convert.ToInt32(opcionSelect.Valor) == Convert.ToInt32(usuariosDataGridView.Rows[indice].Cells["id_rol"].Value))
                        {
                            int indice_select = CBModificarRoles.Items.IndexOf(opcionSelect);
                            CBModificarRoles.SelectedIndex = indice_select;
                            break;
                        }
                    }

                    foreach (OpcionSelect opcionSelect in CBModificarEstado.Items)
                    {
                        if (Convert.ToInt32(opcionSelect.Valor) == Convert.ToInt32(usuariosDataGridView.Rows[indice].Cells["estadoValor"].Value))
                        {
                            int indice_select = CBModificarEstado.Items.IndexOf(opcionSelect);
                            CBModificarEstado.SelectedIndex = indice_select;
                            break;
                        }
                    }
                }
            }
        }



        private void BModificar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            // Validación para nombre
            if (string.IsNullOrEmpty(TModificarNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }

            // Validación para apellido
            if (string.IsNullOrEmpty(TModificarAp.Text))
            {
                MessageBox.Show("El apellido no puede estar vacío.");
                return;
            }

            // Validación para DNI
            if (string.IsNullOrEmpty(TModificarDni.Text) || !int.TryParse(TModificarDni.Text, out int dni))
            {
                MessageBox.Show("El DNI debe ser un número válido.");
                return;
            }

            // Validación para rol
            if (CBModificarRoles.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un rol.");
                return;
            }

            // Validación para estado
            if (CBModificarEstado.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar el estado.");
                return;
            }

            // Validación para usuario
            if (string.IsNullOrEmpty(TModificarUser.Text))
            {
                MessageBox.Show("El nombre de usuario no puede estar vacío.");
                return;
            }

            // Validación para email
            if (string.IsNullOrEmpty(TModificarEmail.Text) || !Regex.IsMatch(TModificarEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El email no tiene un formato válido.");
                return;
            }

            // Crear el objeto Usuario
            Usuario objUser = new Usuario()
            {
                id_user = Convert.ToInt32(TModificarID_user.Text),
                nombre = TModificarNombre.Text,
                apellido = TModificarAp.Text,
                dni = dni,
                mail = TModificarEmail.Text,
                username = TModificarUser.Text,
                baja_user = Convert.ToInt32(((OpcionSelect)CBModificarEstado.SelectedItem).Valor) == 1,
                objRoles = new Roles() { id_rol = Convert.ToInt32(((OpcionSelect)CBModificarRoles.SelectedItem).Valor) }
            };

            bool resultado = new Usuario_negocio().Editar(objUser, out mensaje);

            if (resultado)
            {
                DataGridViewRow row = usuariosDataGridView.Rows[Convert.ToInt32(TBModificarIndice.Text)];

                //row.Cells["id_user"].Value = TModificarID_user.Text;
                row.Cells["nombre"].Value = TModificarNombre.Text;
                row.Cells["apellido"].Value = TModificarAp.Text;
                row.Cells["dni"].Value = TModificarDni.Text;
                row.Cells["email"].Value = TModificarEmail.Text;
                row.Cells["user"].Value = TModificarUser.Text;
                row.Cells["id_rol"].Value = ((OpcionSelect)CBModificarRoles.SelectedItem).Valor.ToString();
                row.Cells["rol"].Value = ((OpcionSelect)CBModificarRoles.SelectedItem).Texto.ToString();
                row.Cells["estadoValor"].Value = Convert.ToInt32(((OpcionSelect)CBModificarEstado.SelectedItem).Valor) == 1;
                row.Cells["estado"].Value = ((OpcionSelect)CBModificarEstado.SelectedItem).Texto.ToString();

                VaciarCampos();
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }
        private void BEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TModificarID_user.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Usuario objusuario = new Usuario()
                    {
                        id_user = Convert.ToInt32(TModificarID_user.Text)
                    };

                    bool respuesta = new Usuario_negocio().Eliminar(objusuario, out mensaje);

                    if (respuesta)
                    {
                        usuariosDataGridView.Rows.RemoveAt(Convert.ToInt32(TBModificarIndice.Text));
                        VaciarCampos();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void PanelModificarUser_Resize(object sender, EventArgs e)
        {

        }
        private void panelInternoModif_Resize(object sender, EventArgs e)
        {

        }

        private void panelInterno_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelAltaUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelModificarUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TModificarConfirmPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelInternoModif_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TModificarEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void LModificarEmail_Click(object sender, EventArgs e)
        {

        }

        private void BRegisterUser_Click_1(object sender, EventArgs e)
        {

        }

    }
}
