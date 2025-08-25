using CapaEntidades;
using CapaNegocio;
using OcioStoreIngSoftII.Utillidades; // Asumiendo que OpcionSelect está aquí
using System;
using System.Collections.Generic;
using System.Data; // Necesario para DataTable/DataSet si se sigue usando TableAdapter
using System.Drawing;
using System.Windows.Forms;

namespace OcioStoreIngSoftII
{
    public partial class Products : Form
    {
        // Instancias de la capa de negocio
        private readonly Producto_negocio _productoNegocio;
        private readonly Categoria_negocio _categoriaNegocio;

        public Products()
        {
            InitializeComponent();
            _productoNegocio = new Producto_negocio();
            _categoriaNegocio = new Categoria_negocio();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            // Carga inicial de ComboBoxes (UI específica)
            CargarComboBoxEstados(CBEstado);
            CargarComboBoxEstados(CBModificarEstado); // Podría no tener selección inicial si se carga un producto
            CargarComboBoxCategorias(CBCategoria);
            CargarComboBoxCategorias(CBModificarCategoria); // Podría no tener selección inicial si se carga un producto

            // Establecer índices por defecto si hay elementos
            if (CBEstado.Items.Count > 0) CBEstado.SelectedIndex = 0;
            // CBModificarEstado.SelectedIndex no se establece inicialmente si la idea es que muestre el estado del producto cargado
            if (CBCategoria.Items.Count > 0) CBCategoria.SelectedIndex = 0;
            // CBModificarCategoria.SelectedIndex no se establece inicialmente

            ActualizarDatosTabla();
        }

        //Carga las opciones de estado (alta/baja)
        private void CargarComboBoxEstados(ComboBox comboBox)
        {
            try
            {
                comboBox.Items.Add(new OpcionSelect() { Valor = 1, Texto = "Baja" });
                comboBox.Items.Add(new OpcionSelect() { Valor = 0, Texto = "Alta" });
                comboBox.DisplayMember = "Texto";
                comboBox.ValueMember = "Valor";
            }
            catch (Exception ex)
            {
                // Si hay un error, lo mostraremos en un mensaje
                MessageBox.Show("Ocurrió un error al cargar las categorías: \n" + ex.Message, "Error de Carga de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// Carga las categorías desde la capa de negocio en un ComboBox.

        private void CargarComboBoxCategorias(ComboBox comboBox)
        {
            try
            {
                // La capa de presentación pide las categorías a la capa de negocio
                List<Categoria> listaCategorias = _categoriaNegocio.Listar();
                foreach (Categoria item in listaCategorias)
                {
                    comboBox.Items.Add(new OpcionSelect() { Valor = item.id_categoria, Texto = item.nombre_categoria });
                }
                comboBox.DisplayMember = "Texto";
                comboBox.ValueMember = "Valor";
            }
            catch (Exception ex)
            {
                // Si hay un error, lo mostraremos en un mensaje
                MessageBox.Show("Ocurrió un error al cargar las categorías: \n" + ex.Message, "Error de Carga de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// Idealmente, esta carga de datos debería pasar por la capa de negocio xd
        private void ActualizarDatosTabla()
        {
            this.pROC_BUSCAR_PRODUCTOTableAdapter.Fill(
                this.dataSet1.PROC_BUSCAR_PRODUCTO,
                null, null, null, null, null, null, null, null, null, null, null
            );
        }

        // Lógica de dibujo de celdas - Pertenece a la capa de Presentación
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

        /// Vacía y reinicia los campos de entrada de la UI.
        private void VaciarCampos()
        {
            // Campos de Registro
            TID_prod.Text = "0"; // ID 0 para un nuevo registro
            TNombre.Text = string.Empty;
            TDescripcion.Text = string.Empty;
            TPrecioLista.Text = string.Empty;
            TPrecioVenta.Text = string.Empty;
            NStock.Text = string.Empty;
            NStockMin.Text = string.Empty;
            if (CBCategoria.Items.Count > 0) CBCategoria.SelectedIndex = 0;
            if (CBEstado.Items.Count > 0) CBEstado.SelectedIndex = 0;

            // Campos de Modificación
            TModificarID_prod.Text = "0"; // ID 0 para indicar que no hay producto cargado
            TModificarNombre.Text = string.Empty;
            TModificarDescripcion.Text = string.Empty;
            TModificarPrecioLista.Text = string.Empty;
            TModificarPrecioVenta.Text = string.Empty;
            NModificarStock.Text = string.Empty;
            NModificarStockMin.Text = string.Empty;
            // No se reinician los SelectedIndex de modificar, ya que se llenan al seleccionar una fila.
        }

        // Lógica de UI: Cargar datos en el formulario de modificación al seleccionar una fila
        private void productosDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (productosDataGridView.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    TCProductos.SelectedIndex = 1; // Cambia a la pestaña de modificación

                    TBModificarIndice.Text = indice.ToString(); // Guardar índice de la fila para futura actualización

                    // Cargar datos de la fila seleccionada a los controles de modificación
                    TModificarID_prod.Text = productosDataGridView.Rows[indice].Cells["id_producto"].Value.ToString();
                    TModificarNombre.Text = productosDataGridView.Rows[indice].Cells["nombre_producto"].Value.ToString();
                    TModificarDescripcion.Text = productosDataGridView.Rows[indice].Cells["descripcion"].Value.ToString();
                    TModificarPrecioLista.Text = productosDataGridView.Rows[indice].Cells["precioLista"].Value.ToString();
                    TModificarPrecioVenta.Text = productosDataGridView.Rows[indice].Cells["precioVenta"].Value.ToString();
                    NModificarStock.Text = productosDataGridView.Rows[indice].Cells["stock"].Value.ToString();
                    NModificarStockMin.Text = productosDataGridView.Rows[indice].Cells["stock_min"].Value.ToString();

                    // Seleccionar la categoría correcta en el ComboBox de modificación
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

                    // Seleccionar el estado correcto en el ComboBox de modificación
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

        /// Evento Click para el botón de Registro de Producto.
        /// La capa de presentación se encarga de la captura, validación de formato y delegación.
        private void BRegisterProduct_Click_1(object sender, EventArgs e)
        {
            string uiValidationMessage;
            // 1. Validaciones a nivel de UI (formato y obligatoriedad)
            // Estas validaciones evitan enviar datos mal formados a la capa de negocio.
            if (!ValidarCamposRegistro(out uiValidationMessage))
            {
                MessageBox.Show(uiValidationMessage, "Error de Validación de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Parseo de datos de la UI a tipos de datos adecuados
            decimal precioLista = decimal.Parse(TPrecioLista.Text);
            decimal precioVenta = decimal.Parse(TPrecioVenta.Text);
            int stock = int.Parse(NStock.Text);
            int stockMin = int.Parse(NStockMin.Text);
            bool bajaProducto = Convert.ToInt32(((OpcionSelect)CBEstado.SelectedItem).Valor) == 1;
            int idCategoria = Convert.ToInt32(((OpcionSelect)CBCategoria.SelectedItem).Valor);
            string nombreCategoria = ((OpcionSelect)CBCategoria.SelectedItem).Texto;

            // 3. Creación de objetos de entidad (Producto y Categoria)
            Producto objProducto = new Producto()
            {
                id_producto = Convert.ToInt32(TID_prod.Text), // Asume 0 para nuevos registros
                nombre_producto = TNombre.Text,
                descripcion = TDescripcion.Text,
                fechaIngreso = DateTime.Now, // Podría ser generado en BLL/DAL
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

            string businessValidationMessage = string.Empty; // Mensaje devuelto por la capa de negocio

            // 4. Llamada a la Capa de Negocio para el registro
            // Aquí se valida la lógica de negocio (por ejemplo, precioVenta > precioLista)
            int idRegistrado = _productoNegocio.Registrar(objProducto, objCategoria, out businessValidationMessage);

            // 5. Manejo del resultado de la operación
            if (idRegistrado != 0) // Éxito en el registro
            {
                MessageBox.Show("Producto registrado exitosamente con ID: " + idRegistrado, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VaciarCampos();
                ActualizarDatosTabla(); // Refresca el DataGridView para mostrar el nuevo producto
            }
            else // Fallo en el registro (puede ser por validación de negocio o error de base de datos)
            {
                MessageBox.Show(businessValidationMessage, "Error al Registrar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// Realiza validaciones de formato y obligatoriedad a nivel de UI para el registro de productos.
        private bool ValidarCamposRegistro(out string mensaje)
        {
            mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(TNombre.Text)) { mensaje = "El nombre del producto es obligatorio."; return false; }
            if (string.IsNullOrWhiteSpace(TDescripcion.Text)) { mensaje = "La descripción es obligatoria."; return false; }

            if (!decimal.TryParse(TPrecioLista.Text, out decimal precioLista)) { mensaje = "El precio de lista debe ser un número válido."; return false; }
            if (!decimal.TryParse(TPrecioVenta.Text, out decimal precioVenta)) { mensaje = "El precio de venta debe ser un número válido."; return false; }
            if (!int.TryParse(NStock.Text, out int stock)) { mensaje = "El stock debe ser un número entero válido."; return false; }
            if (!int.TryParse(NStockMin.Text, out int stockMin)) { mensaje = "El stock mínimo debe ser un número entero válido."; return false; }

            if (CBCategoria.SelectedItem == null) { mensaje = "Debe seleccionar una categoría."; return false; }
            if (CBEstado.SelectedItem == null) { mensaje = "Debe seleccionar un estado."; return false; }

            return true;
        }

        /// Evento Click para el botón de Modificar Producto.
        /// La capa de presentación se encarga de la captura, validación de formato y delegación.
        private void BModificar_Click_1(object sender, EventArgs e)
        {
            string uiValidationMessage;
            // 1. Validaciones a nivel de UI (formato y obligatoriedad)
            if (!ValidarCamposModificacion(out uiValidationMessage))
            {
                MessageBox.Show(uiValidationMessage, "Error de Validación de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Parseo de datos de la UI a tipos de datos adecuados
            decimal precioLista = decimal.Parse(TModificarPrecioLista.Text);
            decimal precioVenta = decimal.Parse(TModificarPrecioVenta.Text);
            int stock = int.Parse(NModificarStock.Text);
            int stockMin = int.Parse(NModificarStockMin.Text);
            bool bajaProducto = Convert.ToInt32(((OpcionSelect)CBModificarEstado.SelectedItem).Valor) == 1;
            int idCategoria = Convert.ToInt32(((OpcionSelect)CBModificarCategoria.SelectedItem).Valor);
            string nombreCategoria = ((OpcionSelect)CBModificarCategoria.SelectedItem).Texto;

            // 3. Creación de objetos de entidad (Producto y Categoria)
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

            // 4. Llamada a la Capa de Negocio para la edición
            bool resultado = _productoNegocio.Editar(objProducto, objCategoria, out businessValidationMessage);

            // 5. Manejo del resultado de la operación
            if (resultado)
            {
                MessageBox.Show("Producto modificado exitosamente.", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Actualizar la fila específica en el DataGridView
                DataGridViewRow row = productosDataGridView.Rows[Convert.ToInt32(TBModificarIndice.Text)];

                row.Cells["nombre_producto"].Value = objProducto.nombre_producto;
                row.Cells["descripcion"].Value = objProducto.descripcion;
                row.Cells["precioLista"].Value = objProducto.precioLista;
                row.Cells["precioVenta"].Value = objProducto.precioVenta;
                row.Cells["stock"].Value = objProducto.stock;
                row.Cells["stock_min"].Value = objProducto.stock_min;
                row.Cells["id_categoria"].Value = objCategoria.id_categoria;
                row.Cells["categoria"].Value = objCategoria.nombre_categoria;
                row.Cells["estadoValor"].Value = objProducto.baja_producto;
                row.Cells["estado"].Value = objProducto.baja_producto ? "Baja" : "Alta";

                VaciarCampos();
            }
            else
            {
                MessageBox.Show(businessValidationMessage, "Error al Modificar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// Realiza validaciones de formato y obligatoriedad a nivel de UI para la modificación de productos.
        private bool ValidarCamposModificacion(out string mensaje)
        {
            mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(TModificarNombre.Text)) { mensaje = "El nombre del producto no puede estar vacío."; return false; }
            if (string.IsNullOrWhiteSpace(TModificarDescripcion.Text)) { mensaje = "La descripción no puede estar vacía."; return false; }

            if (!decimal.TryParse(TModificarPrecioLista.Text, out decimal precioLista)) { mensaje = "El precio de lista debe ser un número válido."; return false; }
            if (!decimal.TryParse(TModificarPrecioVenta.Text, out decimal precioVenta)) { mensaje = "El precio de venta debe ser un número válido."; return false; }
            if (!int.TryParse(NModificarStock.Text, out int stock)) { mensaje = "El stock debe ser un número entero válido."; return false; }
            if (!int.TryParse(NModificarStockMin.Text, out int stockMin)) { mensaje = "El stock mínimo debe ser un número entero válido."; return false; }

            if (CBModificarCategoria.SelectedItem == null) { mensaje = "Debe seleccionar una categoría."; return false; }
            if (CBModificarEstado.SelectedItem == null) { mensaje = "Debe seleccionar el estado."; return false; }

            return true;
        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(filtro))
            {
                ActualizarDatosTabla(); // Si el filtro está vacío, muestra todos los productos
                return;
            }

            // Intenta buscar por id_producto si el texto es un número
            if (int.TryParse(filtro, out int idVal))
            {
                this.pROC_BUSCAR_PRODUCTOTableAdapter.Fill(
                    this.dataSet1.PROC_BUSCAR_PRODUCTO,
                    idVal, null, null, null, null, null, null, null, null, null, null
                );
                return;
            }

            // Si no es numérico, intenta buscar por nombre de producto
            this.pROC_BUSCAR_PRODUCTOTableAdapter.Fill(
                this.dataSet1.PROC_BUSCAR_PRODUCTO,
                null, filtro, null, null, null, null, null, null, null, null, null // nombre_producto
            );
            // Si no se encuentran resultados por nombre, intenta por descripción
            if (this.dataSet1.PROC_BUSCAR_PRODUCTO.Rows.Count == 0)
            {
                this.pROC_BUSCAR_PRODUCTOTableAdapter.Fill(this.dataSet1.PROC_BUSCAR_PRODUCTO, null, null, null, null, null, null, null, null, filtro, null, null); // descripcion
            }
            // Si sigue sin resultados, intenta por nombre de categoría
            if (this.dataSet1.PROC_BUSCAR_PRODUCTO.Rows.Count == 0)
            {
                this.pROC_BUSCAR_PRODUCTOTableAdapter.Fill(this.dataSet1.PROC_BUSCAR_PRODUCTO, null, null, null, null, null, null, null, null, null, null, filtro); // nombre_categoria
            }
        }

        private void productosDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in productosDataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                var valor = row.Cells["estadoValor"].Value;
                if (valor != null && valor != DBNull.Value)
                {
                    bool estado = Convert.ToBoolean(valor);
                    row.Cells["estado"].Value = estado ? "Baja" : "Alta";
                }
                else
                {
                    row.Cells["estado"].Value = "Desconocido";
                }
            }
            productosDataGridView.ClearSelection();
            productosDataGridView.CurrentCell = null;
        }
    }
}