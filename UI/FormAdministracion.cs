using EduTech;
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
    public partial class FormAdministracion : FormTraducible
    {
        public FormAdministracion()
        {
            InitializeComponent();
        }
        private void AbrirFormEnPanel(object FormHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)

                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();

        } 

        private void btnAbrirFamilias_Click(object sender, EventArgs e)
        {
            
            AbrirFormEnPanel(new FormABMFamilias());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            

        }
    }
}
