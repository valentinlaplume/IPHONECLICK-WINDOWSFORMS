using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Producto
    {
        int idProducto;
        string nombre;
        float precio_Compra;
        float precio_Venta;
        int stock;
        int idCategoria;
        string categoria;

        public E_Producto() { }

        public E_Producto(int idProductos, string nombre, float precio_Compra, float precio_Venta, int stock, int idCategoria)
        {
            this.IdProducto = idProductos;
            this.Nombre = nombre;
            this.Precio_Compra = precio_Compra;
            this.Precio_Venta = precio_Venta;
            this.Stock = stock;
            this.IdCategoria = idCategoria;
        }

        public E_Producto(int idProducto, string nombre, float precio_Compra, float precio_Venta, int stock, int idCategoria, string categoria)
            : this(idProducto, nombre, precio_Compra, precio_Venta, stock, idCategoria)
        {
            this.Categoria = categoria;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float Precio_Compra { get => precio_Compra; set => precio_Compra = value; }
        public float Precio_Venta { get => precio_Venta; set => precio_Venta = value; }
        public int Stock { get => stock; set => stock = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string Categoria { get => categoria; set => categoria = value; }
    }
}
