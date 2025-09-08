using CapaDatos;
using CapaEntidades;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using CapaEntidades.Utilidades;
using System.IO;
using iText.Layout;
//using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iTextSharp.tool.xml;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace OcioStoreIngSoftII
{
    public partial class Informes : Form
    {
        public Informes()
        {
            InitializeComponent();
        }

        private void Informes_Load(object sender, EventArgs e)
        {
            // Llama al método para cargar los datos cuando se inicia el formulario.
            CargarDatosInformes();
        }

        private void CargarDatosInformes()
        {
            // **Paso 1: Obtener los datos directamente de la capa de datos**
            // Se crea una instancia de la clase de acceso a datos y se llama directamente al método.
            Informes_Datos obj_informes_datos = new Informes_Datos();
            List<Informe> listaInformes = obj_informes_datos.ObtenerTodosLosInformes();

            // Convertir la lista a un DataTable para el DataGridView (opcional pero útil)
            DataTable dt = new DataTable();
            dt.Columns.Add("id_informe", typeof(int));
            dt.Columns.Add("Titulo", typeof(string));
            dt.Columns.Add("Descripción", typeof(string));
            dt.Columns.Add("Fecha de Generación", typeof(DateTime));
            dt.Columns.Add("Tipo de Informe", typeof(string));
            dt.Columns.Add("Realizado por", typeof(string));

            foreach (var informe in listaInformes)
            {
                string nombreCompletoUsuario = informe.objUsuario != null ? $"{informe.objUsuario.nombre} {informe.objUsuario.apellido}" : "N/A";
                dt.Rows.Add(
                    informe.id_informe,
                    informe.titulo,
                    informe.descripcion,
                    informe.fecha_generacion,
                    informe.tipo_informe,
                    nombreCompletoUsuario
                );
            }

            // Asignar el DataTable como origen de datos del DataGridView.
            informesDataGridView.DataSource = dt;

            // Ocultar la columna de ID si no es necesaria para la vista del usuario
            informesDataGridView.Columns["id_informe"].Visible = false;

            // **Paso 2: Crear la columna "Ver PDF"**
            // Verifica si la columna ya existe para no agregarla más de una vez.
            if (!informesDataGridView.Columns.Contains("Informe"))
            {
                DataGridViewButtonColumn verPdfColumna = new DataGridViewButtonColumn();
                verPdfColumna.Name = "Informe";
                verPdfColumna.HeaderText = "Informe";
                verPdfColumna.Text = "Ver PDF";
                verPdfColumna.UseColumnTextForButtonValue = true;
                informesDataGridView.Columns.Add(verPdfColumna);
            }

            // Asignar el evento CellContentClick
            informesDataGridView.CellContentClick += informesDataGridView_CellContentClick;
        }

        private void informesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // **Paso 3: Manejar el clic en el botón**
            // Asegurarse de que el clic fue en la columna "Ver PDF" y no en la cabecera.
            if (e.ColumnIndex == informesDataGridView.Columns["Informe"].Index && e.RowIndex >= 0)
            {
                // Obtener la fila completa que fue clicada
                DataGridViewRow fila = informesDataGridView.Rows[e.RowIndex];

                // Extraer los datos de la fila
                Informe reporteSeleccionado = new Informe
                {
                    id_informe = Convert.ToInt32(fila.Cells["id_informe"].Value),
                    titulo = fila.Cells["Titulo"].Value.ToString(),
                    descripcion = fila.Cells["Descripción"].Value.ToString(),
                    fecha_generacion = Convert.ToDateTime(fila.Cells["Fecha de Generación"].Value),
                    tipo_informe = fila.Cells["Tipo de Informe"].Value.ToString(),
                    // Asumimos que la celda de usuario contiene el nombre completo
                    objUsuario = new Usuario { nombre = fila.Cells["Realizado por"].Value.ToString() }
                };

                // Llamar al método para generar el PDF.
                GenerarPDF(reporteSeleccionado);
            }
        }

        private void GenerarPDF(Informe reporte)
        {
            //corregir la condíción de control de ser necesario, aquello que vayamos a imprimir tiene que existir
            if (reporte == null)
            {
                MessageBox.Show("No se encontró el informe para imprimir", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string Texto_Html = Properties.Resources.PlantillaCompra.ToString(); //la plantilla HTML cargada en Recursos del Proyecto

            Texto_Html = Texto_Html.Replace("@nombrenegocio", "Ocio Store");
            Texto_Html = Texto_Html.Replace("@docnegocio", "Tienda de Juegos de Mesa");
            Texto_Html = Texto_Html.Replace("@direcnegocio", "Avenida Corrientes 453");

            Texto_Html = Texto_Html.Replace("@tipodocumento", "COMPROBANTE DE COMPRA");
            Texto_Html = Texto_Html.Replace("@numerodocumento", "");//poner acá el ID de la Compra desde lo seleccionado

            Texto_Html = Texto_Html.Replace("@docproveedor", ""); //poner acá el CUIT del PRoveedor de la compra
            Texto_Html = Texto_Html.Replace("@nombreproveedor", ""); //poner acá el nombre del proveedor 
            Texto_Html = Texto_Html.Replace("@fecharegistro", ""); //poner la fecha de la compra
            Texto_Html = Texto_Html.Replace("@usuarioregistro", ""); //poner el nombre del usuario que generó el pdf de la compra

            string filas = string.Empty;
            foreach (DataGridViewRow row in informesDataGridView.Rows)
            {
                filas += "<td>";
                filas += "<td>" + row.Cells["Nombre Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Precio Unitario"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Total"].Value.ToString() + "</td>";
                filas += "</td>";
            }

            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", ""); //colocar el total

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = string.Format("Informe_{0].pdf", reporte.id_informe);
            saveFile.Filter = "Pdf files|* .pdf";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                {
                    iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 25, 25, 25, 25);

                    iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    bool obtenido = true;
                    byte[] byteImage = null; //poner la imagen acá, una ref a resources quizas

                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.GetLeft(20), pdfDoc.GetTop(51));
                        pdfDoc.Add(img);
                    }

                    using (StringReader sr = new StringReader(Texto_Html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
