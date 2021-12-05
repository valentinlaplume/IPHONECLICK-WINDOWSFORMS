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
    public class D_Producto
    {
        SqlConnection Conexion;
        SqlCommand Comando; // lleva la consulta
        SqlDataReader Lector;

        public D_Producto()
        {
            Conexion = new SqlConnection();
            Conexion.ConnectionString = "Data Source= DESKTOP-SI4GNH1; Database= BLUECASE ;Trusted_Connection=True;";
            //"Data Source=190.210.161.90;Integrated Security=false;User ID=alumno;Password=alumno;Initial Catalog=UTN";

            Comando = new SqlCommand();
            //Comando.CommandType = CommandType.Text; // que tipo de query vas a ejecutar
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Connection = Conexion; // se agrega a donde se conecta, podes cambiar la Conexion
        }

        #region Producto

        public List<E_Producto> BuscarProducto(string buscar)
        {
            try
            {
                Comando.Parameters.Clear();
                List<E_Producto> listaLeida = new List<E_Producto>(); // aca instancio la lista de lo que quiero leer
                Comando.CommandText = "PA_BUSCARPRODUCTO";
                Comando.Parameters.AddWithValue("@BUSCAR", buscar);

                if (Conexion.State != ConnectionState.Open) { Conexion.Open(); }

                Lector = Comando.ExecuteReader();
                while (Lector.Read())
                {
                    //Lector.GetString(2) == null ? "" : Lector.GetString(2)
                    listaLeida.Add(new E_Producto
                    {
                        IdProducto = Lector.GetInt32(0),
                        Nombre = Lector.GetString(1),
                        Precio_Compra = (float)Lector.GetDouble(2),
                        Precio_Venta = (float)Lector.GetDouble(3),
                        Stock = Lector.GetInt32(4),
                        IdCategoria = Lector.GetInt32(5),
                        Categoria = Lector.GetString(6),
                    });
                }

                return listaLeida;
            }
            catch (Exception ex)
            {
                throw new Exception("Fallo al buscar dato. " + ex.Message);
            }
            finally
            {
                Conexion.Close();
            }
        }

        public List<E_Producto> ListarProductos()
        {
            try
            {
                Comando.Parameters.Clear();
                List<E_Producto> listaLeida = new List<E_Producto>(); 
                Comando.CommandText = "PA_LISTARPRODUCTOS";

                if (Conexion.State != ConnectionState.Open) { Conexion.Open(); }

                Lector = Comando.ExecuteReader();
                while (Lector.Read())
                {
                    listaLeida.Add(new E_Producto
                    {
                        IdProducto = Lector.GetInt32(0),
                        Nombre = Lector.GetString(1),
                        Precio_Compra = (float)Lector.GetDouble(2),
                        Precio_Venta = (float)Lector.GetDouble(3),
                        Stock = Lector.GetInt32(4),
                        IdCategoria = Lector.GetInt32(5),
                        Categoria = Lector.GetString(6),
                    });
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

        public void InsertarProducto(E_Producto obj)
        {
            try
            {
                Comando.Parameters.Clear();
                Comando.CommandText = "PA_INSERTARPRODUCTO";

                if (Conexion.State != ConnectionState.Open) { Conexion.Open(); }

                Comando.Parameters.AddWithValue("@NOMBRE", obj.Nombre);

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

        public void EditarProducto(E_Producto obj)
        {
            try
            {
                Comando.Parameters.Clear();
                Comando.CommandText = "PA_EDITARPRODUCTO";

                if (Conexion.State != ConnectionState.Open) { Conexion.Open(); }

                Comando.Parameters.AddWithValue("@IDPRODUCTO", obj.IdProducto);
                Comando.Parameters.AddWithValue("@NOMBRE", obj.Nombre);

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

        public void EliminarProducto(E_Producto obj)
        {
            try
            {
                Comando.Parameters.Clear();
                Comando.CommandText = "PA_ELIMINARPRODUCTO";

                if (Conexion.State != ConnectionState.Open) { Conexion.Open(); }

                Comando.Parameters.AddWithValue("@IDPRODUCTO", obj.IdProducto);

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
