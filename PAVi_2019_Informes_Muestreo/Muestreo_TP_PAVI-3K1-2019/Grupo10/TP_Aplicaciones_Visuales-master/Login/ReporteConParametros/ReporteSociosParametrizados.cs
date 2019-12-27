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
    public partial class ReporteSociosParametrizados : MetroFramework.Forms.MetroForm
    {
        private readonly SoporteForm oSoporteForm;
        private readonly BarrioService oBarrioService;
        private readonly CiudadService oCiudadService;
        private readonly TipoDocumentoService oTipoDocumentoService;

        public ReporteSociosParametrizados()
        {
            InitializeComponent();
            oSoporteForm = new SoporteForm();
            oBarrioService = new BarrioService();
            oCiudadService = new CiudadService();
            oTipoDocumentoService = new TipoDocumentoService();

        }

        private void ReporteSociosParametrizados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatosReportesConParametros.dtSocioParametrizado' Puede moverla o quitarla según sea necesario.
            this.dtSocioParametrizadoTableAdapter.FillInitialice(this.DatosReportesConParametros.dtSocioParametrizado);

            this.reportViewer1.RefreshReport();
            oSoporteForm.cargarCombo(cboBarrio, oBarrioService.obtenerBarrios("listarBarrios"));
            oSoporteForm.cargarCombo(cboCiudad, oCiudadService.obtenerCiudades("listarCiudades"));
            oSoporteForm.cargarCombo(cboTipoDoc, oTipoDocumentoService.obtenerTipoDocumentos("listarTipoDoc"));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboBarrio.SelectedIndex = -1;
            cboCiudad.SelectedIndex = -1;
            cboTipoDoc.SelectedIndex = -1;
            cboBarrio.Text = "";
            cboCiudad.Text = "";
            cboTipoDoc.Text = "";
            this.dtSocioParametrizadoTableAdapter.FillInitialice(this.DatosReportesConParametros.dtSocioParametrizado);

            this.reportViewer1.RefreshReport();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {


            ReportParameter[] parametros = new ReportParameter[1];

            if (cboBarrio.SelectedIndex != -1 && cboCiudad.SelectedIndex != -1 && cboTipoDoc.SelectedIndex != -1)
            {
                parametros = new ReportParameter[3];
                parametros[0] = (new ReportParameter("idBarrio", cboBarrio.SelectedIndex == -1 ? "0" : cboBarrio.SelectedValue.ToString()));
                parametros[1] = (new ReportParameter("idCiudad", cboCiudad.SelectedIndex == -1 ? "0" : cboCiudad.SelectedValue.ToString()));
                parametros[1] = (new ReportParameter("idTipoDoc", cboTipoDoc.SelectedIndex == -1 ? "0" : cboTipoDoc.SelectedValue.ToString()));

                int Barrio = Convert.ToInt32(cboBarrio.SelectedValue.ToString());
                int Ciudad = Convert.ToInt32(cboCiudad.SelectedValue.ToString());
                int TipoDoc = Convert.ToInt32(cboTipoDoc.SelectedValue.ToString());
                this.dtSocioParametrizadoTableAdapter.FillByTipoDocBarrioCiudad(this.DatosReportesConParametros.dtSocioParametrizado, TipoDoc, Barrio, Ciudad);




            }
            else
            {
                if (cboBarrio.SelectedIndex != -1)
                {
                    parametros[0] = (new ReportParameter("idBarrio", cboBarrio.SelectedIndex == -1 ? "0" : cboBarrio.SelectedValue.ToString()));

                    int Barrio = Convert.ToInt32(cboBarrio.SelectedValue.ToString());
                    this.dtSocioParametrizadoTableAdapter.FillByBarrio(this.DatosReportesConParametros.dtSocioParametrizado, Barrio);



                }
                if (cboCiudad.SelectedIndex != -1)
                {
                    parametros[0] = (new ReportParameter("idCiudad", cboCiudad.SelectedIndex == -1 ? "0" : cboCiudad.SelectedValue.ToString()));

                    int Ciudad = Convert.ToInt32(cboCiudad.SelectedValue.ToString());

                    this.dtSocioParametrizadoTableAdapter.FillByCiudad(this.DatosReportesConParametros.dtSocioParametrizado, Ciudad);



                }
                if (cboTipoDoc.SelectedIndex != -1)
                {
                    parametros[0] = (new ReportParameter("idTipoD", cboTipoDoc.SelectedIndex == -1 ? "0" : cboTipoDoc.SelectedValue.ToString()));

                    int TipoDoc = Convert.ToInt32(cboTipoDoc.SelectedValue.ToString());

                    this.dtSocioParametrizadoTableAdapter.FillByTipoDoc(this.DatosReportesConParametros.dtSocioParametrizado, TipoDoc);


                }
            }

            this.reportViewer1.LocalReport.SetParameters(parametros);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();



        }
    }
}
