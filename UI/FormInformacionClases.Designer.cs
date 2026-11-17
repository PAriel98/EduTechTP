namespace UI
{
    partial class FormInformacionClases
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
            this.dgvInscripciones = new System.Windows.Forms.DataGridView();
            this.dgvNotificaciones = new System.Windows.Forms.DataGridView();
            this.lblInscripcion = new System.Windows.Forms.Label();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrarNota = new UI.UserControls.BotonAnimado();
            this.txtNotaExamen = new UI.UserControls.TextBoxValidado();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInscripciones
            // 
            this.dgvInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscripciones.Location = new System.Drawing.Point(8, 43);
            this.dgvInscripciones.Name = "dgvInscripciones";
            this.dgvInscripciones.Size = new System.Drawing.Size(395, 201);
            this.dgvInscripciones.TabIndex = 0;
            this.dgvInscripciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInscripciones_CellClick);
            // 
            // dgvNotificaciones
            // 
            this.dgvNotificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotificaciones.Location = new System.Drawing.Point(409, 43);
            this.dgvNotificaciones.Name = "dgvNotificaciones";
            this.dgvNotificaciones.Size = new System.Drawing.Size(390, 201);
            this.dgvNotificaciones.TabIndex = 1;
            // 
            // lblInscripcion
            // 
            this.lblInscripcion.AutoSize = true;
            this.lblInscripcion.Location = new System.Drawing.Point(70, 316);
            this.lblInscripcion.Name = "lblInscripcion";
            this.lblInscripcion.Size = new System.Drawing.Size(135, 13);
            this.lblInscripcion.TabIndex = 2;
            this.lblInscripcion.Text = "Inscripocion Seleccionada:";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(391, 415);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 5;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nota:";
            // 
            // btnRegistrarNota
            // 
            this.btnRegistrarNota.BackColor = System.Drawing.Color.Green;
            this.btnRegistrarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarNota.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarNota.Location = new System.Drawing.Point(310, 415);
            this.btnRegistrarNota.Name = "btnRegistrarNota";
            this.btnRegistrarNota.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarNota.TabIndex = 4;
            this.btnRegistrarNota.Text = "Registrar Nota";
            this.btnRegistrarNota.UseVisualStyleBackColor = false;
            this.btnRegistrarNota.Click += new System.EventHandler(this.btnRegistrarNota_Click);
            // 
            // txtNotaExamen
            // 
            this.txtNotaExamen.BackColor = System.Drawing.Color.LightPink;
            this.txtNotaExamen.Location = new System.Drawing.Point(109, 363);
            this.txtNotaExamen.Name = "txtNotaExamen";
            this.txtNotaExamen.PatronRegex = "^[a-zA-Z\\\\s]+$";
            this.txtNotaExamen.Size = new System.Drawing.Size(100, 20);
            this.txtNotaExamen.TabIndex = 3;
            // 
            // FormInformacionClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnRegistrarNota);
            this.Controls.Add(this.txtNotaExamen);
            this.Controls.Add(this.lblInscripcion);
            this.Controls.Add(this.dgvNotificaciones);
            this.Controls.Add(this.dgvInscripciones);
            this.Name = "FormInformacionClases";
            this.Text = "FormInformacionClases";
            this.Load += new System.EventHandler(this.FormInformacionClases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInscripciones;
        private System.Windows.Forms.DataGridView dgvNotificaciones;
        private System.Windows.Forms.Label lblInscripcion;
        private UserControls.TextBoxValidado txtNotaExamen;
        private UserControls.BotonAnimado btnRegistrarNota;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Label label2;
    }
}