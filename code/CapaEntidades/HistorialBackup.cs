using System;

namespace CapaEntidades
{
    public class HistorialBackup
    {
        public string NombreBaseDeDatos { get; set; }
        public DateTime FechaInicioBackup { get; set; }
        public DateTime FechaFinBackup { get; set; }
        public decimal TamanoMB { get; set; }
        public string RutaArchivo { get; set; }
    }
}