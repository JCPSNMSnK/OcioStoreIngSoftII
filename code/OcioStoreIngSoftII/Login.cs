using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using OcioStoreIngSoftII;
using CapaEntidades;
using CapaNegocio;

namespace OcioStoreIngSoftII
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void form_closing(object sender, FormClosingEventArgs e)
        {
            TUser.Content = "";
            TPass.Content = "";
            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            TPass.PlaceholderText = "Contraseña";
            TPass.PlaceholderColor = Color.Gray;

            TUser.PlaceholderText = "Usuario";
            TUser.PlaceholderColor = Color.Gray;
        }

        private void BLogin_Click_1(object sender, EventArgs e)
        {
            string usuario = TUser.Content?.Trim();
            string password = TPass.Content;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, completá todos los campos.");
                return;
            }

            string mensaje;
            Usuario_negocio negocio = new Usuario_negocio();
            Usuario userAutenticado = negocio.AutenticarUsuario(usuario, password, out mensaje);

            if (userAutenticado != null)
            {
                Inicio form_inicio = new Inicio(userAutenticado);
                form_inicio.Show();
                this.Hide();
                form_inicio.FormClosing += form_closing;
            }
            else
            {
                MessageBox.Show(mensaje, "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
