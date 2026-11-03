namespace UI
{
    partial class FormNuevoAlumno
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
            this.lbl_legajo = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.btn_alta_alumno = new System.Windows.Forms.Button();
            this.btn_modificar_usuario = new System.Windows.Forms.Button();
            this.panelTituloAlumno = new System.Windows.Forms.Panel();
            this.btn_cerrar_alumno = new System.Windows.Forms.Button();
            this.lbl_titulo_alumno = new System.Windows.Forms.Label();
            this.panelTituloAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_legajo
            // 
            this.lbl_legajo.AutoSize = true;
            this.lbl_legajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_legajo.Location = new System.Drawing.Point(330, 111);
            this.lbl_legajo.Name = "lbl_legajo";
            this.lbl_legajo.Size = new System.Drawing.Size(45, 13);
            this.lbl_legajo.TabIndex = 0;
            this.lbl_legajo.Text = "Legajo";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(330, 156);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(50, 13);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.Location = new System.Drawing.Point(330, 203);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(52, 13);
            this.lbl_apellido.TabIndex = 2;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dni.Location = new System.Drawing.Point(330, 247);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(29, 13);
            this.lbl_dni.TabIndex = 3;
            this.lbl_dni.Text = "DNI";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(424, 108);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(170, 20);
            this.txtLegajo.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(424, 153);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(170, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(424, 200);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(170, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(424, 244);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(170, 20);
            this.txtDNI.TabIndex = 7;
            // 
            // btn_alta_alumno
            // 
            this.btn_alta_alumno.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_alta_alumno.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_alta_alumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alta_alumno.Location = new System.Drawing.Point(333, 309);
            this.btn_alta_alumno.Name = "btn_alta_alumno";
            this.btn_alta_alumno.Size = new System.Drawing.Size(119, 28);
            this.btn_alta_alumno.TabIndex = 8;
            this.btn_alta_alumno.Text = "Agregar Usuario";
            this.btn_alta_alumno.UseVisualStyleBackColor = true;
            this.btn_alta_alumno.Click += new System.EventHandler(this.btn_alta_alumno_Click);
            // 
            // btn_modificar_usuario
            // 
            this.btn_modificar_usuario.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_modificar_usuario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_modificar_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar_usuario.Location = new System.Drawing.Point(475, 309);
            this.btn_modificar_usuario.Name = "btn_modificar_usuario";
            this.btn_modificar_usuario.Size = new System.Drawing.Size(119, 28);
            this.btn_modificar_usuario.TabIndex = 9;
            this.btn_modificar_usuario.Text = "Modificar Usuario";
            this.btn_modificar_usuario.UseVisualStyleBackColor = true;
            this.btn_modificar_usuario.Click += new System.EventHandler(this.btn_modificar_usuario_Click);
            // 
            // panelTituloAlumno
            // 
            this.panelTituloAlumno.BackColor = System.Drawing.Color.DarkGray;
            this.panelTituloAlumno.Controls.Add(this.btn_cerrar_alumno);
            this.panelTituloAlumno.Controls.Add(this.lbl_titulo_alumno);
            this.panelTituloAlumno.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloAlumno.Location = new System.Drawing.Point(0, 0);
            this.panelTituloAlumno.Name = "panelTituloAlumno";
            this.panelTituloAlumno.Size = new System.Drawing.Size(962, 35);
            this.panelTituloAlumno.TabIndex = 10;
            // 
            // btn_cerrar_alumno
            // 
            this.btn_cerrar_alumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar_alumno.BackColor = System.Drawing.Color.DarkGray;
            this.btn_cerrar_alumno.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_cerrar_alumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_alumno.Location = new System.Drawing.Point(921, 6);
            this.btn_cerrar_alumno.Name = "btn_cerrar_alumno";
            this.btn_cerrar_alumno.Size = new System.Drawing.Size(29, 23);
            this.btn_cerrar_alumno.TabIndex = 1;
            this.btn_cerrar_alumno.Text = "X";
            this.btn_cerrar_alumno.UseVisualStyleBackColor = false;
            // 
            // lbl_titulo_alumno
            // 
            this.lbl_titulo_alumno.AutoSize = true;
            this.lbl_titulo_alumno.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo_alumno.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_alumno.Location = new System.Drawing.Point(397, 5);
            this.lbl_titulo_alumno.Name = "lbl_titulo_alumno";
            this.lbl_titulo_alumno.Size = new System.Drawing.Size(176, 25);
            this.lbl_titulo_alumno.TabIndex = 0;
            this.lbl_titulo_alumno.Text = "Nuevos Alumnos";
            // 
            // FormNuevoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(962, 429);
            this.Controls.Add(this.panelTituloAlumno);
            this.Controls.Add(this.btn_modificar_usuario);
            this.Controls.Add(this.btn_alta_alumno);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_legajo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNuevoAlumno";
            this.Text = "Nuevos Alumnos";
            this.Load += new System.EventHandler(this.FormNuevoAlumno_Load);
            this.panelTituloAlumno.ResumeLayout(false);
            this.panelTituloAlumno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_legajo;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button btn_alta_alumno;
        private System.Windows.Forms.Button btn_modificar_usuario;
        private System.Windows.Forms.Panel panelTituloAlumno;
        private System.Windows.Forms.Label lbl_titulo_alumno;
        private System.Windows.Forms.Button btn_cerrar_alumno;
    }
}
