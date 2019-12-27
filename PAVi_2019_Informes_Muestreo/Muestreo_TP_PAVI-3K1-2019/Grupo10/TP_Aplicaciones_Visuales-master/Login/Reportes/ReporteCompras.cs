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
    public partial class ReporteCompras : MetroFramework.Forms.MetroForm
    {
        public ReporteCompras()
        {
            InitializeComponent();
        }

        private void ReporteCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatosCompras.dtCompra' Puede moverla o quitarla según sea necesario.
            this.dtCompraTableAdapter.FillInitialice(this.DatosCompras.dtCompra);

            this.reportViewer1.RefreshReport();
        }
    }
}
