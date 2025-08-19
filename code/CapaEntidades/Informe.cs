using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Informe
    {
        public int id_informe { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public DateTime fecha_generacion { get; set; }
        public string tipo_informe { get; set; }
        public Usuario objUsuario { get; set; }

        // Constructor para registrar un nuevo informe
        public Informe(string tituloInforme, string tipoInforme, string descripcionInforme, Usuario usuario)
        {
            this.id_informe = 0; // ID por defecto
            this.titulo = tituloInforme;
            this.descripcion = descripcionInforme;
            this.fecha_generacion = DateTime.Now;
            this.tipo_informe = tipoInforme;
            this.objUsuario = usuario;
        }

        // Constructor para cargar un informe existente
        public Informe(int idInforme, string tituloInforme, string descripcionInforme, DateTime fechaGeneracion, string tipoInforme, Usuario usuario)
        {
            this.id_informe = idInforme;
            this.titulo = tituloInforme;
            this.descripcion = descripcionInforme;
            this.fecha_generacion = fechaGeneracion;
            this.tipo_informe = tipoInforme;
            this.objUsuario = usuario;
        }

        public Informe() { }
    }
}