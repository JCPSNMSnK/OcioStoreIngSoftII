using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace OcioStoreIngSoftII
{
    public partial class BuscarVendedor : Form
    {
        public Usuario VendedorSeleccionado { get; private set; }
        private Usuario_negocio _usuarioNegocio = new Usuario_negocio();

        public BuscarVendedor()
        {
            InitializeComponent();
        }

        private void BuscarVendedor_Load(object sender, EventArgs e)
        {
            actualizarDatosTabla();
        }



        private void actualizarDatosTabla(string busqueda = null)
        {
            if (busqueda == null)
            {
                busqueda = "";
            }

            List<Usuario> listaTodos = _usuarioNegocio.BuscarUsuariosGeneral(busqueda);

            //Filtro solo vendedores
            List<Usuario> listaVendedores = listaTodos
                                .Where(u => u.objRoles.nombre_rol == "Vendedor" || u.objRoles.nombre_rol == "Admin")
                                .ToList();

            dgvVendedores.AutoGenerateColumns = false;
            dgvVendedores.DataSource = null;
            dgvVendedores.DataSource = listaVendedores;
        }


        //Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();
            actualizarDatosTabla(filtro);
        }



        //DGV - Texto para la columna estado
        private void dgvVendedores_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvVendedores.Rows)
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
            dgvVendedores.ClearSelection();
            dgvVendedores.CurrentCell = null;
        }

        //DGV - Dibujo del botón Seleccionar
        private void dgvVendedores_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        //DGV - Click en Seleccionar
        private void dgvVendedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVendedores.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    this.VendedorSeleccionado = (Usuario)dgvVendedores.Rows[indice].DataBoundItem;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void BuscarVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar_Click(BBuscar, EventArgs.Empty);

                // Evita el sonido "ding" de Windows al presionar Enter en algunos contextos
                e.SuppressKeyPress = true;
            }
        }
    }
}
