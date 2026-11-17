using BE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class InscripcionDAL
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["EduTechDB"].ConnectionString;
        public List<InscripcionCursoBE> ListarInscripciones()
        {
            List<InscripcionCursoBE> lista = new List<InscripcionCursoBE>();

            string query = @"
                SELECT 
                    IC.InscripcionID,
                    IC.EstudianteID,
                    E.Nombre AS EstudianteNombre,
                    IC.ComponenteID,
                    CE.Nombre AS CursoNombre,
                    IC.FechaInscripcion,
                    IC.NotaExamenFinal
                FROM InscripcionCurso IC
                INNER JOIN Estudiante E ON IC.EstudianteID = E.EstudianteID
                INNER JOIN ComponenteEducativo CE ON IC.ComponenteID = CE.ComponenteID";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new InscripcionCursoBE
                            {
                                InscripcionID = Convert.ToInt32(dr["InscripcionID"]),
                                EstudianteID = Convert.ToInt32(dr["EstudianteID"]),
                                EstudianteNombre = dr["EstudianteNombre"].ToString(),
                                ComponenteID = Convert.ToInt32(dr["ComponenteID"]),
                                CursoNombre = dr["CursoNombre"].ToString(),
                                FechaInscripcion = Convert.ToDateTime(dr["FechaInscripcion"]),
                                NotaExamenFinal = dr["NotaExamenFinal"] != DBNull.Value ? (int?)Convert.ToInt32(dr["NotaExamenFinal"]) : null
                            });
                        }
                    }
                }
            } 
            return lista;
        }

        public bool RegistrarNotaExamen(int inscripcionId, int nota) 
        { 
            using (SqlConnection con = new SqlConnection(connectionString)) 
            { 
                using (SqlCommand cmd = new SqlCommand("sp_RegistrarNotaExamen", con)) 
                { 
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@InscripcionID", inscripcionId); 
                    cmd.Parameters.AddWithValue("@Nota", nota); 
                    con.Open(); 
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0 || filas == -1; 
                } 
            } 
        }

        public List<NotificacionAcademicaBE> ListarNotificaciones()
        {
            List<NotificacionAcademicaBE> lista = new List<NotificacionAcademicaBE>();

            string query = "SELECT NotificacionID, InscripcionID, EstudianteNombre, NotaObtenida, FechaPublicacion FROM NotificacionAcademica ORDER BY FechaPublicacion DESC";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new NotificacionAcademicaBE
                            {
                                NotificacionID = Convert.ToInt32(dr["NotificacionID"]),
                                InscripcionID = Convert.ToInt32(dr["InscripcionID"]),
                                EstudianteNombre = dr["EstudianteNombre"].ToString(),
                                NotaObtenida = Convert.ToInt32(dr["NotaObtenida"]),
                                FechaPublicacion = Convert.ToDateTime(dr["FechaPublicacion"])
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}
