using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcioStoreIngSoftII.Themes
{
    public static class PaletaColores
    {
        // Esta es una propiedad estática y de solo lectura que contiene tu paleta.
        public static SKColor[] OcioStore { get; } = new[]
        {
            new SKColor(28, 127, 251),   // Azul
            new SKColor(183, 208, 237),  // Azul claro
            new SKColor(255, 193, 7),    // Amarillo
            new SKColor(255, 112, 67),   // Naranja
            new SKColor(92, 107, 192)    // Indigo
        };
    }
}
