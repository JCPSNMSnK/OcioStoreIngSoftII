using CapaEntidades;
using CapaEntidades.Utilidades;
using CapaNegocio;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OcioStoreIngSoftII
{
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
        }
        private Backup_negocio objBackupNegocio = new Backup_negocio();

        private void Backup_Load(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void GestionarEstadoUI(bool estaOcupado)
        {
            progressBarBackup.Style = ProgressBarStyle.Marquee;
            progressBarBackup.Visible = estaOcupado;
            BtnRealizarBackup.Enabled = !estaOcupado;
            BtnExaminar.Enabled = !estaOcupado;
            BackupDataGridView.Enabled = !estaOcupado; // También deshabilita el grid
            this.Cursor = estaOcupado ? Cursors.WaitCursor : Cursors.Default;
            lblEstado.Content = estaOcupado ? "Procesando... por favor espere." : "Listo.";
        }

        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo de Backup (*.bak)|*.bak";
            saveFileDialog.Title = "Guardar Copia de Seguridad";
            // Sugiere un nombre de archivo con fecha y hora
            saveFileDialog.FileName = $"Backup_OcioStore_{DateTime.Now:yyyyMMdd_HHmmss}.bak";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                TRutaBackup.Text = saveFileDialog.FileName;
                lblEstado.Content = "Ruta seleccionada. Listo para iniciar.";
            }
        }

        private async void BtnRealizarBackup_Click(object sender, EventArgs e)
        {
            string ruta = TRutaBackup.Text;

            GestionarEstadoUI(true);
            ResultadoOperacion resultado = await Task.Run(() => objBackupNegocio.RealizarBackup(ruta));

            GestionarEstadoUI(false);
            if (resultado.Exito)
            {
                lblEstado.Content = "Backup completado exitosamente.";
                MessageBox.Show(resultado.Mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarHistorial();
            }
            else
            {
                lblEstado.Content = "Error al realizar el backup.";
                MessageBox.Show(resultado.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRecarcar_Click(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void CargarHistorial()
        {
            List<HistorialBackup> historial = objBackupNegocio.ObtenerHistorial();
            BackupDataGridView.AutoGenerateColumns = false;
            BackupDataGridView.DataSource = null;
            BackupDataGridView.DataSource = historial;
        }
    }
}
