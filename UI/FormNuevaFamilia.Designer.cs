namespace EduTech
{
    partial class FormNuevaFamilia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombreFamilia = new System.Windows.Forms.TextBox();
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.BTNcancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreFamilia
            // 
            this.txtNombreFamilia.Location = new System.Drawing.Point(76, 58);
            this.txtNombreFamilia.Name = "txtNombreFamilia";
            this.txtNombreFamilia.Size = new System.Drawing.Size(209, 20);
            this.txtNombreFamilia.TabIndex = 0;
            this.txtNombreFamilia.Text = "NOMBRE DE LA FAMILIA";
            this.txtNombreFamilia.Enter += new System.EventHandler(this.txtNombreFamilia_Enter);
            this.txtNombreFamilia.Leave += new System.EventHandler(this.txtNombreFamilia_Leave);
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.Location = new System.Drawing.Point(76, 99);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(95, 23);
            this.BTNGuardar.TabIndex = 1;
            this.BTNGuardar.Text = "GUARDAR";
            this.BTNGuardar.UseVisualStyleBackColor = true;
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // BTNcancelar
            // 
            this.BTNcancelar.Location = new System.Drawing.Point(190, 99);
            this.BTNcancelar.Name = "BTNcancelar";
            this.BTNcancelar.Size = new System.Drawing.Size(95, 23);
            this.BTNcancelar.TabIndex = 2;
            this.BTNcancelar.Text = "CANCELAR";
            this.BTNcancelar.UseVisualStyleBackColor = true;
            this.BTNcancelar.Click += new System.EventHandler(this.BTNcancelar_Click);
            // 
            // FormNuevaFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(360, 191);
            this.Controls.Add(this.BTNcancelar);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.txtNombreFamilia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNuevaFamilia";
            this.Text = "FormNuevaFamilia";
            this.Load += new System.EventHandler(this.FormNuevaFamilia_Load);
            this.Enter += new System.EventHandler(this.FormNuevaFamilia_Enter);
            this.Leave += new System.EventHandler(this.FormNuevaFamilia_Leave);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormNuevaFamilia_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreFamilia;
        private System.Windows.Forms.Button BTNGuardar;
        private System.Windows.Forms.Button BTNcancelar;
    }
}