using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace UI
{
    public partial class FormDocente : Form
    {
        private readonly DocenteBLL docenteBLL = new DocenteBLL(); 
        private Docente docenteSeleccionado = null;
        public FormDocente()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try 
            { 
                dgvDocentes.DataSource = null; 
                dgvDocentes.AutoGenerateColumns = true; 
                dgvDocentes.DataSource = docenteBLL.ObtenerDocentes(); 
            } 
            catch (Exception ex)
            { 
                MessageBox.Show("Error al cargar listado de docentes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try 
            { 
                if (!decimal.TryParse(txtValorHora.Text.Trim(), out decimal valorHora)) 
                { 
                    MessageBox.Show("Ingrese un valor numérico válido para el valor de la hora cátedra.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                    return; 
                } 
                Docente docente = new Docente {
                    DocenteID = docenteSeleccionado != null ? docenteSeleccionado.DocenteID : 0, 
                    Legajo = txtLegajo.Text.Trim(), 
                    Nombre =txtNombre.Text.Trim(), 
                    Apellido = txtApellido.Text.Trim(), 
                    DNI = txtDNI.Text.Trim(), 
                    Titulo = txtTitulo.Text.Trim(),
                    ValordeHora = txtValorHora.Text.Trim() != "" ? Convert.ToDouble(txtValorHora.Text.Trim()) : 0
                }; 
                if (docenteBLL.GuardarDocente(docente)) 
                {
                    MessageBox.Show("Docente guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario(); 
                    CargarGrilla();
                } 
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void LimpiarFormulario()
        {

            docenteSeleccionado = null;
            txtLegajo.Clear(); 
            txtNombre.Clear(); 
            txtApellido.Clear();
            txtDNI.Clear(); 
            txtTitulo.Clear(); 
            txtValorHora.Clear();
            btnGuardar.Text = "Guardar Docente";
        }


        private void btnElminar_Click(object sender, EventArgs e)
        {
            try { 
                if (docenteSeleccionado == null) 
                { 
                    MessageBox.Show("Seleccione un docente de la grilla para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; 
                } 
                DialogResult dr = MessageBox.Show($"¿Está seguro de eliminar al docente {docenteSeleccionado.Nombre} {docenteSeleccionado.Apellido}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
                if (dr == DialogResult.Yes) 
                { 
                    if (docenteBLL.EliminarDocente(docenteSeleccionado.DocenteID)) 
                    { 
                        MessageBox.Show("Docente eliminado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information); LimpiarFormulario(); 
                        CargarGrilla(); 
                    } 
                } 
            } 
            catch (Exception ex)
            { 
                MessageBox.Show("Error al eliminar el docente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void dgvDocentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            { 
                DataGridViewRow row = dgvDocentes.Rows[e.RowIndex]; 
                docenteSeleccionado = new Docente 
                { 
                    DocenteID = Convert.ToInt32(row.Cells["DocenteID"].Value), 
                    Legajo = row.Cells["Legajo"].Value.ToString(),
                    Nombre = row.Cells["Nombre"].Value.ToString(),
                    Apellido = row.Cells["Apellido"].Value.ToString(), 
                    DNI = row.Cells["DNI"].Value.ToString(), 
                    Titulo = row.Cells["Titulo"].Value.ToString(),
                    ValordeHora = Convert.ToDouble(row.Cells["ValorHoraCatedra"].Value) 
                };
                txtLegajo.Text = docenteSeleccionado.Legajo;
                txtNombre.Text = docenteSeleccionado.Nombre; 
                txtApellido.Text = docenteSeleccionado.Apellido;
                txtDNI.Text = docenteSeleccionado.DNI; 
                txtTitulo.Text = docenteSeleccionado.Titulo;
                txtValorHora.Text = docenteSeleccionado.ValordeHora.ToString("0.00"); 
                btnGuardar.Text = "Modificar Docente";
            }
        }
    }
}
