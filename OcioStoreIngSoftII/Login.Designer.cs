namespace ProyectoTallerG8
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
            this.BCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BLogin = new System.Windows.Forms.Button();
            this.TPass = new System.Windows.Forms.TextBox();
            this.LPass = new System.Windows.Forms.Label();
            this.TUser = new System.Windows.Forms.TextBox();
            this.LUser = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.BCancelar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BLogin);
            this.panel1.Controls.Add(this.TPass);
            this.panel1.Controls.Add(this.LPass);
            this.panel1.Controls.Add(this.TUser);
            this.panel1.Controls.Add(this.LUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 372);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_2);
            // 
            // BCancelar
            // 
            this.BCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.BCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BCancelar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.ForeColor = System.Drawing.Color.White;
            this.BCancelar.Location = new System.Drawing.Point(51, 319);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(193, 32);
            this.BCancelar.TabIndex = 8;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = false;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(146, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 50);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sistema de\r\nAdministración";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // BLogin
            // 
            this.BLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BLogin.BackColor = System.Drawing.Color.Gray;
            this.BLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BLogin.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLogin.ForeColor = System.Drawing.Color.White;
            this.BLogin.Location = new System.Drawing.Point(51, 281);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(193, 32);
            this.BLogin.TabIndex = 5;
            this.BLogin.Text = "Iniciar Sesión";
            this.BLogin.UseVisualStyleBackColor = false;
            this.BLogin.Click += new System.EventHandler(this.BLogin_Click_1);
            // 
            // TPass
            // 
            this.TPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TPass.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPass.ForeColor = System.Drawing.Color.Black;
            this.TPass.Location = new System.Drawing.Point(51, 232);
            this.TPass.Name = "TPass";
            this.TPass.Size = new System.Drawing.Size(193, 27);
            this.TPass.TabIndex = 3;
            this.TPass.UseSystemPasswordChar = true;
            // 
            // LPass
            // 
            this.LPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LPass.AutoSize = true;
            this.LPass.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LPass.Location = new System.Drawing.Point(47, 206);
            this.LPass.Name = "LPass";
            this.LPass.Size = new System.Drawing.Size(82, 23);
            this.LPass.TabIndex = 2;
            this.LPass.Text = "Contraseña";
            // 
            // TUser
            // 
            this.TUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TUser.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TUser.ForeColor = System.Drawing.Color.Black;
            this.TUser.Location = new System.Drawing.Point(51, 176);
            this.TUser.Name = "TUser";
            this.TUser.Size = new System.Drawing.Size(193, 27);
            this.TUser.TabIndex = 1;
            // 
            // LUser
            // 
            this.LUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LUser.AutoSize = true;
            this.LUser.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LUser.Location = new System.Drawing.Point(47, 150);
            this.LUser.Name = "LUser";
            this.LUser.Size = new System.Drawing.Size(58, 23);
            this.LUser.TabIndex = 0;
            this.LUser.Text = "Usuario";
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
        private System.Windows.Forms.Button BLogin;
        private System.Windows.Forms.TextBox TPass;
        private System.Windows.Forms.Label LPass;
        private System.Windows.Forms.TextBox TUser;
        private System.Windows.Forms.Label LUser;
        private System.Windows.Forms.Button BCancelar;
    }
}

