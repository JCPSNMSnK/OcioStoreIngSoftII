namespace OcioStoreIngSoftII
{
    partial class Categories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataSet1 = new OcioStoreIngSoftII.DataSet1();
            this.TCUsuarios = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.categoriasDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BBuscar = new CuoreUI.Controls.cuiButton();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.baja_estado_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baja_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.LEstado = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LModificarEstado = new System.Windows.Forms.Label();
            this.CBModificarEstado = new System.Windows.Forms.ComboBox();
            this.LModificarNombre = new System.Windows.Forms.Label();
            this.BRegisterUser = new CuoreUI.Controls.cuiButton();
            this.TNombre = new CuoreUI.Controls.cuiTextBox();
            this.TBModificarIndice = new CuoreUI.Controls.cuiTextBox();
            this.TModificarID_user = new CuoreUI.Controls.cuiTextBox();
            this.TID_user = new CuoreUI.Controls.cuiTextBox();
            this.TIndice = new CuoreUI.Controls.cuiTextBox();
            this.BModificar = new CuoreUI.Controls.cuiButton();
            this.TModificarNombre = new CuoreUI.Controls.cuiTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.TCUsuarios.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TCUsuarios
            // 
            this.TCUsuarios.AllowDrop = true;
            this.TCUsuarios.Controls.Add(this.tabPage1);
            this.TCUsuarios.Controls.Add(this.tabPage2);
            this.TCUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCUsuarios.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCUsuarios.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TCUsuarios.Location = new System.Drawing.Point(3, 427);
            this.TCUsuarios.Multiline = true;
            this.TCUsuarios.Name = "TCUsuarios";
            this.TCUsuarios.SelectedIndex = 0;
            this.TCUsuarios.Size = new System.Drawing.Size(1211, 273);
            this.TCUsuarios.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1203, 240);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alta de Categoría";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1203, 240);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Categoría";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1211, 78);
            this.panel1.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(8, 40);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(232, 29);
            this.txtBuscar.TabIndex = 5;
            // 
            // categoriasDataGridView
            // 
            this.categoriasDataGridView.AllowUserToAddRows = false;
            this.categoriasDataGridView.AllowUserToDeleteRows = false;
            this.categoriasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoriasDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.categoriasDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoriasDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.categoriasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.baja_estado_valor,
            this.baja_estado,
            this.nombre_categoria,
            this.id_categoria,
            this.cantidad_categoria});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categoriasDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.categoriasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriasDataGridView.EnableHeadersVisualStyles = false;
            this.categoriasDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.categoriasDataGridView.Location = new System.Drawing.Point(15, 87);
            this.categoriasDataGridView.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.categoriasDataGridView.Name = "categoriasDataGridView";
            this.categoriasDataGridView.ReadOnly = true;
            this.categoriasDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoriasDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.categoriasDataGridView.RowHeadersVisible = false;
            this.categoriasDataGridView.Size = new System.Drawing.Size(1187, 334);
            this.categoriasDataGridView.TabIndex = 58;
            this.categoriasDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoriasDataGridView_CellContentClick);
            this.categoriasDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.categoriasDataGridView_CellPainting);
            this.categoriasDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.categoriasDataGridView_DataBindingComplete);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.categoriasDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TCUsuarios, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.06395F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.5064F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.54481F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1217, 703);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.BBuscar.Location = new System.Drawing.Point(266, 40);
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
            this.BBuscar.Size = new System.Drawing.Size(91, 29);
            this.BBuscar.TabIndex = 11;
            this.BBuscar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BBuscar.TextOffset = new System.Drawing.Point(0, 0);
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            this.BBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Users_KeyDown);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.btnSeleccionar.HeaderText = "Seleccionar";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnSeleccionar.Width = 112;
            // 
            // baja_estado_valor
            // 
            this.baja_estado_valor.DataPropertyName = "baja_categoria";
            this.baja_estado_valor.HeaderText = "baja_categoria";
            this.baja_estado_valor.Name = "baja_estado_valor";
            this.baja_estado_valor.ReadOnly = true;
            this.baja_estado_valor.Visible = false;
            // 
            // baja_estado
            // 
            this.baja_estado.HeaderText = "Dado de baja?";
            this.baja_estado.Name = "baja_estado";
            this.baja_estado.ReadOnly = true;
            // 
            // nombre_categoria
            // 
            this.nombre_categoria.HeaderText = "Nombre de Categoria";
            this.nombre_categoria.Name = "nombre_categoria";
            this.nombre_categoria.ReadOnly = true;
            // 
            // id_categoria
            // 
            this.id_categoria.HeaderText = "id_categoria";
            this.id_categoria.Name = "id_categoria";
            this.id_categoria.ReadOnly = true;
            this.id_categoria.Visible = false;
            // 
            // cantidad_categoria
            // 
            this.cantidad_categoria.HeaderText = "Cantidad de Productos";
            this.cantidad_categoria.Name = "cantidad_categoria";
            this.cantidad_categoria.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TID_user);
            this.panel2.Controls.Add(this.TIndice);
            this.panel2.Controls.Add(this.TNombre);
            this.panel2.Controls.Add(this.BRegisterUser);
            this.panel2.Controls.Add(this.CBEstado);
            this.panel2.Controls.Add(this.LEstado);
            this.panel2.Controls.Add(this.LNombre);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1197, 234);
            this.panel2.TabIndex = 0;
            // 
            // CBEstado
            // 
            this.CBEstado.BackColor = System.Drawing.SystemColors.Window;
            this.CBEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Location = new System.Drawing.Point(588, 76);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(232, 29);
            this.CBEstado.TabIndex = 60;
            // 
            // LEstado
            // 
            this.LEstado.AutoSize = true;
            this.LEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LEstado.Location = new System.Drawing.Point(588, 52);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(56, 21);
            this.LEstado.TabIndex = 59;
            this.LEstado.Text = "Estado";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LNombre.Location = new System.Drawing.Point(316, 52);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(68, 21);
            this.LNombre.TabIndex = 56;
            this.LNombre.Text = "Nombre";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TModificarNombre);
            this.panel3.Controls.Add(this.BModificar);
            this.panel3.Controls.Add(this.TModificarID_user);
            this.panel3.Controls.Add(this.TBModificarIndice);
            this.panel3.Controls.Add(this.LModificarEstado);
            this.panel3.Controls.Add(this.CBModificarEstado);
            this.panel3.Controls.Add(this.LModificarNombre);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1197, 234);
            this.panel3.TabIndex = 0;
            // 
            // LModificarEstado
            // 
            this.LModificarEstado.AutoSize = true;
            this.LModificarEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LModificarEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarEstado.Location = new System.Drawing.Point(588, 52);
            this.LModificarEstado.Name = "LModificarEstado";
            this.LModificarEstado.Size = new System.Drawing.Size(56, 21);
            this.LModificarEstado.TabIndex = 57;
            this.LModificarEstado.Text = "Estado";
            // 
            // CBModificarEstado
            // 
            this.CBModificarEstado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CBModificarEstado.DisplayMember = "estado";
            this.CBModificarEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBModificarEstado.FormattingEnabled = true;
            this.CBModificarEstado.Location = new System.Drawing.Point(588, 76);
            this.CBModificarEstado.Name = "CBModificarEstado";
            this.CBModificarEstado.Size = new System.Drawing.Size(232, 29);
            this.CBModificarEstado.TabIndex = 56;
            this.CBModificarEstado.ValueMember = "estado";
            // 
            // LModificarNombre
            // 
            this.LModificarNombre.AutoSize = true;
            this.LModificarNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LModificarNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarNombre.Location = new System.Drawing.Point(316, 52);
            this.LModificarNombre.Name = "LModificarNombre";
            this.LModificarNombre.Size = new System.Drawing.Size(68, 21);
            this.LModificarNombre.TabIndex = 54;
            this.LModificarNombre.Text = "Nombre";
            // 
            // BRegisterUser
            // 
            this.BRegisterUser.CheckButton = false;
            this.BRegisterUser.Checked = false;
            this.BRegisterUser.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.BRegisterUser.CheckedForeColor = System.Drawing.Color.White;
            this.BRegisterUser.CheckedImageTint = System.Drawing.Color.White;
            this.BRegisterUser.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.BRegisterUser.Content = "Registrar Categoría";
            this.BRegisterUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BRegisterUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BRegisterUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRegisterUser.ForeColor = System.Drawing.Color.White;
            this.BRegisterUser.HoverBackground = System.Drawing.Color.White;
            this.BRegisterUser.HoverForeColor = System.Drawing.Color.Black;
            this.BRegisterUser.HoverImageTint = System.Drawing.Color.White;
            this.BRegisterUser.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BRegisterUser.Image = null;
            this.BRegisterUser.ImageAutoCenter = true;
            this.BRegisterUser.ImageExpand = new System.Drawing.Point(0, 0);
            this.BRegisterUser.ImageOffset = new System.Drawing.Point(0, 0);
            this.BRegisterUser.Location = new System.Drawing.Point(476, 124);
            this.BRegisterUser.Name = "BRegisterUser";
            this.BRegisterUser.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.BRegisterUser.NormalForeColor = System.Drawing.Color.White;
            this.BRegisterUser.NormalImageTint = System.Drawing.Color.White;
            this.BRegisterUser.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BRegisterUser.OutlineThickness = 1F;
            this.BRegisterUser.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.BRegisterUser.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BRegisterUser.PressedImageTint = System.Drawing.Color.White;
            this.BRegisterUser.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BRegisterUser.Rounding = new System.Windows.Forms.Padding(8);
            this.BRegisterUser.Size = new System.Drawing.Size(168, 32);
            this.BRegisterUser.TabIndex = 63;
            this.BRegisterUser.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BRegisterUser.TextOffset = new System.Drawing.Point(0, 0);
            this.BRegisterUser.Click += new System.EventHandler(this.BRegisterCategory_Click);
            // 
            // TNombre
            // 
            this.TNombre.BackgroundColor = System.Drawing.Color.White;
            this.TNombre.Content = "";
            this.TNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TNombre.FocusBackgroundColor = System.Drawing.Color.White;
            this.TNombre.FocusImageTint = System.Drawing.Color.White;
            this.TNombre.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNombre.ForeColor = System.Drawing.Color.Gray;
            this.TNombre.Image = null;
            this.TNombre.ImageExpand = new System.Drawing.Point(0, 0);
            this.TNombre.ImageOffset = new System.Drawing.Point(0, 0);
            this.TNombre.Location = new System.Drawing.Point(316, 76);
            this.TNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TNombre.Multiline = false;
            this.TNombre.Name = "TNombre";
            this.TNombre.NormalImageTint = System.Drawing.Color.White;
            this.TNombre.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TNombre.Padding = new System.Windows.Forms.Padding(15, 7, 15, 0);
            this.TNombre.PasswordChar = false;
            this.TNombre.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.TNombre.PlaceholderText = "";
            this.TNombre.Rounding = new System.Windows.Forms.Padding(8);
            this.TNombre.Size = new System.Drawing.Size(233, 28);
            this.TNombre.TabIndex = 64;
            this.TNombre.TextOffset = new System.Drawing.Size(0, 0);
            this.TNombre.UnderlinedStyle = true;
            // 
            // TBModificarIndice
            // 
            this.TBModificarIndice.BackgroundColor = System.Drawing.Color.White;
            this.TBModificarIndice.Content = "-1";
            this.TBModificarIndice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBModificarIndice.FocusBackgroundColor = System.Drawing.Color.White;
            this.TBModificarIndice.FocusImageTint = System.Drawing.Color.White;
            this.TBModificarIndice.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TBModificarIndice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBModificarIndice.ForeColor = System.Drawing.Color.Gray;
            this.TBModificarIndice.Image = null;
            this.TBModificarIndice.ImageExpand = new System.Drawing.Point(0, 0);
            this.TBModificarIndice.ImageOffset = new System.Drawing.Point(0, 0);
            this.TBModificarIndice.Location = new System.Drawing.Point(245, 129);
            this.TBModificarIndice.Margin = new System.Windows.Forms.Padding(4);
            this.TBModificarIndice.Multiline = false;
            this.TBModificarIndice.Name = "TBModificarIndice";
            this.TBModificarIndice.NormalImageTint = System.Drawing.Color.White;
            this.TBModificarIndice.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TBModificarIndice.Padding = new System.Windows.Forms.Padding(15, 7, 15, 0);
            this.TBModificarIndice.PasswordChar = false;
            this.TBModificarIndice.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.TBModificarIndice.PlaceholderText = "";
            this.TBModificarIndice.Rounding = new System.Windows.Forms.Padding(8);
            this.TBModificarIndice.Size = new System.Drawing.Size(51, 28);
            this.TBModificarIndice.TabIndex = 108;
            this.TBModificarIndice.TextOffset = new System.Drawing.Size(0, 0);
            this.TBModificarIndice.UnderlinedStyle = true;
            this.TBModificarIndice.Visible = false;
            // 
            // TModificarID_user
            // 
            this.TModificarID_user.BackgroundColor = System.Drawing.Color.White;
            this.TModificarID_user.Content = "0";
            this.TModificarID_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TModificarID_user.FocusBackgroundColor = System.Drawing.Color.White;
            this.TModificarID_user.FocusImageTint = System.Drawing.Color.White;
            this.TModificarID_user.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TModificarID_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarID_user.ForeColor = System.Drawing.Color.Gray;
            this.TModificarID_user.Image = null;
            this.TModificarID_user.ImageExpand = new System.Drawing.Point(0, 0);
            this.TModificarID_user.ImageOffset = new System.Drawing.Point(0, 0);
            this.TModificarID_user.Location = new System.Drawing.Point(316, 129);
            this.TModificarID_user.Margin = new System.Windows.Forms.Padding(4);
            this.TModificarID_user.Multiline = false;
            this.TModificarID_user.Name = "TModificarID_user";
            this.TModificarID_user.NormalImageTint = System.Drawing.Color.White;
            this.TModificarID_user.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TModificarID_user.Padding = new System.Windows.Forms.Padding(15, 7, 15, 0);
            this.TModificarID_user.PasswordChar = false;
            this.TModificarID_user.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.TModificarID_user.PlaceholderText = "";
            this.TModificarID_user.Rounding = new System.Windows.Forms.Padding(8);
            this.TModificarID_user.Size = new System.Drawing.Size(51, 28);
            this.TModificarID_user.TabIndex = 110;
            this.TModificarID_user.TextOffset = new System.Drawing.Size(0, 0);
            this.TModificarID_user.UnderlinedStyle = true;
            this.TModificarID_user.Visible = false;
            // 
            // TID_user
            // 
            this.TID_user.BackgroundColor = System.Drawing.Color.White;
            this.TID_user.Content = "0";
            this.TID_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TID_user.FocusBackgroundColor = System.Drawing.Color.White;
            this.TID_user.FocusImageTint = System.Drawing.Color.White;
            this.TID_user.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TID_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TID_user.ForeColor = System.Drawing.Color.Gray;
            this.TID_user.Image = null;
            this.TID_user.ImageExpand = new System.Drawing.Point(0, 0);
            this.TID_user.ImageOffset = new System.Drawing.Point(0, 0);
            this.TID_user.Location = new System.Drawing.Point(316, 129);
            this.TID_user.Margin = new System.Windows.Forms.Padding(4);
            this.TID_user.Multiline = false;
            this.TID_user.Name = "TID_user";
            this.TID_user.NormalImageTint = System.Drawing.Color.White;
            this.TID_user.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TID_user.Padding = new System.Windows.Forms.Padding(15, 7, 15, 0);
            this.TID_user.PasswordChar = false;
            this.TID_user.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.TID_user.PlaceholderText = "";
            this.TID_user.Rounding = new System.Windows.Forms.Padding(8);
            this.TID_user.Size = new System.Drawing.Size(51, 28);
            this.TID_user.TabIndex = 112;
            this.TID_user.TextOffset = new System.Drawing.Size(0, 0);
            this.TID_user.UnderlinedStyle = true;
            this.TID_user.Visible = false;
            // 
            // TIndice
            // 
            this.TIndice.BackgroundColor = System.Drawing.Color.White;
            this.TIndice.Content = "-1";
            this.TIndice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TIndice.FocusBackgroundColor = System.Drawing.Color.White;
            this.TIndice.FocusImageTint = System.Drawing.Color.White;
            this.TIndice.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TIndice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIndice.ForeColor = System.Drawing.Color.Gray;
            this.TIndice.Image = null;
            this.TIndice.ImageExpand = new System.Drawing.Point(0, 0);
            this.TIndice.ImageOffset = new System.Drawing.Point(0, 0);
            this.TIndice.Location = new System.Drawing.Point(245, 129);
            this.TIndice.Margin = new System.Windows.Forms.Padding(4);
            this.TIndice.Multiline = false;
            this.TIndice.Name = "TIndice";
            this.TIndice.NormalImageTint = System.Drawing.Color.White;
            this.TIndice.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TIndice.Padding = new System.Windows.Forms.Padding(15, 7, 15, 0);
            this.TIndice.PasswordChar = false;
            this.TIndice.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.TIndice.PlaceholderText = "";
            this.TIndice.Rounding = new System.Windows.Forms.Padding(8);
            this.TIndice.Size = new System.Drawing.Size(51, 28);
            this.TIndice.TabIndex = 111;
            this.TIndice.TextOffset = new System.Drawing.Size(0, 0);
            this.TIndice.UnderlinedStyle = true;
            this.TIndice.Visible = false;
            // 
            // BModificar
            // 
            this.BModificar.CheckButton = false;
            this.BModificar.Checked = false;
            this.BModificar.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.BModificar.CheckedForeColor = System.Drawing.Color.White;
            this.BModificar.CheckedImageTint = System.Drawing.Color.White;
            this.BModificar.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.BModificar.Content = "Modificar Categoría";
            this.BModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BModificar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BModificar.ForeColor = System.Drawing.Color.White;
            this.BModificar.HoverBackground = System.Drawing.Color.White;
            this.BModificar.HoverForeColor = System.Drawing.Color.Black;
            this.BModificar.HoverImageTint = System.Drawing.Color.White;
            this.BModificar.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BModificar.Image = null;
            this.BModificar.ImageAutoCenter = true;
            this.BModificar.ImageExpand = new System.Drawing.Point(0, 0);
            this.BModificar.ImageOffset = new System.Drawing.Point(0, 0);
            this.BModificar.Location = new System.Drawing.Point(476, 124);
            this.BModificar.Name = "BModificar";
            this.BModificar.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.BModificar.NormalForeColor = System.Drawing.Color.White;
            this.BModificar.NormalImageTint = System.Drawing.Color.White;
            this.BModificar.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BModificar.OutlineThickness = 1F;
            this.BModificar.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.BModificar.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BModificar.PressedImageTint = System.Drawing.Color.White;
            this.BModificar.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BModificar.Rounding = new System.Windows.Forms.Padding(8);
            this.BModificar.Size = new System.Drawing.Size(168, 32);
            this.BModificar.TabIndex = 111;
            this.BModificar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BModificar.TextOffset = new System.Drawing.Point(0, 0);
            this.BModificar.Click += new System.EventHandler(this.BModificar_Click);
            // 
            // TModificarNombre
            // 
            this.TModificarNombre.BackgroundColor = System.Drawing.Color.White;
            this.TModificarNombre.Content = "";
            this.TModificarNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TModificarNombre.FocusBackgroundColor = System.Drawing.Color.White;
            this.TModificarNombre.FocusImageTint = System.Drawing.Color.White;
            this.TModificarNombre.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TModificarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarNombre.ForeColor = System.Drawing.Color.Gray;
            this.TModificarNombre.Image = null;
            this.TModificarNombre.ImageExpand = new System.Drawing.Point(0, 0);
            this.TModificarNombre.ImageOffset = new System.Drawing.Point(0, 0);
            this.TModificarNombre.Location = new System.Drawing.Point(316, 76);
            this.TModificarNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TModificarNombre.Multiline = false;
            this.TModificarNombre.Name = "TModificarNombre";
            this.TModificarNombre.NormalImageTint = System.Drawing.Color.White;
            this.TModificarNombre.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TModificarNombre.Padding = new System.Windows.Forms.Padding(15, 7, 15, 0);
            this.TModificarNombre.PasswordChar = false;
            this.TModificarNombre.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.TModificarNombre.PlaceholderText = "";
            this.TModificarNombre.Rounding = new System.Windows.Forms.Padding(8);
            this.TModificarNombre.Size = new System.Drawing.Size(233, 28);
            this.TModificarNombre.TabIndex = 112;
            this.TModificarNombre.TextOffset = new System.Drawing.Size(0, 0);
            this.TModificarNombre.UnderlinedStyle = true;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1217, 703);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Categories";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.TCUsuarios.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.TabControl TCUsuarios;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView categoriasDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CuoreUI.Controls.cuiButton BBuscar;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn baja_estado_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn baja_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_categoria;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.Label LEstado;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LModificarEstado;
        private System.Windows.Forms.ComboBox CBModificarEstado;
        private System.Windows.Forms.Label LModificarNombre;
        private CuoreUI.Controls.cuiButton BRegisterUser;
        private CuoreUI.Controls.cuiTextBox TNombre;
        private CuoreUI.Controls.cuiTextBox TBModificarIndice;
        private CuoreUI.Controls.cuiTextBox TID_user;
        private CuoreUI.Controls.cuiTextBox TIndice;
        private CuoreUI.Controls.cuiTextBox TModificarID_user;
        private CuoreUI.Controls.cuiButton BModificar;
        private CuoreUI.Controls.cuiTextBox TModificarNombre;
    }
}