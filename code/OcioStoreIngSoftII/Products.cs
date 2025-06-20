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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }



        private void PanelModificarUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {
            CentrarTodosLosPaneles();
        }

        private void PanelAltaProducts_Resize(object sender, EventArgs e)
        {
            CentrarTodosLosPaneles();
        }

        private void TCProductos_Resize(object sender, EventArgs e)
        {
            CentrarTodosLosPaneles();
        }

        private void CentrarTodosLosPaneles()
        {
            CentrarPanel(panelInternoAlta);
            CentrarPanel(panelInternoModif);
        }

        private void CentrarPanel(Panel panel)
        {
            panel.Left = (PanelAltaProducts.Width - panel.Width) / 2;
            panel.Top = (PanelAltaProducts.Height - panel.Height) / 2;
        }

        private void CBEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LEstado_Click(object sender, EventArgs e)
        {

        }

        private void TDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void LDescripcion_Click(object sender, EventArgs e)
        {

        }
    }
}
