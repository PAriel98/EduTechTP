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
    public partial class FormRecaudacionClase : Form
    {
        private readonly RecaudacionBLL recaudacionBLL = new RecaudacionBLL();
        private bool _cargando = true;
        public FormRecaudacionClase()
        {
            InitializeComponent();
        }

        private void FormRecaudacionClase_Load(object sender, EventArgs e)
        {
            _cargando = true;
            InicializarFechas();
            CargarCombo(); 
            _cargando = false;
            BuscarRecaudacion();
        }

        private void BuscarRecaudacion()
        {
            if (_cargando) return;
            try
            {
                if (cmbClases.SelectedValue == null) return; int componenteId = 0;
                if (cmbClases.SelectedValue is int id)
                {
                    componenteId = id;
                }
                else
                    if (cmbClases.SelectedItem is ComponenteEducativoBE comp)
                    {
                        componenteId = comp.ComponenteID;
                    }
                DateTime desde = dtpFechaDesde.Value;
                DateTime hasta = dtpFechaHasta.Value;
                var reporte = recaudacionBLL.ConsultarRecaudacionPorClase(componenteId, desde, hasta, out decimal totalMonto, out int totalAlumnos); dgvRecaudacion.DataSource = null;
                dgvRecaudacion.AutoGenerateColumns = true;
                dgvRecaudacion.DataSource = reporte;
                lblTotalRecaudado.Text = $"Total Recaudado: {totalMonto:C2}";
                lblCantidadAlumnos.Text = $"Alumnos Inscriptos: {totalAlumnos}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void InicializarFechas()
        {
            DateTime hoy = DateTime.Now;
            dtpFechaDesde.Value = new DateTime(hoy.Year, 1, 1); 
            dtpFechaHasta.Value = hoy;
        }

        private void CargarCombo()
        {
            try {
                cmbClases.DisplayMember = "Nombre"; 
                cmbClases.ValueMember = "ComponenteID"; 
                cmbClases.DataSource = recaudacionBLL.CargarComboClases();
                cmbClases.SelectedIndex = 0;
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show("Error al cargar la lista de clases: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            BuscarRecaudacion();
        }

        private void cmbClases_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cargando) return;
            BuscarRecaudacion();
        }
    }
}
