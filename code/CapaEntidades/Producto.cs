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
        public int stock_min { get; set; }
        public string descripcion { get; set; }
        public List<Categoria> categorias { get; set; }
        public int cod_producto { get; set; }
        public int id_proveedor { get; set; }


        //Para manejar las categorías - productos
        public string CategoriasConcatenadas
        {
            get
            {
                // Si la lista de categorías no es nula y tiene elementos,
                // une los nombres de las categorías con ", ". Si no, devuelve un string vacío.
                if (categorias != null && categorias.Any())
                {
                    return string.Join(", ", categorias.Select(c => c.nombre_categoria));
                }
                return "";
            }
        }


        //constructor con ID por defecto y fecha de ahora, para registrar en DB y pasado a la capa de datos para su registro
        //no recibe el booleana de dado de baja y lo asigna como false
        public Producto(string nombre, List<Categoria> categorias, decimal precioLista, decimal precioVenta, int stockInicial, int stockMinimo, string descripcionProducto, int cod_producto, int id_proveedor)
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
            this.categorias = categorias ?? new List<Categoria>(); // Asegura que la lista no sea null
            this.cod_producto = cod_producto;
            this.id_proveedor = id_proveedor;
        }

        //constructor con ID por defecto y fecha de ahora, para registrar en DB y pasado a la capa de datos para su registro
        //recibe el booleano de baja por parametro
        public Producto(string nombre, List<Categoria> categorias, decimal precioLista, decimal precioVenta, bool estaDeBaja, int stockInicial, int stockMinimo, string descripcionProducto, int cod_producto, int id_proveedor)
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
            this.categorias = categorias ?? new List<Categoria>();
            this.cod_producto = cod_producto;
            this.id_proveedor = id_proveedor;
        }

        //constructor para producto que tiene asignado un ID en la DB, producto registrado y traído desde la DB por consulta
        public Producto(int idProducto, string nombre, DateTime fechaIngreso, decimal precioLista, decimal precioVenta, bool estaDeBaja, int stockActual, int stockMinimo, string descripcionProducto, List<Categoria> categorias, int cod_producto, int id_proveedor)
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
            this.categorias = categorias ?? new List<Categoria>();
            this.cod_producto = cod_producto;
            this.id_proveedor = id_proveedor;
        }

        //constructor vacío
        public Producto() { }
    }
}
