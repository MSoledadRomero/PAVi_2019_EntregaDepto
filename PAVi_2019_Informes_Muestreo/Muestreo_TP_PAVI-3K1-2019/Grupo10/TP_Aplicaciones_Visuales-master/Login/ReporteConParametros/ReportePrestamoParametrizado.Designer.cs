namespace TP_Aplicaciones_Visuales.ReporteConParametros
{
    partial class ReportePrestamoParametrizado
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DatosReportesConParametros = new TP_Aplicaciones_Visuales.ReporteConParametros.DatosReportesConParametros();
            this.dtPrestamoParametrizadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtPrestamoParametrizadoTableAdapter = new TP_Aplicaciones_Visuales.ReporteConParametros.DatosReportesConParametrosTableAdapters.dtPrestamoParametrizadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatosReportesConParametros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPrestamoParametrizadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "HASTA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "DESDE:";
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(286, 111);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(97, 54);
            this.btnMostrarDatos.TabIndex = 11;
            this.btnMostrarDatos.Text = "Cargar Datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(80, 145);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 10;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(80, 111);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 9;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetPrestamosParametrizados";
            reportDataSource1.Value = this.dtPrestamoParametrizadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_Aplicaciones_Visuales.ReporteConParametros.InformePrestamosParametrizados.rdlc" +
    "";
            this.reportViewer1.Location = new System.Drawing.Point(23, 171);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(610, 325);
            this.reportViewer1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(153, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "ESTADISTICA DE PRESTAMO";
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.Teal;
            this.txtTitulo.Location = new System.Drawing.Point(199, 21);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(220, 39);
            this.txtTitulo.TabIndex = 17;
            this.txtTitulo.Text = "BIBLIOTECA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 54);
            this.button1.TabIndex = 18;
            this.button1.Text = "Limpiar Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DatosReportesConParametros
            // 
            this.DatosReportesConParametros.DataSetName = "DatosReportesConParametros";
            this.DatosReportesConParametros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtPrestamoParametrizadoBindingSource
            // 
            this.dtPrestamoParametrizadoBindingSource.DataMember = "dtPrestamoParametrizado";
            this.dtPrestamoParametrizadoBindingSource.DataSource = this.DatosReportesConParametros;
            // 
            // dtPrestamoParametrizadoTableAdapter
            // 
            this.dtPrestamoParametrizadoTableAdapter.ClearBeforeFill = true;
            // 
            // ReportePrestamoParametrizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportePrestamoParametrizado";
            this.Load += new System.EventHandler(this.ReportePrestamoParametrizado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosReportesConParametros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPrestamoParametrizadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource dtPrestamoParametrizadoBindingSource;
        private DatosReportesConParametros DatosReportesConParametros;
        private DatosReportesConParametrosTableAdapters.dtPrestamoParametrizadoTableAdapter dtPrestamoParametrizadoTableAdapter;
    }
}