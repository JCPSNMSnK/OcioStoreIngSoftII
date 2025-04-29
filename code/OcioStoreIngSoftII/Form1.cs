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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.UserDetailed' Puede moverla o quitarla según sea necesario.
            this.userDetailedTableAdapter.FillDetailed(this.dataSet1.UserDetailed);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.UserDetailed' Puede moverla o quitarla según sea necesario.
            this.userDetailedTableAdapter.FillDetailed(this.dataSet1.UserDetailed);

        }

        private void usersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }
    }
}
