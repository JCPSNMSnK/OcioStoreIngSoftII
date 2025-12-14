using CapaEntidades;
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
    public partial class GestionarCategorias : Form
    {
        public List<Categoria> CategoriasSeleccionadas { get; private set; }

        public GestionarCategorias (List<Categoria> todasLasCategorias, List<Categoria> categoriasActuales)
        {
            InitializeComponent();
            CLBCategorias.DisplayMember = "nombre_categoria";

            // 2. Llena el CheckedListBox con TODAS las categorías disponibles
            foreach (var categoria in todasLasCategorias)
            {
                CLBCategorias.Items.Add(categoria);
            }

            // 3. Marca las casillas de las categorías que el producto ya tiene
            for (int i = 0; i < CLBCategorias.Items.Count; i++)
            {
                var categoriaEnLista = (Categoria)CLBCategorias.Items[i];
                // Comprueba si esta categoría está en la lista de categorías actuales del producto
                if (categoriasActuales != null && categoriasActuales.Any(c => c.id_categoria == categoriaEnLista.id_categoria))
                {
                    CLBCategorias.SetItemChecked(i, true);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Recolecta todas las categorías que fueron marcadas
            this.CategoriasSeleccionadas = CLBCategorias.CheckedItems.OfType<Categoria>().ToList();

            // Cierra el formulario indicando que se guardaron los cambios
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void GestionarCategorias_Load(object sender, EventArgs e)
        {

        }
    }
}
