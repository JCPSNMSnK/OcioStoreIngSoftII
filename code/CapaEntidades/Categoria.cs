using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Categoria
    {
        public int id_categoria { get; private set; }
        public string nombre_categoria { get; private set; }
        public bool baja_categoria { get; private set; }

        public Categoria(string nombre)
        {
            this.id_categoria = 0; // ID por defecto, asumirá uno real al persistir
            this.nombre_categoria = nombre;
            this.baja_categoria = false; // Por defecto, una categoría nueva no está de baja
        }

        public Categoria(int idCategoria, string nombre, bool estaDeBaja)
        {
            this.id_categoria = idCategoria;
            this.nombre_categoria = nombre;
            this.baja_categoria = estaDeBaja;
        }
    }
}
