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
    public partial class frmEstadisticaLibroPorGenero : MetroFramework.Forms.MetroForm
    {
        public frmEstadisticaLibroPorGenero()
        {
            InitializeComponent();
        }

        private void frmEstadisticaLibroPorGenero_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatosEstadisticasGraficas.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.FillLibrosPorGenero(this.DatosEstadisticasGraficas.DataTable1);
            this.reportViewer1.RefreshReport();
        }
    }
}
