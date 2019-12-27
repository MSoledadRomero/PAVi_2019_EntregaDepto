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
    public partial class ReporteLibros : MetroFramework.Forms.MetroForm
    {
        public ReporteLibros()
        {
            InitializeComponent();
        }

        private void ReporteLibros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatosLibros.DataTableLibros' Puede moverla o quitarla según sea necesario.
            this.DataTableLibrosTableAdapter.Fill(this.DatosLibros.DataTableLibros);
            this.reportViewer1.RefreshReport();

        }
    }
}
