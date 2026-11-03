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
    public partial class FormNuevoCurso : Form
    {
        private readonly CursoBLL cursoBLL = new CursoBLL(); 
        private CursoBE cursoSeleccionado = null;
        public FormNuevoCurso()
        {
            InitializeComponent();
        }

        private void lbl_titulo_alumno_Click(object sender, EventArgs e)
        {

        }

        private void btn_modificar_usuario_Click(object sender, EventArgs e)
        {
            try 
            { 
                if (cursoSeleccionado == null) 
                { 
                    MessageBox.Show("Seleccione un curso de la tabla para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; 
                } 
                if (!decimal.TryParse(txtPrecio.Text.Trim(), out decimal precio)) 
                { 
                    MessageBox.Show("Ingrese un precio válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                } 
                cursoSeleccionado.Nombre = txtNombre.Text.Trim(); 
                cursoSeleccionado.Precio = precio; 
                cursoSeleccionado.EsProgramaCompleto = chkEsProgramaCompleto.Checked; 
                if (cursoBLL.ModificarCurso(cursoSeleccionado)) 
                { 
                    MessageBox.Show("Curso actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario(); 
                    CargarGrilla(); 
                } 
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message, "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btn_alta_curso_Click(object sender, EventArgs e)
        {
            try 
            { 
                if (!decimal.TryParse(txtPrecio.Text.Trim(), out decimal precio)) 
                { 
                    MessageBox.Show("Ingrese un precio válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                    return;
                } 
                CursoBE nuevoCurso = new CursoBE 
                { 
                    Nombre = txtNombre.Text.Trim(), Precio = precio, EsProgramaCompleto = chkEsProgramaCompleto.Checked 
                }; 
                if (cursoBLL.AgregarCurso(nuevoCurso)) 
                { 
                    MessageBox.Show("Curso agregado correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario(); 
                    CargarGrilla(); 
                } 
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message, "Error al agregar", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void CargarGrilla()
        {
            try { 
                dgvCursos.DataSource = null; 
                dgvCursos.DataSource = cursoBLL.ListarCursos();
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show("Error al cargar la grilla de cursos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear(); 
            txtPrecio.Clear(); 
            chkEsProgramaCompleto.Checked = false; 
            cursoSeleccionado = null;
        }

        private void FormNuevoCurso_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
                { 
                DataGridViewRow row = dgvCursos.Rows[e.RowIndex]; 
                cursoSeleccionado = new CursoBE { ComponenteID = Convert.ToInt32(row.Cells["ComponenteID"].Value), Nombre = row.Cells["Nombre"].Value.ToString(), Precio = Convert.ToDecimal(row.Cells["Precio"].Value), EsProgramaCompleto = Convert.ToBoolean(row.Cells["EsProgramaCompleto"].Value) 
                }; 
                txtNombre.Text = cursoSeleccionado.Nombre; 
                txtPrecio.Text = cursoSeleccionado.Precio.ToString("0.00"); 
                chkEsProgramaCompleto.Checked = cursoSeleccionado.EsProgramaCompleto; 
            }
        }
    }
}
