namespace OcioStoreIngSoftII
{
    partial class Informes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TLayoutCategories = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cuiLabel9 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel8 = new CuoreUI.Controls.cuiLabel();
            this.dtpFin = new CuoreUI.Controls.cuiCalendarDatePicker();
            this.dtpInicio = new CuoreUI.Controls.cuiCalendarDatePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVistaPrevia = new CuoreUI.Controls.cuiButton();
            this.txtVendedorSeleccionado = new System.Windows.Forms.TextBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.btnBuscarVendedor = new CuoreUI.Controls.cuiButton();
            this.cbTipoReporte = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnGenerarPDF = new CuoreUI.Controls.cuiButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.dtpHistorialFin = new CuoreUI.Controls.cuiCalendarDatePicker();
            this.dtpHistorialInicio = new CuoreUI.Controls.cuiCalendarDatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarHistorial = new CuoreUI.Controls.cuiButton();
            this.cbFiltroTipo = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cuiTextBox1 = new CuoreUI.Controls.cuiTextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.TLayoutCategories.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1335, 749);
            this.panel1.TabIndex = 0;
            // 
            // TLayoutCategories
            // 
            this.TLayoutCategories.AutoScroll = true;
            this.TLayoutCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.TLayoutCategories.ColumnCount = 1;
            this.TLayoutCategories.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLayoutCategories.Controls.Add(this.tabControl1, 0, 1);
            this.TLayoutCategories.Controls.Add(this.panel2, 0, 0);
            this.TLayoutCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLayoutCategories.Location = new System.Drawing.Point(0, 0);
            this.TLayoutCategories.Name = "TLayoutCategories";
            this.TLayoutCategories.RowCount = 3;
            this.TLayoutCategories.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLayoutCategories.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TLayoutCategories.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLayoutCategories.Size = new System.Drawing.Size(1335, 749);
            this.TLayoutCategories.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(3, 152);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1329, 518);
            this.tabControl1.TabIndex = 60;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1321, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generar Informe";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1315, 479);
            this.panel3.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvVistaPrevia, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1315, 479);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvVistaPrevia
            // 
            this.dgvVistaPrevia.AllowUserToAddRows = false;
            this.dgvVistaPrevia.AllowUserToDeleteRows = false;
            this.dgvVistaPrevia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVistaPrevia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.dgvVistaPrevia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVistaPrevia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVistaPrevia.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvVistaPrevia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVistaPrevia.EnableHeadersVisualStyles = false;
            this.dgvVistaPrevia.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvVistaPrevia.Location = new System.Drawing.Point(15, 203);
            this.dgvVistaPrevia.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.dgvVistaPrevia.MultiSelect = false;
            this.dgvVistaPrevia.Name = "dgvVistaPrevia";
            this.dgvVistaPrevia.ReadOnly = true;
            this.dgvVistaPrevia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVistaPrevia.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvVistaPrevia.RowHeadersVisible = false;
            this.dgvVistaPrevia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVistaPrevia.Size = new System.Drawing.Size(1285, 217);
            this.dgvVistaPrevia.TabIndex = 61;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cuiLabel9);
            this.groupBox1.Controls.Add(this.cuiLabel8);
            this.groupBox1.Controls.Add(this.dtpFin);
            this.groupBox1.Controls.Add(this.dtpInicio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnVistaPrevia);
            this.groupBox1.Controls.Add(this.txtVendedorSeleccionado);
            this.groupBox1.Controls.Add(this.lblVendedor);
            this.groupBox1.Controls.Add(this.btnBuscarVendedor);
            this.groupBox1.Controls.Add(this.cbTipoReporte);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1309, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generar Reportes";
            // 
            // cuiLabel9
            // 
            this.cuiLabel9.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel9.Content = "Hasta:";
            this.cuiLabel9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel9.ForeColor = System.Drawing.Color.White;
            this.cuiLabel9.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel9.Location = new System.Drawing.Point(467, 66);
            this.cuiLabel9.Margin = new System.Windows.Forms.Padding(5);
            this.cuiLabel9.Name = "cuiLabel9";
            this.cuiLabel9.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cuiLabel9.Size = new System.Drawing.Size(117, 28);
            this.cuiLabel9.TabIndex = 76;
            this.cuiLabel9.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel8
            // 
            this.cuiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel8.Content = "Desde:";
            this.cuiLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel8.ForeColor = System.Drawing.Color.White;
            this.cuiLabel8.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel8.Location = new System.Drawing.Point(331, 66);
            this.cuiLabel8.Margin = new System.Windows.Forms.Padding(5);
            this.cuiLabel8.Name = "cuiLabel8";
            this.cuiLabel8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cuiLabel8.Size = new System.Drawing.Size(117, 28);
            this.cuiLabel8.TabIndex = 75;
            this.cuiLabel8.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // dtpFin
            // 
            this.dtpFin.Content = new System.DateTime(2025, 9, 4, 0, 0, 0, 0);
            this.dtpFin.EnableThemeChangeButton = true;
            this.dtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtpFin.ForeColor = System.Drawing.Color.DarkGray;
            this.dtpFin.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dtpFin.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dtpFin.Icon = ((System.Drawing.Image)(resources.GetObject("dtpFin.Icon")));
            this.dtpFin.IconTint = System.Drawing.Color.Gray;
            this.dtpFin.Location = new System.Drawing.Point(467, 94);
            this.dtpFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(128)))));
            this.dtpFin.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(128)))));
            this.dtpFin.OutlineThickness = 1.5F;
            this.dtpFin.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom;
            this.dtpFin.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dtpFin.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dtpFin.Rounding = 8;
            this.dtpFin.ShowIcon = true;
            this.dtpFin.Size = new System.Drawing.Size(117, 45);
            this.dtpFin.TabIndex = 74;
            this.dtpFin.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Content = new System.DateTime(2025, 9, 4, 0, 0, 0, 0);
            this.dtpInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpInicio.EnableThemeChangeButton = true;
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtpInicio.ForeColor = System.Drawing.Color.DarkGray;
            this.dtpInicio.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dtpInicio.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dtpInicio.Icon = ((System.Drawing.Image)(resources.GetObject("dtpInicio.Icon")));
            this.dtpInicio.IconTint = System.Drawing.Color.Gray;
            this.dtpInicio.Location = new System.Drawing.Point(331, 94);
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(128)))));
            this.dtpInicio.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(128)))));
            this.dtpInicio.OutlineThickness = 1.5F;
            this.dtpInicio.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom;
            this.dtpInicio.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dtpInicio.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dtpInicio.Rounding = 8;
            this.dtpInicio.ShowIcon = true;
            this.dtpInicio.Size = new System.Drawing.Size(117, 45);
            this.dtpInicio.TabIndex = 73;
            this.dtpInicio.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(38, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 21);
            this.label2.TabIndex = 72;
            this.label2.Text = "Seleccione Tipo de Informe:";
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.CheckButton = false;
            this.btnVistaPrevia.Checked = false;
            this.btnVistaPrevia.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnVistaPrevia.CheckedForeColor = System.Drawing.Color.White;
            this.btnVistaPrevia.CheckedImageTint = System.Drawing.Color.White;
            this.btnVistaPrevia.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnVistaPrevia.Content = "  Ver Datos";
            this.btnVistaPrevia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVistaPrevia.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVistaPrevia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnVistaPrevia.ForeColor = System.Drawing.Color.White;
            this.btnVistaPrevia.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnVistaPrevia.HoverForeColor = System.Drawing.Color.White;
            this.btnVistaPrevia.HoverImageTint = System.Drawing.Color.White;
            this.btnVistaPrevia.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnVistaPrevia.Image = global::OcioStoreIngSoftII.Properties.Resources.view;
            this.btnVistaPrevia.ImageAutoCenter = true;
            this.btnVistaPrevia.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnVistaPrevia.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnVistaPrevia.Location = new System.Drawing.Point(1094, 101);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.btnVistaPrevia.NormalForeColor = System.Drawing.Color.White;
            this.btnVistaPrevia.NormalImageTint = System.Drawing.Color.White;
            this.btnVistaPrevia.NormalOutline = System.Drawing.Color.DarkBlue;
            this.btnVistaPrevia.OutlineThickness = 1F;
            this.btnVistaPrevia.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.btnVistaPrevia.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnVistaPrevia.PressedImageTint = System.Drawing.Color.White;
            this.btnVistaPrevia.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnVistaPrevia.Rounding = new System.Windows.Forms.Padding(8);
            this.btnVistaPrevia.Size = new System.Drawing.Size(180, 29);
            this.btnVistaPrevia.TabIndex = 71;
            this.btnVistaPrevia.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnVistaPrevia.TextOffset = new System.Drawing.Point(0, 0);
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // txtVendedorSeleccionado
            // 
            this.txtVendedorSeleccionado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendedorSeleccionado.Location = new System.Drawing.Point(834, 101);
            this.txtVendedorSeleccionado.Name = "txtVendedorSeleccionado";
            this.txtVendedorSeleccionado.ReadOnly = true;
            this.txtVendedorSeleccionado.Size = new System.Drawing.Size(222, 27);
            this.txtVendedorSeleccionado.TabIndex = 70;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblVendedor.Location = new System.Drawing.Point(831, 64);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(190, 21);
            this.lblVendedor.TabIndex = 69;
            this.lblVendedor.Text = "Vendedor Seleccionado";
            // 
            // btnBuscarVendedor
            // 
            this.btnBuscarVendedor.CheckButton = false;
            this.btnBuscarVendedor.Checked = false;
            this.btnBuscarVendedor.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnBuscarVendedor.CheckedForeColor = System.Drawing.Color.White;
            this.btnBuscarVendedor.CheckedImageTint = System.Drawing.Color.White;
            this.btnBuscarVendedor.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnBuscarVendedor.Content = "Seleccionar  Vendedor";
            this.btnBuscarVendedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarVendedor.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscarVendedor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBuscarVendedor.ForeColor = System.Drawing.Color.White;
            this.btnBuscarVendedor.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnBuscarVendedor.HoverForeColor = System.Drawing.Color.White;
            this.btnBuscarVendedor.HoverImageTint = System.Drawing.Color.White;
            this.btnBuscarVendedor.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBuscarVendedor.Image = null;
            this.btnBuscarVendedor.ImageAutoCenter = true;
            this.btnBuscarVendedor.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnBuscarVendedor.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnBuscarVendedor.Location = new System.Drawing.Point(631, 99);
            this.btnBuscarVendedor.Name = "btnBuscarVendedor";
            this.btnBuscarVendedor.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.btnBuscarVendedor.NormalForeColor = System.Drawing.Color.White;
            this.btnBuscarVendedor.NormalImageTint = System.Drawing.Color.White;
            this.btnBuscarVendedor.NormalOutline = System.Drawing.Color.DarkBlue;
            this.btnBuscarVendedor.OutlineThickness = 1F;
            this.btnBuscarVendedor.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarVendedor.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBuscarVendedor.PressedImageTint = System.Drawing.Color.White;
            this.btnBuscarVendedor.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBuscarVendedor.Rounding = new System.Windows.Forms.Padding(8);
            this.btnBuscarVendedor.Size = new System.Drawing.Size(180, 29);
            this.btnBuscarVendedor.TabIndex = 68;
            this.btnBuscarVendedor.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnBuscarVendedor.TextOffset = new System.Drawing.Point(0, 0);
            this.btnBuscarVendedor.Click += new System.EventHandler(this.btnBuscarVendedor_Click);
            // 
            // cbTipoReporte
            // 
            this.cbTipoReporte.FormattingEnabled = true;
            this.cbTipoReporte.Location = new System.Drawing.Point(32, 101);
            this.cbTipoReporte.Name = "cbTipoReporte";
            this.cbTipoReporte.Size = new System.Drawing.Size(250, 29);
            this.cbTipoReporte.TabIndex = 0;
            this.cbTipoReporte.SelectedIndexChanged += new System.EventHandler(this.cbTipoReporte_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnGenerarPDF);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1112, 426);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 50);
            this.panel5.TabIndex = 1;
            // 
            // btnGenerarPDF
            // 
            this.btnGenerarPDF.CheckButton = false;
            this.btnGenerarPDF.Checked = false;
            this.btnGenerarPDF.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnGenerarPDF.CheckedForeColor = System.Drawing.Color.White;
            this.btnGenerarPDF.CheckedImageTint = System.Drawing.Color.White;
            this.btnGenerarPDF.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnGenerarPDF.Content = "  Generar PDF";
            this.btnGenerarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarPDF.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGenerarPDF.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnGenerarPDF.ForeColor = System.Drawing.Color.White;
            this.btnGenerarPDF.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnGenerarPDF.HoverForeColor = System.Drawing.Color.White;
            this.btnGenerarPDF.HoverImageTint = System.Drawing.Color.White;
            this.btnGenerarPDF.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGenerarPDF.Image = global::OcioStoreIngSoftII.Properties.Resources.printer_icon;
            this.btnGenerarPDF.ImageAutoCenter = true;
            this.btnGenerarPDF.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnGenerarPDF.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnGenerarPDF.Location = new System.Drawing.Point(10, 16);
            this.btnGenerarPDF.Name = "btnGenerarPDF";
            this.btnGenerarPDF.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.btnGenerarPDF.NormalForeColor = System.Drawing.Color.White;
            this.btnGenerarPDF.NormalImageTint = System.Drawing.Color.White;
            this.btnGenerarPDF.NormalOutline = System.Drawing.Color.DarkBlue;
            this.btnGenerarPDF.OutlineThickness = 1F;
            this.btnGenerarPDF.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.btnGenerarPDF.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnGenerarPDF.PressedImageTint = System.Drawing.Color.White;
            this.btnGenerarPDF.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGenerarPDF.Rounding = new System.Windows.Forms.Padding(8);
            this.btnGenerarPDF.Size = new System.Drawing.Size(180, 29);
            this.btnGenerarPDF.TabIndex = 72;
            this.btnGenerarPDF.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnGenerarPDF.TextOffset = new System.Drawing.Point(0, 0);
            this.btnGenerarPDF.Click += new System.EventHandler(this.btnGenerarPDF_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1321, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Historial de Informes";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1315, 479);
            this.panel4.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dgvHistorial, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1315, 479);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.dgvHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.Titulo,
            this.dataGridViewTextBoxColumn10,
            this.ID});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistorial.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistorial.EnableHeadersVisualStyles = false;
            this.dgvHistorial.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvHistorial.Location = new System.Drawing.Point(15, 203);
            this.dgvHistorial.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.dgvHistorial.MultiSelect = false;
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorial.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvHistorial.RowHeadersVisible = false;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Size = new System.Drawing.Size(1285, 217);
            this.dgvHistorial.TabIndex = 61;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fechaGeneracion";
            dataGridViewCellStyle12.Format = "g";
            dataGridViewCellStyle12.NullValue = null;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle12;
            this.Fecha.HeaderText = "Fecha de Generación";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "tipo_informe";
            this.dataGridViewTextBoxColumn7.HeaderText = "Tipo de Informe";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "usuario_generador";
            this.dataGridViewTextBoxColumn9.HeaderText = "Realizado por";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "titulo";
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn10.HeaderText = "descripcion";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_informe";
            this.ID.HeaderText = "ID Informe";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cuiLabel1);
            this.groupBox2.Controls.Add(this.cuiLabel2);
            this.groupBox2.Controls.Add(this.dtpHistorialFin);
            this.groupBox2.Controls.Add(this.dtpHistorialInicio);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnBuscarHistorial);
            this.groupBox2.Controls.Add(this.cbFiltroTipo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1309, 194);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Reportes";
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel1.Content = "Hasta:";
            this.cuiLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.ForeColor = System.Drawing.Color.White;
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel1.Location = new System.Drawing.Point(467, 66);
            this.cuiLabel1.Margin = new System.Windows.Forms.Padding(5);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cuiLabel1.Size = new System.Drawing.Size(117, 28);
            this.cuiLabel1.TabIndex = 76;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel2
            // 
            this.cuiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel2.Content = "Desde:";
            this.cuiLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel2.ForeColor = System.Drawing.Color.White;
            this.cuiLabel2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel2.Location = new System.Drawing.Point(331, 66);
            this.cuiLabel2.Margin = new System.Windows.Forms.Padding(5);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cuiLabel2.Size = new System.Drawing.Size(117, 28);
            this.cuiLabel2.TabIndex = 75;
            this.cuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // dtpHistorialFin
            // 
            this.dtpHistorialFin.Content = new System.DateTime(2025, 9, 4, 0, 0, 0, 0);
            this.dtpHistorialFin.EnableThemeChangeButton = true;
            this.dtpHistorialFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtpHistorialFin.ForeColor = System.Drawing.Color.DarkGray;
            this.dtpHistorialFin.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dtpHistorialFin.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dtpHistorialFin.Icon = ((System.Drawing.Image)(resources.GetObject("dtpHistorialFin.Icon")));
            this.dtpHistorialFin.IconTint = System.Drawing.Color.Gray;
            this.dtpHistorialFin.Location = new System.Drawing.Point(467, 94);
            this.dtpHistorialFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpHistorialFin.Name = "dtpHistorialFin";
            this.dtpHistorialFin.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(128)))));
            this.dtpHistorialFin.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(128)))));
            this.dtpHistorialFin.OutlineThickness = 1.5F;
            this.dtpHistorialFin.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom;
            this.dtpHistorialFin.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dtpHistorialFin.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dtpHistorialFin.Rounding = 8;
            this.dtpHistorialFin.ShowIcon = true;
            this.dtpHistorialFin.Size = new System.Drawing.Size(117, 45);
            this.dtpHistorialFin.TabIndex = 74;
            this.dtpHistorialFin.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            // 
            // dtpHistorialInicio
            // 
            this.dtpHistorialInicio.Content = new System.DateTime(2025, 9, 4, 0, 0, 0, 0);
            this.dtpHistorialInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpHistorialInicio.EnableThemeChangeButton = true;
            this.dtpHistorialInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtpHistorialInicio.ForeColor = System.Drawing.Color.DarkGray;
            this.dtpHistorialInicio.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dtpHistorialInicio.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dtpHistorialInicio.Icon = ((System.Drawing.Image)(resources.GetObject("dtpHistorialInicio.Icon")));
            this.dtpHistorialInicio.IconTint = System.Drawing.Color.Gray;
            this.dtpHistorialInicio.Location = new System.Drawing.Point(331, 94);
            this.dtpHistorialInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpHistorialInicio.Name = "dtpHistorialInicio";
            this.dtpHistorialInicio.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(128)))));
            this.dtpHistorialInicio.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(128)))));
            this.dtpHistorialInicio.OutlineThickness = 1.5F;
            this.dtpHistorialInicio.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom;
            this.dtpHistorialInicio.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dtpHistorialInicio.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dtpHistorialInicio.Rounding = 8;
            this.dtpHistorialInicio.ShowIcon = true;
            this.dtpHistorialInicio.Size = new System.Drawing.Size(117, 45);
            this.dtpHistorialInicio.TabIndex = 73;
            this.dtpHistorialInicio.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(38, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 21);
            this.label1.TabIndex = 72;
            this.label1.Text = "Seleccione Tipo de Informe:";
            // 
            // btnBuscarHistorial
            // 
            this.btnBuscarHistorial.CheckButton = false;
            this.btnBuscarHistorial.Checked = false;
            this.btnBuscarHistorial.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnBuscarHistorial.CheckedForeColor = System.Drawing.Color.White;
            this.btnBuscarHistorial.CheckedImageTint = System.Drawing.Color.White;
            this.btnBuscarHistorial.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnBuscarHistorial.Content = "Buscar";
            this.btnBuscarHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarHistorial.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscarHistorial.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBuscarHistorial.ForeColor = System.Drawing.Color.White;
            this.btnBuscarHistorial.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnBuscarHistorial.HoverForeColor = System.Drawing.Color.White;
            this.btnBuscarHistorial.HoverImageTint = System.Drawing.Color.White;
            this.btnBuscarHistorial.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBuscarHistorial.Image = global::OcioStoreIngSoftII.Properties.Resources.view;
            this.btnBuscarHistorial.ImageAutoCenter = true;
            this.btnBuscarHistorial.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnBuscarHistorial.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnBuscarHistorial.Location = new System.Drawing.Point(1095, 103);
            this.btnBuscarHistorial.Name = "btnBuscarHistorial";
            this.btnBuscarHistorial.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.btnBuscarHistorial.NormalForeColor = System.Drawing.Color.White;
            this.btnBuscarHistorial.NormalImageTint = System.Drawing.Color.White;
            this.btnBuscarHistorial.NormalOutline = System.Drawing.Color.DarkBlue;
            this.btnBuscarHistorial.OutlineThickness = 1F;
            this.btnBuscarHistorial.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarHistorial.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBuscarHistorial.PressedImageTint = System.Drawing.Color.White;
            this.btnBuscarHistorial.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBuscarHistorial.Rounding = new System.Windows.Forms.Padding(8);
            this.btnBuscarHistorial.Size = new System.Drawing.Size(180, 29);
            this.btnBuscarHistorial.TabIndex = 71;
            this.btnBuscarHistorial.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnBuscarHistorial.TextOffset = new System.Drawing.Point(0, 0);
            this.btnBuscarHistorial.Click += new System.EventHandler(this.btnBuscarHistorial_Click);
            // 
            // cbFiltroTipo
            // 
            this.cbFiltroTipo.FormattingEnabled = true;
            this.cbFiltroTipo.Location = new System.Drawing.Point(32, 103);
            this.cbFiltroTipo.Name = "cbFiltroTipo";
            this.cbFiltroTipo.Size = new System.Drawing.Size(250, 29);
            this.cbFiltroTipo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.cuiTextBox1);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1329, 143);
            this.panel2.TabIndex = 57;
            // 
            // cuiTextBox1
            // 
            this.cuiTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.cuiTextBox1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cuiTextBox1.Content = "Informes";
            this.cuiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cuiTextBox1.Enabled = false;
            this.cuiTextBox1.FocusBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cuiTextBox1.FocusImageTint = System.Drawing.Color.White;
            this.cuiTextBox1.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiTextBox1.Font = new System.Drawing.Font("Segoe UI", 50F);
            this.cuiTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.cuiTextBox1.Image = null;
            this.cuiTextBox1.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiTextBox1.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiTextBox1.Location = new System.Drawing.Point(482, 40);
            this.cuiTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.cuiTextBox1.Multiline = false;
            this.cuiTextBox1.Name = "cuiTextBox1";
            this.cuiTextBox1.NormalImageTint = System.Drawing.Color.White;
            this.cuiTextBox1.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiTextBox1.Padding = new System.Windows.Forms.Padding(89, 2, 89, 0);
            this.cuiTextBox1.PasswordChar = false;
            this.cuiTextBox1.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.cuiTextBox1.PlaceholderText = "";
            this.cuiTextBox1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiTextBox1.Size = new System.Drawing.Size(438, 93);
            this.cuiTextBox1.TabIndex = 13;
            this.cuiTextBox1.TextOffset = new System.Drawing.Size(0, 0);
            this.cuiTextBox1.UnderlinedStyle = true;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 129;
            this.iconPictureBox1.Location = new System.Drawing.Point(360, 27);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(706, 129);
            this.iconPictureBox1.TabIndex = 12;
            this.iconPictureBox1.TabStop = false;
            // 
            // Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 749);
            this.Controls.Add(this.TLayoutCategories);
            this.Controls.Add(this.panel1);
            this.Name = "Informes";
            this.Text = "Informes";
            this.Load += new System.EventHandler(this.Informes_Load);
            this.TLayoutCategories.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel TLayoutCategories;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private CuoreUI.Controls.cuiTextBox cuiTextBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTipoReporte;
        private System.Windows.Forms.TextBox txtVendedorSeleccionado;
        private System.Windows.Forms.Label lblVendedor;
        private CuoreUI.Controls.cuiButton btnBuscarVendedor;
        private System.Windows.Forms.Label label2;
        private CuoreUI.Controls.cuiButton btnVistaPrevia;
        private System.Windows.Forms.Panel panel5;
        private CuoreUI.Controls.cuiButton btnGenerarPDF;
        private CuoreUI.Controls.cuiLabel cuiLabel9;
        private CuoreUI.Controls.cuiLabel cuiLabel8;
        private CuoreUI.Controls.cuiCalendarDatePicker dtpFin;
        private CuoreUI.Controls.cuiCalendarDatePicker dtpInicio;
        private System.Windows.Forms.DataGridView dgvVistaPrevia;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.GroupBox groupBox2;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiCalendarDatePicker dtpHistorialFin;
        private CuoreUI.Controls.cuiCalendarDatePicker dtpHistorialInicio;
        private System.Windows.Forms.Label label1;
        private CuoreUI.Controls.cuiButton btnBuscarHistorial;
        private System.Windows.Forms.ComboBox cbFiltroTipo;
    }
}