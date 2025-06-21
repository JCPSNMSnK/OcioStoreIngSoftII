using CapaEntidades;
using CapaNegocio;
using OcioStoreIngSoftII.Utillidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OcioStoreIngSoftII
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            CBEstado.Items.Add(new OpcionSelect() { Valor = 1, Texto = "Alta" });
            CBEstado.Items.Add(new OpcionSelect() { Valor = 0, Texto = "Baja" });
            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "Valor";
            CBEstado.SelectedIndex = 0;

            CBModificarEstado.Items.Add(new OpcionSelect() { Valor = 1, Texto = "Alta" });
            CBModificarEstado.Items.Add(new OpcionSelect() { Valor = 0, Texto = "Baja" });
            CBModificarEstado.DisplayMember = "Texto";
            CBModificarEstado.ValueMember = "Valor";

            List<Categoria> listaCategorias = new Categoria_negocio().Listar();
            foreach (Categoria item in listaCategorias)
            {
                CBCategoria.Items.Add(new OpcionSelect() { Valor = item.id_categoria, Texto = item.nombre_categoria });
                CBModificarCategoria.Items.Add(new OpcionSelect() { Valor = item.id_categoria, Texto = item.nombre_categoria });
            }
            CBCategoria.DisplayMember = "Texto";
            CBCategoria.ValueMember = "Valor";
            CBCategoria.SelectedIndex = 0;

            CBModificarCategoria.DisplayMember = "Texto";
            CBModificarCategoria.ValueMember = "Valor";
            CBModificarCategoria.SelectedIndex = 0;

            CentrarTodosLosPaneles();

            actualizarDatosTabla();
        }

        private void actualizarDatosTabla()
        {
            this.pROC_BUSCAR_PRODUCTOTableAdapter.Fill(
                this.dataSet1.PROC_BUSCAR_PRODUCTO,
                null, null, null, null, null, null, null, null, null, null, null
            );

            foreach (DataGridViewRow row in productosDataGridView.Rows)
            {
                if (row.Cells["estadoValor"].Value is bool estado)
                {
                    row.Cells["estado"].Value = estado ? "Alta" : "Baja";
                }
            }
        }

        private void PanelAltaProducts_Resize(object sender, EventArgs e)
        {
            CentrarTodosLosPaneles();
        }

        private void TCProductos_Resize(object sender, EventArgs e)
        {
            CentrarTodosLosPaneles();
        }

        private void CentrarTodosLosPaneles()
        {
            CentrarPanel(panelInternoAlta);
            CentrarPanel(panelInternoModif);
        }

        private void CentrarPanel(Panel panel)
        {
            panel.Left = (PanelAltaProducts.Width - panel.Width) / 2;
            panel.Top = (PanelAltaProducts.Height - panel.Height) / 2;
        }
        private void usuariosDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = OcioStoreIngSoftII.Properties.Resources.checkbox.Width;
                var h = OcioStoreIngSoftII.Properties.Resources.checkbox.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - w) / 2;

                e.Graphics.DrawImage(Properties.Resources.checkbox, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void BRegisterProduct_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            // Validaciones
            if (string.IsNullOrWhiteSpace(TNombre.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TDescripcion.Text))
            {
                MessageBox.Show("La descripción es obligatoria.");
                return;
            }

            if (!decimal.TryParse(TPrecioLista.Text, out decimal precioLista) || precioLista < 0)
            {
                MessageBox.Show("Precio de lista inválido.");
                return;
            }

            if (!decimal.TryParse(TPrecioVenta.Text, out decimal precioVenta) || precioVenta < 0)
            {
                MessageBox.Show("Precio de venta inválido.");
                return;
            }

            if (!int.TryParse(NStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Stock inválido.");
                return;
            }

            if (!int.TryParse(NStockMin.Text, out int stockMin) || stockMin < 0)
            {
                MessageBox.Show("Stock mínimo inválido.");
                return;
            }

            if (CBCategoria.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una categoría.");
                return;
            }

            if (CBEstado.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un estado.");
                return;
            }

            // Construcción del objeto Producto
            Producto objProducto = new Producto()
            {
                id_producto = Convert.ToInt32(TID_prod.Text),
                nombre_producto = TNombre.Text,
                descripcion = TDescripcion.Text,
                fechaIngreso = DateTime.Now.ToString("yyyy-MM-dd"),
                precioLista = precioLista,
                precioVenta = precioVenta,
                stock = stock,
                stock_min = stockMin,
                baja_producto = Convert.ToInt32(((OpcionSelect)CBEstado.SelectedItem).Valor) == 1,
            };
            Categoria objCategoria = new Categoria()
            {
                id_categoria = Convert.ToInt32(((OpcionSelect)CBCategoria.SelectedItem).Valor),
                nombre_categoria = ((OpcionSelect)CBCategoria.SelectedItem).Texto
            };

            if (objProducto.id_producto == 0)
            {
                int idRegistrado = new Producto_negocio().Registrar(objProducto, objCategoria, out mensaje);

                if (idRegistrado != 0)
                {
                    VaciarCampos();
                    actualizarDatosTabla(); // Refresca el DataGridView
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new Producto_negocio().Editar(objProducto, objCategoria, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = productosDataGridView.Rows[Convert.ToInt32(TIndice.Text)];

                    row.Cells["id_producto"].Value = TID_prod.Text;
                    row.Cells["nombre_producto"].Value = TNombre.Text;
                    row.Cells["descripcion"].Value = TDescripcion.Text;
                    row.Cells["precioLista"].Value = TPrecioLista.Text;
                    row.Cells["precioVenta"].Value = TPrecioVenta.Text;
                    row.Cells["stock"].Value = NStock.Text;
                    row.Cells["stock_min"].Value = NStockMin.Text;
                    row.Cells["id_categoria"].Value = ((OpcionSelect)CBCategoria.SelectedItem).Valor.ToString();
                    row.Cells["categoria"].Value = ((OpcionSelect)CBCategoria.SelectedItem).Texto.ToString();
                    row.Cells["estadoValor"].Value = ((OpcionSelect)CBEstado.SelectedItem).Valor.ToString();
                    row.Cells["estado"].Value = ((OpcionSelect)CBEstado.SelectedItem).Texto.ToString();

                    VaciarCampos();
                    actualizarDatosTabla();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }

        private void VaciarCampos()
        {
            // Registro
            TID_prod.Text = "0";
            TNombre.Text = "";
            TDescripcion.Text = "";
            TPrecioLista.Text = "";
            TPrecioVenta.Text = "";
            NStock.Text = "";
            NStockMin.Text = "";
            CBCategoria.SelectedIndex = 0;
            CBEstado.SelectedIndex = 0;

            // Modificación (si usás campos separados)
            TModificarID_prod.Text = "0";
            TModificarNombre.Text = "";
            TModificarDescripcion.Text = "";
            TModificarPrecioLista.Text = "";
            TModificarPrecioVenta.Text = "";
            NModificarStock.Text = "";
            NModificarStockMin.Text = "";
            CBModificarCategoria.SelectedIndex = 0;
            CBModificarEstado.SelectedIndex = 0;
        }

        private void productosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productosDataGridView.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    TCProductos.SelectedIndex = 1; // Cambia al tab de modificación

                    TBModificarIndice.Text = indice.ToString();

                    TModificarID_prod.Text = productosDataGridView.Rows[indice].Cells["id_producto"].Value.ToString();
                    TModificarNombre.Text = productosDataGridView.Rows[indice].Cells["nombre_producto"].Value.ToString();
                    TModificarDescripcion.Text = productosDataGridView.Rows[indice].Cells["descripcion"].Value.ToString();
                    TModificarPrecioLista.Text = productosDataGridView.Rows[indice].Cells["precioLista"].Value.ToString();
                    TModificarPrecioVenta.Text = productosDataGridView.Rows[indice].Cells["precioVenta"].Value.ToString();
                    NModificarStock.Text = productosDataGridView.Rows[indice].Cells["stock"].Value.ToString();
                    NModificarStockMin.Text = productosDataGridView.Rows[indice].Cells["stock_min"].Value.ToString();

                    foreach (OpcionSelect opcionSelect in CBModificarCategoria.Items)
                    {
                        if (Convert.ToInt32(opcionSelect.Valor) == Convert.ToInt32(productosDataGridView.Rows[indice].Cells["id_categoria"].Value))
                        {
                            int indice_select = CBModificarCategoria.Items.IndexOf(opcionSelect);
                            CBModificarCategoria.SelectedIndex = indice_select;
                            break;
                        }
                    }

                    foreach (OpcionSelect opcionSelect in CBModificarEstado.Items)
                    {
                        if (Convert.ToInt32(opcionSelect.Valor) == Convert.ToInt32(productosDataGridView.Rows[indice].Cells["estadoValor"].Value))
                        {
                            int indice_select = CBModificarEstado.Items.IndexOf(opcionSelect);
                            CBModificarEstado.SelectedIndex = indice_select;
                            break;
                        }
                    }
                }
            }

        }

        private void BModificar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            // Validación: nombre del producto
            if (string.IsNullOrWhiteSpace(TModificarNombre.Text))
            {
                MessageBox.Show("El nombre del producto no puede estar vacío.");
                return;
            }

            // Validación: descripción
            if (string.IsNullOrWhiteSpace(TModificarDescripcion.Text))
            {
                MessageBox.Show("La descripción no puede estar vacía.");
                return;
            }

            // Validación: precio de lista
            if (!decimal.TryParse(TModificarPrecioLista.Text, out decimal precioLista) || precioLista < 0)
            {
                MessageBox.Show("El precio de lista debe ser un número válido mayor o igual a cero.");
                return;
            }

            // Validación: precio de venta
            if (!decimal.TryParse(TModificarPrecioVenta.Text, out decimal precioVenta) || precioVenta < 0)
            {
                MessageBox.Show("El precio de venta debe ser un número válido mayor o igual a cero.");
                return;
            }

            // Validación: stock
            if (!int.TryParse(NModificarStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("El stock debe ser un número entero mayor o igual a cero.");
                return;
            }

            // Validación: stock mínimo
            if (!int.TryParse(NModificarStockMin.Text, out int stockMin) || stockMin < 0)
            {
                MessageBox.Show("El stock mínimo debe ser un número entero mayor o igual a cero.");
                return;
            }

            // Validación: categoría
            if (CBModificarCategoria.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una categoría.");
                return;
            }

            // Validación: estado
            if (CBModificarEstado.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar el estado.");
                return;
            }

            // Crear el objeto Producto
            Producto objProducto = new Producto()
            {
                id_producto = Convert.ToInt32(TModificarID_prod.Text),
                nombre_producto = TModificarNombre.Text,
                descripcion = TModificarDescripcion.Text,
                precioLista = precioLista,
                precioVenta = precioVenta,
                stock = stock,
                stock_min = stockMin,
                baja_producto = Convert.ToInt32(((OpcionSelect)CBModificarEstado.SelectedItem).Valor) == 1,
            };
            Categoria objCategoria = new Categoria()
            {
                id_categoria = Convert.ToInt32(((OpcionSelect)CBModificarCategoria.SelectedItem).Valor),
                nombre_categoria = ((OpcionSelect)CBModificarCategoria.SelectedItem).Texto
            };

            bool resultado = new Producto_negocio().Editar(objProducto, objCategoria, out mensaje);

            if (resultado)
            {
                DataGridViewRow row = productosDataGridView.Rows[Convert.ToInt32(TBModificarIndice.Text)];

                row.Cells["nombre_producto"].Value = TModificarNombre.Text;
                row.Cells["descripcion"].Value = TModificarDescripcion.Text;
                row.Cells["precioLista"].Value = TModificarPrecioLista.Text;
                row.Cells["precioVenta"].Value = TModificarPrecioVenta.Text;
                row.Cells["stock"].Value = NModificarStock.Text;
                row.Cells["stock_min"].Value = NModificarStockMin.Text;
                row.Cells["id_categoria"].Value = ((OpcionSelect)CBModificarCategoria.SelectedItem).Valor.ToString();
                row.Cells["categoria"].Value = ((OpcionSelect)CBModificarCategoria.SelectedItem).Texto.ToString();
                row.Cells["estadoValor"].Value = Convert.ToInt32(((OpcionSelect)CBModificarEstado.SelectedItem).Valor) == 1;
                row.Cells["estado"].Value = ((OpcionSelect)CBModificarEstado.SelectedItem).Texto.ToString();

                VaciarCampos();
            }
            else
            {
                MessageBox.Show(mensaje);
            }

        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TModificarID_prod.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Producto objProducto = new Producto()
                    {
                        id_producto = Convert.ToInt32(TModificarID_prod.Text)
                    };

                    bool respuesta = new Producto_negocio().Eliminar(objProducto, out mensaje);

                    if (respuesta)
                    {
                        productosDataGridView.Rows.RemoveAt(Convert.ToInt32(TBModificarIndice.Text));
                        VaciarCampos();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

        }
    }
}
