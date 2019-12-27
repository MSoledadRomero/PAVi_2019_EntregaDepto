namespace TP_Aplicaciones_Visuales.EstadisticasGraficas
{
    partial class frmEstadisticaPrestamoPorLibro
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DatosEstadisticasGraficas = new TP_Aplicaciones_Visuales.EstadisticasGraficas.DatosEstadisticasGraficas();
            this.dtPrestamoPorLibroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtPrestamoPorLibroTableAdapter = new TP_Aplicaciones_Visuales.EstadisticasGraficas.DatosEstadisticasGraficasTableAdapters.dtPrestamoPorLibroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatosEstadisticasGraficas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPrestamoPorLibroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetPrestamoPorLibro";
            reportDataSource1.Value = this.dtPrestamoPorLibroBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_Aplicaciones_Visuales.EstadisticasGraficas.EstadisticaPrestamoPorLibroRDLC.rdl" +
    "c";
            this.reportViewer1.Location = new System.Drawing.Point(17, 55);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(756, 373);
            this.reportViewer1.TabIndex = 0;
            // 
            // DatosEstadisticasGraficas
            // 
            this.DatosEstadisticasGraficas.DataSetName = "DatosEstadisticasGraficas";
            this.DatosEstadisticasGraficas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtPrestamoPorLibroBindingSource
            // 
            this.dtPrestamoPorLibroBindingSource.DataMember = "dtPrestamoPorLibro";
            this.dtPrestamoPorLibroBindingSource.DataSource = this.DatosEstadisticasGraficas;
            // 
            // dtPrestamoPorLibroTableAdapter
            // 
            this.dtPrestamoPorLibroTableAdapter.ClearBeforeFill = true;
            // 
            // frmEstadisticaPrestamoPorLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmEstadisticaPrestamoPorLibro";
            this.Load += new System.EventHandler(this.frmEstadisticaPrestamoPorLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosEstadisticasGraficas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPrestamoPorLibroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtPrestamoPorLibroBindingSource;
        private DatosEstadisticasGraficas DatosEstadisticasGraficas;
        private DatosEstadisticasGraficasTableAdapters.dtPrestamoPorLibroTableAdapter dtPrestamoPorLibroTableAdapter;
    }
}