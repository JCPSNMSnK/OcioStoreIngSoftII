using CapaEntidades;
using CapaNegocio;
using OcioStoreIngSoftII.Utillidades; // Assuming OpcionSelect is here
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace OcioStoreIngSoftII
{
    public partial class Products : Form
    {
        private readonly Producto_negocio _productoNegocio;
        private readonly Categoria_negocio _categoriaNegocio;

        public Products()
        {
            InitializeComponent();
            // Instantiate business logic classes
            _productoNegocio = new Producto_negocio();
            _categoriaNegocio = new Categoria_negocio();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            // Populate ComboBoxes - UI specific logic
            // Estado ComboBoxes
            CBEstado.Items.Add(new OpcionSelect() { Valor = 1, Texto = "Alta" });
            CBEstado.Items.Add(new OpcionSelect() { Valor = 0, Texto = "Baja" });
            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "Valor";
            CBEstado.SelectedIndex = 0;

            CBModificarEstado.Items.Add(new OpcionSelect() { Valor = 1, Texto = "Alta" });
            CBModificarEstado.Items.Add(new OpcionSelect() { Valor = 0, Texto = "Baja" });
            CBModificarEstado.DisplayMember = "Texto";
            CBModificarEstado.ValueMember = "Valor";
            // No default selection here, will be set when loading existing product data

            // Category ComboBoxes
            List<Categoria> listaCategorias = _categoriaNegocio.Listar(); // Call to Business Layer
            foreach (Categoria item in listaCategorias)
            {
                CBCategoria.Items.Add(new OpcionSelect() { Valor = item.id_categoria, Texto = item.nombre_categoria });
                CBModificarCategoria.Items.Add(new OpcionSelect() { Valor = item.id_categoria, Texto = item.nombre_categoria });
            }
            CBCategoria.DisplayMember = "Texto";
            CBCategoria.ValueMember = "Valor";
            if (CBCategoria.Items.Count > 0) CBCategoria.SelectedIndex = 0; // Ensure there are items before selecting

            CBModificarCategoria.DisplayMember = "Texto";
            CBModificarCategoria.ValueMember = "Valor";
            if (CBModificarCategoria.Items.Count > 0) CBModificarCategoria.SelectedIndex = 0; // Ensure there are items before selecting

            // Load initial data for the grid
            ActualizarDatosTabla();
        }

        private void ActualizarDatosTabla()
        {
            // This method directly interacts with your DataSet and TableAdapter.
            // Ideally, the data retrieval itself would be delegated to the BLL,
            // which would then get it from the DAL.
            // For now, keeping it here as it's tightly coupled to your DataSet/TableAdapter.
            this.pROC_BUSCAR_PRODUCTOTableAdapter.Fill(
                this.dataSet1.PROC_BUSCAR_PRODUCTO,
                null, null, null, null, null, null, null, null, null, null, null
            );

            // UI specific formatting for the 'estado' column
            foreach (DataGridViewRow row in productosDataGridView.Rows)
            {
                if (row.Cells["estadoValor"].Value is bool estado)
                {
                    row.Cells["estado"].Value = estado ? "Alta" : "Baja";
                }
            }
        }

        // UI Painting logic - remains in UI layer
        private void productosDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 0) // Assuming this is your "select" column
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = OcioStoreIngSoftII.Properties.Resources.checkbox.Width;
                var h = OcioStoreIngSoftII.Properties.Resources.checkbox.Height; // Fixed potential typo
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - w) / 2;

                e.Graphics.DrawImage(Properties.Resources.checkbox, new System.Drawing.Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        // UI Utility: Clearing input fields
        private void VaciarCampos()
        {
            // Registration fields
            TID_prod.Text = "0";
            TNombre.Text = "";
            TDescripcion.Text = "";
            TPrecioLista.Text = "";
            TPrecioVenta.Text = "";
            NStock.Text = "";
            NStockMin.Text = "";
            if (CBCategoria.Items.Count > 0) CBCategoria.SelectedIndex = 0;
            if (CBEstado.Items.Count > 0) CBEstado.SelectedIndex = 0;

            // Modification fields
            TModificarID_prod.Text = "0";
            TModificarNombre.Text = "";
            TModificarDescripcion.Text = "";
            TModificarPrecioLista.Text = "";
            TModificarPrecioVenta.Text = "";
            NModificarStock.Text = "";
            NModificarStockMin.Text = "";
            if (CBModificarCategoria.Items.Count > 0) CBModificarCategoria.SelectedIndex = 0;
            if (CBModificarEstado.Items.Count > 0) CBModificarEstado.SelectedIndex = 0;
        }

        // UI Logic: Handling cell click to load data for modification
        private void productosDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (productosDataGridView.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    TCProductos.SelectedIndex = 1; // Switch to modification tab

                    TBModificarIndice.Text = indice.ToString();

                    // Populate modification fields from selected row
                    TModificarID_prod.Text = productosDataGridView.Rows[indice].Cells["id_producto"].Value.ToString();
                    TModificarNombre.Text = productosDataGridView.Rows[indice].Cells["nombre_producto"].Value.ToString();
                    TModificarDescripcion.Text = productosDataGridView.Rows[indice].Cells["descripcion"].Value.ToString();
                    TModificarPrecioLista.Text = productosDataGridView.Rows[indice].Cells["precioLista"].Value.ToString();
                    TModificarPrecioVenta.Text = productosDataGridView.Rows[indice].Cells["precioVenta"].Value.ToString();
                    NModificarStock.Text = productosDataGridView.Rows[indice].Cells["stock"].Value.ToString();
                    NModificarStockMin.Text = productosDataGridView.Rows[indice].Cells["stock_min"].Value.ToString();

                    // Select category in ComboBox
                    if (int.TryParse(productosDataGridView.Rows[indice].Cells["id_categoria"].Value.ToString(), out int selectedCategoryId))
                    {
                        foreach (OpcionSelect opcionSelect in CBModificarCategoria.Items)
                        {
                            if (Convert.ToInt32(opcionSelect.Valor) == selectedCategoryId)
                            {
                                CBModificarCategoria.SelectedItem = opcionSelect;
                                break;
                            }
                        }
                    }

                    // Select state in ComboBox
                    if (productosDataGridView.Rows[indice].Cells["estadoValor"].Value is bool isAlta)
                    {
                        foreach (OpcionSelect opcionSelect in CBModificarEstado.Items)
                        {
                            if ((Convert.ToInt32(opcionSelect.Valor) == 1 && isAlta) || (Convert.ToInt32(opcionSelect.Valor) == 0 && !isAlta))
                            {
                                CBModificarEstado.SelectedItem = opcionSelect;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void BRegisterProduct_Click_1(object sender, EventArgs e)
        {
            // 1. **UI Validations (format and presence)**
            // All 'if (string.IsNullOrWhiteSpace(...))' and 'if (!decimal.TryParse(...))' checks
            // remain here. These are quick checks to ensure input is in the correct format
            // or not empty before even attempting to pass to the business layer.
            if (!ValidarCamposRegistro(out string uiValidationMessage))
            {
                MessageBox.Show(uiValidationMessage, "Error de ValidaciÃ³n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. **Parse/Convert UI Input to appropriate types**
            // Convert strings from TextBoxes to their respective types (decimal, int, bool)
            decimal precioLista = decimal.Parse(TPrecioLista.Text);
            decimal precioVenta = decimal.Parse(TPrecioVenta.Text);
            int stock = int.Parse(NStock.Text);
            int stockMin = int.Parse(NStockMin.Text);
            bool bajaProducto = Convert.ToInt32(((OpcionSelect)CBEstado.SelectedItem).Valor) == 1;
            int idCategoria = Convert.ToInt32(((OpcionSelect)CBCategoria.SelectedItem).Valor);
            string nombreCategoria = ((OpcionSelect)CBCategoria.SelectedItem).Texto;

            // 3. **Create Entity Object(s)**
            // Populate a Producto object with data from the UI
            Producto objProducto = new Producto()
            {
                id_producto = Convert.ToInt32(TID_prod.Text), // Assuming TID_prod is 0 for new records
                nombre_producto = TNombre.Text,
                descripcion = TDescripcion.Text,
                fechaIngreso = DateTime.Now.ToString("yyyy-MM-dd"), // This could be handled in BLL or DAL as well
                precioLista = precioLista,
                precioVenta = precioVenta,
                stock = stock,
                stock_min = stockMin,
                baja_producto = bajaProducto,
            };

            Categoria objCategoria = new Categoria()
            {
                id_categoria = idCategoria,
                nombre_categoria = nombreCategoria
            };

            string businessValidationMessage = string.Empty; // Message from the business layer

            // 4. **Call Business Logic Layer (BLL)**
            // Delegate the actual registration/editing logic to the business layer
            if (objProducto.id_producto == 0) // New product registration
            {
                int idRegistrado = _productoNegocio.Registrar(objProducto, objCategoria, out businessValidationMessage);

                if (idRegistrado != 0)
                {
                    MessageBox.Show("Producto registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VaciarCampos();
                    ActualizarDatosTabla(); // Refresh the grid
                }
                else
                {
                    // Display business validation message or database error
                    MessageBox.Show(businessValidationMessage, "Error al Registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // Existing product modification (should use BModificar_Click for this)
            {
                // This block should ideally not be reached if the form flow is correct,
                // or if BRegisterProduct is only for new records.
                // For demonstration, let's keep the existing edit logic but flag it.
                // It's generally better to have separate handlers for Create and Update.
                // However, since the original code combines them, we'll keep it here for now.
                bool resultado = _productoNegocio.Editar(objProducto, objCategoria, out businessValidationMessage);

                if (resultado)
                {
                    MessageBox.Show("Producto modificado exitosamente.", "ModificaciÃ³n Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Update specific row in DataGridView (more efficient than full refresh)
                    DataGridViewRow row = productosDataGridView.Rows[Convert.ToInt32(TIndice.Text)]; // Assuming TIndice.Text holds the row index
                    row.Cells["id_producto"].Value = objProducto.id_producto;
                    row.Cells["nombre_producto"].Value = objProducto.nombre_producto;
                    row.Cells["descripcion"].Value = objProducto.descripcion;
                    row.Cells["precioLista"].Value = objProducto.precioLista;
                    row.Cells["precioVenta"].Value = objProducto.precioVenta;
                    row.Cells["stock"].Value = objProducto.stock;
                    row.Cells["stock_min"].Value = objProducto.stock_min;
                    row.Cells["id_categoria"].Value = objCategoria.id_categoria;
                    row.Cells["categoria"].Value = objCategoria.nombre_categoria;
                    row.Cells["estadoValor"].Value = objProducto.baja_producto; // Use boolean for stateValue
                    row.Cells["estado"].Value = objProducto.baja_producto ? "Alta" : "Baja"; // Update string representation

                    VaciarCampos();
                    // If you update row directly, you might not need ActualizarDatosTabla()
                    // If you prefer simplicity, always call ActualizarDatosTabla().
                    // ActualizarDatosTabla();
                }
                else
                {
                    MessageBox.Show(businessValidationMessage, "Error al Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Helper method for UI-level validations for registration
        private bool ValidarCamposRegistro(out string mensaje)
        {
            mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(TNombre.Text)) { mensaje = "El nombre del producto es obligatorio."; return false; }
            if (string.IsNullOrWhiteSpace(TDescripcion.Text)) { mensaje = "La descripciÃ³n es obligatoria."; return false; }
            if (!decimal.TryParse(TPrecioLista.Text, out _) || decimal.Parse(TPrecioLista.Text) < 0) { mensaje = "El precio de lista debe ser un nÃºmero vÃ¡lido mayor o igual a cero."; return false; }
            if (!decimal.TryParse(TPrecioVenta.Text, out _) || decimal.Parse(TPrecioVenta.Text) < 0) { mensaje = "El precio de venta debe ser un nÃºmero vÃ¡lido mayor o igual a cero."; return false; }
            if (!int.TryParse(NStock.Text, out _) || int.Parse(NStock.Text) < 0) { mensaje = "El stock debe ser un nÃºmero entero mayor o igual a cero."; return false; }
            if (!int.TryParse(NStockMin.Text, out _) || int.Parse(NStockMin.Text) < 0) { mensaje = "El stock mÃ­nimo debe ser un nÃºmero entero mayor o igual a cero."; return false; }
            if (CBCategoria.SelectedItem == null) { mensaje = "Debe seleccionar una categorÃ­a."; return false; }
            if (CBEstado.SelectedItem == null) { mensaje = "Debe seleccionar un estado."; return false; }

            return true;
        }

        private void BModificar_Click_1(object sender, EventArgs e)
        {
            // 1. **UI Validations (format and presence)**
            if (!ValidarCamposModificacion(out string uiValidationMessage))
            {
                MessageBox.Show(uiValidationMessage, "Error de ValidaciÃ³n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. **Parse/Convert UI Input to appropriate types**
            decimal precioLista = decimal.Parse(TModificarPrecioLista.Text);
            decimal precioVenta = decimal.Parse(TModificarPrecioVenta.Text);
            int stock = int.Parse(NModificarStock.Text);
            int stockMin = int.Parse(NModificarStockMin.Text);
            bool bajaProducto = Convert.ToInt32(((OpcionSelect)CBModificarEstado.SelectedItem).Valor) == 1;
            int idCategoria = Convert.ToInt32(((OpcionSelect)CBModificarCategoria.SelectedItem).Valor);
            string nombreCategoria = ((OpcionSelect)CBModificarCategoria.SelectedItem).Texto;

            // 3. **Create Entity Object(s)**
            Producto objProducto = new Producto()
            {
                id_producto = Convert.ToInt32(TModificarID_prod.Text),
                nombre_producto = TModificarNombre.Text,
                descripcion = TModificarDescripcion.Text,
                precioLista = precioLista,
                precioVenta = precioVenta,
                stock = stock,
                stock_min = stockMin,
                baja_producto = bajaProducto,
            };
            Categoria objCategoria = new Categoria()
            {
                id_categoria = idCategoria,
                nombre_categoria = nombreCategoria
            };

            string businessValidationMessage = string.Empty;

            // 4. **Call Business Logic Layer (BLL)**
            bool resultado = _productoNegocio.Editar(objProducto, objCategoria, out businessValidationMessage);

            // 5. **Handle Result and Update UI**
            if (resultado)
            {
                MessageBox.Show("Producto modificado exitosamente.", "ModificaciÃ³n Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Update the specific row in the DataGridView
                DataGridViewRow row = productosDataGridView.Rows[Convert.ToInt32(TBModificarIndice.Text)];

                row.Cells["id_producto"].Value = objProducto.id_producto; // Ensure ID is updated if it was edited (unlikely for primary key)
                row.Cells["nombre_producto"].Value = objProducto.nombre_producto;
                row.Cells["descripcion"].Value = objProducto.descripcion;
                row.Cells["precioLista"].Value = objProducto.precioLista;
                row.Cells["precioVenta"].Value = objProducto.precioVenta;
                row.Cells["stock"].Value = objProducto.stock;
                row.Cells["stock_min"].Value = objProducto.stock_min;
                row.Cells["id_categoria"].Value = objCategoria.id_categoria;
                row.Cells["categoria"].Value = objCategoria.nombre_categoria; // Display text for category
                row.Cells["estadoValor"].Value = objProducto.baja_producto; // Store the boolean value
                row.Cells["estado"].Value = objProducto.baja_producto ? "Alta" : "Baja"; // Display text for state

                VaciarCampos();
            }
            else
            {
                MessageBox.Show(businessValidationMessage, "Error al Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method for UI-level validations for modification
        private bool ValidarCamposModificacion(out string mensaje)
        {
            mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(TModificarNombre.Text)) { mensaje = "El nombre del producto no puede estar vacÃ­o."; return false; }
            if (string.IsNullOrWhiteSpace(TModificarDescripcion.Text)) { mensaje = "La descripciÃ³n no puede estar vacÃ­a."; return false; }
            if (!decimal.TryParse(TModificarPrecioLista.Text, out _) || decimal.Parse(TModificarPrecioLista.Text) < 0) { mensaje = "El precio de lista debe ser un nÃºmero vÃ¡lido mayor o igual a cero."; return false; }
            if (!decimal.TryParse(TModificarPrecioVenta.Text, out _) || decimal.Parse(TModificarPrecioVenta.Text) < 0) { mensaje = "El precio de venta debe ser un nÃºmero vÃ¡lido mayor o igual a cero."; return false; }
            if (!int.TryParse(NModificarStock.Text, out _) || int.Parse(NModificarStock.Text) < 0) { mensaje = "El stock debe ser un nÃºmero entero mayor o igual a cero."; return false; }
            if (!int.TryParse(NModificarStockMin.Text, out _) || int.Parse(NModificarStockMin.Text) < 0) { mensaje = "El stock mÃ­nimo debe ser un nÃºmero entero mayor o igual a cero."; return false; }
            if (CBModificarCategoria.SelectedItem == null) { mensaje = "Debe seleccionar una categorÃ­a."; return false; }
            if (CBModificarEstado.SelectedItem == null) { mensaje = "Debe seleccionar el estado."; return false; }

            return true;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();

            // All search logic directly interacts with the TableAdapter, which implies
            // it's deeply coupled with your Data Layer. This is acceptable for simple UI-driven searches
            // but for complex business-driven searches, the BLL would expose methods
            // that then use a DAL.
            if (string.IsNullOrEmpty(filtro))
            {
                ActualizarDatosTabla(); // Show all when filter is empty
                return;
            }

            // Attempt to search by id_producto if numeric
            if (int.TryParse(filtro, out int idVal))
            {
                this.pROC_BUSCAR_PRODUCTOTableAdapter.Fill(
                    this.dataSet1.PROC_BUSCAR_PRODUCTO,
                    idVal, null, null, null, null, null, null, null, null, null, null
                );
                return;
            }

            // If not numeric, try by text fields
            this.pROC_BUSCAR_PRODUCTOTableAdapter.Fill(
                this.dataSet1.PROC_BUSCAR_PRODUCTO,
                null, filtro, null, null, null, null, null, null, null, null, null // nombre producto
            );
            if (this.dataSet1.PROC_BUSCAR_PRODUCTO.Rows.Count == 0)
            {
                this.pROC_BUSCAR_PRODUCTOTableAdapter.Fill(this.dataSet1.PROC_BUSCAR_PRODUCTO, null, null, null, null, null, null, null, null, filtro, null, null); // descripcion
            }
            if (this.dataSet1.PROC_BUSCAR_PRODUCTO.Rows.Count == 0)
            {
                this.pROC_BUSCAR_PRODUCTOTableAdapter.Fill(this.dataSet1.PROC_BUSCAR_PRODUCTO, null, null, null, null, null, null, null, null, null, null, filtro); // nombre categoria
            }
        }

        private void TDescripcion_TextChanged(object sender, EventArgs e)
        {
            // Event handler with no logic - can be removed if not used.
        }
    }
}