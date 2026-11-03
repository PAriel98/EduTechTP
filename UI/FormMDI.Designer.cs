namespace UI
{
    partial class FormMDI
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMDI));
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.familiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupRestoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarIdiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionClasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalRecaudadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudacionPorClaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_edutech = new System.Windows.Forms.Label();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.PanelContenedor.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelContenedor.Controls.Add(this.menuStrip1);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 32);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(964, 453);
            this.PanelContenedor.TabIndex = 1;
            this.PanelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenedor_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem1,
            this.perfilesToolStripMenuItem,
            this.backupRestoreToolStripMenuItem,
            this.bitacoraToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // usuarioToolStripMenuItem1
            // 
            this.usuarioToolStripMenuItem1.Name = "usuarioToolStripMenuItem1";
            this.usuarioToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.usuarioToolStripMenuItem1.Text = "Usuarios";
            // 
            // perfilesToolStripMenuItem
            // 
            this.perfilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesToolStripMenuItem,
            this.familiasToolStripMenuItem});
            this.perfilesToolStripMenuItem.Name = "perfilesToolStripMenuItem";
            this.perfilesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.perfilesToolStripMenuItem.Text = "Perfiles";
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.rolesToolStripMenuItem.Text = "Roles";
            // 
            // familiasToolStripMenuItem
            // 
            this.familiasToolStripMenuItem.Name = "familiasToolStripMenuItem";
            this.familiasToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.familiasToolStripMenuItem.Text = "Familias";
            // 
            // backupRestoreToolStripMenuItem
            // 
            this.backupRestoreToolStripMenuItem.Name = "backupRestoreToolStripMenuItem";
            this.backupRestoreToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.backupRestoreToolStripMenuItem.Text = "Backup/Restore";
            // 
            // bitacoraToolStripMenuItem
            // 
            this.bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            this.bitacoraToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.bitacoraToolStripMenuItem.Text = "Bitacora";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reLoginToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem,
            this.cambiarIdiomaToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // reLoginToolStripMenuItem
            // 
            this.reLoginToolStripMenuItem.Name = "reLoginToolStripMenuItem";
            this.reLoginToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.reLoginToolStripMenuItem.Text = "Re-Login";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            // 
            // cambiarIdiomaToolStripMenuItem
            // 
            this.cambiarIdiomaToolStripMenuItem.Name = "cambiarIdiomaToolStripMenuItem";
            this.cambiarIdiomaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cambiarIdiomaToolStripMenuItem.Text = "Cambiar Idioma";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionClasesToolStripMenuItem,
            this.agregarClaseToolStripMenuItem,
            this.agregarAlumnoToolStripMenuItem,
            this.agregarDocenteToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.comprasToolStripMenuItem.Text = "Clases";
            // 
            // informacionClasesToolStripMenuItem
            // 
            this.informacionClasesToolStripMenuItem.Name = "informacionClasesToolStripMenuItem";
            this.informacionClasesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.informacionClasesToolStripMenuItem.Text = "Informacion Clases";
            // 
            // agregarClaseToolStripMenuItem
            // 
            this.agregarClaseToolStripMenuItem.Name = "agregarClaseToolStripMenuItem";
            this.agregarClaseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarClaseToolStripMenuItem.Text = "Agregar Curso";
            this.agregarClaseToolStripMenuItem.Click += new System.EventHandler(this.agregarClaseToolStripMenuItem_Click);
            // 
            // agregarAlumnoToolStripMenuItem
            // 
            this.agregarAlumnoToolStripMenuItem.Name = "agregarAlumnoToolStripMenuItem";
            this.agregarAlumnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarAlumnoToolStripMenuItem.Text = "Agregar Alumno";
            this.agregarAlumnoToolStripMenuItem.Click += new System.EventHandler(this.agregarAlumnoToolStripMenuItem_Click);
            // 
            // agregarDocenteToolStripMenuItem
            // 
            this.agregarDocenteToolStripMenuItem.Name = "agregarDocenteToolStripMenuItem";
            this.agregarDocenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarDocenteToolStripMenuItem.Text = "Agregar Docente";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalRecaudadoToolStripMenuItem,
            this.recaudacionPorClaseToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.ventasToolStripMenuItem.Text = "Facturacion";
            // 
            // totalRecaudadoToolStripMenuItem
            // 
            this.totalRecaudadoToolStripMenuItem.Name = "totalRecaudadoToolStripMenuItem";
            this.totalRecaudadoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.totalRecaudadoToolStripMenuItem.Text = "Total Recaudado";
            // 
            // recaudacionPorClaseToolStripMenuItem
            // 
            this.recaudacionPorClaseToolStripMenuItem.Name = "recaudacionPorClaseToolStripMenuItem";
            this.recaudacionPorClaseToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.recaudacionPorClaseToolStripMenuItem.Text = "Recaudacion por Clase";
            // 
            // lbl_edutech
            // 
            this.lbl_edutech.AutoSize = true;
            this.lbl_edutech.BackColor = System.Drawing.Color.Transparent;
            this.lbl_edutech.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edutech.ForeColor = System.Drawing.Color.Black;
            this.lbl_edutech.Location = new System.Drawing.Point(425, 12);
            this.lbl_edutech.Name = "lbl_edutech";
            this.lbl_edutech.Size = new System.Drawing.Size(128, 25);
            this.lbl_edutech.TabIndex = 0;
            this.lbl_edutech.Text = "EDUTECH";
            this.lbl_edutech.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.DarkGray;
            this.PanelMenu.Controls.Add(this.label2);
            this.PanelMenu.Controls.Add(this.lbl_edutech);
            this.PanelMenu.Controls.Add(this.btncerrar);
            this.PanelMenu.Controls.Add(this.btnminimizar);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(964, 35);
            this.PanelMenu.TabIndex = 3;
            this.PanelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenu_Paint);
            this.PanelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelMenu_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(776, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ADMINISTRACION";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(931, 3);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(33, 16);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 37;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(896, 3);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(29, 16);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 38;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // FormMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(964, 485);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.PanelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMDI";
            this.Text = "EduTech";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMDI_MouseDown);
            this.PanelContenedor.ResumeLayout(false);
            this.PanelContenedor.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Label lbl_edutech;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem perfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem familiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupRestoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarIdiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarClaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalRecaudadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudacionPorClaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionClasesToolStripMenuItem;
    }
}

