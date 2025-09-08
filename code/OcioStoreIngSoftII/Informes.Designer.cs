namespace OcioStoreIngSoftII
{
    partial class Informes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TLayoutCategories = new System.Windows.Forms.TableLayoutPanel();
            this.informesDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.cuiTextBox1 = new CuoreUI.Controls.cuiTextBox();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoInforme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaGenerado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Informe = new System.Windows.Forms.DataGridViewButtonColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TLayoutCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.informesDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1335, 797);
            this.panel1.TabIndex = 0;
            // 
            // TLayoutCategories
            // 
            this.TLayoutCategories.AutoScroll = true;
            this.TLayoutCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.TLayoutCategories.ColumnCount = 1;
            this.TLayoutCategories.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLayoutCategories.Controls.Add(this.informesDataGridView, 0, 1);
            this.TLayoutCategories.Controls.Add(this.panel2, 0, 0);
            this.TLayoutCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLayoutCategories.Location = new System.Drawing.Point(0, 0);
            this.TLayoutCategories.Name = "TLayoutCategories";
            this.TLayoutCategories.RowCount = 3;
            this.TLayoutCategories.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLayoutCategories.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TLayoutCategories.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLayoutCategories.Size = new System.Drawing.Size(1335, 797);
            this.TLayoutCategories.TabIndex = 2;
            // 
            // informesDataGridView
            // 
            this.informesDataGridView.AllowUserToAddRows = false;
            this.informesDataGridView.AllowUserToDeleteRows = false;
            this.informesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.informesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.informesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.informesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.informesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.informesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.tipoInforme,
            this.FechaGenerado,
            this.usuario,
            this.Informe,
            this.descripcion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.informesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.informesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informesDataGridView.EnableHeadersVisualStyles = false;
            this.informesDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.informesDataGridView.Location = new System.Drawing.Point(15, 162);
            this.informesDataGridView.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.informesDataGridView.MultiSelect = false;
            this.informesDataGridView.Name = "informesDataGridView";
            this.informesDataGridView.ReadOnly = true;
            this.informesDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.informesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.informesDataGridView.RowHeadersVisible = false;
            this.informesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.informesDataGridView.Size = new System.Drawing.Size(1305, 472);
            this.informesDataGridView.TabIndex = 58;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.cuiTextBox1);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1329, 153);
            this.panel2.TabIndex = 57;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 129;
            this.iconPictureBox1.Location = new System.Drawing.Point(360, 27);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(706, 129);
            this.iconPictureBox1.TabIndex = 12;
            this.iconPictureBox1.TabStop = false;
            // 
            // cuiTextBox1
            // 
            this.cuiTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.cuiTextBox1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cuiTextBox1.Content = "Informes";
            this.cuiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cuiTextBox1.FocusBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cuiTextBox1.FocusImageTint = System.Drawing.Color.White;
            this.cuiTextBox1.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiTextBox1.Font = new System.Drawing.Font("Segoe UI", 50F);
            this.cuiTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.cuiTextBox1.Image = null;
            this.cuiTextBox1.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiTextBox1.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiTextBox1.Location = new System.Drawing.Point(482, 40);
            this.cuiTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.cuiTextBox1.Multiline = false;
            this.cuiTextBox1.Name = "cuiTextBox1";
            this.cuiTextBox1.NormalImageTint = System.Drawing.Color.White;
            this.cuiTextBox1.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiTextBox1.Padding = new System.Windows.Forms.Padding(89, 2, 89, 0);
            this.cuiTextBox1.PasswordChar = false;
            this.cuiTextBox1.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.cuiTextBox1.PlaceholderText = "";
            this.cuiTextBox1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiTextBox1.Size = new System.Drawing.Size(438, 93);
            this.cuiTextBox1.TabIndex = 13;
            this.cuiTextBox1.TextOffset = new System.Drawing.Size(0, 0);
            this.cuiTextBox1.UnderlinedStyle = true;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // tipoInforme
            // 
            this.tipoInforme.HeaderText = "Tipo de Informe";
            this.tipoInforme.Name = "tipoInforme";
            this.tipoInforme.ReadOnly = true;
            // 
            // FechaGenerado
            // 
            this.FechaGenerado.HeaderText = "Fecha de Generación";
            this.FechaGenerado.Name = "FechaGenerado";
            this.FechaGenerado.ReadOnly = true;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Realizado por";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // Informe
            // 
            this.Informe.HeaderText = "Informe";
            this.Informe.Name = "Informe";
            this.Informe.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Visible = false;
            // 
            // Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 797);
            this.Controls.Add(this.TLayoutCategories);
            this.Controls.Add(this.panel1);
            this.Name = "Informes";
            this.Text = "Informes";
            this.Load += new System.EventHandler(this.Informes_Load);
            this.TLayoutCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.informesDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel TLayoutCategories;
        private System.Windows.Forms.DataGridView informesDataGridView;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private CuoreUI.Controls.cuiTextBox cuiTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoInforme;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaGenerado;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewButtonColumn Informe;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
    }
}