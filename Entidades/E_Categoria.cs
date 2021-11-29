using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Categoria
    {
        int idCategoria;
        string nombre;
        string descripcion;

        public E_Categoria() { }

        public E_Categoria(int idCategoria, string nombre, string descripcion)
        {
            this.IdCategoria = idCategoria;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        
        
        public string Descripcion
        {
            get => descripcion;
            set
            {
                if (string.IsNullOrEmpty(value))
                    descripcion = "";
                else
                    descripcion = value;
            }
        }
    }
}
