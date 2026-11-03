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
    public partial class FormNuevaFamilia : FormTraducible
    {
        private FamiliaBLL familiaBLL =new FamiliaBLL();
        public FormNuevaFamilia()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            FamiliaBE familia =new FamiliaBE();

            familia.Id = Guid.NewGuid().GetHashCode();

            familia.Nombre =txtNombreFamilia.Text;

            familiaBLL.CrearFamilia(familia);

            MessageBox.Show("Familia creada correctamente");

            Close();

        }

        private void FormNuevaFamilia_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormNuevaFamilia_Enter(object sender, EventArgs e)
        {
            
        }

        private void FormNuevaFamilia_Leave(object sender, EventArgs e)
        {
            
        }

        private void FormNuevaFamilia_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BTNcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtNombreFamilia_Enter(object sender, EventArgs e)
        {
            if (txtNombreFamilia.Text == "NOMBRE DE LA FAMILIA")
            {
                txtNombreFamilia.Text = "";
                txtNombreFamilia.ForeColor = Color.BlueViolet;
            }
        }

        private void txtNombreFamilia_Leave(object sender, EventArgs e)
        {
            if (txtNombreFamilia.Text == "")
            {
                txtNombreFamilia.Text = "NOMBRE DE LA FAMILIA";
                txtNombreFamilia.ForeColor = Color.DimGray;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
