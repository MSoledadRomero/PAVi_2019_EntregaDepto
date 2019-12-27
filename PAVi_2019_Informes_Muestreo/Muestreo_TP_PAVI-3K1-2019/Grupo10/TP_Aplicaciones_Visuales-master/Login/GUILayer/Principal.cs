using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Aplicaciones_Visuales.GUILayer;

namespace TP_Aplicaciones_Visuales.GUILayer
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rpta;
            rpta = MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rpta == DialogResult.No)
                e.Cancel = true;
        }



      

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevoSocio nuevoSocio = new frmNuevoSocio();
            nuevoSocio.ShowDialog();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultarLibros consultarLibros = new frmConsultarLibros();
            consultarLibros.ShowDialog();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevoSocio nuevoSocio = new frmNuevoSocio();
            nuevoSocio.FormMode1 = frmNuevoSocio.FormMode.update;
            nuevoSocio.ShowDialog();
        }


        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarSocio consultarSocio = new frmConsultarSocio();
            consultarSocio.Show();

        }
    }
}
