namespace OcioStoreIngSoftII
{
    partial class Users
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.usuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROC_BUSCAR_USUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new OcioStoreIngSoftII.DataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.TCUsuarios = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TProvincia = new CuoreUI.Controls.cuiTextBox();
            this.TPassConf = new CuoreUI.Controls.cuiTextBox();
            this.TPass = new CuoreUI.Controls.cuiTextBox();
            this.TDireccion = new CuoreUI.Controls.cuiTextBox();
            this.TLocalidad = new CuoreUI.Controls.cuiTextBox();
            this.TUser = new CuoreUI.Controls.cuiTextBox();
            this.TTelefono = new CuoreUI.Controls.cuiTextBox();
            this.TEmail = new CuoreUI.Controls.cuiTextBox();
            this.TDni = new CuoreUI.Controls.cuiTextBox();
            this.TApellido = new CuoreUI.Controls.cuiTextBox();
            this.TNombre = new CuoreUI.Controls.cuiTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BRegisterUser = new CuoreUI.Controls.cuiButton();
            this.LEstado = new System.Windows.Forms.Label();
            this.LRol = new System.Windows.Forms.Label();
            this.LPassConf = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LPass = new System.Windows.Forms.Label();
            this.LUser = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelModificarUser = new System.Windows.Forms.Panel();
            this.panelInternoModif = new System.Windows.Forms.Panel();
            this.BModificar = new CuoreUI.Controls.cuiButton();
            this.TModificarConfirmPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TModificarPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBModificarRoles = new System.Windows.Forms.ComboBox();
            this.LModificarEstado = new System.Windows.Forms.Label();
            this.CBModificarEstado = new System.Windows.Forms.ComboBox();
            this.LModificarRol = new System.Windows.Forms.Label();
            this.TModificarDni = new System.Windows.Forms.TextBox();
            this.LModificarDni = new System.Windows.Forms.Label();
            this.LModificarUsuario = new System.Windows.Forms.Label();
            this.TModificarUser = new System.Windows.Forms.TextBox();
            this.LModificarApellido = new System.Windows.Forms.Label();
            this.TModificarEmail = new System.Windows.Forms.TextBox();
            this.TModificarAp = new System.Windows.Forms.TextBox();
            this.LModificarEmail = new System.Windows.Forms.Label();
            this.TModificarNombre = new System.Windows.Forms.TextBox();
            this.LModificarNombre = new System.Windows.Forms.Label();
            this.TModificarID_user = new System.Windows.Forms.TextBox();
            this.TBModificarIndice = new System.Windows.Forms.TextBox();
            this.pROC_BUSCAR_USUARIOTableAdapter = new OcioStoreIngSoftII.DataSet1TableAdapters.PROC_BUSCAR_USUARIOTableAdapter();
            this.tableAdapterManager = new OcioStoreIngSoftII.DataSet1TableAdapters.TableAdapterManager();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new OcioStoreIngSoftII.DataSet1TableAdapters.UsersTableAdapter();
            this.CBroles = new System.Windows.Forms.ComboBox();
            this.CBestado = new System.Windows.Forms.ComboBox();
            this.TID_user = new CuoreUI.Controls.cuiTextBox();
            this.TIndice = new CuoreUI.Controls.cuiTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROC_BUSCAR_USUARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.TCUsuarios.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.PanelModificarUser.SuspendLayout();
            this.panelInternoModif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.usuariosDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TCUsuarios, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1142, 688);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // usuariosDataGridView
            // 
            this.usuariosDataGridView.AllowUserToAddRows = false;
            this.usuariosDataGridView.AllowUserToDeleteRows = false;
            this.usuariosDataGridView.AutoGenerateColumns = false;
            this.usuariosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usuariosDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.usuariosDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usuariosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.usuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.id_user,
            this.apellido,
            this.nombre,
            this.dni,
            this.email,
            this.user,
            this.pass,
            this.estadoValor,
            this.estado,
            this.id_rol,
            this.rol});
            this.usuariosDataGridView.DataSource = this.pROC_BUSCAR_USUARIOBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usuariosDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.usuariosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usuariosDataGridView.EnableHeadersVisualStyles = false;
            this.usuariosDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.usuariosDataGridView.Location = new System.Drawing.Point(15, 73);
            this.usuariosDataGridView.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.usuariosDataGridView.Name = "usuariosDataGridView";
            this.usuariosDataGridView.ReadOnly = true;
            this.usuariosDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usuariosDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.usuariosDataGridView.RowHeadersVisible = false;
            this.usuariosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usuariosDataGridView.Size = new System.Drawing.Size(1112, 494);
            this.usuariosDataGridView.TabIndex = 58;
            this.usuariosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usuariosDataGridView_CellContentClick);
            this.usuariosDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.usuariosDataGridView_CellPainting);
            this.usuariosDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.usuariosDataGridView_DataBindingComplete);
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
            // id_user
            // 
            this.id_user.DataPropertyName = "id_user";
            this.id_user.HeaderText = "ID de Usuario";
            this.id_user.Name = "id_user";
            this.id_user.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // dni
            // 
            this.dni.DataPropertyName = "dni";
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "mail";
            this.email.HeaderText = "E-Mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // user
            // 
            this.user.DataPropertyName = "username";
            this.user.HeaderText = "Usuario";
            this.user.Name = "user";
            this.user.ReadOnly = true;
            // 
            // pass
            // 
            this.pass.DataPropertyName = "pass";
            this.pass.HeaderText = "Contraseña";
            this.pass.Name = "pass";
            this.pass.ReadOnly = true;
            // 
            // estadoValor
            // 
            this.estadoValor.DataPropertyName = "baja_user";
            this.estadoValor.HeaderText = "baja_user";
            this.estadoValor.Name = "estadoValor";
            this.estadoValor.ReadOnly = true;
            this.estadoValor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estadoValor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.estadoValor.Visible = false;
            // 
            // estado
            // 
            this.estado.HeaderText = "Dado de Baja?";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // id_rol
            // 
            this.id_rol.DataPropertyName = "id_rol";
            this.id_rol.HeaderText = "id_rol";
            this.id_rol.Name = "id_rol";
            this.id_rol.ReadOnly = true;
            this.id_rol.Visible = false;
            // 
            // rol
            // 
            this.rol.DataPropertyName = "nombre_rol";
            this.rol.HeaderText = "Tipo de Rol";
            this.rol.Name = "rol";
            this.rol.ReadOnly = true;
            // 
            // pROC_BUSCAR_USUARIOBindingSource
            // 
            this.pROC_BUSCAR_USUARIOBindingSource.DataMember = "PROC_BUSCAR_USUARIO";
            this.pROC_BUSCAR_USUARIOBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 64);
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
            this.label1.TabIndex = 7;
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
            // TCUsuarios
            // 
            this.TCUsuarios.AllowDrop = true;
            this.TCUsuarios.Controls.Add(this.tabPage1);
            this.TCUsuarios.Controls.Add(this.tabPage2);
            this.TCUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCUsuarios.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCUsuarios.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TCUsuarios.Location = new System.Drawing.Point(3, 573);
            this.TCUsuarios.Multiline = true;
            this.TCUsuarios.Name = "TCUsuarios";
            this.TCUsuarios.SelectedIndex = 0;
            this.TCUsuarios.Size = new System.Drawing.Size(1136, 494);
            this.TCUsuarios.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1128, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alta de Usuario";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.TIndice);
            this.panel2.Controls.Add(this.TID_user);
            this.panel2.Controls.Add(this.CBestado);
            this.panel2.Controls.Add(this.CBroles);
            this.panel2.Controls.Add(this.TProvincia);
            this.panel2.Controls.Add(this.TPassConf);
            this.panel2.Controls.Add(this.TPass);
            this.panel2.Controls.Add(this.TDireccion);
            this.panel2.Controls.Add(this.TLocalidad);
            this.panel2.Controls.Add(this.TUser);
            this.panel2.Controls.Add(this.TTelefono);
            this.panel2.Controls.Add(this.TEmail);
            this.panel2.Controls.Add(this.TDni);
            this.panel2.Controls.Add(this.TApellido);
            this.panel2.Controls.Add(this.TNombre);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.BRegisterUser);
            this.panel2.Controls.Add(this.LEstado);
            this.panel2.Controls.Add(this.LRol);
            this.panel2.Controls.Add(this.LPassConf);
            this.panel2.Controls.Add(this.LEmail);
            this.panel2.Controls.Add(this.LApellido);
            this.panel2.Controls.Add(this.LDni);
            this.panel2.Controls.Add(this.LNombre);
            this.panel2.Controls.Add(this.LPass);
            this.panel2.Controls.Add(this.LUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1122, 455);
            this.panel2.TabIndex = 0;
            // 
            // TProvincia
            // 
            this.TProvincia.BackgroundColor = System.Drawing.Color.White;
            this.TProvincia.Content = "";
            this.TProvincia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TProvincia.FocusBackgroundColor = System.Drawing.Color.White;
            this.TProvincia.FocusImageTint = System.Drawing.Color.White;
            this.TProvincia.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TProvincia.ForeColor = System.Drawing.Color.Gray;
            this.TProvincia.Image = null;
            this.TProvincia.ImageExpand = new System.Drawing.Point(0, 0);
            this.TProvincia.ImageOffset = new System.Drawing.Point(0, 0);
            this.TProvincia.Location = new System.Drawing.Point(448, 40);
            this.TProvincia.Margin = new System.Windows.Forms.Padding(4);
            this.TProvincia.Multiline = false;
            this.TProvincia.Name = "TProvincia";
            this.TProvincia.NormalImageTint = System.Drawing.Color.White;
            this.TProvincia.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TProvincia.Padding = new System.Windows.Forms.Padding(15, 7, 15, 0);
            this.TProvincia.PasswordChar = false;
            this.TProvincia.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.TProvincia.PlaceholderText = "";
            this.TProvincia.Rounding = new System.Windows.Forms.Padding(8);
            this.TProvincia.Size = new System.Drawing.Size(233, 28);
            this.TProvincia.TabIndex = 74;
            this.TProvincia.TextOffset = new System.Drawing.Size(0, 0);
            this.TProvincia.UnderlinedStyle = true;
            // 
            // TPassConf
            // 
            this.TPassConf.BackgroundColor = System.Drawing.Color.White;
            this.TPassConf.Content = "";
            this.TPassConf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TPassConf.FocusBackgroundColor = System.Drawing.Color.White;
            this.TPassConf.FocusImageTint = System.Drawing.Color.White;
            this.TPassConf.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TPassConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPassConf.ForeColor = System.Drawing.Color.Gray;
            this.TPassConf.Image = null;
            this.TPassConf.ImageExpand = new System.Drawing.Point(0, 0);
            this.TPassConf.ImageOffset = new System.Drawing.Point(0, 0);
            this.TPassConf.Location = new System.Drawing.Point(720, 264);
            this.TPassConf.Margin = new System.Windows.Forms.Padding(4);
            this.TPassConf.Multiline = false;
            this.TPassConf.Name = "TPassConf";
            this.TPassConf.NormalImageTint = System.Drawing.Color.White;
            this.TPassConf.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TPassConf.Padding = new System.Windows.Forms.Padding(15, 7, 15, 0);
            this.TPassConf.PasswordChar = true;
            this.TPassConf.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.TPassConf.PlaceholderText = "";
            this.TPassConf.Rounding = new System.Windows.Forms.Padding(8);
            this.TPassConf.Size = new System.Drawing.Size(233, 28);
            this.TPassConf.TabIndex = 73;
            this.TPassConf.TextOffset = new System.Drawing.Size(0, 0);
            this.TPassConf.UnderlinedStyle = true;
            // 
            // TPass
            // 
            this.TPass.BackgroundColor = System.Drawing.Color.White;
            this.TPass.Content = "";
            this.TPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TPass.FocusBackgroundColor = System.Drawing.Color.White;
            this.TPass.FocusImageTint = System.Drawing.Color.White;
            this.TPass.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPass.ForeColor = System.Drawing.Color.Gray;
            this.TPass.Image = null;
            this.TPass.ImageExpand = new System.Drawing.Point(0, 0);
            this.TPass.ImageOffset = new System.Drawing.Point(0, 0);
            this.TPass.Location = new System.Drawing.Point(720, 208);
            this.TPass.Margin = new System.Windows.Forms.Padding(4);
            this.TPass.Multiline = false;
            this.TPass.Name = "TPass";
            this.TPass.NormalImageTint = System.Drawing.Color.White;
            this.TPass.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TPass.Padding = new System.Windows.Forms.Padding(15, 7, 15, 0);
            this.TPass.PasswordChar = true;
            this.TPass.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.TPass.PlaceholderText = "";
            this.TPass.Rounding = new System.Windows.Forms.Padding(8);
            this.TPass.Size = new System.Drawing.Size(233, 28);
            this.TPass.TabIndex = 72;
            this.TPass.TextOffset = new System.Drawing.Size(0, 0);
            this.TPass.UnderlinedStyle = true;
            // 
            // TDireccion
            // 
            this.TDireccion.BackgroundColor = System.Drawing.Color.White;
            this.TDireccion.Content = "";
            this.TDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TDireccion.FocusBackgroundColor = System.Drawing.Color.White;
            this.TDireccion.FocusImageTint = System.Drawing.Color.White;
            this.TDireccion.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDireccion.ForeColor = System.Drawing.Color.Gray;
            this.TDireccion.Image = null;
            this.TDireccion.ImageExpand = new System.Drawing.Point(0, 0);
            this.TDireccion.ImageOffset = new System.Drawing.Point(0, 0);
            this.TDireccion.Location = new System.Drawing.Point(448, 152);
            this.TDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.TDireccion.Multiline = false;
            this.TDireccion.Name = "TDireccion";
            this.TDireccion.NormalImageTint = System.Drawing.Color.White;
            this.TDireccion.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TDireccion.Padding = new System.Windows.Forms.Padding(15, 63, 15, 0);
            this.TDireccion.PasswordChar = false;
            this.TDireccion.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.TDireccion.PlaceholderText = "";
            this.TDireccion.Rounding = new System.Windows.Forms.Padding(8);
            this.TDireccion.Size = new System.Drawing.Size(233, 140);
            this.TDireccion.TabIndex = 69;
            this.TDireccion.TextOffset = new System.Drawing.Size(0, 0);
            this.TDireccion.UnderlinedStyle = true;
            // 
            // TLocalidad
            // 
            this.TLocalidad.BackgroundColor = System.Drawing.Color.White;
            this.TLocalidad.Content = "";
            this.TLocalidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TLocalidad.FocusBackgroundColor = System.Drawing.Color.White;
            this.TLocalidad.FocusImageTint = System.Drawing.Color.White;
            this.TLocalidad.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLocalidad.ForeColor = System.Drawing.Color.Gray;
            this.TLocalidad.Image = null;
            this.TLocalidad.ImageExpand = new System.Drawing.Point(0, 0);
            this.TLocalidad.ImageOffset = new System.Drawing.Point(0, 0);
            this.TLocalidad.Location = new System.Drawing.Point(448, 96);
            this.TLocalidad.Margin = new System.Windows.Forms.Padding(4);
            this.TLocalidad.Multiline = false;
            this.TLocalidad.Name = "TLocalidad";
            this.TLocalidad.NormalImageTint = System.Drawing.Color.White;
            this.TLocalidad.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TLocalidad.Padding = new System.Windows.Forms.Padding(15, 7, 15, 0);
            this.TLocalidad.PasswordChar = false;
            this.TLocalidad.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.TLocalidad.PlaceholderText = "";
            this.TLocalidad.Rounding = new System.Windows.Forms.Padding(8);
            this.TLocalidad.Size = new System.Drawing.Size(233, 28);
            this.TLocalidad.TabIndex = 68;
            this.TLocalidad.TextOffset = new System.Drawing.Size(0, 0);
            this.TLocalidad.UnderlinedStyle = true;
            // 
            // TUser
            // 
            this.TUser.BackgroundColor = System.Drawing.Color.White;
            this.TUser.Content = "";
            this.TUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TUser.FocusBackgroundColor = System.Drawing.Color.White;
            this.TUser.FocusImageTint = System.Drawing.Color.White;
            this.TUser.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TUser.ForeColor = System.Drawing.Color.Gray;
            this.TUser.Image = null;
            this.TUser.ImageExpand = new System.Drawing.Point(0, 0);
            this.TUser.ImageOffset = new System.Drawing.Point(0, 0);
            this.TUser.Location = new System.Drawing.Point(720, 40);
            this.TUser.Margin = new System.Windows.Forms.Padding(4);
            this.TUser.Multiline = false;
            this.TUser.Name = "TUser";
            this.TUser.NormalImageTint = System.Drawing.Color.White;
            this.TUser.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TUser.Padding = new System.Windows.Forms.Padding(15, 7, 15, 0);
            this.TUser.PasswordChar = false;
            this.TUser.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.TUser.PlaceholderText = "";
            this.TUser.Rounding = new System.Windows.Forms.Padding(8);
            this.TUser.Size = new System.Drawing.Size(233, 28);
            this.TUser.TabIndex = 67;
            this.TUser.TextOffset = new System.Drawing.Size(0, 0);
            this.TUser.UnderlinedStyle = true;
            // 
            // TTelefono
            // 
            this.TTelefono.BackgroundColor = System.Drawing.Color.White;
            this.TTelefono.Content = "";
            this.TTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TTelefono.FocusBackgroundColor = System.Drawing.Color.White;
            this.TTelefono.FocusImageTint = System.Drawing.Color.White;
            this.TTelefono.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTelefono.ForeColor = System.Drawing.Color.Gray;
            this.TTelefono.Image = null;
            this.TTelefono.ImageExpand = new System.Drawing.Point(0, 0);
            this.TTelefono.ImageOffset = new System.Drawing.Point(0, 0);
            this.TTelefono.Location = new System.Drawing.Point(176, 264);
            this.TTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.TTelefono.Multiline = false;
            this.TTelefono.Name = "TTelefono";
            this.TTelefono.NormalImageTint = System.Drawing.Color.White;
            this.TTelefono.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TTelefono.Padding = new System.Windows.Forms.Padding(15, 7, 15, 0);
            this.TTelefono.PasswordChar = false;
            this.TTelefono.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.TTelefono.PlaceholderText = "";
            this.TTelefono.Rounding = new System.Windows.Forms.Padding(8);
            this.TTelefono.Size = new System.Drawing.Size(233, 28);
            this.TTelefono.TabIndex = 66;
            this.TTelefono.TextOffset = new System.Drawing.Size(0, 0);
            this.TTelefono.UnderlinedStyle = true;
            // 
            // TEmail
            // 
            this.TEmail.BackgroundColor = System.Drawing.Color.White;
            this.TEmail.Content = "";
            this.TEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TEmail.FocusBackgroundColor = System.Drawing.Color.White;
            this.TEmail.FocusImageTint = System.Drawing.Color.White;
            this.TEmail.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEmail.ForeColor = System.Drawing.Color.Gray;
            this.TEmail.Image = null;
            this.TEmail.ImageExpand = new System.Drawing.Point(0, 0);
            this.TEmail.ImageOffset = new System.Drawing.Point(0, 0);
            this.TEmail.Location = new System.Drawing.Point(176, 208);
            this.TEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TEmail.Multiline = false;
            this.TEmail.Name = "TEmail";
            this.TEmail.NormalImageTint = System.Drawing.Color.White;
            this.TEmail.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TEmail.Padding = new System.Windows.Forms.Padding(15, 7, 15, 0);
            this.TEmail.PasswordChar = false;
            this.TEmail.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.TEmail.PlaceholderText = "";
            this.TEmail.Rounding = new System.Windows.Forms.Padding(8);
            this.TEmail.Size = new System.Drawing.Size(233, 28);
            this.TEmail.TabIndex = 65;
            this.TEmail.TextOffset = new System.Drawing.Size(0, 0);
            this.TEmail.UnderlinedStyle = true;
            // 
            // TDni
            // 
            this.TDni.BackgroundColor = System.Drawing.Color.White;
            this.TDni.Content = "";
            this.TDni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TDni.FocusBackgroundColor = System.Drawing.Color.White;
            this.TDni.FocusImageTint = System.Drawing.Color.White;
            this.TDni.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDni.ForeColor = System.Drawing.Color.Gray;
            this.TDni.Image = null;
            this.TDni.ImageExpand = new System.Drawing.Point(0, 0);
            this.TDni.ImageOffset = new System.Drawing.Point(0, 0);
            this.TDni.Location = new System.Drawing.Point(176, 152);
            this.TDni.Margin = new System.Windows.Forms.Padding(4);
            this.TDni.Multiline = false;
            this.TDni.Name = "TDni";
            this.TDni.NormalImageTint = System.Drawing.Color.White;
            this.TDni.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TDni.Padding = new System.Windows.Forms.Padding(15, 7, 15, 0);
            this.TDni.PasswordChar = false;
            this.TDni.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.TDni.PlaceholderText = "";
            this.TDni.Rounding = new System.Windows.Forms.Padding(8);
            this.TDni.Size = new System.Drawing.Size(233, 28);
            this.TDni.TabIndex = 64;
            this.TDni.TextOffset = new System.Drawing.Size(0, 0);
            this.TDni.UnderlinedStyle = true;
            // 
            // TApellido
            // 
            this.TApellido.BackgroundColor = System.Drawing.Color.White;
            this.TApellido.Content = "";
            this.TApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TApellido.FocusBackgroundColor = System.Drawing.Color.White;
            this.TApellido.FocusImageTint = System.Drawing.Color.White;
            this.TApellido.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TApellido.ForeColor = System.Drawing.Color.Gray;
            this.TApellido.Image = null;
            this.TApellido.ImageExpand = new System.Drawing.Point(0, 0);
            this.TApellido.ImageOffset = new System.Drawing.Point(0, 0);
            this.TApellido.Location = new System.Drawing.Point(176, 96);
            this.TApellido.Margin = new System.Windows.Forms.Padding(4);
            this.TApellido.Multiline = false;
            this.TApellido.Name = "TApellido";
            this.TApellido.NormalImageTint = System.Drawing.Color.White;
            this.TApellido.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TApellido.Padding = new System.Windows.Forms.Padding(15, 7, 15, 0);
            this.TApellido.PasswordChar = false;
            this.TApellido.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.TApellido.PlaceholderText = "";
            this.TApellido.Rounding = new System.Windows.Forms.Padding(8);
            this.TApellido.Size = new System.Drawing.Size(233, 28);
            this.TApellido.TabIndex = 63;
            this.TApellido.TextOffset = new System.Drawing.Size(0, 0);
            this.TApellido.UnderlinedStyle = true;
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
            this.TNombre.Location = new System.Drawing.Point(176, 40);
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
            this.TNombre.TabIndex = 62;
            this.TNombre.TextOffset = new System.Drawing.Size(0, 0);
            this.TNombre.UnderlinedStyle = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(456, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 21);
            this.label7.TabIndex = 60;
            this.label7.Text = "Dirección";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(456, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 21);
            this.label6.TabIndex = 58;
            this.label6.Text = "Localidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(456, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 56;
            this.label5.Text = "Provincia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(184, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 54;
            this.label4.Text = "Teléfono";
            // 
            // BRegisterUser
            // 
            this.BRegisterUser.CheckButton = false;
            this.BRegisterUser.Checked = false;
            this.BRegisterUser.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.BRegisterUser.CheckedForeColor = System.Drawing.Color.White;
            this.BRegisterUser.CheckedImageTint = System.Drawing.Color.White;
            this.BRegisterUser.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.BRegisterUser.Content = "Registrar Usuario";
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
            this.BRegisterUser.Location = new System.Drawing.Point(496, 312);
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
            this.BRegisterUser.Size = new System.Drawing.Size(143, 32);
            this.BRegisterUser.TabIndex = 53;
            this.BRegisterUser.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BRegisterUser.TextOffset = new System.Drawing.Point(0, 0);
            this.BRegisterUser.Click += new System.EventHandler(this.BRegisterUser_Click);
            // 
            // LEstado
            // 
            this.LEstado.AutoSize = true;
            this.LEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LEstado.Location = new System.Drawing.Point(726, 128);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(56, 21);
            this.LEstado.TabIndex = 50;
            this.LEstado.Text = "Estado";
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LRol.Location = new System.Drawing.Point(726, 72);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(33, 21);
            this.LRol.TabIndex = 49;
            this.LRol.Text = "Rol";
            // 
            // LPassConf
            // 
            this.LPassConf.AutoSize = true;
            this.LPassConf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPassConf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LPassConf.Location = new System.Drawing.Point(726, 240);
            this.LPassConf.Name = "LPassConf";
            this.LPassConf.Size = new System.Drawing.Size(164, 21);
            this.LPassConf.TabIndex = 47;
            this.LPassConf.Text = "Confirmar Contraseña";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LEmail.Location = new System.Drawing.Point(184, 184);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(54, 21);
            this.LEmail.TabIndex = 45;
            this.LEmail.Text = "E-mail";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LApellido.Location = new System.Drawing.Point(184, 72);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(67, 21);
            this.LApellido.TabIndex = 43;
            this.LApellido.Text = "Apellido";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LDni.Location = new System.Drawing.Point(184, 128);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(37, 21);
            this.LDni.TabIndex = 40;
            this.LDni.Text = "DNI";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LNombre.Location = new System.Drawing.Point(184, 16);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(68, 21);
            this.LNombre.TabIndex = 39;
            this.LNombre.Text = "Nombre";
            // 
            // LPass
            // 
            this.LPass.AutoSize = true;
            this.LPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LPass.Location = new System.Drawing.Point(726, 184);
            this.LPass.Name = "LPass";
            this.LPass.Size = new System.Drawing.Size(89, 21);
            this.LPass.TabIndex = 37;
            this.LPass.Text = "Contraseña";
            // 
            // LUser
            // 
            this.LUser.AutoSize = true;
            this.LUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LUser.Location = new System.Drawing.Point(726, 16);
            this.LUser.Name = "LUser";
            this.LUser.Size = new System.Drawing.Size(64, 21);
            this.LUser.TabIndex = 35;
            this.LUser.Text = "Usuario";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tabPage2.Controls.Add(this.tableLayoutPanel7);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1128, 461);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Usuario";
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
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1122, 455);
            this.tableLayoutPanel7.TabIndex = 56;
            // 
            // PanelModificarUser
            // 
            this.PanelModificarUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PanelModificarUser.Controls.Add(this.panelInternoModif);
            this.PanelModificarUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelModificarUser.Location = new System.Drawing.Point(106, 3);
            this.PanelModificarUser.Name = "PanelModificarUser";
            this.PanelModificarUser.Size = new System.Drawing.Size(1013, 449);
            this.PanelModificarUser.TabIndex = 51;
            // 
            // panelInternoModif
            // 
            this.panelInternoModif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panelInternoModif.Controls.Add(this.BModificar);
            this.panelInternoModif.Controls.Add(this.TModificarConfirmPass);
            this.panelInternoModif.Controls.Add(this.label2);
            this.panelInternoModif.Controls.Add(this.TModificarPass);
            this.panelInternoModif.Controls.Add(this.label3);
            this.panelInternoModif.Controls.Add(this.CBModificarRoles);
            this.panelInternoModif.Controls.Add(this.LModificarEstado);
            this.panelInternoModif.Controls.Add(this.CBModificarEstado);
            this.panelInternoModif.Controls.Add(this.LModificarRol);
            this.panelInternoModif.Controls.Add(this.TModificarDni);
            this.panelInternoModif.Controls.Add(this.LModificarDni);
            this.panelInternoModif.Controls.Add(this.LModificarUsuario);
            this.panelInternoModif.Controls.Add(this.TModificarUser);
            this.panelInternoModif.Controls.Add(this.LModificarApellido);
            this.panelInternoModif.Controls.Add(this.TModificarEmail);
            this.panelInternoModif.Controls.Add(this.TModificarAp);
            this.panelInternoModif.Controls.Add(this.LModificarEmail);
            this.panelInternoModif.Controls.Add(this.TModificarNombre);
            this.panelInternoModif.Controls.Add(this.LModificarNombre);
            this.panelInternoModif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInternoModif.Location = new System.Drawing.Point(0, 0);
            this.panelInternoModif.Name = "panelInternoModif";
            this.panelInternoModif.Size = new System.Drawing.Size(1013, 449);
            this.panelInternoModif.TabIndex = 54;
            // 
            // BModificar
            // 
            this.BModificar.CheckButton = false;
            this.BModificar.Checked = false;
            this.BModificar.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.BModificar.CheckedForeColor = System.Drawing.Color.White;
            this.BModificar.CheckedImageTint = System.Drawing.Color.White;
            this.BModificar.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.BModificar.Content = "Modificar Usuario";
            this.BModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BModificar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BModificar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BModificar.ForeColor = System.Drawing.Color.White;
            this.BModificar.HoverBackground = System.Drawing.Color.White;
            this.BModificar.HoverForeColor = System.Drawing.Color.Black;
            this.BModificar.HoverImageTint = System.Drawing.Color.White;
            this.BModificar.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BModificar.Image = null;
            this.BModificar.ImageAutoCenter = true;
            this.BModificar.ImageExpand = new System.Drawing.Point(0, 0);
            this.BModificar.ImageOffset = new System.Drawing.Point(0, 0);
            this.BModificar.Location = new System.Drawing.Point(393, 305);
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
            this.BModificar.Size = new System.Drawing.Size(143, 32);
            this.BModificar.TabIndex = 58;
            this.BModificar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BModificar.TextOffset = new System.Drawing.Point(0, 0);
            this.BModificar.Click += new System.EventHandler(this.BModificar_Click);
            // 
            // TModificarConfirmPass
            // 
            this.TModificarConfirmPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TModificarConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarConfirmPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarConfirmPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarConfirmPass.Location = new System.Drawing.Point(208, 256);
            this.TModificarConfirmPass.Name = "TModificarConfirmPass";
            this.TModificarConfirmPass.PasswordChar = '*';
            this.TModificarConfirmPass.Size = new System.Drawing.Size(232, 29);
            this.TModificarConfirmPass.TabIndex = 57;
            this.TModificarConfirmPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(208, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 56;
            this.label2.Text = "Confirmar Contraseña";
            // 
            // TModificarPass
            // 
            this.TModificarPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TModificarPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarPass.Location = new System.Drawing.Point(208, 200);
            this.TModificarPass.Name = "TModificarPass";
            this.TModificarPass.PasswordChar = '*';
            this.TModificarPass.Size = new System.Drawing.Size(232, 29);
            this.TModificarPass.TabIndex = 55;
            this.TModificarPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(208, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 54;
            this.label3.Text = "Contraseña";
            // 
            // CBModificarRoles
            // 
            this.CBModificarRoles.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CBModificarRoles.DisplayMember = "id_rol";
            this.CBModificarRoles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBModificarRoles.FormattingEnabled = true;
            this.CBModificarRoles.Location = new System.Drawing.Point(480, 144);
            this.CBModificarRoles.Name = "CBModificarRoles";
            this.CBModificarRoles.Size = new System.Drawing.Size(231, 29);
            this.CBModificarRoles.TabIndex = 46;
            this.CBModificarRoles.ValueMember = "id_rol";
            // 
            // LModificarEstado
            // 
            this.LModificarEstado.AutoSize = true;
            this.LModificarEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LModificarEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarEstado.Location = new System.Drawing.Point(480, 176);
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
            this.CBModificarEstado.Location = new System.Drawing.Point(480, 200);
            this.CBModificarEstado.Name = "CBModificarEstado";
            this.CBModificarEstado.Size = new System.Drawing.Size(232, 29);
            this.CBModificarEstado.TabIndex = 43;
            this.CBModificarEstado.ValueMember = "estado";
            // 
            // LModificarRol
            // 
            this.LModificarRol.AutoSize = true;
            this.LModificarRol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LModificarRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarRol.Location = new System.Drawing.Point(480, 120);
            this.LModificarRol.Name = "LModificarRol";
            this.LModificarRol.Size = new System.Drawing.Size(33, 21);
            this.LModificarRol.TabIndex = 42;
            this.LModificarRol.Text = "Rol";
            // 
            // TModificarDni
            // 
            this.TModificarDni.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TModificarDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarDni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarDni.Location = new System.Drawing.Point(480, 32);
            this.TModificarDni.Name = "TModificarDni";
            this.TModificarDni.Size = new System.Drawing.Size(232, 29);
            this.TModificarDni.TabIndex = 34;
            // 
            // LModificarDni
            // 
            this.LModificarDni.AutoSize = true;
            this.LModificarDni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LModificarDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarDni.Location = new System.Drawing.Point(480, 8);
            this.LModificarDni.Name = "LModificarDni";
            this.LModificarDni.Size = new System.Drawing.Size(37, 21);
            this.LModificarDni.TabIndex = 33;
            this.LModificarDni.Text = "DNI";
            // 
            // LModificarUsuario
            // 
            this.LModificarUsuario.AutoSize = true;
            this.LModificarUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LModificarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarUsuario.Location = new System.Drawing.Point(480, 64);
            this.LModificarUsuario.Name = "LModificarUsuario";
            this.LModificarUsuario.Size = new System.Drawing.Size(64, 21);
            this.LModificarUsuario.TabIndex = 25;
            this.LModificarUsuario.Text = "Usuario";
            // 
            // TModificarUser
            // 
            this.TModificarUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TModificarUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarUser.Location = new System.Drawing.Point(480, 88);
            this.TModificarUser.Name = "TModificarUser";
            this.TModificarUser.Size = new System.Drawing.Size(232, 29);
            this.TModificarUser.TabIndex = 26;
            // 
            // LModificarApellido
            // 
            this.LModificarApellido.AutoSize = true;
            this.LModificarApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LModificarApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarApellido.Location = new System.Drawing.Point(208, 64);
            this.LModificarApellido.Name = "LModificarApellido";
            this.LModificarApellido.Size = new System.Drawing.Size(67, 21);
            this.LModificarApellido.TabIndex = 31;
            this.LModificarApellido.Text = "Apellido";
            // 
            // TModificarEmail
            // 
            this.TModificarEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TModificarEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarEmail.Location = new System.Drawing.Point(208, 144);
            this.TModificarEmail.Name = "TModificarEmail";
            this.TModificarEmail.Size = new System.Drawing.Size(232, 29);
            this.TModificarEmail.TabIndex = 34;
            // 
            // TModificarAp
            // 
            this.TModificarAp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TModificarAp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarAp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarAp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarAp.Location = new System.Drawing.Point(208, 88);
            this.TModificarAp.Name = "TModificarAp";
            this.TModificarAp.Size = new System.Drawing.Size(232, 29);
            this.TModificarAp.TabIndex = 32;
            // 
            // LModificarEmail
            // 
            this.LModificarEmail.AutoSize = true;
            this.LModificarEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LModificarEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarEmail.Location = new System.Drawing.Point(208, 120);
            this.LModificarEmail.Name = "LModificarEmail";
            this.LModificarEmail.Size = new System.Drawing.Size(54, 21);
            this.LModificarEmail.TabIndex = 33;
            this.LModificarEmail.Text = "E-mail";
            // 
            // TModificarNombre
            // 
            this.TModificarNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TModificarNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarNombre.Location = new System.Drawing.Point(208, 32);
            this.TModificarNombre.Name = "TModificarNombre";
            this.TModificarNombre.Size = new System.Drawing.Size(232, 29);
            this.TModificarNombre.TabIndex = 30;
            // 
            // LModificarNombre
            // 
            this.LModificarNombre.AutoSize = true;
            this.LModificarNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LModificarNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarNombre.Location = new System.Drawing.Point(208, 8);
            this.LModificarNombre.Name = "LModificarNombre";
            this.LModificarNombre.Size = new System.Drawing.Size(68, 21);
            this.LModificarNombre.TabIndex = 29;
            this.LModificarNombre.Text = "Nombre";
            // 
            // TModificarID_user
            // 
            this.TModificarID_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TModificarID_user.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TModificarID_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarID_user.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarID_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarID_user.Location = new System.Drawing.Point(54, 3);
            this.TModificarID_user.Name = "TModificarID_user";
            this.TModificarID_user.Size = new System.Drawing.Size(46, 27);
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
            this.TBModificarIndice.Size = new System.Drawing.Size(45, 27);
            this.TBModificarIndice.TabIndex = 49;
            this.TBModificarIndice.Text = "-1";
            this.TBModificarIndice.Visible = false;
            // 
            // pROC_BUSCAR_USUARIOTableAdapter
            // 
            this.pROC_BUSCAR_USUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriasTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DetalleVentasTableAdapter = null;
            this.tableAdapterManager.InformeDetalleTableAdapter = null;
            this.tableAdapterManager.InformeTableAdapter = null;
            this.tableAdapterManager.MetodosPagoTableAdapter = null;
            this.tableAdapterManager.PermisosTableAdapter = null;
            this.tableAdapterManager.PROC_BUSCAR_PRODUCTOTableAdapter = null;
            this.tableAdapterManager.PROC_BUSCAR_USUARIOTableAdapter = null;
            this.tableAdapterManager.ProductosCategoriasTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OcioStoreIngSoftII.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dataSet1;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // CBroles
            // 
            this.CBroles.FormattingEnabled = true;
            this.CBroles.Location = new System.Drawing.Point(720, 97);
            this.CBroles.Name = "CBroles";
            this.CBroles.Size = new System.Drawing.Size(233, 28);
            this.CBroles.TabIndex = 75;
            // 
            // CBestado
            // 
            this.CBestado.FormattingEnabled = true;
            this.CBestado.Location = new System.Drawing.Point(720, 153);
            this.CBestado.Name = "CBestado";
            this.CBestado.Size = new System.Drawing.Size(233, 28);
            this.CBestado.TabIndex = 76;
            // 
            // TID_user
            // 
            this.TID_user.BackgroundColor = System.Drawing.Color.White;
            this.TID_user.Content = "";
            this.TID_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TID_user.FocusBackgroundColor = System.Drawing.Color.White;
            this.TID_user.FocusImageTint = System.Drawing.Color.White;
            this.TID_user.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TID_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TID_user.ForeColor = System.Drawing.Color.Gray;
            this.TID_user.Image = null;
            this.TID_user.ImageExpand = new System.Drawing.Point(0, 0);
            this.TID_user.ImageOffset = new System.Drawing.Point(0, 0);
            this.TID_user.Location = new System.Drawing.Point(19, 414);
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
            this.TID_user.TabIndex = 77;
            this.TID_user.TextOffset = new System.Drawing.Size(0, 0);
            this.TID_user.UnderlinedStyle = true;
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
            this.TIndice.Location = new System.Drawing.Point(94, 414);
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
            this.TIndice.TabIndex = 78;
            this.TIndice.TextOffset = new System.Drawing.Size(0, 0);
            this.TIndice.UnderlinedStyle = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(15, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 21);
            this.label8.TabIndex = 79;
            this.label8.Text = "ID User";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(94, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 21);
            this.label9.TabIndex = 79;
            this.label9.Text = "Indice";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1142, 688);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROC_BUSCAR_USUARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TCUsuarios.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.PanelModificarUser.ResumeLayout(false);
            this.panelInternoModif.ResumeLayout(false);
            this.panelInternoModif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pROC_BUSCAR_USUARIOBindingSource;
        private DataSet1TableAdapters.PROC_BUSCAR_USUARIOTableAdapter pROC_BUSCAR_USUARIOTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView usuariosDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TabControl TCUsuarios;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Panel PanelModificarUser;
        private System.Windows.Forms.Panel panelInternoModif;
        private System.Windows.Forms.ComboBox CBModificarRoles;
        private System.Windows.Forms.Label LModificarEstado;
        private System.Windows.Forms.ComboBox CBModificarEstado;
        private System.Windows.Forms.Label LModificarRol;
        private System.Windows.Forms.TextBox TModificarDni;
        private System.Windows.Forms.Label LModificarDni;
        private System.Windows.Forms.Label LModificarUsuario;
        private System.Windows.Forms.TextBox TModificarUser;
        private System.Windows.Forms.Label LModificarApellido;
        private System.Windows.Forms.TextBox TModificarEmail;
        private System.Windows.Forms.TextBox TModificarAp;
        private System.Windows.Forms.Label LModificarEmail;
        private System.Windows.Forms.TextBox TModificarNombre;
        private System.Windows.Forms.Label LModificarNombre;
        private System.Windows.Forms.TextBox TModificarID_user;
        private System.Windows.Forms.TextBox TBModificarIndice;
        private System.Windows.Forms.TextBox TModificarConfirmPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TModificarPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private CuoreUI.Controls.cuiButton BModificar;
        private System.Windows.Forms.Panel panel2;
        private CuoreUI.Controls.cuiTextBox TApellido;
        private CuoreUI.Controls.cuiTextBox TNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private CuoreUI.Controls.cuiButton BRegisterUser;
        private System.Windows.Forms.Label LEstado;
        private System.Windows.Forms.Label LRol;
        private System.Windows.Forms.Label LPassConf;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LPass;
        private System.Windows.Forms.Label LUser;
        private CuoreUI.Controls.cuiTextBox TDireccion;
        private CuoreUI.Controls.cuiTextBox TLocalidad;
        private CuoreUI.Controls.cuiTextBox TUser;
        private CuoreUI.Controls.cuiTextBox TTelefono;
        private CuoreUI.Controls.cuiTextBox TEmail;
        private CuoreUI.Controls.cuiTextBox TDni;
        private CuoreUI.Controls.cuiTextBox TProvincia;
        private CuoreUI.Controls.cuiTextBox TPassConf;
        private CuoreUI.Controls.cuiTextBox TPass;
        private System.Windows.Forms.ComboBox CBestado;
        private System.Windows.Forms.ComboBox CBroles;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private CuoreUI.Controls.cuiTextBox TIndice;
        private CuoreUI.Controls.cuiTextBox TID_user;
    }
}