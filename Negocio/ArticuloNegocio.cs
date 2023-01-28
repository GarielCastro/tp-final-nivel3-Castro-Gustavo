using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoaDatos datos = new AccesoaDatos();
           // SqlConnection conexion = new SqlConnection();
           // SqlCommand comando = new SqlCommand();
            //SqlDataReader lector;
            try
            {
                datos.setearConsulta("SELECT Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio from Articulos");
                datos.ejecutarConsulta();
                //conexion.ConnectionString = "data source=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                //comando.CommandType = System.Data.CommandType.Text;
                //comando.CommandText = "SELECT codigo, nombre, descripcion from articulos";
                //comando.Connection = conexion;
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = datos.Lector.GetInt32(0); 
                    aux.Codigo = datos.Lector.GetString(1);
                    aux.Nombre = datos.Lector.GetString(2);
                    aux.Descripcion = datos.Lector.GetString(3);
                    aux.Marca = datos.Lector.GetInt32(4);
                    aux.Categoria = datos.Lector.GetInt32(5);
                    aux.UrlImagen = datos.Lector.GetString(6);
                    aux.Precio = (decimal)datos.Lector.GetSqlMoney(7);
                    
                    lista.Add(aux);
                //conexion.Close();
                }
            
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
}
}
