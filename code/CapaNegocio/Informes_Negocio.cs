using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class Informes_Negocio
    {

        private Informes_Datos objInformes_datos = new Informes_Datos();

        public List<ProductoVendido> ObtenerProductosMasVendidos(DateTime fechaInicio, DateTime fechaFin)
        {
            if (fechaInicio > fechaFin)
            {
                return new List<ProductoVendido>();
            }
            List<ProductoVendido> resultados = objInformes_datos.ObtenerProductosMasVendidos(fechaInicio, fechaFin);

            return resultados;
        }

        public bool GenerarYRegistrarProductosMasVendidos(DateTime fechaInicio, DateTime fechaFin, Usuario usuario, out string mensaje)
        {
            List<ProductoVendido> resultados = this.ObtenerProductosMasVendidos(fechaInicio, fechaFin);

            Informe informe = new Informe("Informe de Productos más vendidos", "Productos más vendidos",
              $"Informe de productos más vendidos desde {fechaInicio.ToShortDateString()} hasta {fechaFin.ToShortDateString()}",
              usuario);

            return objInformes_datos.RegistrarInforme(informe, out mensaje);
        }

        public List<VentaPorPeriodo> ObtenerFluctuacionDeVentas(DateTime fechaInicio, DateTime fechaFin)
        {
            if (fechaInicio > fechaFin)
            {
                return new List<VentaPorPeriodo>();
            }

            List<VentaPorPeriodo> resultados = objInformes_datos.ObtenerFluctuacionDeVentas(fechaInicio, fechaFin);
            return resultados;
        }

        public bool GenerarYRegistrarFluctuacionDeVentas(DateTime fechaInicio, DateTime fechaFin, Usuario usuario, out string mensaje)
        {
            List<VentaPorPeriodo> resultados = this.ObtenerFluctuacionDeVentas(fechaInicio, fechaFin);

            Informe informe = new Informe("Informe de Ventas por Periodo de Tiempo", "Total de Ventas Realizadas",
                $"Ventas desde {fechaInicio.ToShortDateString()} hasta {fechaFin.ToShortDateString()}",
                usuario);

            return objInformes_datos.RegistrarInforme(informe, out mensaje);
        }

        public List<CategoriaMasVendida> ObtenerCategoriasMasVendidas(DateTime fechaInicio, DateTime fechaFin)
        {
            if (fechaInicio > fechaFin)
            {
                return new List<CategoriaMasVendida>();
            }

            List<CategoriaMasVendida> resultados = objInformes_datos.ObtenerCategoriasMasVendidas(fechaInicio, fechaFin);
            return resultados;
        }

        public bool GenerarYRegistrarCategoriasMasVendidas(DateTime fechaInicio, DateTime fechaFin, Usuario usuario, out string mensaje)
        {
            List<CategoriaMasVendida> resultados = this.ObtenerCategoriasMasVendidas(fechaInicio, fechaFin);
            Informe informe = new Informe("Informe de Categorías más vendidas", "Categorías más vendidas",
                $"Informe de categorías más vendidos desde {fechaInicio.ToShortDateString()} hasta {fechaFin.ToShortDateString()}",
                usuario);
            return objInformes_datos.RegistrarInforme(informe, out mensaje);
        }

        public List<VendedorConMasVentas> ObtenerVendedoresConMasVentas(DateTime fechaInicio, DateTime fechaFin)
        {
            if (fechaInicio > fechaFin)
            {
                return new List<VendedorConMasVentas>();
            }
            List<VendedorConMasVentas> resultados = objInformes_datos.ObtenerVendedoresConMasVentas(fechaInicio, fechaFin);
            return resultados;
        }

        public bool GenerarYRegistrarVendedoresConMasVentas(DateTime fechaInicio, DateTime fechaFin, Usuario usuario, out string mensaje)
        {
            List<VendedorConMasVentas> resultados = this.ObtenerVendedoresConMasVentas(fechaInicio, fechaFin);

            Informe informe = new Informe("Informe de Vendedores con más ventas", "Vendedores",
                $"Informe de mejores vendedores desde {fechaInicio.ToShortDateString()} hasta {fechaFin.ToShortDateString()}",
                usuario);
            return objInformes_datos.RegistrarInforme(informe, out mensaje);
        }

        public List<Informes_Datos.VentaDetalle> ObtenerVentasVendedor(int id_vendedor, DateTime fechaInicio, DateTime fechaFin)
        {
            // Validación de fechas
            if (fechaInicio > fechaFin)
            {
                // Devuelve una lista vacía si las fechas son inconsistentes
                return new List<Informes_Datos.VentaDetalle>();
            }

            // Se invoca el método de la capa de datos con los parámetros correctos
            List<Informes_Datos.VentaDetalle> resultados = objInformes_datos.ObtenerVentasVendedor(id_vendedor, fechaInicio, fechaFin);

            return resultados;
        }

    }
}