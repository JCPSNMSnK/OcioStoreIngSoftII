namespace OcioStoreIngSoftII
{
    partial class Backup
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.BtnExaminar = new FontAwesome.Sharp.IconButton();
            this.BtnRealizarBackup = new CuoreUI.Controls.cuiButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.lblEstado = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            this.TRutaBackup = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cuiCircleProgressBar1 = new CuoreUI.Controls.cuiCircleProgressBar();
            this.cuiLabel7 = new CuoreUI.Controls.cuiLabel();
            this.BackupDataGridView = new System.Windows.Forms.DataGridView();
            this.progressBarBackup = new System.Windows.Forms.ProgressBar();
            this.BtnRecarcar = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFinBackup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamaño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RutaBackup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackupDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(1142, 688);
            this.splitContainer1.SplitterDistance = 496;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.cuiLabel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(496, 688);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Content = "Ruta\\ de\\ Destino:";
            this.cuiLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.ForeColor = System.Drawing.Color.White;
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel1.Location = new System.Drawing.Point(33, 78);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(144, 39);
            this.cuiLabel1.TabIndex = 12;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // BtnExaminar
            // 
            this.BtnExaminar.BackColor = System.Drawing.Color.White;
            this.BtnExaminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnExaminar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExaminar.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.BtnExaminar.IconColor = System.Drawing.Color.Black;
            this.BtnExaminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExaminar.IconSize = 24;
            this.BtnExaminar.Location = new System.Drawing.Point(338, 122);
            this.BtnExaminar.Name = "BtnExaminar";
            this.BtnExaminar.Size = new System.Drawing.Size(124, 27);
            this.BtnExaminar.TabIndex = 8;
            this.BtnExaminar.Text = "Examinar...";
            this.BtnExaminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExaminar.UseVisualStyleBackColor = false;
            this.BtnExaminar.Click += new System.EventHandler(this.BtnExaminar_Click);
            // 
            // BtnRealizarBackup
            // 
            this.BtnRealizarBackup.CheckButton = false;
            this.BtnRealizarBackup.Checked = false;
            this.BtnRealizarBackup.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.BtnRealizarBackup.CheckedForeColor = System.Drawing.Color.White;
            this.BtnRealizarBackup.CheckedImageTint = System.Drawing.Color.White;
            this.BtnRealizarBackup.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.BtnRealizarBackup.Content = "";
            this.BtnRealizarBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRealizarBackup.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnRealizarBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRealizarBackup.ForeColor = System.Drawing.Color.White;
            this.BtnRealizarBackup.HoverBackground = System.Drawing.Color.White;
            this.BtnRealizarBackup.HoverForeColor = System.Drawing.Color.Black;
            this.BtnRealizarBackup.HoverImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.BtnRealizarBackup.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnRealizarBackup.Image = global::OcioStoreIngSoftII.Properties.Resources.floppy_disk_solid_full;
            this.BtnRealizarBackup.ImageAutoCenter = true;
            this.BtnRealizarBackup.ImageExpand = new System.Drawing.Point(0, 0);
            this.BtnRealizarBackup.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnRealizarBackup.Location = new System.Drawing.Point(168, 252);
            this.BtnRealizarBackup.Name = "BtnRealizarBackup";
            this.BtnRealizarBackup.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.BtnRealizarBackup.NormalForeColor = System.Drawing.Color.White;
            this.BtnRealizarBackup.NormalImageTint = System.Drawing.Color.White;
            this.BtnRealizarBackup.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnRealizarBackup.OutlineThickness = 1F;
            this.BtnRealizarBackup.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.BtnRealizarBackup.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnRealizarBackup.PressedImageTint = System.Drawing.Color.Black;
            this.BtnRealizarBackup.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnRealizarBackup.Rounding = new System.Windows.Forms.Padding(8);
            this.BtnRealizarBackup.Size = new System.Drawing.Size(131, 129);
            this.BtnRealizarBackup.TabIndex = 7;
            this.BtnRealizarBackup.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnRealizarBackup.TextOffset = new System.Drawing.Point(0, 0);
            this.BtnRealizarBackup.Click += new System.EventHandler(this.BtnRealizarBackup_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBarBackup);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.BtnExaminar);
            this.panel1.Controls.Add(this.BtnRealizarBackup);
            this.panel1.Controls.Add(this.cuiLabel1);
            this.panel1.Controls.Add(this.cuiLabel4);
            this.panel1.Controls.Add(this.TRutaBackup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 582);
            this.panel1.TabIndex = 0;
            // 
            // cuiLabel2
            // 
            this.cuiLabel2.Content = "Realizar\\ nuevo\\ Backup";
            this.cuiLabel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.cuiLabel2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel2.ForeColor = System.Drawing.Color.White;
            this.cuiLabel2.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel2.Location = new System.Drawing.Point(10, 10);
            this.cuiLabel2.Margin = new System.Windows.Forms.Padding(10);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Padding = new System.Windows.Forms.Padding(10);
            this.cuiLabel2.Size = new System.Drawing.Size(403, 80);
            this.cuiLabel2.TabIndex = 14;
            this.cuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblEstado
            // 
            this.lblEstado.Content = "Seleccione\\ una\\ ruta\\ de\\ destino\\.";
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblEstado.Location = new System.Drawing.Point(22, 206);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(439, 40);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel4
            // 
            this.cuiLabel4.Content = "Realizar\\ Backup";
            this.cuiLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel4.ForeColor = System.Drawing.Color.White;
            this.cuiLabel4.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel4.Location = new System.Drawing.Point(168, 376);
            this.cuiLabel4.Name = "cuiLabel4";
            this.cuiLabel4.Size = new System.Drawing.Size(131, 40);
            this.cuiLabel4.TabIndex = 14;
            this.cuiLabel4.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // TRutaBackup
            // 
            this.TRutaBackup.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRutaBackup.Location = new System.Drawing.Point(23, 122);
            this.TRutaBackup.Name = "TRutaBackup";
            this.TRutaBackup.ReadOnly = true;
            this.TRutaBackup.Size = new System.Drawing.Size(316, 27);
            this.TRutaBackup.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(642, 688);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BackupDataGridView);
            this.panel2.Controls.Add(this.cuiCircleProgressBar1);
            this.panel2.Controls.Add(this.cuiLabel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 103);
            this.panel2.Margin = new System.Windows.Forms.Padding(10, 3, 10, 20);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.panel2.Size = new System.Drawing.Size(622, 565);
            this.panel2.TabIndex = 0;
            // 
            // cuiCircleProgressBar1
            // 
            this.cuiCircleProgressBar1.BorderWidth = 12;
            this.cuiCircleProgressBar1.Location = new System.Drawing.Point(209, 446);
            this.cuiCircleProgressBar1.MaximumValue = 100;
            this.cuiCircleProgressBar1.MinimumSize = new System.Drawing.Size(24, 24);
            this.cuiCircleProgressBar1.MinimumValue = 0;
            this.cuiCircleProgressBar1.Name = "cuiCircleProgressBar1";
            this.cuiCircleProgressBar1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(120)))));
            this.cuiCircleProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiCircleProgressBar1.ProgressValue = 50;
            this.cuiCircleProgressBar1.RoundedEnds = true;
            this.cuiCircleProgressBar1.Size = new System.Drawing.Size(48, 48);
            this.cuiCircleProgressBar1.TabIndex = 10;
            this.cuiCircleProgressBar1.Visible = false;
            // 
            // cuiLabel7
            // 
            this.cuiLabel7.Content = "Realizar\\ Backup";
            this.cuiLabel7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel7.ForeColor = System.Drawing.Color.White;
            this.cuiLabel7.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel7.Location = new System.Drawing.Point(168, 376);
            this.cuiLabel7.Name = "cuiLabel7";
            this.cuiLabel7.Size = new System.Drawing.Size(131, 40);
            this.cuiLabel7.TabIndex = 14;
            this.cuiLabel7.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // BackupDataGridView
            // 
            this.BackupDataGridView.AllowUserToAddRows = false;
            this.BackupDataGridView.AllowUserToDeleteRows = false;
            this.BackupDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.BackupDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BackupDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BackupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BackupDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Fecha_Inicio,
            this.FechaFinBackup,
            this.Tamaño,
            this.RutaBackup});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BackupDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.BackupDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackupDataGridView.EnableHeadersVisualStyles = false;
            this.BackupDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackupDataGridView.Location = new System.Drawing.Point(10, 10);
            this.BackupDataGridView.Margin = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.BackupDataGridView.MultiSelect = false;
            this.BackupDataGridView.Name = "BackupDataGridView";
            this.BackupDataGridView.ReadOnly = true;
            this.BackupDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BackupDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.BackupDataGridView.RowHeadersVisible = false;
            this.BackupDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BackupDataGridView.Size = new System.Drawing.Size(592, 545);
            this.BackupDataGridView.TabIndex = 61;
            // 
            // progressBarBackup
            // 
            this.progressBarBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            this.progressBarBackup.Location = new System.Drawing.Point(168, 433);
            this.progressBarBackup.Name = "progressBarBackup";
            this.progressBarBackup.Size = new System.Drawing.Size(131, 23);
            this.progressBarBackup.TabIndex = 16;
            this.progressBarBackup.Visible = false;
            // 
            // BtnRecarcar
            // 
            this.BtnRecarcar.BackColor = System.Drawing.Color.White;
            this.BtnRecarcar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnRecarcar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecarcar.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            this.BtnRecarcar.IconColor = System.Drawing.Color.Black;
            this.BtnRecarcar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRecarcar.IconSize = 24;
            this.BtnRecarcar.Location = new System.Drawing.Point(437, 34);
            this.BtnRecarcar.Name = "BtnRecarcar";
            this.BtnRecarcar.Size = new System.Drawing.Size(172, 30);
            this.BtnRecarcar.TabIndex = 17;
            this.BtnRecarcar.Text = "Refrescar Historial";
            this.BtnRecarcar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRecarcar.UseVisualStyleBackColor = false;
            this.BtnRecarcar.Click += new System.EventHandler(this.BtnRecarcar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnRecarcar);
            this.panel3.Controls.Add(this.cuiLabel3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(636, 94);
            this.panel3.TabIndex = 1;
            // 
            // cuiLabel3
            // 
            this.cuiLabel3.Content = "Historial\\ de\\ Backups";
            this.cuiLabel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.cuiLabel3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel3.ForeColor = System.Drawing.Color.White;
            this.cuiLabel3.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel3.Location = new System.Drawing.Point(0, 0);
            this.cuiLabel3.Margin = new System.Windows.Forms.Padding(10);
            this.cuiLabel3.Name = "cuiLabel3";
            this.cuiLabel3.Padding = new System.Windows.Forms.Padding(10);
            this.cuiLabel3.Size = new System.Drawing.Size(403, 94);
            this.cuiLabel3.TabIndex = 15;
            this.cuiLabel3.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NombreBaseDeDatos";
            this.Nombre.HeaderText = "Nombre BD";
            this.Nombre.MinimumWidth = 120;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 120;
            // 
            // Fecha_Inicio
            // 
            this.Fecha_Inicio.DataPropertyName = "FechaInicioBackup";
            this.Fecha_Inicio.HeaderText = "Fecha Inicio";
            this.Fecha_Inicio.Name = "Fecha_Inicio";
            this.Fecha_Inicio.ReadOnly = true;
            // 
            // FechaFinBackup
            // 
            this.FechaFinBackup.DataPropertyName = "FechaFinBackup";
            this.FechaFinBackup.HeaderText = "Fecha Fin";
            this.FechaFinBackup.MinimumWidth = 80;
            this.FechaFinBackup.Name = "FechaFinBackup";
            this.FechaFinBackup.ReadOnly = true;
            // 
            // Tamaño
            // 
            this.Tamaño.DataPropertyName = "TamanoMB";
            this.Tamaño.HeaderText = "Tamaño";
            this.Tamaño.MinimumWidth = 80;
            this.Tamaño.Name = "Tamaño";
            this.Tamaño.ReadOnly = true;
            // 
            // RutaBackup
            // 
            this.RutaBackup.DataPropertyName = "RutaArchivo";
            this.RutaBackup.HeaderText = "Ruta al Archivo";
            this.RutaBackup.MinimumWidth = 500;
            this.RutaBackup.Name = "RutaBackup";
            this.RutaBackup.ReadOnly = true;
            this.RutaBackup.Width = 500;
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1142, 688);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Backup";
            this.Text = "Backup";
            this.Load += new System.EventHandler(this.Backup_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BackupDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton BtnExaminar;
        private CuoreUI.Controls.cuiButton BtnRealizarBackup;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiLabel lblEstado;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private System.Windows.Forms.TextBox TRutaBackup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private CuoreUI.Controls.cuiCircleProgressBar cuiCircleProgressBar1;
        private CuoreUI.Controls.cuiLabel cuiLabel7;
        private System.Windows.Forms.DataGridView BackupDataGridView;
        private System.Windows.Forms.ProgressBar progressBarBackup;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton BtnRecarcar;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFinBackup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamaño;
        private System.Windows.Forms.DataGridViewTextBoxColumn RutaBackup;
    }
}