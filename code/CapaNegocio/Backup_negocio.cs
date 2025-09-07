using CapaDatos;
using CapaEntidades;
using CapaEntidades.Utilidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;


namespace CapaNegocio
{
    public class Backup_negocio
    {
        private readonly Backup_Datos objBackupDatos;

        public Backup_negocio()
        {
            objBackupDatos = new Backup_Datos();
        }

        public ResultadoOperacion RealizarBackup(string rutaDestino)
        {
            if (!ValidarRutaBackup(rutaDestino, out string mensajeError))
            {
                return new ResultadoOperacion { Exito = false, Mensaje = mensajeError};
            }
            // Si todas las validaciones pasan, se delega a la capa de datos
            return objBackupDatos.RealizarBackup(rutaDestino);
        }

        private bool ValidarRutaBackup(string rutaDestino, out string mensaje)
        {
            mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(rutaDestino))
            {
                mensaje = "La ruta de destino no puede ser vacía.";
                return false;
            }

            try
            {
                // Comprueba si la ruta tiene un formato válido
                Path.GetFullPath(rutaDestino);

                // Comprueba si el directorio donde se guardará el archivo existe
                string directorioDestino = Path.GetDirectoryName(rutaDestino);
                if (!Directory.Exists(directorioDestino))
                {
                    mensaje = "El directorio de destino especificado no existe.";
                    return false;
                }
            }
            catch (Exception)
            {
                mensaje = "La ruta de destino no tiene un formato válido.";
                return false;
            }

            // Si todas las validaciones son exitosas
            return true;
        }

        // Método para obtener el historial de backups desde la capa de datos
        public List<HistorialBackup> ObtenerHistorial()
        {
            return objBackupDatos.ObtenerHistorialBackups();
        }
    }
}