namespace OcioStoreIngSoftII
{
    partial class GestionarCategorias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.btnCancelar = new CuoreUI.Controls.cuiButton();
            this.btnGuardar = new CuoreUI.Controls.cuiButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CLBCategorias = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.cuiLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 361);
            this.panel1.TabIndex = 0;
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Content = "Seleccionar\\ Categorias";
            this.cuiLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.ForeColor = System.Drawing.Color.White;
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel1.Location = new System.Drawing.Point(234, 17);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(301, 47);
            this.cuiLabel1.TabIndex = 1;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnCancelar
            // 
            this.btnCancelar.CheckButton = false;
            this.btnCancelar.Checked = false;
            this.btnCancelar.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnCancelar.CheckedForeColor = System.Drawing.Color.White;
            this.btnCancelar.CheckedImageTint = System.Drawing.Color.White;
            this.btnCancelar.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnCancelar.Content = "Cancelar";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.HoverBackground = System.Drawing.Color.Firebrick;
            this.btnCancelar.HoverForeColor = System.Drawing.Color.White;
            this.btnCancelar.HoverImageTint = System.Drawing.Color.White;
            this.btnCancelar.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.Image = null;
            this.btnCancelar.ImageAutoCenter = true;
            this.btnCancelar.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnCancelar.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCancelar.Location = new System.Drawing.Point(412, 298);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NormalBackground = System.Drawing.Color.DimGray;
            this.btnCancelar.NormalForeColor = System.Drawing.Color.White;
            this.btnCancelar.NormalImageTint = System.Drawing.Color.White;
            this.btnCancelar.NormalOutline = System.Drawing.Color.Gray;
            this.btnCancelar.OutlineThickness = 1F;
            this.btnCancelar.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnCancelar.PressedImageTint = System.Drawing.Color.White;
            this.btnCancelar.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.Rounding = new System.Windows.Forms.Padding(8);
            this.btnCancelar.Size = new System.Drawing.Size(193, 32);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnCancelar.TextOffset = new System.Drawing.Point(0, 0);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.CheckButton = false;
            this.btnGuardar.Checked = false;
            this.btnGuardar.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnGuardar.CheckedForeColor = System.Drawing.Color.White;
            this.btnGuardar.CheckedImageTint = System.Drawing.Color.White;
            this.btnGuardar.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnGuardar.Content = "Guardar";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnGuardar.HoverForeColor = System.Drawing.Color.White;
            this.btnGuardar.HoverImageTint = System.Drawing.Color.White;
            this.btnGuardar.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGuardar.Image = null;
            this.btnGuardar.ImageAutoCenter = true;
            this.btnGuardar.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnGuardar.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnGuardar.Location = new System.Drawing.Point(179, 298);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.NormalBackground = System.Drawing.Color.White;
            this.btnGuardar.NormalForeColor = System.Drawing.Color.Black;
            this.btnGuardar.NormalImageTint = System.Drawing.Color.White;
            this.btnGuardar.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGuardar.OutlineThickness = 1F;
            this.btnGuardar.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.btnGuardar.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnGuardar.PressedImageTint = System.Drawing.Color.White;
            this.btnGuardar.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGuardar.Rounding = new System.Windows.Forms.Padding(8);
            this.btnGuardar.Size = new System.Drawing.Size(193, 32);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnGuardar.TextOffset = new System.Drawing.Point(0, 0);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.CLBCategorias);
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 222);
            this.panel2.TabIndex = 12;
            // 
            // CLBCategorias
            // 
            this.CLBCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.CLBCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CLBCategorias.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLBCategorias.ForeColor = System.Drawing.Color.White;
            this.CLBCategorias.FormattingEnabled = true;
            this.CLBCategorias.Location = new System.Drawing.Point(47, 12);
            this.CLBCategorias.Name = "CLBCategorias";
            this.CLBCategorias.Size = new System.Drawing.Size(691, 198);
            this.CLBCategorias.TabIndex = 1;
            // 
            // GestionarCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.panel1);
            this.Name = "GestionarCategorias";
            this.Text = "GestionarCategorias";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiButton btnCancelar;
        private CuoreUI.Controls.cuiButton btnGuardar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckedListBox CLBCategorias;
    }
}