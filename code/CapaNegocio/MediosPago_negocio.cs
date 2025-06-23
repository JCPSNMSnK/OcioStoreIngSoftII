using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class MediosPago_negocio
    {
        private MedioPago_Datos objMedios_datos = new MedioPago_Datos();

        public List<MediosPago> Listar()
        {
            return objMedios_datos.ListarMediosPago();
        }
    }
}

