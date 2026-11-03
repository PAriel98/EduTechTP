using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CursoDAL
    {
        private readonly string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=EduTechDB;Integrated Security=True";
        public bool Insertar(CursoBE curso)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertarCurso", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", curso.Nombre);
                    cmd.Parameters.AddWithValue("@Precio", curso.Precio);
                    cmd.Parameters.AddWithValue("@EsProgramaCompleto", curso.EsProgramaCompleto);
                    conexion.Open();
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0 || filas == -1;
                }
            }
        }
        public bool Modificar(CursoBE curso)
        { 
            using (SqlConnection conexion = new SqlConnection(connectionString)) 
            { 
                using (SqlCommand cmd = new SqlCommand("sp_ModificarCurso", conexion)) 
                { 
                    cmd.CommandType = CommandType.StoredProcedure; 
                    cmd.Parameters.AddWithValue("@ComponenteID", curso.ComponenteID); 
                    cmd.Parameters.AddWithValue("@Nombre", curso.Nombre); 
                    cmd.Parameters.AddWithValue("@Precio", curso.Precio);
                    cmd.Parameters.AddWithValue("@EsProgramaCompleto", curso.EsProgramaCompleto); 
                    conexion.Open(); 
                    int filas = cmd.ExecuteNonQuery(); 
                    return filas > 0 || filas == -1; 
                } 
            } 
        }
        public List<CursoBE> Listar()
        {
            List<CursoBE> lista = new List<CursoBE>();

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ListarCursos", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new CursoBE
                            {
                                ComponenteID = Convert.ToInt32(dr["ComponenteID"]),
                                Nombre = dr["Nombre"].ToString(),
                                Precio = Convert.ToDecimal(dr["Precio"]),
                                EsProgramaCompleto = Convert.ToBoolean(dr["EsProgramaCompleto"])
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
} 
