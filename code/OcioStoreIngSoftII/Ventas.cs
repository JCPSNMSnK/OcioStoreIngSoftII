using CapaEntidades;
using CapaNegocio;
using CapaEntidades.Utilidades;
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
        private static Usuario usuarioActual;
        private readonly Producto_negocio _productoNegocio;
        private readonly Categoria_negocio _categoriaNegocio;
        private List<Producto> _listaProductos;

        private CapaEntidades.Ventas _ventaActual;
        private Ventas_negocio _ventasNegocio = new Ventas_negocio();
        private Cliente clienteParaVenta;
        private Factura_Negocio facturaNegocio = new Factura_Negocio();
        private Producto productoParaAgregar;
        private List<CarritoItem> carrito = new List<CarritoItem>();
        private BindingSource carritoBindingSource = new BindingSource();

        public Ventas(Usuario objUser)
        {
            InitializeComponent();
            usuarioActual = objUser;
            _productoNegocio = new Producto_negocio();
            _categoriaNegocio = new Categoria_negocio();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            string mensaje;
            _ventaActual = _ventasNegocio.IniciarVenta(usuarioActual, out mensaje);

            if (_ventaActual == null)
            {
                MessageBox.Show("Error al iniciar la venta: " + mensaje);
                this.Close(); // o bloquear el resto del formulario
            }

            _listaProductos = _productoNegocio.Listar();
            CargarTiposFactura();
            CargarComboBoxFiltroCat(CBFiltroCategoria);

            //Enlaza el DGV con el carrito
            VentaDataGridView.DataSource = carritoBindingSource;
            VentaDataGridView.AutoGenerateColumns = false;

            ActualizarDatosTabla();
        }

        private void CargarTiposFactura()
        {
            try
            {
                // 1. Pide la lista de tipos de factura a la capa de negocio
                List<FacturaTipo> listaTipos = facturaNegocio.ListarTiposFactura();

                // 2. Transforma la lista a OpcionSelect
                var dataSource = listaTipos.Select(tipo => new OpcionSelect
                {
                    Valor = tipo.id_tipo_factura,
                    Texto = tipo.nombre_tipo_factura
                }).ToList();

                // 3. Asigna la lista al DataSource del ComboBox
                cbTipoFactura.DataSource = dataSource;
                cbTipoFactura.DisplayMember = "Texto";
                cbTipoFactura.ValueMember = "Valor";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los tipos de factura: \n" + ex.Message);
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


        //--------------------------------------------
        // BOTONES CLIENTE
        //--------------------------------------------
        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            // Abrimos el formulario de búsqueda como un diálogo
            using (BuscarCliente popup = new BuscarCliente())
            {
                var resultado = popup.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    // Si el usuario seleccionó un cliente, lo guardamos
                    this.clienteParaVenta = popup.ClienteSeleccionado;

                    // Y mostramos su DNI en el TextBox
                    txtClienteSeleccionado.Text = $"{clienteParaVenta.nombre_cliente} {clienteParaVenta.apellido_cliente} (DNI: {clienteParaVenta.dni_cliente})";
                }
            }
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            // Abrimos el formulario de registro de clientes
            using (RegistrarClienteVenta popup = new RegistrarClienteVenta())
            {
                var resultado = popup.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    this.clienteParaVenta = popup.ClienteRegistrado;
                    txtClienteSeleccionado.Text = $"{clienteParaVenta.nombre_cliente} {clienteParaVenta.apellido_cliente} (DNI: {clienteParaVenta.dni_cliente})";
                }
            }
        }
        //-----------------------------------------------------------------------
        //
        //-------------------------------------------------------------------


        private void ActualizarDatosTabla(string filtros = null, int idCategoria = 0)
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

                    productoParaAgregar = (Producto)productosDataGridView.Rows[e.RowIndex].DataBoundItem;
                    if (productoParaAgregar != null)
                    {

                        // Llenamos los campos de texto
                        txtProducto.Text = productoParaAgregar.nombre_producto;
                        txtPrecio.Text = productoParaAgregar.precioVenta.ToString("0.00");

                        // Reiniciamos la cantidad
                        NCantidad.Value = 1;

                    }
                }
            }
        }

        private void btnAgregarAlCarrito_Click(object sender, EventArgs e)
        {
            if (productoParaAgregar == null)
            {
                MessageBox.Show("Debe seleccionar un producto de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cantidad = (int)NCantidad.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cantidad > productoParaAgregar.stock)
            {
                MessageBox.Show($"No hay stock suficiente. Stock disponible: {productoParaAgregar.stock}", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Comprobar si el producto ya está en el carrito para actualizar la cantidad
            CarritoItem itemExistente = carrito.FirstOrDefault(p => p.IdProducto == productoParaAgregar.id_producto);

            if (itemExistente != null)
            {
                // Si ya existe, solo actualizamos la cantidad (validando el stock de nuevo)
                if (itemExistente.Cantidad + cantidad > productoParaAgregar.stock)
                {
                    MessageBox.Show($"No puede agregar más de este producto. Stock disponible: {productoParaAgregar.stock}", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                itemExistente.Cantidad += cantidad;
            }
            else
            {
                // Si es nuevo, lo añadimos a la lista
                carrito.Add(new CarritoItem
                {
                    IdProducto = productoParaAgregar.id_producto,
                    NombreProducto = productoParaAgregar.nombre_producto,
                    Precio = productoParaAgregar.precioVenta,
                    Cantidad = cantidad
                });
            }

            // Actualizamos la tabla del carrito y el total
            ActualizarCarrito();
        }

        private void ActualizarCarrito()
        {
            carritoBindingSource.DataSource = null;
            carritoBindingSource.DataSource = carrito;

            // Calcula y muestra el total
            decimal total = carrito.Sum(item => item.Subtotal);
            lblTotal.Text = total.ToString("C"); // "C" para formato de moneda
        }

        //----------------------------------------------------------
        //Buscar
        //----------------------------------------------------------
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
            ActualizarDatosTabla();
        }

        //---------------------------------------------------------------------------
        //
        //---------------------------------------------------------------------------



        //------------------------------------------------------------------
        // REGISTRO VENTAS - EDICIÓN CARRITO
        //------------------------------------------------------------------
        private void VentaDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 5) 
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

        private void VentaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Asegurarse de que el clic es en una fila válida y en la columna del botón de eliminar
            if (e.RowIndex >= 0 && VentaDataGridView.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                // Obtenemos el item del carrito correspondiente a la fila
                CarritoItem itemAEliminar = (CarritoItem)VentaDataGridView.Rows[e.RowIndex].DataBoundItem;

                var resultado = MessageBox.Show($"¿Desea quitar '{itemAEliminar.NombreProducto}' del carrito?",
                                                "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Eliminamos el item de nuestra lista
                    carrito.Remove(itemAEliminar);

                    // Refrescamos la tabla del carrito para que se vea el cambio
                    ActualizarCarrito();
                }
            }
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            List<DetalleVenta> listaDetalles = new List<DetalleVenta>();

            foreach (DataGridViewRow fila in VentaDataGridView.Rows)
            {
                int idProducto = Convert.ToInt32(fila.Cells["id_producto_venta"].Value);
                Producto prod = _listaProductos.FirstOrDefault(p => p.id_producto == idProducto);
                int cantidad = Convert.ToInt32(fila.Cells["cantidad"].Value);

                if (prod != null)
                {
                    listaDetalles.Add(new DetalleVenta()
                    {
                        objProducto = prod,
                        cantidad = cantidad,
                        subtotal = cantidad * prod.precioVenta
                    });
                }
            }

            string mensaje = "";
            bool resultado = _ventasNegocio.ProcesarDetalles(_ventaActual, listaDetalles, out mensaje);

            if (resultado)
            {
                MessageBox.Show("Detalles agregados. Total calculado: $" + _ventaActual.total.ToString("0.00"));

                // Mostrar la vista de pago
                Payment paymentForm = new Payment(_ventaActual);  // Pasamos la venta actual
                paymentForm.ShowDialog();
                ActualizarDatosTabla();
            }

            else
            {
                MessageBox.Show("Error al procesar detalles:\n" + mensaje);
            }

        }
    }
}

