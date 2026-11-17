using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormInformacionClases : Form
    {
        private readonly InscripcionBLL inscripcionBLL = new InscripcionBLL(); 
        private InscripcionCursoBE inscripcionSeleccionada = null;
        public FormInformacionClases()
        {
            InitializeComponent();
        }

        private void FormInformacionClases_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            var listaInscripciones = inscripcionBLL.ObtenerInscripciones();
            MessageBox.Show($"Inscripciones encontradas en BD: {listaInscripciones.Count}");
            try
            { dgvInscripciones.DataSource = null; 
               dgvInscripciones.DataSource = inscripcionBLL.ObtenerInscripciones();
              dgvNotificaciones.DataSource = null; 
                dgvNotificaciones.DataSource = inscripcionBLL.ObtenerNotificaciones(); 
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show("Error al cargar la información de clases: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarNota_Click(object sender, EventArgs e)
        {
            try 
            { 
                if (inscripcionSeleccionada == null) 
                { 
             MessageBox.Show("Seleccione una clase/inscripción de la grilla superior.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                    return;
                } 
                if 
                    (!int.TryParse(txtNotaExamen.Text.Trim(), out int nota)) 
                {
                    MessageBox.Show("Ingrese una nota válida (numero entero entre 1 y 10).", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                    return; 
                }
                if (inscripcionBLL.CargarNotaExamen(inscripcionSeleccionada.InscripcionID, nota)) 
                { 
                    MessageBox.Show("Calificacion registrada con exito. Se ha enviado la notificacion academica correspondiente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    txtNotaExamen.Clear(); 
                    inscripcionSeleccionada = null; 
                    lblInscripcion.Text = "Inscripcion seleccionada: Ninguna"; 
                    CargarDatos(); 
                } 
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message, "Error al registrar nota", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dgvInscripciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                {
                DataGridViewRow row = dgvInscripciones.Rows[e.RowIndex];
                int inscripcionId = Convert.ToInt32(row.Cells["InscripcionID"].Value); 
                string alumno = row.Cells["EstudianteNombre"].Value.ToString();
                string curso = row.Cells["CursoNombre"].Value.ToString(); 
                inscripcionSeleccionada = new InscripcionCursoBE 
                { 
                    InscripcionID = inscripcionId, EstudianteNombre = alumno, CursoNombre = curso };
                lblInscripcion.Text = $"Seleccionado: Inscripción N°{inscripcionId} - {alumno} ({curso})";
                if (row.Cells["NotaExamenFinal"].Value != null && row.Cells["NotaExamenFinal"].Value != DBNull.Value) 
                    { txtNotaExamen.Text = row.Cells["NotaExamenFinal"].Value.ToString(); 
                } 
                else { 
                    txtNotaExamen.Clear(); 
                }
            }
        }
    }
}
