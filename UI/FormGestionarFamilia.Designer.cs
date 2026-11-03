namespace EduTech
{
    partial class FormGestionarFamilia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionarFamilia));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.DGVPermisos = new System.Windows.Forms.DataGridView();
            this.CMBNombreFamilia = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(244, 274);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(178, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(46, 274);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(178, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // DGVPermisos
            // 
            this.DGVPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPermisos.Location = new System.Drawing.Point(50, 63);
            this.DGVPermisos.Name = "DGVPermisos";
            this.DGVPermisos.Size = new System.Drawing.Size(372, 197);
            this.DGVPermisos.TabIndex = 4;
            this.DGVPermisos.SelectionChanged += new System.EventHandler(this.DGVPermisos_SelectionChanged);
            // 
            // CMBNombreFamilia
            // 
            this.CMBNombreFamilia.FormattingEnabled = true;
            this.CMBNombreFamilia.Location = new System.Drawing.Point(50, 23);
            this.CMBNombreFamilia.Name = "CMBNombreFamilia";
            this.CMBNombreFamilia.Size = new System.Drawing.Size(174, 21);
            this.CMBNombreFamilia.TabIndex = 5;
            this.CMBNombreFamilia.SelectedIndexChanged += new System.EventHandler(this.CMBNombreFamilia_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(435, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormGestionarFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(467, 338);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CMBNombreFamilia);
            this.Controls.Add(this.DGVPermisos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionarFamilia";
            this.Text = "FormGestionarFamilia";
            this.Load += new System.EventHandler(this.FormGestionarFamilia_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormGestionarFamilia_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView DGVPermisos;
        private System.Windows.Forms.ComboBox CMBNombreFamilia;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}