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
    public partial class Payment : Form
    {
        private int pasoActual = 0;
        private CapaEntidades.Ventas _ventaActual;

        public Payment(CapaEntidades.Ventas objVenta)
        {
            _ventaActual = objVenta;
            InitializeComponent();
        }

        private void ActualizarBarraProgreso(int pasoActual)
        {
            if (pasoActual == 0)
            {
                VentaDataGridView.Visible = false;
                btnAnterior.Content = "Cancelar";
            }
            if (pasoActual == 1)
            {
                VentaDataGridView.Visible = true;
                btnAnterior.Content = "Anterior";
            }
            if (pasoActual == 2)
            {
                VentaDataGridView.Visible = false;
                btnSiguiente.Content = "Siguiente";
            }
            if (pasoActual == 3)
            {
                VentaDataGridView.Visible = false;
                btnSiguiente.Content = "Cerrar";
            }

            cuiSwitch1.Checked = pasoActual >= 1 ? true : false;
            cuiSwitch2.Checked = pasoActual >= 2 ? true : false;
            cuiSwitch3.Checked = pasoActual >= 3 ? true : false;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            MostrarDetallesVenta();

            VentaDataGridView.Visible = false;
            if (pasoActual == 0)
            {
                VentaDataGridView.Visible = false;
                btnAnterior.Text = "Cancelar";
            }
            ActualizarBarraProgreso(pasoActual);
        }

        private void MostrarDetallesVenta()
        {
            VentaDataGridView.Rows.Clear();

            foreach (var detalle in _ventaActual.detalles)
            {
                VentaDataGridView.Rows.Add(
                    detalle.objProducto.id_producto,
                    detalle.objProducto.nombre_producto,
                    detalle.cantidad,
                    detalle.objProducto.precioVenta,
                    detalle.subtotal
                );
            }
        }

        private void tabPage10_Click(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click_1(object sender, EventArgs e)
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

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            if (pasoActual <= 3)
            {
                pasoActual++;
                ActualizarBarraProgreso(pasoActual);
            }
            if ((pasoActual == 4))
            {
                this.Close();
            }
        }
    }
}
