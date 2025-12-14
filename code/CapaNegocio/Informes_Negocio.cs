using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class Informes_Negocio
    {
        private Informes_Datos objDatos = new Informes_Datos();

        public DataTable GenerarInforme(string tipoInforme, DateTime inicio, DateTime fin, int? idFiltro = null)
        {
            // Si las fechas son inválidas y el reporte las requiere, devolvemos tabla vacía o null
            if (tipoInforme != "StockBajo" && inicio > fin)
            {
                throw new Exception("La fecha de inicio no puede ser mayor a la fecha de fin.");
            }

            string spNombre = "";
            bool usaFechas = true;
            bool esReporteVendedor = false;

            // Mapeo del "Tipo" seleccionado al "Stored Procedure"
            switch (tipoInforme)
            {
                case "VendedoresDestacados":
                    spNombre = "PROC_INFORME_VENDEDORES_MAS_VENTAS";
                    break;
                case "ProductosTop":
                    spNombre = "PROC_INFORME_PRODUCTOS_MAS_VENDIDOS";
                    break;
                case "FluctuacionVentas":
                    spNombre = "PROC_INFORME_FLUCTUACION_VENTAS";
                    break;
                case "CategoriasTop":
                    spNombre = "PROC_INFORME_CATEGORIAS_MAS_VENDIDAS";
                    break;
                case "StockBajo":
                    spNombre = "PROC_LISTAR_PRODUCTOS_STOCK_BAJO";
                    usaFechas = false;
                    break;
                case "DetalleVendedor": 
                    esReporteVendedor = true;
                    break;

                default:
                    return new DataTable(); // Retorna vacío si no encuentra el tipo
            }

            if (esReporteVendedor)
            {
                // Si es null, lanzamos error o devolvemos vacío
                if (idFiltro == null) throw new Exception("Se requiere un ID de vendedor.");
                return objDatos.ObtenerVentasDeVendedor(idFiltro.Value, inicio, fin);
            }
            else if (usaFechas)
            {
                return objDatos.ObtenerDatosInforme(spNombre, inicio, fin);
            }
            else
            {
                return objDatos.ObtenerDatosInforme(spNombre, null, null);
            }
        }

        public DataTable ObtenerHistorial(DateTime inicio, DateTime fin, string tipo)
        {
            if (inicio > fin)
                throw new Exception("La fecha de inicio no puede ser mayor a la fecha de fin.");

            return objDatos.ListarHistorial(inicio, fin, tipo);
        }

        public void RegistrarAuditoriaInforme(string titulo, string tipo, int idUsuario)
        {
            // Generamos una descripción
            string descripcion = $"Generación de reporte tipo '{tipo}' solicitada al sistema.";

            objDatos.RegistrarInforme(titulo, descripcion, tipo, idUsuario);
        }

        public DataTable ObtenerVentasDeVendedorEspecifico(int idVendedor, DateTime inicio, DateTime fin)
        {
            if (inicio > fin) throw new Exception("Fechas incorrectas.");
            return objDatos.ObtenerVentasDeVendedor(idVendedor, inicio, fin);
        }

        public int ObtenerCantidadVentasGlobal(DateTime inicio, DateTime fin)
        {
            DataTable dt = objDatos.ObtenerDatosInforme("PROC_COUNT_VENTAS_GLOBAL", inicio, fin);

            if (dt.Rows.Count > 0 && dt.Columns.Contains("cantidad"))
            {
                return Convert.ToInt32(dt.Rows[0]["cantidad"]);
            }
            return 0;
        }
    }
}