using CapaEntidades;
using CapaEntidades.Utilidades;
using CapaNegocio;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OcioStoreIngSoftII
{
    public partial class Products : Form
    {
        // Instancias de la capa de negocio
        private readonly Producto_negocio _productoNegocio;
        private readonly Categoria_negocio _categoriaNegocio;
        private readonly Proveedores_negocio _proveedorNegocio;
        private Producto productoSeleccionado;
        private List<Categoria> categoriasNuevoProducto;

        public Products()
        {
            InitializeComponent();
            _productoNegocio = new Producto_negocio();
            _categoriaNegocio = new Categoria_negocio();
            _proveedorNegocio = new Proveedores_negocio();
            categoriasNuevoProducto = new List<Categoria>();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            // Carga inicial de ComboBoxes (UI específica)
            CargarComboBoxEstados(CBEstado);
            CargarComboBoxEstados(CBModificarEstado);
            CargarComboBoxProveedor(CBProveedor);
            CargarComboBoxProveedor(CBModificarProveedor); 
            CargarComboBoxFiltroCat(CBFiltroCategoria);
            // Establecer índices por defecto si hay elementos
            if (CBEstado.Items.Count > 0) CBEstado.SelectedIndex = 0;

            actualizarDatosTabla();
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

        private void CargarComboBoxProveedor(ComboBox comboBox)
        {
            try
            {
                // La capa de presentación pide las categorías a la capa de negocio
                List<Proveedor> listaProveedores = _proveedorNegocio.ListarProveedores();
                foreach (Proveedor item in listaProveedores)
                {
                    comboBox.Items.Add(new OpcionSelect() { Valor = item.id_proveedor, Texto = item.nombre_proveedor });
                }
                comboBox.DisplayMember = "Texto";
                comboBox.ValueMember = "Valor";
            }
            catch (Exception ex)
            {
                // Si hay un error, lo mostraremos en un mensaje
                MessageBox.Show("Ocurrió un error al cargar los proveedores: \n" + ex.Message, "Error de Carga de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboBoxFiltroCat(ComboBox cbFiltroCategoria)
        {
            // Creamos una lista de opciones para el ComboBox
            var opciones = new List<OpcionSelect>();

            // ---  OPCIÓN "TODAS" ---
            opciones.Add(new OpcionSelect() { Valor = 0, Texto = "Todas las Categorías" });

            // Obtenemos el resto de las categorías de la capa de negocio
            List<Categoria> listaCategorias = _categoriaNegocio.ListarActivas();
            foreach (var categoria in listaCategorias)
            {
                opciones.Add(new OpcionSelect() { Valor = categoria.id_categoria, Texto = categoria.nombre_categoria });
            }

            // Asignamos la lista completa al ComboBox
            cbFiltroCategoria.DataSource = opciones;
            cbFiltroCategoria.DisplayMember = "Texto";
            cbFiltroCategoria.ValueMember = "Valor";
        }

        private void actualizarDatosTabla(string filtros = null, int idCategoria = 0)
        {
            if (filtros == null)
            {
                filtros = "";
            }

            List<Producto> resultados = _productoNegocio.BuscarProductosGeneral(filtros, idCategoria);
            productosDataGridView.AutoGenerateColumns = false;
            productosDataGridView.DataSource = null;
            productosDataGridView.DataSource = resultados;
        }


        // Lógica de dibujo de celdas - Pertenece a la capa de Presentación
        private void productosDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)

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
                e.Graphics.DrawImage(Properties.Resources.checkbox, new System.Drawing.Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        //DGV - Texto para la columna estado y proveedor
        private void productosDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in productosDataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                var valor = row.Cells["estadoValor"].Value;
                if (valor != null && valor != DBNull.Value)
                {
                    bool estado = Convert.ToBoolean(valor);
                    row.Cells["estado"].Value = estado ? "Dado de Baja" : "Alta";
                }
                else
                {
                    row.Cells["estado"].Value = "Desconocido";
                }
            }
            productosDataGridView.ClearSelection();
            productosDataGridView.CurrentCell = null;
        }


        // Vacía y reinicia los campos de entrada
        private void VaciarCampos()
        {
            // Campos de Registro
            TID_prod.Text = "0"; // ID 0 para un nuevo registro
            TNombreProducto.Content = string.Empty;
            TDescripcion.Content = string.Empty;
            TPrecioLista.Content = string.Empty;
            TPrecioVenta.Content = string.Empty;
            NStock.Text = string.Empty;
            NStockMin.Text = string.Empty;
            TCodigo.Content = "0"; //
            if (CBEstado.Items.Count > 0) CBEstado.SelectedIndex = 0;
            if (CBProveedor.Items.Count > 0) CBProveedor.SelectedIndex = 0;
            // Limpia la lista temporal y el TextBox de categorías
            this.categoriasNuevoProducto.Clear();
            TCategorias.Text = string.Empty;

            // Campos de Modificación
            TModificarID_prod.Text = "0"; // ID 0 para indicar que no hay producto cargado
            TModificarNombreProducto.Text = string.Empty;
            TModificarDescripcion.Text = string.Empty;
            TModificarPrecioLista.Text = string.Empty;
            TModificarPrecioVenta.Text = string.Empty;
            NModificarStock.Text = string.Empty;
            NModificarStockMin.Text = string.Empty;
            TModificarCodigo.Content = "0";
            // No se reinician los SelectedIndex de modificar, ya que se llenan al seleccionar una fila.
        }


        // Cargar datos en el formulario de modificación al seleccionar una fila
        private void productosDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (productosDataGridView.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    productoSeleccionado = (Producto)productosDataGridView.Rows[indice].DataBoundItem;

                    TCProductos.SelectedIndex = 1; // Cambia a la pestaña de modificación

                    TBModificarIndice.Text = indice.ToString(); // Guardar índice de la fila para futura actualización

                    // Cargar datos de la fila seleccionada a los controles de modificación
                    TModificarID_prod.Text = productoSeleccionado.id_producto.ToString();
                    TModificarNombreProducto.Content = productoSeleccionado.nombre_producto.ToString();
                    TModificarDescripcion.Content = productoSeleccionado.descripcion.ToString();
                    TModificarPrecioLista.Content = productoSeleccionado.precioLista.ToString();
                    TModificarPrecioVenta.Content = productoSeleccionado.precioVenta.ToString();
                    TModificarCodigo.Content = productoSeleccionado.cod_producto.ToString();
                    NModificarStock.Text = productoSeleccionado.stock.ToString();
                    NModificarStockMin.Text = productoSeleccionado.stock_min.ToString();
                    TModificarCategorias.Text = productoSeleccionado.CategoriasConcatenadas;

                    for (int i = 0; i < CBModificarProveedor.Items.Count; i++)
                    {
                        // Obtenemos el objeto OpcionSelect de la posición 'i'
                        // Necesitamos castear 'Items[i]' de vuelta a OpcionSelect para acceder a su propiedad 'Valor'
                        OpcionSelect opcion = (OpcionSelect)CBModificarProveedor.Items[i];

                        // Comparamos su propiedad 'Valor' con el ID que buscamos
                        if (Convert.ToInt32(opcion.Valor) == productoSeleccionado.id_proveedor)
                        {
                            // Si coinciden, establecemos el ComboBox en ese índice y salimos del bucle
                            CBModificarProveedor.SelectedIndex = i;
                            break;
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

                    TLayoutProducts.ScrollControlIntoView(TCProductos);

                }
            }
        }


        /// Evento Click para el botón de Registro de Producto.
        private void BRegisterProduct_Click_1(object sender, EventArgs e)
        {
            string uiValidationMessage;

            // Estas validaciones evitan enviar datos mal formados a la capa de negocio.
            if (!ValidarCamposRegistro(out uiValidationMessage))
            {
                MessageBox.Show(uiValidationMessage, "Error de Validación de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //  Parseo de datos de la UI a tipos de datos adecuados
            decimal precioLista = decimal.Parse(TPrecioLista.Content);
            decimal precioVenta = decimal.Parse(TPrecioVenta.Content);
            int stock = int.Parse(NStock.Text);
            int stockMin = int.Parse(NStockMin.Text);
            bool bajaProducto = Convert.ToInt32(((OpcionSelect)CBEstado.SelectedItem).Valor) == 1;
            int codigoProducto = Convert.ToInt32(TCodigo);

            //  Creación de objetos de entidad (Producto y Categoria)
            Producto objProducto = new Producto()
            {
                id_producto = Convert.ToInt32(TID_prod.Text), // Asume 0 para nuevos registros
                nombre_producto = TNombreProducto.Content,
                descripcion = TDescripcion.Content,
                fechaIngreso = DateTime.Now, // Podría ser generado en BLL/DAL
                precioLista = precioLista,
                precioVenta = precioVenta,
                stock = stock,
                stock_min = stockMin,
                baja_producto = bajaProducto,
                cod_producto = codigoProducto, 
                categorias = this.categoriasNuevoProducto
            };
            string businessValidationMessage = string.Empty; // Mensaje devuelto por la capa de negocio

            // Aquí se valida la lógica de negocio (por ejemplo, precioVenta > precioLista)
            int idRegistrado = _productoNegocio.Registrar(objProducto, out businessValidationMessage);


            if (idRegistrado != 0) // Éxito en el registro
            {
                MessageBox.Show("Producto registrado exitosamente con ID: " + idRegistrado, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VaciarCampos();
                actualizarDatosTabla(); // Refresca el DataGridView para mostrar el nuevo producto
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

            if (string.IsNullOrWhiteSpace(TNombreProducto.Content)) { mensaje = "El nombre del producto es obligatorio."; return false; }
            if (string.IsNullOrWhiteSpace(TDescripcion.Content)) { mensaje = "La descripción es obligatoria."; return false; }

            if (!decimal.TryParse(TPrecioLista.Content, out decimal precioLista)) { mensaje = "El precio de lista debe ser un número válido."; return false; }
            if (!decimal.TryParse(TPrecioVenta.Content, out decimal precioVenta)) { mensaje = "El precio de venta debe ser un número válido."; return false; }
            if (!int.TryParse(NStock.Text, out int stock)) { mensaje = "El stock debe ser un número entero válido."; return false; }
            if (!int.TryParse(NStockMin.Text, out int stockMin)) { mensaje = "El stock mínimo debe ser un número entero válido."; return false; }
            if (CBEstado.SelectedItem == null) { mensaje = "Debe seleccionar un estado."; return false; }
            if (CBProveedor.SelectedItem == null) { mensaje = "Debe seleccionar un proveedor."; return false; }

            return true;
        }


        /// Evento Click para el botón de Modificar Producto.
        private void BModificar_Click_1(object sender, EventArgs e)
        {
            string uiValidationMessage;
            //  Validaciones a nivel de UI (formato y obligatoriedad)
            if (!ValidarCamposModificacion(out uiValidationMessage))
            {
                MessageBox.Show(uiValidationMessage, "Error de Validación de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //  Parseo de datos de la UI a tipos de datos adecuados
            decimal precioLista = decimal.Parse(TModificarPrecioLista.Content);
            decimal precioVenta = decimal.Parse(TModificarPrecioVenta.Content);
            int stock = int.Parse(NModificarStock.Text);
            int stockMin = int.Parse(NModificarStockMin.Text);
            bool bajaProducto = Convert.ToInt32(((OpcionSelect)CBModificarEstado.SelectedItem).Valor) == 1;
            int idProveedor = Convert.ToInt32(((OpcionSelect)CBModificarProveedor.SelectedItem).Valor);

            //  Creación de objetos de entidad (Producto y Categoria)
            Producto objProducto = new Producto()
            {
                id_producto = Convert.ToInt32(TModificarID_prod.Text),
                nombre_producto = TModificarNombreProducto.Content,
                cod_producto = Convert.ToInt32(TModificarCodigo.Content),
                descripcion = TModificarDescripcion.Content,
                precioLista = precioLista,
                precioVenta = precioVenta,
                stock = stock,
                stock_min = stockMin,
                baja_producto = bajaProducto,
                categorias = productoSeleccionado.categorias,
                id_proveedor = idProveedor
            };

            string businessValidationMessage = string.Empty;

            //  Llamada a la Capa de Negocio para la edición
            bool resultado = _productoNegocio.Editar(objProducto, out businessValidationMessage);

            //  Manejo del resultado de la operación
            if (resultado)
            {
                MessageBox.Show("Producto modificado exitosamente.", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Actualizar la fila específica en el DataGridView
                actualizarDatosTabla();
                VaciarCampos();
            }
            else
            {
                MessageBox.Show(businessValidationMessage, "Error al Modificar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Realiza validaciones de formato y obligatoriedad a nivel de UI para la modificación de productos.
        private bool ValidarCamposModificacion(out string mensaje)
        {
            mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(TModificarNombreProducto.Content)) { mensaje = "El nombre del producto no puede estar vacío."; return false; }
            if (string.IsNullOrWhiteSpace(TModificarDescripcion.Content)) { mensaje = "La descripción no puede estar vacía."; return false; }
            if (!decimal.TryParse(TModificarPrecioLista.Content, out decimal precioLista)) { mensaje = "El precio de lista debe ser un número válido."; return false; }
            if (!decimal.TryParse(TModificarPrecioVenta.Content, out decimal precioVenta)) { mensaje = "El precio de venta debe ser un número válido."; return false; }
            if (!int.TryParse(NModificarStock.Text, out int stock)) { mensaje = "El stock debe ser un número entero válido."; return false; }
            if (!int.TryParse(NModificarStockMin.Text, out int stockMin)) { mensaje = "El stock mínimo debe ser un número entero válido."; return false; }
            if (CBModificarEstado.SelectedItem == null) { mensaje = "Debe seleccionar el estado."; return false; }
            if (CBModificarProveedor.SelectedItem == null) { mensaje = "Debe seleccionar un proveedor."; return false; }

            return true;
        }


        //-----------------------------------------------------------------------------
        //BOTONES DE CATEGORIAS
        //-----------------------------------------------------------------------------
        private void btnModificarCategorias_Click(object sender, EventArgs e)
        {
            if (productoSeleccionado == null)
            {
                MessageBox.Show("Primero debe seleccionar un producto de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Categoria_negocio objNegocioCategoria = new Categoria_negocio();
            List<Categoria> todasLasCategorias = objNegocioCategoria.ListarActivas();
            
            //  Crea y muestra la ventana emergente, pasándole los datos necesarios
            using (GestionarCategorias popup = new GestionarCategorias(todasLasCategorias, productoSeleccionado.categorias))
            {
                // Abre el formulario como un diálogo modal (bloquea la ventana padre)
                var resultado = popup.ShowDialog();

                //  Si el usuario hizo clic en "Guardar"
                if (resultado == DialogResult.OK)
                {
                    // Actualiza la lista de categorías del producto con la nueva selección
                    productoSeleccionado.categorias = popup.CategoriasSeleccionadas;
                    TModificarCategorias.Text = productoSeleccionado.CategoriasConcatenadas;
                }
            }            
        }

        private void btnElegirCategorias_Click(object sender, EventArgs e)
        {
            List<Categoria> todasLasCategorias = _categoriaNegocio.ListarActivas();

            using (GestionarCategorias popup = new GestionarCategorias(todasLasCategorias, categoriasNuevoProducto))
            {
                var resultado = popup.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    categoriasNuevoProducto = popup.CategoriasSeleccionadas;

                    TCategorias.Text = string.Join(", ", categoriasNuevoProducto.Select(c => c.nombre_categoria));
                }
            }
        }
        //-----------------------------------------------------------------------------
        //
        //-----------------------------------------------------------------------------


        //Buscar
        private void BBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();
            int idCategoria = Convert.ToInt32(((OpcionSelect)CBFiltroCategoria.SelectedItem).Valor);

            List<Producto> resultados = _productoNegocio.BuscarProductosGeneral(filtro, idCategoria);
            productosDataGridView.DataSource = null;
            productosDataGridView.DataSource = resultados;
        }

        //Que el enter sirva para buscar
        private void Users_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BBuscar_Click(BBuscar, EventArgs.Empty);

                // Evita el sonido "ding" de Windows al presionar Enter en algunos contextos
                e.SuppressKeyPress = true;
            }
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            CBFiltroCategoria.SelectedIndex = 0;
            actualizarDatosTabla();
        }
    }
}