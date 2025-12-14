using CapaEntidades;
using CapaNegocio;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.VisualElements;
using OcioStoreIngSoftII.Utilidades;
using SkiaSharp;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace OcioStoreIngSoftII
{
    public partial class Stats : Form
    {
        private Informes_Negocio objNegocio = new Informes_Negocio();

        // Variables para control de permisos
        private bool esAdmin = false;
        private int? _idVendedorFiltro = null;
        private static Usuario usuarioActual;

        public Stats(Usuario objUser)
        {
            InitializeComponent();
            usuarioActual = objUser;
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            // Fechas por defecto
            DtpFechaFin.Content = DateTime.Now;
            DtpFechaInicio.Content = DateTime.Now.AddMonths(-1);

            ConfigurarPermisos();
            CargarDashboard();
        }

        private void ConfigurarPermisos()
        {
            if (usuarioActual != null)
            {
                if (usuarioActual.NombreRol == "Administrador" || usuarioActual.NombreRol == "Analista de Ventas")
                {
                    esAdmin = true;

                    // Admin: Puede buscar y limpiar
                    btnBuscarVendedor.Visible = true;
                    btnLimpiarVendedor.Visible = true;
                    txtVendedorSeleccionado.Text = "Todos (Global)";
                    _idVendedorFiltro = null;
                }
                else
                {
                    esAdmin = false;

                    // Vendedor: Filtro fijo, botones ocultos
                    btnBuscarVendedor.Visible = false;
                    btnLimpiarVendedor.Visible = false;

                    // Fijamos el ID y el Texto
                    _idVendedorFiltro = usuarioActual.id_user;
                    txtVendedorSeleccionado.Text = $"{usuarioActual.nombre} {usuarioActual.apellido} (DNI: {usuarioActual.dni})";
                }
            }
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
                    CargarDashboard();
                }
            }
        }

        private void btnLimpiarVendedor_Click(object sender, EventArgs e)
        {
            _idVendedorFiltro = null;
            txtVendedorSeleccionado.Text = "Todos (Global)";
            CargarDashboard();
        }


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime inicio = Convert.ToDateTime(DtpFechaInicio.Content);
            DateTime fin = Convert.ToDateTime(DtpFechaFin.Content);
            if (inicio > fin)
            {
                MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CargarDashboard();
        }

        private void CargarDashboard()
        {
            DateTime inicio = DtpFechaInicio.Content;
            DateTime fin = DtpFechaFin.Content;

            try
            {
                CargarKPI(inicio, fin, _idVendedorFiltro);
                CargarGraficoFluctuacion(inicio, fin, _idVendedorFiltro);
                CargarGraficoProductos(inicio, fin, _idVendedorFiltro);
                CargarGraficoCategorias(inicio, fin, _idVendedorFiltro);
                CargarGraficoVendedores(inicio, fin);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estadísticas: " + ex.Message);
            }
        }

        // ----------------------------------------------------------------------
        // LÓGICA DE CARGA DE DATOS
        // ----------------------------------------------------------------------

        private void CargarKPI(DateTime inicio, DateTime fin, int? idVendedor)
        {
            DataTable dt;
            if (idVendedor.HasValue)
            {
                dt = objNegocio.GenerarInforme("DetalleVendedor", inicio, fin, idVendedor);
                // El SP devuelve: Nro Venta, Fecha, Vendedor, Cliente, Medio Pago, Total

                if (dt.Rows.Count == 0)
                {
                    PonerKPIsEnCero();
                    return;
                }

                decimal totalIngresos = dt.AsEnumerable().Sum(row => Convert.ToDecimal(row["Total"]));
                int cantVentas = dt.Rows.Count;
                decimal promedio = cantVentas > 0 ? totalIngresos / cantVentas : 0;

                KPI_CantVentas.Content = cantVentas.ToString();
                KPI_Ingresos.Content = totalIngresos.ToString("C");
                KPI_PromedioVentas.Content = promedio.ToString("C");
            }
            else
            {
                dt = objNegocio.GenerarInforme("FluctuacionVentas", inicio, fin);
                decimal totalIngresos = 0;

                if (dt.Rows.Count > 0)
                    totalIngresos = dt.AsEnumerable().Sum(row => Convert.ToDecimal(row["total_ventas"]));

                int cantVentas = objNegocio.ObtenerCantidadVentasGlobal(inicio, fin);
                decimal promedio = cantVentas > 0 ? totalIngresos / cantVentas : 0;

                KPI_CantVentas.Content = cantVentas.ToString();
                KPI_Ingresos.Content = totalIngresos.ToString("C");
                KPI_PromedioVentas.Content = promedio.ToString("C");
            }
        }

        private void PonerKPIsEnCero()
        {
            KPI_CantVentas.Content = "0";
            KPI_Ingresos.Content = "$0.00";
            KPI_PromedioVentas.Content = "$0.00";
        }

        private void CargarGraficoFluctuacion(DateTime inicio, DateTime fin, int? idVendedor)
        {
            var chart = GraphFluctuacionVentas;
            DataTable dt;

            if (idVendedor.HasValue) // CASO VENDEDOR ESPECÍFICO
            {
                dt = objNegocio.GenerarInforme("DetalleVendedor", inicio, fin, idVendedor);

                if (dt.Rows.Count == 0) { LimpiarGrafico(chart); return; }

                // Usamos LINQ para agrupar por Día y sumar los totales.
                var agrupado = dt.AsEnumerable()
                    .GroupBy(row => Convert.ToDateTime(row["Fecha"]).Date) // Agrupamos por fecha
                    .Select(g => new
                    {
                        Fecha = g.Key,
                        SumaTotal = g.Sum(r => Convert.ToDecimal(r["Total"]))
                    })
                    .OrderBy(x => x.Fecha) // Ordenamos cronológicamente
                    .ToList();

                if (!agrupado.Any()) { LimpiarGrafico(chart); return; }

                var valores = agrupado.Select(x => x.SumaTotal).ToArray();
                var etiquetas = agrupado.Select(x => x.Fecha.ToString("dd/MM")).ToArray();

                ConfigurarLineaChart(chart, "Ventas Vendedor", valores, etiquetas);
            }
            else // CASO GLOBAL
            {
                dt = objNegocio.GenerarInforme("FluctuacionVentas", inicio, fin);

                if (dt.Rows.Count == 0) { LimpiarGrafico(chart); return; }
                var valores = dt.AsEnumerable().Select(r => Convert.ToDecimal(r["total_ventas"])).ToArray();
                var etiquetas = dt.AsEnumerable().Select(r => Convert.ToDateTime(r["fecha_periodo"]).ToString("dd/MM")).ToArray();

                ConfigurarLineaChart(chart, "Ventas Globales", valores, etiquetas);
            }
        }

        private void ConfigurarLineaChart(LiveChartsCore.SkiaSharpView.WinForms.CartesianChart chart, string nombreSerie, decimal[] valores, string[] etiquetas)
        {
            chart.Series = new ISeries[]
            {
                new LineSeries<decimal>
                {
                    Name = nombreSerie,
                    Values = valores,
                    Fill = null,
                    GeometrySize = 5,
                    Stroke = new SolidColorPaint(SKColors.BlueViolet) { StrokeThickness = 3 }
                }
            };
            chart.XAxes = new[] { new Axis { Labels = etiquetas } };
            chart.Title = new LabelVisual { Text = "Fluctuación Temporal" };
        }

        private void CargarGraficoProductos(DateTime inicio, DateTime fin, int? idVendedor)
        {
            var chart = GraphProductosMasVendidos;

            DataTable dt = objNegocio.GenerarInforme("ProductosTop", inicio, fin);

            if (dt.Rows.Count == 0) { LimpiarGrafico(chart); return; }

            // Tomamos solo el Top 10 para que no explote el gráfico
            var top10 = dt.AsEnumerable().Take(10);

            var valores = top10.Select(r => Convert.ToDouble(r["cantidad_vendida"])).ToArray();
            var etiquetas = top10.Select(r => r["nombre_producto"].ToString()).ToArray();

            chart.Series = new ISeries[]
            {
                new ColumnSeries<double>
                {
                    Name = "Unidades",
                    Values = valores,
                    Fill = new SolidColorPaint(SKColors.CornflowerBlue)
                }
            };
            chart.XAxes = new[] { new Axis { Labels = etiquetas, LabelsRotation = 45 } };
            chart.Title = new LabelVisual { Text = "Top Productos (Tienda)" };
        }

        private void CargarGraficoCategorias(DateTime inicio, DateTime fin, int? idVendedor)
        {
            // Usamos el global por ahora
            var chart = GraphCategoriasMasVendidas;
            DataTable dt = objNegocio.GenerarInforme("CategoriasTop", inicio, fin);

            if (dt.Rows.Count == 0) { LimpiarGrafico(chart); return; }

            var series = dt.AsEnumerable().Select(row => new PieSeries<double>
            {
                Values = new double[] { Convert.ToDouble(row["cantidad_vendida"]) },
                Name = row["nombre_categoria"].ToString()
            }).ToArray();

            chart.Series = series;
            chart.Title = new LabelVisual { Text = "Categorías (Tienda)" };
        }

        private void CargarGraficoVendedores(DateTime inicio, DateTime fin)
        {
            var chart = GraphVendedoresConMasVentas;

            if (!esAdmin)
            {
                chart.Visible = false;
                return;
            }
            chart.Visible = true;

            DataTable dt = objNegocio.GenerarInforme("VendedoresDestacados", inicio, fin);

            if (dt.Rows.Count == 0) { LimpiarGrafico(chart); return; }

            var series = dt.AsEnumerable().Select(row => new PieSeries<decimal>
            {
                Values = new decimal[] { Convert.ToDecimal(row["total_ventas"]) },
                Name = row["nombre_vendedor"].ToString()
            }).ToArray();

            chart.Series = series;
            chart.Title = new LabelVisual { Text = "Ranking Vendedores" };
        }

        private void LimpiarGrafico(dynamic chart)
        {
            chart.Series = new ISeries[0];
            chart.Title = new LabelVisual { Text = "Sin Datos" };
        }
    }
}