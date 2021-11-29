using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Categoria
    {
        D_Categoria objDato = new D_Categoria();

        public List<E_Categoria> ListarCategoria(string buscar)
        {
           return objDato.ListarCategoria(buscar);
        }

        public void InsertarCategoria(E_Categoria obj)
        {
           objDato.InsertarCategoria(obj);
        }

        public void EditarCategoria(E_Categoria obj)
        {
           objDato.EditarCategoria(obj);
        }

        public void EliminarCategoria(E_Categoria obj)
        {
           objDato.EliminarCategoria(obj);
        }

    }
}
