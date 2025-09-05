using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.VisualElements;
using LiveChartsCore.SkiaSharpView.WinForms;
using OcioStoreIngSoftII.Themes;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iText.Svg.SvgConstants;
using CapaEntidades;
using CapaNegocio;

namespace OcioStoreIngSoftII
{
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
        }

        private Informes_Negocio objNegocio = new Informes_Negocio();

        private void Stats_Load(object sender, EventArgs e)
        {
            DtpFechaFin.Content = DateTime.Now;
            DtpFechaInicio.Content = DateTime.Now.AddMonths(-1);

            CargarDashboard();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            // Valida las fechas antes de continuar
            if (DtpFechaInicio.Content > DtpFechaFin.Content)
            {
                MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CargarDashboard();
        }

        private void CargarDashboard()
        {
            DateTime fechaInicio = DtpFechaInicio.Content;
            DateTime fechaFin = DtpFechaFin.Content;

            CargarGraficoFluctuacionVentas(fechaInicio, fechaFin);
            CargarGraficoProductosMasVendidos(fechaInicio, fechaFin);
            CargarGraficoCategoriasMasVendidas(fechaInicio, fechaFin);
            //CargarGraficoVendedoresMasVentas(fechaInicio, fechaFin);
        }

        private void CargarGraficoFluctuacionVentas(DateTime fechaInicio, DateTime fechaFin)
        {
            List<VentaPorPeriodo> resultados = objNegocio.ObtenerFluctuacionDeVentas(fechaInicio, fechaFin);

            var chart = GraphFluctuacionVentas;

            if (resultados.Count == 0)
            {
                chart.Series = new ISeries[0];
                chart.Title = FabricaGraficos.CrearTituloGrapf("No hay productos vendidos en este período");
                return;
            }

            // Adapta los datos para LiveCharts usando LINQ
            var valores = resultados.Select(v => v.total_ventas).ToArray();
            var etiquetas = resultados.Select(v => v.fecha_periodo.ToString("dd/MM")).ToArray();

            chart.Series = new ISeries[]
            {
        new LineSeries<decimal>
        {
            Name = "Total de Ventas",
            Values = valores,
            Fill = null // Muestra solo la línea
        }
            };

            chart.XAxes = new[] { new Axis { Name = "Fecha", Labels = etiquetas } };
            chart.YAxes = new[] { new Axis { Name = "Ingresos", MinLimit = 0 } };
            chart.Title = FabricaGraficos.CrearTituloGrapf("Fluctuación de Ventas");
        }
        
        private void CargarGraficoProductosMasVendidos(DateTime fechaInicio, DateTime fechaFin)
        {
            // Llama a la capa de negocio
            List<ProductoVendido> resultados = objNegocio.ObtenerProductosMasVendidos(fechaInicio, fechaFin);

            var chart = GraphVendedoresMasVentas; // Asigna el gráfico correcto

            if (resultados.Count == 0)
            {
                chart.Series = new ISeries[0];
                chart.Title = FabricaGraficos.CrearTituloGrapf("No hay productos vendidos en este período");
                return;
            }

            // Adapta los datos para un gráfico de barras horizontales
            var valores = resultados.Select(p => (double)p.cantidad_vendida).ToArray();
            var etiquetas = resultados.Select(p => p.nombre_producto).ToArray();

            chart.Series = new ISeries[]
            {
                new ColumnSeries<double>
                {
                    Name = "Cantidad",
                    Values = valores
                }
            };

            chart.XAxes = new[] { new Axis { Labels = etiquetas, LabelsRotation = 90 }  };
            chart.YAxes = new[] { new Axis { MinLimit = 0 } };
            chart.Title = FabricaGraficos.CrearTituloGrapf("Top Productos Vendidos");
            chart.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.PanX;
        }
        

        private void CargarGraficoCategoriasMasVendidas(DateTime fechaInicio, DateTime fechaFin)
        {
            List<CategoriaMasVendida> resultados = objNegocio.ObtenerCategoriasMasVendidas(fechaInicio, fechaFin);

            var chart = GraphCategoriasMasVendidas; // Asigna el gráfico correcto

            if (resultados.Count == 0)
            {
                chart.Series = new ISeries[0];
                chart.Title = FabricaGraficos.CrearTituloGrapf("No hay ventas por categoría en este período");
                return;
            }

            var datos = resultados.Select(categoria => new PieSeries<double>
            {
                Values = new double[] { (double)categoria.cantidad_vendida },
                Name = categoria.nombre_categoria
            }).ToArray();

            chart.Title = FabricaGraficos.CrearTituloGrapf("Ventas por Categoría");

            for (int i = 0; i < datos.Length; i++)
            {
                // Operador '%' para que los colores se repitan si hay más series que colores
                datos[i].Fill = new SolidColorPaint(PaletaColores.OcioStore[i % PaletaColores.OcioStore.Length]);
            }

            chart.Series = datos;
            chart.LegendPosition = LiveChartsCore.Measure.LegendPosition.Bottom;

            chart.Title = FabricaGraficos.CrearTituloGrapf("Ventas por Categoría");
        }
    }
}
