using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Categoria
    {
         SqlConnection Conexion;
         SqlCommand Comando; // lleva la consulta
         SqlDataReader Lector;

        public D_Categoria()
        {
            Conexion = new SqlConnection();
            Conexion.ConnectionString = "Data Source= DESKTOP-SI4GNH1; Database= BLUECASE ;Trusted_Connection=True;";
            //"Data Source=190.210.161.90;Integrated Security=false;User ID=alumno;Password=alumno;Initial Catalog=UTN";

            Comando = new SqlCommand();
            //Comando.CommandType = CommandType.Text; // que tipo de query vas a ejecutar
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Connection = Conexion; // se agrega a donde se conecta, podes cambiar la Conexion
        }

        #region Categoria

        public List<E_Categoria> ListarCategoria(string buscar)
        {
            try
            {
                List<E_Categoria> listaLeida = new List<E_Categoria>(); // aca instancio la lista de lo que quiero leer
                Comando.CommandText = "PA_BUSCARCATEGORIA";
                Comando.Parameters.AddWithValue("@BUSCAR", buscar);

                if (Conexion.State != ConnectionState.Open) { Conexion.Open(); }

                Lector = Comando.ExecuteReader();
                while (Lector.Read())
                {
                    //Lector.GetString(2) == null ? "" : Lector.GetString(2)
                    listaLeida.Add(new E_Categoria(Lector.GetInt32(0), Lector.GetString(1), Lector.GetString(2))); 
                }

                return listaLeida;
            }
            catch (Exception ex)
            {
                throw new Exception("Fallo al leer datos. " + ex.Message);
            }
            finally
            {
                Conexion.Close();
            }
        }

        public void InsertarCategoria(E_Categoria obj)
        {
            try
            {
                Comando.Parameters.Clear();
                Comando.CommandText = "PA_INSERTARCATEGORIA";

                if (Conexion.State != ConnectionState.Open) { Conexion.Open(); }

                Comando.Parameters.AddWithValue("@NOMBRE", obj.Nombre);
                Comando.Parameters.AddWithValue("@DESCRIPCION", obj.Descripcion);

                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Fallo al insertar dato. " + ex.Message);
            }
            finally
            {
                Conexion.Close();
            }
        }

        public void EditarCategoria(E_Categoria obj)
        {
            try
            {
                Comando.Parameters.Clear();
                Comando.CommandText = "PA_EDITARCATEGORIA";

                if (Conexion.State != ConnectionState.Open) { Conexion.Open(); }

                Comando.Parameters.AddWithValue("@IDCATEGORIA", obj.IdCategoria);
                Comando.Parameters.AddWithValue("@NOMBRE", obj.Nombre);
                Comando.Parameters.AddWithValue("@DESCRIPCION", obj.Descripcion);

                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Fallo al editar dato. " + ex.Message);
            }
            finally
            {
                Conexion.Close();
            }
        }

        public void EliminarCategoria(E_Categoria obj)
        {
            try
            {
                Comando.Parameters.Clear();
                Comando.CommandText = "PA_ELIMINARCATEGORIA";

                if (Conexion.State != ConnectionState.Open) { Conexion.Open(); }

                Comando.Parameters.AddWithValue("@IDCATEGORIA", obj.IdCategoria);

                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Fallo al eliminar dato. " + ex.Message);
            }
            finally
            {
                Conexion.Close();
            }
        }

        #endregion
    }
}
