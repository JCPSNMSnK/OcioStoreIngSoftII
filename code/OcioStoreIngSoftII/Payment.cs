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
    public partial class Payment : Form
    {
        private int pasoActual = 0;

        public Payment()
        {
            InitializeComponent();
        }

        private void ActualizarBarraProgreso(int pasoActual)
        {
            if (pasoActual == 0)
            {
                TCPagos.Visible = false;
                btnAnterior.Text = "Cancelar";
            }
            if (pasoActual == 1)
            {
                TCPagos.Visible = true;
                btnAnterior.Text = "Anterior";
            }
            if (pasoActual == 2)
            {
                TCPagos.Visible = false;
                btnAnterior.Text = "Anterior";
            }
            
            cuiSwitch1.Checked = pasoActual >= 1 ? true : false;
            cuiSwitch2.Checked = pasoActual >= 2 ? true : false;
            cuiSwitch3.Checked = pasoActual >= 3 ? true : false;
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (pasoActual <= 2)
            {
                pasoActual++;
                ActualizarBarraProgreso(pasoActual);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (pasoActual == 0)
            {
                this.Close();
            }
            
            if (pasoActual >= 1)
            {
                pasoActual--;
                ActualizarBarraProgreso(pasoActual);
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            TCPagos.Visible = false;
            if (pasoActual == 0)
            {
                TCPagos.Visible = false;
                btnAnterior.Text = "Cancelar";
            }
        }
    }
}
