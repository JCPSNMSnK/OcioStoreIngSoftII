using System;
using System.Collections.Generic;
using System.IO;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class Backup_negocio
    {
        private readonly Backup_Datos objBackupDatos;

        public Backup_negocio()
        {
            objBackupDatos = new Backup_Datos();
        }

        public bool RealizarBackup(string rutaDestino, out string mensaje)
        {
            mensaje = string.Empty;

            // 1. Validación de campos nulos o vacíos
            if (string.IsNullOrWhiteSpace(rutaDestino))
            {
                mensaje = "La ruta de destino no puede ser vacío.";
                return false;
            }

            // 2. Validación del formato de la ruta
            if (!EsRutaValida(rutaDestino))
            {
                mensaje = "La ruta de destino no tiene un formato válido.";
                return false;
            }

            // 3. Validación de existencia del directorio de destino
            string directorioDestino = Path.GetDirectoryName(rutaDestino);
            if (!Directory.Exists(directorioDestino))
            {
                mensaje = "El directorio de destino especificado no existe. Por favor, créelo antes de realizar el backup.";
                return false;
            }

            // Si todas las validaciones pasan, se delega a la capa de datos
            return objBackupDatos.RealizarBackup(rutaDestino, out mensaje);
        }

        private bool EsRutaValida(string path)
        {
            try
            {
                Path.GetFullPath(path);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Método para obtener el historial de backups desde la capa de datos
        public List<HistorialBackup> ObtenerHistorial()
        {
            // La capa de negocio simplemente delega la petición a la capa de datos.
            // Aquí podrías agregar lógica adicional si fuera necesaria, como
            // filtrar por fechas o por tipo de backup, pero en este caso, la
            // simple delegación es suficiente.
            return objBackupDatos.ObtenerHistorialBackups();
        }
    }
}