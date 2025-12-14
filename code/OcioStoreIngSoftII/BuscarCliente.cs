using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OcioStoreIngSoftII
{
    public partial class BuscarCliente : Form
    {
        public Cliente ClienteSeleccionado { get; private set; }

        private Clientes_negocio objNegocio = new Clientes_negocio();
        public BuscarCliente()
        {
            InitializeComponent();
            actualizarDatosTabla();
        }

        private void actualizarDatosTabla(string filtros = null)
        {
            if (filtros == null)
            {
                filtros = "";
            }

            List<Cliente> resultados = objNegocio.BuscarClienteGeneral(filtros);
            ClientesDataGridView.AutoGenerateColumns = false;
            ClientesDataGridView.DataSource = null;
            ClientesDataGridView.DataSource = resultados;
        }

        private void BBuscarCliente_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();

            List<Cliente> resultados = objNegocio.BuscarClienteGeneral(filtro);
            ClientesDataGridView.DataSource = null;
            ClientesDataGridView.DataSource = resultados;
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


        private void ClientesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ClientesDataGridView.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    // Guarda el objeto Cliente completo de la fila seleccionada
                    this.ClienteSeleccionado = (Cliente)ClientesDataGridView.Rows[indice].DataBoundItem;

                    // Cierra el formulario indicando que la operación fue exitosa
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void BuscarCliente_KeyDown(object sender, KeyEventArgs e)
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
