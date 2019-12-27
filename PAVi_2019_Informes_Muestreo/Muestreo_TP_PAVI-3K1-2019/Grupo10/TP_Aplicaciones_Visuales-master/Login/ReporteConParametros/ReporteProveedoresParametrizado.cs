using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Aplicaciones_Visuales.Soporte;
using TP_Aplicaciones_Visuales.BusinessLayer;
using Microsoft.Reporting.WinForms;

namespace TP_Aplicaciones_Visuales.ReporteConParametros
{
    public partial class ReporteProveedoresParametrizado : MetroFramework.Forms.MetroForm
    {
        private readonly SoporteForm oSoporteForm;
        private readonly BarrioService oBarrioService;
        private readonly CiudadService oCiudadService;

        public ReporteProveedoresParametrizado()
        {
            InitializeComponent();
            oSoporteForm = new SoporteForm();
            oBarrioService = new BarrioService();
            oCiudadService = new CiudadService();

        }

       

        private void ReporteProveedoresParametrizado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatosReportesConParametros.dtProveedoresParametrizados' Puede moverla o quitarla según sea necesario.
            this.dtProveedoresParametrizadosTableAdapter.FillInitialice(this.DatosReportesConParametros.dtProveedoresParametrizados);

            this.reportViewer1.RefreshReport();

            oSoporteForm.cargarCombo(cboBarrio, oBarrioService.obtenerBarrios("listarBarrios"));
            oSoporteForm.cargarCombo(cboCiudad, oCiudadService.obtenerCiudades("listarCiudades"));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboBarrio.SelectedIndex = -1;
            cboCiudad.SelectedIndex = -1;
            cboBarrio.Text = "";
            cboCiudad.Text = "";
            this.dtProveedoresParametrizadosTableAdapter.FillInitialice(this.DatosReportesConParametros.dtProveedoresParametrizados);

            this.reportViewer1.RefreshReport();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ReportParameter[] parametros = new ReportParameter[1];

            if (cboBarrio.SelectedIndex != -1 && cboCiudad.SelectedIndex != -1)
            {
                parametros = new ReportParameter[2];
                parametros[0] = (new ReportParameter("idBarrio", cboBarrio.SelectedIndex == -1 ? "0" : cboBarrio.SelectedValue.ToString()));
                parametros[1] = (new ReportParameter("idCiudad", cboCiudad.SelectedIndex == -1 ? "0" : cboCiudad.SelectedValue.ToString()));

                int Barrio = Convert.ToInt32(cboBarrio.SelectedValue.ToString());
                int Ciudad = Convert.ToInt32(cboCiudad.SelectedValue.ToString());
                this.dtProveedoresParametrizadosTableAdapter.FillByBarrioCiudad(this.DatosReportesConParametros.dtProveedoresParametrizados,Barrio,Ciudad);
                                

            }
            else
            {
                if (cboBarrio.SelectedIndex != -1)
                {
                    parametros[0] = (new ReportParameter("idBarrio", cboBarrio.SelectedIndex == -1 ? "0" : cboBarrio.SelectedValue.ToString()));

                    int Barrio = Convert.ToInt32(cboBarrio.SelectedValue.ToString());
                    
                    this.dtProveedoresParametrizadosTableAdapter.FillByBarrio(this.DatosReportesConParametros.dtProveedoresParametrizados, Barrio);

                }
                if (cboCiudad.SelectedIndex != -1)
                {
                    parametros[0] = (new ReportParameter("idCiudad", cboCiudad.SelectedIndex == -1 ? "0" : cboCiudad.SelectedValue.ToString()));

                    int Ciudad = Convert.ToInt32(cboCiudad.SelectedValue.ToString());
                    this.dtProveedoresParametrizadosTableAdapter.FillByCiudad(this.DatosReportesConParametros.dtProveedoresParametrizados, Ciudad);                                                                          

                }
            }

            this.reportViewer1.LocalReport.SetParameters(parametros);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();

        }
    }
}
