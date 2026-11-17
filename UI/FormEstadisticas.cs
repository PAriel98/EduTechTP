using BE;
using BLL;
using DAL;
using System;
using System.Drawing;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UI 
{
    public partial class FormEstadisticas : Form 
    {
        private readonly CursoBLL cursoBLL = new CursoBLL();
        private readonly InscripcionBLL inscripcionBLL = new InscripcionBLL();
        public FormEstadisticas()
        { 
            InitializeComponent();
        } 
        private void FormEstadisticas_Load(object sender, EventArgs e) 
        { 
            CargarGraficoInscripciones();
           
        }

        private void CargarReporteSeleccionado()
        {
            if (cmbFiltroReporte.SelectedItem == null) return; 
            string opcion = cmbFiltroReporte.SelectedItem.ToString(); 
            lblTitulo.Text = "Estadística: " + opcion; 
            try 
            { switch (opcion) 
                { 
                    case "Inscriptos por Curso": 
                        MostrarInscriptosPorCurso();
                        break;
                    case "Promedio de Calificaciones por Curso": 
                        MostrarPromediosPorCurso(); 
                        break; 
                    case "Alumnos Aprobados vs. Reprobados": 
                        MostrarAprobadosVsReprobados(); 
                        break; 
                } 
            } catch (Exception ex) 
            { MessageBox.Show("Error al cargar los datos estadísticos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void MostrarAprobadosVsReprobados()
        {
            DataTable dt = cursoBLL.ObtenerAprobadosVsReprobados(); 
            dgvDatosEstadisticos.DataSource = dt; 
            chartEstadisticas.Series.Clear(); 
            chartEstadisticas.ChartAreas.Clear();
            ChartArea area = chartEstadisticas.ChartAreas.Add("AreaAprobacion");
            Series serie = chartEstadisticas.Series.Add("Estado"); 
            serie.ChartType = SeriesChartType.Pie;
            serie.IsValueShownAsLabel = true;
            foreach (DataRow row in dt.Rows) 
            { 
                string estado = row["Estado"].ToString(); 
                int cantidad = Convert.ToInt32(row["Cantidad"]);
                serie.Points.AddXY(estado, cantidad); 
            }
        }

        private void MostrarPromediosPorCurso()
        {
            DataTable dt = cursoBLL.ObtenerPromediosPorCurso(); 
            dgvDatosEstadisticos.DataSource = dt;
            chartEstadisticas.Series.Clear(); 
            chartEstadisticas.ChartAreas.Clear();
            ChartArea area = chartEstadisticas.ChartAreas.Add("AreaPromedios"); 
            area.AxisX.Title = "Cursos"; 
            area.AxisY.Title = "Promedio Final"; 
            Series serie = chartEstadisticas.Series.Add("Promedio"); 
            serie.ChartType = SeriesChartType.Bar;
            serie.Color = Color.SteelBlue; 
            serie.IsValueShownAsLabel = true; 
            foreach (DataRow row in dt.Rows) 
            { 
                string curso = row["Curso"].ToString();
                double promedio = Convert.ToDouble(row["PromedioNota"]);
                serie.Points.AddXY(curso, promedio); 
            }
        }

        private void MostrarInscriptosPorCurso()
        {
            DataTable dt = cursoBLL.ObtenerInscriptosPorCurso();
            dgvDatosEstadisticos.DataSource = dt;
            chartEstadisticas.Series.Clear(); 
            chartEstadisticas.ChartAreas.Clear(); 
            ChartArea area = chartEstadisticas.ChartAreas.Add("AreaInscriptos"); 
            area.AxisX.Title = "Cursos"; 
            area.AxisY.Title = "Cantidad de Alumnos"; 
            Series serie = chartEstadisticas.Series.Add("Inscriptos"); 
            serie.ChartType = SeriesChartType.Column;
            serie.IsValueShownAsLabel = true; 
            foreach (DataRow row in dt.Rows)
            { 
                string curso = row["Curso"].ToString();
                int cantidad = Convert.ToInt32(row["CantidadInscriptos"]); 
                serie.Points.AddXY(curso, cantidad); 
            }
        }

        private void CargarGraficoInscripciones() 
        {            
            chartEstadisticas.Series.Clear();
            Series serie = chartEstadisticas.Series.Add("Inscriptos por Curso"); 
            serie.ChartType = SeriesChartType.Column; 
            string connectionString = ConfigurationManager.ConnectionStrings["EduTechDB"].ConnectionString;
            string query = @" SELECT CE.Nombre, COUNT(IC.InscripcionID) AS Cantidad FROM ComponenteEducativo CE LEFT JOIN InscripcionCurso IC ON CE.ComponenteID = IC.ComponenteID GROUP BY CE.Nombre"; 
            using (SqlConnection con = new SqlConnection(connectionString))
            { 
                using (SqlCommand cmd = new SqlCommand(query, con)) 
                { con.Open(); 
                    using (SqlDataReader dr = cmd.ExecuteReader()) 
                    {
                        while (dr.Read())
                        { 
                            serie.Points.AddXY(dr["Nombre"].ToString(), Convert.ToInt32(dr["Cantidad"])); 
                        } 
                    }
                }
            } 
        }

        private void cmbFiltroReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarReporteSeleccionado();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarReporteSeleccionado();
        }
    }
}