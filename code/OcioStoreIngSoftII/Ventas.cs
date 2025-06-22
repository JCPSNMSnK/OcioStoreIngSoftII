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
using System.Windows.Forms;

namespace OcioStoreIngSoftII
{
    public partial class Ventas : Form
    {
        // Instancias de la capa de negocio
        private readonly Producto_negocio _productoNegocio;
        private readonly Categoria_negocio _categoriaNegocio;
        private List<Producto> _listaProductos;

        public Ventas()
        {
            InitializeComponent();
            _productoNegocio = new Producto_negocio();
            _categoriaNegocio = new Categoria_negocio();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            _listaProductos = _productoNegocio.Listar();

            CargarComboBoxCategorias(CBCategoria);
            CargarComboBoxProductos(CBProductos);

            // Establecer índices por defecto si hay elementos
            if (CBProductos.Items.Count > 0) CBProductos.SelectedIndex = 0;
            // CBModificarEstado.SelectedIndex no se establece inicialmente si la idea es que muestre el estado del producto cargado
            if (CBCategoria.Items.Count > 0) CBCategoria.SelectedIndex = 0;
            // CBModificarCategoria.SelectedIndex no se establece inicialmente

            ActualizarDatosTabla();
        }
        private void CargarComboBoxCategorias(ComboBox comboBox)
        {
            // La capa de presentación pide las categorías a la capa de negocio
            comboBox.Items.Clear(); // importante
            List<Categoria> listaCategorias = _categoriaNegocio.Listar();
            foreach (Categoria item in listaCategorias)
            {
                comboBox.Items.Add(new OpcionSelect() { Valor = item.id_categoria, Texto = item.nombre_categoria });
            }
            comboBox.DisplayMember = "Texto";
            comboBox.ValueMember = "Valor";
        }
        private void CargarComboBoxProductos(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            _listaProductos = _productoNegocio.Listar(); // Asignación aquí también

            foreach (Producto item in _listaProductos)
            {
                comboBox.Items.Add(new OpcionSelect() { Valor = item.id_producto, Texto = item.nombre_producto });
            }

            comboBox.DisplayMember = "Texto";
            comboBox.ValueMember = "Valor";
        }

        /// Idealmente, esta carga de datos debería pasar por la capa de negocio.
        private void ActualizarDatosTabla()
        {
            // Esta llamada es al TableAdapter, que es una abstracción de datos
            // generada por Visual Studio, lo que acopla directamente la UI a la fuente de datos.
            // Para una separación estricta, la CapaNegocio debería tener un método
            // que devuelva una lista de Producto o un DataTable, y la UI solo lo consumiría.
            this.pROC_BUSCAR_PRODUCTOTableAdapter.Fill(
                this.dataSet1.PROC_BUSCAR_PRODUCTO,
                null, null, null, null, null, null, null, null, null, null, null
            );

        }

        private void productosDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 0) // Asumiendo que es la columna del botón de selección
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = OcioStoreIngSoftII.Properties.Resources.checkbox.Width;
                var h = OcioStoreIngSoftII.Properties.Resources.checkbox.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - w) / 2;

                e.Graphics.DrawImage(Properties.Resources.checkbox, new System.Drawing.Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void productosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productosDataGridView.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    TBModificarIndice.Text = indice.ToString(); // Guardar índice de la fila para futura actualización

                    // Cargar datos de la fila seleccionada a los controles de modificación
                    TModificarID_prod.Text = productosDataGridView.Rows[indice].Cells["id_producto"].Value.ToString();

                    // Seleccionar la categoría correcta en el ComboBox de modificación
                    if (int.TryParse(productosDataGridView.Rows[indice].Cells["id_producto"].Value.ToString(), out int selectedProductId))
                    {
                        foreach (OpcionSelect opcionSelect in CBProductos.Items)
                        {
                            if (Convert.ToInt32(opcionSelect.Valor) == selectedProductId)
                            {
                                CBProductos.SelectedItem = opcionSelect;
                                break;
                            }
                        }
                    }

                    // Seleccionar la categoría correcta en el ComboBox de modificación
                    if (int.TryParse(productosDataGridView.Rows[indice].Cells["id_categoria"].Value.ToString(), out int selectedCategoryId))
                    {
                        foreach (OpcionSelect opcionSelect in CBCategoria.Items)
                        {
                            if (Convert.ToInt32(opcionSelect.Valor) == selectedCategoryId)
                            {
                                CBCategoria.SelectedItem = opcionSelect;
                                break;
                            }
                        }
                    }

                }
            }
        }

        private void BAddProduct_Click(object sender, EventArgs e)
        {
            var productoSeleccionado = CBProductos.SelectedItem as OpcionSelect;
            if (productoSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un producto.");
                return;
            }

            int idProducto = Convert.ToInt32(productoSeleccionado.Valor);
            Producto producto = _listaProductos.FirstOrDefault(p => p.id_producto == idProducto);

            if (producto == null)
            {
                MessageBox.Show("Producto no encontrado en la lista.");
                return;
            }

            int stockDisponible = producto.stock;
            decimal precio = producto.precioVenta;
            string nombre = producto.nombre_producto;
            int cantidadNueva = (int)NCantidad.Value;

            // Verificar si ya está en la grilla
            DataGridViewRow filaExistente = null;
            foreach (DataGridViewRow fila in VentaDataGridView.Rows)
            {
                if (Convert.ToInt32(fila.Cells["id_producto_venta"].Value) == idProducto)
                {
                    filaExistente = fila;
                    break;
                }
            }

            if (filaExistente != null)
            {
                int cantidadExistente = Convert.ToInt32(filaExistente.Cells["cantidad"].Value);
                int nuevaCantidad = cantidadExistente + cantidadNueva;

                if (nuevaCantidad > stockDisponible)
                {
                    MessageBox.Show("No se puede agregar más unidades. Stock disponible: " + stockDisponible);
                    return;
                }

                filaExistente.Cells["cantidad"].Value = nuevaCantidad;
            }
            else
            {
                if (cantidadNueva > stockDisponible)
                {
                    MessageBox.Show("Cantidad supera el stock disponible: " + stockDisponible);
                    return;
                }

                VentaDataGridView.Rows.Add(idProducto, nombre, precio, cantidadNueva);
            }
        }

        private void VentaDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 4) // Asumiendo que es la columna del botón de selección
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = OcioStoreIngSoftII.Properties.Resources.delete_button.Width;
                var h = OcioStoreIngSoftII.Properties.Resources.delete_button.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - w) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete_button, new System.Drawing.Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void CBProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBProductos.SelectedItem is OpcionSelect productoSeleccionado)
            {
                int idProducto = Convert.ToInt32(productoSeleccionado.Valor);

                Producto prod = _productoNegocio.Listar().FirstOrDefault(p => p.id_producto == idProducto);

                if (prod != null)
                {
                    // Limita el control a la cantidad de stock disponible (mínimo 1)
                    NCantidad.Maximum = prod.stock > 0 ? prod.stock : 1;

                    if (NCantidad.Value > NCantidad.Maximum)
                        NCantidad.Value = NCantidad.Maximum;
                }
                else
                {
                    NCantidad.Maximum = 1;
                    NCantidad.Value = 1;
                }
            }
            else
            {
                NCantidad.Maximum = 1;
                NCantidad.Value = 1;
            }
        }

        private void VentaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && VentaDataGridView.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                var resultado = MessageBox.Show("¿Desea eliminar este producto de la venta?",
                                                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    VentaDataGridView.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }

    // Lógica de dibujo de celdas - Pertenece a la capa de Presentación


}

