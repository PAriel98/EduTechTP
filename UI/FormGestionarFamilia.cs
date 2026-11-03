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
    public partial class FormGestionarFamilia : FormTraducible
    {
        //private int _idFamilia;
        private FamiliaBLL familiaBLL;

        private List<FamiliaBE> listaFamilias;

        private List<PermisosBE> listaPermisos;
        public FormGestionarFamilia(/*int idFamilia*/)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //idFamilia = idFamilia;
        }

        private void FormGestionarFamilia_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            familiaBLL = new FamiliaBLL();

            ConfigurarDGV();

            CargarFamilias();
        }

        private void CargarFamilias()
        {
            listaFamilias =familiaBLL.ObtenerFamilias();

            CMBNombreFamilia.DataSource = null;

            CMBNombreFamilia.DataSource =listaFamilias;

            CMBNombreFamilia.DisplayMember ="Nombre";

            CMBNombreFamilia.ValueMember ="Id";
        }
        private void ConfigurarDGV()
        {
            DGVPermisos.Columns.Clear();

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();

            chk.Name = "Seleccionado";
            chk.HeaderText = "";

            DGVPermisos.Columns.Add(chk);

            DGVPermisos.Columns.Add( "Id", "Id");

            DGVPermisos.Columns.Add( "Nombre", "Permiso");
            DGVPermisos.Columns["Id"].Visible = false;

            DGVPermisos.AllowUserToAddRows = false;

            DGVPermisos.AllowUserToDeleteRows = false;
            DGVPermisos.ReadOnly = false;

            DGVPermisos.SelectionMode =DataGridViewSelectionMode.FullRowSelect;
        }

        private void DGVPermisos_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void CMBNombreFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMBNombreFamilia.SelectedItem == null)
                return;

            FamiliaBE familia =(FamiliaBE)CMBNombreFamilia.SelectedItem;

            CargarPermisosFamilia(familia);
        }
        private void CargarPermisosFamilia(FamiliaBE familia)
        {
            DGVPermisos.Rows.Clear();

            listaPermisos =familiaBLL.ObtenerTodosLosPermisos();

            foreach (PermisosBE permiso in listaPermisos)
            {
                bool asignado = familia.Permisos.Any( p => p.Id ==permiso.Id);

                DGVPermisos.Rows.Add(asignado,permiso.Id,permiso.Nombre);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (CMBNombreFamilia.SelectedItem == null)
                return;

            FamiliaBE familia =(FamiliaBE) CMBNombreFamilia.SelectedItem;

            familia.Permisos.Clear();

            foreach (DataGridViewRow fila in DGVPermisos.Rows)
            {
                bool seleccionado =Convert.ToBoolean(fila.Cells["Seleccionado"].Value);

                if (seleccionado)
                {
                    int id =Convert.ToInt32( fila.Cells["Id"].Value);

                    PermisosBE permiso =listaPermisos.First(p => p.Id == id);

                    familia.Permisos.Add(permiso);
                }
            }

            familiaBLL.GuardarFamilia();

            MessageBox.Show("Permisos actualizados correctamente");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (CMBNombreFamilia.SelectedItem == null)
                return;
            this.Close();

            FamiliaBE familia =(FamiliaBE) CMBNombreFamilia.SelectedItem;

            CargarPermisosFamilia(familia);
        }

        private void FormGestionarFamilia_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
