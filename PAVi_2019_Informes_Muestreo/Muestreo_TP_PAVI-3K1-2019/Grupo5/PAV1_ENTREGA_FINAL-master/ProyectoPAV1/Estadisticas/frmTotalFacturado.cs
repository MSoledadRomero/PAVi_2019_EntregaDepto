using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPAV1.Estadisticas
{
    public partial class frmTotalFacturado : Form
    {
        public frmTotalFacturado()
        {
            InitializeComponent();
        }

        private void frmTotalFacturado_Load(object sender, EventArgs e)
        {
          

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'totalFacturadoDS.DataTable1' Puede moverla o quitarla según sea necesario.
            DateTime año = (dtpAño.Value);

            this.DataTable1TableAdapter.Fill(this.totalFacturadoDS.DataTable1,año);
            this.reportViewer1.RefreshReport();
        }

        private void dtpAño_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Año_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
