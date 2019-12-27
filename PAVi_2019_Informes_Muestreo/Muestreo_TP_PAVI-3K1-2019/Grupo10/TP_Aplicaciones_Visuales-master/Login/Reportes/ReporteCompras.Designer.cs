namespace TP_Aplicaciones_Visuales.Reportes
{
    partial class ReporteCompras
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
            this.DatosCompras = new TP_Aplicaciones_Visuales.Reportes.DatosCompras();
            this.dtCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtCompraTableAdapter = new TP_Aplicaciones_Visuales.Reportes.DatosComprasTableAdapters.dtCompraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatosCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetCompras";
            reportDataSource1.Value = this.dtCompraBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_Aplicaciones_Visuales.Reportes.InformeCompras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 45);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(679, 244);
            this.reportViewer1.TabIndex = 0;
            // 
            // DatosCompras
            // 
            this.DatosCompras.DataSetName = "DatosCompras";
            this.DatosCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtCompraBindingSource
            // 
            this.dtCompraBindingSource.DataMember = "dtCompra";
            this.dtCompraBindingSource.DataSource = this.DatosCompras;
            // 
            // dtCompraTableAdapter
            // 
            this.dtCompraTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 308);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteCompras";
            this.Load += new System.EventHandler(this.ReporteCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtCompraBindingSource;
        private DatosCompras DatosCompras;
        private DatosComprasTableAdapters.dtCompraTableAdapter dtCompraTableAdapter;
    }
}