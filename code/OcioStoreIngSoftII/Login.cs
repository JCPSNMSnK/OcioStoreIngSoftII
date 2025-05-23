﻿using System;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LLogin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BLogin_Click_1(object sender, EventArgs e)
        {
            List<Usuario> TEST = new Usuario_negocio().Listar();




            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString;
            string usuario = TUser.Text;
            string pass = TPass.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT pass, id_rol FROM users WHERE username=@usuario";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@usuario", usuario);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) // Si el usuario existe
                    {
                        string storedHash = reader["pass"].ToString();
                        int perfilId = Convert.ToInt32(reader["id_rol"]);
                        Usuario ousuario = new Usuario_negocio().Listar().Where(u => u.username == TUser.Text && u.pass == storedHash).FirstOrDefault();
                        Inicio form_inicio = new Inicio(ousuario);

                        // Verificamos si la contraseña está hasheada o en texto claro
                        bool isAuthenticated = false;
                        if (storedHash.Length == 60) // Longitud típica de un hash BCrypt
                        {
                            isAuthenticated = BCrypt.Net.BCrypt.Verify(pass, storedHash);
                        }
                        else
                        {
                            isAuthenticated = pass == storedHash; // Compara directamente si no está hasheada
                        }

                        // Verificamos si la autenticación fue exitosa y que el perfil_id sea distinto de 0
                        if (isAuthenticated && perfilId != 0)
                        {
                            // Caso de éxito: Mostrar la nueva ventana y ocultar la actual
                            form_inicio.Show();
                            this.Hide();

                            // Aseguramos que el evento form_closing se suscribe antes de mostrar el formulario
                            form_inicio.FormClosing += form_closing;
                        }
                        else if (perfilId == 0)
                        {
                            MessageBox.Show("El usuario no tiene permiso para ingresar");
                        }
                        else
                        {
                            MessageBox.Show("Usuario o Contraseña no válidos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña no válidos");
                    }
                }
            }
        }

        public void form_closing(object sender, FormClosingEventArgs e)
        {
            TUser.Text = "";
            TPass.Text = "";
            this.Show();
        }

        private void TPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void LPass_Click(object sender, EventArgs e)
        {

        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LPass_Click_1(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            TPass.Text = "Contraseña";
            TPass.ForeColor = Color.Gray;
            TPass.UseSystemPasswordChar = false;

            TUser.Text = "Usuario";
            TUser.ForeColor = Color.Gray;
        }

        // Evento Enter
        private void TPass_Enter(object sender, EventArgs e)
        {
            if (TPass.Text == "Contraseña")
            {
                TPass.Text = "";
                TPass.ForeColor = Color.Black;
                TPass.UseSystemPasswordChar = true;
            }
        }

        private void TPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TPass.Text))
            {
                TPass.Text = "Contraseña";
                TPass.ForeColor = Color.Gray;
                TPass.UseSystemPasswordChar = false;
            }
        }

        private void TUser_Enter(object sender, EventArgs e)
        {
            if (TUser.Text == "Usuario")
            {
                TUser.Text = "";
                TUser.ForeColor = Color.Black;
            }
        }

        private void TUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TUser.Text))
            {
                TUser.Text = "Usuario";
                TUser.ForeColor = Color.Gray;
            }
        }
    }
}
