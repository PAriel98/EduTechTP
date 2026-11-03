using EduTech;
using EduTech.Observer;
using System;
using System.Windows.Forms;

namespace UI
{
    public class FormTraducible : Form, IObservadorIdioma
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            SessionManager.GetInstancia().SuscribirObservadorIdioma(this);
            ActualizarIdioma(SessionManager.GetInstancia().IdiomaActual);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                SessionManager.GetInstancia().DesuscribirObservadorIdioma(this);
            }

            base.Dispose(disposing);
        }

        public virtual void ActualizarIdioma(Idioma idioma)
        {
            if (idioma == null)
            {
                return;
            }

            TraducirFormulario(idioma);
        }

        private void TraducirFormulario(Idioma idioma)
        {
            AplicarTexto(this, idioma);
            TraducirControles(Controls, idioma);
        }

        private void TraducirControles(Control.ControlCollection controles, Idioma idioma)
        {
            foreach (Control control in controles)
            {
                AplicarTexto(control, idioma);

                MenuStrip menu = control as MenuStrip;
                if (menu != null)
                {
                    TraducirMenu(menu.Items, idioma);
                }

                if (control.HasChildren)
                {
                    TraducirControles(control.Controls, idioma);
                }
            }
        }

        private void TraducirMenu(ToolStripItemCollection items, Idioma idioma)
        {
            foreach (ToolStripItem item in items)
            {
                string texto = idioma.Traducir(item.Name);

                if (!string.IsNullOrEmpty(texto))
                {
                    item.Text = texto;
                }

                ToolStripMenuItem menuItem = item as ToolStripMenuItem;
                if (menuItem != null && menuItem.DropDownItems.Count > 0)
                {
                    TraducirMenu(menuItem.DropDownItems, idioma);
                }
            }
        }

        private void AplicarTexto(Control control, Idioma idioma)
        {
            if (!(control is Label) && !(control is Button) && !(control is Form))
            {
                return;
            }

            string texto = idioma.Traducir(control.Name);

            if (!string.IsNullOrEmpty(texto))
            {
                control.Text = texto;
            }
        }
    }
}
