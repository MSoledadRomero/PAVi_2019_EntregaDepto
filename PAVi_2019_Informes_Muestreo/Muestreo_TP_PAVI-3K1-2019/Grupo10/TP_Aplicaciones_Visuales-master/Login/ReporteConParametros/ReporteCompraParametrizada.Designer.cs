namespace TP_Aplicaciones_Visuales.ReporteConParametros
{
    partial class ReporteCompraParametrizada
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DatosReportesConParametros = new TP_Aplicaciones_Visuales.ReporteConParametros.DatosReportesConParametros();
            this.dtCompraParametrizadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtCompraParametrizadaTableAdapter = new TP_Aplicaciones_Visuales.ReporteConParametros.DatosReportesConParametrosTableAdapters.dtCompraParametrizadaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DatosReportesConParametros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompraParametrizadaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSetCompraParametrizada";
            reportDataSource2.Value = this.dtCompraParametrizadaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_Aplicaciones_Visuales.ReporteConParametros.InformeCompraParametrizado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 190);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(629, 238);
            this.reportViewer1.TabIndex = 0;
            // 
            // DatosReportesConParametros
            // 
            this.DatosReportesConParametros.DataSetName = "DatosReportesConParametros";
            this.DatosReportesConParametros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtCompraParametrizadaBindingSource
            // 
            this.dtCompraParametrizadaBindingSource.DataMember = "dtCompraParametrizada";
            this.dtCompraParametrizadaBindingSource.DataSource = this.DatosReportesConParametros;
            // 
            // dtCompraParametrizadaTableAdapter
            // 
            this.dtCompraParametrizadaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 54);
            this.button1.TabIndex = 26;
            this.button1.Text = "Limpiar Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(151, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "ESTADISTICA DE COMPRA";
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.Teal;
            this.txtTitulo.Location = new System.Drawing.Point(197, 35);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(220, 39);
            this.txtTitulo.TabIndex = 25;
            this.txtTitulo.Text = "BIBLIOTECA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "HASTA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "DESDE:";
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(284, 125);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(97, 54);
            this.btnMostrarDatos.TabIndex = 21;
            this.btnMostrarDatos.Text = "Cargar Datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(78, 159);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 20;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(78, 125);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 19;
            // 
            // ReporteCompraParametrizada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteCompraParametrizada";
            this.Load += new System.EventHandler(this.ReporteCompraParametrizada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosReportesConParametros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompraParametrizadaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtCompraParametrizadaBindingSource;
        private DatosReportesConParametros DatosReportesConParametros;
        private DatosReportesConParametrosTableAdapters.dtCompraParametrizadaTableAdapter dtCompraParametrizadaTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
    }
}