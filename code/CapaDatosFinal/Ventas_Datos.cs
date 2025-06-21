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
    public class Ventas_Datos
    {
        public List<Ventas> Listar()//mostrarVentas
        {
            List<Ventas> lista = new List<Ventas>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT id_venta,total,id_medio,id_user,fecha_venta FROM ventas v");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            lista.Add(new Ventas()
                            {
                                id_venta = Convert.ToInt32(dataReader["id_venta"]),
                                total = Convert.ToSingle(dataReader["total"]),
                                objMediosPago = new MediosPago()
                                {
                                    id_medioPago = Convert.ToInt32(dataReader["id_medioPago"]),
                                    nombre_medio = dataReader["nombre_medio"].ToString(),
                                    comision = Convert.ToDecimal(dataReader["comision"]),
                                },

                                objUsuario = new Usuario()
                                {
                                    id_user = Convert.ToInt32(dataReader["id_user"]),
                                    apellido = dataReader["apellido"].ToString(),
                                    nombre = dataReader["nombre"].ToString(),
                                    dni = Convert.ToInt32(dataReader["dni"]),
                                    mail = dataReader["mail"].ToString(),
                                    username = dataReader["username"].ToString(),
                                    pass = dataReader["pass"].ToString(),
                                    baja_user = Convert.ToBoolean(dataReader["baja_user"]),
                                    objRoles = new Roles(){
                                        id_rol = Convert.ToInt32(dataReader["id_rol"]),
                                        nombre_rol = dataReader["nombre_rol"].ToString(),
                                    }
                                },
                                
                                fecha_venta = Convert.ToDateTime(dataReader["fecha_venta"]),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Ventas>();
                }
            }
            return lista;
        }
        //public bool Registrar(Ventas obj, MetodoPago objMetPago, out string Ventas)//crearVenta hay que cambiar el procedimiento almac
        //{
        //    
        //    Ventas = string.Empty;

        //    try
        //    {
        //        using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
        //        {
        //            SqlCommand cmd = new SqlCommand("PROC_REGISTRAR_VENTA", oconexion);
        //            cmd.Parameters.AddWithValue("total", obj.total);
        //            cmd.Parameters.AddWithValue("id_medioPago", obj.objMediosPago);
        //            cmd.Parameters.AddWithValue("id_usuario", obj.objUsuario);
        //            cmd.Parameters.AddWithValue("fecha_venta", obj.fecha_venta);
        //           

        //            cmd.CommandType = CommandType.StoredProcedure;

        //            oconexion.Open();
        //            cmd.ExecuteNonQuery();

        //           
        //            Ventas = cmd.Parameters["mensaje"].Value.ToString();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        resultado = false;
        //        Ventas = ex.Message;
        //    }

        //    return resultado;
        //}
    }
}
