using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace TP_Aplicaciones_Visuales.ReporteConParametros
{
    public partial class ReportePrestamoParametrizado : MetroFramework.Forms.MetroForm
    {

        public ReportePrestamoParametrizado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Parse("01/01/2019 00:00:00");
            dtpHasta.Value = DateTime.Now;
            this.dtPrestamoParametrizadoTableAdapter.FillInitialice(this.DatosReportesConParametros.dtPrestamoParametrizado);
            this.reportViewer1.RefreshReport();

        }


        private void ReportePrestamoParametrizado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatosReportesConParametros.dtPrestamoParametrizado' Puede moverla o quitarla según sea necesario.
            this.dtPrestamoParametrizadoTableAdapter.FillInitialice(this.DatosReportesConParametros.dtPrestamoParametrizado);
            this.reportViewer1.RefreshReport();
            dtpDesde.Value = DateTime.Parse("01/01/2019 00:00:00");
            dtpHasta.Value = DateTime.Now;
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            ReportParameter[] parametros = new ReportParameter[2];
            parametros[0] = new ReportParameter("fechaDesde", dtpDesde.Value.ToShortDateString());
            parametros[1] = new ReportParameter("fechaHasta", dtpHasta.Value.ToShortDateString());
            this.dtPrestamoParametrizadoTableAdapter.FillByFecha(this.DatosReportesConParametros.dtPrestamoParametrizado, dtpDesde.Value.ToShortDateString(), dtpHasta.Value.ToShortDateString());
            reportViewer1.LocalReport.SetParameters(parametros);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }
    }
}
