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
            this.productosDataGridView = new System.Windows.Forms.DataGridView();
            this.pROCBUSCARPRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new OcioStoreIngSoftII.DataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TModificarID_prod = new System.Windows.Forms.TextBox();
            this.TBModificarIndice = new System.Windows.Forms.TextBox();
            this.NCantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.LCantidad = new System.Windows.Forms.Label();
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.BAddProduct = new System.Windows.Forms.Button();
            this.CBProductos = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.LCategoria = new System.Windows.Forms.Label();
            this.LProducto = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.VentaDataGridView = new System.Windows.Forms.DataGridView();
            this.id_producto_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new OcioStoreIngSoftII.DataSet1TableAdapters.ProductosTableAdapter();
            this.pROC_BUSCAR_PRODUCTOTableAdapter = new OcioStoreIngSoftII.DataSet1TableAdapters.PROC_BUSCAR_PRODUCTOTableAdapter();
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
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCBUSCARPRODUCTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NCantidad)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VentaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.productosDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.31861F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.68138F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(872, 701);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.productosDataGridView.Location = new System.Drawing.Point(15, 264);
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
            this.productosDataGridView.Size = new System.Drawing.Size(854, 434);
            this.productosDataGridView.TabIndex = 60;
            this.productosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productosDataGridView_CellContentClick);
            this.productosDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.productosDataGridView_CellPainting);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.TModificarID_prod);
            this.panel1.Controls.Add(this.TBModificarIndice);
            this.panel1.Controls.Add(this.NCantidad);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LCantidad);
            this.panel1.Controls.Add(this.CBCategoria);
            this.panel1.Controls.Add(this.BAddProduct);
            this.panel1.Controls.Add(this.CBProductos);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.LCategoria);
            this.panel1.Controls.Add(this.LProducto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 255);
            this.panel1.TabIndex = 58;
            // 
            // TModificarID_prod
            // 
            this.TModificarID_prod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TModificarID_prod.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TModificarID_prod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarID_prod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarID_prod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarID_prod.Location = new System.Drawing.Point(122, 184);
            this.TModificarID_prod.Name = "TModificarID_prod";
            this.TModificarID_prod.Size = new System.Drawing.Size(46, 29);
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
            this.TBModificarIndice.Location = new System.Drawing.Point(71, 184);
            this.TBModificarIndice.Name = "TBModificarIndice";
            this.TBModificarIndice.Size = new System.Drawing.Size(45, 29);
            this.TBModificarIndice.TabIndex = 51;
            this.TBModificarIndice.Text = "-1";
            this.TBModificarIndice.Visible = false;
            // 
            // NCantidad
            // 
            this.NCantidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NCantidad.Location = new System.Drawing.Point(598, 128);
            this.NCantidad.Name = "NCantidad";
            this.NCantidad.Size = new System.Drawing.Size(74, 29);
            this.NCantidad.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar";
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LCantidad.Location = new System.Drawing.Point(594, 104);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(72, 21);
            this.LCantidad.TabIndex = 24;
            this.LCantidad.Text = "Cantidad";
            // 
            // CBCategoria
            // 
            this.CBCategoria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CBCategoria.DisplayMember = "id_categoria";
            this.CBCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Location = new System.Drawing.Point(303, 128);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(232, 29);
            this.CBCategoria.TabIndex = 24;
            this.CBCategoria.ValueMember = "id_categoria";
            // 
            // BAddProduct
            // 
            this.BAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.BAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BAddProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAddProduct.ForeColor = System.Drawing.Color.White;
            this.BAddProduct.Location = new System.Drawing.Point(261, 184);
            this.BAddProduct.Name = "BAddProduct";
            this.BAddProduct.Size = new System.Drawing.Size(168, 32);
            this.BAddProduct.TabIndex = 20;
            this.BAddProduct.Text = "Agregar a la venta";
            this.BAddProduct.UseVisualStyleBackColor = false;
            this.BAddProduct.Click += new System.EventHandler(this.BAddProduct_Click);
            // 
            // CBProductos
            // 
            this.CBProductos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CBProductos.DisplayMember = "id_categoria";
            this.CBProductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBProductos.FormattingEnabled = true;
            this.CBProductos.Location = new System.Drawing.Point(8, 128);
            this.CBProductos.Name = "CBProductos";
            this.CBProductos.Size = new System.Drawing.Size(232, 29);
            this.CBProductos.TabIndex = 24;
            this.CBProductos.ValueMember = "id_categoria";
            this.CBProductos.SelectedIndexChanged += new System.EventHandler(this.CBProductos_SelectedIndexChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(13, 44);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(665, 29);
            this.txtBuscar.TabIndex = 5;
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LCategoria.Location = new System.Drawing.Point(299, 104);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(77, 21);
            this.LCategoria.TabIndex = 22;
            this.LCategoria.Text = "Categoria";
            // 
            // LProducto
            // 
            this.LProducto.AutoSize = true;
            this.LProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LProducto.Location = new System.Drawing.Point(8, 104);
            this.LProducto.Name = "LProducto";
            this.LProducto.Size = new System.Drawing.Size(73, 21);
            this.LProducto.TabIndex = 8;
            this.LProducto.Text = "Producto";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.VentaDataGridView);
            this.panel2.Controls.Add(this.btnRegistrarVenta);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(872, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 701);
            this.panel2.TabIndex = 2;
            // 
            // VentaDataGridView
            // 
            this.VentaDataGridView.AllowUserToAddRows = false;
            this.VentaDataGridView.AllowUserToDeleteRows = false;
            this.VentaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VentaDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.VentaDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
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
            this.VentaDataGridView.EnableHeadersVisualStyles = false;
            this.VentaDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.VentaDataGridView.Location = new System.Drawing.Point(0, 0);
            this.VentaDataGridView.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
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
            this.VentaDataGridView.Size = new System.Drawing.Size(317, 413);
            this.VentaDataGridView.TabIndex = 61;
            this.VentaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VentaDataGridView_CellContentClick);
            this.VentaDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.VentaDataGridView_CellPainting);
            // 
            // id_producto_venta
            // 
            this.id_producto_venta.HeaderText = "id_producto_venta";
            this.id_producto_venta.Name = "id_producto_venta";
            this.id_producto_venta.ReadOnly = true;
            this.id_producto_venta.Visible = false;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEliminar.Width = 75;
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.btnRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVenta.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(41, 440);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(168, 32);
            this.btnRegistrarVenta.TabIndex = 20;
            this.btnRegistrarVenta.Text = "Agregar a la venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = false;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
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
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1189, 701);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCBUSCARPRODUCTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NCantidad)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VentaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.NumericUpDown NCantidad;
        private System.Windows.Forms.ComboBox CBCategoria;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.Label LCategoria;
        private System.Windows.Forms.Button BAddProduct;
        private System.Windows.Forms.Label LProducto;
        private System.Windows.Forms.DataGridView productosDataGridView;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private DataSet1TableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.BindingSource pROCBUSCARPRODUCTOBindingSource;
        private DataSet1TableAdapters.PROC_BUSCAR_PRODUCTOTableAdapter pROC_BUSCAR_PRODUCTOTableAdapter;
        private System.Windows.Forms.ComboBox CBProductos;
        private System.Windows.Forms.TextBox TModificarID_prod;
        private System.Windows.Forms.TextBox TBModificarIndice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView VentaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.Button btnRegistrarVenta;
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
    }
}