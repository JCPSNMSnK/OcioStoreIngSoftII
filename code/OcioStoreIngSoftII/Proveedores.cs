using CapaEntidades;
using CapaEntidades.Utilidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OcioStoreIngSoftII
{
    public partial class Proveedores : Form
    {
        private readonly Proveedores_negocio proveedorNegocio;
        public Proveedores()
        {
            InitializeComponent();
            proveedorNegocio = new Proveedores_negocio();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            actualizarDatosTabla();
        }
        private void actualizarDatosTabla(string filtros = null)
        {
            if (filtros == null)
            {
                filtros = "";
            }

            List<Proveedor> resultados = proveedorNegocio.ListarProveedores();
            //Dictionary<int, int> cantidad_productos = proveedorNegocio.ContarProductosPorProveedor();
            proveedoresDataGridView.AutoGenerateColumns = false;
            proveedoresDataGridView.DataSource = null;
            proveedoresDataGridView.DataSource = resultados;
        }

        //Buscar
        private void BBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();

            List<Proveedor> resultados = proveedorNegocio.ListarProveedores();
            proveedoresDataGridView.DataSource = null;
            proveedoresDataGridView.DataSource = resultados;
        }

        // Modificar Categoría
        private void BModificar_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado una proveedor
            if (string.IsNullOrEmpty(TModificarNombreProveedor.Content))
            {
                MessageBox.Show("Debe seleccionar una categoría para modificar.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validaciones de los campos de la proveedor
            if (ValidacionesCategoria(TModificarNombreProveedor.Content, TModificarTelefonoProveedor.Content, TModificarCUITProveedor.Content, out string mensajeError))
            {
                // Creación de un nuevo objeto proveedor
                Proveedor objProveedor = new Proveedor()
                {
                    id_proveedor = Convert.ToInt32(TModificarIDProveedor.Content),
                    nombre_proveedor = TModificarNombreProveedor.Content,
                    cuit_proveedor = TModificarCUITProveedor.Content,
                    telefono_proveedor = TModificarTelefonoProveedor.Content
                };

                // Llamada a la capa de negocio para la edición
                bool resultado = proveedorNegocio.ModificarProveedor(objProveedor, out string mensaje);

                if (resultado)
                {
                    VaciarCampos();
                    actualizarDatosTabla();
                    MessageBox.Show("Proveedor modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(mensajeError, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Registrar Categoría
        private void BRegisterCategory_Click(object sender, EventArgs e)
        {
            if (ValidacionesCategoria(TNombreProveedor.Content, TTelefonoProveedor.Content, TCUITProveedor.Content,out string mensajeError))
            {
                // Creación del objeto Proveedor
                Proveedor objProveedor = new Proveedor()
                {
                    nombre_proveedor = TNombreProveedor.Content,
                    telefono_proveedor = TTelefonoProveedor.Content,
                    cuit_proveedor = TCUITProveedor.Content
                };

                if (proveedorNegocio.RegistrarProveedor(objProveedor, out string mensaje) > 0)
                {
                    VaciarCampos();
                    actualizarDatosTabla();
                    MessageBox.Show("Proveedor registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(mensajeError, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // DGV - Dibujo del botón Seleccionar
        private void proveedoresDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            // Verificar si estamos en la primera columna (índice 0)
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Obtener el tamaño de la imagen del recurso
                var w = OcioStoreIngSoftII.Properties.Resources.checkbox.Width;
                var h = OcioStoreIngSoftII.Properties.Resources.checkbox.Height;

                // Calcular la posición central para dibujar la imagen
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                // Dibujar la imagen
                e.Graphics.DrawImage(OcioStoreIngSoftII.Properties.Resources.checkbox, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void proveedoresDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el clic no fue en el encabezado
            if (e.RowIndex < 0) return;

            // Verificar si la columna del clic es el botón de "Seleccionar"
            if (proveedoresDataGridView.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                // Obtener el objeto Categoria de la fila seleccionada
                // Usamos la propiedad DataBoundItem para obtener el objeto completo
                // y hacemos un 'cast' a la clase Categoria.
                Proveedor proveedorSeleccionada = (Proveedor)proveedoresDataGridView.Rows[e.RowIndex].DataBoundItem;

                // Verificar que el objeto no sea nulo
                if (proveedorSeleccionada != null)
                {
                    // Ejemplo de cómo llenar los campos de texto
                    // (Ajustar los nombres de los controles de tu UI, ej: txtId, txtNombre, cbEstado)

                    // Supongamos que tienes un TextBox para el ID y otro para el nombre
                    TBModificarIndice.Content = e.RowIndex.ToString();
                    TModificarIDProveedor.Content = proveedorSeleccionada.id_proveedor.ToString();
                    TModificarNombreProveedor.Content = proveedorSeleccionada.nombre_proveedor;
                    TModificarCUITProveedor.Content = proveedorSeleccionada.cuit_proveedor;
                    TModificarTelefonoProveedor.Content = proveedorSeleccionada.telefono_proveedor;
                }
            }
        }

        // DGV - Completa la lógica de la tabla una vez que el enlace de datos está completo
        private void proveedorsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            proveedoresDataGridView.ClearSelection();
            proveedoresDataGridView.CurrentCell = null;
        }

        // Validaciones mejoradas para Categoría
        private bool ValidacionesCategoria(string nombre, string telefono, string cuit, out string mensajeError)
        {
            mensajeError = string.Empty;

            // El nombre de la categoría no puede estar vacío.
            if (string.IsNullOrWhiteSpace(nombre))
            {
                mensajeError = "El nombre del proveedor es obligatorio.";
                return false;
            }

            // El nombre de la categoría no puede contener números.
            if (nombre.Any(char.IsDigit))
            {
                mensajeError = "El nombre del proveedor no puede contener números.";
                return false;
            }

            // El nombre no puede exceder los 50 caracteres.
            if (nombre.Length > 50)
            {
                mensajeError = "El nombre del proveedor no puede tener más de 50 caracteres.";
                return false;
            }

            //Telefono
            if (telefono.Length < 7)
            {
                mensajeError = "El número de teléfono es demasiado corto.";
                return false;
            }
            if (!telefono.All(char.IsDigit))
            {
                mensajeError = "El campo telefono solo puede contener números, sin guiones o " + ".";
                return false;
            }

            //CUIT
            if(string.IsNullOrWhiteSpace(cuit))
            {
                mensajeError = "El campo DNI es obligatorio.";
                return false;
            }
            if (!cuit.All(char.IsDigit))
            {
                mensajeError = "El campo DNI solo puede contener números, sin puntos.";
                return false;
            }


            return true;
        }

        // Método adaptado para vaciar los campos de Categoría
        private void VaciarCampos()
        {
            TIDProveedor.Content = string.Empty;
            TNombreProveedor.Content = string.Empty;
            TTelefonoProveedor.Content = string.Empty;
            TCUITProveedor.Content = string.Empty;
        }

        private void Users_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BBuscar_Click(BBuscar, EventArgs.Empty);

                // Evita el sonido "ding" de Windows al presionar Enter en algunos contextos
                e.SuppressKeyPress = true;
            }
        }

    }
}
