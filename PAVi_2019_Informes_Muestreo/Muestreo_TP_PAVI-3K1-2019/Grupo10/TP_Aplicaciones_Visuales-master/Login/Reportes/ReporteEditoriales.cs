using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Aplicaciones_Visuales.Reportes
{
    public partial class ReporteEditoriales : MetroFramework.Forms.MetroForm
    {
        public ReporteEditoriales()
        {
            InitializeComponent();
        }

        private void ReporteEditoriales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatosEditorial.dtEditorial' Puede moverla o quitarla según sea necesario.
            this.dtEditorialTableAdapter.FillEditorial(this.DatosEditorial.dtEditorial);

            this.reportViewer1.RefreshReport();
        }
    }
}
