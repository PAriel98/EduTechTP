namespace UI
{
    partial class FormNuevoCurso
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
            this.panelTituloAlumno = new System.Windows.Forms.Panel();
            this.btn_cerrar_alumno = new System.Windows.Forms.Button();
            this.lbl_titulo_alumno = new System.Windows.Forms.Label();
            this.btn_modificar_usuario = new System.Windows.Forms.Button();
            this.btn_alta_curso = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.chkEsProgramaCompleto = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelTituloAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTituloAlumno
            // 
            this.panelTituloAlumno.BackColor = System.Drawing.Color.DarkGray;
            this.panelTituloAlumno.Controls.Add(this.btn_cerrar_alumno);
            this.panelTituloAlumno.Controls.Add(this.lbl_titulo_alumno);
            this.panelTituloAlumno.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloAlumno.Location = new System.Drawing.Point(0, 0);
            this.panelTituloAlumno.Name = "panelTituloAlumno";
            this.panelTituloAlumno.Size = new System.Drawing.Size(800, 35);
            this.panelTituloAlumno.TabIndex = 11;
            // 
            // btn_cerrar_alumno
            // 
            this.btn_cerrar_alumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar_alumno.BackColor = System.Drawing.Color.DarkGray;
            this.btn_cerrar_alumno.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_cerrar_alumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_alumno.Location = new System.Drawing.Point(759, 6);
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
            this.lbl_titulo_alumno.Location = new System.Drawing.Point(324, 6);
            this.lbl_titulo_alumno.Name = "lbl_titulo_alumno";
            this.lbl_titulo_alumno.Size = new System.Drawing.Size(134, 25);
            this.lbl_titulo_alumno.TabIndex = 0;
            this.lbl_titulo_alumno.Text = "Nuevo Curso";
            this.lbl_titulo_alumno.Click += new System.EventHandler(this.lbl_titulo_alumno_Click);
            // 
            // btn_modificar_usuario
            // 
            this.btn_modificar_usuario.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_modificar_usuario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_modificar_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar_usuario.Location = new System.Drawing.Point(160, 241);
            this.btn_modificar_usuario.Name = "btn_modificar_usuario";
            this.btn_modificar_usuario.Size = new System.Drawing.Size(119, 28);
            this.btn_modificar_usuario.TabIndex = 21;
            this.btn_modificar_usuario.Text = "Modificar Curso";
            this.btn_modificar_usuario.UseVisualStyleBackColor = true;
            this.btn_modificar_usuario.Click += new System.EventHandler(this.btn_modificar_usuario_Click);
            // 
            // btn_alta_curso
            // 
            this.btn_alta_curso.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_alta_curso.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_alta_curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alta_curso.Location = new System.Drawing.Point(18, 241);
            this.btn_alta_curso.Name = "btn_alta_curso";
            this.btn_alta_curso.Size = new System.Drawing.Size(119, 28);
            this.btn_alta_curso.TabIndex = 20;
            this.btn_alta_curso.Text = "Agregar Curso";
            this.btn_alta_curso.UseVisualStyleBackColor = true;
            this.btn_alta_curso.Click += new System.EventHandler(this.btn_alta_curso_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(109, 132);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(170, 20);
            this.txtPrecio.TabIndex = 18;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(109, 106);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(170, 20);
            this.txtNombre.TabIndex = 17;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.Location = new System.Drawing.Point(15, 135);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(43, 13);
            this.lbl_apellido.TabIndex = 14;
            this.lbl_apellido.Text = "Precio";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(15, 109);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(50, 13);
            this.lbl_nombre.TabIndex = 13;
            this.lbl_nombre.Text = "Nombre";
            // 
            // dgvCursos
            // 
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvCursos.Location = new System.Drawing.Point(319, 35);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.Size = new System.Drawing.Size(481, 415);
            this.dgvCursos.TabIndex = 22;
            this.dgvCursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursos_CellClick);
            // 
            // chkEsProgramaCompleto
            // 
            this.chkEsProgramaCompleto.AutoSize = true;
            this.chkEsProgramaCompleto.Location = new System.Drawing.Point(54, 191);
            this.chkEsProgramaCompleto.Name = "chkEsProgramaCompleto";
            this.chkEsProgramaCompleto.Size = new System.Drawing.Size(206, 17);
            this.chkEsProgramaCompleto.TabIndex = 23;
            this.chkEsProgramaCompleto.Text = "Es Diplomatura / Programa Completo?";
            this.chkEsProgramaCompleto.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Reiniciar Campos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormNuevoCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkEsProgramaCompleto);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.btn_modificar_usuario);
            this.Controls.Add(this.btn_alta_curso);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.panelTituloAlumno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNuevoCurso";
            this.Text = "FormNuevoCurso";
            this.Load += new System.EventHandler(this.FormNuevoCurso_Load);
            this.panelTituloAlumno.ResumeLayout(false);
            this.panelTituloAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTituloAlumno;
        private System.Windows.Forms.Button btn_cerrar_alumno;
        private System.Windows.Forms.Label lbl_titulo_alumno;
        private System.Windows.Forms.Button btn_modificar_usuario;
        private System.Windows.Forms.Button btn_alta_curso;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.CheckBox chkEsProgramaCompleto;
        private System.Windows.Forms.Button button1;
    }
}