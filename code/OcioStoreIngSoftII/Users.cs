using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

            CBEstado.Items.Add(new OpcionSelect() { Valor = 1, Texto = "Dado de Alta" });
            CBEstado.Items.Add(new OpcionSelect() { Valor = 0, Texto = "Dado de Baja" });
            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "Valor";
            CBEstado.SelectedIndex = 0;

            CBModificarEstado.Items.Add(new OpcionSelect() { Valor = 1, Texto = "Dado de Alta" });
            CBModificarEstado.Items.Add(new OpcionSelect() { Valor = 0, Texto = "Dado de Baja" });
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

            CentrarTodosLosPaneles();

            this.pROC_BUSCAR_USUARIOTableAdapter.Fill(
                this.dataSet1.PROC_BUSCAR_USUARIO,
                null, null, null, null, null, null, null, null, null
            );
        }
        private void usuariosDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //cambia el valor booleano a texto, esto es solo estetico
            //if (usuariosDataGridView.Columns[e.ColumnIndex].Name == "estado")
            //{
            //    if (e.Value is bool valor)
            //    {
            //        e.Value = valor ? "Alta" : "Baja";
            //        e.FormattingApplied = true;
            //    }
            //}
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


        private void PanelAltaUser_Resize(object sender, EventArgs e)
        {
            CentrarTodosLosPaneles();
        }
        

        private void CentrarPanel(Panel panel)
        {
            panel.Left = (PanelAltaUser.Width - panel.Width) / 2;
            panel.Top = (PanelAltaUser.Height - panel.Height) / 2;
        }

        private void CentrarTodosLosPaneles()
        {
            CentrarPanel(panelInternoAlta);
            CentrarPanel(panelInternoModif);
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

        

        private void pROC_BUSCAR_USUARIODataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void pROC_BUSCAR_USUARIODataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (usuariosDataGridView.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    TCUsuarios.SelectedIndex = 1;

                    TBModificarIndice.Text = indice.ToString();

                    TModificarID_user.Text = usuariosDataGridView.Rows[indice].Cells["id_user"].Value.ToString();
                    TModificarNombre.Text = usuariosDataGridView.Rows[indice].Cells["nombre"].Value.ToString();
                    TModificarAp.Text = usuariosDataGridView.Rows[indice].Cells["apellido"].Value.ToString();
                    TModificarEmail.Text = usuariosDataGridView.Rows[indice].Cells["email"].Value.ToString();
                    TModificarUser.Text = usuariosDataGridView.Rows[indice].Cells["user"].Value.ToString();
                    //TModificarPass.Text = usuariosDataGridView.Rows[indice].Cells["pass"].Value.ToString();
                    //TModificarConfirmPass.Text = usuariosDataGridView.Rows[indice].Cells["pass"].Value.ToString();

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
                        if (Convert.ToInt32(opcionSelect.Valor) == Convert.ToInt32(usuariosDataGridView.Rows[indice].Cells["estado"].Value))
                        {
                            int indice_select = CBModificarEstado.Items.IndexOf(opcionSelect);
                            CBModificarEstado.SelectedIndex = indice_select;
                            break;
                        }
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
    }
}
