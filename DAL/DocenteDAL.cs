using BE;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DocenteDAL
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["EduTechDB"]?.ConnectionString ?? @"Data Source=.\\SQLEXPRESS;Initial Catalog=EduTechDB;Integrated Security=True;";

        private SqlConnection conexion;
        private SqlTransaction transaccion;
        public bool InsertarDocente(Docente docente) 
        { 
            using (SqlConnection con = new SqlConnection(connectionString)) 
            { 
                using (SqlCommand cmd = new SqlCommand("sp_AltaDocente", con))
                { 
                    cmd.CommandType = CommandType.StoredProcedure; 
                    cmd.Parameters.AddWithValue("@Legajo", docente.Legajo); 
                    cmd.Parameters.AddWithValue("@Nombre", docente.Nombre); 
                    cmd.Parameters.AddWithValue("@Apellido", docente.Apellido);
                    cmd.Parameters.AddWithValue("@DNI", docente.DNI); 
                    cmd.Parameters.AddWithValue("@Titulo", docente.Titulo); 
                    cmd.Parameters.AddWithValue("@ValorHoraCatedra", docente.ValordeHora);
                    con.Open(); 
                    return 
                        cmd.ExecuteNonQuery() > 0; 
                }
            } 
        }
        public bool ModificarDocente(Docente docente)
        { 
            using (SqlConnection con = new SqlConnection(connectionString)) 
            {
                using (SqlCommand cmd = new SqlCommand("sp_ModificarDocente", con)) 
                { 
                    cmd.CommandType = CommandType.StoredProcedure; 
                    cmd.Parameters.AddWithValue("@DocenteID", docente.DocenteID);
                    cmd.Parameters.AddWithValue("@Legajo", docente.Legajo); 
                    cmd.Parameters.AddWithValue("@Nombre", docente.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", docente.Apellido);
                    cmd.Parameters.AddWithValue("@DNI", docente.DNI);
                    cmd.Parameters.AddWithValue("@Titulo", docente.Titulo); 
                    cmd.Parameters.AddWithValue("@ValorHoraCatedra", docente.ValordeHora); 
                    con.Open(); 
                    return
                        cmd.ExecuteNonQuery() > 0;
                } 
            } 
        }
        public bool EliminarDocente(int docenteId) 
        { 
            using (SqlConnection con = new SqlConnection(connectionString)) 
            { 
                using (SqlCommand cmd = new SqlCommand("sp_EliminarDocente", con)) 
                { 
                    cmd.CommandType = CommandType.StoredProcedure; 
                    cmd.Parameters.AddWithValue("@DocenteID", docenteId); 
                    con.Open(); 
                    return 
                        cmd.ExecuteNonQuery() > 0; 
                } 
            } 
        }
        public List<Docente> ListarDocentes()
        {
            List<Docente> lista = new List<Docente>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ListarDocentes", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Docente
                            {
                                DocenteID = Convert.ToInt32(dr["DocenteID"]),
                                Legajo = dr["Legajo"].ToString(),
                                Nombre = dr["Nombre"].ToString(),
                                Apellido = dr["Apellido"].ToString(),
                                DNI = dr["DNI"].ToString(),
                                Titulo = dr["Titulo"].ToString(),
                                ValordeHora = (double)Convert.ToDecimal(dr["ValorHoraCatedra"])
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}
