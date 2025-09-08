namespace OcioStoreIngSoftII
{
    partial class Ventas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TModificarID_prod = new System.Windows.Forms.TextBox();
            this.TBModificarIndice = new System.Windows.Forms.TextBox();
            this.btnLimpiarFiltros = new CuoreUI.Controls.cuiButton();
            this.LProducto = new System.Windows.Forms.Label();
            this.BAddProduct = new System.Windows.Forms.Button();
            this.BBuscar = new CuoreUI.Controls.cuiButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.CBFiltroCategoria = new System.Windows.Forms.ComboBox();
            this.NCantidad = new System.Windows.Forms.NumericUpDown();
            this.LCantidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.productosDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioLista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROCBUSCARPRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new OcioStoreIngSoftII.DataSet1();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.VentaDataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new OcioStoreIngSoftII.DataSet1TableAdapters.ProductosTableAdapter();
            this.pROC_BUSCAR_PRODUCTOTableAdapter = new OcioStoreIngSoftII.DataSet1TableAdapters.PROC_BUSCAR_PRODUCTOTableAdapter();
            this.id_producto_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NCantidad)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCBUSCARPRODUCTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VentaDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(872, 701);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 344);
            this.panel1.TabIndex = 58;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.TModificarID_prod);
            this.groupBox1.Controls.Add(this.TBModificarIndice);
            this.groupBox1.Controls.Add(this.btnLimpiarFiltros);
            this.groupBox1.Controls.Add(this.LProducto);
            this.groupBox1.Controls.Add(this.BAddProduct);
            this.groupBox1.Controls.Add(this.BBuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.CBFiltroCategoria);
            this.groupBox1.Controls.Add(this.NCantidad);
            this.groupBox1.Controls.Add(this.LCantidad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(9, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 174);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(246, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 59;
            this.label3.Text = "Precio";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(241, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(111, 27);
            this.textBox2.TabIndex = 58;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(20, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(207, 27);
            this.textBox1.TabIndex = 57;
            // 
            // TModificarID_prod
            // 
            this.TModificarID_prod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TModificarID_prod.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TModificarID_prod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarID_prod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarID_prod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarID_prod.Location = new System.Drawing.Point(79, 201);
            this.TModificarID_prod.Name = "TModificarID_prod";
            this.TModificarID_prod.Size = new System.Drawing.Size(56, 29);
            this.TModificarID_prod.TabIndex = 52;
            this.TModificarID_prod.Visible = false;
            // 
            // TBModificarIndice
            // 
            this.TBModificarIndice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBModificarIndice.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TBModificarIndice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBModificarIndice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBModificarIndice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBModificarIndice.Location = new System.Drawing.Point(28, 201);
            this.TBModificarIndice.Name = "TBModificarIndice";
            this.TBModificarIndice.Size = new System.Drawing.Size(55, 29);
            this.TBModificarIndice.TabIndex = 51;
            this.TBModificarIndice.Text = "-1";
            this.TBModificarIndice.Visible = false;
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.CheckButton = false;
            this.btnLimpiarFiltros.Checked = false;
            this.btnLimpiarFiltros.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnLimpiarFiltros.CheckedForeColor = System.Drawing.Color.White;
            this.btnLimpiarFiltros.CheckedImageTint = System.Drawing.Color.White;
            this.btnLimpiarFiltros.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnLimpiarFiltros.Content = "Limpiar Filtros";
            this.btnLimpiarFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarFiltros.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLimpiarFiltros.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarFiltros.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnLimpiarFiltros.HoverForeColor = System.Drawing.Color.White;
            this.btnLimpiarFiltros.HoverImageTint = System.Drawing.Color.White;
            this.btnLimpiarFiltros.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLimpiarFiltros.Image = null;
            this.btnLimpiarFiltros.ImageAutoCenter = true;
            this.btnLimpiarFiltros.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnLimpiarFiltros.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(586, 54);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.NormalBackground = System.Drawing.Color.White;
            this.btnLimpiarFiltros.NormalForeColor = System.Drawing.Color.Black;
            this.btnLimpiarFiltros.NormalImageTint = System.Drawing.Color.White;
            this.btnLimpiarFiltros.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLimpiarFiltros.OutlineThickness = 1F;
            this.btnLimpiarFiltros.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiarFiltros.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnLimpiarFiltros.PressedImageTint = System.Drawing.Color.White;
            this.btnLimpiarFiltros.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLimpiarFiltros.Rounding = new System.Windows.Forms.Padding(8);
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(110, 29);
            this.btnLimpiarFiltros.TabIndex = 56;
            this.btnLimpiarFiltros.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLimpiarFiltros.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // LProducto
            // 
            this.LProducto.AutoSize = true;
            this.LProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LProducto.Location = new System.Drawing.Point(16, 111);
            this.LProducto.Name = "LProducto";
            this.LProducto.Size = new System.Drawing.Size(73, 21);
            this.LProducto.TabIndex = 8;
            this.LProducto.Text = "Producto";
            // 
            // BAddProduct
            // 
            this.BAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.BAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BAddProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAddProduct.ForeColor = System.Drawing.Color.White;
            this.BAddProduct.Location = new System.Drawing.Point(466, 135);
            this.BAddProduct.Name = "BAddProduct";
            this.BAddProduct.Size = new System.Drawing.Size(230, 28);
            this.BAddProduct.TabIndex = 20;
            this.BAddProduct.Text = "Agregar al Carrito";
            this.BAddProduct.UseVisualStyleBackColor = false;
            // 
            // BBuscar
            // 
            this.BBuscar.CheckButton = false;
            this.BBuscar.Checked = false;
            this.BBuscar.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.BBuscar.CheckedForeColor = System.Drawing.Color.White;
            this.BBuscar.CheckedImageTint = System.Drawing.Color.White;
            this.BBuscar.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.BBuscar.Content = "Filtrar";
            this.BBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBuscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BBuscar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BBuscar.ForeColor = System.Drawing.Color.White;
            this.BBuscar.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.BBuscar.HoverForeColor = System.Drawing.Color.White;
            this.BBuscar.HoverImageTint = System.Drawing.Color.White;
            this.BBuscar.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BBuscar.Image = null;
            this.BBuscar.ImageAutoCenter = true;
            this.BBuscar.ImageExpand = new System.Drawing.Point(0, 0);
            this.BBuscar.ImageOffset = new System.Drawing.Point(0, 0);
            this.BBuscar.Location = new System.Drawing.Point(466, 54);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.BBuscar.NormalForeColor = System.Drawing.Color.White;
            this.BBuscar.NormalImageTint = System.Drawing.Color.White;
            this.BBuscar.NormalOutline = System.Drawing.Color.DarkBlue;
            this.BBuscar.OutlineThickness = 1F;
            this.BBuscar.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.BBuscar.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BBuscar.PressedImageTint = System.Drawing.Color.White;
            this.BBuscar.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BBuscar.Rounding = new System.Windows.Forms.Padding(8);
            this.BBuscar.Size = new System.Drawing.Size(110, 29);
            this.BBuscar.TabIndex = 53;
            this.BBuscar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BBuscar.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(236, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 55;
            this.label2.Text = "Seleccionar Categoría";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(20, 55);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(207, 29);
            this.txtBuscar.TabIndex = 5;
            // 
            // CBFiltroCategoria
            // 
            this.CBFiltroCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFiltroCategoria.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBFiltroCategoria.FormattingEnabled = true;
            this.CBFiltroCategoria.Location = new System.Drawing.Point(241, 55);
            this.CBFiltroCategoria.Name = "CBFiltroCategoria";
            this.CBFiltroCategoria.Size = new System.Drawing.Size(207, 28);
            this.CBFiltroCategoria.TabIndex = 54;
            // 
            // NCantidad
            // 
            this.NCantidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NCantidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NCantidad.Location = new System.Drawing.Point(374, 134);
            this.NCantidad.Name = "NCantidad";
            this.NCantidad.Size = new System.Drawing.Size(74, 27);
            this.NCantidad.TabIndex = 26;
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LCantidad.Location = new System.Drawing.Point(376, 110);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(72, 21);
            this.LCantidad.TabIndex = 24;
            this.LCantidad.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar";
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.productosDataGridView);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 353);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(866, 345);
            this.panel4.TabIndex = 59;
            // 
            // productosDataGridView
            // 
            this.productosDataGridView.AllowUserToAddRows = false;
            this.productosDataGridView.AllowUserToDeleteRows = false;
            this.productosDataGridView.AutoGenerateColumns = false;
            this.productosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productosDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.productosDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.id_producto,
            this.nombre_producto,
            this.fechaIngreso,
            this.precioLista,
            this.precioVenta,
            this.stock_min,
            this.stock,
            this.descripcion,
            this.id_categoria,
            this.nombre_categoria});
            this.productosDataGridView.DataSource = this.pROCBUSCARPRODUCTOBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productosDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.productosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productosDataGridView.EnableHeadersVisualStyles = false;
            this.productosDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.productosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.productosDataGridView.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.productosDataGridView.Name = "productosDataGridView";
            this.productosDataGridView.ReadOnly = true;
            this.productosDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productosDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.productosDataGridView.RowHeadersVisible = false;
            this.productosDataGridView.Size = new System.Drawing.Size(866, 345);
            this.productosDataGridView.TabIndex = 61;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.btnSeleccionar.HeaderText = "Seleccionar";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnSeleccionar.Width = 116;
            // 
            // id_producto
            // 
            this.id_producto.DataPropertyName = "id_producto";
            this.id_producto.HeaderText = "id_producto";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            this.id_producto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_producto.Visible = false;
            // 
            // nombre_producto
            // 
            this.nombre_producto.DataPropertyName = "nombre_producto";
            this.nombre_producto.HeaderText = "Nombre";
            this.nombre_producto.Name = "nombre_producto";
            this.nombre_producto.ReadOnly = true;
            this.nombre_producto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.DataPropertyName = "fechaIngreso";
            this.fechaIngreso.HeaderText = "Fecha Ingreso";
            this.fechaIngreso.Name = "fechaIngreso";
            this.fechaIngreso.ReadOnly = true;
            // 
            // precioLista
            // 
            this.precioLista.DataPropertyName = "precioLista";
            this.precioLista.HeaderText = "Precio Lista";
            this.precioLista.Name = "precioLista";
            this.precioLista.ReadOnly = true;
            this.precioLista.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // precioVenta
            // 
            this.precioVenta.DataPropertyName = "precioVenta";
            this.precioVenta.HeaderText = "Precio Venta";
            this.precioVenta.Name = "precioVenta";
            this.precioVenta.ReadOnly = true;
            this.precioVenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // stock_min
            // 
            this.stock_min.DataPropertyName = "stock_min";
            this.stock_min.HeaderText = "Stock Min";
            this.stock_min.Name = "stock_min";
            this.stock_min.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.DataPropertyName = "stock";
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // id_categoria
            // 
            this.id_categoria.DataPropertyName = "id_categoria";
            this.id_categoria.HeaderText = "id_categoria";
            this.id_categoria.Name = "id_categoria";
            this.id_categoria.ReadOnly = true;
            this.id_categoria.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_categoria.Visible = false;
            // 
            // nombre_categoria
            // 
            this.nombre_categoria.DataPropertyName = "nombre_categoria";
            this.nombre_categoria.HeaderText = "Categoria";
            this.nombre_categoria.Name = "nombre_categoria";
            this.nombre_categoria.ReadOnly = true;
            // 
            // pROCBUSCARPRODUCTOBindingSource
            // 
            this.pROCBUSCARPRODUCTOBindingSource.DataMember = "PROC_BUSCAR_PRODUCTO";
            this.pROCBUSCARPRODUCTOBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(872, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 701);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.VentaDataGridView, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(352, 701);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // VentaDataGridView
            // 
            this.VentaDataGridView.AllowUserToAddRows = false;
            this.VentaDataGridView.AllowUserToDeleteRows = false;
            this.VentaDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.VentaDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VentaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.VentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VentaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto_venta,
            this.nombre,
            this.precio,
            this.cantidad,
            this.btnEliminar});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VentaDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.VentaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VentaDataGridView.EnableHeadersVisualStyles = false;
            this.VentaDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.VentaDataGridView.Location = new System.Drawing.Point(15, 15);
            this.VentaDataGridView.Margin = new System.Windows.Forms.Padding(15, 15, 15, 5);
            this.VentaDataGridView.Name = "VentaDataGridView";
            this.VentaDataGridView.ReadOnly = true;
            this.VentaDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VentaDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.VentaDataGridView.RowHeadersVisible = false;
            this.VentaDataGridView.Size = new System.Drawing.Size(322, 428);
            this.VentaDataGridView.TabIndex = 62;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRegistrarVenta);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 451);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(346, 247);
            this.panel3.TabIndex = 63;
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.btnRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVenta.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(69, 12);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(208, 32);
            this.btnRegistrarVenta.TabIndex = 21;
            this.btnRegistrarVenta.Text = "Proceder al Pago";
            this.btnRegistrarVenta.UseVisualStyleBackColor = false;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.dataSet1;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // pROC_BUSCAR_PRODUCTOTableAdapter
            // 
            this.pROC_BUSCAR_PRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // id_producto_venta
            // 
            this.id_producto_venta.HeaderText = "id_producto_venta";
            this.id_producto_venta.MinimumWidth = 50;
            this.id_producto_venta.Name = "id_producto_venta";
            this.id_producto_venta.ReadOnly = true;
            this.id_producto_venta.Visible = false;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 75;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 75;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "Precio";
            this.precio.MinimumWidth = 75;
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 75;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 75;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 75;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.MinimumWidth = 75;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEliminar.Width = 110;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1224, 701);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NCantidad)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCBUSCARPRODUCTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VentaDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.NumericUpDown NCantidad;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.Button BAddProduct;
        private System.Windows.Forms.Label LProducto;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private DataSet1TableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.BindingSource pROCBUSCARPRODUCTOBindingSource;
        private DataSet1TableAdapters.PROC_BUSCAR_PRODUCTOTableAdapter pROC_BUSCAR_PRODUCTOTableAdapter;
        private System.Windows.Forms.TextBox TModificarID_prod;
        private System.Windows.Forms.TextBox TBModificarIndice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView VentaDataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private CuoreUI.Controls.cuiButton btnLimpiarFiltros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBFiltroCategoria;
        private CuoreUI.Controls.cuiButton BBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView productosDataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_min;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_categoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
    }
}