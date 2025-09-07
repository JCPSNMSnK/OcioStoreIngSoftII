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
    public partial class AvisoStockMinimo : Form
    {
        public AvisoStockMinimo(string mensaje)
        {
            InitializeComponent();
            lblMensaje.Content = mensaje;
        }

        private void AvisoStockMinimo_Load(object sender, EventArgs e)
        {
            Rectangle areaTrabajo = Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point(areaTrabajo.Right - this.Width, areaTrabajo.Bottom - this.Height);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
