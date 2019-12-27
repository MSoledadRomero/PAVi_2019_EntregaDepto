using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Aplicaciones_Visuales.GUILayer;
using TP_Aplicaciones_Visuales.ReporteConParametros;
using TP_Aplicaciones_Visuales.Reportes;
using TP_Aplicaciones_Visuales.EstadisticasGraficas;


namespace TP_Aplicaciones_Visuales
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmMain());
            Application.Run(new ReporteSociosParametrizados());
            
            
            //Application.Run(new frmEstadisticaProveedores());
        }
    }
}
