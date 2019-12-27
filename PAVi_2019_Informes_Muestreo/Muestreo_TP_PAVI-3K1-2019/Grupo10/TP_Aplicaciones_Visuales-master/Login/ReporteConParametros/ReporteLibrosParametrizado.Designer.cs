namespace TP_Aplicaciones_Visuales.ReporteConParametros
{
    partial class ReporteLibrosParametrizado
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
            this.dtLibrosParametrizadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosReportesConParametros = new TP_Aplicaciones_Visuales.ReporteConParametros.DatosReportesConParametros();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnLimpiar = new MetroFramework.Controls.MetroButton();
            this.btnConsultar = new MetroFramework.Controls.MetroButton();
            this.cboGenero = new MetroFramework.Controls.MetroComboBox();
            this.cboEditorial = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cboAutor = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtLibrosParametrizadosTableAdapter = new TP_Aplicaciones_Visuales.ReporteConParametros.DatosReportesConParametrosTableAdapters.dtLibrosParametrizadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtLibrosParametrizadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosReportesConParametros)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtLibrosParametrizadosBindingSource
            // 
            this.dtLibrosParametrizadosBindingSource.DataMember = "dtLibrosParametrizados";
            this.dtLibrosParametrizadosBindingSource.DataSource = this.DatosReportesConParametros;
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
            this.metroLabel4.Location = new System.Drawing.Point(27, 88);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(141, 25);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Buscar con filtros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(137, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "ESTADISTICA DE LIBROS";
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.Teal;
            this.txtTitulo.Location = new System.Drawing.Point(183, 14);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(220, 39);
            this.txtTitulo.TabIndex = 8;
            this.txtTitulo.Text = "BIBLIOTECA";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.btnLimpiar);
            this.metroPanel1.Controls.Add(this.btnConsultar);
            this.metroPanel1.Controls.Add(this.cboGenero);
            this.metroPanel1.Controls.Add(this.cboEditorial);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.cboAutor);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(5, 110);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(598, 162);
            this.metroPanel1.TabIndex = 9;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(459, 67);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(103, 29);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseSelectable = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(459, 112);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(103, 29);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseSelectable = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboGenero
            // 
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.ItemHeight = 23;
            this.cboGenero.Location = new System.Drawing.Point(99, 18);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(255, 29);
            this.cboGenero.TabIndex = 0;
            this.cboGenero.UseSelectable = true;
            // 
            // cboEditorial
            // 
            this.cboEditorial.FormattingEnabled = true;
            this.cboEditorial.ItemHeight = 23;
            this.cboEditorial.Location = new System.Drawing.Point(99, 112);
            this.cboEditorial.Name = "cboEditorial";
            this.cboEditorial.Size = new System.Drawing.Size(255, 29);
            this.cboEditorial.TabIndex = 0;
            this.cboEditorial.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(21, 122);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(57, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Editorial";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(21, 28);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Genero";
            // 
            // cboAutor
            // 
            this.cboAutor.FormattingEnabled = true;
            this.cboAutor.ItemHeight = 23;
            this.cboAutor.Location = new System.Drawing.Point(99, 67);
            this.cboAutor.Name = "cboAutor";
            this.cboAutor.Size = new System.Drawing.Size(255, 29);
            this.cboAutor.TabIndex = 0;
            this.cboAutor.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(21, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Autor";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetLibrosParametrizados";
            reportDataSource1.Value = this.dtLibrosParametrizadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_Aplicaciones_Visuales.ReporteConParametros.InformeLibrosParametrizados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(7, 279);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(596, 238);
            this.reportViewer1.TabIndex = 10;
            // 
            // dtLibrosParametrizadosTableAdapter
            // 
            this.dtLibrosParametrizadosTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteLibrosParametrizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 536);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.metroPanel1);
            this.Name = "ReporteLibrosParametrizado";
            this.Load += new System.EventHandler(this.ReporteLibrosParametrizado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtLibrosParametrizadosBindingSource)).EndInit();
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
        private MetroFramework.Controls.MetroComboBox cboGenero;
        private MetroFramework.Controls.MetroComboBox cboEditorial;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cboAutor;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtLibrosParametrizadosBindingSource;
        private DatosReportesConParametros DatosReportesConParametros;
        private DatosReportesConParametrosTableAdapters.dtLibrosParametrizadosTableAdapter dtLibrosParametrizadosTableAdapter;
    }
}