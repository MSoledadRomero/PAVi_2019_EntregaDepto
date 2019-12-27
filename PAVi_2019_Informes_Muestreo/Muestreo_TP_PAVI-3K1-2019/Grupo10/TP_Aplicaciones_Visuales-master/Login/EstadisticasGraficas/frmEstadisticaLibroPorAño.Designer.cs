namespace TP_Aplicaciones_Visuales.EstadisticasGraficas
{
    partial class frmEstadisticaLibroPorAño
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
            this.dtLibroPorAñoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtLibroPorAñoTableAdapter = new TP_Aplicaciones_Visuales.EstadisticasGraficas.DatosEstadisticasGraficasTableAdapters.dtLibroPorAñoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatosEstadisticasGraficas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLibroPorAñoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetLibrosPorAño";
            reportDataSource1.Value = this.dtLibroPorAñoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_Aplicaciones_Visuales.EstadisticasGraficas.EstadisticaLibrosPorAñoRDLC.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(19, 41);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(603, 391);
            this.reportViewer1.TabIndex = 0;
            // 
            // DatosEstadisticasGraficas
            // 
            this.DatosEstadisticasGraficas.DataSetName = "DatosEstadisticasGraficas";
            this.DatosEstadisticasGraficas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtLibroPorAñoBindingSource
            // 
            this.dtLibroPorAñoBindingSource.DataMember = "dtLibroPorAño";
            this.dtLibroPorAñoBindingSource.DataSource = this.DatosEstadisticasGraficas;
            // 
            // dtLibroPorAñoTableAdapter
            // 
            this.dtLibroPorAñoTableAdapter.ClearBeforeFill = true;
            // 
            // frmEstadisticaLibroPorAño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmEstadisticaLibroPorAño";
            this.Load += new System.EventHandler(this.frmEstadisticaLibroPorAño_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosEstadisticasGraficas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLibroPorAñoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtLibroPorAñoBindingSource;
        private DatosEstadisticasGraficas DatosEstadisticasGraficas;
        private DatosEstadisticasGraficasTableAdapters.dtLibroPorAñoTableAdapter dtLibroPorAñoTableAdapter;
    }
}