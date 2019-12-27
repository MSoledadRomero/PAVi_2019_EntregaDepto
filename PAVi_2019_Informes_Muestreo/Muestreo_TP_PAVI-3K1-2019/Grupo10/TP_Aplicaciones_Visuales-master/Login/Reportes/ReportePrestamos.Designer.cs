namespace TP_Aplicaciones_Visuales.Reportes
{
    partial class ReportePrestamos
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
            this.DatosPrestamos = new TP_Aplicaciones_Visuales.Reportes.DatosPrestamos();
            this.dtPrestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtPrestamosTableAdapter = new TP_Aplicaciones_Visuales.Reportes.DatosPrestamosTableAdapters.dtPrestamosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatosPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPrestamosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetPrestamos";
            reportDataSource1.Value = this.dtPrestamosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_Aplicaciones_Visuales.Reportes.InformePrestamos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(9, 38);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(819, 349);
            this.reportViewer1.TabIndex = 0;
            // 
            // DatosPrestamos
            // 
            this.DatosPrestamos.DataSetName = "DatosPrestamos";
            this.DatosPrestamos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtPrestamosBindingSource
            // 
            this.dtPrestamosBindingSource.DataMember = "dtPrestamos";
            this.dtPrestamosBindingSource.DataSource = this.DatosPrestamos;
            // 
            // dtPrestamosTableAdapter
            // 
            this.dtPrestamosTableAdapter.ClearBeforeFill = true;
            // 
            // ReportePrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 401);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportePrestamos";
            this.Load += new System.EventHandler(this.ReportePrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPrestamosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtPrestamosBindingSource;
        private DatosPrestamos DatosPrestamos;
        private DatosPrestamosTableAdapters.dtPrestamosTableAdapter dtPrestamosTableAdapter;
    }
}