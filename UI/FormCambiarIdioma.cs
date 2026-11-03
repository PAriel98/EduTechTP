using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EduTech;
using EduTech.Observer;

namespace UI
{
    public partial class FormCambiarIdioma : FormTraducible
    {
        public FormCambiarIdioma()
        {
            InitializeComponent();
            cmb_idioma.DataSource = Idioma.ObtenerNombres();
            btn_cambiar_idioma.Click += btn_cambiar_idioma_Click;
            btn_cerrar_idioma.Click += btn_cerrar_idioma_Click;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            MostrarIdiomaActual();
        }

        public override void ActualizarIdioma(Idioma idioma)
        {
            base.ActualizarIdioma(idioma);
            MostrarIdiomaActual();
        }

        private void btn_cambiar_idioma_Click(object sender, EventArgs e)
        {
            string nombreIdioma = cmb_idioma.SelectedItem.ToString();
            Idioma idioma = Idioma.CrearPorNombre(nombreIdioma);
            SessionManager.GetInstancia().CambiarIdioma(idioma);
            MostrarIdiomaActual();
        }

        private void MostrarIdiomaActual()
        {
            Idioma idioma = SessionManager.GetInstancia().IdiomaActual;

            if (idioma != null)
            {
                txt_idioma_actual.Text = idioma.Nombre;
                cmb_idioma.SelectedItem = idioma.Nombre;
            }
        }

        private void btn_cerrar_idioma_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
