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
        
        public bool RegistrarMedioDePago(MediosPago objMetPago, out string Metodos)//crearVenta ()
        {

            Ventas = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("PROC_REGISTRAR_METODO", oconexion);
                    cmd.Parameters.AddWithValue("comision", obj.comision);
                    cmd.Parameters.AddWithValue("nombre_medio", obj.nombre_medio);

                    cmd.Parameters.Add("id_medio_registrado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    id_medio_registrado = Convert.ToInt32(cmd.Parameters["id_medio_registrado"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                id_medio_registrado = 0;
                Mensaje = ex.Message;
            }

            return id_medio_registrado;

            
        }
    }
}
