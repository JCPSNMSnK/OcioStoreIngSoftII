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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();

            // Si está vacío, muestra todos
            if (string.IsNullOrEmpty(filtro))
            {
                this.pROC_BUSCAR_USUARIOTableAdapter.Fill(
                    this.dataSet1.PROC_BUSCAR_USUARIO,
                    null, null, null, null, null, null, null, null, null
                );
                return;
            }

            // Intentar buscar por id_user si es numérico
            if (int.TryParse(filtro, out int idVal))
            {
                this.pROC_BUSCAR_USUARIOTableAdapter.Fill(
                    this.dataSet1.PROC_BUSCAR_USUARIO,
                    idVal, null, null, null, null, null, null, null, null
                );
                return;
            }

            // Si no es numérico, intenta por los campos de texto

            this.pROC_BUSCAR_USUARIOTableAdapter.Fill(
                this.dataSet1.PROC_BUSCAR_USUARIO,
                null, filtro, null, null, null, null, null, null, null // apellido
            );

            if (this.dataSet1.PROC_BUSCAR_USUARIO.Rows.Count == 0)
            {
                this.pROC_BUSCAR_USUARIOTableAdapter.Fill(this.dataSet1.PROC_BUSCAR_USUARIO, null, null, filtro, null, null, null, null, null, null); // nombre
            }
            if (this.dataSet1.PROC_BUSCAR_USUARIO.Rows.Count == 0)
            {
                this.pROC_BUSCAR_USUARIOTableAdapter.Fill(this.dataSet1.PROC_BUSCAR_USUARIO, null, null, null, filtro, null, null, null, null, null); // dni
            }
            if (this.dataSet1.PROC_BUSCAR_USUARIO.Rows.Count == 0)
            {
                this.pROC_BUSCAR_USUARIOTableAdapter.Fill(this.dataSet1.PROC_BUSCAR_USUARIO, null, null, null, null, filtro, null, null, null, null); // mail
            }
            if (this.dataSet1.PROC_BUSCAR_USUARIO.Rows.Count == 0)
            {
                this.pROC_BUSCAR_USUARIOTableAdapter.Fill(this.dataSet1.PROC_BUSCAR_USUARIO, null, null, null, null, null, filtro, null, null, null); // username
            }
            if (this.dataSet1.PROC_BUSCAR_USUARIO.Rows.Count == 0)
            {
                this.pROC_BUSCAR_USUARIOTableAdapter.Fill(this.dataSet1.PROC_BUSCAR_USUARIO, null, null, null, null, null, null, null, null, filtro); // username
            }

        }


        private void Users_Load(object sender, EventArgs e)
        {
            this.pROC_BUSCAR_USUARIOTableAdapter.Fill(
            this.dataSet1.PROC_BUSCAR_USUARIO,
            null, null, null, null, null, null, null, null, null
    );
        }
    }
}
