namespace OcioStoreIngSoftII
{
    partial class BuscarVendedor
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
            this.BBuscar = new CuoreUI.Controls.cuiButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvVendedores = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teléfono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LayoutUsuarios = new System.Windows.Forms.TableLayoutPanel();
            this.dataSet1 = new OcioStoreIngSoftII.DataSet1();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).BeginInit();
            this.LayoutUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1723, 115);
            this.panel1.TabIndex = 57;
            // 
            // BBuscar
            // 
            this.BBuscar.CheckButton = false;
            this.BBuscar.Checked = false;
            this.BBuscar.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.BBuscar.CheckedForeColor = System.Drawing.Color.White;
            this.BBuscar.CheckedImageTint = System.Drawing.Color.White;
            this.BBuscar.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.BBuscar.Content = "Buscar";
            this.BBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBuscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BBuscar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BBuscar.ForeColor = System.Drawing.Color.Black;
            this.BBuscar.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.BBuscar.HoverForeColor = System.Drawing.Color.White;
            this.BBuscar.HoverImageTint = System.Drawing.Color.White;
            this.BBuscar.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BBuscar.Image = null;
            this.BBuscar.ImageAutoCenter = true;
            this.BBuscar.ImageExpand = new System.Drawing.Point(0, 0);
            this.BBuscar.ImageOffset = new System.Drawing.Point(0, 0);
            this.BBuscar.Location = new System.Drawing.Point(363, 49);
            this.BBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.NormalBackground = System.Drawing.Color.White;
            this.BBuscar.NormalForeColor = System.Drawing.Color.Black;
            this.BBuscar.NormalImageTint = System.Drawing.Color.White;
            this.BBuscar.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BBuscar.OutlineThickness = 1F;
            this.BBuscar.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.BBuscar.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BBuscar.PressedImageTint = System.Drawing.Color.White;
            this.BBuscar.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BBuscar.Rounding = new System.Windows.Forms.Padding(8);
            this.BBuscar.Size = new System.Drawing.Size(121, 36);
            this.BBuscar.TabIndex = 10;
            this.BBuscar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BBuscar.TextOffset = new System.Drawing.Point(0, 0);
            this.BBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(28, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar Vendedores";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(23, 49);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(309, 34);
            this.txtBuscar.TabIndex = 5;
            // 
            // dgvVendedores
            // 
            this.dgvVendedores.AllowUserToAddRows = false;
            this.dgvVendedores.AllowUserToDeleteRows = false;
            this.dgvVendedores.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVendedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVendedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.id_user,
            this.rol,
            this.apellido,
            this.nombre,
            this.dni,
            this.user,
            this.pass,
            this.estadoValor,
            this.estado,
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
            this.dgvVendedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVendedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVendedores.EnableHeadersVisualStyles = false;
            this.dgvVendedores.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvVendedores.Location = new System.Drawing.Point(20, 127);
            this.dgvVendedores.Margin = new System.Windows.Forms.Padding(20, 4, 20, 4);
            this.dgvVendedores.MultiSelect = false;
            this.dgvVendedores.Name = "dgvVendedores";
            this.dgvVendedores.ReadOnly = true;
            this.dgvVendedores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVendedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVendedores.RowHeadersVisible = false;
            this.dgvVendedores.RowHeadersWidth = 51;
            this.dgvVendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendedores.Size = new System.Drawing.Size(1691, 822);
            this.dgvVendedores.TabIndex = 58;
            this.dgvVendedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendedores_CellContentClick);
            this.dgvVendedores.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvVendedores_CellPainting);
            this.dgvVendedores.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvVendedores_DataBindingComplete);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.btnSeleccionar.HeaderText = "Seleccionar";
            this.btnSeleccionar.MinimumWidth = 110;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnSeleccionar.Width = 140;
            // 
            // id_user
            // 
            this.id_user.DataPropertyName = "id_user";
            this.id_user.HeaderText = "ID de Usuario";
            this.id_user.MinimumWidth = 60;
            this.id_user.Name = "id_user";
            this.id_user.ReadOnly = true;
            this.id_user.Visible = false;
            this.id_user.Width = 110;
            // 
            // rol
            // 
            this.rol.DataPropertyName = "NombreRol";
            this.rol.HeaderText = "Tipo de Rol";
            this.rol.MinimumWidth = 110;
            this.rol.Name = "rol";
            this.rol.ReadOnly = true;
            this.rol.Width = 110;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.MinimumWidth = 110;
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 110;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 110;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 110;
            // 
            // dni
            // 
            this.dni.DataPropertyName = "dni";
            this.dni.HeaderText = "DNI";
            this.dni.MinimumWidth = 110;
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            this.dni.Width = 110;
            // 
            // user
            // 
            this.user.DataPropertyName = "username";
            this.user.HeaderText = "Usuario";
            this.user.MinimumWidth = 110;
            this.user.Name = "user";
            this.user.ReadOnly = true;
            this.user.Width = 110;
            // 
            // pass
            // 
            this.pass.DataPropertyName = "pass";
            this.pass.HeaderText = "Contraseña";
            this.pass.MinimumWidth = 110;
            this.pass.Name = "pass";
            this.pass.ReadOnly = true;
            this.pass.Visible = false;
            this.pass.Width = 110;
            // 
            // estadoValor
            // 
            this.estadoValor.DataPropertyName = "baja_user";
            this.estadoValor.HeaderText = "baja_user";
            this.estadoValor.MinimumWidth = 110;
            this.estadoValor.Name = "estadoValor";
            this.estadoValor.ReadOnly = true;
            this.estadoValor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estadoValor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.estadoValor.Visible = false;
            this.estadoValor.Width = 110;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 110;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.estado.Width = 110;
            // 
            // email
            // 
            this.email.DataPropertyName = "mail";
            this.email.HeaderText = "E-Mail";
            this.email.MinimumWidth = 110;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 110;
            // 
            // Teléfono
            // 
            this.Teléfono.DataPropertyName = "telefono_user";
            this.Teléfono.HeaderText = "Teléfono";
            this.Teléfono.MinimumWidth = 110;
            this.Teléfono.Name = "Teléfono";
            this.Teléfono.ReadOnly = true;
            this.Teléfono.Width = 110;
            // 
            // Dirección
            // 
            this.Dirección.DataPropertyName = "direccion_user";
            this.Dirección.HeaderText = "Dirección";
            this.Dirección.MinimumWidth = 110;
            this.Dirección.Name = "Dirección";
            this.Dirección.ReadOnly = true;
            this.Dirección.Width = 110;
            // 
            // Localidad
            // 
            this.Localidad.DataPropertyName = "localidad_user";
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.MinimumWidth = 110;
            this.Localidad.Name = "Localidad";
            this.Localidad.ReadOnly = true;
            this.Localidad.Width = 110;
            // 
            // Provincia
            // 
            this.Provincia.DataPropertyName = "provincia_user";
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.MinimumWidth = 110;
            this.Provincia.Name = "Provincia";
            this.Provincia.ReadOnly = true;
            this.Provincia.Width = 110;
            // 
            // LayoutUsuarios
            // 
            this.LayoutUsuarios.AutoScroll = true;
            this.LayoutUsuarios.ColumnCount = 1;
            this.LayoutUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutUsuarios.Controls.Add(this.dgvVendedores, 0, 1);
            this.LayoutUsuarios.Controls.Add(this.panel1, 0, 0);
            this.LayoutUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutUsuarios.Location = new System.Drawing.Point(0, 0);
            this.LayoutUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.LayoutUsuarios.Name = "LayoutUsuarios";
            this.LayoutUsuarios.RowCount = 2;
            this.LayoutUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.LayoutUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 492F));
            this.LayoutUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LayoutUsuarios.Size = new System.Drawing.Size(1731, 953);
            this.LayoutUsuarios.TabIndex = 1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BuscarVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1385, 762);
            this.Controls.Add(this.LayoutUsuarios);
            this.KeyPreview = true;
            this.Name = "BuscarVendedor";
            this.Text = "BuscarVendedor";
            this.Load += new System.EventHandler(this.BuscarVendedor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BuscarVendedor_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).EndInit();
            this.LayoutUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.Panel panel1;
        private CuoreUI.Controls.cuiButton BBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvVendedores;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teléfono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dirección;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.TableLayoutPanel LayoutUsuarios;
    }
}