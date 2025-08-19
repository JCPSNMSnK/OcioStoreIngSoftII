using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class Informes_Negocio
    {
        private Informes_Datos objInformes_datos = new Informes_Datos();

        public List<ProductoVendido> ObtenerProductosMasVendidos(DateTime fechaInicio, DateTime fechaFin, Usuario usuario)
        {
            if (fechaInicio > fechaFin)
            {
                return new List<ProductoVendido>();
            }

            // Paso 1: Obtener los datos del informe
            List<ProductoVendido> resultados = objInformes_datos.ObtenerProductosMasVendidos(fechaInicio, fechaFin);

            // Paso 2: Registrar el informe generado
            string mensajeRegistro;
            Informe informe = new Informe("Informe de Productos más vendidos", "Productos más vendidos",
              $"Informe de productos más vendidos desde {fechaInicio.ToShortDateString()} hasta {fechaFin.ToShortDateString()}",
              usuario);
            objInformes_datos.RegistrarInforme(informe, out mensajeRegistro);

            // Paso 3: Retornar los resultados
            return resultados;
        }

        public List<VentaPorPeriodo> ObtenerFluctuacionDeVentas(DateTime fechaInicio, DateTime fechaFin)
        {
            if (fechaInicio > fechaFin)
            {
                return new List<VentaPorPeriodo>();
            }

            // Paso 1: Obtener los datos del informe
            List<VentaPorPeriodo> resultados = objInformes_datos.ObtenerFluctuacionDeVentas(fechaInicio, fechaFin);

            // Paso 2: Registrar el informe generado
            string mensajeRegistro;
            Informe informe = new Informe("Informe de Ventas por Periodo de Tiempo", "Total de Ventas Realizadas",
              $"Ventas desde {fechaInicio.ToShortDateString()} hasta {fechaFin.ToShortDateString()}",
              usuario);
            objInformes_datos.RegistrarInforme(informe, out mensajeRegistro);

            // Paso 3: Retornar los resultados
            return resultados;
        }

        public List<CategoriaMasVendida> ObtenerCategoriasMasVendidas(DateTime fechaInicio, DateTime fechaFin)
        {
            if (fechaInicio > fechaFin)
            {
                return new List<CategoriaMasVendida>();
            }

            // Paso 1: Obtener los datos del informe
            List<CategoriaMasVendida> resultados = objInformes_datos.ObtenerCategoriasMasVendidas(fechaInicio, fechaFin);

            // Paso 2: Registrar el informe generado
            string mensajeRegistro;
            Informe informe = new Informe("Informe de Categorías más vendidas", "Categorías más vendidas",
              $"Informe de categorías más vendidos desde {fechaInicio.ToShortDateString()} hasta {fechaFin.ToShortDateString()}",
              usuario);
            objInformes_datos.RegistrarInforme(informe, out mensajeRegistro);

            // Paso 3: Retornar los resultados
            return resultados;
        }

        public List<VendedorConMasVentas> ObtenerVendedoresConMasVentas(DateTime fechaInicio, DateTime fechaFin)
        {
            if (fechaInicio > fechaFin)
            {
                return new List<VendedorConMasVentas>();
            }

            // Paso 1: Obtener los datos del informe
            List<VendedorConMasVentas> resultados = objInformes_datos.ObtenerVendedoresConMasVentas(fechaInicio, fechaFin);

            // Paso 2: Registrar el informe generado
            string mensajeRegistro;
            Informe informe = new Informe("Informe de Vendedores con más ventas", "Vendedores",
              $"Informe de mejores vendedores desde {fechaInicio.ToShortDateString()} hasta {fechaFin.ToShortDateString()}",
              usuario);
            objInformes_datos.RegistrarInforme(informe, out mensajeRegistro);

            // Paso 3: Retornar los resultados
            return resultados;
        }
    }
}