namespace OcioStoreIngSoftII
{
    partial class Proveedores
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.proveedoresDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BBuscar = new CuoreUI.Controls.cuiButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.TCUsuarios = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TCUITProveedor = new CuoreUI.Controls.cuiTextBox();
            this.LCUITProveedor = new System.Windows.Forms.Label();
            this.TTelefonoProveedor = new CuoreUI.Controls.cuiTextBox();
            this.LTelefonoProveedor = new System.Windows.Forms.Label();
            this.TIDProveedor = new CuoreUI.Controls.cuiTextBox();
            this.TIndice = new CuoreUI.Controls.cuiTextBox();
            this.TNombreProveedor = new CuoreUI.Controls.cuiTextBox();
            this.BRegistrarProveedor = new CuoreUI.Controls.cuiButton();
            this.LNombreProveedor = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TModificarCUITProveedor = new CuoreUI.Controls.cuiTextBox();
            this.LModificarCUITProveedor = new System.Windows.Forms.Label();
            this.TModificarTelefonoProveedor = new CuoreUI.Controls.cuiTextBox();
            this.LModificarTelefonoProveedor = new System.Windows.Forms.Label();
            this.TModificarNombreProveedor = new CuoreUI.Controls.cuiTextBox();
            this.BModificarrProveedor = new CuoreUI.Controls.cuiButton();
            this.LModificarNombreProveedor = new System.Windows.Forms.Label();
            this.TModificarIDProveedor = new CuoreUI.Controls.cuiTextBox();
            this.TBModificarIndice = new CuoreUI.Controls.cuiTextBox();
            this.dataSet1 = new OcioStoreIngSoftII.DataSet1();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.LEstado = new System.Windows.Forms.Label();
            this.LModificarEstado = new System.Windows.Forms.Label();
            this.CBModificarEstado = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.TCUsuarios.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.proveedoresDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TCUsuarios, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.06395F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.5064F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.54481F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1284, 749);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // proveedoresDataGridView
            // 
            this.proveedoresDataGridView.AllowUserToAddRows = false;
            this.proveedoresDataGridView.AllowUserToDeleteRows = false;
            this.proveedoresDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.proveedoresDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.proveedoresDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.proveedoresDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.proveedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proveedoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.id_proveedor,
            this.nombre_proveedor,
            this.cuit_proveedor,
            this.telefono_proveedor});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.proveedoresDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.proveedoresDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proveedoresDataGridView.EnableHeadersVisualStyles = false;
            this.proveedoresDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.proveedoresDataGridView.Location = new System.Drawing.Point(15, 93);
            this.proveedoresDataGridView.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.proveedoresDataGridView.Name = "proveedoresDataGridView";
            this.proveedoresDataGridView.ReadOnly = true;
            this.proveedoresDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.proveedoresDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.proveedoresDataGridView.RowHeadersVisible = false;
            this.proveedoresDataGridView.Size = new System.Drawing.Size(1254, 356);
            this.proveedoresDataGridView.TabIndex = 58;
            this.proveedoresDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.proveedoresDataGridView_CellContentClick);
            this.proveedoresDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.proveedoresDataGridView_CellPainting);
            this.proveedoresDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.proveedorsDataGridView_DataBindingComplete);
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
            // id_proveedor
            // 
            this.id_proveedor.DataPropertyName = "id_proveedor";
            this.id_proveedor.HeaderText = "Cod. Proveedor";
            this.id_proveedor.Name = "id_proveedor";
            this.id_proveedor.ReadOnly = true;
            // 
            // nombre_proveedor
            // 
            this.nombre_proveedor.DataPropertyName = "nombre_proveedor";
            this.nombre_proveedor.HeaderText = "Nombre de Proveedor";
            this.nombre_proveedor.Name = "nombre_proveedor";
            this.nombre_proveedor.ReadOnly = true;
            // 
            // cuit_proveedor
            // 
            this.cuit_proveedor.DataPropertyName = "cuit_proveedor";
            this.cuit_proveedor.HeaderText = "CUIT";
            this.cuit_proveedor.Name = "cuit_proveedor";
            this.cuit_proveedor.ReadOnly = true;
            // 
            // telefono_proveedor
            // 
            this.telefono_proveedor.HeaderText = "Teléfono";
            this.telefono_proveedor.Name = "telefono_proveedor";
            this.telefono_proveedor.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.BBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 84);
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
            // TCUsuarios
            // 
            this.TCUsuarios.AllowDrop = true;
            this.TCUsuarios.Controls.Add(this.tabPage1);
            this.TCUsuarios.Controls.Add(this.tabPage2);
            this.TCUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCUsuarios.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCUsuarios.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TCUsuarios.Location = new System.Drawing.Point(3, 455);
            this.TCUsuarios.Multiline = true;
            this.TCUsuarios.Name = "TCUsuarios";
            this.TCUsuarios.SelectedIndex = 0;
            this.TCUsuarios.Size = new System.Drawing.Size(1278, 291);
            this.TCUsuarios.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1270, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alta de Proveedor";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CBEstado);
            this.panel2.Controls.Add(this.LEstado);
            this.panel2.Controls.Add(this.TCUITProveedor);
            this.panel2.Controls.Add(this.LCUITProveedor);
            this.panel2.Controls.Add(this.TTelefonoProveedor);
            this.panel2.Controls.Add(this.LTelefonoProveedor);
            this.panel2.Controls.Add(this.TIDProveedor);
            this.panel2.Controls.Add(this.TIndice);
            this.panel2.Controls.Add(this.TNombreProveedor);
            this.panel2.Controls.Add(this.BRegistrarProveedor);
            this.panel2.Controls.Add(this.LNombreProveedor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1264, 252);
            this.panel2.TabIndex = 0;
            // 
            // TCUITProveedor
            // 
            this.TCUITProveedor.BackgroundColor = System.Drawing.Color.White;
            this.TCUITProveedor.Content = "";
            this.TCUITProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TCUITProveedor.FocusBackgroundColor = System.Drawing.Color.White;
            this.TCUITProveedor.FocusImageTint = System.Drawing.Color.White;
            this.TCUITProveedor.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TCUITProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCUITProveedor.ForeColor = System.Drawing.Color.Black;
            this.TCUITProveedor.Image = null;
            this.TCUITProveedor.ImageExpand = new System.Drawing.Point(0, 0);
            this.TCUITProveedor.ImageOffset = new System.Drawing.Point(0, 0);
            this.TCUITProveedor.Location = new System.Drawing.Point(344, 153);
            this.TCUITProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.TCUITProveedor.Multiline = false;
            this.TCUITProveedor.Name = "TCUITProveedor";
            this.TCUITProveedor.NormalImageTint = System.Drawing.Color.White;
            this.TCUITProveedor.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TCUITProveedor.Padding = new System.Windows.Forms.Padding(15, 7, 15, 0);
            this.TCUITProveedor.PasswordChar = false;
            this.TCUITProveedor.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.TCUITProveedor.PlaceholderText = "";
            this.TCUITProveedor.Rounding = new System.Windows.Forms.Padding(8);
            this.TCUITProveedor.Size = new System.Drawing.Size(233, 28);
            this.TCUITProveedor.TabIndex = 118;
            this.TCUITProveedor.TextOffset = new System.Drawing.Size(0, 0);
            this.TCUITProveedor.UnderlinedStyle = true;
            // 
            // LCUITProveedor
            // 
            this.LCUITProveedor.AutoSize = true;
            this.LCUITProveedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCUITProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LCUITProveedor.Location = new System.Drawing.Point(344, 129);
            this.LCUITProveedor.Name = "LCUITProveedor";
            this.LCUITProveedor.Size = new System.Drawing.Size(43, 21);
            this.LCUITProveedor.TabIndex = 117;
            this.LCUITProveedor.Text = "CUIT";
            // 
            // TTelefonoProveedor
            // 
            this.TTelefonoProveedor.BackgroundColor = System.Drawing.Color.White;
            this.TTelefonoProveedor.Content = "";
            this.TTelefonoProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TTelefonoProveedor.FocusBackgroundColor = System.Drawing.Color.White;
            this.TTelefonoProveedor.FocusImageTint = System.Drawing.Color.White;
            this.TTelefonoProveedor.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TTelefonoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTelefonoProveedor.ForeColor = System.Drawing.Color.Black;
            this.TTelefonoProveedor.Image = null;
            this.TTelefonoProveedor.ImageExpand = new System.Drawing.Point(0, 0);
            this.TTelefonoProveedor.ImageOffset = new System.Drawing.Point(0, 0);
            this.TTelefonoProveedor.Location = new System.Drawing.Point(618, 80);
            this.TTelefonoProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.TTelefonoProveedor.Multiline = false;
            this.TTelefonoProveedor.Name = "TTelefonoProveedor";
            this.TTelefonoProveedor.NormalImageTint = System.Drawing.Color.White;
            this.TTelefonoProveedor.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TTelefonoProveedor.Padding = new System.Windows.Forms.Padding(15, 7, 15, 0);
            this.TTelefonoProveedor.PasswordChar = false;
            this.TTelefonoProveedor.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.TTelefonoProveedor.PlaceholderText = "";
            this.TTelefonoProveedor.Rounding = new System.Windows.Forms.Padding(8);
            this.TTelefonoProveedor.Size = new System.Drawing.Size(233, 28);
            this.TTelefonoProveedor.TabIndex = 116;
            this.TTelefonoProveedor.TextOffset = new System.Drawing.Size(0, 0);
            this.TTelefonoProveedor.UnderlinedStyle = true;
            // 
            // LTelefonoProveedor
            // 
            this.LTelefonoProveedor.AutoSize = true;
            this.LTelefonoProveedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefonoProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LTelefonoProveedor.Location = new System.Drawing.Point(618, 56);
            this.LTelefonoProveedor.Name = "LTelefonoProveedor";
            this.LTelefonoProveedor.Size = new System.Drawing.Size(155, 21);
            this.LTelefonoProveedor.TabIndex = 115;
            this.LTelefonoProveedor.Text = "Teléfono de Contacto";
            // 
            // TIDProveedor
            // 
            this.TIDProveedor.BackgroundColor = System.Drawing.Color.White;
            this.TIDProveedor.Content = "0";
            this.TIDProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TIDProveedor.FocusBackgroundColor = System.Drawing.Color.White;
            this.TIDProveedor.FocusImageTint = System.Drawing.Color.White;
            this.TIDProveedor.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TIDProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIDProveedor.ForeColor = System.Drawing.Color.Gray;
            this.TIDProveedor.Image = null;
            this.TIDProveedor.ImageExpand = new System.Drawing.Point(0, 0);
            this.TIDProveedor.ImageOffset = new System.Drawing.Point(0, 0);
            this.TIDProveedor.Location = new System.Drawing.Point(84, 229);
            this.TIDProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.TIDProveedor.Multiline = false;
            this.TIDProveedor.Name = "TIDProveedor";
            this.TIDProveedor.NormalImageTint = System.Drawing.Color.White;
            this.TIDProveedor.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TIDProveedor.Padding = new System.Windows.Forms.Padding(15, 7, 15, 0);
            this.TIDProveedor.PasswordChar = false;
            this.TIDProveedor.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.TIDProveedor.PlaceholderText = "";
            this.TIDProveedor.Rounding = new System.Windows.Forms.Padding(8);
            this.TIDProveedor.Size = new System.Drawing.Size(51, 28);
            this.TIDProveedor.TabIndex = 112;
            this.TIDProveedor.TextOffset = new System.Drawing.Size(0, 0);
            this.TIDProveedor.UnderlinedStyle = true;
            this.TIDProveedor.Visible = false;
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
            this.TIndice.Location = new System.Drawing.Point(13, 229);
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
            // TNombreProveedor
            // 
            this.TNombreProveedor.BackgroundColor = System.Drawing.Color.White;
            this.TNombreProveedor.Content = "";
            this.TNombreProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TNombreProveedor.FocusBackgroundColor = System.Drawing.Color.White;
            this.TNombreProveedor.FocusImageTint = System.Drawing.Color.White;
            this.TNombreProveedor.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TNombreProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNombreProveedor.ForeColor = System.Drawing.Color.Black;
            this.TNombreProveedor.Image = null;
            this.TNombreProveedor.ImageExpand = new System.Drawing.Point(0, 0);
            this.TNombreProveedor.ImageOffset = new System.Drawing.Point(0, 0);
            this.TNombreProveedor.Location = new System.Drawing.Point(344, 80);
            this.TNombreProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.TNombreProveedor.Multiline = false;
            this.TNombreProveedor.Name = "TNombreProveedor";
            this.TNombreProveedor.NormalImageTint = System.Drawing.Color.White;
            this.TNombreProveedor.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TNombreProveedor.Padding = new System.Windows.Forms.Padding(15, 7, 15, 0);
            this.TNombreProveedor.PasswordChar = false;
            this.TNombreProveedor.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.TNombreProveedor.PlaceholderText = "";
            this.TNombreProveedor.Rounding = new System.Windows.Forms.Padding(8);
            this.TNombreProveedor.Size = new System.Drawing.Size(233, 28);
            this.TNombreProveedor.TabIndex = 64;
            this.TNombreProveedor.TextOffset = new System.Drawing.Size(0, 0);
            this.TNombreProveedor.UnderlinedStyle = true;
            // 
            // BRegistrarProveedor
            // 
            this.BRegistrarProveedor.CheckButton = false;
            this.BRegistrarProveedor.Checked = false;
            this.BRegistrarProveedor.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.BRegistrarProveedor.CheckedForeColor = System.Drawing.Color.White;
            this.BRegistrarProveedor.CheckedImageTint = System.Drawing.Color.White;
            this.BRegistrarProveedor.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.BRegistrarProveedor.Content = "Registrar Proveedor";
            this.BRegistrarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BRegistrarProveedor.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BRegistrarProveedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRegistrarProveedor.ForeColor = System.Drawing.Color.White;
            this.BRegistrarProveedor.HoverBackground = System.Drawing.Color.White;
            this.BRegistrarProveedor.HoverForeColor = System.Drawing.Color.Black;
            this.BRegistrarProveedor.HoverImageTint = System.Drawing.Color.White;
            this.BRegistrarProveedor.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BRegistrarProveedor.Image = null;
            this.BRegistrarProveedor.ImageAutoCenter = true;
            this.BRegistrarProveedor.ImageExpand = new System.Drawing.Point(0, 0);
            this.BRegistrarProveedor.ImageOffset = new System.Drawing.Point(0, 0);
            this.BRegistrarProveedor.Location = new System.Drawing.Point(506, 217);
            this.BRegistrarProveedor.Name = "BRegistrarProveedor";
            this.BRegistrarProveedor.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.BRegistrarProveedor.NormalForeColor = System.Drawing.Color.White;
            this.BRegistrarProveedor.NormalImageTint = System.Drawing.Color.White;
            this.BRegistrarProveedor.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BRegistrarProveedor.OutlineThickness = 1F;
            this.BRegistrarProveedor.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.BRegistrarProveedor.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BRegistrarProveedor.PressedImageTint = System.Drawing.Color.White;
            this.BRegistrarProveedor.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BRegistrarProveedor.Rounding = new System.Windows.Forms.Padding(8);
            this.BRegistrarProveedor.Size = new System.Drawing.Size(168, 32);
            this.BRegistrarProveedor.TabIndex = 63;
            this.BRegistrarProveedor.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BRegistrarProveedor.TextOffset = new System.Drawing.Point(0, 0);
            this.BRegistrarProveedor.Click += new System.EventHandler(this.BRegisterCategory_Click);
            // 
            // LNombreProveedor
            // 
            this.LNombreProveedor.AutoSize = true;
            this.LNombreProveedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LNombreProveedor.Location = new System.Drawing.Point(344, 56);
            this.LNombreProveedor.Name = "LNombreProveedor";
            this.LNombreProveedor.Size = new System.Drawing.Size(169, 21);
            this.LNombreProveedor.TabIndex = 56;
            this.LNombreProveedor.Text = "Nombre del Proveedor";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1270, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Proveedor";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LModificarEstado);
            this.panel3.Controls.Add(this.CBModificarEstado);
            this.panel3.Controls.Add(this.TModificarCUITProveedor);
            this.panel3.Controls.Add(this.LModificarCUITProveedor);
            this.panel3.Controls.Add(this.TModificarTelefonoProveedor);
            this.panel3.Controls.Add(this.LModificarTelefonoProveedor);
            this.panel3.Controls.Add(this.TModificarNombreProveedor);
            this.panel3.Controls.Add(this.BModificarrProveedor);
            this.panel3.Controls.Add(this.LModificarNombreProveedor);
            this.panel3.Controls.Add(this.TModificarIDProveedor);
            this.panel3.Controls.Add(this.TBModificarIndice);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1264, 252);
            this.panel3.TabIndex = 0;
            // 
            // TModificarCUITProveedor
            // 
            this.TModificarCUITProveedor.BackgroundColor = System.Drawing.Color.White;
            this.TModificarCUITProveedor.Content = "";
            this.TModificarCUITProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TModificarCUITProveedor.FocusBackgroundColor = System.Drawing.Color.White;
            this.TModificarCUITProveedor.FocusImageTint = System.Drawing.Color.White;
            this.TModificarCUITProveedor.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TModificarCUITProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarCUITProveedor.ForeColor = System.Drawing.Color.Black;
            this.TModificarCUITProveedor.Image = null;
            this.TModificarCUITProveedor.ImageExpand = new System.Drawing.Point(0, 0);
            this.TModificarCUITProveedor.ImageOffset = new System.Drawing.Point(0, 0);
            this.TModificarCUITProveedor.Location = new System.Drawing.Point(340, 157);
            this.TModificarCUITProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.TModificarCUITProveedor.Multiline = false;
            this.TModificarCUITProveedor.Name = "TModificarCUITProveedor";
            this.TModificarCUITProveedor.NormalImageTint = System.Drawing.Color.White;
            this.TModificarCUITProveedor.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TModificarCUITProveedor.Padding = new System.Windows.Forms.Padding(15, 7, 15, 0);
            this.TModificarCUITProveedor.PasswordChar = false;
            this.TModificarCUITProveedor.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.TModificarCUITProveedor.PlaceholderText = "";
            this.TModificarCUITProveedor.Rounding = new System.Windows.Forms.Padding(8);
            this.TModificarCUITProveedor.Size = new System.Drawing.Size(233, 28);
            this.TModificarCUITProveedor.TabIndex = 125;
            this.TModificarCUITProveedor.TextOffset = new System.Drawing.Size(0, 0);
            this.TModificarCUITProveedor.UnderlinedStyle = true;
            // 
            // LModificarCUITProveedor
            // 
            this.LModificarCUITProveedor.AutoSize = true;
            this.LModificarCUITProveedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LModificarCUITProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarCUITProveedor.Location = new System.Drawing.Point(340, 133);
            this.LModificarCUITProveedor.Name = "LModificarCUITProveedor";
            this.LModificarCUITProveedor.Size = new System.Drawing.Size(43, 21);
            this.LModificarCUITProveedor.TabIndex = 124;
            this.LModificarCUITProveedor.Text = "CUIT";
            // 
            // TModificarTelefonoProveedor
            // 
            this.TModificarTelefonoProveedor.BackgroundColor = System.Drawing.Color.White;
            this.TModificarTelefonoProveedor.Content = "";
            this.TModificarTelefonoProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TModificarTelefonoProveedor.FocusBackgroundColor = System.Drawing.Color.White;
            this.TModificarTelefonoProveedor.FocusImageTint = System.Drawing.Color.White;
            this.TModificarTelefonoProveedor.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TModificarTelefonoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarTelefonoProveedor.ForeColor = System.Drawing.Color.Black;
            this.TModificarTelefonoProveedor.Image = null;
            this.TModificarTelefonoProveedor.ImageExpand = new System.Drawing.Point(0, 0);
            this.TModificarTelefonoProveedor.ImageOffset = new System.Drawing.Point(0, 0);
            this.TModificarTelefonoProveedor.Location = new System.Drawing.Point(614, 84);
            this.TModificarTelefonoProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.TModificarTelefonoProveedor.Multiline = false;
            this.TModificarTelefonoProveedor.Name = "TModificarTelefonoProveedor";
            this.TModificarTelefonoProveedor.NormalImageTint = System.Drawing.Color.White;
            this.TModificarTelefonoProveedor.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TModificarTelefonoProveedor.Padding = new System.Windows.Forms.Padding(15, 7, 15, 0);
            this.TModificarTelefonoProveedor.PasswordChar = false;
            this.TModificarTelefonoProveedor.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.TModificarTelefonoProveedor.PlaceholderText = "";
            this.TModificarTelefonoProveedor.Rounding = new System.Windows.Forms.Padding(8);
            this.TModificarTelefonoProveedor.Size = new System.Drawing.Size(233, 28);
            this.TModificarTelefonoProveedor.TabIndex = 123;
            this.TModificarTelefonoProveedor.TextOffset = new System.Drawing.Size(0, 0);
            this.TModificarTelefonoProveedor.UnderlinedStyle = true;
            // 
            // LModificarTelefonoProveedor
            // 
            this.LModificarTelefonoProveedor.AutoSize = true;
            this.LModificarTelefonoProveedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LModificarTelefonoProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarTelefonoProveedor.Location = new System.Drawing.Point(614, 60);
            this.LModificarTelefonoProveedor.Name = "LModificarTelefonoProveedor";
            this.LModificarTelefonoProveedor.Size = new System.Drawing.Size(155, 21);
            this.LModificarTelefonoProveedor.TabIndex = 122;
            this.LModificarTelefonoProveedor.Text = "Teléfono de Contacto";
            // 
            // TModificarNombreProveedor
            // 
            this.TModificarNombreProveedor.BackgroundColor = System.Drawing.Color.White;
            this.TModificarNombreProveedor.Content = "";
            this.TModificarNombreProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TModificarNombreProveedor.FocusBackgroundColor = System.Drawing.Color.White;
            this.TModificarNombreProveedor.FocusImageTint = System.Drawing.Color.White;
            this.TModificarNombreProveedor.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TModificarNombreProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarNombreProveedor.ForeColor = System.Drawing.Color.Black;
            this.TModificarNombreProveedor.Image = null;
            this.TModificarNombreProveedor.ImageExpand = new System.Drawing.Point(0, 0);
            this.TModificarNombreProveedor.ImageOffset = new System.Drawing.Point(0, 0);
            this.TModificarNombreProveedor.Location = new System.Drawing.Point(340, 84);
            this.TModificarNombreProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.TModificarNombreProveedor.Multiline = false;
            this.TModificarNombreProveedor.Name = "TModificarNombreProveedor";
            this.TModificarNombreProveedor.NormalImageTint = System.Drawing.Color.White;
            this.TModificarNombreProveedor.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TModificarNombreProveedor.Padding = new System.Windows.Forms.Padding(15, 7, 15, 0);
            this.TModificarNombreProveedor.PasswordChar = false;
            this.TModificarNombreProveedor.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.TModificarNombreProveedor.PlaceholderText = "";
            this.TModificarNombreProveedor.Rounding = new System.Windows.Forms.Padding(8);
            this.TModificarNombreProveedor.Size = new System.Drawing.Size(233, 28);
            this.TModificarNombreProveedor.TabIndex = 121;
            this.TModificarNombreProveedor.TextOffset = new System.Drawing.Size(0, 0);
            this.TModificarNombreProveedor.UnderlinedStyle = true;
            // 
            // BModificarrProveedor
            // 
            this.BModificarrProveedor.CheckButton = false;
            this.BModificarrProveedor.Checked = false;
            this.BModificarrProveedor.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.BModificarrProveedor.CheckedForeColor = System.Drawing.Color.White;
            this.BModificarrProveedor.CheckedImageTint = System.Drawing.Color.White;
            this.BModificarrProveedor.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.BModificarrProveedor.Content = "Modificar Proveedor";
            this.BModificarrProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BModificarrProveedor.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BModificarrProveedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BModificarrProveedor.ForeColor = System.Drawing.Color.White;
            this.BModificarrProveedor.HoverBackground = System.Drawing.Color.White;
            this.BModificarrProveedor.HoverForeColor = System.Drawing.Color.Black;
            this.BModificarrProveedor.HoverImageTint = System.Drawing.Color.White;
            this.BModificarrProveedor.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BModificarrProveedor.Image = null;
            this.BModificarrProveedor.ImageAutoCenter = true;
            this.BModificarrProveedor.ImageExpand = new System.Drawing.Point(0, 0);
            this.BModificarrProveedor.ImageOffset = new System.Drawing.Point(0, 0);
            this.BModificarrProveedor.Location = new System.Drawing.Point(506, 220);
            this.BModificarrProveedor.Name = "BModificarrProveedor";
            this.BModificarrProveedor.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.BModificarrProveedor.NormalForeColor = System.Drawing.Color.White;
            this.BModificarrProveedor.NormalImageTint = System.Drawing.Color.White;
            this.BModificarrProveedor.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BModificarrProveedor.OutlineThickness = 1F;
            this.BModificarrProveedor.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.BModificarrProveedor.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BModificarrProveedor.PressedImageTint = System.Drawing.Color.White;
            this.BModificarrProveedor.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BModificarrProveedor.Rounding = new System.Windows.Forms.Padding(8);
            this.BModificarrProveedor.Size = new System.Drawing.Size(168, 32);
            this.BModificarrProveedor.TabIndex = 120;
            this.BModificarrProveedor.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BModificarrProveedor.TextOffset = new System.Drawing.Point(0, 0);
            this.BModificarrProveedor.Click += new System.EventHandler(this.BModificar_Click);
            // 
            // LModificarNombreProveedor
            // 
            this.LModificarNombreProveedor.AutoSize = true;
            this.LModificarNombreProveedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LModificarNombreProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarNombreProveedor.Location = new System.Drawing.Point(340, 60);
            this.LModificarNombreProveedor.Name = "LModificarNombreProveedor";
            this.LModificarNombreProveedor.Size = new System.Drawing.Size(169, 21);
            this.LModificarNombreProveedor.TabIndex = 119;
            this.LModificarNombreProveedor.Text = "Nombre del Proveedor";
            // 
            // TModificarIDProveedor
            // 
            this.TModificarIDProveedor.BackgroundColor = System.Drawing.Color.White;
            this.TModificarIDProveedor.Content = "0";
            this.TModificarIDProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TModificarIDProveedor.FocusBackgroundColor = System.Drawing.Color.White;
            this.TModificarIDProveedor.FocusImageTint = System.Drawing.Color.White;
            this.TModificarIDProveedor.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TModificarIDProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarIDProveedor.ForeColor = System.Drawing.Color.Gray;
            this.TModificarIDProveedor.Image = null;
            this.TModificarIDProveedor.ImageExpand = new System.Drawing.Point(0, 0);
            this.TModificarIDProveedor.ImageOffset = new System.Drawing.Point(0, 0);
            this.TModificarIDProveedor.Location = new System.Drawing.Point(78, 238);
            this.TModificarIDProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.TModificarIDProveedor.Multiline = false;
            this.TModificarIDProveedor.Name = "TModificarIDProveedor";
            this.TModificarIDProveedor.NormalImageTint = System.Drawing.Color.White;
            this.TModificarIDProveedor.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TModificarIDProveedor.Padding = new System.Windows.Forms.Padding(15, 7, 15, 0);
            this.TModificarIDProveedor.PasswordChar = false;
            this.TModificarIDProveedor.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.TModificarIDProveedor.PlaceholderText = "";
            this.TModificarIDProveedor.Rounding = new System.Windows.Forms.Padding(8);
            this.TModificarIDProveedor.Size = new System.Drawing.Size(51, 28);
            this.TModificarIDProveedor.TabIndex = 110;
            this.TModificarIDProveedor.TextOffset = new System.Drawing.Size(0, 0);
            this.TModificarIDProveedor.UnderlinedStyle = true;
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
            this.TBModificarIndice.Location = new System.Drawing.Point(7, 238);
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
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CBEstado
            // 
            this.CBEstado.BackColor = System.Drawing.SystemColors.Window;
            this.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Location = new System.Drawing.Point(618, 152);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(232, 29);
            this.CBEstado.TabIndex = 62;
            // 
            // LEstado
            // 
            this.LEstado.AutoSize = true;
            this.LEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LEstado.Location = new System.Drawing.Point(618, 128);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(56, 21);
            this.LEstado.TabIndex = 61;
            this.LEstado.Text = "Estado";
            // 
            // LModificarEstado
            // 
            this.LModificarEstado.AutoSize = true;
            this.LModificarEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LModificarEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarEstado.Location = new System.Drawing.Point(618, 133);
            this.LModificarEstado.Name = "LModificarEstado";
            this.LModificarEstado.Size = new System.Drawing.Size(56, 21);
            this.LModificarEstado.TabIndex = 127;
            this.LModificarEstado.Text = "Estado";
            // 
            // CBModificarEstado
            // 
            this.CBModificarEstado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CBModificarEstado.DisplayMember = "estado";
            this.CBModificarEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBModificarEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBModificarEstado.FormattingEnabled = true;
            this.CBModificarEstado.Location = new System.Drawing.Point(618, 157);
            this.CBModificarEstado.Name = "CBModificarEstado";
            this.CBModificarEstado.Size = new System.Drawing.Size(232, 29);
            this.CBModificarEstado.TabIndex = 126;
            this.CBModificarEstado.ValueMember = "estado";
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TCUsuarios.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView proveedoresDataGridView;
        private System.Windows.Forms.Panel panel1;
        private CuoreUI.Controls.cuiButton BBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TabControl TCUsuarios;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private CuoreUI.Controls.cuiTextBox TIDProveedor;
        private CuoreUI.Controls.cuiTextBox TIndice;
        private CuoreUI.Controls.cuiTextBox TNombreProveedor;
        private CuoreUI.Controls.cuiButton BRegistrarProveedor;
        private System.Windows.Forms.Label LNombreProveedor;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private CuoreUI.Controls.cuiTextBox TModificarIDProveedor;
        private CuoreUI.Controls.cuiTextBox TBModificarIndice;
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono_proveedor;
        private CuoreUI.Controls.cuiTextBox TCUITProveedor;
        private System.Windows.Forms.Label LCUITProveedor;
        private CuoreUI.Controls.cuiTextBox TTelefonoProveedor;
        private System.Windows.Forms.Label LTelefonoProveedor;
        private CuoreUI.Controls.cuiTextBox TModificarCUITProveedor;
        private System.Windows.Forms.Label LModificarCUITProveedor;
        private CuoreUI.Controls.cuiTextBox TModificarTelefonoProveedor;
        private System.Windows.Forms.Label LModificarTelefonoProveedor;
        private CuoreUI.Controls.cuiTextBox TModificarNombreProveedor;
        private CuoreUI.Controls.cuiButton BModificarrProveedor;
        private System.Windows.Forms.Label LModificarNombreProveedor;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.Label LEstado;
        private System.Windows.Forms.Label LModificarEstado;
        private System.Windows.Forms.ComboBox CBModificarEstado;
    }
}