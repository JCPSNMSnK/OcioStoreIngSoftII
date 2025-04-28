using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace OcioStoreIngSoftII
{
    public partial class FormStats : Form
    {
        public FormStats()
        {
            InitializeComponent();

            // Agregar eventos para validar las fechas cada vez que cambien
            dtpStartDate.ValueChanged += new EventHandler(DateTimePickers_ValueChanged);
            dtpEndDate.ValueChanged += new EventHandler(DateTimePickers_ValueChanged);

            dtpStartDateE.ValueChanged += new EventHandler(DateTimePickersE_ValueChanged);
            dtpEndDateE.ValueChanged += new EventHandler(DateTimePickersE_ValueChanged);

            dtpStartDateP.ValueChanged += new EventHandler(DateTimePickersP_ValueChanged);
            dtpEndDateP.ValueChanged += new EventHandler(DateTimePickersP_ValueChanged);

            // Inicialmente comprobar la validez de las fechas
            ValidateDates();

            LoadEmployees();

            LoadProducts();

            // Añadir un ítem "Todos los productos" con un valor distinto, como -1 o null
            cmbProductos.Items.Insert(0, new ComboBoxItem { Text = "Todos los productos", Value = null });

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet11.ventas_cabecera' Puede moverla o quitarla según sea necesario.
            this.ventas_cabeceraTableAdapter.Fill(this.dataSet11.ventas_cabecera);

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private bool showingTotalSales = true;

        // Método para cargar datos en el gráfico
        private void btnLoadChart_Click(object sender, EventArgs e)
        {
            showingTotalSales = !showingTotalSales; // Alterna entre las dos métricas
            LoadChart();
        }

        // Método que carga los datos en el gráfico
        private void LoadChart()
        {
            // Limpiar los datos previos del gráfico
            chartVentas.Series.Clear();
            chartVentas.ChartAreas[0].AxisX.Title = "Fecha";
            chartVentas.ChartAreas[0].AxisY.Title = showingTotalSales ? "Ingresos Totales ($)" : "Número de Ventas";

            // Crear una serie para el gráfico
            var series = chartVentas.Series.Add("Ventas");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            // Configurar el eje Y para mostrar solo números enteros si se trata del número de ventas
            if (!showingTotalSales)
            {
                chartVentas.ChartAreas[0].AxisY.LabelStyle.Format = "0"; // Formato entero para evitar decimales
                series.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            }
            else
            {
                chartVentas.ChartAreas[0].AxisY.LabelStyle.Format = "C"; // Formato de moneda si es total de ingresos
                series.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            }

            // Conexión a la base de datos
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["pruebaLogin.Properties.Settings.db_piazza_giovanniConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query;

                // Verifica si estamos mostrando total de ingresos o número de ventas
                if (showingTotalSales)
                {
                    // Consulta para total de ingresos por día
                    query = "SELECT fecha, SUM(total_venta) AS total FROM ventas_cabecera WHERE fecha BETWEEN @startDate AND @endDate GROUP BY fecha";
                    labelMetric.Text = "Ingresos por dia";
                }
                else
                {
                    // Consulta para número de ventas por día
                    query = "SELECT fecha, COUNT(*) AS total FROM ventas_cabecera WHERE fecha BETWEEN @startDate AND @endDate GROUP BY fecha";
                    labelMetric.Text = "Ventas por dia";
                }

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Parámetros de la consulta
                    cmd.Parameters.AddWithValue("@startDate", dtpStartDate.Value);
                    cmd.Parameters.AddWithValue("@endDate", dtpEndDate.Value);

                    // Abrir la conexión
                    con.Open();

                    // Ejecutar la consulta y cargar los datos
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime fecha = Convert.ToDateTime(reader["fecha"]);
                            double total = Convert.ToDouble(reader["total"]);

                            // Añadir puntos al gráfico
                            series.Points.AddXY(fecha, total);
                        }
                    }

                    // Cerrar la conexión
                    con.Close();
                }
            }
        }


        // Método para validar las fechas seleccionadas
        private void DateTimePickers_ValueChanged(object sender, EventArgs e)
        {
            ValidateDates();
        }

        private void DateTimePickersE_ValueChanged(object sender, EventArgs e)
        {
            ValidateDatesE();
        }

        // Método que comprueba si la fecha final es mayor o igual a la fecha inicial
        private void ValidateDates()
        {
            if (dtpEndDate.Value >= dtpStartDate.Value)
            {
                // Si la fecha final es válida, habilitar el botón
                btnLoadChart.Enabled = true;
            }
            else
            {
                // Si la fecha final es menor a la fecha inicial, deshabilitar el botón
                btnLoadChart.Enabled = false;
            }
        }

        private void ValidateDatesE()
        {
            if (dtpEndDateE.Value >= dtpStartDateE.Value)
            {
                // Si la fecha final es válida, habilitar el botón
                btnLoadEmployeeChart.Enabled = true;
            }
            else
            {
                // Si la fecha final es menor a la fecha inicial, deshabilitar el botón
                btnLoadEmployeeChart.Enabled = false;
            }
        }

        private void btnLoadEmployeeChart_Click(object sender, EventArgs e)
        {
            showingTotalSales = !showingTotalSales; // Alterna entre las dos métricas
            LoadEmployeeSalesChart();
        }

        private void LoadEmployeeSalesChart()
        {
            // Limpiar los datos previos del gráfico
            chartVentasEmpleados.Series.Clear(); // Cambiar el nombre del gráfico
            chartVentasEmpleados.ChartAreas[0].AxisX.Title = "Fecha";
            chartVentasEmpleados.ChartAreas[0].AxisY.Title = showingTotalSales ? "Ingresos Totales ($)" : "Número de Ventas";

            // Obtener el empleado seleccionado

            string selectedEmployeeId = null;
            bool filterByEmployee = false;

            int comboBoxItemId = cmbEmpleados.SelectedIndex;
            if (comboBoxItemId == 0)
            {
                selectedEmployeeId = "Todos";

            }
            else
            {
                selectedEmployeeId = ((ComboBoxItem)(cmbEmpleados.SelectedItem)).Value;
                filterByEmployee = true;
            }

            // Conexión a la base de datos
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["pruebaLogin.Properties.Settings.db_piazza_giovanniConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query;

                if (showingTotalSales)
                {
                    // Consulta para total de ingresos por empleado
                    query = @"
                SELECT u.id AS usuario_id, u.nombre, vc.fecha, SUM(vc.total_venta) AS total 
                FROM ventas_cabecera vc
                JOIN usuarios u ON vc.usuario_id = u.id 
                WHERE u.perfil_id = 3 AND vc.fecha BETWEEN @startDate AND @endDate ";
                }
                else
                {
                    // Consulta para número de ventas por empleado
                    query = @"
                SELECT u.id AS usuario_id, u.nombre, vc.fecha, COUNT(*) AS total 
                FROM ventas_cabecera vc
                JOIN usuarios u ON vc.usuario_id = u.id 
                WHERE u.perfil_id = 3 AND vc.fecha BETWEEN @startDate AND @endDate ";
                }

                // Añadir condición para filtrar por empleado si es necesario
                if (filterByEmployee)
                {
                    query += " AND u.id = @selectedEmployeeId ";
                }

                query += " GROUP BY u.id, u.nombre, vc.fecha";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Parámetros de la consulta
                    cmd.Parameters.AddWithValue("@startDate", dtpStartDate.Value);
                    cmd.Parameters.AddWithValue("@endDate", dtpEndDate.Value);
                    if (filterByEmployee)
                    {
                        cmd.Parameters.AddWithValue("@selectedEmployeeId", selectedEmployeeId);
                    }

                    // Abrir la conexión
                    con.Open();

                    // Ejecutar la consulta y cargar los datos
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        var employeeColors = new Dictionary<int, Color>();
                        int colorIndex = 0;

                        while (reader.Read())
                        {
                            DateTime fecha = Convert.ToDateTime(reader["fecha"]);
                            double total = Convert.ToDouble(reader["total"]);
                            int usuarioId = Convert.ToInt32(reader["usuario_id"]);
                            string nombre = reader["nombre"].ToString();

                            // Crear una serie para cada empleado si no existe
                            if (!employeeColors.ContainsKey(usuarioId))
                            {
                                var seriesEmpleados = chartVentasEmpleados.Series.Add(nombre);
                                seriesEmpleados.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeColumn;
                                seriesEmpleados.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
                                seriesEmpleados.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

                                // Asignar un color único a la serie
                                seriesEmpleados.Color = GetColor(colorIndex);
                                employeeColors[usuarioId] = seriesEmpleados.Color;
                                colorIndex++;
                            }

                            // Añadir puntos al gráfico
                            var series = chartVentasEmpleados.Series[nombre];
                            series.Points.AddXY(fecha, total);
                        }
                    }

                    // Cerrar la conexión
                    con.Close();
                }
            }

            // Configurar el eje Y según lo que estemos mostrando
            if (!showingTotalSales)
            {
                // Para número de ventas por día
                chartVentasEmpleados.ChartAreas[0].AxisY.LabelStyle.Format = "0"; // Formato entero para evitar decimales
                labelMetricE.Text = "Ventas por dia";

            }
            else
            {
                // Para ingresos totales en dinero
                chartVentasEmpleados.ChartAreas[0].AxisY.LabelStyle.Format = "C"; // Formato de moneda
                labelMetricE.Text = "Ingresos por dia";
            }


        }

        private Color GetColor(int index)
        {
            // Array de colores
            Color[] colors = new Color[]
            {
        Color.Red,
        Color.Blue,
        Color.Green,
        Color.Orange,
        Color.Purple,
        Color.Brown,
        Color.Cyan,
        Color.Magenta,
        Color.Yellow,
        Color.Gray
            };

            // Devolver color basado en el índice
            return colors[index % colors.Length];
        }

        private void LoadEmployees()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["pruebaLogin.Properties.Settings.db_piazza_giovanniConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT id, nombre FROM usuarios WHERE perfil_id = 3"; // Selecciona empleados con perfil_id 3

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cmbEmpleados.Items.Clear();
                        cmbEmpleados.Items.Add("Todos"); // Opción para ver todos los empleados

                        while (reader.Read())
                        {
                            cmbEmpleados.Items.Add(new ComboBoxItem
                            {
                                Text = reader["nombre"].ToString(),
                                Value = reader["id"].ToString()
                            });
                        }

                        cmbEmpleados.SelectedIndex = 0; // Selecciona la primera opción por defecto
                    }

                    con.Close();
                }
            }
        }

        // Clase para gestionar los ítems del ComboBox
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public override string ToString()
            {
                return Text; // Muestra el nombre del empleado en el ComboBox
            }
        }

        
        //productos
        
        private bool showingViews = true;

        private void btnLoadProductChart_Click(object sender, EventArgs e)
        {
            showingViews = !showingViews; // Alterna entre las dos métricas
            LoadProductStatChart();
        }

        private void DateTimePickersP_ValueChanged(object sender, EventArgs e)
        {
            ValidateDatesP();
        }

        private void ValidateDatesP()
        {
            if (dtpEndDateP.Value >= dtpStartDateP.Value)
            {
                // Si la fecha final es válida, habilitar el botón
                btnSearchProductChart.Enabled = true;
                btnLoadProductChart.Enabled = true;
            }
            else
            {
                // Si la fecha final es menor a la fecha inicial, deshabilitar el botón
                btnSearchProductChart.Enabled = false;
                btnLoadProductChart.Enabled = false;
            }
        }

        private void LoadProducts()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["pruebaLogin.Properties.Settings.db_piazza_giovanniConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT id, nombre FROM productos_pc"; // Selecciona productos de la lista

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cmbProductos.Items.Clear();

                        while (reader.Read())
                        {
                            cmbProductos.Items.Add(new ComboBoxItem
                            {
                                Text = reader["nombre"].ToString(),
                                Value = reader["id"].ToString()
                            });
                        }

                        cmbProductos.SelectedIndex = 0; // Selecciona la primera opción por defecto
                    }

                    con.Close();
                }
            }
        }

        // Método que carga los datos en el gráfico
        private void LoadProductStatChart()
        {
            // Limpiar los datos previos del gráfico
            chartProducts.Series.Clear();
            chartProducts.ChartAreas[0].AxisX.Title = "Fechas de Venta";
            chartProducts.ChartAreas[0].AxisY.Title = "Número de Ventas";

            // Configurar selectores de fecha según la vista
            dtpStartDateP.Enabled = !showingViews;
            dtpEndDateP.Enabled = !showingViews;

            // Obtener el producto seleccionado
            string selectedProductId = null;
            if (cmbProductos.SelectedItem != null && cmbProductos.SelectedItem is ComboBoxItem selectedItem)
            {
                if (selectedItem.Value != null)
                {
                    selectedProductId = selectedItem.Value; // Obtiene el valor del producto
                }
            }

            // Conexión a la base de datos
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["pruebaLogin.Properties.Settings.db_piazza_giovanniConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query;

                if (showingViews)
                {
                    query = @"
            SELECT p.id AS producto_id, p.nombre, p.visitas 
            FROM productos_pc p
            WHERE (@selectedProductId IS NULL OR p.id = @selectedProductId)
            ORDER BY p.visitas DESC";
                }
                else
                {
                    query = @"
            SELECT p.id AS producto_id, p.nombre, vc.fecha, SUM(vd.cantidad) AS total_ventas 
            FROM productos_pc p
            JOIN ventas_detalle vd ON p.id = vd.producto_id
            JOIN ventas_cabecera vc ON vd.venta_id = vc.id
            WHERE vc.fecha BETWEEN @startDate AND @endDate
            AND (@selectedProductId IS NULL OR p.id = @selectedProductId)
            GROUP BY p.id, p.nombre, vc.fecha
            ORDER BY vc.fecha ASC";
                }

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Agregar parámetros
                    cmd.Parameters.AddWithValue("@selectedProductId", (object)selectedProductId ?? DBNull.Value);

                    if (!showingViews)
                    {
                        cmd.Parameters.AddWithValue("@startDate", dtpStartDateP.Value);
                        cmd.Parameters.AddWithValue("@endDate", dtpEndDateP.Value);
                    }

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        bool dataFound = false; // Bandera para saber si encontramos datos

                        if (showingViews)
                        {
                            // Manejo de datos para visitas
                            while (reader.Read())
                            {
                                string nombre = reader["nombre"].ToString();
                                int visitas = Convert.ToInt32(reader["visitas"]);

                                // Crear una serie con el nombre del producto
                                var seriesProducto = chartProducts.Series.Add(nombre);
                                seriesProducto.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                                // Ajustar grosor de las columnas
                                seriesProducto.CustomProperties = "PointWidth=2"; // Aumenta el ancho de las columnas

                                // Mostrar los valores en la parte superior
                                seriesProducto.IsValueShownAsLabel = true;

                                // Agregar el valor de visitas
                                seriesProducto.Points.AddXY(nombre, visitas);

                                dataFound = true; // Encontramos datos
                            }
                        }
                        else
                        {
                            // Manejo de datos para ventas
                            Dictionary<string, Series> seriesMap = new Dictionary<string, Series>();
                            List<DateTime> fechas = new List<DateTime>();  // Lista para almacenar todas las fechas

                            while (reader.Read())
                            {
                                string nombre = reader["nombre"].ToString();
                                DateTime fecha = Convert.ToDateTime(reader["fecha"]);
                                int totalVentas = Convert.ToInt32(reader["total_ventas"]);

                                // Agregar la fecha a la lista de fechas si no está ya incluida
                                if (!fechas.Contains(fecha))
                                {
                                    fechas.Add(fecha);
                                }

                                // Si no existe una serie para este producto, crearla
                                if (!seriesMap.ContainsKey(nombre))
                                {
                                    var seriesProducto = chartProducts.Series.Add(nombre);
                                    seriesProducto.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                                    seriesProducto.IsValueShownAsLabel = true; // Mostrar valores
                                    seriesProducto.CustomProperties = "PointWidth=0.5"; // Ajustar grosor de las columnas
                                    seriesMap[nombre] = seriesProducto;
                                }

                                // Agregar el punto de ventas a la serie correspondiente
                                seriesMap[nombre].Points.AddXY(fecha, totalVentas);

                                dataFound = true; // Encontramos datos
                            }

                            // Ordenar las fechas de manera ascendente
                            fechas.Sort();

                            // Mostrar todas las fechas en el eje X
                            chartProducts.ChartAreas[0].AxisX.Interval = 1;
                            chartProducts.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yyyy";  // Formato de fecha

                            // Limpiar etiquetas anteriores
                            chartProducts.ChartAreas[0].AxisX.CustomLabels.Clear();

                            // Establecer las fechas como etiquetas en el eje X
                            for (int i = 0; i < fechas.Count; i++)
                            {
                                var fecha = fechas[i];
                                double xValue = i;  // Establecer la posición en el eje X según el índice

                                chartProducts.ChartAreas[0].AxisX.CustomLabels.Add(new System.Windows.Forms.DataVisualization.Charting.CustomLabel(
                                    xValue,
                                    xValue,
                                    fecha.ToString("dd/MM/yyyy"),
                                    0,
                                    System.Windows.Forms.DataVisualization.Charting.LabelMarkStyle.None));
                            }
                        }

                        // Si no se encontraron datos, mostrar mensaje de advertencia
                        if (!dataFound)
                        {
                            chartProducts.Visible = false;  // Ocultar el gráfico
                            labelWarning.Text = "No se encontraron resultados para el producto y el rango de fechas seleccionados.";  // Mostrar mensaje de advertencia
                        }
                        else
                        {
                            chartProducts.Visible = true;  // Asegurarse de que el gráfico sea visible
                            labelWarning.Text = "";  // Limpiar mensaje de advertencia
                        }
                    }

                    con.Close();
                }
            }

            // Configuración del gráfico según lo que estemos mostrando
            if (showingViews)
            {
                chartProducts.ChartAreas[0].AxisY.LabelStyle.Format = "0"; // Formato entero
                labelMetricP.Text = "Visitas por producto";
            }
            else
            {
                chartProducts.ChartAreas[0].AxisY.LabelStyle.Format = "0"; // Formato entero
                chartProducts.ChartAreas[0].AxisX.Interval = 1; // Mostrar todas las fechas
                chartProducts.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yyyy"; // Formato de fecha en el eje X
                labelMetricP.Text = "Ventas de productos por fecha";
            }
        }

        private void TSearchProduct_TextChanged(object sender, EventArgs e)
        {
            // Obtener el texto ingresado en el TextBox
            string searchText = TSearchProduct.Text.Trim().ToLower();

            // Almacenar temporalmente los elementos originales si aún no lo has hecho
            if (cmbProductos.Tag == null)
            {
                cmbProductos.Tag = cmbProductos.Items.Cast<object>().ToList();
            }

            // Lista original de elementos
            var originalItems = (List<object>)cmbProductos.Tag;

            // Filtrar los elementos que contienen el texto ingresado
            var filteredItems = originalItems
                .OfType<ComboBoxItem>() // Solo elementos ComboBoxItem
                .Where(item => item.Text.ToLower().Contains(searchText))
                .ToList();

            // Actualizar el ComboBox con los elementos filtrados
            cmbProductos.Items.Clear();

            if (filteredItems.Any())
            {
                cmbProductos.Items.AddRange(filteredItems.ToArray());
            }
            else
            {
                cmbProductos.Items.Add("No se encontraron resultados");
            }

            // Si hay coincidencias, seleccionar automáticamente el primero
            if (filteredItems.Count > 0)
            {
                cmbProductos.SelectedIndex = 0;
            }
        }

        private void btnSearchProductChart_Click(object sender, EventArgs e)
        {
            LoadProductStatChart();
        }
    }
}
