namespace TP_Aplicaciones_Visuales.ReporteConParametros
{
    partial class ReporteProveedoresParametrizado
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
            this.dtProveedoresParametrizadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosReportesConParametros = new TP_Aplicaciones_Visuales.ReporteConParametros.DatosReportesConParametros();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnLimpiar = new MetroFramework.Controls.MetroButton();
            this.btnConsultar = new MetroFramework.Controls.MetroButton();
            this.cboBarrio = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cboCiudad = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtProveedoresParametrizadosTableAdapter = new TP_Aplicaciones_Visuales.ReporteConParametros.DatosReportesConParametrosTableAdapters.dtProveedoresParametrizadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtProveedoresParametrizadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosReportesConParametros)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtProveedoresParametrizadosBindingSource
            // 
            this.dtProveedoresParametrizadosBindingSource.DataMember = "dtProveedoresParametrizados";
            this.dtProveedoresParametrizadosBindingSource.DataSource = this.DatosReportesConParametros;
            // 
            // DatosReportesConParametros
            // 
            this.DatosReportesConParametros.DataSetName = "DatosReportesConParametros";
            this.DatosReportesConParametros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(28, 93);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(141, 25);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Buscar con filtros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(169, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "ESTADISTICA DE PROVEEDORES";
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.Teal;
            this.txtTitulo.Location = new System.Drawing.Point(237, 23);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(220, 39);
            this.txtTitulo.TabIndex = 12;
            this.txtTitulo.Text = "BIBLIOTECA";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.btnLimpiar);
            this.metroPanel1.Controls.Add(this.btnConsultar);
            this.metroPanel1.Controls.Add(this.cboBarrio);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.cboCiudad);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(6, 115);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(729, 121);
            this.metroPanel1.TabIndex = 13;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(535, 18);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(103, 29);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseSelectable = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(535, 67);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(103, 29);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseSelectable = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboBarrio
            // 
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.ItemHeight = 23;
            this.cboBarrio.Location = new System.Drawing.Point(99, 18);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(329, 29);
            this.cboBarrio.TabIndex = 0;
            this.cboBarrio.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(21, 28);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Barrio";
            // 
            // cboCiudad
            // 
            this.cboCiudad.FormattingEnabled = true;
            this.cboCiudad.ItemHeight = 23;
            this.cboCiudad.Location = new System.Drawing.Point(99, 67);
            this.cboCiudad.Name = "cboCiudad";
            this.cboCiudad.Size = new System.Drawing.Size(329, 29);
            this.cboCiudad.TabIndex = 0;
            this.cboCiudad.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(21, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Ciudad";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetProveedoresParametrizado";
            reportDataSource1.Value = this.dtProveedoresParametrizadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_Aplicaciones_Visuales.ReporteConParametros.InformeProveedoresConParametros.rdl" +
    "c";
            this.reportViewer1.Location = new System.Drawing.Point(6, 243);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(729, 196);
            this.reportViewer1.TabIndex = 14;
            // 
            // dtProveedoresParametrizadosTableAdapter
            // 
            this.dtProveedoresParametrizadosTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteProveedoresParametrizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.metroPanel1);
            this.Name = "ReporteProveedoresParametrizado";
            this.Load += new System.EventHandler(this.ReporteProveedoresParametrizado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtProveedoresParametrizadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosReportesConParametros)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtTitulo;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnLimpiar;
        private MetroFramework.Controls.MetroButton btnConsultar;
        private MetroFramework.Controls.MetroComboBox cboBarrio;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cboCiudad;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtProveedoresParametrizadosBindingSource;
        private DatosReportesConParametros DatosReportesConParametros;
        private DatosReportesConParametrosTableAdapters.dtProveedoresParametrizadosTableAdapter dtProveedoresParametrizadosTableAdapter;
    }
}