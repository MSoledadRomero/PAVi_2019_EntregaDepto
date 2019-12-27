using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Aplicaciones_Visuales.EstadisticasGraficas;
using TP_Aplicaciones_Visuales.Reportes;
using TP_Aplicaciones_Visuales.ReporteConParametros;

namespace TP_Aplicaciones_Visuales
{
    public partial class frmInformes : MetroFramework.Forms.MetroForm
    {
        public frmInformes()
        {
            InitializeComponent();
        }

        private void frmInformes_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ReporteLibros frmReporteLibros = new ReporteLibros();
            frmReporteLibros.ShowDialog();
            frmReporteLibros.Dispose();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            ReporteProveedores frmReporteProveedores = new ReporteProveedores();
            frmReporteProveedores.ShowDialog();
            frmReporteProveedores.Dispose();
        }
    }
}
