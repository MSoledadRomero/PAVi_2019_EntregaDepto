namespace TP_Aplicaciones_Visuales.EstadisticasGraficas
{
    partial class frmEstadisticaPrestamoPorSocio
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
            this.dtPrestamoPorSocioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtPrestamoPorSocioTableAdapter = new TP_Aplicaciones_Visuales.EstadisticasGraficas.DatosEstadisticasGraficasTableAdapters.dtPrestamoPorSocioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatosEstadisticasGraficas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPrestamoPorSocioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetPrestamoPorSocio";
            reportDataSource1.Value = this.dtPrestamoPorSocioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_Aplicaciones_Visuales.EstadisticasGraficas.EstadisticaPrestamoPorSocioRDLC.rdl" +
    "c";
            this.reportViewer1.Location = new System.Drawing.Point(11, 33);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(556, 407);
            this.reportViewer1.TabIndex = 0;
            // 
            // DatosEstadisticasGraficas
            // 
            this.DatosEstadisticasGraficas.DataSetName = "DatosEstadisticasGraficas";
            this.DatosEstadisticasGraficas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtPrestamoPorSocioBindingSource
            // 
            this.dtPrestamoPorSocioBindingSource.DataMember = "dtPrestamoPorSocio";
            this.dtPrestamoPorSocioBindingSource.DataSource = this.DatosEstadisticasGraficas;
            // 
            // dtPrestamoPorSocioTableAdapter
            // 
            this.dtPrestamoPorSocioTableAdapter.ClearBeforeFill = true;
            // 
            // frmEstadisticaPrestamoPorSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 455);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmEstadisticaPrestamoPorSocio";
            this.Load += new System.EventHandler(this.frmEstadisticaPrestamoPorSocio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosEstadisticasGraficas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPrestamoPorSocioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtPrestamoPorSocioBindingSource;
        private DatosEstadisticasGraficas DatosEstadisticasGraficas;
        private DatosEstadisticasGraficasTableAdapters.dtPrestamoPorSocioTableAdapter dtPrestamoPorSocioTableAdapter;
    }
}