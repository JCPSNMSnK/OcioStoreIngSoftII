using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;
using CapaDatos;
using FontAwesome.Sharp;
using CapaEntidades.Utilidades;
using System.IO;
using iText.Layout;
//using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iTextSharp.tool.xml;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace OcioStoreIngSoftII
{
    public partial class Compras : Form
    {
        // Instancia de la capa de negocio para interactuar con los datos
        private readonly Compras_negocio comprasNegocio = new Compras_negocio();
        private readonly Proveedores_negocio proveedoresNegocio = new Proveedores_negocio();
        private readonly Producto_negocio productosNegocio = new Producto_negocio();

        public Compras()
        {
            InitializeComponent();
        }

        // Evento que se ejecuta cuando el formulario se carga
        private void Compras_Load(object sender, EventArgs e)
        {
            // Oculta las columnas que no se mostrarán al usuario
            OcultarColumnas();

            // Llena la tabla con todas las compras al inicio
            CargarCompras();

            // NUEVA LÓGICA: Cargar la lista de proveedores en el ComboBox
            CargarProveedores();
            // Agregar una columna oculta para el ID del producto
            detallesDataGridView.Columns.Add("id_producto", "ID Producto");
            detallesDataGridView.Columns["id_producto"].Visible = false;

            // CÓDIGO ACTUALIZADO: Volvemos a la columna de botón de texto
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "btnEliminar";
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Text = "X";
            btnEliminar.UseColumnTextForButtonValue = true;
            detallesDataGridView.Columns.Add(btnEliminar);
        }

        // NUEVO MÉTODO: Cargar proveedores en el ComboBox
        private void CargarProveedores()
        {
            List<Proveedor> listaProveedores = proveedoresNegocio.ListarProveedores();
            CBProveedor.DataSource = listaProveedores;
            CBProveedor.DisplayMember = "nombre_proveedor";
            CBProveedor.ValueMember = "id_proveedor";
            CBProveedor.Refresh();
        }

        // Método para cargar la tabla de compras
        private void CargarCompras(string filtro = null)
        {
            List<Compra> listaCompras;

            if (string.IsNullOrEmpty(filtro))
            {
                // Si el filtro está vacío, se muestran todas las compras
                listaCompras = comprasNegocio.ListarCompras();
            }
            else
            {
                // Si hay un filtro, se realiza la búsqueda general
                listaCompras = comprasNegocio.BuscarComprasGeneral(filtro);
            }

            // Enlazar los datos a la tabla
            comprasDataGridView.DataSource = null;
            comprasDataGridView.DataSource = listaCompras;
        }

        // Método para ocultar columnas en la tabla
        private void OcultarColumnas()
        {
            
            if (comprasDataGridView.Columns.Contains("objUsuario"))
            {
                comprasDataGridView.Columns["objUsuario"].Visible = false;
            }
            if (comprasDataGridView.Columns.Contains("detalles"))
            {
                comprasDataGridView.Columns["detalles"].Visible = false;
            }
        }

        // Evento para el botón de búsqueda
        private void BSearch_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text;
            CargarCompras(filtro);
        }

        // NUEVO EVENTO: Buscar producto al presionar Enter en el campo de código
        private void TB_Codigo_Producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                string codigoProducto = TCodigoProducto.Content;
                Producto productoEncontrado = productosNegocio.BuscarProductosGeneral(codigoProducto, 0).First();

                if (productoEncontrado != null)
                {
                    TNombreProducto.Content = productoEncontrado.nombre_producto;
                    // Guardar el ID en la etiqueta para usarlo luego
                    TB_Id_Producto_Oculto.Text = productoEncontrado.id_producto.ToString();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TNombreProducto.Content = string.Empty;
                    TB_Id_Producto_Oculto.Text = string.Empty;
                }
            }
        }

        // NUEVO EVENTO: Agregar producto a la lista de detalles
        private void BAgregarProducto_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (CBProveedor.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(TNombreProducto.Content))
            {
                MessageBox.Show("Debe ingresar un código de producto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal precioUnitario;
            if (!decimal.TryParse(TPrecioUnitario.Content, out precioUnitario))
            {
                MessageBox.Show("Debe ingresar un precio unitario válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Asumiendo que `cantidad` es un `NumericUpDown`
            int cantidad = (int)NCantidad.Value;
            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad no puede ser cero o negativa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /// Crear el objeto para el detalle de la compra
            DetalleCompra detalle = new DetalleCompra()
            {
                // Ahora usamos el ID del producto
                objProducto = new Producto() { id_producto = Convert.ToInt32(TB_Id_Producto_Oculto.Text), nombre_producto = TNombreProducto.Text },
                cantidad = cantidad,
                precio_unitario = precioUnitario
            };

            // Agregar el producto a la tabla de detalles, ahora con el orden correcto
            detallesDataGridView.Rows.Add(new object[] {
                detalle.objProducto.nombre_producto,
                detalle.precio_unitario,
                detalle.cantidad,
                "X", // Botón de eliminar
                detalle.objProducto.id_producto // ID del producto (oculto)
            });

            // Limpiar los campos para el siguiente producto
            TCodigoProducto.Text = string.Empty;
            TNombreProducto.Content = string.Empty;
            NCantidad.Value = 0;
            TPrecioUnitario.Content = string.Empty;
        }

        // NUEVO EVENTO: Registrar la compra completa
        private void BRegistrarCompra_Click(object sender, EventArgs e)
        {
            // Validación: Asegurarse de que haya al menos un producto en la lista
            if (detallesDataGridView.Rows.Count < 1)
            {
                MessageBox.Show("Debe agregar al menos un producto a la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el proveedor seleccionado
            Proveedor proveedorSeleccionado = (Proveedor)CBProveedor.SelectedItem;

            // Calcular el total de la compra y construir la lista de detalles
            decimal totalCompra = 0;
            List<DetalleCompra> detallesCompra = new List<DetalleCompra>();

            foreach (DataGridViewRow fila in detallesDataGridView.Rows)
            {
                if (!fila.IsNewRow) // Evitar la fila vacía de la tabla
                {
                    // Obtener los datos de la fila, incluyendo el ID del producto
                    DetalleCompra detalle = new DetalleCompra()
                    {
                        objProducto = new Producto() { id_producto = Convert.ToInt32(fila.Cells["id_producto"].Value), nombre_producto = fila.Cells["nombre_producto"].Value.ToString() },
                        precio_unitario = Convert.ToDecimal(fila.Cells["precio_unitario"].Value),
                        cantidad = Convert.ToInt32(fila.Cells["cantidad"].Value)
                    };
                    detallesCompra.Add(detalle);
                    totalCompra += detalle.precio_unitario * detalle.cantidad;
                }
            }

            // Crear el objeto Compra
            Compra nuevaCompra = new Compra()
            {
                objProveedor = proveedorSeleccionado,
                total = totalCompra,
                detalles = detallesCompra
            };

            // Llamar al método de negocio para registrar la compra
            string mensaje;
            int idCompraGenerada = comprasNegocio.RegistrarCompra(nuevaCompra, detallesCompra, out mensaje);

            if (idCompraGenerada > 0)
            {
                MessageBox.Show("Compra registrada exitosamente. ID: " + idCompraGenerada, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Error al registrar la compra: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // NUEVO MÉTODO: Limpiar todos los campos del formulario
        private void LimpiarFormulario()
        {
            // Limpiar los campos de registro de producto
            CBProveedor.SelectedIndex = -1;
            TCodigoProducto.Content = string.Empty;
            TNombreProducto.Content = string.Empty;
            NCantidad.Value = 0;
            TPrecioUnitario.Content = string.Empty;

            // Limpiar la tabla de detalles de la compra
            detallesDataGridView.Rows.Clear();
            detallesDataGridView.Refresh();
        }

        // NUEVO EVENTO: Manejar el clic del botón en la tabla de detalles para eliminar una fila
        private void detallesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == detallesDataGridView.Columns["btnEliminar"].Index && e.RowIndex >= 0)
            {
                // Confirmar la eliminación con el usuario
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Eliminar la fila de la tabla
                    detallesDataGridView.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            //corregir la condíción de control de ser necesario, aquello que vayamos a imprimir tiene que existir
            if(btnSeleccionar.Text == "")
            {
                MessageBox.Show("No se encontró la compra para imprimir", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string Texto_Html = Properties.Resources.PlantillaCompra.ToString(); //la plantilla HTML cargada en Recursos del Proyecto

            Texto_Html = Texto_Html.Replace("@nombrenegocio", "Ocio Store");
            Texto_Html = Texto_Html.Replace("@docnegocio", "Tienda de Juegos de Mesa");
            Texto_Html = Texto_Html.Replace("@direcnegocio", "Avenida Corrientes 453");

            Texto_Html = Texto_Html.Replace("@tipodocumento", "COMPROBANTE DE COMPRA");
            Texto_Html = Texto_Html.Replace("@numerodocumento", "");//poner acá el ID de la Compra desde lo seleccionado

            Texto_Html = Texto_Html.Replace("@docproveedor", ""); //poner acá el CUIT del PRoveedor de la compra
            Texto_Html = Texto_Html.Replace("@nombreproveedor", ""); //poner acá el nombre del proveedor 
            Texto_Html = Texto_Html.Replace("@fecharegistro", ""); //poner la fecha de la compra
            Texto_Html = Texto_Html.Replace("@usuarioregistro", ""); //poner el nombre del usuario que generó el pdf de la compra

            string filas = string.Empty;
            foreach(DataGridViewRow row in comprasDataGridView.Rows)
            {
                filas += "<td>";
                filas += "<td>" + row.Cells["Nombre Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Precio Unitario"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Total"].Value.ToString() + "</td>";
                filas += "</td>";
            }

            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", ""); //colocar el total

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = string.Format("Compra_{0].pdf", btnSeleccionar.Text);
            saveFile.Filter = "Pdf files|* .pdf";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                {
                    iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 25, 25, 25, 25);

                    iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    bool obtenido = true;
                    byte[] byteImage = null; //poner la imagen acá, una ref a resources quizas

                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.GetLeft(20), pdfDoc.GetTop(51));
                        pdfDoc.Add(img);
                    }

                    using(StringReader sr = new StringReader(Texto_Html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
