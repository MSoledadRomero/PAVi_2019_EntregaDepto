using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPAV1.GUILayer;
using ProyectoPAV1.GUILayer.Usuarios;
using ProyectoPAV1.GUILayer.Perfiles;
using ProyectoPAV1.GUILayer.Marcas;
using ProyectoPAV1.Estadisticas;


namespace ProyectoPAV1.GUILayer
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin f1 = new frmLogin();
            f1.ShowDialog();

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmUsuarios frmU = new frmUsuarios();
            frmU.ShowDialog();

        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarcas frmM = new frmMarcas();
            frmM.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos f2 = new frmProductos();
            f2.ShowDialog();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFactura ff = new frmFactura();
            ff.ShowDialog();
        }

        private void totalFacturadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTotalFacturado ftf = new frmTotalFacturado();
            ftf.ShowDialog();
        }

        private void productosMasVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductosMasVendidos fpmv = new frmProductosMasVendidos();
            fpmv.ShowDialog();
        }

        private void totalFacturadoPorProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTotalFacturadoXProducto ftp = new frmTotalFacturadoXProducto();
            ftp.ShowDialog();
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPerfiles fp = new frmPerfiles();
            fp.ShowDialog();
        }
    }
}
