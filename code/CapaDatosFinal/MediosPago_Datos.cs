using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class MedioPago_Datos
    {
        public List<MediosPago> Listar()//mostrarMediosPago
        {
            List<MediosPago> lista = new List<MediosPago>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT id_medioPago, nombre_medio, comision FROM MetodosPago;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            lista.Add(new MediosPago()
                            {
                                id_medioPago = Convert.ToInt32(dataReader["id_medioPago"]),
                                nombre_medio = dataReader["nombre_medio"].ToString(),
                                comision = Convert.ToDecimal(dataReader["comision"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<MediosPago>();
                }
            }
            return lista;
        }
        //public bool Registrar(MediosPago obj, out string MediosPago)//crearMediosPago
        //{
        //    bool resultado = false;
        //    Mensaje = string.Empty;

        //    try
        //    {
        //        using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
        //        {
        //            SqlCommand cmd = new SqlCommand("PROC_REGISTRAR_RESPUESTA", oconexion);
        //            cmd.Parameters.AddWithValue("id_mensaje", obj.id_mensaje);
        //            cmd.Parameters.AddWithValue("respuesta", obj.respuesta);
        //            cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
        //            cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

        //            cmd.CommandType = CommandType.StoredProcedure;

        //            oconexion.Open();
        //            cmd.ExecuteNonQuery();

        //            resultado = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
        //            Mensaje = cmd.Parameters["mensaje"].Value.ToString();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        resultado = false;
        //        MediosPago = ex.Message;
        //    }

        //    return resultado;
        //}
    }
}
