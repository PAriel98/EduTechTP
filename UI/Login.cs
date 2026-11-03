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
    public partial class Login : Form                      
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.White;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.White;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.White;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.White;
                txtpass.UseSystemPasswordChar = false;
            }
        }       

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                string usuarioIngresado = txtuser.Text;
                string claveIngresada = txtpass.Text;
                UsuarioBLL usuariobll = new UsuarioBLL();
                var usuario = usuariobll.Login(usuarioIngresado,claveIngresada);

                if (usuario != null)
                {
                    FormMDI menu = new FormMDI(usuario);
                    this.Hide();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o clave incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                // FormMDI mdi = new FormMDI(usuarioValido);
                // this.Hide();
                // mdi.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {           
          
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("admin;admin");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
