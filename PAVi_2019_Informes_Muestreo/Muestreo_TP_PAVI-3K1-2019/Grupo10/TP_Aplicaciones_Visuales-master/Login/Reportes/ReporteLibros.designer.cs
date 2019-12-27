
namespace TP_Aplicaciones_Visuales.Reportes
{
    partial class ReporteLibros
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
            this.DataTableLibrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosLibros = new TP_Aplicaciones_Visuales.Reportes.DatosLibros();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTableLibrosTableAdapter = new TP_Aplicaciones_Visuales.Reportes.DatosLibrosTableAdapters.DataTableLibrosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableLibrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTableLibrosBindingSource
            // 
            this.DataTableLibrosBindingSource.DataMember = "DataTableLibros";
            this.DataTableLibrosBindingSource.DataSource = this.DatosLibros;
            // 
            // DatosLibros
            // 
            this.DatosLibros.DataSetName = "DatosLibros";
            this.DatosLibros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ConjuntoDeDatosLibro";
            reportDataSource1.Value = this.DataTableLibrosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_Aplicaciones_Visuales.Reportes.InformeLibros.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(8, 39);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(732, 296);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataTableLibrosTableAdapter
            // 
            this.DataTableLibrosTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 349);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteLibros";
            this.Load += new System.EventHandler(this.ReporteLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTableLibrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTableLibrosBindingSource;
        private DatosLibros DatosLibros;
        private DatosLibrosTableAdapters.DataTableLibrosTableAdapter DataTableLibrosTableAdapter;
    }
}