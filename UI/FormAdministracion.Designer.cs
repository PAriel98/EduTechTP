namespace UI
{
    partial class FormAdministracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministracion));
            this.btnAbrirFamilias = new System.Windows.Forms.Button();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.panelMenuAdm = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMenuAdm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbrirFamilias
            // 
            this.btnAbrirFamilias.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirFamilias.Image")));
            this.btnAbrirFamilias.Location = new System.Drawing.Point(12, 12);
            this.btnAbrirFamilias.Name = "btnAbrirFamilias";
            this.btnAbrirFamilias.Size = new System.Drawing.Size(132, 26);
            this.btnAbrirFamilias.TabIndex = 1;
            this.btnAbrirFamilias.Text = "Familias";
            this.btnAbrirFamilias.UseVisualStyleBackColor = true;
            this.btnAbrirFamilias.Click += new System.EventHandler(this.btnAbrirFamilias_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.Beige;
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelContenedor.Location = new System.Drawing.Point(159, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(803, 450);
            this.PanelContenedor.TabIndex = 5;
            // 
            // panelMenuAdm
            // 
            this.panelMenuAdm.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelMenuAdm.Controls.Add(this.button1);
            this.panelMenuAdm.Controls.Add(this.btnAbrirFamilias);
            this.panelMenuAdm.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuAdm.Location = new System.Drawing.Point(0, 0);
            this.panelMenuAdm.Name = "panelMenuAdm";
            this.panelMenuAdm.Size = new System.Drawing.Size(163, 450);
            this.panelMenuAdm.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(30, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Menu Principal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 450);
            this.Controls.Add(this.panelMenuAdm);
            this.Controls.Add(this.PanelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdministracion";
            this.Text = "FormAdministracion";
            this.panelMenuAdm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirFamilias;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Panel panelMenuAdm;
        private System.Windows.Forms.Button button1;
    }
}