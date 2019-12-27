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
    public partial class frmProductosMasVendidos : Form
    {
        public frmProductosMasVendidos()
        {
            InitializeComponent();
        }

        private void frmProductosMasVendidos_Load(object sender, EventArgs e)
        {
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'PMasVendidosDS.Productos' Puede moverla o quitarla según sea necesario.
            string fechadesde = Convert.ToString(dtpDesde.Value);
            string fechahasta = Convert.ToString(dtpHasta.Value);
            this.ProductosTableAdapter.Fill(this.PMasVendidosDS.Productos, fechadesde, fechahasta);
            this.reportViewer1.RefreshReport();
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
