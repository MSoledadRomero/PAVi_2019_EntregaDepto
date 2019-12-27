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
    public partial class ReportePrestamos : MetroFramework.Forms.MetroForm
    {
        public ReportePrestamos()
        {
            InitializeComponent();
        }

        private void ReportePrestamos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatosPrestamos.dtPrestamos' Puede moverla o quitarla según sea necesario.
            this.dtPrestamosTableAdapter.FillPrestamos(this.DatosPrestamos.dtPrestamos);

            this.reportViewer1.RefreshReport();
        }
    }
}
