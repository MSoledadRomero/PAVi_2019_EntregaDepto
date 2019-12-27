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
    public partial class ReporteLibrosParametrizado : MetroFramework.Forms.MetroForm
    {
        private SoporteForm oSoporteForm;
        private readonly AutorService oAutorService;
        private readonly GeneroService oGeneroService;
        private readonly EditorialService oEditorialService;

        public ReporteLibrosParametrizado()
        {
            InitializeComponent();
           
            oSoporteForm = new SoporteForm();
            oAutorService = new AutorService();
            oGeneroService = new GeneroService();
            oEditorialService = new EditorialService();
        }

        private void ReporteLibrosParametrizado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatosReportesConParametros.dtLibrosParametrizados' Puede moverla o quitarla según sea necesario.
            this.dtLibrosParametrizadosTableAdapter.FillInitialice(this.DatosReportesConParametros.dtLibrosParametrizados);

            this.reportViewer1.RefreshReport();

            oSoporteForm.cargarCombo(cboAutor, oAutorService.obtenerAutores("listarAutores"), "Nombre", "ID");
            oSoporteForm.cargarCombo(cboEditorial, oEditorialService.obtenerEditoriales("listarEditoriales"), "Nombre", "ID");
            oSoporteForm.cargarCombo(cboGenero, oGeneroService.obtenerGeneros("listarGeneros"), "Nombre", "ID");

            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboAutor.SelectedIndex = -1;
            cboGenero.SelectedIndex = -1;
            cboEditorial.SelectedIndex = -1;
            cboAutor.Text = "";
            cboEditorial.Text = "";
            cboGenero.Text = "";
            this.dtLibrosParametrizadosTableAdapter.FillInitialice(this.DatosReportesConParametros.dtLibrosParametrizados);

            this.reportViewer1.RefreshReport();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ReportParameter[] parametros = new ReportParameter[1];
            if (cboGenero.SelectedIndex != -1 && cboAutor.SelectedIndex != -1 && cboEditorial.SelectedIndex != -1)
            {
                parametros = new ReportParameter[3];
                parametros[0] = (new ReportParameter("idGenero", cboGenero.SelectedIndex == -1 ? "0" : cboGenero.SelectedValue.ToString()));
                parametros[1] = (new ReportParameter("idAutor", cboAutor.SelectedIndex == -1 ? "0" : cboAutor.SelectedValue.ToString()));
                parametros[2] = (new ReportParameter("idEditorial", cboEditorial.SelectedIndex == -1 ? "0" : cboEditorial.SelectedValue.ToString()));
                int Genero = Convert.ToInt32(cboGenero.SelectedValue.ToString());
                int Autor = Convert.ToInt32(cboAutor.SelectedValue.ToString());
                int Editorial = Convert.ToInt32(cboEditorial.SelectedValue.ToString());
                
                this.dtLibrosParametrizadosTableAdapter.FillByGeneroAutorEditorial(this.DatosReportesConParametros.dtLibrosParametrizados,Genero,Autor,Editorial);

            }
            else
            {
                if (cboGenero.SelectedIndex != -1)
                {
                    parametros[0] = (new ReportParameter("idGenero", cboGenero.SelectedIndex == -1 ? "0" : cboGenero.SelectedValue.ToString()));

                    int Genero = Convert.ToInt32(cboGenero.SelectedValue.ToString());
                    this.dtLibrosParametrizadosTableAdapter.FillByGenero(this.DatosReportesConParametros.dtLibrosParametrizados, Genero);

                }
                if (cboAutor.SelectedIndex != -1)
                {
                    parametros[0] = (new ReportParameter("idAutor", cboAutor.SelectedIndex == -1 ? "0" : cboAutor.SelectedValue.ToString()));

                    int Autor = Convert.ToInt32(cboAutor.SelectedValue.ToString());
                    this.dtLibrosParametrizadosTableAdapter.FillByAutor(this.DatosReportesConParametros.dtLibrosParametrizados, Autor);
                    
                }
                if (cboEditorial.SelectedIndex != -1)
                {
                    parametros[0] = (new ReportParameter("idEditorial", cboEditorial.SelectedIndex == -1 ? "0" : cboEditorial.SelectedValue.ToString()));

                    int Editorial = Convert.ToInt32(cboEditorial.SelectedValue.ToString());
                    this.dtLibrosParametrizadosTableAdapter.FillByEditorial(this.DatosReportesConParametros.dtLibrosParametrizados, Editorial);
                    
                }
            }
            this.reportViewer1.LocalReport.SetParameters(parametros);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        
        }

       
    }
}
