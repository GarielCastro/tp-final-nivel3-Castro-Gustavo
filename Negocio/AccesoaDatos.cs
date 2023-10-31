using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    public class AccesoaDatos
    {
        private SqlConnection conexion = new SqlConnection();
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }
        public AccesoaDatos()
        {
            conexion = new SqlConnection("data source=.\\SQLEXPRESS; initial catalog=ACCESORIO_DB; integrated security=true");
        }
        public void setearConsulta(string consulta)
        {
            try
            {
                comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = consulta;

            }
            catch (Exception ex )
            {

                throw ex;
            }

        }
        public void agregarParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }
        public void ejecutarConsulta()
        {
            comando.Connection = conexion;
            conexion.Open();
            lector = comando.ExecuteReader();
        }
        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            conexion.Open();
            comando.ExecuteNonQuery();
        }
        public void cerrarConexion()
        {
            conexion.Close();
            if (lector != null)
                lector.Close();

        }

    }
}
