using LiveChartsCore;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.VisualElements;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcioStoreIngSoftII.Themes
{
    public static class FabricaGraficos
    {
        public static LabelVisual CrearTituloGrapf (string texto)
        {
            return new LabelVisual
            {
                Text = texto,
                TextSize = 22,
                Paint = new SolidColorPaint(SKColors.White)
            };
        }

        //Al final esto no funcionó por como funciona liveCharts, pero las risas no faltaron eh
        //Resumen de como funciona esta cosa, no puedo creer que la libreria no lo tenga
        /// <summary>
        /// Inserta saltos de línea en un texto para que no exceda un ancho máximo.
        /// </summary>
        /// <param name="texto">El texto original.</param>
        /// <param name="anchoMaximo">El número máximo de caracteres por línea.</param>
        /// <returns>El texto con saltos de línea (\n) insertados.</returns>
        public static string EnvolverTexto(string texto, int anchoMaximo)
        {
            if (string.IsNullOrEmpty(texto) || texto.Length <= anchoMaximo)
            {
                return texto;
            }

            var sb = new StringBuilder();
            var palabras = texto.Split(' ');
            var lineaActual = string.Empty;

            foreach (var palabra in palabras)
            {
                if ((lineaActual + palabra).Length > anchoMaximo)
                {
                    sb.AppendLine(lineaActual.Trim());
                    lineaActual = string.Empty;
                }

                lineaActual += palabra + " ";
            }

            if (lineaActual.Length > 0)
            {
                sb.Append(lineaActual.Trim());
            }

            return sb.ToString();
        }
    }
}
