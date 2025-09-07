namespace OcioStoreIngSoftII
{
    partial class AvisoStockMinimo
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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnCerrarNotificacion = new FontAwesome.Sharp.IconButton();
            this.lblMensaje = new CuoreUI.Controls.cuiLabel();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(208)))), ((int)(((byte)(237)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CircleExclamation;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 47;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 52);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(50, 47);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // btnCerrarNotificacion
            // 
            this.btnCerrarNotificacion.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCerrarNotificacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCerrarNotificacion.FlatAppearance.BorderSize = 0;
            this.btnCerrarNotificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarNotificacion.IconChar = FontAwesome.Sharp.IconChar.SquareXmark;
            this.btnCerrarNotificacion.IconColor = System.Drawing.Color.Black;
            this.btnCerrarNotificacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarNotificacion.IconSize = 32;
            this.btnCerrarNotificacion.Location = new System.Drawing.Point(318, 0);
            this.btnCerrarNotificacion.Name = "btnCerrarNotificacion";
            this.btnCerrarNotificacion.Size = new System.Drawing.Size(42, 24);
            this.btnCerrarNotificacion.TabIndex = 1;
            this.btnCerrarNotificacion.UseVisualStyleBackColor = false;
            this.btnCerrarNotificacion.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Content = "Notificación";
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblMensaje.Location = new System.Drawing.Point(61, 19);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(10);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Padding = new System.Windows.Forms.Padding(10);
            this.lblMensaje.Size = new System.Drawing.Size(280, 119);
            this.lblMensaje.TabIndex = 2;
            this.lblMensaje.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // AvisoStockMinimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(208)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(360, 150);
            this.Controls.Add(this.btnCerrarNotificacion);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.iconPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AvisoStockMinimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AvisoStockMinimo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AvisoStockMinimo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnCerrarNotificacion;
        private CuoreUI.Controls.cuiLabel lblMensaje;
    }
}