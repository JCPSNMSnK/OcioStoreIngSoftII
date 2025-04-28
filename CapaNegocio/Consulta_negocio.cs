using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Consulta_negocio
    {
        private Consulta_Datos objConsulta_datos = new Consulta_Datos();

        public List<Consulta> Listar()
        {
            return objConsulta_datos.Listar();
        }

        public bool Registrar(Consulta obj, out string Consulta)
        {
            Consulta = string.Empty;

            return objConsulta_datos.Registrar(obj, out Consulta);

        }
    }
}
