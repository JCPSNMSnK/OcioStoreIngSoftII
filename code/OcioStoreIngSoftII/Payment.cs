using CapaEntidades;
using CapaNegocio;
using CuoreUI.Controls;
using CapaEntidades.Utilidades;
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
        private readonly Ventas_negocio _ventasNegocio = new Ventas_negocio();

        private readonly MediosPago_negocio _mediosNegocio;
        private List<MediosPago> _listaMedios;

        public Payment(CapaEntidades.Ventas objVenta)
        {
            _ventasNegocio = new Ventas_negocio();
            _mediosNegocio = new MediosPago_negocio();
            _ventaActual = objVenta;
            InitializeComponent();
        }

        private void ActualizarBarraProgreso(int pasoActual)
        {
            if (pasoActual == 0)
            {
                VentaDataGridView.Visible = true;
                panelPago.Visible = false;
                panelConfirmar.Visible = false;
                btnAnterior.Content = "Cancelar";
            }
            if (pasoActual == 1)
            {
                VentaDataGridView.Visible = false;
                panelPago.Visible = true;
                panelConfirmar.Visible = false;
                btnSiguiente.Content = "Confirmar";
                btnAnterior.Content = "Anterior";
            }
            if (pasoActual == 2)
            {
                VentaDataGridView.Visible = false;
                panelPago.Visible = false;
                panelConfirmar.Visible = true;
                btnSiguiente.Content = "Siguiente";
                btnAnterior.Visible = false;
            }
            if (pasoActual == 3)
            {
                VentaDataGridView.Visible = false;
                panelPago.Visible = false;
                panelConfirmar.Visible = true;
                btnSiguiente.Content = "Cerrar";
                btnAnterior.Visible = false;
            }

            cuiSwitch1.Checked = pasoActual >= 1 ? true : false;
            cuiSwitch2.Checked = pasoActual >= 2 ? true : false;
            cuiSwitch3.Checked = pasoActual >= 3 ? true : false;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            MostrarDetallesVenta();

            CargarComboBoxMedios(CBMediosPago);

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

        private void CargarComboBoxMedios(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            _listaMedios = _mediosNegocio.Listar(); // Asignación aquí también

            foreach (MediosPago item in _listaMedios)
            {
                comboBox.Items.Add(new OpcionSelect() { Valor = item.id_medioPago, Texto = item.nombre_medio });
            }

            comboBox.DisplayMember = "Texto";
            comboBox.ValueMember = "Valor";
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
            if (pasoActual == 1)
            {
                // Validar medio de pago seleccionado
                if (CBMediosPago.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un medio de pago.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string mensaje;
                bool exito = _ventasNegocio.verificacionPago(_ventaActual, out mensaje);

                if (exito)
                {
                    MessageBox.Show(mensaje, "Pago verificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pasoActual++;
                    pasoActual++;
                    ActualizarBarraProgreso(pasoActual);
                }
                else
                {
                    MessageBox.Show(mensaje, "Error en el pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (pasoActual < 3)
            {
                pasoActual++;
                ActualizarBarraProgreso(pasoActual);
            }
            else if (pasoActual == 3)
            {
                this.Close();
            }
        }



        private void CBMediosPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CBMediosPago.SelectedItem is OpcionSelect opcion)
                {
                    int idMedio = (int)opcion.Valor;
                    MediosPago medioSeleccionado = _listaMedios.FirstOrDefault(m => m.id_medioPago == idMedio);

                    if (medioSeleccionado != null)
                    {
                        string mensaje;
                        bool exito = _ventasNegocio.SeleccionarMedioPagoYCalcular(_ventaActual, medioSeleccionado, out mensaje);

                        if (exito)
                        {
                            // Asumiendo que _ventaActual tiene propiedad TotalConComision (o similar)
                            // Si no, deberías acceder al total recalculado después de AsignarMedioPago
                            LListo.Text = $"Gracias por su compra.\n" +
                                          $"Total abonado (incluye comisión): ${_ventaActual.total:F2}\n" +
                                          $"Medio de pago: {_ventaActual.objMediosPago.nombre_medio}";

                            LMedioPago.Text = $"{medioSeleccionado.nombre_medio} - Comisión: {medioSeleccionado.comision}%";
                        }
                        else
                        {
                            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en selección: " + ex.Message);
            }
        }
    }
}
