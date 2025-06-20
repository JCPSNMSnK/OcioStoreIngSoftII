namespace OcioStoreIngSoftII
{
    partial class Products
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
            this.TCProductos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PanelAltaProducts = new System.Windows.Forms.Panel();
            this.panelInternoAlta = new System.Windows.Forms.Panel();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.LEstado = new System.Windows.Forms.Label();
            this.LCategoria = new System.Windows.Forms.Label();
            this.BRegisterProduct = new System.Windows.Forms.Button();
            this.TPrecioVenta = new System.Windows.Forms.TextBox();
            this.LPrecioVenta = new System.Windows.Forms.Label();
            this.TPrecioLista = new System.Windows.Forms.TextBox();
            this.LPrecioLista = new System.Windows.Forms.Label();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.TDescripcion = new System.Windows.Forms.TextBox();
            this.LDescripcion = new System.Windows.Forms.Label();
            this.TIndice = new System.Windows.Forms.TextBox();
            this.TID_user = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PanelModificarProducts = new System.Windows.Forms.Panel();
            this.BEliminar = new System.Windows.Forms.Button();
            this.TBModificarIndice = new System.Windows.Forms.TextBox();
            this.TModificarID_user = new System.Windows.Forms.TextBox();
            this.pROC_BUSCAR_USUARIODataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.NStock = new System.Windows.Forms.NumericUpDown();
            this.LStock = new System.Windows.Forms.Label();
            this.panelInternoModif = new System.Windows.Forms.Panel();
            this.NModificarStock = new System.Windows.Forms.NumericUpDown();
            this.CBModificarEstado = new System.Windows.Forms.ComboBox();
            this.CBModificarCategoria = new System.Windows.Forms.ComboBox();
            this.LModificarStock = new System.Windows.Forms.Label();
            this.LModificarEstado = new System.Windows.Forms.Label();
            this.LModificarCategoria = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TBModificarPrecioVenta = new System.Windows.Forms.TextBox();
            this.LModificarPrecioVenta = new System.Windows.Forms.Label();
            this.TBModificarPrecioLista = new System.Windows.Forms.TextBox();
            this.LModificarPrecioLista = new System.Windows.Forms.Label();
            this.TBModificarNombre = new System.Windows.Forms.TextBox();
            this.LModificarNombre = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.TCProductos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.PanelAltaProducts.SuspendLayout();
            this.panelInternoAlta.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.PanelModificarProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROC_BUSCAR_USUARIODataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NStock)).BeginInit();
            this.panelInternoModif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NModificarStock)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.TCProductos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pROC_BUSCAR_USUARIODataGridView, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1127, 674);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // TCProductos
            // 
            this.TCProductos.AllowDrop = true;
            this.TCProductos.Controls.Add(this.tabPage1);
            this.TCProductos.Controls.Add(this.tabPage2);
            this.TCProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCProductos.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TCProductos.Location = new System.Drawing.Point(3, 3);
            this.TCProductos.Multiline = true;
            this.TCProductos.Name = "TCProductos";
            this.TCProductos.SelectedIndex = 0;
            this.TCProductos.Size = new System.Drawing.Size(1121, 414);
            this.TCProductos.TabIndex = 9;
            this.TCProductos.Resize += new System.EventHandler(this.TCProductos_Resize);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.PanelAltaProducts);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1113, 383);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alta de Productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // PanelAltaProducts
            // 
            this.PanelAltaProducts.AutoScroll = true;
            this.PanelAltaProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PanelAltaProducts.Controls.Add(this.panelInternoAlta);
            this.PanelAltaProducts.Controls.Add(this.TIndice);
            this.PanelAltaProducts.Controls.Add(this.TID_user);
            this.PanelAltaProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAltaProducts.Location = new System.Drawing.Point(3, 3);
            this.PanelAltaProducts.Name = "PanelAltaProducts";
            this.PanelAltaProducts.Size = new System.Drawing.Size(1107, 377);
            this.PanelAltaProducts.TabIndex = 7;
            this.PanelAltaProducts.Resize += new System.EventHandler(this.PanelAltaProducts_Resize);
            // 
            // panelInternoAlta
            // 
            this.panelInternoAlta.Controls.Add(this.NStock);
            this.panelInternoAlta.Controls.Add(this.CBEstado);
            this.panelInternoAlta.Controls.Add(this.CBCategoria);
            this.panelInternoAlta.Controls.Add(this.LStock);
            this.panelInternoAlta.Controls.Add(this.LEstado);
            this.panelInternoAlta.Controls.Add(this.LCategoria);
            this.panelInternoAlta.Controls.Add(this.BRegisterProduct);
            this.panelInternoAlta.Controls.Add(this.TPrecioVenta);
            this.panelInternoAlta.Controls.Add(this.LPrecioVenta);
            this.panelInternoAlta.Controls.Add(this.TPrecioLista);
            this.panelInternoAlta.Controls.Add(this.LPrecioLista);
            this.panelInternoAlta.Controls.Add(this.TNombre);
            this.panelInternoAlta.Controls.Add(this.LNombre);
            this.panelInternoAlta.Controls.Add(this.TDescripcion);
            this.panelInternoAlta.Controls.Add(this.LDescripcion);
            this.panelInternoAlta.Location = new System.Drawing.Point(201, 8);
            this.panelInternoAlta.Name = "panelInternoAlta";
            this.panelInternoAlta.Size = new System.Drawing.Size(731, 360);
            this.panelInternoAlta.TabIndex = 51;
            // 
            // CBEstado
            // 
            this.CBEstado.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Location = new System.Drawing.Point(330, 32);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(171, 26);
            this.CBEstado.TabIndex = 25;
            this.CBEstado.SelectedIndexChanged += new System.EventHandler(this.CBEstado_SelectedIndexChanged);
            // 
            // CBCategoria
            // 
            this.CBCategoria.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CBCategoria.DisplayMember = "id_categoria";
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Location = new System.Drawing.Point(31, 270);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(231, 26);
            this.CBCategoria.TabIndex = 24;
            this.CBCategoria.ValueMember = "id_categoria";
            // 
            // LEstado
            // 
            this.LEstado.AutoSize = true;
            this.LEstado.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LEstado.Location = new System.Drawing.Point(326, 5);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(52, 23);
            this.LEstado.TabIndex = 24;
            this.LEstado.Text = "Estado";
            this.LEstado.Click += new System.EventHandler(this.LEstado_Click);
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LCategoria.Location = new System.Drawing.Point(27, 244);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(71, 23);
            this.LCategoria.TabIndex = 22;
            this.LCategoria.Text = "Categoria";
            // 
            // BRegisterProduct
            // 
            this.BRegisterProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.BRegisterProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BRegisterProduct.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRegisterProduct.ForeColor = System.Drawing.Color.White;
            this.BRegisterProduct.Location = new System.Drawing.Point(444, 313);
            this.BRegisterProduct.Name = "BRegisterProduct";
            this.BRegisterProduct.Size = new System.Drawing.Size(143, 32);
            this.BRegisterProduct.TabIndex = 20;
            this.BRegisterProduct.Text = "Registrar Producto";
            this.BRegisterProduct.UseVisualStyleBackColor = false;
            // 
            // TPrecioVenta
            // 
            this.TPrecioVenta.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TPrecioVenta.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPrecioVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TPrecioVenta.Location = new System.Drawing.Point(30, 190);
            this.TPrecioVenta.Name = "TPrecioVenta";
            this.TPrecioVenta.Size = new System.Drawing.Size(232, 27);
            this.TPrecioVenta.TabIndex = 13;
            // 
            // LPrecioVenta
            // 
            this.LPrecioVenta.AutoSize = true;
            this.LPrecioVenta.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LPrecioVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LPrecioVenta.Location = new System.Drawing.Point(27, 164);
            this.LPrecioVenta.Name = "LPrecioVenta";
            this.LPrecioVenta.Size = new System.Drawing.Size(87, 23);
            this.LPrecioVenta.TabIndex = 12;
            this.LPrecioVenta.Text = "Precio Venta";
            // 
            // TPrecioLista
            // 
            this.TPrecioLista.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TPrecioLista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TPrecioLista.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPrecioLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TPrecioLista.Location = new System.Drawing.Point(30, 107);
            this.TPrecioLista.Name = "TPrecioLista";
            this.TPrecioLista.Size = new System.Drawing.Size(232, 27);
            this.TPrecioLista.TabIndex = 11;
            // 
            // LPrecioLista
            // 
            this.LPrecioLista.AutoSize = true;
            this.LPrecioLista.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LPrecioLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LPrecioLista.Location = new System.Drawing.Point(27, 81);
            this.LPrecioLista.Name = "LPrecioLista";
            this.LPrecioLista.Size = new System.Drawing.Size(84, 23);
            this.LPrecioLista.TabIndex = 10;
            this.LPrecioLista.Text = "Precio Lista";
            // 
            // TNombre
            // 
            this.TNombre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TNombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TNombre.Location = new System.Drawing.Point(31, 30);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(232, 27);
            this.TNombre.TabIndex = 9;
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LNombre.Location = new System.Drawing.Point(26, 5);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(58, 23);
            this.LNombre.TabIndex = 8;
            this.LNombre.Text = "Nombre";
            // 
            // TDescripcion
            // 
            this.TDescripcion.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TDescripcion.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TDescripcion.Location = new System.Drawing.Point(330, 107);
            this.TDescripcion.Multiline = true;
            this.TDescripcion.Name = "TDescripcion";
            this.TDescripcion.PasswordChar = '*';
            this.TDescripcion.Size = new System.Drawing.Size(370, 189);
            this.TDescripcion.TabIndex = 7;
            this.TDescripcion.UseSystemPasswordChar = true;
            this.TDescripcion.TextChanged += new System.EventHandler(this.TDescripcion_TextChanged);
            // 
            // LDescripcion
            // 
            this.LDescripcion.AutoSize = true;
            this.LDescripcion.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LDescripcion.Location = new System.Drawing.Point(326, 81);
            this.LDescripcion.Name = "LDescripcion";
            this.LDescripcion.Size = new System.Drawing.Size(83, 23);
            this.LDescripcion.TabIndex = 6;
            this.LDescripcion.Text = "Descripcion";
            this.LDescripcion.Click += new System.EventHandler(this.LDescripcion_Click);
            // 
            // TIndice
            // 
            this.TIndice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TIndice.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TIndice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TIndice.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIndice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TIndice.Location = new System.Drawing.Point(20, 16);
            this.TIndice.Name = "TIndice";
            this.TIndice.Size = new System.Drawing.Size(36, 27);
            this.TIndice.TabIndex = 50;
            this.TIndice.Text = "-1";
            this.TIndice.Visible = false;
            // 
            // TID_user
            // 
            this.TID_user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TID_user.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TID_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TID_user.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TID_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TID_user.Location = new System.Drawing.Point(76, 16);
            this.TID_user.Name = "TID_user";
            this.TID_user.Size = new System.Drawing.Size(38, 27);
            this.TID_user.TabIndex = 49;
            this.TID_user.Text = "0";
            this.TID_user.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PanelModificarProducts);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1113, 383);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Productos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PanelModificarProducts
            // 
            this.PanelModificarProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PanelModificarProducts.Controls.Add(this.panelInternoModif);
            this.PanelModificarProducts.Controls.Add(this.TBModificarIndice);
            this.PanelModificarProducts.Controls.Add(this.TModificarID_user);
            this.PanelModificarProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelModificarProducts.Location = new System.Drawing.Point(3, 3);
            this.PanelModificarProducts.Name = "PanelModificarProducts";
            this.PanelModificarProducts.Size = new System.Drawing.Size(1107, 377);
            this.PanelModificarProducts.TabIndex = 8;
            this.PanelModificarProducts.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelModificarUser_Paint);
            // 
            // BEliminar
            // 
            this.BEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.BEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BEliminar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEliminar.ForeColor = System.Drawing.Color.White;
            this.BEliminar.Location = new System.Drawing.Point(330, 316);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(143, 32);
            this.BEliminar.TabIndex = 49;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.UseVisualStyleBackColor = false;
            // 
            // TBModificarIndice
            // 
            this.TBModificarIndice.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TBModificarIndice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBModificarIndice.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBModificarIndice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBModificarIndice.Location = new System.Drawing.Point(20, 14);
            this.TBModificarIndice.Name = "TBModificarIndice";
            this.TBModificarIndice.Size = new System.Drawing.Size(36, 27);
            this.TBModificarIndice.TabIndex = 48;
            this.TBModificarIndice.Text = "-1";
            this.TBModificarIndice.Visible = false;
            // 
            // TModificarID_user
            // 
            this.TModificarID_user.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TModificarID_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarID_user.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarID_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarID_user.Location = new System.Drawing.Point(63, 14);
            this.TModificarID_user.Name = "TModificarID_user";
            this.TModificarID_user.Size = new System.Drawing.Size(36, 27);
            this.TModificarID_user.TabIndex = 47;
            this.TModificarID_user.Visible = false;
            // 
            // pROC_BUSCAR_USUARIODataGridView
            // 
            this.pROC_BUSCAR_USUARIODataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pROC_BUSCAR_USUARIODataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pROC_BUSCAR_USUARIODataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pROC_BUSCAR_USUARIODataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.pROC_BUSCAR_USUARIODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pROC_BUSCAR_USUARIODataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.pROC_BUSCAR_USUARIODataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pROC_BUSCAR_USUARIODataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.pROC_BUSCAR_USUARIODataGridView.Location = new System.Drawing.Point(3, 555);
            this.pROC_BUSCAR_USUARIODataGridView.Name = "pROC_BUSCAR_USUARIODataGridView";
            this.pROC_BUSCAR_USUARIODataGridView.ReadOnly = true;
            this.pROC_BUSCAR_USUARIODataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pROC_BUSCAR_USUARIODataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.pROC_BUSCAR_USUARIODataGridView.RowHeadersVisible = false;
            this.pROC_BUSCAR_USUARIODataGridView.Size = new System.Drawing.Size(1121, 176);
            this.pROC_BUSCAR_USUARIODataGridView.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 423);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 126);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(9, 42);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(226, 22);
            this.txtBuscar.TabIndex = 5;
            // 
            // NStock
            // 
            this.NStock.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.NStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NStock.Location = new System.Drawing.Point(564, 33);
            this.NStock.Name = "NStock";
            this.NStock.Size = new System.Drawing.Size(74, 26);
            this.NStock.TabIndex = 26;
            // 
            // LStock
            // 
            this.LStock.AutoSize = true;
            this.LStock.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LStock.Location = new System.Drawing.Point(560, 7);
            this.LStock.Name = "LStock";
            this.LStock.Size = new System.Drawing.Size(45, 23);
            this.LStock.TabIndex = 24;
            this.LStock.Text = "Stock";
            this.LStock.Click += new System.EventHandler(this.LEstado_Click);
            // 
            // panelInternoModif
            // 
            this.panelInternoModif.Controls.Add(this.NModificarStock);
            this.panelInternoModif.Controls.Add(this.CBModificarEstado);
            this.panelInternoModif.Controls.Add(this.CBModificarCategoria);
            this.panelInternoModif.Controls.Add(this.BEliminar);
            this.panelInternoModif.Controls.Add(this.LModificarStock);
            this.panelInternoModif.Controls.Add(this.LModificarEstado);
            this.panelInternoModif.Controls.Add(this.LModificarCategoria);
            this.panelInternoModif.Controls.Add(this.button1);
            this.panelInternoModif.Controls.Add(this.TBModificarPrecioVenta);
            this.panelInternoModif.Controls.Add(this.LModificarPrecioVenta);
            this.panelInternoModif.Controls.Add(this.TBModificarPrecioLista);
            this.panelInternoModif.Controls.Add(this.LModificarPrecioLista);
            this.panelInternoModif.Controls.Add(this.TBModificarNombre);
            this.panelInternoModif.Controls.Add(this.LModificarNombre);
            this.panelInternoModif.Controls.Add(this.textBox4);
            this.panelInternoModif.Controls.Add(this.label8);
            this.panelInternoModif.Location = new System.Drawing.Point(188, 14);
            this.panelInternoModif.Name = "panelInternoModif";
            this.panelInternoModif.Size = new System.Drawing.Size(731, 360);
            this.panelInternoModif.TabIndex = 52;
            // 
            // NModificarStock
            // 
            this.NModificarStock.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.NModificarStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NModificarStock.Location = new System.Drawing.Point(564, 33);
            this.NModificarStock.Name = "NModificarStock";
            this.NModificarStock.Size = new System.Drawing.Size(74, 26);
            this.NModificarStock.TabIndex = 26;
            // 
            // CBModificarEstado
            // 
            this.CBModificarEstado.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CBModificarEstado.FormattingEnabled = true;
            this.CBModificarEstado.Location = new System.Drawing.Point(330, 32);
            this.CBModificarEstado.Name = "CBModificarEstado";
            this.CBModificarEstado.Size = new System.Drawing.Size(171, 26);
            this.CBModificarEstado.TabIndex = 25;
            // 
            // CBModificarCategoria
            // 
            this.CBModificarCategoria.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CBModificarCategoria.DisplayMember = "id_categoria";
            this.CBModificarCategoria.FormattingEnabled = true;
            this.CBModificarCategoria.Location = new System.Drawing.Point(31, 270);
            this.CBModificarCategoria.Name = "CBModificarCategoria";
            this.CBModificarCategoria.Size = new System.Drawing.Size(231, 26);
            this.CBModificarCategoria.TabIndex = 24;
            this.CBModificarCategoria.ValueMember = "id_categoria";
            // 
            // LModificarStock
            // 
            this.LModificarStock.AutoSize = true;
            this.LModificarStock.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LModificarStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarStock.Location = new System.Drawing.Point(560, 7);
            this.LModificarStock.Name = "LModificarStock";
            this.LModificarStock.Size = new System.Drawing.Size(45, 23);
            this.LModificarStock.TabIndex = 24;
            this.LModificarStock.Text = "Stock";
            // 
            // LModificarEstado
            // 
            this.LModificarEstado.AutoSize = true;
            this.LModificarEstado.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LModificarEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarEstado.Location = new System.Drawing.Point(326, 5);
            this.LModificarEstado.Name = "LModificarEstado";
            this.LModificarEstado.Size = new System.Drawing.Size(52, 23);
            this.LModificarEstado.TabIndex = 24;
            this.LModificarEstado.Text = "Estado";
            // 
            // LModificarCategoria
            // 
            this.LModificarCategoria.AutoSize = true;
            this.LModificarCategoria.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LModificarCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarCategoria.Location = new System.Drawing.Point(27, 244);
            this.LModificarCategoria.Name = "LModificarCategoria";
            this.LModificarCategoria.Size = new System.Drawing.Size(71, 23);
            this.LModificarCategoria.TabIndex = 22;
            this.LModificarCategoria.Text = "Categoria";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(557, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 32);
            this.button1.TabIndex = 20;
            this.button1.Text = "Registrar Producto";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TBModificarPrecioVenta
            // 
            this.TBModificarPrecioVenta.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TBModificarPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBModificarPrecioVenta.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBModificarPrecioVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBModificarPrecioVenta.Location = new System.Drawing.Point(30, 190);
            this.TBModificarPrecioVenta.Name = "TBModificarPrecioVenta";
            this.TBModificarPrecioVenta.Size = new System.Drawing.Size(232, 27);
            this.TBModificarPrecioVenta.TabIndex = 13;
            // 
            // LModificarPrecioVenta
            // 
            this.LModificarPrecioVenta.AutoSize = true;
            this.LModificarPrecioVenta.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LModificarPrecioVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarPrecioVenta.Location = new System.Drawing.Point(27, 164);
            this.LModificarPrecioVenta.Name = "LModificarPrecioVenta";
            this.LModificarPrecioVenta.Size = new System.Drawing.Size(87, 23);
            this.LModificarPrecioVenta.TabIndex = 12;
            this.LModificarPrecioVenta.Text = "Precio Venta";
            // 
            // TBModificarPrecioLista
            // 
            this.TBModificarPrecioLista.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TBModificarPrecioLista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBModificarPrecioLista.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBModificarPrecioLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBModificarPrecioLista.Location = new System.Drawing.Point(30, 107);
            this.TBModificarPrecioLista.Name = "TBModificarPrecioLista";
            this.TBModificarPrecioLista.Size = new System.Drawing.Size(232, 27);
            this.TBModificarPrecioLista.TabIndex = 11;
            // 
            // LModificarPrecioLista
            // 
            this.LModificarPrecioLista.AutoSize = true;
            this.LModificarPrecioLista.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LModificarPrecioLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarPrecioLista.Location = new System.Drawing.Point(27, 81);
            this.LModificarPrecioLista.Name = "LModificarPrecioLista";
            this.LModificarPrecioLista.Size = new System.Drawing.Size(84, 23);
            this.LModificarPrecioLista.TabIndex = 10;
            this.LModificarPrecioLista.Text = "Precio Lista";
            // 
            // TBModificarNombre
            // 
            this.TBModificarNombre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TBModificarNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBModificarNombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBModificarNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBModificarNombre.Location = new System.Drawing.Point(31, 30);
            this.TBModificarNombre.Name = "TBModificarNombre";
            this.TBModificarNombre.Size = new System.Drawing.Size(232, 27);
            this.TBModificarNombre.TabIndex = 9;
            // 
            // LModificarNombre
            // 
            this.LModificarNombre.AutoSize = true;
            this.LModificarNombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LModificarNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarNombre.Location = new System.Drawing.Point(26, 5);
            this.LModificarNombre.Name = "LModificarNombre";
            this.LModificarNombre.Size = new System.Drawing.Size(58, 23);
            this.LModificarNombre.TabIndex = 8;
            this.LModificarNombre.Text = "Nombre";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox4.Location = new System.Drawing.Point(330, 107);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.PasswordChar = '*';
            this.textBox4.Size = new System.Drawing.Size(370, 189);
            this.textBox4.TabIndex = 7;
            this.textBox4.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(326, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "Descripcion";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 674);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TCProductos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.PanelAltaProducts.ResumeLayout(false);
            this.PanelAltaProducts.PerformLayout();
            this.panelInternoAlta.ResumeLayout(false);
            this.panelInternoAlta.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.PanelModificarProducts.ResumeLayout(false);
            this.PanelModificarProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROC_BUSCAR_USUARIODataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NStock)).EndInit();
            this.panelInternoModif.ResumeLayout(false);
            this.panelInternoModif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NModificarStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl TCProductos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel PanelAltaProducts;
        private System.Windows.Forms.Panel panelInternoAlta;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.ComboBox CBCategoria;
        private System.Windows.Forms.Label LEstado;
        private System.Windows.Forms.Label LCategoria;
        private System.Windows.Forms.Button BRegisterProduct;
        private System.Windows.Forms.TextBox TPrecioVenta;
        private System.Windows.Forms.Label LPrecioVenta;
        private System.Windows.Forms.TextBox TPrecioLista;
        private System.Windows.Forms.Label LPrecioLista;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox TDescripcion;
        private System.Windows.Forms.Label LDescripcion;
        private System.Windows.Forms.TextBox TIndice;
        private System.Windows.Forms.TextBox TID_user;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel PanelModificarProducts;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.TextBox TBModificarIndice;
        private System.Windows.Forms.TextBox TModificarID_user;
        private System.Windows.Forms.DataGridView pROC_BUSCAR_USUARIODataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.NumericUpDown NStock;
        private System.Windows.Forms.Label LStock;
        private System.Windows.Forms.Panel panelInternoModif;
        private System.Windows.Forms.NumericUpDown NModificarStock;
        private System.Windows.Forms.ComboBox CBModificarEstado;
        private System.Windows.Forms.ComboBox CBModificarCategoria;
        private System.Windows.Forms.Label LModificarStock;
        private System.Windows.Forms.Label LModificarEstado;
        private System.Windows.Forms.Label LModificarCategoria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TBModificarPrecioVenta;
        private System.Windows.Forms.Label LModificarPrecioVenta;
        private System.Windows.Forms.TextBox TBModificarPrecioLista;
        private System.Windows.Forms.Label LModificarPrecioLista;
        private System.Windows.Forms.TextBox TBModificarNombre;
        private System.Windows.Forms.Label LModificarNombre;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
    }
}