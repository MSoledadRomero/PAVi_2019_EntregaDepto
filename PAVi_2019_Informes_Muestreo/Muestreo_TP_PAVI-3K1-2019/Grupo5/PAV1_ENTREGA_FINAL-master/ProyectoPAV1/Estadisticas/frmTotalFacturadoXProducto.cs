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
    public partial class frmTotalFacturadoXProducto : Form
    {
        public frmTotalFacturadoXProducto()
        {
            InitializeComponent();
        }

        private void frmTotalFacturadoXProducto_Load(object sender, EventArgs e)
        {
          
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'totalFacturadoXProductoDS.Productos' Puede moverla o quitarla según sea necesario.
            string fechadesde = Convert.ToString(dtpDesde.Value);
            string fechahasta = Convert.ToString(dtpHasta.Value);
            this.ProductosTableAdapter.Fill(this.totalFacturadoXProductoDS.Productos, fechadesde, fechahasta);

            this.reportViewer1.RefreshReport();
        }
    }
}
