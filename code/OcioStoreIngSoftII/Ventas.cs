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

        public Ventas()
        {
            InitializeComponent();
            _productoNegocio = new Producto_negocio();
            _categoriaNegocio = new Categoria_negocio();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            
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
            // La capa de presentación pide las categorías a la capa de negocio
            comboBox.Items.Clear(); // importante
            List<Producto> listaProductos = _productoNegocio.Listar();
            foreach (Producto item in listaProductos)
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
            if (CBProductos.SelectedItem is OpcionSelect productoSeleccionado)
            {
                // Obtener producto seleccionado (puedes usar tu negocio para obtener datos exactos)
                int idProducto = Convert.ToInt32(productoSeleccionado.Valor);

                // Buscamos el objeto producto completo (precio, nombre, etc)
                Producto prod = _productoNegocio.Listar().FirstOrDefault(p => p.id_producto == idProducto);

                if (prod == null)
                {
                    MessageBox.Show("Producto no encontrado.");
                    return;
                }

                // Validar cantidad
                if (!int.TryParse(NCantidad.Text.Trim(), out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida mayor a 0.");
                    return;
                }

                // Verificar si ya existe el producto en el DataGridView
                foreach (DataGridViewRow row in VentaDataGridView.Rows)
                {
                    if (row.Cells["nombre"].Value != null &&
                        row.Cells["nombre"].Value.ToString() == prod.nombre_producto)
                    {
                        // Si ya existe, actualizar cantidad
                        int cantidadActual = Convert.ToInt32(row.Cells["cantidad"].Value);
                        row.Cells["cantidad"].Value = cantidadActual + cantidad;
                        return;
                    }
                }

                // Si no existe, agregar nueva fila
                VentaDataGridView.Rows.Add(prod.id_producto, prod.nombre_producto, prod.precioVenta, cantidad);
            }
            else
            {
                MessageBox.Show("Seleccione un producto primero.");
            }
        }
    }

        // Lógica de dibujo de celdas - Pertenece a la capa de Presentación


}

