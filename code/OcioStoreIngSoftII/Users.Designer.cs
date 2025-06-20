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
            this.TCUsuarios = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PanelAltaUser = new System.Windows.Forms.Panel();
            this.panelInternoAlta = new System.Windows.Forms.Panel();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.CBroles = new System.Windows.Forms.ComboBox();
            this.LEstado = new System.Windows.Forms.Label();
            this.LRol = new System.Windows.Forms.Label();
            this.BRegisterUser = new System.Windows.Forms.Button();
            this.TPassConf = new System.Windows.Forms.TextBox();
            this.LPassConf = new System.Windows.Forms.Label();
            this.TEmail = new System.Windows.Forms.TextBox();
            this.LEmail = new System.Windows.Forms.Label();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.LApellido = new System.Windows.Forms.Label();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.TPass = new System.Windows.Forms.TextBox();
            this.LPass = new System.Windows.Forms.Label();
            this.TUser = new System.Windows.Forms.TextBox();
            this.LUser = new System.Windows.Forms.Label();
            this.TIndice = new System.Windows.Forms.TextBox();
            this.TID_user = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PanelModificarUser = new System.Windows.Forms.Panel();
            this.panelInternoModif = new System.Windows.Forms.Panel();
            this.TModificarConfirmPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TModificarPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BEliminar = new System.Windows.Forms.Button();
            this.CBModificarRoles = new System.Windows.Forms.ComboBox();
            this.LModificarEstado = new System.Windows.Forms.Label();
            this.CBModificarEstado = new System.Windows.Forms.ComboBox();
            this.LModificarRol = new System.Windows.Forms.Label();
            this.TModificarEmail = new System.Windows.Forms.TextBox();
            this.LModificarEmail = new System.Windows.Forms.Label();
            this.TModificarAp = new System.Windows.Forms.TextBox();
            this.LModificarApellido = new System.Windows.Forms.Label();
            this.TModificarNombre = new System.Windows.Forms.TextBox();
            this.LModificarNombre = new System.Windows.Forms.Label();
            this.TModificarUser = new System.Windows.Forms.TextBox();
            this.LModificarUsuario = new System.Windows.Forms.Label();
            this.BModificar = new System.Windows.Forms.Button();
            this.TBModificarIndice = new System.Windows.Forms.TextBox();
            this.TModificarID_user = new System.Windows.Forms.TextBox();
            this.usuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pROC_BUSCAR_USUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new OcioStoreIngSoftII.DataSet1();
            this.pROC_BUSCAR_USUARIOTableAdapter = new OcioStoreIngSoftII.DataSet1TableAdapters.PROC_BUSCAR_USUARIOTableAdapter();
            this.tableAdapterManager = new OcioStoreIngSoftII.DataSet1TableAdapters.TableAdapterManager();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new OcioStoreIngSoftII.DataSet1TableAdapters.UsersTableAdapter();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.TCUsuarios.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.PanelAltaUser.SuspendLayout();
            this.panelInternoAlta.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.PanelModificarUser.SuspendLayout();
            this.panelInternoModif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROC_BUSCAR_USUARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.TCUsuarios, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.usuariosDataGridView, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1142, 688);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // TCUsuarios
            // 
            this.TCUsuarios.AllowDrop = true;
            this.TCUsuarios.Controls.Add(this.tabPage1);
            this.TCUsuarios.Controls.Add(this.tabPage2);
            this.TCUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCUsuarios.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCUsuarios.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TCUsuarios.Location = new System.Drawing.Point(3, 3);
            this.TCUsuarios.Multiline = true;
            this.TCUsuarios.Name = "TCUsuarios";
            this.TCUsuarios.SelectedIndex = 0;
            this.TCUsuarios.Size = new System.Drawing.Size(1136, 414);
            this.TCUsuarios.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.PanelAltaUser);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 383);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alta de Usuario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // PanelAltaUser
            // 
            this.PanelAltaUser.AutoScroll = true;
            this.PanelAltaUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PanelAltaUser.Controls.Add(this.panelInternoAlta);
            this.PanelAltaUser.Controls.Add(this.TIndice);
            this.PanelAltaUser.Controls.Add(this.TID_user);
            this.PanelAltaUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAltaUser.Location = new System.Drawing.Point(3, 3);
            this.PanelAltaUser.Name = "PanelAltaUser";
            this.PanelAltaUser.Size = new System.Drawing.Size(970, 377);
            this.PanelAltaUser.TabIndex = 7;
            this.PanelAltaUser.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelAltaUser_Paint);
            this.PanelAltaUser.Resize += new System.EventHandler(this.PanelAltaUser_Resize);
            // 
            // panelInternoAlta
            // 
            this.panelInternoAlta.Controls.Add(this.CBEstado);
            this.panelInternoAlta.Controls.Add(this.CBroles);
            this.panelInternoAlta.Controls.Add(this.LEstado);
            this.panelInternoAlta.Controls.Add(this.LRol);
            this.panelInternoAlta.Controls.Add(this.BRegisterUser);
            this.panelInternoAlta.Controls.Add(this.TPassConf);
            this.panelInternoAlta.Controls.Add(this.LPassConf);
            this.panelInternoAlta.Controls.Add(this.TEmail);
            this.panelInternoAlta.Controls.Add(this.LEmail);
            this.panelInternoAlta.Controls.Add(this.TApellido);
            this.panelInternoAlta.Controls.Add(this.LApellido);
            this.panelInternoAlta.Controls.Add(this.TNombre);
            this.panelInternoAlta.Controls.Add(this.LNombre);
            this.panelInternoAlta.Controls.Add(this.TPass);
            this.panelInternoAlta.Controls.Add(this.LPass);
            this.panelInternoAlta.Controls.Add(this.TUser);
            this.panelInternoAlta.Controls.Add(this.LUser);
            this.panelInternoAlta.Location = new System.Drawing.Point(201, 49);
            this.panelInternoAlta.Name = "panelInternoAlta";
            this.panelInternoAlta.Size = new System.Drawing.Size(568, 303);
            this.panelInternoAlta.TabIndex = 51;
            this.panelInternoAlta.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInterno_Paint);
            // 
            // CBEstado
            // 
            this.CBEstado.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Location = new System.Drawing.Point(301, 151);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(232, 26);
            this.CBEstado.TabIndex = 25;
            // 
            // CBroles
            // 
            this.CBroles.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CBroles.DisplayMember = "id_rol";
            this.CBroles.FormattingEnabled = true;
            this.CBroles.Location = new System.Drawing.Point(301, 92);
            this.CBroles.Name = "CBroles";
            this.CBroles.Size = new System.Drawing.Size(231, 26);
            this.CBroles.TabIndex = 24;
            this.CBroles.ValueMember = "id_rol";
            // 
            // LEstado
            // 
            this.LEstado.AutoSize = true;
            this.LEstado.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LEstado.Location = new System.Drawing.Point(297, 123);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(52, 23);
            this.LEstado.TabIndex = 24;
            this.LEstado.Text = "Estado";
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LRol.Location = new System.Drawing.Point(297, 64);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(30, 23);
            this.LRol.TabIndex = 22;
            this.LRol.Text = "Rol";
            // 
            // BRegisterUser
            // 
            this.BRegisterUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.BRegisterUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BRegisterUser.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRegisterUser.ForeColor = System.Drawing.Color.White;
            this.BRegisterUser.Location = new System.Drawing.Point(346, 259);
            this.BRegisterUser.Name = "BRegisterUser";
            this.BRegisterUser.Size = new System.Drawing.Size(143, 32);
            this.BRegisterUser.TabIndex = 20;
            this.BRegisterUser.Text = "Registrar Usuario";
            this.BRegisterUser.UseVisualStyleBackColor = false;
            // 
            // TPassConf
            // 
            this.TPassConf.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TPassConf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TPassConf.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPassConf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TPassConf.Location = new System.Drawing.Point(301, 210);
            this.TPassConf.Name = "TPassConf";
            this.TPassConf.PasswordChar = '*';
            this.TPassConf.Size = new System.Drawing.Size(232, 27);
            this.TPassConf.TabIndex = 19;
            this.TPassConf.UseSystemPasswordChar = true;
            // 
            // LPassConf
            // 
            this.LPassConf.AutoSize = true;
            this.LPassConf.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LPassConf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LPassConf.Location = new System.Drawing.Point(297, 182);
            this.LPassConf.Name = "LPassConf";
            this.LPassConf.Size = new System.Drawing.Size(150, 23);
            this.LPassConf.TabIndex = 18;
            this.LPassConf.Text = "Confirmar Contraseña";
            // 
            // TEmail
            // 
            this.TEmail.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEmail.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TEmail.Location = new System.Drawing.Point(31, 150);
            this.TEmail.Name = "TEmail";
            this.TEmail.Size = new System.Drawing.Size(232, 27);
            this.TEmail.TabIndex = 13;
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LEmail.Location = new System.Drawing.Point(27, 123);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(52, 23);
            this.LEmail.TabIndex = 12;
            this.LEmail.Text = "E-mail";
            // 
            // TApellido
            // 
            this.TApellido.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TApellido.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TApellido.Location = new System.Drawing.Point(31, 91);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(232, 27);
            this.TApellido.TabIndex = 11;
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LApellido.Location = new System.Drawing.Point(27, 64);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(60, 23);
            this.LApellido.TabIndex = 10;
            this.LApellido.Text = "Apellido";
            // 
            // TNombre
            // 
            this.TNombre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TNombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TNombre.Location = new System.Drawing.Point(31, 32);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(232, 27);
            this.TNombre.TabIndex = 9;
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LNombre.Location = new System.Drawing.Point(27, 4);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(58, 23);
            this.LNombre.TabIndex = 8;
            this.LNombre.Text = "Nombre";
            // 
            // TPass
            // 
            this.TPass.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TPass.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TPass.Location = new System.Drawing.Point(31, 210);
            this.TPass.Name = "TPass";
            this.TPass.PasswordChar = '*';
            this.TPass.Size = new System.Drawing.Size(232, 27);
            this.TPass.TabIndex = 7;
            this.TPass.UseSystemPasswordChar = true;
            // 
            // LPass
            // 
            this.LPass.AutoSize = true;
            this.LPass.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LPass.Location = new System.Drawing.Point(27, 182);
            this.LPass.Name = "LPass";
            this.LPass.Size = new System.Drawing.Size(82, 23);
            this.LPass.TabIndex = 6;
            this.LPass.Text = "Contraseña";
            // 
            // TUser
            // 
            this.TUser.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TUser.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TUser.Location = new System.Drawing.Point(301, 32);
            this.TUser.Name = "TUser";
            this.TUser.Size = new System.Drawing.Size(232, 27);
            this.TUser.TabIndex = 5;
            // 
            // LUser
            // 
            this.LUser.AutoSize = true;
            this.LUser.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LUser.Location = new System.Drawing.Point(297, 4);
            this.LUser.Name = "LUser";
            this.LUser.Size = new System.Drawing.Size(58, 23);
            this.LUser.TabIndex = 4;
            this.LUser.Text = "Usuario";
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
            this.TID_user.Location = new System.Drawing.Point(63, 16);
            this.TID_user.Name = "TID_user";
            this.TID_user.Size = new System.Drawing.Size(36, 27);
            this.TID_user.TabIndex = 49;
            this.TID_user.Text = "0";
            this.TID_user.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PanelModificarUser);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1128, 383);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Usuario";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PanelModificarUser
            // 
            this.PanelModificarUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PanelModificarUser.Controls.Add(this.TModificarConfirmPass);
            this.PanelModificarUser.Controls.Add(this.panelInternoModif);
            this.PanelModificarUser.Controls.Add(this.label2);
            this.PanelModificarUser.Controls.Add(this.TBModificarIndice);
            this.PanelModificarUser.Controls.Add(this.TModificarPass);
            this.PanelModificarUser.Controls.Add(this.TModificarID_user);
            this.PanelModificarUser.Controls.Add(this.label3);
            this.PanelModificarUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelModificarUser.Location = new System.Drawing.Point(3, 3);
            this.PanelModificarUser.Name = "PanelModificarUser";
            this.PanelModificarUser.Size = new System.Drawing.Size(1122, 377);
            this.PanelModificarUser.TabIndex = 8;
            this.PanelModificarUser.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelModificarUser_Paint);
            this.PanelModificarUser.Resize += new System.EventHandler(this.PanelModificarUser_Resize);
            // 
            // panelInternoModif
            // 
            this.panelInternoModif.Controls.Add(this.BEliminar);
            this.panelInternoModif.Controls.Add(this.CBModificarRoles);
            this.panelInternoModif.Controls.Add(this.LModificarEstado);
            this.panelInternoModif.Controls.Add(this.CBModificarEstado);
            this.panelInternoModif.Controls.Add(this.LModificarRol);
            this.panelInternoModif.Controls.Add(this.TModificarEmail);
            this.panelInternoModif.Controls.Add(this.LModificarEmail);
            this.panelInternoModif.Controls.Add(this.TModificarAp);
            this.panelInternoModif.Controls.Add(this.LModificarApellido);
            this.panelInternoModif.Controls.Add(this.TModificarNombre);
            this.panelInternoModif.Controls.Add(this.LModificarNombre);
            this.panelInternoModif.Controls.Add(this.TModificarUser);
            this.panelInternoModif.Controls.Add(this.LModificarUsuario);
            this.panelInternoModif.Controls.Add(this.BModificar);
            this.panelInternoModif.Location = new System.Drawing.Point(211, 33);
            this.panelInternoModif.Name = "panelInternoModif";
            this.panelInternoModif.Size = new System.Drawing.Size(549, 311);
            this.panelInternoModif.TabIndex = 54;
            this.panelInternoModif.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInternoModif_Paint);
            this.panelInternoModif.Resize += new System.EventHandler(this.panelInternoModif_Resize);
            // 
            // TModificarConfirmPass
            // 
            this.TModificarConfirmPass.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TModificarConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarConfirmPass.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarConfirmPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarConfirmPass.Location = new System.Drawing.Point(795, 242);
            this.TModificarConfirmPass.Name = "TModificarConfirmPass";
            this.TModificarConfirmPass.PasswordChar = '*';
            this.TModificarConfirmPass.Size = new System.Drawing.Size(232, 27);
            this.TModificarConfirmPass.TabIndex = 53;
            this.TModificarConfirmPass.UseSystemPasswordChar = true;
            this.TModificarConfirmPass.Visible = false;
            this.TModificarConfirmPass.TextChanged += new System.EventHandler(this.TModificarConfirmPass_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(791, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "Confirmar Contraseña";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TModificarPass
            // 
            this.TModificarPass.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TModificarPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarPass.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarPass.Location = new System.Drawing.Point(795, 177);
            this.TModificarPass.Name = "TModificarPass";
            this.TModificarPass.PasswordChar = '*';
            this.TModificarPass.Size = new System.Drawing.Size(232, 27);
            this.TModificarPass.TabIndex = 51;
            this.TModificarPass.UseSystemPasswordChar = true;
            this.TModificarPass.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(791, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 50;
            this.label3.Text = "Contraseña";
            this.label3.Visible = false;
            // 
            // BEliminar
            // 
            this.BEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.BEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BEliminar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEliminar.ForeColor = System.Drawing.Color.White;
            this.BEliminar.Location = new System.Drawing.Point(71, 230);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(143, 32);
            this.BEliminar.TabIndex = 49;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.UseVisualStyleBackColor = false;
            // 
            // CBModificarRoles
            // 
            this.CBModificarRoles.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CBModificarRoles.FormattingEnabled = true;
            this.CBModificarRoles.Location = new System.Drawing.Point(296, 131);
            this.CBModificarRoles.Name = "CBModificarRoles";
            this.CBModificarRoles.Size = new System.Drawing.Size(231, 26);
            this.CBModificarRoles.TabIndex = 46;
            this.CBModificarRoles.ValueMember = "id_rol";
            // 
            // LModificarEstado
            // 
            this.LModificarEstado.AutoSize = true;
            this.LModificarEstado.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LModificarEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarEstado.Location = new System.Drawing.Point(292, 158);
            this.LModificarEstado.Name = "LModificarEstado";
            this.LModificarEstado.Size = new System.Drawing.Size(52, 23);
            this.LModificarEstado.TabIndex = 44;
            this.LModificarEstado.Text = "Estado";
            // 
            // CBModificarEstado
            // 
            this.CBModificarEstado.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CBModificarEstado.DisplayMember = "estado";
            this.CBModificarEstado.FormattingEnabled = true;
            this.CBModificarEstado.Location = new System.Drawing.Point(295, 184);
            this.CBModificarEstado.Name = "CBModificarEstado";
            this.CBModificarEstado.Size = new System.Drawing.Size(232, 26);
            this.CBModificarEstado.TabIndex = 43;
            this.CBModificarEstado.ValueMember = "estado";
            // 
            // LModificarRol
            // 
            this.LModificarRol.AutoSize = true;
            this.LModificarRol.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LModificarRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarRol.Location = new System.Drawing.Point(292, 105);
            this.LModificarRol.Name = "LModificarRol";
            this.LModificarRol.Size = new System.Drawing.Size(30, 23);
            this.LModificarRol.TabIndex = 42;
            this.LModificarRol.Text = "Rol";
            // 
            // TModificarEmail
            // 
            this.TModificarEmail.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TModificarEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarEmail.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarEmail.Location = new System.Drawing.Point(26, 183);
            this.TModificarEmail.Name = "TModificarEmail";
            this.TModificarEmail.Size = new System.Drawing.Size(232, 27);
            this.TModificarEmail.TabIndex = 34;
            // 
            // LModificarEmail
            // 
            this.LModificarEmail.AutoSize = true;
            this.LModificarEmail.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LModificarEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarEmail.Location = new System.Drawing.Point(22, 158);
            this.LModificarEmail.Name = "LModificarEmail";
            this.LModificarEmail.Size = new System.Drawing.Size(52, 23);
            this.LModificarEmail.TabIndex = 33;
            this.LModificarEmail.Text = "E-mail";
            // 
            // TModificarAp
            // 
            this.TModificarAp.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TModificarAp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarAp.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarAp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarAp.Location = new System.Drawing.Point(26, 130);
            this.TModificarAp.Name = "TModificarAp";
            this.TModificarAp.Size = new System.Drawing.Size(232, 27);
            this.TModificarAp.TabIndex = 32;
            // 
            // LModificarApellido
            // 
            this.LModificarApellido.AutoSize = true;
            this.LModificarApellido.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LModificarApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarApellido.Location = new System.Drawing.Point(22, 105);
            this.LModificarApellido.Name = "LModificarApellido";
            this.LModificarApellido.Size = new System.Drawing.Size(60, 23);
            this.LModificarApellido.TabIndex = 31;
            this.LModificarApellido.Text = "Apellido";
            // 
            // TModificarNombre
            // 
            this.TModificarNombre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TModificarNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarNombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarNombre.Location = new System.Drawing.Point(26, 75);
            this.TModificarNombre.Name = "TModificarNombre";
            this.TModificarNombre.Size = new System.Drawing.Size(232, 27);
            this.TModificarNombre.TabIndex = 30;
            // 
            // LModificarNombre
            // 
            this.LModificarNombre.AutoSize = true;
            this.LModificarNombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LModificarNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarNombre.Location = new System.Drawing.Point(21, 50);
            this.LModificarNombre.Name = "LModificarNombre";
            this.LModificarNombre.Size = new System.Drawing.Size(58, 23);
            this.LModificarNombre.TabIndex = 29;
            this.LModificarNombre.Text = "Nombre";
            // 
            // TModificarUser
            // 
            this.TModificarUser.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TModificarUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarUser.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarUser.Location = new System.Drawing.Point(296, 75);
            this.TModificarUser.Name = "TModificarUser";
            this.TModificarUser.Size = new System.Drawing.Size(232, 27);
            this.TModificarUser.TabIndex = 26;
            // 
            // LModificarUsuario
            // 
            this.LModificarUsuario.AutoSize = true;
            this.LModificarUsuario.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LModificarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarUsuario.Location = new System.Drawing.Point(292, 49);
            this.LModificarUsuario.Name = "LModificarUsuario";
            this.LModificarUsuario.Size = new System.Drawing.Size(58, 23);
            this.LModificarUsuario.TabIndex = 25;
            this.LModificarUsuario.Text = "Usuario";
            // 
            // BModificar
            // 
            this.BModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.BModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BModificar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BModificar.ForeColor = System.Drawing.Color.White;
            this.BModificar.Location = new System.Drawing.Point(340, 230);
            this.BModificar.Name = "BModificar";
            this.BModificar.Size = new System.Drawing.Size(143, 32);
            this.BModificar.TabIndex = 21;
            this.BModificar.Text = "Modificar Usuario";
            this.BModificar.UseVisualStyleBackColor = false;
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
            // 
            // usuariosDataGridView
            // 
            this.usuariosDataGridView.AllowUserToAddRows = false;
            this.usuariosDataGridView.AllowUserToDeleteRows = false;
            this.usuariosDataGridView.AutoGenerateColumns = false;
            this.usuariosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usuariosDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.usuariosDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
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
            this.estado,
            this.id_rol,
            this.rol});
            this.usuariosDataGridView.DataSource = this.pROC_BUSCAR_USUARIOBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usuariosDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.usuariosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usuariosDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.usuariosDataGridView.Location = new System.Drawing.Point(3, 523);
            this.usuariosDataGridView.Name = "usuariosDataGridView";
            this.usuariosDataGridView.ReadOnly = true;
            this.usuariosDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usuariosDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.usuariosDataGridView.RowHeadersVisible = false;
            this.usuariosDataGridView.Size = new System.Drawing.Size(1136, 176);
            this.usuariosDataGridView.TabIndex = 8;
            this.usuariosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pROC_BUSCAR_USUARIODataGridView_CellContentClick);
            this.usuariosDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.usuariosDataGridView_CellFormatting);
            this.usuariosDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.pROC_BUSCAR_USUARIODataGridView_CellPainting);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 423);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 94);
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
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
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
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.btnSeleccionar.HeaderText = "Seleccionar";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnSeleccionar.Width = 110;
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
            // estado
            // 
            this.estado.DataPropertyName = "baja_user";
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
            this.TCUsuarios.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.PanelAltaUser.ResumeLayout(false);
            this.PanelAltaUser.PerformLayout();
            this.panelInternoAlta.ResumeLayout(false);
            this.panelInternoAlta.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.PanelModificarUser.ResumeLayout(false);
            this.PanelModificarUser.PerformLayout();
            this.panelInternoModif.ResumeLayout(false);
            this.panelInternoModif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROC_BUSCAR_USUARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource pROC_BUSCAR_USUARIOBindingSource;
        private DataSet1TableAdapters.PROC_BUSCAR_USUARIOTableAdapter pROC_BUSCAR_USUARIOTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TabControl TCUsuarios;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel PanelAltaUser;
        private System.Windows.Forms.TextBox TIndice;
        private System.Windows.Forms.TextBox TID_user;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.ComboBox CBroles;
        private System.Windows.Forms.Label LEstado;
        private System.Windows.Forms.Label LRol;
        private System.Windows.Forms.Button BRegisterUser;
        private System.Windows.Forms.TextBox TPassConf;
        private System.Windows.Forms.Label LPassConf;
        private System.Windows.Forms.TextBox TEmail;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox TPass;
        private System.Windows.Forms.Label LPass;
        private System.Windows.Forms.TextBox TUser;
        private System.Windows.Forms.Label LUser;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel PanelModificarUser;
        private System.Windows.Forms.TextBox TModificarConfirmPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TModificarPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.TextBox TBModificarIndice;
        private System.Windows.Forms.TextBox TModificarID_user;
        private System.Windows.Forms.ComboBox CBModificarRoles;
        private System.Windows.Forms.Label LModificarEstado;
        private System.Windows.Forms.ComboBox CBModificarEstado;
        private System.Windows.Forms.Label LModificarRol;
        private System.Windows.Forms.TextBox TModificarEmail;
        private System.Windows.Forms.Label LModificarEmail;
        private System.Windows.Forms.TextBox TModificarAp;
        private System.Windows.Forms.Label LModificarApellido;
        private System.Windows.Forms.TextBox TModificarNombre;
        private System.Windows.Forms.Label LModificarNombre;
        private System.Windows.Forms.TextBox TModificarUser;
        private System.Windows.Forms.Label LModificarUsuario;
        private System.Windows.Forms.Button BModificar;
        private System.Windows.Forms.DataGridView usuariosDataGridView;
        private System.Windows.Forms.Panel panelInternoAlta;
        private System.Windows.Forms.Panel panelInternoModif;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
    }
}