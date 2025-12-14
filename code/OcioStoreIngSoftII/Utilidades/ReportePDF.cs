using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.Data;
using System.IO;

namespace OcioStoreIngSoftII.Utilidades
{
    public static class ReportePDF
    {
        public static void GenerarPdfInforme(DataTable datos, string tituloReporte, string idInforme,string descripcion, string rutaGuardado, string nombreUsuario)
        {
            string PaginaHTML_Texto = Properties.Resources.PlantillaEstadística;

            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@nombrenegocio", Properties.Settings.Default.NombreNegocio);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@docnegocio", Properties.Settings.Default.CUITNegocio);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@direcnegocio", Properties.Settings.Default.DireccionNegocio);

            // Reemplazo de Datos del Informe
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@tipo_informe", tituloReporte);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@nombre_usuario", nombreUsuario); // Quien lo genera
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@fecha_generacion", DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@descripcion", descripcion);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@id_informe", idInforme);


            // GENERACIÓN DINÁMICA DE LA TABLA
            StringBuilder filas = new StringBuilder();
            StringBuilder encabezados = new StringBuilder();

            // Generar Encabezados (<th>) dinámicamente
            foreach (DataColumn column in datos.Columns)
            {
                // Reemplazamos guiones bajos por espacios y ponemos en mayúsculas
                string nombreColumna = column.ColumnName.Replace("_", " ").ToUpper();
                encabezados.Append($"<th>{nombreColumna}</th>");
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@encabezados", encabezados.ToString());


            // Generar Filas (<tr><td>) dinámicamente
            foreach (DataRow row in datos.Rows)
            {
                filas.Append("<tr>");
                foreach (object cellValue in row.ItemArray)
                {
                    string textoCelda = cellValue.ToString();

                    // Formateo especial si detectamos dinero o fechas
                    if (cellValue is decimal || cellValue is double)
                        textoCelda = Convert.ToDecimal(cellValue).ToString("C"); // Moneda
                    else if (cellValue is DateTime)
                        textoCelda = Convert.ToDateTime(cellValue).ToString("dd/MM/yyyy");

                    filas.Append($"<td>{textoCelda}</td>");
                }
                filas.Append("</tr>");
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@filas", filas.ToString());


            using (FileStream stream = new FileStream(rutaGuardado, FileMode.Create))
            {
                // Documento A4
                Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                using (StringReader sr = new StringReader(PaginaHTML_Texto))
                {
                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                }

                pdfDoc.Close();
                stream.Close();
            }
        }
    }
}