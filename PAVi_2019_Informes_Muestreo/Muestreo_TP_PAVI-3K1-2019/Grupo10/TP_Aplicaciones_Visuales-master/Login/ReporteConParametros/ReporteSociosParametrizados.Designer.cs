namespace TP_Aplicaciones_Visuales.ReporteConParametros
{
    partial class ReporteSociosParametrizados
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
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnLimpiar = new MetroFramework.Controls.MetroButton();
            this.btnConsultar = new MetroFramework.Controls.MetroButton();
            this.cboTipoDoc = new MetroFramework.Controls.MetroComboBox();
            this.cboCiudad = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cboBarrio = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtSocioParametrizadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosReportesConParametros = new TP_Aplicaciones_Visuales.ReporteConParametros.DatosReportesConParametros();
            this.dtSocioParametrizadoTableAdapter = new TP_Aplicaciones_Visuales.ReporteConParametros.DatosReportesConParametrosTableAdapters.dtSocioParametrizadoTableAdapter();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSocioParametrizadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosReportesConParametros)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetSociosParametrizados";
            reportDataSource1.Value = this.dtSocioParametrizadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_Aplicaciones_Visuales.ReporteConParametros.InformeSociosParametrizados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(5, 285);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(616, 186);
            this.reportViewer1.TabIndex = 0;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(27, 87);
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
            this.label1.Location = new System.Drawing.Point(174, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "ESTADISTICA DE SOCIOS";
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.Teal;
            this.txtTitulo.Location = new System.Drawing.Point(220, 19);
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
            this.metroPanel1.Controls.Add(this.cboTipoDoc);
            this.metroPanel1.Controls.Add(this.cboCiudad);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.cboBarrio);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(5, 106);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(616, 162);
            this.metroPanel1.TabIndex = 13;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(495, 67);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(103, 29);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseSelectable = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(495, 112);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(103, 29);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseSelectable = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.ItemHeight = 23;
            this.cboTipoDoc.Location = new System.Drawing.Point(99, 18);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(326, 29);
            this.cboTipoDoc.TabIndex = 0;
            this.cboTipoDoc.UseSelectable = true;
            // 
            // cboCiudad
            // 
            this.cboCiudad.FormattingEnabled = true;
            this.cboCiudad.ItemHeight = 23;
            this.cboCiudad.Location = new System.Drawing.Point(99, 112);
            this.cboCiudad.Name = "cboCiudad";
            this.cboCiudad.Size = new System.Drawing.Size(326, 29);
            this.cboCiudad.TabIndex = 0;
            this.cboCiudad.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(21, 122);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Ciudad";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(21, 28);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Tipo Doc.";
            // 
            // cboBarrio
            // 
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.ItemHeight = 23;
            this.cboBarrio.Location = new System.Drawing.Point(99, 67);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(326, 29);
            this.cboBarrio.TabIndex = 0;
            this.cboBarrio.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(21, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Barrio";
            // 
            // dtSocioParametrizadoBindingSource
            // 
            this.dtSocioParametrizadoBindingSource.DataMember = "dtSocioParametrizado";
            this.dtSocioParametrizadoBindingSource.DataSource = this.DatosReportesConParametros;
            // 
            // DatosReportesConParametros
            // 
            this.DatosReportesConParametros.DataSetName = "DatosReportesConParametros";
            this.DatosReportesConParametros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtSocioParametrizadoTableAdapter
            // 
            this.dtSocioParametrizadoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteSociosParametrizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 483);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteSociosParametrizados";
            this.Load += new System.EventHandler(this.ReporteSociosParametrizados_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSocioParametrizadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosReportesConParametros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtSocioParametrizadoBindingSource;
        private DatosReportesConParametros DatosReportesConParametros;
        private DatosReportesConParametrosTableAdapters.dtSocioParametrizadoTableAdapter dtSocioParametrizadoTableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtTitulo;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnLimpiar;
        private MetroFramework.Controls.MetroButton btnConsultar;
        private MetroFramework.Controls.MetroComboBox cboTipoDoc;
        private MetroFramework.Controls.MetroComboBox cboCiudad;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cboBarrio;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}