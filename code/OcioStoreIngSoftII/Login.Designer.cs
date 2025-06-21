namespace OcioStoreIngSoftII
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TUser = new CuoreUI.Controls.cuiTextBox();
            this.TPass = new CuoreUI.Controls.cuiTextBox();
            this.BCancelar = new CuoreUI.Controls.cuiButton();
            this.BLogin = new CuoreUI.Controls.cuiButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.TUser);
            this.panel1.Controls.Add(this.TPass);
            this.panel1.Controls.Add(this.BCancelar);
            this.panel1.Controls.Add(this.BLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 372);
            this.panel1.TabIndex = 2;
            // 
            // TUser
            // 
            this.TUser.BackgroundColor = System.Drawing.Color.White;
            this.TUser.Content = "";
            this.TUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TUser.FocusBackgroundColor = System.Drawing.Color.White;
            this.TUser.FocusImageTint = System.Drawing.Color.White;
            this.TUser.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TUser.ForeColor = System.Drawing.Color.Black;
            this.TUser.Image = null;
            this.TUser.ImageExpand = new System.Drawing.Point(0, 0);
            this.TUser.ImageOffset = new System.Drawing.Point(0, 0);
            this.TUser.Location = new System.Drawing.Point(51, 176);
            this.TUser.Margin = new System.Windows.Forms.Padding(4);
            this.TUser.Multiline = false;
            this.TUser.Name = "TUser";
            this.TUser.NormalImageTint = System.Drawing.Color.White;
            this.TUser.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TUser.Padding = new System.Windows.Forms.Padding(15, 7, 15, 0);
            this.TUser.PasswordChar = false;
            this.TUser.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.TUser.PlaceholderText = "";
            this.TUser.Rounding = new System.Windows.Forms.Padding(8);
            this.TUser.Size = new System.Drawing.Size(193, 29);
            this.TUser.TabIndex = 10;
            this.TUser.TextOffset = new System.Drawing.Size(0, 0);
            this.TUser.UnderlinedStyle = true;
            // 
            // TPass
            // 
            this.TPass.BackgroundColor = System.Drawing.Color.White;
            this.TPass.Content = "";
            this.TPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TPass.FocusBackgroundColor = System.Drawing.Color.White;
            this.TPass.FocusImageTint = System.Drawing.Color.White;
            this.TPass.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPass.ForeColor = System.Drawing.Color.Black;
            this.TPass.Image = null;
            this.TPass.ImageExpand = new System.Drawing.Point(0, 0);
            this.TPass.ImageOffset = new System.Drawing.Point(0, 0);
            this.TPass.Location = new System.Drawing.Point(51, 215);
            this.TPass.Margin = new System.Windows.Forms.Padding(4);
            this.TPass.Multiline = false;
            this.TPass.Name = "TPass";
            this.TPass.NormalImageTint = System.Drawing.Color.White;
            this.TPass.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TPass.Padding = new System.Windows.Forms.Padding(15, 7, 15, 0);
            this.TPass.PasswordChar = true;
            this.TPass.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.TPass.PlaceholderText = "";
            this.TPass.Rounding = new System.Windows.Forms.Padding(8);
            this.TPass.Size = new System.Drawing.Size(193, 29);
            this.TPass.TabIndex = 10;
            this.TPass.TextOffset = new System.Drawing.Size(0, 0);
            this.TPass.UnderlinedStyle = true;
            this.TPass.ContentChanged += new System.EventHandler(this.TPass_ContentChanged);
            // 
            // BCancelar
            // 
            this.BCancelar.CheckButton = false;
            this.BCancelar.Checked = false;
            this.BCancelar.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.BCancelar.CheckedForeColor = System.Drawing.Color.White;
            this.BCancelar.CheckedImageTint = System.Drawing.Color.White;
            this.BCancelar.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.BCancelar.Content = "Cancelar";
            this.BCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BCancelar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BCancelar.ForeColor = System.Drawing.Color.White;
            this.BCancelar.HoverBackground = System.Drawing.Color.White;
            this.BCancelar.HoveredImageTint = System.Drawing.Color.White;
            this.BCancelar.HoverForeColor = System.Drawing.Color.Black;
            this.BCancelar.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BCancelar.Image = null;
            this.BCancelar.ImageAutoCenter = true;
            this.BCancelar.ImageExpand = new System.Drawing.Point(0, 0);
            this.BCancelar.ImageOffset = new System.Drawing.Point(0, 0);
            this.BCancelar.Location = new System.Drawing.Point(51, 319);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BCancelar.NormalForeColor = System.Drawing.Color.White;
            this.BCancelar.NormalImageTint = System.Drawing.Color.White;
            this.BCancelar.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BCancelar.OutlineThickness = 1F;
            this.BCancelar.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.BCancelar.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BCancelar.PressedImageTint = System.Drawing.Color.White;
            this.BCancelar.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BCancelar.Rounding = new System.Windows.Forms.Padding(8);
            this.BCancelar.Size = new System.Drawing.Size(193, 32);
            this.BCancelar.TabIndex = 9;
            this.BCancelar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BCancelar.TextOffset = new System.Drawing.Point(0, 0);
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click_1);
            // 
            // BLogin
            // 
            this.BLogin.CheckButton = false;
            this.BLogin.Checked = false;
            this.BLogin.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.BLogin.CheckedForeColor = System.Drawing.Color.White;
            this.BLogin.CheckedImageTint = System.Drawing.Color.White;
            this.BLogin.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.BLogin.Content = "Iniciar Sesión";
            this.BLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BLogin.ForeColor = System.Drawing.Color.Black;
            this.BLogin.HoverBackground = System.Drawing.Color.Gainsboro;
            this.BLogin.HoveredImageTint = System.Drawing.Color.White;
            this.BLogin.HoverForeColor = System.Drawing.Color.Black;
            this.BLogin.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BLogin.Image = null;
            this.BLogin.ImageAutoCenter = true;
            this.BLogin.ImageExpand = new System.Drawing.Point(0, 0);
            this.BLogin.ImageOffset = new System.Drawing.Point(0, 0);
            this.BLogin.Location = new System.Drawing.Point(51, 281);
            this.BLogin.Name = "BLogin";
            this.BLogin.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BLogin.NormalForeColor = System.Drawing.Color.Black;
            this.BLogin.NormalImageTint = System.Drawing.Color.White;
            this.BLogin.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BLogin.OutlineThickness = 1F;
            this.BLogin.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.BLogin.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BLogin.PressedImageTint = System.Drawing.Color.White;
            this.BLogin.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BLogin.Rounding = new System.Windows.Forms.Padding(8);
            this.BLogin.Size = new System.Drawing.Size(193, 32);
            this.BLogin.TabIndex = 9;
            this.BLogin.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BLogin.TextOffset = new System.Drawing.Point(0, 0);
            this.BLogin.Click += new System.EventHandler(this.BLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(169, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 56);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ocio\r\nStore";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(294, 372);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CuoreUI.Controls.cuiButton BCancelar;
        private CuoreUI.Controls.cuiButton BLogin;
        private CuoreUI.Controls.cuiTextBox TUser;
        private CuoreUI.Controls.cuiTextBox TPass;
    }
}

