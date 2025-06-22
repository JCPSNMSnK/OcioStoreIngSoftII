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
        public List<Ventas> ventas { get; set; }

        public Informe(Usuario usuario, string tituloInforme, string tipoInforme, string descripcionInforme)
        {
            this.id_informe = 0; // ID por defecto, asumirá uno real al persistir
            this.titulo = tituloInforme;
            this.descripcion = descripcionInforme;
            this.fecha_generacion = DateTime.Now; // Fecha y hora actuales de generación
            this.tipo_informe = tipoInforme;
            this.objUsuario = usuario;
            this.ventas = new List<Ventas>(); // Inicializa la lista de ventas vacía
        }

        public Informe(int idInforme, string tituloInforme, string descripcionInforme, DateTime fechaGeneracion, string tipoInforme, Usuario usuario, List<Ventas> listaVentas)
        {
            this.id_informe = idInforme;
            this.titulo = tituloInforme;
            this.descripcion = descripcionInforme;
            this.fecha_generacion = fechaGeneracion;
            this.tipo_informe = tipoInforme;
            this.objUsuario = usuario;
            this.ventas = listaVentas ?? new List<Ventas>(); // Asegura que la lista no sea null
        }

        public Informe()
        {
        }
    }
}
