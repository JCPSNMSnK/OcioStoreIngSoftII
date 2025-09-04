using CapaEntidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace CapaDatos
{
    public class Backup_Datos
    {
        public bool RealizarBackup(string rutaDestino, out string mensaje)
        {
            mensaje = string.Empty;
            bool exito = false;
            string nombreBaseDeDatos = "ocio_store";

            // Validación de seguridad: Asegurar que la ruta no sea maliciosa.
            // Para un entorno de producción, es crucial validar la ruta.
            if (string.IsNullOrWhiteSpace(rutaDestino) || string.IsNullOrWhiteSpace(nombreBaseDeDatos))
            {
                mensaje = "La ruta de destino y el nombre de la base de datos no pueden ser vacíos.";
                return false;
            }

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    // El comando SQL BACKUP DATABASE es el que hace la magia.
                    string query = $"BACKUP DATABASE [{nombreBaseDeDatos}] TO DISK = '{rutaDestino}' WITH NOFORMAT, NOINIT, NAME = N'Full Backup', SKIP, NOREWIND, NOUNLOAD, STATS = 10;";
                    
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    mensaje = $"Backup de la base de datos '{nombreBaseDeDatos}' realizado exitosamente en: {rutaDestino}";
                    exito = true;
                }
            }
            catch (Exception ex)
            {
                mensaje = $"Error al realizar el backup: {ex.Message}";
                exito = false;
            }

            return exito;
        }

        public List<HistorialBackup> ObtenerHistorialBackups()
        {
            List<HistorialBackup> historial = new List<HistorialBackup>();
            string nombreBaseDeDatos = "ocio_store";

            try
            {
                // Conectamos directamente a la base de datos 'master' o 'msdb' para acceder a las tablas del sistema.
                // Es preferible usar la conexión a 'master' para consultas de todo el servidor.
                string cadenaMaster = Conexion.cadena.Replace("database=" + nombreBaseDeDatos, "database=master");

                using (SqlConnection oconexion = new SqlConnection(cadenaMaster))
                {
                    string query = @"
                        SELECT TOP 10
                            bs.database_name,
                            bs.backup_start_date,
                            bs.backup_finish_date,
                            bs.backup_size,
                            bmf.physical_device_name
                        FROM
                            msdb.dbo.backupset AS bs
                        INNER JOIN
                            msdb.dbo.backupmediafamily AS bmf ON bs.media_set_id = bmf.media_set_id
                        WHERE
                            bs.database_name = @nombreBaseDeDatos
                            AND bs.type = 'D' -- 'D' para backups completos
                        ORDER BY
                            bs.backup_finish_date DESC;";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@nombreBaseDeDatos", nombreBaseDeDatos);
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            historial.Add(new HistorialBackup()
                            {
                                NombreBaseDeDatos = dr["database_name"].ToString(),
                                FechaInicioBackup = Convert.ToDateTime(dr["backup_start_date"]),
                                FechaFinBackup = Convert.ToDateTime(dr["backup_finish_date"]),
                                TamanoMB = Math.Round(Convert.ToDecimal(dr["backup_size"]) / 1024 / 1024, 2),
                                RutaArchivo = dr["physical_device_name"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception)
            {
                // En caso de error, devolvemos una lista vacía para evitar fallos.
                historial = new List<HistorialBackup>();
            }

            return historial;
        }
    }
}