namespace OcioStoreIngSoftII
{
    partial class Stats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stats));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanelStats = new System.Windows.Forms.TableLayoutPanel();
            this.cuiPanel3 = new CuoreUI.Controls.cuiPanel();
            this.KPI_PromedioVentas = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel6 = new CuoreUI.Controls.cuiLabel();
            this.cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            this.KPI_CantVentas = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            this.GraphFluctuacionVentas = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            this.GraphVendedoresMasVentas = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            this.GraphProductosMasVendidos = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            this.GraphCategoriasMasVendidas = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.KPI_Ingresos = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.cuiPanel4 = new CuoreUI.Controls.cuiPanel();
            this.cuiLabel9 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel8 = new CuoreUI.Controls.cuiLabel();
            this.btnFiltrar = new CuoreUI.Controls.cuiButton();
            this.DtpFechaFin = new CuoreUI.Controls.cuiCalendarDatePicker();
            this.DtpFechaInicio = new CuoreUI.Controls.cuiCalendarDatePicker();
            this.cuiLabel7 = new CuoreUI.Controls.cuiLabel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanelStats.SuspendLayout();
            this.cuiPanel3.SuspendLayout();
            this.cuiPanel2.SuspendLayout();
            this.cuiPanel1.SuspendLayout();
            this.cuiPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.tableLayoutPanelStats);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 749);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanelStats
            // 
            this.tableLayoutPanelStats.AutoSize = true;
            this.tableLayoutPanelStats.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelStats.ColumnCount = 3;
            this.tableLayoutPanelStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanelStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelStats.Controls.Add(this.cuiPanel3, 2, 1);
            this.tableLayoutPanelStats.Controls.Add(this.cuiPanel2, 1, 1);
            this.tableLayoutPanelStats.Controls.Add(this.GraphFluctuacionVentas, 0, 2);
            this.tableLayoutPanelStats.Controls.Add(this.GraphVendedoresMasVentas, 0, 3);
            this.tableLayoutPanelStats.Controls.Add(this.GraphProductosMasVendidos, 1, 3);
            this.tableLayoutPanelStats.Controls.Add(this.GraphCategoriasMasVendidas, 2, 3);
            this.tableLayoutPanelStats.Controls.Add(this.cuiPanel1, 0, 1);
            this.tableLayoutPanelStats.Controls.Add(this.cuiPanel4, 0, 0);
            this.tableLayoutPanelStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelStats.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelStats.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelStats.Name = "tableLayoutPanelStats";
            this.tableLayoutPanelStats.RowCount = 4;
            this.tableLayoutPanelStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 480F));
            this.tableLayoutPanelStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 480F));
            this.tableLayoutPanelStats.Size = new System.Drawing.Size(1125, 1190);
            this.tableLayoutPanelStats.TabIndex = 1;
            // 
            // cuiPanel3
            // 
            this.cuiPanel3.Controls.Add(this.KPI_PromedioVentas);
            this.cuiPanel3.Controls.Add(this.cuiLabel6);
            this.cuiPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuiPanel3.Location = new System.Drawing.Point(764, 95);
            this.cuiPanel3.Margin = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.cuiPanel3.Name = "cuiPanel3";
            this.cuiPanel3.OutlineThickness = 1F;
            this.cuiPanel3.Padding = new System.Windows.Forms.Padding(3);
            this.cuiPanel3.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.cuiPanel3.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.cuiPanel3.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanel3.Size = new System.Drawing.Size(346, 125);
            this.cuiPanel3.TabIndex = 10;
            // 
            // KPI_PromedioVentas
            // 
            this.KPI_PromedioVentas.BackColor = System.Drawing.Color.Transparent;
            this.KPI_PromedioVentas.Content = "Your\\ text\\ here!";
            this.KPI_PromedioVentas.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KPI_PromedioVentas.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.KPI_PromedioVentas.Location = new System.Drawing.Point(0, 50);
            this.KPI_PromedioVentas.Name = "KPI_PromedioVentas";
            this.KPI_PromedioVentas.Padding = new System.Windows.Forms.Padding(5);
            this.KPI_PromedioVentas.Size = new System.Drawing.Size(347, 69);
            this.KPI_PromedioVentas.TabIndex = 4;
            this.KPI_PromedioVentas.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel6
            // 
            this.cuiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel6.Content = "Precio\\ Promedio\\ de\\ Venta";
            this.cuiLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel6.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel6.Location = new System.Drawing.Point(10, 7);
            this.cuiLabel6.Margin = new System.Windows.Forms.Padding(5);
            this.cuiLabel6.Name = "cuiLabel6";
            this.cuiLabel6.Size = new System.Drawing.Size(254, 47);
            this.cuiLabel6.TabIndex = 5;
            this.cuiLabel6.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // cuiPanel2
            // 
            this.cuiPanel2.Controls.Add(this.KPI_CantVentas);
            this.cuiPanel2.Controls.Add(this.cuiLabel4);
            this.cuiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuiPanel2.Location = new System.Drawing.Point(389, 95);
            this.cuiPanel2.Margin = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.cuiPanel2.Name = "cuiPanel2";
            this.cuiPanel2.OutlineThickness = 1F;
            this.cuiPanel2.Padding = new System.Windows.Forms.Padding(3);
            this.cuiPanel2.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(208)))), ((int)(((byte)(237)))));
            this.cuiPanel2.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(208)))), ((int)(((byte)(237)))));
            this.cuiPanel2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanel2.Size = new System.Drawing.Size(345, 125);
            this.cuiPanel2.TabIndex = 9;
            // 
            // KPI_CantVentas
            // 
            this.KPI_CantVentas.BackColor = System.Drawing.Color.Transparent;
            this.KPI_CantVentas.Content = "Your\\ text\\ here!";
            this.KPI_CantVentas.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KPI_CantVentas.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.KPI_CantVentas.Location = new System.Drawing.Point(0, 50);
            this.KPI_CantVentas.Name = "KPI_CantVentas";
            this.KPI_CantVentas.Padding = new System.Windows.Forms.Padding(5);
            this.KPI_CantVentas.Size = new System.Drawing.Size(347, 69);
            this.KPI_CantVentas.TabIndex = 4;
            this.KPI_CantVentas.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel4
            // 
            this.cuiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel4.Content = "Cantidad\\ de\\ Ventas";
            this.cuiLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel4.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel4.Location = new System.Drawing.Point(10, 7);
            this.cuiLabel4.Margin = new System.Windows.Forms.Padding(5);
            this.cuiLabel4.Name = "cuiLabel4";
            this.cuiLabel4.Size = new System.Drawing.Size(210, 47);
            this.cuiLabel4.TabIndex = 5;
            this.cuiLabel4.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // GraphFluctuacionVentas
            // 
            this.tableLayoutPanelStats.SetColumnSpan(this.GraphFluctuacionVentas, 3);
            this.GraphFluctuacionVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GraphFluctuacionVentas.Location = new System.Drawing.Point(15, 245);
            this.GraphFluctuacionVentas.Margin = new System.Windows.Forms.Padding(15);
            this.GraphFluctuacionVentas.MatchAxesScreenDataRatio = false;
            this.GraphFluctuacionVentas.Name = "GraphFluctuacionVentas";
            this.GraphFluctuacionVentas.Size = new System.Drawing.Size(1095, 450);
            this.GraphFluctuacionVentas.TabIndex = 3;
            this.GraphFluctuacionVentas.Load += new System.EventHandler(this.Stats_Load);
            // 
            // GraphVendedoresMasVentas
            // 
            this.GraphVendedoresMasVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GraphVendedoresMasVentas.Location = new System.Drawing.Point(10, 720);
            this.GraphVendedoresMasVentas.Margin = new System.Windows.Forms.Padding(10, 10, 10, 15);
            this.GraphVendedoresMasVentas.MatchAxesScreenDataRatio = false;
            this.GraphVendedoresMasVentas.Name = "GraphVendedoresMasVentas";
            this.GraphVendedoresMasVentas.Size = new System.Drawing.Size(354, 455);
            this.GraphVendedoresMasVentas.TabIndex = 5;
            this.GraphVendedoresMasVentas.Load += new System.EventHandler(this.Stats_Load);
            // 
            // GraphProductosMasVendidos
            // 
            this.GraphProductosMasVendidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GraphProductosMasVendidos.InitialRotation = 0D;
            this.GraphProductosMasVendidos.IsClockwise = true;
            this.GraphProductosMasVendidos.Location = new System.Drawing.Point(384, 720);
            this.GraphProductosMasVendidos.Margin = new System.Windows.Forms.Padding(10, 10, 10, 15);
            this.GraphProductosMasVendidos.MaxAngle = 360D;
            this.GraphProductosMasVendidos.MaxValue = double.NaN;
            this.GraphProductosMasVendidos.MinValue = 0D;
            this.GraphProductosMasVendidos.Name = "GraphProductosMasVendidos";
            this.GraphProductosMasVendidos.Size = new System.Drawing.Size(355, 455);
            this.GraphProductosMasVendidos.TabIndex = 6;
            this.GraphProductosMasVendidos.Load += new System.EventHandler(this.Stats_Load);
            // 
            // GraphCategoriasMasVendidas
            // 
            this.GraphCategoriasMasVendidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GraphCategoriasMasVendidas.InitialRotation = 0D;
            this.GraphCategoriasMasVendidas.IsClockwise = true;
            this.GraphCategoriasMasVendidas.Location = new System.Drawing.Point(759, 720);
            this.GraphCategoriasMasVendidas.Margin = new System.Windows.Forms.Padding(10, 10, 10, 15);
            this.GraphCategoriasMasVendidas.MaxAngle = 360D;
            this.GraphCategoriasMasVendidas.MaxValue = double.NaN;
            this.GraphCategoriasMasVendidas.MinValue = 0D;
            this.GraphCategoriasMasVendidas.Name = "GraphCategoriasMasVendidas";
            this.GraphCategoriasMasVendidas.Size = new System.Drawing.Size(356, 455);
            this.GraphCategoriasMasVendidas.TabIndex = 7;
            this.GraphCategoriasMasVendidas.Load += new System.EventHandler(this.Stats_Load);
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Controls.Add(this.KPI_Ingresos);
            this.cuiPanel1.Controls.Add(this.cuiLabel2);
            this.cuiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuiPanel1.Location = new System.Drawing.Point(15, 95);
            this.cuiPanel1.Margin = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.cuiPanel1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanel1.Size = new System.Drawing.Size(344, 125);
            this.cuiPanel1.TabIndex = 8;
            // 
            // KPI_Ingresos
            // 
            this.KPI_Ingresos.BackColor = System.Drawing.Color.Transparent;
            this.KPI_Ingresos.Content = "Your\\ text\\ here!";
            this.KPI_Ingresos.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KPI_Ingresos.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.KPI_Ingresos.Location = new System.Drawing.Point(0, 50);
            this.KPI_Ingresos.Name = "KPI_Ingresos";
            this.KPI_Ingresos.Padding = new System.Windows.Forms.Padding(5);
            this.KPI_Ingresos.Size = new System.Drawing.Size(347, 69);
            this.KPI_Ingresos.TabIndex = 4;
            this.KPI_Ingresos.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel2
            // 
            this.cuiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel2.Content = "Ingresos";
            this.cuiLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel2.Location = new System.Drawing.Point(11, 7);
            this.cuiLabel2.Margin = new System.Windows.Forms.Padding(5);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Size = new System.Drawing.Size(209, 47);
            this.cuiLabel2.TabIndex = 5;
            this.cuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // cuiPanel4
            // 
            this.cuiPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tableLayoutPanelStats.SetColumnSpan(this.cuiPanel4, 3);
            this.cuiPanel4.Controls.Add(this.cuiLabel9);
            this.cuiPanel4.Controls.Add(this.cuiLabel8);
            this.cuiPanel4.Controls.Add(this.btnFiltrar);
            this.cuiPanel4.Controls.Add(this.DtpFechaFin);
            this.cuiPanel4.Controls.Add(this.DtpFechaInicio);
            this.cuiPanel4.Controls.Add(this.cuiLabel7);
            this.cuiPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuiPanel4.Location = new System.Drawing.Point(0, 3);
            this.cuiPanel4.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.cuiPanel4.Name = "cuiPanel4";
            this.cuiPanel4.OutlineThickness = 1F;
            this.cuiPanel4.PanelColor = System.Drawing.Color.Transparent;
            this.cuiPanel4.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPanel4.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanel4.Size = new System.Drawing.Size(1122, 74);
            this.cuiPanel4.TabIndex = 11;
            // 
            // cuiLabel9
            // 
            this.cuiLabel9.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel9.Content = "Hasta:";
            this.cuiLabel9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel9.ForeColor = System.Drawing.Color.White;
            this.cuiLabel9.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel9.Location = new System.Drawing.Point(837, -3);
            this.cuiLabel9.Margin = new System.Windows.Forms.Padding(5);
            this.cuiLabel9.Name = "cuiLabel9";
            this.cuiLabel9.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cuiLabel9.Size = new System.Drawing.Size(117, 28);
            this.cuiLabel9.TabIndex = 11;
            this.cuiLabel9.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel8
            // 
            this.cuiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel8.Content = "Desde:";
            this.cuiLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel8.ForeColor = System.Drawing.Color.White;
            this.cuiLabel8.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel8.Location = new System.Drawing.Point(676, -3);
            this.cuiLabel8.Margin = new System.Windows.Forms.Padding(5);
            this.cuiLabel8.Name = "cuiLabel8";
            this.cuiLabel8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cuiLabel8.Size = new System.Drawing.Size(117, 28);
            this.cuiLabel8.TabIndex = 10;
            this.cuiLabel8.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.CheckButton = false;
            this.btnFiltrar.Checked = false;
            this.btnFiltrar.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnFiltrar.CheckedForeColor = System.Drawing.Color.White;
            this.btnFiltrar.CheckedImageTint = System.Drawing.Color.White;
            this.btnFiltrar.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnFiltrar.Content = "Filtrar";
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.HoverBackground = System.Drawing.Color.White;
            this.btnFiltrar.HoverForeColor = System.Drawing.Color.Black;
            this.btnFiltrar.HoverImageTint = System.Drawing.Color.White;
            this.btnFiltrar.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFiltrar.Image = null;
            this.btnFiltrar.ImageAutoCenter = true;
            this.btnFiltrar.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnFiltrar.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnFiltrar.Location = new System.Drawing.Point(998, 24);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            this.btnFiltrar.NormalForeColor = System.Drawing.Color.White;
            this.btnFiltrar.NormalImageTint = System.Drawing.Color.White;
            this.btnFiltrar.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFiltrar.OutlineThickness = 1F;
            this.btnFiltrar.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.btnFiltrar.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnFiltrar.PressedImageTint = System.Drawing.Color.White;
            this.btnFiltrar.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFiltrar.Rounding = new System.Windows.Forms.Padding(8);
            this.btnFiltrar.Size = new System.Drawing.Size(110, 45);
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnFiltrar.TextOffset = new System.Drawing.Point(0, 0);
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // DtpFechaFin
            // 
            this.DtpFechaFin.Content = new System.DateTime(2025, 9, 4, 0, 0, 0, 0);
            this.DtpFechaFin.EnableThemeChangeButton = true;
            this.DtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.DtpFechaFin.ForeColor = System.Drawing.Color.DarkGray;
            this.DtpFechaFin.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DtpFechaFin.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DtpFechaFin.Icon = ((System.Drawing.Image)(resources.GetObject("DtpFechaFin.Icon")));
            this.DtpFechaFin.IconTint = System.Drawing.Color.Gray;
            this.DtpFechaFin.Location = new System.Drawing.Point(837, 25);
            this.DtpFechaFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DtpFechaFin.Name = "DtpFechaFin";
            this.DtpFechaFin.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(128)))));
            this.DtpFechaFin.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(128)))));
            this.DtpFechaFin.OutlineThickness = 1.5F;
            this.DtpFechaFin.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom;
            this.DtpFechaFin.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DtpFechaFin.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DtpFechaFin.Rounding = 8;
            this.DtpFechaFin.ShowIcon = true;
            this.DtpFechaFin.Size = new System.Drawing.Size(153, 45);
            this.DtpFechaFin.TabIndex = 8;
            this.DtpFechaFin.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            // 
            // DtpFechaInicio
            // 
            this.DtpFechaInicio.Content = new System.DateTime(2025, 9, 4, 0, 0, 0, 0);
            this.DtpFechaInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DtpFechaInicio.EnableThemeChangeButton = true;
            this.DtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.DtpFechaInicio.ForeColor = System.Drawing.Color.DarkGray;
            this.DtpFechaInicio.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DtpFechaInicio.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DtpFechaInicio.Icon = ((System.Drawing.Image)(resources.GetObject("DtpFechaInicio.Icon")));
            this.DtpFechaInicio.IconTint = System.Drawing.Color.Gray;
            this.DtpFechaInicio.Location = new System.Drawing.Point(676, 25);
            this.DtpFechaInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtpFechaInicio.Name = "DtpFechaInicio";
            this.DtpFechaInicio.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(128)))));
            this.DtpFechaInicio.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(128)))));
            this.DtpFechaInicio.OutlineThickness = 1.5F;
            this.DtpFechaInicio.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom;
            this.DtpFechaInicio.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DtpFechaInicio.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DtpFechaInicio.Rounding = 8;
            this.DtpFechaInicio.ShowIcon = true;
            this.DtpFechaInicio.Size = new System.Drawing.Size(153, 45);
            this.DtpFechaInicio.TabIndex = 7;
            this.DtpFechaInicio.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            // 
            // cuiLabel7
            // 
            this.cuiLabel7.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel7.Content = "Dashboard\\ de\\ Ventas";
            this.cuiLabel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.cuiLabel7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel7.ForeColor = System.Drawing.Color.White;
            this.cuiLabel7.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel7.Location = new System.Drawing.Point(0, 0);
            this.cuiLabel7.Margin = new System.Windows.Forms.Padding(5);
            this.cuiLabel7.Name = "cuiLabel7";
            this.cuiLabel7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cuiLabel7.Size = new System.Drawing.Size(325, 74);
            this.cuiLabel7.TabIndex = 6;
            this.cuiLabel7.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1142, 749);
            this.Controls.Add(this.panel1);
            this.Name = "Stats";
            this.Text = "Stats";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanelStats.ResumeLayout(false);
            this.cuiPanel3.ResumeLayout(false);
            this.cuiPanel2.ResumeLayout(false);
            this.cuiPanel1.ResumeLayout(false);
            this.cuiPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStats;
        private CuoreUI.Controls.cuiPanel cuiPanel3;
        private CuoreUI.Controls.cuiLabel cuiLabel6;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart GraphFluctuacionVentas;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart GraphVendedoresMasVentas;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart GraphProductosMasVendidos;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart GraphCategoriasMasVendidas;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiLabel KPI_Ingresos;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiLabel KPI_PromedioVentas;
        private CuoreUI.Controls.cuiLabel KPI_CantVentas;
        private CuoreUI.Controls.cuiPanel cuiPanel4;
        private CuoreUI.Controls.cuiCalendarDatePicker DtpFechaFin;
        private CuoreUI.Controls.cuiCalendarDatePicker DtpFechaInicio;
        private CuoreUI.Controls.cuiLabel cuiLabel7;
        private CuoreUI.Controls.cuiButton btnFiltrar;
        private CuoreUI.Controls.cuiLabel cuiLabel9;
        private CuoreUI.Controls.cuiLabel cuiLabel8;
    }
}