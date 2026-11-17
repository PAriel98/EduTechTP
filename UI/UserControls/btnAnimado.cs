using System;
using System.Drawing;
using System.Windows.Forms;
namespace UI.UserControls 
{ 
    public class BotonAnimado : Button 
    { 
        private Size tamanoOriginal;
        public BotonAnimado() 
        { 
            this.BackColor = Color.Green; 
            this.ForeColor = Color.White;
            this.FlatStyle = FlatStyle.Flat; 
        } 
        protected override void OnMouseEnter(EventArgs e) 
        { 
            base.OnMouseEnter(e); 
            tamanoOriginal = this.Size; 
            this.BackColor = Color.Red;
            this.Size = new Size(this.Width + 100, this.Height + 100); 
         } 
        protected override void OnMouseLeave(EventArgs e) 
        { 
            base.OnMouseLeave(e); 
            this.BackColor = Color.Green;
            if (tamanoOriginal != Size.Empty) 
            { 
                this.Size = tamanoOriginal;
            } 
        } 
    } 
}