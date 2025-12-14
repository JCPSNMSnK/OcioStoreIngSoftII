using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    // Asegúrate de que la clase Proveedor ya tenga el campo Baja_Proveedor añadido
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
        public List<Proveedor> proveedores { get; set; }


        // Para manejar las categorías - productos
        public string CategoriasConcatenadas
        {
            get
            {
                if (categorias != null && categorias.Any())
                {
                    return string.Join(", ", categorias.Select(c => c.nombre_categoria));
                }
                return "";
            }
        }

        public string ProveedoresConcatenados
        {
            get
            {
                if (proveedores != null && proveedores.Any())
                {
                    // Une los nombres de los proveedores separados por ", "
                    return string.Join(", ", proveedores.Select(p => p.nombre_proveedor));
                }
                return "";
            }
        }


        // Constructor 1: Para registrar en DB (sin bool de baja)
        // Se espera una lista de proveedores (List<Proveedor> o List<int>)
        public Producto(string nombre, List<Categoria> categorias, List<Proveedor> proveedores, decimal precioLista, decimal precioVenta, int stockInicial, int stockMinimo, string descripcionProducto, int cod_producto)
        {
            this.id_producto = 0;
            this.nombre_producto = nombre;
            this.fechaIngreso = DateTime.Now;
            this.precioLista = precioLista;
            this.precioVenta = precioVenta;
            this.baja_producto = false;
            this.stock = stockInicial;
            this.stock_min = stockMinimo;
            this.descripcion = descripcionProducto;
            this.categorias = categorias ?? new List<Categoria>();
            this.proveedores = proveedores ?? new List<Proveedor>(); // Inicializa la lista de proveedores
            this.cod_producto = cod_producto;
        }

        // Constructor 2: Para registrar en DB (recibe bool de baja)
        public Producto(string nombre, List<Categoria> categorias, List<Proveedor> proveedores, decimal precioLista, decimal precioVenta, bool estaDeBaja, int stockInicial, int stockMinimo, string descripcionProducto, int cod_producto)
        {
            this.id_producto = 0;
            this.nombre_producto = nombre;
            this.fechaIngreso = DateTime.Now;
            this.precioLista = precioLista;
            this.precioVenta = precioVenta;
            this.baja_producto = estaDeBaja;
            this.stock = stockInicial;
            this.stock_min = stockMinimo;
            this.descripcion = descripcionProducto;
            this.categorias = categorias ?? new List<Categoria>();
            this.proveedores = proveedores ?? new List<Proveedor>(); // Inicializa la lista de proveedores
            this.cod_producto = cod_producto;
        }

        // Constructor 3: Para producto ya registrado (traído desde la DB)
        public Producto(int idProducto, string nombre, DateTime fechaIngreso, decimal precioLista, decimal precioVenta, bool estaDeBaja, int stockActual, int stockMinimo, string descripcionProducto, List<Categoria> categorias, List<Proveedor> proveedores, int cod_producto)
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
            this.proveedores = proveedores ?? new List<Proveedor>(); // Asigna la lista de proveedores
            this.cod_producto = cod_producto;
        }

        // constructor vacío
        public Producto() { }
    }
}