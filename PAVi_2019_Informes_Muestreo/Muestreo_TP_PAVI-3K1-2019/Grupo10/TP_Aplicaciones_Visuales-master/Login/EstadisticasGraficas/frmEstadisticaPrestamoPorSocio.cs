using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Aplicaciones_Visuales.EstadisticasGraficas
{
    public partial class frmEstadisticaPrestamoPorSocio : MetroFramework.Forms.MetroForm
    {
        public frmEstadisticaPrestamoPorSocio()
        {
            InitializeComponent();
        }

        private void frmEstadisticaPrestamoPorSocio_Load(object sender, EventArgs e)
        {
            this.dtPrestamoPorSocioTableAdapter.FillPrestamoPorSocio(this.DatosEstadisticasGraficas.dtPrestamoPorSocio);
            this.reportViewer1.RefreshReport();
            
        }
    }
}
