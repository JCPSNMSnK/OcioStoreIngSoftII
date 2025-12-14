using CapaEntidades;
using CapaNegocio;
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
    public partial class Recibos : Form
    {
        private Ventas_negocio _ventaNegocio = new Ventas_negocio();
        private Factura_Negocio _facturaNegocio = new Factura_Negocio();
        private static Usuario usuarioActual;

        private int _idClienteFiltro = 0; //Para buscar por cliente
        private int _idVendedorFiltro = 0; //Para buscar por vendedor
        private int _idVentaSeleccionadaActual = -1;

        public Recibos(Usuario objUser)
        {
            InitializeComponent();
            usuarioActual = objUser;
        }

        private void Recibos_Load(object sender, EventArgs e)
        {
            //Por defecto que cargue las ventas del último mes
            DtpFechaInicio.Content = DateTime.Now.AddDays(-30);
            DtpFechaFin.Content = DateTime.Now;

            // Si se es un vendedor, solo se pueden ver las ventas propias:
            if (usuarioActual.objRoles.nombre_rol == "Vendedor")
            {
                
                _idVendedorFiltro = usuarioActual.id_user;
                txtVendedorSeleccionado.Text = $"{usuarioActual.nombre} {usuarioActual.apellido}";
                btnSeleccionarVendedor.Enabled = false;
                btnLimpiarVendedor.Enabled = false;
            }
            else if (usuarioActual.objRoles.nombre_rol == "Administrador" || usuarioActual.objRoles.nombre_rol == "Analista de Ventas")
            {
                btnSeleccionarVendedor.Enabled = true;
            }

            BuscarVentas();
        }

        // -----------------------------------------
        // BOTONES
        //------------------------------------------
        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            // Abrimos el formulario de búsqueda como un diálogo
            using (BuscarCliente popup = new BuscarCliente())
            {
                var resultado = popup.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    // Si el usuario seleccionó un cliente, lo guardamos
                    _idClienteFiltro = popup.ClienteSeleccionado.id_cliente;

                    // Y mostramos su DNI en el TextBox
                    txtClienteSeleccionado.Text = $"{popup.ClienteSeleccionado.nombre_cliente} {popup.ClienteSeleccionado.apellido_cliente} (DNI: {popup.ClienteSeleccionado.dni_cliente})";
                }
            }
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            _idClienteFiltro = 0;
            txtClienteSeleccionado.Text = "";
        }

        private void btnSeleccionarVendedor_Click(object sender, EventArgs e)
        {
            // Abrimos el formulario de búsqueda como un diálogo
            using (BuscarVendedor popup = new BuscarVendedor())
            {
                var resultado = popup.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    // Si el usuario seleccionó un vendedor, lo guardamos
                    _idVendedorFiltro = popup.VendedorSeleccionado.id_user;

                    // Y mostramos su DNI en el TextBox
                    txtVendedorSeleccionado.Text = $"{popup.VendedorSeleccionado.nombre} {popup.VendedorSeleccionado.apellido} (DNI: {popup.VendedorSeleccionado.dni})";
                }
            }
        }

        private void btnLimpiarVendedor_Click(object sender, EventArgs e)
        {
            _idVendedorFiltro = 0;
            txtVendedorSeleccionado.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarVentas();
        }


        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            if (usuarioActual.objRoles.nombre_rol != "Vendedor")
            {
                _idVendedorFiltro = 0;
                txtVendedorSeleccionado.Text = "";
            }
            _idClienteFiltro = 0;
            txtClienteSeleccionado.Text = "";
            txtNroFactura.Text = "";
            BuscarVentas();
        }


        private void BuscarVentas()
        {
            int idCliente = _idClienteFiltro;
            int nroFactura = 0;
            int idVendedorParaConsulta = _idVendedorFiltro;

            // REGLA DE SEGURIDAD:
            // Si es Vendedor, ignoramos cualquier variable y forzamos su ID
            if (usuarioActual.objRoles.nombre_rol == "Vendedor")
            {
                idVendedorParaConsulta = usuarioActual.id_user;
            }

            if (!string.IsNullOrWhiteSpace(txtNroFactura.Text))
            {
                if (!int.TryParse(txtNroFactura.Text, out nroFactura))
                {
                    MessageBox.Show("El número de factura debe ser un valor numérico.", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Detenemos la búsqueda si escribió letras
                }
            }

            List<Ventas> lista = _ventaNegocio.BuscarVentasConFiltros(DtpFechaInicio.Content, DtpFechaFin.Content, idVendedorParaConsulta, idCliente, nroFactura);

            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("La consulta devolvió 0 resultados."); 
            }

            //DGV
            var listaParaMostrar = lista.Select(v => new
            {
                IdVenta = v.id_venta,

                // Formato: Apellido y Nombre
                Vendedor = $"{v.objUsuario.apellido} {v.objUsuario.nombre}",
                Cliente = $"{v.objCliente.apellido_cliente} {v.objCliente.nombre_cliente}",
                Fecha = v.fecha_venta.ToString("dd/MM/yyyy HH:mm"),
                Total = v.total.ToString("C"),
                MedioPago = v.objMediosPago.nombre_medio,
                NroFactura = v.IdFacturaAsociada > 0 ? v.IdFacturaAsociada.ToString("00000") : "Sin Factura"
            }).ToList();

            dgvRecibos.DataSource = null;
            dgvRecibos.AutoGenerateColumns = false;
            dgvRecibos.DataSource = listaParaMostrar;


            if (dgvRecibos.Columns["btnVerFactura"] != null)
            {
                dgvRecibos.Columns["btnVerFactura"].DisplayIndex = dgvRecibos.Columns.Count - 1;
            }
        }





        // -----------------------------------------------------------------------
        // DGV RECIBOS
        //------------------------------------------------------------------------

        private void dgvRecibos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Solo pintamos la columna del botón "btnVerFactura"
            if (dgvRecibos.Columns[e.ColumnIndex].Name == "btnVerFactura")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                System.Drawing.Image icono = Properties.Resources.printer_icon;

                int iconSize = 20;
                // Calcular posición para centrar
                var x = e.CellBounds.Left + (e.CellBounds.Width - iconSize) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - iconSize) / 2;
                e.Graphics.DrawImage(icono, new System.Drawing.Rectangle(x, y, iconSize, iconSize));
                e.Handled = true;
            }
        }

        private void dgvRecibos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRecibos.Columns[e.ColumnIndex].Name == "btnVerFactura" && e.RowIndex >= 0)
            {
                int idVenta = Convert.ToInt32(dgvRecibos.Rows[e.RowIndex].Cells["IdVenta"].Value);

                // 1. Verificar si existe factura antes de intentar imprimir
                Factura factura = _facturaNegocio.ObtenerFacturaPorIdVenta(idVenta);

                if (factura == null || factura.id_factura == 0)
                {
                    MessageBox.Show("Esta venta no tiene una factura generada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 2. Si existe, imprimir
                ImprimirFactura(idVenta);
            }
        }

        // IMPRIMIR FACTURA
        private void ImprimirFactura(int idVenta)
        {
            try
            {

                Ventas ventaCompleta = _ventaNegocio.ObtenerVentaCompleta(idVenta);
                Factura factura = _facturaNegocio.ObtenerFacturaPorIdVenta(idVenta);

                if (ventaCompleta == null || factura == null)
                {
                   MessageBox.Show("No se pudieron recuperar los datos completos de la venta o la factura.");
                   return;
                }

                // 3. GENERAR PDF (Lógica reutilizada de Payment.cs)
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = $"Factura_{factura.id_factura}.pdf";
                savefile.Filter = "Pdf Files|*.pdf";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    string PaginaHTML_Texto = Properties.Resources.PlantillaVenta;

                    // REEMPLAZOS
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@nombrenegocio", Properties.Settings.Default.NombreNegocio);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@docnegocio", Properties.Settings.Default.CUITNegocio);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@direcnegocio", Properties.Settings.Default.DireccionNegocio);

                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@tipofactura", factura.objTipoFactura.nombre_tipo_factura.ToUpper());
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@numerofactura", factura.id_factura.ToString("00000"));
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@fecha_emision", DateTime.Now.ToString("dd/MM/yyyy"));

                    // C. Datos del Cliente y Venta
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@dni_cliente", ventaCompleta.objCliente.dni_cliente.ToString());
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@nombre_cliente", $"{ventaCompleta.objCliente.nombre_cliente} {ventaCompleta.objCliente.apellido_cliente}");
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@id_venta", ventaCompleta.id_venta.ToString());
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@nombre_usuario", $"{ventaCompleta.objUsuario.nombre} {ventaCompleta.objUsuario.apellido}");
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@mediopago", ventaCompleta.objMediosPago.nombre_medio);

                    string filas = string.Empty;
                    decimal subtotalNetoAcumulado = 0;

                    foreach (var item in ventaCompleta.detalles)
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

                    // Cálculos finales
                    decimal totalFinal = ventaCompleta.total;
                    decimal montoComision = totalFinal - subtotalNetoAcumulado;
                    decimal porcentajeComision = ventaCompleta.objMediosPago.comision;

                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@subtotal_neto", subtotalNetoAcumulado.ToString("C"));
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@porcentaje_comision", porcentajeComision.ToString("0.##"));
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@monto_comision", montoComision.ToString("C"));
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@total_venta", totalFinal.ToString("C"));

                    // Generar PDF
                    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        using (StringReader sr = new StringReader(PaginaHTML_Texto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }
                        pdfDoc.Close();
                        stream.Close();
                    }

                    DialogResult result = MessageBox.Show("Factura generada exitosamente.\n¿Desea abrir el archivo ahora?", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(savefile.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar PDF: " + ex.Message);
            }
        }


        //-------------------------------------------------
        // DGV DETALLES
        //-------------------------------------------------

        private void CargarDetallesVenta(int idVenta)
        {
            Ventas ventaCompleta = _ventaNegocio.ObtenerVentaCompleta(idVenta);

            if (ventaCompleta != null && ventaCompleta.detalles != null)
            {
                // Proyectamos los datos para que se vean bonitos en la grilla derecha
                var listaDetalles = ventaCompleta.detalles.Select(d => new
                {
                    Producto = d.objProducto.nombre_producto,
                    Precio = d.objProducto.precioVenta.ToString("C"), // Formato moneda
                    Cant = d.cantidad,
                    Subtotal = d.subtotal.ToString("C")
                }).ToList();

                dgvDetalles.DataSource = listaDetalles;

                lblDetalleTitulo.Text = $"Detalles Venta #{idVenta} - Total: {ventaCompleta.total:C}";
                lblDetallePie.Text = $"Medio de Pago: {ventaCompleta.objMediosPago.nombre_medio} - Comisión: {ventaCompleta.objMediosPago.comision}%";
            }
            else
            {
                dgvDetalles.DataSource = null;
            }
        }


        private void dgvRecibos_SelectionChanged(object sender, EventArgs e)
        {
            // Validar que haya filas seleccionadas
            if (dgvRecibos.SelectedRows.Count > 0)
            {

                int idVenta = Convert.ToInt32(dgvRecibos.SelectedRows[0].Cells["IdVenta"].Value);

                // Evitar recargar si ya estamos viendo esa venta
                if (idVenta != _idVentaSeleccionadaActual)
                {
                    _idVentaSeleccionadaActual = idVenta;
                    CargarDetallesVenta(idVenta);
                }
            }
        }

    }
}