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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pROCBUSCARCATEGORIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new OcioStoreIngSoftII.DataSet1();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriasTableAdapter = new OcioStoreIngSoftII.DataSet1TableAdapters.CategoriasTableAdapter();
            this.pROC_BUSCAR_CATEGORIATableAdapter = new OcioStoreIngSoftII.DataSet1TableAdapters.PROC_BUSCAR_CATEGORIATableAdapter();
            this.TCUsuarios = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelInternoAlta = new System.Windows.Forms.Panel();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.LEstado = new System.Windows.Forms.Label();
            this.BRegisterUser = new System.Windows.Forms.Button();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.TID_user = new System.Windows.Forms.TextBox();
            this.TIndice = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelModificarUser = new System.Windows.Forms.Panel();
            this.panelInternoModif = new System.Windows.Forms.Panel();
            this.LModificarEstado = new System.Windows.Forms.Label();
            this.CBModificarEstado = new System.Windows.Forms.ComboBox();
            this.TModificarNombre = new System.Windows.Forms.TextBox();
            this.LModificarNombre = new System.Windows.Forms.Label();
            this.BModificar = new System.Windows.Forms.Button();
            this.TModificarID_user = new System.Windows.Forms.TextBox();
            this.TBModificarIndice = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.categoriasDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idcategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baja_estado_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baja_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pROCBUSCARCATEGORIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            this.TCUsuarios.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelInternoAlta.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.PanelModificarUser.SuspendLayout();
            this.panelInternoModif.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pROCBUSCARCATEGORIABindingSource
            // 
            this.pROCBUSCARCATEGORIABindingSource.DataMember = "PROC_BUSCAR_CATEGORIA";
            this.pROCBUSCARCATEGORIABindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "Categorias";
            this.categoriasBindingSource.DataSource = this.dataSet1;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // pROC_BUSCAR_CATEGORIATableAdapter
            // 
            this.pROC_BUSCAR_CATEGORIATableAdapter.ClearBeforeFill = true;
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
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1203, 240);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alta de Categoría";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.632153F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.722979F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.64487F));
            this.tableLayoutPanel2.Controls.Add(this.panelInternoAlta, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.TID_user, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TIndice, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1197, 234);
            this.tableLayoutPanel2.TabIndex = 58;
            // 
            // panelInternoAlta
            // 
            this.panelInternoAlta.Controls.Add(this.CBEstado);
            this.panelInternoAlta.Controls.Add(this.LEstado);
            this.panelInternoAlta.Controls.Add(this.BRegisterUser);
            this.panelInternoAlta.Controls.Add(this.TNombre);
            this.panelInternoAlta.Controls.Add(this.LNombre);
            this.panelInternoAlta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInternoAlta.Location = new System.Drawing.Point(114, 3);
            this.panelInternoAlta.Name = "panelInternoAlta";
            this.panelInternoAlta.Size = new System.Drawing.Size(1080, 228);
            this.panelInternoAlta.TabIndex = 54;
            // 
            // CBEstado
            // 
            this.CBEstado.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CBEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Location = new System.Drawing.Point(488, 32);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(232, 29);
            this.CBEstado.TabIndex = 25;
            // 
            // LEstado
            // 
            this.LEstado.AutoSize = true;
            this.LEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LEstado.Location = new System.Drawing.Point(488, 8);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(56, 21);
            this.LEstado.TabIndex = 24;
            this.LEstado.Text = "Estado";
            // 
            // BRegisterUser
            // 
            this.BRegisterUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.BRegisterUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BRegisterUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRegisterUser.ForeColor = System.Drawing.Color.White;
            this.BRegisterUser.Location = new System.Drawing.Point(376, 80);
            this.BRegisterUser.Name = "BRegisterUser";
            this.BRegisterUser.Size = new System.Drawing.Size(168, 32);
            this.BRegisterUser.TabIndex = 20;
            this.BRegisterUser.Text = "Registrar Categoría";
            this.BRegisterUser.UseVisualStyleBackColor = false;
            // 
            // TNombre
            // 
            this.TNombre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TNombre.Location = new System.Drawing.Point(216, 32);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(232, 29);
            this.TNombre.TabIndex = 9;
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LNombre.Location = new System.Drawing.Point(216, 8);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(68, 21);
            this.LNombre.TabIndex = 8;
            this.LNombre.Text = "Nombre";
            // 
            // TID_user
            // 
            this.TID_user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TID_user.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TID_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TID_user.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TID_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TID_user.Location = new System.Drawing.Point(58, 3);
            this.TID_user.Name = "TID_user";
            this.TID_user.Size = new System.Drawing.Size(50, 27);
            this.TID_user.TabIndex = 53;
            this.TID_user.Text = "0";
            this.TID_user.Visible = false;
            // 
            // TIndice
            // 
            this.TIndice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TIndice.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TIndice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TIndice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIndice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TIndice.Location = new System.Drawing.Point(3, 3);
            this.TIndice.Name = "TIndice";
            this.TIndice.Size = new System.Drawing.Size(49, 27);
            this.TIndice.TabIndex = 52;
            this.TIndice.Text = "-1";
            this.TIndice.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tabPage2.Controls.Add(this.tableLayoutPanel7);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1203, 240);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Categoría";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.632153F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.722979F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.64487F));
            this.tableLayoutPanel7.Controls.Add(this.PanelModificarUser, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.TModificarID_user, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.TBModificarIndice, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1197, 234);
            this.tableLayoutPanel7.TabIndex = 56;
            // 
            // PanelModificarUser
            // 
            this.PanelModificarUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PanelModificarUser.Controls.Add(this.panelInternoModif);
            this.PanelModificarUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelModificarUser.Location = new System.Drawing.Point(114, 3);
            this.PanelModificarUser.Name = "PanelModificarUser";
            this.PanelModificarUser.Size = new System.Drawing.Size(1080, 228);
            this.PanelModificarUser.TabIndex = 51;
            // 
            // panelInternoModif
            // 
            this.panelInternoModif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panelInternoModif.Controls.Add(this.LModificarEstado);
            this.panelInternoModif.Controls.Add(this.CBModificarEstado);
            this.panelInternoModif.Controls.Add(this.TModificarNombre);
            this.panelInternoModif.Controls.Add(this.LModificarNombre);
            this.panelInternoModif.Controls.Add(this.BModificar);
            this.panelInternoModif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInternoModif.Location = new System.Drawing.Point(0, 0);
            this.panelInternoModif.Name = "panelInternoModif";
            this.panelInternoModif.Size = new System.Drawing.Size(1080, 228);
            this.panelInternoModif.TabIndex = 54;
            // 
            // LModificarEstado
            // 
            this.LModificarEstado.AutoSize = true;
            this.LModificarEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LModificarEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarEstado.Location = new System.Drawing.Point(488, 8);
            this.LModificarEstado.Name = "LModificarEstado";
            this.LModificarEstado.Size = new System.Drawing.Size(56, 21);
            this.LModificarEstado.TabIndex = 44;
            this.LModificarEstado.Text = "Estado";
            // 
            // CBModificarEstado
            // 
            this.CBModificarEstado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CBModificarEstado.DisplayMember = "estado";
            this.CBModificarEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBModificarEstado.FormattingEnabled = true;
            this.CBModificarEstado.Location = new System.Drawing.Point(488, 32);
            this.CBModificarEstado.Name = "CBModificarEstado";
            this.CBModificarEstado.Size = new System.Drawing.Size(232, 29);
            this.CBModificarEstado.TabIndex = 43;
            this.CBModificarEstado.ValueMember = "estado";
            // 
            // TModificarNombre
            // 
            this.TModificarNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TModificarNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarNombre.Location = new System.Drawing.Point(216, 32);
            this.TModificarNombre.Name = "TModificarNombre";
            this.TModificarNombre.Size = new System.Drawing.Size(232, 29);
            this.TModificarNombre.TabIndex = 30;
            // 
            // LModificarNombre
            // 
            this.LModificarNombre.AutoSize = true;
            this.LModificarNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LModificarNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarNombre.Location = new System.Drawing.Point(216, 8);
            this.LModificarNombre.Name = "LModificarNombre";
            this.LModificarNombre.Size = new System.Drawing.Size(68, 21);
            this.LModificarNombre.TabIndex = 29;
            this.LModificarNombre.Text = "Nombre";
            // 
            // BModificar
            // 
            this.BModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.BModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BModificar.ForeColor = System.Drawing.Color.White;
            this.BModificar.Location = new System.Drawing.Point(376, 80);
            this.BModificar.Name = "BModificar";
            this.BModificar.Size = new System.Drawing.Size(168, 32);
            this.BModificar.TabIndex = 21;
            this.BModificar.Text = "Modificar Categoría";
            this.BModificar.UseVisualStyleBackColor = false;
            // 
            // TModificarID_user
            // 
            this.TModificarID_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TModificarID_user.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TModificarID_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarID_user.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarID_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarID_user.Location = new System.Drawing.Point(58, 3);
            this.TModificarID_user.Name = "TModificarID_user";
            this.TModificarID_user.Size = new System.Drawing.Size(50, 27);
            this.TModificarID_user.TabIndex = 50;
            this.TModificarID_user.Visible = false;
            // 
            // TBModificarIndice
            // 
            this.TBModificarIndice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBModificarIndice.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TBModificarIndice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBModificarIndice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBModificarIndice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBModificarIndice.Location = new System.Drawing.Point(3, 3);
            this.TBModificarIndice.Name = "TBModificarIndice";
            this.TBModificarIndice.Size = new System.Drawing.Size(49, 27);
            this.TBModificarIndice.TabIndex = 49;
            this.TBModificarIndice.Text = "-1";
            this.TBModificarIndice.Visible = false;
            // 
            // panel1
            // 
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
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // categoriasDataGridView
            // 
            this.categoriasDataGridView.AllowUserToAddRows = false;
            this.categoriasDataGridView.AllowUserToDeleteRows = false;
            this.categoriasDataGridView.AutoGenerateColumns = false;
            this.categoriasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoriasDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.categoriasDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoriasDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.categoriasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.idcategoriaDataGridViewTextBoxColumn,
            this.nombrecategoriaDataGridViewTextBoxColumn,
            this.baja_estado_valor,
            this.baja_estado});
            this.categoriasDataGridView.DataSource = this.pROCBUSCARCATEGORIABindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categoriasDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.categoriasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriasDataGridView.EnableHeadersVisualStyles = false;
            this.categoriasDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.categoriasDataGridView.Location = new System.Drawing.Point(15, 87);
            this.categoriasDataGridView.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.categoriasDataGridView.Name = "categoriasDataGridView";
            this.categoriasDataGridView.ReadOnly = true;
            this.categoriasDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoriasDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.categoriasDataGridView.RowHeadersVisible = false;
            this.categoriasDataGridView.Size = new System.Drawing.Size(1187, 334);
            this.categoriasDataGridView.TabIndex = 58;
            this.categoriasDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoriasDataGridView_CellContentClick);
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
            // idcategoriaDataGridViewTextBoxColumn
            // 
            this.idcategoriaDataGridViewTextBoxColumn.DataPropertyName = "id_categoria";
            this.idcategoriaDataGridViewTextBoxColumn.HeaderText = "ID de Categoría";
            this.idcategoriaDataGridViewTextBoxColumn.Name = "idcategoriaDataGridViewTextBoxColumn";
            this.idcategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombrecategoriaDataGridViewTextBoxColumn
            // 
            this.nombrecategoriaDataGridViewTextBoxColumn.DataPropertyName = "nombre_categoria";
            this.nombrecategoriaDataGridViewTextBoxColumn.HeaderText = "Categoría";
            this.nombrecategoriaDataGridViewTextBoxColumn.Name = "nombrecategoriaDataGridViewTextBoxColumn";
            this.nombrecategoriaDataGridViewTextBoxColumn.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.pROCBUSCARCATEGORIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            this.TCUsuarios.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panelInternoAlta.ResumeLayout(false);
            this.panelInternoAlta.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.PanelModificarUser.ResumeLayout(false);
            this.panelInternoModif.ResumeLayout(false);
            this.panelInternoModif.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private DataSet1TableAdapters.CategoriasTableAdapter categoriasTableAdapter;
        private System.Windows.Forms.BindingSource pROCBUSCARCATEGORIABindingSource;
        private DataSet1TableAdapters.PROC_BUSCAR_CATEGORIATableAdapter pROC_BUSCAR_CATEGORIATableAdapter;
        private System.Windows.Forms.TabControl TCUsuarios;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panelInternoAlta;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.Label LEstado;
        private System.Windows.Forms.Button BRegisterUser;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox TID_user;
        private System.Windows.Forms.TextBox TIndice;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView categoriasDataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baja_estado_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn baja_estado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Panel PanelModificarUser;
        private System.Windows.Forms.Panel panelInternoModif;
        private System.Windows.Forms.Label LModificarEstado;
        private System.Windows.Forms.ComboBox CBModificarEstado;
        private System.Windows.Forms.TextBox TModificarNombre;
        private System.Windows.Forms.Label LModificarNombre;
        private System.Windows.Forms.Button BModificar;
        private System.Windows.Forms.TextBox TModificarID_user;
        private System.Windows.Forms.TextBox TBModificarIndice;
    }
}