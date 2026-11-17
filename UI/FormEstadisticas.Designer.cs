namespace UI
{
    partial class FormEstadisticas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartEstadisticas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbFiltroReporte = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new UI.UserControls.BotonAnimado();
            this.dgvDatosEstadisticos = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartEstadisticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEstadisticos)).BeginInit();
            this.SuspendLayout();
            // 
            // chartEstadisticas
            // 
            chartArea2.Name = "ChartArea1";
            this.chartEstadisticas.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartEstadisticas.Legends.Add(legend2);
            this.chartEstadisticas.Location = new System.Drawing.Point(48, 73);
            this.chartEstadisticas.Name = "chartEstadisticas";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartEstadisticas.Series.Add(series2);
            this.chartEstadisticas.Size = new System.Drawing.Size(409, 312);
            this.chartEstadisticas.TabIndex = 0;
            this.chartEstadisticas.Text = "chart1";
            // 
            // cmbFiltroReporte
            // 
            this.cmbFiltroReporte.FormattingEnabled = true;
            this.cmbFiltroReporte.Items.AddRange(new object[] {
            "Inscriptos por Curso",
            "Promedio de Calificaciones por Curso",
            "Alumnos Aprobados vs. Reprobados"});
            this.cmbFiltroReporte.Location = new System.Drawing.Point(181, 464);
            this.cmbFiltroReporte.Name = "cmbFiltroReporte";
            this.cmbFiltroReporte.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltroReporte.TabIndex = 1;
            this.cmbFiltroReporte.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroReporte_SelectedIndexChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Green;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(345, 464);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(112, 23);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar Datos";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgvDatosEstadisticos
            // 
            this.dgvDatosEstadisticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosEstadisticos.Location = new System.Drawing.Point(567, 73);
            this.dgvDatosEstadisticos.Name = "dgvDatosEstadisticos";
            this.dgvDatosEstadisticos.Size = new System.Drawing.Size(503, 312);
            this.dgvDatosEstadisticos.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(178, 418);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(110, 13);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "REPORTE ACTUAL: ";
            // 
            // FormEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 576);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvDatosEstadisticos);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.cmbFiltroReporte);
            this.Controls.Add(this.chartEstadisticas);
            this.Name = "FormEstadisticas";
            this.Text = "FormEstadisticas";
            ((System.ComponentModel.ISupportInitialize)(this.chartEstadisticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEstadisticos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartEstadisticas;
        private System.Windows.Forms.ComboBox cmbFiltroReporte;
        private UserControls.BotonAnimado btnActualizar;
        private System.Windows.Forms.DataGridView dgvDatosEstadisticos;
        private System.Windows.Forms.Label lblTitulo;
    }
}