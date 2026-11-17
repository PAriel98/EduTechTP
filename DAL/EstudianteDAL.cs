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
    public class EstudianteDAL 
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["EduTechDB"].ConnectionString;
        //SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-JNUAVL4\SQLEXPRESS;Initial Catalog=EduTechDB;Integrated Security=True;");

        private SqlConnection conexion;
        private SqlTransaction transaccion;
        public bool Insertar(Estudiante estudiante) 
        { 
            using (SqlConnection conexion = new SqlConnection(connectionString)) 
            { 
                using (SqlCommand cmd = new SqlCommand("sp_InsertarEstudiante", conexion)) 
                { 
                    cmd.CommandType = CommandType.StoredProcedure; 
                    cmd.Parameters.AddWithValue("@Nombre", estudiante.Nombre);
                    cmd.Parameters.AddWithValue("@DNI", estudiante.DNI); 
                    conexion.Open(); 
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0 || filasAfectadas == -1;
                } 
            } 
        }

        public bool Modificar(Estudiante estudiante) 
        { 
            using (SqlConnection conexion = new SqlConnection(connectionString)) 
            { 
                using (SqlCommand cmd = new SqlCommand("sp_ModificarEstudiante", conexion)) 
                { 
                    cmd.CommandType = CommandType.StoredProcedure; 
                    cmd.Parameters.AddWithValue("@EstudianteID", estudiante.EstudianteID);
                    cmd.Parameters.AddWithValue("@Nombre", estudiante.Nombre); 
                    cmd.Parameters.AddWithValue("@DNI", estudiante.DNI); 
                    conexion.Open(); 
                    return cmd.ExecuteNonQuery() > 0; 
                } 
            }
        }
        public bool ExisteDNI(int dni, int estudianteIdExcluir = 0)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            { 
                string query = "SELECT COUNT(1) FROM Estudiante WHERE DNI = @DNI AND EstudianteID <> @EstudianteID"; 
                using (SqlCommand cmd = new SqlCommand(query, conexion)) 
                { 
                    cmd.CommandType = CommandType.Text; cmd.Parameters.AddWithValue("@DNI", dni); 
                    cmd.Parameters.AddWithValue("@EstudianteID", estudianteIdExcluir); 
                    conexion.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar()); 
                    return count > 0; 
                } 
            } 
        }
    }
}
