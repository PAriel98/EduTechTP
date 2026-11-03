namespace EduTech
{
    partial class FormABMFamilias
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
            this.DGVFamilias = new System.Windows.Forms.DataGridView();
            this.BTNnuevo = new System.Windows.Forms.Button();
            this.BTNmodificar = new System.Windows.Forms.Button();
            this.BTNeliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFamilias)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVFamilias
            // 
            this.DGVFamilias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFamilias.Location = new System.Drawing.Point(124, 67);
            this.DGVFamilias.Name = "DGVFamilias";
            this.DGVFamilias.Size = new System.Drawing.Size(514, 261);
            this.DGVFamilias.TabIndex = 0;
            // 
            // BTNnuevo
            // 
            this.BTNnuevo.Location = new System.Drawing.Point(124, 344);
            this.BTNnuevo.Name = "BTNnuevo";
            this.BTNnuevo.Size = new System.Drawing.Size(162, 23);
            this.BTNnuevo.TabIndex = 1;
            this.BTNnuevo.Text = "AÑADIR FAMILIA";
            this.BTNnuevo.UseVisualStyleBackColor = true;
            this.BTNnuevo.Click += new System.EventHandler(this.BTNnuevo_Click);
            // 
            // BTNmodificar
            // 
            this.BTNmodificar.Location = new System.Drawing.Point(301, 344);
            this.BTNmodificar.Name = "BTNmodificar";
            this.BTNmodificar.Size = new System.Drawing.Size(162, 23);
            this.BTNmodificar.TabIndex = 2;
            this.BTNmodificar.Text = "MODIFICAR FAMILIA";
            this.BTNmodificar.UseVisualStyleBackColor = true;
            this.BTNmodificar.Click += new System.EventHandler(this.BTNmodificar_Click);
            // 
            // BTNeliminar
            // 
            this.BTNeliminar.Location = new System.Drawing.Point(476, 344);
            this.BTNeliminar.Name = "BTNeliminar";
            this.BTNeliminar.Size = new System.Drawing.Size(162, 23);
            this.BTNeliminar.TabIndex = 3;
            this.BTNeliminar.Text = "ELIMINAR FAMILIA";
            this.BTNeliminar.UseVisualStyleBackColor = true;
            this.BTNeliminar.Click += new System.EventHandler(this.BTNeliminar_Click);
            // 
            // FormABMFamilias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNeliminar);
            this.Controls.Add(this.BTNmodificar);
            this.Controls.Add(this.BTNnuevo);
            this.Controls.Add(this.DGVFamilias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormABMFamilias";
            this.Text = "FormABMFamilias";
            this.Load += new System.EventHandler(this.FormABMFamilias_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormABMFamilias_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.DGVFamilias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVFamilias;
        private System.Windows.Forms.Button BTNnuevo;
        private System.Windows.Forms.Button BTNmodificar;
        private System.Windows.Forms.Button BTNeliminar;
    }
}