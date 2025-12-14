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
    public partial class ConfiguracionNegocio : Form
    {
        public ConfiguracionNegocio()
        {
            InitializeComponent();
        }

        private void ConfiguracionNegocio_Load(object sender, EventArgs e)
        {
            txtNombreNegocio.Text = Properties.Settings.Default.NombreNegocio;
            txtCUIT.Text = Properties.Settings.Default.CUITNegocio;
            txtDireccion.Text = Properties.Settings.Default.DireccionNegocio;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.NombreNegocio = txtNombreNegocio.Text;
            Properties.Settings.Default.CUITNegocio = txtCUIT.Text;
            Properties.Settings.Default.DireccionNegocio = txtDireccion.Text;
            Properties.Settings.Default.Save();

            MessageBox.Show("Datos del negocio actualizados correctamente.", "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
