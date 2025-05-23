﻿using CapaEntidades;
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
        private void Inicio_Load(object sender, EventArgs e)
        {
            //List<Permiso> ListaPermisos = new Permiso_negocio().Listar(usuarioActual.id_usuario);

            //foreach (Control control in menu.Controls)
            //{
            //    if (control is IconButton iconMenu)
            //    {
            //        bool encontrado = ListaPermisos.Any(m => m.nombreAcceso == iconMenu.Name);

            //        // Si el permiso no se encuentra, oculta el botón
            //        iconMenu.Visible = encontrado;
            //    }
            //}

            LogOutButton.Visible = true;

            // Ajusta el layout según la cantidad de botones visibles
            int botonesVisibles = menu.Controls.OfType<IconButton>().Count(b => b.Visible);

            menu.RowStyles.Clear();
            menu.RowCount = botonesVisibles;

            for (int i = 0; i < botonesVisibles; i++)
            {
                menu.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / botonesVisibles));
            }

            //// Ajusta cada botón visible para que ocupe el espacio completo de su celda
            //foreach (Control control in menu.Controls.OfType<IconButton>().Where(b => b.Visible))
            //{
            //    control.Dock = DockStyle.Fill; // Expande el botón para ocupar todo el ancho y alto de su celda
            //}

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
        }


        private void UsersButton_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new Users());
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
