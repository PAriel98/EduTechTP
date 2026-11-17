using BE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class RecaudacionDAL
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["EduTechDB"]?.ConnectionString ?? @"Data Source=.\\SQLEXPRESS;Initial Catalog=EduTechDB;Integrated Security=True;"; 
        public List<ReporteRecaudacionBE> ObtenerRecaudacion(DateTime? fechaDesde, DateTime? fechaHasta)
        {
            List<ReporteRecaudacionBE> lista = new List<ReporteRecaudacionBE>();
            using (SqlConnection con = new SqlConnection(connectionString)) 
            { 
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerTotalRecaudado", con)) 
                { 
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FechaDesde", (object)fechaDesde ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@FechaHasta", (object)fechaHasta ?? DBNull.Value); 
                    con.Open(); 
                    using (SqlDataReader dr = cmd.ExecuteReader()) 
                    { 
                        while (dr.Read()) 
                        {
                            lista.Add(new ReporteRecaudacionBE 
                            { 
                                ComponenteID = Convert.ToInt32(dr["ComponenteID"]),
                                CursoNombre = dr["CursoNombre"].ToString(), 
                                PrecioUnitario = Convert.ToDecimal(dr["PrecioUnitario"]), 
                                CantidadInscriptos = Convert.ToInt32(dr["CantidadInscriptos"]),
                                SubtotalRecaudado = Convert.ToDecimal(dr["SubtotalRecaudado"]) 
                            }); 
                        } 
                    } 
                }
            }
            return lista;
        }

        public List<ComponenteEducativoBE> ListarClasesCombo()
        {
            List<ComponenteEducativoBE> lista = new List<ComponenteEducativoBE>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ListarComponentesEducativos", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new CursoBE { 
                                ComponenteID = Convert.ToInt32(dr["ComponenteID"]), 
                                Nombre = dr["Nombre"].ToString(),
                                Precio = Convert.ToDecimal(dr["Precio"]) 
                            });
                        }
                    }
                }
            }
            return lista;
        }
        public List<RecaudacionClase> ObtenerRecaudacionPorClase(int? componenteId, DateTime? fechaDesde, DateTime? fechaHasta)
        {
            List<RecaudacionClase> lista = new List<RecaudacionClase>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerRecaudacionPorClase", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ComponenteID", (object)componenteId ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@FechaDesde", (object)fechaDesde ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@FechaHasta", (object)fechaHasta ?? DBNull.Value);

                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new RecaudacionClase
                            {
                                ComponenteID = Convert.ToInt32(dr["ComponenteID"]),
                                ClaseNombre = dr["ClaseNombre"].ToString(),
                                PrecioUnitario = Convert.ToDecimal(dr["PrecioUnitario"]),
                                CantidadInscriptos = Convert.ToInt32(dr["CantidadInscriptos"]),
                                TotalRecaudado = Convert.ToDecimal(dr["TotalRecaudado"])
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}
