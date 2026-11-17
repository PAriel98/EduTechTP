using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UI.UserControls
{
    public class TextBoxValidado : TextBox
    {
        public string PatronRegex { get; set; } = @"^[a-zA-Z\\s]+$";
        public bool EsValido() 
        { 
            if (string.IsNullOrWhiteSpace(this.Text) || !Regex.IsMatch(this.Text.Trim(), PatronRegex)) 
            { 
                this.BackColor = Color.LightPink;
                return false; 
            } 
            else 
            { this.BackColor = Color.White; 
                return true; 
            } 
        } 
        protected override void OnTextChanged(EventArgs e) 
        { 
            base.OnTextChanged(e); 
            EsValido(); 
        } 
    }
    }
