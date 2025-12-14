using CapaDatos;
using CapaEntidades;
using CapaEntidades.Utilidades;
using CapaNegocio;
using FontAwesome.Sharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using OcioStoreIngSoftII.Utilidades;
using System;
using System.Activities.Presentation.View;
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
    public partial class Informes : Form
    {
        private Informes_Negocio negocio = new Informes_Negocio();
        private DataTable datosVistaPrevia;
        private int? _idVendedorSeleccionado = null;
        private static Usuario usuarioActual;


        public Informes(Usuario objUser)
        {
            InitializeComponent();
            usuarioActual = objUser;
        }

        private void Informes_Load(object sender, EventArgs e)
        {
            // Llama al método para cargar los datos cuando se inicia el formulario.
            //CargarDatosInformes();

            CargarComboTipos(cbTipoReporte);
            dtpInicio.Content = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpFin.Content = DateTime.Now;

            // Tab Historial
            CargarComboTipos(cbFiltroTipo);
            cbFiltroTipo.Items.Insert(0, new { Valor = "Todos", Texto = "Todos los tipos" });
            cbFiltroTipo.SelectedIndex = 0;
            dtpHistorialInicio.Content = DateTime.Now.AddDays(-30);
            dtpHistorialFin.Content = DateTime.Now;
            dgvHistorial.AutoGenerateColumns = false;

            ConfigurarGridHistorial();
        }

        private void CargarComboTipos(ComboBox cb)
        {
            cb.Items.Clear();
            cb.Items.Add(new { Valor = "VendedoresDestacados", Texto = "Vendedores con más ventas" });
            cb.Items.Add(new { Valor = "ProductosTop", Texto = "Productos más vendidos" });
            cb.Items.Add(new { Valor = "FluctuacionVentas", Texto = "Historial de ventas" });
            cb.Items.Add(new { Valor = "CategoriasTop", Texto = "Categorías más vendidas" });
            cb.Items.Add(new { Valor = "StockBajo", Texto = "Productos con Stock Bajo" });
            cb.Items.Add(new { Valor = "DetalleVendedor", Texto = "Detalle de Ventas por Vendedor" });
            cb.DisplayMember = "Texto";
            cb.ValueMember = "Valor";
            cb.SelectedIndex = 0;
        }

        private void ConfigurarGridHistorial()
        {
            // Verifica si la columna ya existe para no duplicarla
            if (!dgvHistorial.Columns.Contains("btnVer"))
            {
                DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                btnCol.Name = "btnVer";
                btnCol.HeaderText = "Acción";
                btnCol.Text = "Regenerar";
                btnCol.UseColumnTextForButtonValue = true; // Hace que el texto del botón sea "Regenerar"
                dgvHistorial.Columns.Add(btnCol);
            }
        }


        private void btnBuscarVendedor_Click(object sender, EventArgs e)
        {
            // Abrimos el formulario de búsqueda como un diálogo
            using (BuscarVendedor popup = new BuscarVendedor())
            {
                var resultado = popup.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    // Si el usuario seleccionó un vendedor, lo guardamos
                    _idVendedorSeleccionado = popup.VendedorSeleccionado.id_user;

                    // Y mostramos su DNI en el TextBox
                    txtVendedorSeleccionado.Text = $"{popup.VendedorSeleccionado.nombre} {popup.VendedorSeleccionado.apellido} (DNI: {popup.VendedorSeleccionado.dni})";
                }
            }
        }

        // --- LÓGICA TAB 1 ---

        private void cbTipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            dynamic item = cbTipoReporte.SelectedItem;

            txtVendedorSeleccionado.Visible = false;
            btnBuscarVendedor.Visible = false;
            lblVendedor.Visible = false;
            dtpInicio.Enabled = true;
            dtpFin.Enabled = true;

            if (item.Valor == "StockBajo")
            {
                dtpInicio.Enabled = false;
                dtpFin.Enabled = false;
            }
            else if (item.Valor == "DetalleVendedor")
            {
                // Mostramos los controles del Popup
                txtVendedorSeleccionado.Visible = true;
                btnBuscarVendedor.Visible = true;
                lblVendedor.Visible = true;
            }
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            dynamic item = cbTipoReporte.SelectedItem;

            if (item.Valor == "StockBajo")
                datosVistaPrevia = negocio.GenerarInforme(item.Valor, DateTime.Now, DateTime.Now);
            else
                datosVistaPrevia = negocio.GenerarInforme(item.Valor, dtpInicio.Content, dtpFin.Content);

            if (item.Valor == "DetalleVendedor")
            {
                if (_idVendedorSeleccionado == null)
                {
                    MessageBox.Show("Debe seleccionar un vendedor utilizando el botón de búsqueda.", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Llamamos al negocio pasando el ID guardado
            datosVistaPrevia = negocio.GenerarInforme(
                item.Valor,
                dtpInicio.Content,
                dtpFin.Content,
                _idVendedorSeleccionado // Pasamos la variable privada
            );

            dgvVistaPrevia.DataSource = datosVistaPrevia;

            if (datosVistaPrevia.Rows.Count == 0)
                MessageBox.Show("No se encontraron resultados para los filtros seleccionados.");

            EmbellecerEncabezados(dgvVistaPrevia);
        }

        private void EmbellecerEncabezados(DataGridView dgv)
        {
            foreach (DataGridViewColumn columna in dgv.Columns)
            {
                // Reemplazar guiones bajos por espacios
                string texto = columna.HeaderText.Replace("_", " ");

                // Convertir a "Título" (Primera letra mayúscula de cada palabra)
                texto = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(texto.ToLower());

                // Asignar de nuevo
                columna.HeaderText = texto;
            }

            // Opcional: Ajustar ancho automáticamente
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            if (datosVistaPrevia == null || datosVistaPrevia.Rows.Count == 0) return;

            SaveFileDialog savefile = new SaveFileDialog();
            dynamic item = cbTipoReporte.SelectedItem;
            // ID Visual para el PDF
            string idVisual = $"INF-{DateTime.Now:yyyyMMdd-HHmmss}";
            savefile.FileName = $"Reporte_{item.Valor}_{DateTime.Now:ddMMyyyy}.pdf";
            savefile.Filter = "Pdf Files|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                string usuario = usuarioActual != null ? $"{usuarioActual.nombre} {usuarioActual.apellido}" : "Sistema";
                string rango = item.Valor == "StockBajo" ? "Al día de la fecha" : $"{dtpInicio.Content:dd/MM/yyyy} - {dtpFin.Content:dd/MM/yyyy}";
                string desc = $"Informe de {item.Texto}. Rango: {rango}";

                // Usamos ReportePDF
                ReportePDF.GenerarPdfInforme(datosVistaPrevia, item.Texto, idVisual, desc, savefile.FileName, usuario);

                // Guardamos en BD la auditoría
                negocio.RegistrarAuditoriaInforme(item.Texto, item.Valor, usuarioActual.id_user);

                MessageBox.Show("Informe generado.", "Éxito");
                System.Diagnostics.Process.Start(savefile.FileName);
            }
        }


        // --- LÓGICA TAB 2 ---

        private void btnBuscarHistorial_Click(object sender, EventArgs e)
        {
            string tipo = "Todos";
            if (cbFiltroTipo.SelectedIndex > 0)
            {
                dynamic item = cbFiltroTipo.SelectedItem;
                tipo = item.Valor;
            }

            // Llamamos al negocio (que usa el SP de Historial)
            DataTable dtHistorial = negocio.ObtenerHistorial(dtpHistorialInicio.Content, dtpHistorialFin.Content, tipo);

            dgvHistorial.DataSource = null;
            dgvHistorial.DataSource = dtHistorial;
        }


        private void dgvHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHistorial.Columns[e.ColumnIndex].Name == "btnVer" && e.RowIndex >= 0)
            {
                DataRowView fila = (DataRowView)dgvHistorial.Rows[e.RowIndex].DataBoundItem;

                string tipo = fila["tipo_informe"].ToString();
                string desc = fila["descripcion"].ToString(); // Para las fechas

                // Llamamos al método de limpieza y carga
                CargarDatosDesdeHistorial(tipo, desc);

                MessageBox.Show("Se han cargado los parámetros del historial.\n\n" +
                                "1. Verifique las fechas recuperadas.\n" +
                                "2. Haga clic en 'Ver Datos' para ver los datos actualizados.",
                                "Parámetros Cargados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cambiamos de pestaña
                tabControl1.SelectedIndex = 0;
            }
        }


        private void CargarDatosDesdeHistorial(string tipoInforme, string descripcion)
        {
            dgvVistaPrevia.DataSource = null;
            datosVistaPrevia = null;

            foreach (var item in cbTipoReporte.Items)
            {
                dynamic obj = item;
                if (obj.Valor == tipoInforme)
                {
                    cbTipoReporte.SelectedItem = item;
                    break;
                }
            }
            try
            {
                if (descripcion.Contains("Rango: "))
                {
                    // Cortamos el string para quedarnos con lo que está después de "Rango: "
                    string rangoFechas = descripcion.Split(new string[] { "Rango: " }, StringSplitOptions.None)[1];

                    // Separamos por el guion " - "
                    string[] fechas = rangoFechas.Split(new string[] { " - " }, StringSplitOptions.None);

                    if (fechas.Length == 2)
                    {
                        DateTime fInicio = DateTime.Parse(fechas[0].Trim());
                        DateTime fFin = DateTime.Parse(fechas[1].Trim());

                        // Asignamos a los controles (usando .Content o .Value según tu control)
                        dtpInicio.Content = fInicio;
                        dtpFin.Content = fFin;
                    }
                }
                else if (descripcion.Contains("Al día de la fecha")) // Para Stock Bajo
                {
                    dtpInicio.Content = DateTime.Now;
                    dtpFin.Content = DateTime.Now;
                }
            }
            catch
            {
                // Si falla el parseo (por formato distinto), no hacemos nada y dejamos las fechas que estaban.
                // No queremos que el programa explote por esto.
            }
        }
    }
}
