namespace TP_Aplicaciones_Visuales.Reportes
{
    partial class ReporteProveedores
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
            this.DatosProveedores = new TP_Aplicaciones_Visuales.Reportes.DatosProveedores();
            this.DataTableProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTableProveedoresTableAdapter = new TP_Aplicaciones_Visuales.Reportes.DatosProveedoresTableAdapters.DataTableProveedoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatosProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableProveedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetProveedores";
            reportDataSource1.Value = this.DataTableProveedoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_Aplicaciones_Visuales.Reportes.InformeProveedores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 40);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(715, 305);
            this.reportViewer1.TabIndex = 0;
            // 
            // DatosProveedores
            // 
            this.DatosProveedores.DataSetName = "DatosProveedores";
            this.DatosProveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTableProveedoresBindingSource
            // 
            this.DataTableProveedoresBindingSource.DataMember = "DataTableProveedores";
            this.DataTableProveedoresBindingSource.DataSource = this.DatosProveedores;
            // 
            // DataTableProveedoresTableAdapter
            // 
            this.DataTableProveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 368);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteProveedores";
            this.Load += new System.EventHandler(this.ReporteProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableProveedoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTableProveedoresBindingSource;
        private DatosProveedores DatosProveedores;
        private DatosProveedoresTableAdapters.DataTableProveedoresTableAdapter DataTableProveedoresTableAdapter;
    }
}