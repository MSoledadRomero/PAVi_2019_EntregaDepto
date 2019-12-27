using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPAV1.Reportes
{
    public partial class frmReporteUsuarios : Form
    {
        public frmReporteUsuarios()
        {
            InitializeComponent();
        }

        private void frmReporteUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'usuariosDS.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.usuariosDS.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
