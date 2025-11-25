using CapaEntidades;
using CapaNegocio;
using FontAwesome.Sharp;
using OcioStoreIngSoftII;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OcioStoreIngSoftII
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static IconButton BotonActivo = null;
        private static Form FormularioActivo = null;


        public Inicio(Usuario objUser) //Usuario objUser
        {
            usuarioActual = objUser;
            InitializeComponent();
        }

        private Producto_negocio objNegocioProducto = new Producto_negocio();

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new Permiso_negocio().Listar(usuarioActual.id_user);

            foreach (Control control in menu.Controls)
            {
                if (control is IconButton iconMenu)
                {
                    bool encontrado = ListaPermisos.Any(m => m.nombreAcceso == iconMenu.Name);

                    // Si el permiso no se encuentra, oculta el botón
                    iconMenu.Visible = encontrado;
                }
            }

            LogOutButton.Visible = true;

            ReorganizarMenu();
            if (usuarioActual.NombreRol == "Administrador" || usuarioActual.NombreRol == "Super Admin")
            {
                VerificarStockBajo();
            } 
        }

        private void ReorganizarMenu()
        {
            menu.SuspendLayout();

            // Define el orden deseado de los botones por su nombre (propiedad Name)
            string[] ordenDeseado = new string[]
            {
                "HomeButton",
                "UserButton",
                "ProductsButton",
                "ClientsButton",
                "SellButton",
                "ProductsButton",
                "CategoriesButton",
                "ReceiptsButton",
                "StatsButton",
                //"RestoreButton", //Anulado puesto que no se debe de poder hacer desde la aplicación
                "BackupButton"

                // Agrega aquí los Nombres (Name) de todos tus botones en el orden que quieras
            };

            var botonesVisiblesActuales = menu.Controls.OfType<IconButton>()
                                                        .Where(b => b.Visible && b != LogOutButton)
                                                        .ToList();

            // Ordenar los botones visibles según el array 'ordenDeseado'
            var botonesAMostrarOrdenados = ordenDeseado
                .Select(name => botonesVisiblesActuales.FirstOrDefault(b => b.Name == name))
                .Where(b => b != null) // Filtra los nombres que no corresponden a un botón visible
                .ToList();

            menu.Controls.Clear();
            menu.RowStyles.Clear();

            menu.RowCount = botonesAMostrarOrdenados.Count + (LogOutButton.Visible ? 1 : 0);

            for (int i = 0; i < menu.RowCount; i++)
            {
                menu.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // Permite que la fila se ajuste al contenido
            }

            int currentRow = 0;
            foreach (var btn in botonesAMostrarOrdenados)
            {
                menu.Controls.Add(btn, 0, currentRow);
                btn.Dock = DockStyle.Fill;
                currentRow++;
            }

            if (LogOutButton.Visible)
            {
                menu.Controls.Add(LogOutButton, 0, currentRow);
                LogOutButton.Dock = DockStyle.Bottom; // Importante para el tamaño
                LogOutButton.Margin = new Padding(0, 10, 0, 0); // Opcional: un poco de espacio
            }

            menu.ResumeLayout();
            menu.PerformLayout();
        }

        private void AbrirFormulario(IconButton boton, Form formulario)
        {
            if (BotonActivo != null)
            {
                BotonActivo.BackColor = ColorTranslator.FromHtml("#283593");
            }

            if (boton != null)
            {
                boton.BackColor = ColorTranslator.FromHtml("#3c64ce");
                BotonActivo = boton;
            }
            else
            {
                BotonActivo = null;
            }

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
                FormularioActivo = null;
            }

            if (formulario != null)
            {
                FormularioActivo = formulario;
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                contenedor.Controls.Add(formulario);
                formulario.Show();
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            AbrirFormulario(null, null);
            if (usuarioActual.NombreRol == "Administrador" || usuarioActual.NombreRol == "Super Admin")
            {
                VerificarStockBajo();
            }
        }

        private void UsersButton_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new Users());
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new Products());
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new Vender(usuarioActual));
        }

        private void CategoriesButton_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new Categories());
        }

        private void ReceiptsButton_Click(object sender, EventArgs e)
        {

        }

        private void StatsButton_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new Stats());
        }

        private void BackupButton_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new Backup());
        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new Clientes());
        }

        private void VerificarStockBajo()
        {
            List<Producto> productosConStockBajo = objNegocioProducto.ObtenerProductosConStockBajo();

            if (productosConStockBajo.Count > 0)
            {
                // Construye el mensaje para la notificación
                string mensaje = $"Hay {productosConStockBajo.Count} producto(s) con stock bajo o nulo.\n\n" +
                                 $"Ejemplo: '{productosConStockBajo[0].nombre_producto}' necesita atención.";

                // Crea y muestra el formulario de notificación
                AvisoStockMinimo notificacion = new AvisoStockMinimo(mensaje);
                notificacion.Show();
            }
        }
    }
}
