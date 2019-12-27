using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Aplicaciones_Visuales.Soporte;

namespace TP_Aplicaciones_Visuales.GUILayer
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        
        public frmMain()
        {
            InitializeComponent();
            

        }


        private void metroTilePrestamos_Click(object sender, EventArgs e)
        {
            frmPrestamo oFrmPrestamo = new frmPrestamo();
            oFrmPrestamo.ShowDialog();
            oFrmPrestamo.Dispose();
        }

        private void metroTileInformes_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTileCompras_Click(object sender, EventArgs e)
        {
            ConsultarCompra oConsultarCompra = new ConsultarCompra();
            oConsultarCompra.ShowDialog();
        }

        private void metroTileSocios_Click(object sender, EventArgs e)
        {
            frmConsultarSocio oFrmConsultarSocio = new frmConsultarSocio();
            oFrmConsultarSocio.ShowDialog();
            this.Focus();
        }

        private void metroTileBarrios_Click(object sender, EventArgs e)
        {
            ConsultarBarrios oConsultarBarrios = new ConsultarBarrios();
            oConsultarBarrios.ShowDialog();
            oConsultarBarrios.Dispose();
        }

        private void metroTileTiposDeDocumento_Click(object sender, EventArgs e)
        {
            ConsultarDocumento oConsultarDocumento = new ConsultarDocumento();
            oConsultarDocumento.ShowDialog();
            oConsultarDocumento.Dispose();
        }

        private void metroTileLibros_Click(object sender, EventArgs e)
        {
            frmConsultarLibros oFrmConsultarLibros = new frmConsultarLibros();
            oFrmConsultarLibros.ShowDialog();
            oFrmConsultarLibros.Dispose();
        }

        private void metroTileGeneros_Click(object sender, EventArgs e)
        {
            ConsultarGeneros oConsultarGeneros = new ConsultarGeneros();
            oConsultarGeneros.ShowDialog();
            oConsultarGeneros.Dispose();
        }

        private void metroTileEditoriales_Click(object sender, EventArgs e)
        {
            ConsultarEditorial oConsultarEditorial = new ConsultarEditorial();
            oConsultarEditorial.ShowDialog();
            oConsultarEditorial.Dispose();
        }



        private void metroTileProveedores_Click(object sender, EventArgs e)
        {
            ConsultarProveedor oConsultarProveedor = new ConsultarProveedor();
            oConsultarProveedor.ShowDialog();
     

        }

        private void metroTileAutores_Click(object sender, EventArgs e)
        {
            frmConsultarAutor ofrmConsultarAutor = new frmConsultarAutor();
            ofrmConsultarAutor.ShowDialog();
            ofrmConsultarAutor.Dispose();
       

        }

        private void metroTileProveedores_Click_1(object sender, EventArgs e)
        {
            ConsultarProveedor oConsultarProveedor = new ConsultarProveedor();
            oConsultarProveedor.ShowDialog();
            oConsultarProveedor.Dispose();
        }
    }
}
