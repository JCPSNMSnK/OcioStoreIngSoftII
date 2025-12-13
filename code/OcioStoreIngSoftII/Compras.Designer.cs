namespace OcioStoreIngSoftII
{
    partial class Compras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBProveedor = new System.Windows.Forms.ComboBox();
            this.TNombreProducto = new CuoreUI.Controls.cuiTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TCodigoProducto = new CuoreUI.Controls.cuiTextBox();
            this.BAgregar = new System.Windows.Forms.Button();
            this.BBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.TPrecioUnitario = new CuoreUI.Controls.cuiTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Id_Producto_Oculto = new System.Windows.Forms.TextBox();
            this.TBModificarIndice = new System.Windows.Forms.TextBox();
            this.NCantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.LCantidad = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.LProveedor = new System.Windows.Forms.Label();
            this.LProducto = new System.Windows.Forms.Label();
            this.comprasDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimirCompra = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BRegistrarCompra = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.detallesDataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detallesDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.CBProveedor);
            this.panel1.Controls.Add(this.TNombreProducto);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TCodigoProducto);
            this.panel1.Controls.Add(this.BAgregar);
            this.panel1.Controls.Add(this.BBuscar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.TPrecioUnitario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TB_Id_Producto_Oculto);
            this.panel1.Controls.Add(this.TBModificarIndice);
            this.panel1.Controls.Add(this.NCantidad);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LCantidad);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.LProveedor);
            this.panel1.Controls.Add(this.LProducto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 273);
            this.panel1.TabIndex = 58;
            // 
            // CBProveedor
            // 
            this.CBProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBProveedor.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.CBProveedor.FormattingEnabled = true;
            this.CBProveedor.Location = new System.Drawing.Point(12, 127);
            this.CBProveedor.Name = "CBProveedor";
            this.CBProveedor.Size = new System.Drawing.Size(233, 28);
            this.CBProveedor.TabIndex = 105;
            // 
            // TNombreProducto
            // 
            this.TNombreProducto.BackgroundColor = System.Drawing.Color.White;
            this.TNombreProducto.Content = "";
            this.TNombreProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TNombreProducto.FocusBackgroundColor = System.Drawing.Color.White;
            this.TNombreProducto.FocusImageTint = System.Drawing.Color.White;
            this.TNombreProducto.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNombreProducto.ForeColor = System.Drawing.Color.Gray;
            this.TNombreProducto.Image = null;
            this.TNombreProducto.ImageExpand = new System.Drawing.Point(0, 0);
            this.TNombreProducto.ImageOffset = new System.Drawing.Point(0, 0);
            this.TNombreProducto.Location = new System.Drawing.Point(270, 192);
            this.TNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.TNombreProducto.Multiline = false;
            this.TNombreProducto.Name = "TNombreProducto";
            this.TNombreProducto.NormalImageTint = System.Drawing.Color.White;
            this.TNombreProducto.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TNombreProducto.Padding = new System.Windows.Forms.Padding(15, 7, 15, 0);
            this.TNombreProducto.PasswordChar = false;
            this.TNombreProducto.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.TNombreProducto.PlaceholderText = "";
            this.TNombreProducto.Rounding = new System.Windows.Forms.Padding(2);
            this.TNombreProducto.Size = new System.Drawing.Size(233, 29);
            this.TNombreProducto.TabIndex = 71;
            this.TNombreProducto.TextOffset = new System.Drawing.Size(0, 0);
            this.TNombreProducto.UnderlinedStyle = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(273, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 21);
            this.label4.TabIndex = 70;
            this.label4.Text = "Nombre Producto";
            // 
            // TCodigoProducto
            // 
            this.TCodigoProducto.BackgroundColor = System.Drawing.Color.White;
            this.TCodigoProducto.Content = "";
            this.TCodigoProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TCodigoProducto.FocusBackgroundColor = System.Drawing.Color.White;
            this.TCodigoProducto.FocusImageTint = System.Drawing.Color.White;
            this.TCodigoProducto.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCodigoProducto.ForeColor = System.Drawing.Color.Gray;
            this.TCodigoProducto.Image = null;
            this.TCodigoProducto.ImageExpand = new System.Drawing.Point(0, 0);
            this.TCodigoProducto.ImageOffset = new System.Drawing.Point(0, 0);
            this.TCodigoProducto.Location = new System.Drawing.Point(270, 126);
            this.TCodigoProducto.Margin = new System.Windows.Forms.Padding(4);
            this.TCodigoProducto.Multiline = false;
            this.TCodigoProducto.Name = "TCodigoProducto";
            this.TCodigoProducto.NormalImageTint = System.Drawing.Color.White;
            this.TCodigoProducto.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TCodigoProducto.Padding = new System.Windows.Forms.Padding(15, 7, 15, 0);
            this.TCodigoProducto.PasswordChar = false;
            this.TCodigoProducto.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.TCodigoProducto.PlaceholderText = "";
            this.TCodigoProducto.Rounding = new System.Windows.Forms.Padding(2);
            this.TCodigoProducto.Size = new System.Drawing.Size(233, 29);
            this.TCodigoProducto.TabIndex = 69;
            this.TCodigoProducto.TextOffset = new System.Drawing.Size(0, 0);
            this.TCodigoProducto.UnderlinedStyle = true;
            this.TCodigoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Codigo_Producto_KeyPress);
            // 
            // BAgregar
            // 
            this.BAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            this.BAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregar.ForeColor = System.Drawing.Color.White;
            this.BAgregar.Location = new System.Drawing.Point(534, 189);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(214, 32);
            this.BAgregar.TabIndex = 68;
            this.BAgregar.Text = "Agregar Producto";
            this.BAgregar.UseVisualStyleBackColor = false;
            this.BAgregar.Click += new System.EventHandler(this.BAgregarProducto_Click);
            // 
            // BBuscar
            // 
            this.BBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscar.ForeColor = System.Drawing.Color.White;
            this.BBuscar.Location = new System.Drawing.Point(422, 270);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(134, 28);
            this.BBuscar.TabIndex = 67;
            this.BBuscar.Text = "Buscar";
            this.BBuscar.UseVisualStyleBackColor = false;
            this.BBuscar.Click += new System.EventHandler(this.BSearch_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(80, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 46);
            this.label3.TabIndex = 66;
            this.label3.Text = "Registrar Compra";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 76;
            this.iconPictureBox1.Location = new System.Drawing.Point(7, 9);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(421, 76);
            this.iconPictureBox1.TabIndex = 65;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Tag = "";
            this.iconPictureBox1.UseGdi = true;
            // 
            // TPrecioUnitario
            // 
            this.TPrecioUnitario.BackgroundColor = System.Drawing.Color.White;
            this.TPrecioUnitario.Content = "";
            this.TPrecioUnitario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TPrecioUnitario.FocusBackgroundColor = System.Drawing.Color.White;
            this.TPrecioUnitario.FocusImageTint = System.Drawing.Color.White;
            this.TPrecioUnitario.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPrecioUnitario.ForeColor = System.Drawing.Color.Gray;
            this.TPrecioUnitario.Image = null;
            this.TPrecioUnitario.ImageExpand = new System.Drawing.Point(0, 0);
            this.TPrecioUnitario.ImageOffset = new System.Drawing.Point(0, 0);
            this.TPrecioUnitario.Location = new System.Drawing.Point(639, 127);
            this.TPrecioUnitario.Margin = new System.Windows.Forms.Padding(4);
            this.TPrecioUnitario.Multiline = false;
            this.TPrecioUnitario.Name = "TPrecioUnitario";
            this.TPrecioUnitario.NormalImageTint = System.Drawing.Color.White;
            this.TPrecioUnitario.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TPrecioUnitario.Padding = new System.Windows.Forms.Padding(15, 7, 15, 0);
            this.TPrecioUnitario.PasswordChar = false;
            this.TPrecioUnitario.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.TPrecioUnitario.PlaceholderText = "";
            this.TPrecioUnitario.Rounding = new System.Windows.Forms.Padding(2);
            this.TPrecioUnitario.Size = new System.Drawing.Size(109, 29);
            this.TPrecioUnitario.TabIndex = 54;
            this.TPrecioUnitario.TextOffset = new System.Drawing.Size(0, 0);
            this.TPrecioUnitario.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(635, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 53;
            this.label2.Text = "Precio Unitario";
            // 
            // TB_Id_Producto_Oculto
            // 
            this.TB_Id_Producto_Oculto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Id_Producto_Oculto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TB_Id_Producto_Oculto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Id_Producto_Oculto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Id_Producto_Oculto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TB_Id_Producto_Oculto.Location = new System.Drawing.Point(68, 177);
            this.TB_Id_Producto_Oculto.Name = "TB_Id_Producto_Oculto";
            this.TB_Id_Producto_Oculto.Size = new System.Drawing.Size(46, 29);
            this.TB_Id_Producto_Oculto.TabIndex = 52;
            this.TB_Id_Producto_Oculto.Visible = false;
            // 
            // TBModificarIndice
            // 
            this.TBModificarIndice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBModificarIndice.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TBModificarIndice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBModificarIndice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBModificarIndice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBModificarIndice.Location = new System.Drawing.Point(17, 177);
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
            this.NCantidad.Location = new System.Drawing.Point(534, 127);
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
            this.label1.Location = new System.Drawing.Point(15, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar Compras";
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LCantidad.Location = new System.Drawing.Point(536, 103);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(72, 21);
            this.LCantidad.TabIndex = 24;
            this.LCantidad.Text = "Cantidad";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(12, 270);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(389, 29);
            this.txtBuscar.TabIndex = 5;
            // 
            // LProveedor
            // 
            this.LProveedor.AutoSize = true;
            this.LProveedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LProveedor.Location = new System.Drawing.Point(15, 103);
            this.LProveedor.Name = "LProveedor";
            this.LProveedor.Size = new System.Drawing.Size(82, 21);
            this.LProveedor.TabIndex = 22;
            this.LProveedor.Text = "Proveedor";
            // 
            // LProducto
            // 
            this.LProducto.AutoSize = true;
            this.LProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LProducto.Location = new System.Drawing.Point(273, 103);
            this.LProducto.Name = "LProducto";
            this.LProducto.Size = new System.Drawing.Size(127, 21);
            this.LProducto.TabIndex = 8;
            this.LProducto.Text = "Código Producto";
            // 
            // comprasDataGridView
            // 
            this.comprasDataGridView.AllowUserToAddRows = false;
            this.comprasDataGridView.AllowUserToDeleteRows = false;
            this.comprasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.comprasDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.comprasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.comprasDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.comprasDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.comprasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comprasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.id_compra,
            this.Proveedor,
            this.Fecha,
            this.Total,
            this.id_proveedor,
            this.btnImprimirCompra});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.comprasDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.comprasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comprasDataGridView.EnableHeadersVisualStyles = false;
            this.comprasDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.comprasDataGridView.Location = new System.Drawing.Point(10, 289);
            this.comprasDataGridView.Margin = new System.Windows.Forms.Padding(10);
            this.comprasDataGridView.Name = "comprasDataGridView";
            this.comprasDataGridView.ReadOnly = true;
            this.comprasDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.comprasDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.comprasDataGridView.RowHeadersVisible = false;
            this.comprasDataGridView.Size = new System.Drawing.Size(852, 450);
            this.comprasDataGridView.TabIndex = 60;
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
            // id_compra
            // 
            this.id_compra.DataPropertyName = "id_compra";
            this.id_compra.HeaderText = "Nro. Compra";
            this.id_compra.Name = "id_compra";
            this.id_compra.ReadOnly = true;
            // 
            // Proveedor
            // 
            this.Proveedor.DataPropertyName = "objProveedor.nombre_proveedor";
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fecha_compra";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // id_proveedor
            // 
            this.id_proveedor.DataPropertyName = "id_proveedor";
            this.id_proveedor.HeaderText = "id_proveedor";
            this.id_proveedor.Name = "id_proveedor";
            this.id_proveedor.ReadOnly = true;
            this.id_proveedor.Visible = false;
            // 
            // btnImprimirCompra
            // 
            this.btnImprimirCompra.DataPropertyName = "btnImprimir";
            this.btnImprimirCompra.HeaderText = "Imprimir";
            this.btnImprimirCompra.Name = "btnImprimirCompra";
            this.btnImprimirCompra.ReadOnly = true;
            this.btnImprimirCompra.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnImprimirCompra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.comprasDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.31861F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.68138F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(872, 749);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // BRegistrarCompra
            // 
            this.BRegistrarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.BRegistrarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BRegistrarCompra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRegistrarCompra.ForeColor = System.Drawing.Color.White;
            this.BRegistrarCompra.Location = new System.Drawing.Point(52, 101);
            this.BRegistrarCompra.Name = "BRegistrarCompra";
            this.BRegistrarCompra.Size = new System.Drawing.Size(208, 32);
            this.BRegistrarCompra.TabIndex = 63;
            this.BRegistrarCompra.Text = "Registrar Compra";
            this.BRegistrarCompra.UseVisualStyleBackColor = false;
            this.BRegistrarCompra.Click += new System.EventHandler(this.BRegistrarCompra_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(872, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 749);
            this.panel2.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.detallesDataGridView, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(320, 749);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // detallesDataGridView
            // 
            this.detallesDataGridView.AllowUserToAddRows = false;
            this.detallesDataGridView.AllowUserToDeleteRows = false;
            this.detallesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detallesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.detallesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detallesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detallesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.detallesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detallesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre_producto,
            this.cod_producto,
            this.precio_unitario,
            this.cantidad});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.detallesDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.detallesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detallesDataGridView.EnableHeadersVisualStyles = false;
            this.detallesDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.detallesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.detallesDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.detallesDataGridView.Name = "detallesDataGridView";
            this.detallesDataGridView.ReadOnly = true;
            this.detallesDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detallesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.detallesDataGridView.RowHeadersVisible = false;
            this.detallesDataGridView.Size = new System.Drawing.Size(320, 494);
            this.detallesDataGridView.TabIndex = 62;
            this.detallesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.detallesDataGridView_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BRegistrarCompra);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 494);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 255);
            this.panel3.TabIndex = 63;
            // 
            // nombre_producto
            // 
            this.nombre_producto.DataPropertyName = "nombre_producto";
            this.nombre_producto.HeaderText = "Nombre";
            this.nombre_producto.Name = "nombre_producto";
            this.nombre_producto.ReadOnly = true;
            // 
            // cod_producto
            // 
            this.cod_producto.DataPropertyName = "cod_producto";
            this.cod_producto.HeaderText = "Código";
            this.cod_producto.Name = "cod_producto";
            this.cod_producto.ReadOnly = true;
            // 
            // precio_unitario
            // 
            this.precio_unitario.DataPropertyName = "precio_unitario";
            this.precio_unitario.HeaderText = "Precio";
            this.precio_unitario.Name = "precio_unitario";
            this.precio_unitario.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Compras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detallesDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TB_Id_Producto_Oculto;
        private System.Windows.Forms.TextBox TBModificarIndice;
        private System.Windows.Forms.NumericUpDown NCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label LProveedor;
        private System.Windows.Forms.Label LProducto;
        private System.Windows.Forms.DataGridView comprasDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private CuoreUI.Controls.cuiTextBox TPrecioUnitario;
        private System.Windows.Forms.Button BRegistrarCompra;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView detallesDataGridView;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BAgregar;
        private CuoreUI.Controls.cuiTextBox TCodigoProducto;
        private CuoreUI.Controls.cuiTextBox TNombreProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_proveedor;
        private System.Windows.Forms.DataGridViewButtonColumn btnImprimirCompra;
        private System.Windows.Forms.ComboBox CBProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
    }
}