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
    public partial class frmEstadisticaPrestamoPorLibro : MetroFramework.Forms.MetroForm
    {
        public frmEstadisticaPrestamoPorLibro()
        {
            InitializeComponent();
        }

        private void frmEstadisticaPrestamoPorLibro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatosEstadisticasGraficas.dtPrestamoPorLibro' Puede moverla o quitarla según sea necesario.
            this.dtPrestamoPorLibroTableAdapter.FillPrestamoPorLibro(this.DatosEstadisticasGraficas.dtPrestamoPorLibro);

            this.reportViewer1.RefreshReport();
        }
    }
}
