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

namespace OcioStoreIngSoftII
{
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
        }

        private void cuiFolderDropper1_FolderDropped(object sender, CuoreUI.Controls.FolderDroppedEventArgs e)
        {
            MessageBox.Show(e.FolderName);
        }

        private void cartesianChart1_Load(object sender, EventArgs e)
        {
            cartesianChart1.Series = new ISeries[]
            {
                new LineSeries<double>
                {
                    Values = new double[] { 2, 1, 3, 5, 3, 4, 6 },
                    Fill = null
                }
            };
        }

        private void cuiLabel1_Load(object sender, EventArgs e)
        {

        }

        private void cuiLabel2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cartesianChart1_Load_2(object sender, EventArgs e)
        {
            var seriesColors = PaletaColores.OcioStore;
            cartesianChart1.Series = new ISeries[]
            {
                new LineSeries<double>
                {
                    Name = "Ventas",
                    Values = new double[] { 2, 1, 35, 5, 3, 4, 6 },
                    Fill = new SolidColorPaint(seriesColors[0]),
                }
            };

            cartesianChart1.XAxes = new[]
            {
                new Axis
                {
                    Name = "Día",
                    NamePaint = new SolidColorPaint(new SKColor(180, 180, 180)),
                    LabelsPaint = new SolidColorPaint(new SKColor(180, 180, 180)),
                    SeparatorsPaint = new SolidColorPaint(new SKColor(255, 255, 255, 40))
                }
            };

            cartesianChart1.YAxes = new[]
            {
                new Axis
                {
                    Name = "Total Vendido",
                    NamePaint = new SolidColorPaint(new SKColor(180, 180, 180)),
                    LabelsPaint = new SolidColorPaint(new SKColor(180, 180, 180)),
                    SeparatorsPaint = new SolidColorPaint(new SKColor(255, 255, 255, 40)),
                    MinLimit = 0 // Asegura que el eje empiece en 0
                }
            };

            // 5. Configura el Título, Tooltip y Leyenda
            cartesianChart1.Title = new LabelVisual
            {
                Text = "Productos más Vendidos",
                TextSize = 22,
                Paint = new SolidColorPaint(SKColors.White)
            };

            cartesianChart1.TooltipTextPaint = new SolidColorPaint(SKColors.White);
            cartesianChart1.TooltipBackgroundPaint = new SolidColorPaint(new SKColor(40, 40, 40));
            cartesianChart1.LegendTextPaint = new SolidColorPaint(new SKColor(180, 180, 180));
            cartesianChart1.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
        }

        private void pieChart1_Load_1(object sender, EventArgs e)
        {
            var seriesColors = PaletaColores.OcioStore;

            var datos = new[]
            {
                new PieSeries<double> { Values = new double[] { 2 }, Name = "Producto A" },
                new PieSeries<double> { Values = new double[] { 4 }, Name = "Producto B" },
                new PieSeries<double> { Values = new double[] { 1 }, Name = "Producto C" },
                new PieSeries<double> { Values = new double[] { 4 }, Name = "Producto D" },
                new PieSeries<double> { Values = new double[] { 3 }, Name = "Producto E" }
            };

            int colorIndex = 0;
            foreach (var serie in datos)
            {
                // Asigna el color correspondiente de la paleta.
                // El operador '%' asegura que si hay más series que colores, los colores se repitan.
                serie.Fill = new SolidColorPaint(seriesColors[colorIndex % seriesColors.Length]);

                // (Opcional) Pinta las etiquetas de los datos para que se vean bien
                serie.DataLabelsPaint = new SolidColorPaint(SKColors.White);
                serie.DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Outer;

                colorIndex++;
            }

            pieChart1.Title = new LabelVisual
            {
                Text = "Productos mas Vendidos",
                TextSize = 22,
                Paint = new SolidColorPaint(SKColors.White)
            };

            pieChart1.Series = datos;
            pieChart1.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
        }

        private void pieChart2_Load_1(object sender, EventArgs e)
        {
            var seriesColors = PaletaColores.OcioStore;

            var datos = new[]
            {
                new PieSeries<double> { Values = new double[] { 12 }, Name = "Producto A" },
                new PieSeries<double> { Values = new double[] { 6 }, Name = "Producto B" },
                new PieSeries<double> { Values = new double[] { 1 }, Name = "Producto C" },
                new PieSeries<double> { Values = new double[] { 4 }, Name = "Producto D" },
                new PieSeries<double> { Values = new double[] { 3 }, Name = "Producto E" }
            };

            int colorIndex = 0;
            foreach (var serie in datos)
            {
                // Asigna el color correspondiente de la paleta.
                // El operador '%' asegura que si hay más series que colores, los colores se repitan.
                serie.Fill = new SolidColorPaint(seriesColors[colorIndex % seriesColors.Length]);

                // (Opcional) Pinta las etiquetas de los datos para que se vean bien
                serie.DataLabelsPaint = new SolidColorPaint(SKColors.White);
                serie.DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Outer;

                colorIndex++;
            }

            pieChart2.Title = new LabelVisual
            {
                Text = "Categorías mas Vendidas",
                TextSize = 22,
                Paint = new SolidColorPaint(SKColors.White)
            };

            pieChart2.Series = datos;
            pieChart2.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);

        }

        private void cartesianChart2_Load_1(object sender, EventArgs e)
        {
            var seriesColors = PaletaColores.OcioStore;
            var datos = new double[] { 2, 5, 4 };
            var datos2 = new double[] { 7, 2, 4 };

            cartesianChart2.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.X;
            cartesianChart2.Series = new ISeries[] {
            new ColumnSeries<double>
                {
                Name = "Marita",
                Values = datos
                },
            new ColumnSeries<double>
                {
                Name = "Josefa",
                Values = datos2
                }
            };

            cartesianChart2.YAxes = new[]
            {
                new Axis
                {
                    Name = "Total Comprado(?",
                    NamePaint = new SolidColorPaint(new SKColor(180, 180, 180)),
                    SeparatorsPaint = new SolidColorPaint(new SKColor(255, 255, 255, 40)),
                    MinLimit = 0 // El límite mínimo va en el eje de valores (Y)
                }
            };

            cartesianChart2.XAxes = new[]
            {
                new Axis
                {
                    Name = "Productos",
                    Labels = new string [] {"Producto 1", "Producto 2", "Producto 3" },
                    LabelsRotation = 0,
                    NamePaint = new SolidColorPaint(new SKColor(180, 180, 180)),
                    SeparatorsAtCenter = false,
                    TicksAtCenter = true,
                    SeparatorsPaint = new SolidColorPaint(new SKColor(255, 255, 255, 40)),
                    MinLimit = 0 // Asegura que el eje empiece en 0
                }
            };

            cartesianChart2.Title = new LabelVisual
            {
                Text = "Vendedor con más Ventas",
                TextSize = 22,
                Paint = new SolidColorPaint(SKColors.White)
            };


            cartesianChart2.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
