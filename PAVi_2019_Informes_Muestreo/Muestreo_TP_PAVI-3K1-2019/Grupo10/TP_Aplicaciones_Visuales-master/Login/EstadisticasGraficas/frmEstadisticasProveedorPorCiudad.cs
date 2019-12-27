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
    public partial class frmEstadisticasProveedorPorCiudad : MetroFramework.Forms.MetroForm
    {
        public frmEstadisticasProveedorPorCiudad()
        {
            InitializeComponent();
        }

        private void frmEstadisticasProveedorPorCiudad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatosEstadisticasGraficas.dtProveedoresPorCiudad' Puede moverla o quitarla según sea necesario.
            this.dtProveedoresPorCiudadTableAdapter.FillProveedoresPorCiudad(this.DatosEstadisticasGraficas.dtProveedoresPorCiudad);

            this.reportViewer1.RefreshReport();
        }
    }
}
