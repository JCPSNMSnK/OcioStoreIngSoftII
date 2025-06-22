using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Producto
    {
        public int id_producto { get; set; }
        public string nombre_producto { get; set; }
        public DateTime fechaIngreso { get; set; }
        public decimal precioLista { get; set; }
        public decimal precioVenta { get; set; }
        public bool baja_producto { get; set; }
        public int stock { get; set; }
        public int stock_min { get; private set; }
        public string descripcion { get; private set; }
        public List<Categoria> categoria { get; private set; }

        public Producto(string nombre, List<Categoria> categorias, decimal precioLista, decimal precioVenta, int stockInicial, int stockMinimo, string descripcionProducto)
        {
            this.id_producto = 0; // ID por defecto, asumiendo que se asignará en persistencia
            this.nombre_producto = nombre;
            this.fechaIngreso = DateTime.Now; // Fecha actual al momento de la creación
            this.precioLista = precioLista;
            this.precioVenta = precioVenta;
            this.baja_producto = false; // Por defecto, un producto nuevo no está de baja
            this.stock = stockInicial;
            this.stock_min = stockMinimo;
            this.descripcion = descripcionProducto;
            this.categoria = categorias ?? new List<Categoria>(); // Asegura que la lista no sea null
        }

        public Producto(string nombre, List<Categoria> categorias, decimal precioLista, decimal precioVenta, bool estaDeBaja, int stockInicial, int stockMinimo, string descripcionProducto)
        {
            this.id_producto = 0; // ID por defecto
            this.nombre_producto = nombre;
            this.fechaIngreso = DateTime.Now; // Fecha actual al momento de la creación
            this.precioLista = precioLista;
            this.precioVenta = precioVenta;
            this.baja_producto = estaDeBaja; // Se recibe como parámetro
            this.stock = stockInicial;
            this.stock_min = stockMinimo;
            this.descripcion = descripcionProducto;
            this.categoria = categorias ?? new List<Categoria>();
        }

        public Producto(int idProducto, string nombre, DateTime fechaIngreso, decimal precioLista, decimal precioVenta, bool estaDeBaja, int stockActual, int stockMinimo, string descripcionProducto, List<Categoria> categorias)
        {
            this.id_producto = idProducto;
            this.nombre_producto = nombre;
            this.fechaIngreso = fechaIngreso;
            this.precioLista = precioLista;
            this.precioVenta = precioVenta;
            this.baja_producto = estaDeBaja;
            this.stock = stockActual;
            this.stock_min = stockMinimo;
            this.descripcion = descripcionProducto;
            this.categoria = categorias ?? new List<Categoria>();
        }
    }
}
