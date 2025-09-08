namespace OcioStoreIngSoftII
{
    partial class BuscarCliente
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
            this.ClientesDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teléfono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelScrollClientes = new System.Windows.Forms.Panel();
            this.LayoutClientes = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BBuscarCliente = new CuoreUI.Controls.cuiButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDataGridView)).BeginInit();
            this.panelScrollClientes.SuspendLayout();
            this.LayoutClientes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientesDataGridView
            // 
            this.ClientesDataGridView.AllowUserToAddRows = false;
            this.ClientesDataGridView.AllowUserToDeleteRows = false;
            this.ClientesDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ClientesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.ID_Cliente,
            this.apellido,
            this.nombre,
            this.dni,
            this.email,
            this.Teléfono,
            this.Dirección,
            this.Localidad,
            this.Provincia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClientesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientesDataGridView.EnableHeadersVisualStyles = false;
            this.ClientesDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ClientesDataGridView.Margin = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.ClientesDataGridView.MultiSelect = false;
            this.ClientesDataGridView.Name = "ClientesDataGridView";
            this.ClientesDataGridView.ReadOnly = true;
            this.ClientesDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ClientesDataGridView.RowHeadersVisible = false;
            this.ClientesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientesDataGridView.Size = new System.Drawing.Size(777, 394);
            this.ClientesDataGridView.TabIndex = 59;
            this.ClientesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientesDataGridView_CellContentClick);
            this.ClientesDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.ClientesDataGridView_CellPainting);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.btnSeleccionar.HeaderText = "Seleccionar";
            this.btnSeleccionar.MinimumWidth = 120;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnSeleccionar.Width = 128;
            // 
            // ID_Cliente
            // 
            this.ID_Cliente.DataPropertyName = "id_cliente";
            this.ID_Cliente.HeaderText = "ID de Cliente";
            this.ID_Cliente.MinimumWidth = 120;
            this.ID_Cliente.Name = "ID_Cliente";
            this.ID_Cliente.ReadOnly = true;
            this.ID_Cliente.Visible = false;
            this.ID_Cliente.Width = 120;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido_cliente";
            this.apellido.HeaderText = "Apellido";
            this.apellido.MinimumWidth = 120;
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 120;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre_cliente";
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 120;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 120;
            // 
            // dni
            // 
            this.dni.DataPropertyName = "dni_cliente";
            this.dni.HeaderText = "DNI";
            this.dni.MinimumWidth = 120;
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            this.dni.Width = 120;
            // 
            // email
            // 
            this.email.DataPropertyName = "email_cliente";
            this.email.HeaderText = "E-Mail";
            this.email.MinimumWidth = 120;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 120;
            // 
            // Teléfono
            // 
            this.Teléfono.DataPropertyName = "telefono_cliente";
            this.Teléfono.HeaderText = "Teléfono";
            this.Teléfono.MinimumWidth = 120;
            this.Teléfono.Name = "Teléfono";
            this.Teléfono.ReadOnly = true;
            this.Teléfono.Width = 120;
            // 
            // Dirección
            // 
            this.Dirección.DataPropertyName = "direccion_cliente";
            this.Dirección.HeaderText = "Dirección";
            this.Dirección.MinimumWidth = 120;
            this.Dirección.Name = "Dirección";
            this.Dirección.ReadOnly = true;
            this.Dirección.Width = 120;
            // 
            // Localidad
            // 
            this.Localidad.DataPropertyName = "localidad_cliente";
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.MinimumWidth = 120;
            this.Localidad.Name = "Localidad";
            this.Localidad.ReadOnly = true;
            this.Localidad.Width = 120;
            // 
            // Provincia
            // 
            this.Provincia.DataPropertyName = "provincia_cliente";
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.MinimumWidth = 120;
            this.Provincia.Name = "Provincia";
            this.Provincia.ReadOnly = true;
            this.Provincia.Width = 120;
            // 
            // panelScrollClientes
            // 
            this.panelScrollClientes.AutoScroll = true;
            this.panelScrollClientes.Controls.Add(this.LayoutClientes);
            this.panelScrollClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScrollClientes.Location = new System.Drawing.Point(0, 0);
            this.panelScrollClientes.Name = "panelScrollClientes";
            this.panelScrollClientes.Size = new System.Drawing.Size(800, 450);
            this.panelScrollClientes.TabIndex = 1;
            // 
            // LayoutClientes
            // 
            this.LayoutClientes.AutoSize = true;
            this.LayoutClientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LayoutClientes.ColumnCount = 1;
            this.LayoutClientes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutClientes.Controls.Add(this.panel1, 0, 0);
            this.LayoutClientes.Controls.Add(this.panel2, 0, 1);
            this.LayoutClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.LayoutClientes.Location = new System.Drawing.Point(0, 0);
            this.LayoutClientes.Name = "LayoutClientes";
            this.LayoutClientes.RowCount = 2;
            this.LayoutClientes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.LayoutClientes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutClientes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LayoutClientes.Size = new System.Drawing.Size(783, 500);
            this.LayoutClientes.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BBuscarCliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 94);
            this.panel1.TabIndex = 0;
            // 
            // BBuscarCliente
            // 
            this.BBuscarCliente.CheckButton = false;
            this.BBuscarCliente.Checked = false;
            this.BBuscarCliente.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.BBuscarCliente.CheckedForeColor = System.Drawing.Color.White;
            this.BBuscarCliente.CheckedImageTint = System.Drawing.Color.White;
            this.BBuscarCliente.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.BBuscarCliente.Content = "Buscar";
            this.BBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBuscarCliente.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BBuscarCliente.ForeColor = System.Drawing.Color.Black;
            this.BBuscarCliente.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.BBuscarCliente.HoverForeColor = System.Drawing.Color.White;
            this.BBuscarCliente.HoverImageTint = System.Drawing.Color.White;
            this.BBuscarCliente.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BBuscarCliente.Image = null;
            this.BBuscarCliente.ImageAutoCenter = true;
            this.BBuscarCliente.ImageExpand = new System.Drawing.Point(0, 0);
            this.BBuscarCliente.ImageOffset = new System.Drawing.Point(0, 0);
            this.BBuscarCliente.Location = new System.Drawing.Point(272, 40);
            this.BBuscarCliente.Name = "BBuscarCliente";
            this.BBuscarCliente.NormalBackground = System.Drawing.Color.White;
            this.BBuscarCliente.NormalForeColor = System.Drawing.Color.Black;
            this.BBuscarCliente.NormalImageTint = System.Drawing.Color.White;
            this.BBuscarCliente.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BBuscarCliente.OutlineThickness = 1F;
            this.BBuscarCliente.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.BBuscarCliente.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BBuscarCliente.PressedImageTint = System.Drawing.Color.White;
            this.BBuscarCliente.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BBuscarCliente.Rounding = new System.Windows.Forms.Padding(8);
            this.BBuscarCliente.Size = new System.Drawing.Size(91, 29);
            this.BBuscarCliente.TabIndex = 13;
            this.BBuscarCliente.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BBuscarCliente.TextOffset = new System.Drawing.Point(0, 0);
            this.BBuscarCliente.Click += new System.EventHandler(this.BBuscarCliente_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(21, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Buscar Clientes";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(17, 40);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(232, 29);
            this.txtBuscar.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ClientesDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(777, 394);
            this.panel2.TabIndex = 1;
            // 
            // BuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelScrollClientes);
            this.Name = "BuscarCliente";
            this.Text = "BuscarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDataGridView)).EndInit();
            this.panelScrollClientes.ResumeLayout(false);
            this.panelScrollClientes.PerformLayout();
            this.LayoutClientes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView ClientesDataGridView;
        private System.Windows.Forms.Panel panelScrollClientes;
        private System.Windows.Forms.TableLayoutPanel LayoutClientes;
        private System.Windows.Forms.Panel panel1;
        private CuoreUI.Controls.cuiButton BBuscarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teléfono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dirección;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
    }
}