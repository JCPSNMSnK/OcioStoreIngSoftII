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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            actualizarDatosTabla();
        }

        private void actualizarDatosTabla()
        {
            this.pROC_BUSCAR_CATEGORIATableAdapter.Fill(
                this.dataSet1.PROC_BUSCAR_CATEGORIA,
                null, null, null
            );

            actualizarEstadoVisual();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(filtro))
            {
                this.pROC_BUSCAR_CATEGORIATableAdapter.Fill(
                    this.dataSet1.PROC_BUSCAR_CATEGORIA,
                    null, null, null
                );
            }
            else
            {
                this.pROC_BUSCAR_CATEGORIATableAdapter.Fill(
                    this.dataSet1.PROC_BUSCAR_CATEGORIA,
                    null, filtro, null // FILTRA por nombre_categoria
                );
            }

            actualizarEstadoVisual();
        }

        private void actualizarEstadoVisual()
        {
            foreach (DataGridViewRow row in categoriasDataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                object valor = row.Cells["baja_estado_valor"].Value;

                if (valor != null && valor != DBNull.Value && valor is bool estado)
                {
                    row.Cells["baja_estado"].Value = estado ? "Alta" : "Baja";
                }
                else
                {
                    row.Cells["baja_estado"].Value = "Desconocido";
                }
            }
        }
    }
}
