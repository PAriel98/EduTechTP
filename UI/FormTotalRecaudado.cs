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
using BLL;

namespace UI
{
    public partial class FormTotalRecaudado : Form
    {
        private readonly RecaudacionBLL recaudacionBLL = new RecaudacionBLL();
        public FormTotalRecaudado()
        {
            InitializeComponent();
            InicializarFechas();
            CargarReporte();
        }

        private void CargarReporte()
        {
            try
            {
                DateTime desde = dtpFechaDesde.Value; 
                DateTime hasta = dtpFechaHasta.Value;
                var lista = recaudacionBLL.ConsultarRecaudacion(desde, hasta, out decimal totalGeneral, out int totalInscripciones); dgvRecaudacion.DataSource = null; 
                dgvRecaudacion.AutoGenerateColumns = true; 
                dgvRecaudacion.DataSource = lista;
                lblTotalGeneral.Text = $"Total Recaudado: {totalGeneral:C2}"; 
                lblTotalInscripciones.Text = $"Inscripciones Totales: {totalInscripciones}"; 
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show("Error al consultar la recaudación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            }

        private void InicializarFechas()
        {
            DateTime hoy = DateTime.Now; 
            dtpFechaDesde.Value = new DateTime(hoy.Year, hoy.Month, 1); 
            dtpFechaHasta.Value = hoy;
        }

        private void FormTotalRecaudado_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarReporte();
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            InicializarFechas(); 
            CargarReporte();
        }
    }
}
