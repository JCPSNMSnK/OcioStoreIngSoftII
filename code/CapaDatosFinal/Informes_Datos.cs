using CapaEntidades;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System;

namespace CapaDatos
{
    public class Informes_Datos
    {

        public DataTable ObtenerDatosInforme(string nombreStoreProcedure, DateTime? inicio, DateTime? fin)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(nombreStoreProcedure, oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Solo agregamos fechas si no son nulas
                    if (inicio.HasValue && fin.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@fecha_inicio", inicio.Value);
                        cmd.Parameters.AddWithValue("@fecha_fin", fin.Value);
                    }

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        tabla.Load(dr); // Llena el DataTable con lo que venga del SP
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return tabla;
        }

        public bool RegistrarInforme(string titulo, string descripcion, string tipo, int idUsuario)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PROC_REGISTRAR_INFORME", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@titulo", titulo);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@tipo_informe", tipo);
                    cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                    cmd.Parameters.AddWithValue("@fecha_generacion", DateTime.Now);

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable ListarHistorial(DateTime inicio, DateTime fin, string tipo)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PROC_BUSCAR_INFORMES_HISTORIAL", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@fecha_inicio", inicio);
                    cmd.Parameters.AddWithValue("@fecha_fin", fin);

                    if (string.IsNullOrEmpty(tipo) || tipo == "Todos")
                        cmd.Parameters.AddWithValue("@tipo_informe", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@tipo_informe", tipo);

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        tabla.Load(dr);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return tabla;
        }


        public DataTable ObtenerVentasDeVendedor(int idVendedor, DateTime inicio, DateTime fin)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PROC_INFORME_VENDEDOR_VENTAS", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_user", idVendedor);
                    cmd.Parameters.AddWithValue("@fecha_inicio", inicio);
                    cmd.Parameters.AddWithValue("@fecha_fin", fin);

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        tabla.Load(dr);
                    }
                }
                catch (Exception ex) { throw ex; }
            }
            return tabla;
        }
    }
}