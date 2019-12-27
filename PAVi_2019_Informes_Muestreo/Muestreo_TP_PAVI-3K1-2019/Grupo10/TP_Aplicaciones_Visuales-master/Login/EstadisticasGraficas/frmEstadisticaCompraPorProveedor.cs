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
    public partial class frmEstadisticaCompraPorProveedor : MetroFramework.Forms.MetroForm
    {
        public frmEstadisticaCompraPorProveedor()
        {
            InitializeComponent();
        }

        private void frmEstadisticaCompraPorProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatosEstadisticasGraficas.dtCompraPorProveedor' Puede moverla o quitarla según sea necesario.
            this.dtCompraPorProveedorTableAdapter.FillCompraPorProveedor(this.DatosEstadisticasGraficas.dtCompraPorProveedor);

            this.reportViewer1.RefreshReport();
        }
    }
}
