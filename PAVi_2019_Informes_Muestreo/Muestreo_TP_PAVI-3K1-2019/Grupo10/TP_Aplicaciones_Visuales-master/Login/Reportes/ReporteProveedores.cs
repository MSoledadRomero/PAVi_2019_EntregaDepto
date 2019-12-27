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
    public partial class ReporteProveedores : MetroFramework.Forms.MetroForm
    {
        public ReporteProveedores()
        {
            InitializeComponent();
        }

        private void ReporteProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatosProveedores.DataTableProveedores' Puede moverla o quitarla según sea necesario.
            this.DataTableProveedoresTableAdapter.Fill(this.DatosProveedores.DataTableProveedores);

            this.reportViewer1.RefreshReport();
        }
    }
}
