using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI;

namespace EduTech
{
    public partial class FormABMFamilias : FormTraducible
    {

        private FamiliaBLL familiaBLL = new FamiliaBLL();
        public FormABMFamilias()
        {
            InitializeComponent();
        }

        private void FormABMFamilias_Load(object sender, EventArgs e)
        {
            
            ConfigurarDGV();

            CargarFamilias();
        }

        private void ConfigurarDGV()
        {
            DGVFamilias.Columns.Clear();

            DGVFamilias.Columns.Add("Id", "Id");

            DGVFamilias.Columns.Add("Nombre", "Familia");

            DGVFamilias.Columns["Id"].Visible = false;

            DGVFamilias.AllowUserToAddRows = false;

            DGVFamilias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DGVFamilias.MultiSelect = false;
        }
        private void CargarFamilias()
        {
            DGVFamilias.Rows.Clear();

            foreach (FamiliaBE familia in familiaBLL.ObtenerFamilias())
            {
                DGVFamilias.Rows.Add(familia.Id, familia.Nombre);
            }

        }

        private void BTNnuevo_Click(object sender, EventArgs e)
        {
            
            FormNuevaFamilia frm =new FormNuevaFamilia();

            frm.ShowDialog();

            CargarFamilias();
        }

        

        private void BTNmodificar_Click(object sender, EventArgs e)
        {
             if (DGVFamilias.SelectedRows.Count == 0)
                return;

            int id =Convert.ToInt32( DGVFamilias.SelectedRows[0].Cells["Id"].Value);

            FormGestionarFamilia frm =new FormGestionarFamilia(/*id*/);

            frm.ShowDialog();

            CargarFamilias();
        }

        private void BTNeliminar_Click(object sender, EventArgs e)
        {
            if (DGVFamilias.SelectedRows.Count == 0)
                return;

            int id =Convert.ToInt32( DGVFamilias.SelectedRows[0].Cells["Id"].Value);

            DialogResult r = MessageBox.Show( "¿Eliminar familia?", "Confirmar", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                familiaBLL.EliminarFamilia(id);

                CargarFamilias();
            }
        }

        private void FormABMFamilias_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
    }
}
