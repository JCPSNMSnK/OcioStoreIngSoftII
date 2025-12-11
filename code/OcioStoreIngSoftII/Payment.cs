using CapaEntidades;
using CapaEntidades.Utilidades;
using CapaNegocio;
using CuoreUI.Controls;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private CapaEntidades.Factura _facturaActual;
        private readonly Ventas_negocio _ventasNegocio = new Ventas_negocio();

        private readonly MediosPago_negocio _mediosNegocio;
        private List<MediosPago> _listaMedios;


        public Payment(CapaEntidades.Ventas objVenta, CapaEntidades.Factura objFactura)
        {
            _ventasNegocio = new Ventas_negocio();
            _mediosNegocio = new MediosPago_negocio();
            _ventaActual = objVenta;
            _facturaActual = objFactura;
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
                btnImprimir.Visible = false;
            }
            if (pasoActual == 1)
            {
                VentaDataGridView.Visible = false;
                panelPago.Visible = true;
                panelConfirmar.Visible = false;
                btnSiguiente.Content = "Confirmar";
                btnAnterior.Content = "Anterior";
                btnImprimir.Visible = false;
            }
            if (pasoActual == 2)
            {
                VentaDataGridView.Visible = false;
                panelPago.Visible = false;
                panelConfirmar.Visible = true;
                btnSiguiente.Content = "Siguiente";
                btnAnterior.Visible = false;
                btnImprimir.Visible = false;
            }
            if (pasoActual == 3)
            {
                VentaDataGridView.Visible = false;
                panelPago.Visible = false;
                panelConfirmar.Visible = true;
                btnSiguiente.Content = "Cerrar";
                btnAnterior.Visible = false;
                btnImprimir.Visible = true;
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
                int idVentaGenerada;
                bool exito = _ventasNegocio.verificacionPago(_ventaActual, _facturaActual, out mensaje, out idVentaGenerada);

                if (exito)
                {
                    MessageBox.Show(mensaje, "Pago verificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pasoActual++;
                    pasoActual++;
                    ActualizarBarraProgreso(pasoActual);
                    _ventaActual.id_venta = idVentaGenerada;
                    _facturaActual.id_factura = idVentaGenerada;
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
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Validamos que tengamos datos para imprimir
            if (_ventaActual == null || _facturaActual == null) return;

            // Diálogo para guardar el PDF
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Factura_{0}.pdf", DateTime.Now.ToString("ddMMyyyy_HHmmss"));
            savefile.Filter = "Pdf Files|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string PaginaHTML_Texto = Properties.Resources.PlantillaVenta;

                    // DATOS DEL NEGOCIO
                    // El usuario deberá de cambiar esto según corresponda.
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@nombrenegocio", "OCIO STORE"); // Nombre del negocio
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@docnegocio", "20-12345678-9"); // CUIT del negocio
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@direcnegocio", "Av. Siempre Viva 123"); // Dirección del negocio

                    // DATOS FACTURA
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@tipofactura", _facturaActual.objTipoFactura.nombre_tipo_factura.ToUpper());
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@numerofactura", _facturaActual.id_factura.ToString("00000")); // O idVenta si idFactura es 0
                    //DATOS CLIENTE Y VENTA
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@dni_cliente", _ventaActual.objCliente.dni_cliente.ToString());
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@nombre_cliente", $"{_ventaActual.objCliente.nombre_cliente} {_ventaActual.objCliente.apellido_cliente}");
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@id_venta", _ventaActual.id_venta.ToString()); // Asegúrate de actualizar este ID tras el registro en la BD
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@fecha_emision", DateTime.Now.ToString("dd/MM/yyyy"));
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@nombre_usuario", $"{_ventaActual.objUsuario.nombre} {_ventaActual.objUsuario.apellido}");
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@mediopago", _ventaActual.objMediosPago.nombre_medio);

                    // DETALLE DE PRODUCTOS
                    string filas = string.Empty;
                    decimal subtotalNetoAcumulado = 0;
                    foreach (var item in _ventaActual.detalles)
                    {
                        filas += "<tr>";
                        filas += "<td>" + item.objProducto.nombre_producto + "</td>";
                        filas += "<td>$" + item.objProducto.precioVenta.ToString("0.00") + "</td>";
                        filas += "<td>" + item.cantidad.ToString() + "</td>";
                        filas += "<td>$" + item.subtotal.ToString("0.00") + "</td>";
                        filas += "</tr>";
                        subtotalNetoAcumulado += item.subtotal;
                    }
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@filas", filas);

                    // TOTALES
                    decimal totalFinal = _ventaActual.total;

                    // Comisión
                    decimal porcentajeComision = _ventaActual.objMediosPago.comision;
                    decimal montoComision = totalFinal - subtotalNetoAcumulado;

                    // Reemplazo en HTML
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@subtotal_neto", subtotalNetoAcumulado.ToString("C"));
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@porcentaje_comision", porcentajeComision.ToString("0.##"));
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@monto_comision", montoComision.ToString("C"));
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@total_venta", totalFinal.ToString("C"));

                    // GENERAR EL PDF CON ITEXTSHARP
                    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                    {
                        // Configuración del documento (Tamaño A4, márgenes)
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        // Convertir el string HTML a elementos PDF
                        using (StringReader sr = new StringReader(PaginaHTML_Texto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }

                        pdfDoc.Close();
                        stream.Close();
                    }

                    MessageBox.Show("Factura generada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Opcional: Abrir el PDF automáticamente
                    // System.Diagnostics.Process.Start(savefile.FileName); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
