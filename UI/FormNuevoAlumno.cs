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
    public partial class FormNuevoAlumno : FormTraducible
    {
        private readonly EstudianteBLL estudianteBLL = new EstudianteBLL(); 
        private Estudiante estudianteSeleccionado = null;
        public FormNuevoAlumno()
        {
            InitializeComponent();
            btn_cerrar_alumno.Click += btn_cerrar_alumno_Click;
        }

        private void FormNuevoAlumno_Load(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_alumno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_alta_alumno_Click(object sender, EventArgs e)
        {
            try 
            { 
                if (!int.TryParse(txtDNI.Text.Trim(),out int dni)) 
                { 
                    MessageBox.Show("Ingrese un DNI válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                    return; 
                } 
                Estudiante nuevoEstudiante = new Estudiante 
                { 
                    Nombre = txtNombre.Text.Trim(), DNI = dni 
                }
                ; 
                if (estudianteBLL.AgregarEstudiante(nuevoEstudiante)) 
                {
                    MessageBox.Show("Alumno agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario(); 
                } 
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message, "Error al agregar", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void btn_modificar_usuario_Click(object sender, EventArgs e)
        {
            try 
            { 
                if (estudianteSeleccionado == null) 
                {
                    MessageBox.Show("Seleccione primero un alumno para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            return;
                } 
                if (!int.TryParse(txtDNI.Text.Trim(), out int dni))
                { 
                    MessageBox.Show("Ingrese un DNI válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                } 
                estudianteSeleccionado.Nombre = txtNombre.Text.Trim();
                estudianteSeleccionado.DNI = dni; 
                if (estudianteBLL.ModificarEstudiante(estudianteSeleccionado))
                { 
                    MessageBox.Show("Datos del alumno actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information); LimpiarFormulario(); 
                } 
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message, "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear(); 
            txtDNI.Clear(); 
            estudianteSeleccionado = null;
        }
    }
}
