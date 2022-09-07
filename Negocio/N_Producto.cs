using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class N_Producto
    {
        D_Producto obj;
        public List<E_Producto> ListarProductos()
        {
            if (obj == null) { obj = new D_Producto(); }
            return obj.ListarProductos();
        }

        public List<E_Producto> BuscarProducto(string buscar)
        {
            if (obj == null) { obj = new D_Producto(); }
            return obj.BuscarProducto(buscar);
        }

        public void EliminarProducto(E_Producto objEliminar)
        {
            if (obj == null) { obj = new D_Producto(); }
            obj.EliminarProducto(objEliminar);
        }

        public void EditarProducto(E_Producto objEliminar)
        {
            if (obj == null) { obj = new D_Producto(); }
            obj.EditarProducto(objEliminar);
        }
    }
}
