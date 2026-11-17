using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class AccesoDAL
    {
        private string ObtenerCadenaConexion()
        {
            var config = ConfigurationManager.ConnectionStrings["EduTechDB"];
            if (config != null && !string.IsNullOrWhiteSpace(config.ConnectionString))
            {
                return config.ConnectionString;
            }
            return @"Data Source=.\\SQLEXPRESS;Initial Catalog=EduTechDB;Integrated Security=True;";
        }

        private SqlConnection conexion; 
        private SqlTransaction transaccion;
        public void abrir()
        {
            if (conexion == null)
            { 
                conexion = new SqlConnection(ObtenerCadenaConexion());
            } 
            if (conexion.State != ConnectionState.Open) 
            { conexion.Open();
            } 
        }

        public void cerrar()
        {
            conexion.Close();
        }

        
        public int escribir(string query, SqlParameter[] parametros)
        {
            int filasAfectadas = 0;
            abrir();
            SqlTransaction transaccion = conexion.BeginTransaction();

            try
            {
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Transaction = transaccion;
                comando.CommandType = CommandType.Text;

                if (parametros != null && parametros.Length > 0)
                {
                    comando.Parameters.AddRange(parametros);
                }

                filasAfectadas = comando.ExecuteNonQuery();

                transaccion.Commit();
            }
            catch (Exception)
            {
                transaccion.Rollback();
                throw;
            }
            finally
            {
                cerrar();
            }

            return filasAfectadas;
        }


        public DataTable leer(string query, SqlParameter[] parametros)
        {
            DataTable tabla = new DataTable();
            abrir();
            SqlTransaction transaccion = conexion.BeginTransaction();

            try
            {
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Transaction = transaccion;
                comando.CommandType = CommandType.Text;

                if (parametros != null && parametros.Length > 0)
                {
                    foreach (SqlParameter param in parametros)
                    {
                        comando.Parameters.Add(param);
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(tabla);

                transaccion.Commit();
            }
            catch (Exception)
            {
                transaccion.Rollback();
                throw;
            }
            finally
            {
                cerrar();
            }

            return tabla;
        }
    }
}
