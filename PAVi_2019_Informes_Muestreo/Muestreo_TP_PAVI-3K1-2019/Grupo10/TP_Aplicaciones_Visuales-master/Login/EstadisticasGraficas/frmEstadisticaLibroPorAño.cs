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
    public partial class frmEstadisticaLibroPorAño : MetroFramework.Forms.MetroForm
    {
        public frmEstadisticaLibroPorAño()
        {
            InitializeComponent();
        }

        private void frmEstadisticaLibroPorAño_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatosEstadisticasGraficas.dtLibroPorAño' Puede moverla o quitarla según sea necesario.
            this.dtLibroPorAñoTableAdapter.FillLibroPorAño(this.DatosEstadisticasGraficas.dtLibroPorAño);

            this.reportViewer1.RefreshReport();
        }
    }
}
