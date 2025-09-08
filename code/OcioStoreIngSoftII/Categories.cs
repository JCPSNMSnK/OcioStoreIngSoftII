using CapaEntidades;
using CapaEntidades.Utilidades;
using CapaNegocio;
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
    public partial class Categories : Form
    {
        private readonly Categoria_negocio categoria_Negocio;
        
        public Categories()
        {
            InitializeComponent();
            categoria_Negocio = new Categoria_negocio();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            // Llenar el ComboBox de estados
            CBEstado.Items.Add(new OpcionSelect() { Valor = 0, Texto = "Alta" });
            CBEstado.Items.Add(new OpcionSelect() { Valor = 1, Texto = "Baja" });
            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "Valor";
            CBEstado.SelectedIndex = 0;

            CBModificarEstado.Items.Add(new OpcionSelect() { Valor = 0, Texto = "Alta" });
            CBModificarEstado.Items.Add(new OpcionSelect() { Valor = 1, Texto = "Baja" });
            CBModificarEstado.DisplayMember = "Texto";
            CBModificarEstado.ValueMember = "Valor";

            actualizarDatosTabla();
        }
        private void actualizarDatosTabla(string filtros = null)
        {
            if (filtros == null)
            {
                filtros = "";
            }

            List<Categoria> resultados = categoria_Negocio.BuscarCategoriasGeneral(filtros);
            Dictionary<int, int> cantidad_productos = categoria_Negocio.ContarProductosPorCategoria();
            categoriasDataGridView.AutoGenerateColumns = false;
            categoriasDataGridView.DataSource = null;
            categoriasDataGridView.DataSource = resultados;

            if (categoriasDataGridView.Columns.Contains("cantidad_productos"))
            {
                foreach (DataGridViewRow row in categoriasDataGridView.Rows)
                {
                    if (row.IsNewRow) continue;

                    Categoria categoria = (Categoria)row.DataBoundItem;
                    if (categoria != null && cantidad_productos.ContainsKey(categoria.id_categoria))
                    {
                        row.Cells["cantidad_productos"].Value = cantidad_productos[categoria.id_categoria];
                    }
                    else
                    {
                        row.Cells["cantidad_productos"].Value = 0;
                    }
                }
            }
        }

        //Buscar
        private void BBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();

            List<Categoria> resultados = categoria_Negocio.Listar();
            categoriasDataGridView.DataSource = null;
            categoriasDataGridView.DataSource = resultados;
        }

        // Modificar Categoría
        private void BModificar_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado una categoría
            if (string.IsNullOrEmpty(TModificarNombre.Content))
            {
                MessageBox.Show("Debe seleccionar una categoría para modificar.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validaciones de los campos de la categoría
            if (ValidacionesCategoria(TModificarNombre.Content, out string mensajeError))
            {
                // Creación de un nuevo objeto Categoria
                Categoria objCategoria = new Categoria()
                {
                    id_categoria = Convert.ToInt32(TModificarID_user.Content),
                    nombre_categoria = TModificarNombre.Content,
                    baja_categoria = Convert.ToInt32(((OpcionSelect)CBModificarEstado.SelectedItem).Valor) == 1
                };

                // Llamada a la capa de negocio para la edición
                bool resultado = categoria_Negocio.Modificar(objCategoria, out string mensaje);

                if (resultado)
                {
                    VaciarCampos();
                    actualizarDatosTabla();
                    MessageBox.Show("Categoría modificada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (ValidacionesCategoria(TNombre.Content, out string mensajeError))
            {
                // Creación del objeto Categoría
                Categoria objCategoria = new Categoria()
                {
                    nombre_categoria = TNombre.Content,
                    baja_categoria = Convert.ToInt32(((OpcionSelect)CBEstado.SelectedItem).Valor) == 1
                };

                if (categoria_Negocio.Registrar(objCategoria, out string mensaje))
                {
                    VaciarCampos();
                    actualizarDatosTabla();
                    MessageBox.Show("Categoría registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void categoriasDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void categoriasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el clic no fue en el encabezado
            if (e.RowIndex < 0) return;

            // Verificar si la columna del clic es el botón de "Seleccionar"
            if (categoriasDataGridView.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                // Obtener el objeto Categoria de la fila seleccionada
                // Usamos la propiedad DataBoundItem para obtener el objeto completo
                // y hacemos un 'cast' a la clase Categoria.
                Categoria categoriaSeleccionada = (Categoria)categoriasDataGridView.Rows[e.RowIndex].DataBoundItem;

                // Verificar que el objeto no sea nulo
                if (categoriaSeleccionada != null)
                {
                    // Ejemplo de cómo llenar los campos de texto
                    // (Ajustar los nombres de los controles de tu UI, ej: txtId, txtNombre, cbEstado)

                    // Supongamos que tienes un TextBox para el ID y otro para el nombre
                    TBModificarIndice.Content = e.RowIndex.ToString();
                    TModificarID_user.Content = categoriaSeleccionada.id_categoria.ToString();
                    TModificarNombre.Content = categoriaSeleccionada.nombre_categoria;

                    // Para el ComboBox del estado (asumiendo que es un ComboBox)
                    // Puedes usar un OpcionSelect similar a como lo hiciste para Usuarios
                    if (CBModificarEstado != null)
                    {
                        CBModificarEstado.SelectedItem = categoriaSeleccionada.baja_categoria ? "Baja" : "Alta";
                        // Puedes usar el SelectedValue si tienes los valores en el ComboBox
                        CBModificarEstado.SelectedValue = categoriaSeleccionada.baja_categoria ? 1 : 0;
                    }
                }
            }
        }

        // DGV - Completa la lógica de la tabla una vez que el enlace de datos está completo
        private void categoriasDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in categoriasDataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                var valor = row.Cells["baja_estado_valor"].Value;
                if (valor != null && valor != DBNull.Value)
                {
                    bool estado = Convert.ToBoolean(valor);
                    row.Cells["baja_estado"].Value = estado ? "Baja" : "Alta";
                }
                else
                {
                    row.Cells["baja_estado"].Value = "Desconocido";
                }
            }
            categoriasDataGridView.ClearSelection();
            categoriasDataGridView.CurrentCell = null;
        }

        // Validaciones mejoradas para Categoría
        private bool ValidacionesCategoria(string nombre, out string mensajeError)
        {
            mensajeError = string.Empty;

            // El nombre de la categoría no puede estar vacío.
            if (string.IsNullOrWhiteSpace(nombre))
            {
                mensajeError = "El nombre de la categoría es obligatorio.";
                return false;
            }

            // El nombre de la categoría no puede contener números.
            if (nombre.Any(char.IsDigit))
            {
                mensajeError = "El nombre de la categoría no puede contener números.";
                return false;
            }

            // El nombre no puede exceder los 50 caracteres.
            if (nombre.Length > 50)
            {
                mensajeError = "El nombre de la categoría no puede tener más de 50 caracteres.";
                return false;
            }

            return true;
        }

        // Método adaptado para vaciar los campos de Categoría
        private void VaciarCampos()
        {
            TID_user.Content = string.Empty;
            TNombre.Content = string.Empty;
            CBEstado.SelectedIndex = 0;
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
