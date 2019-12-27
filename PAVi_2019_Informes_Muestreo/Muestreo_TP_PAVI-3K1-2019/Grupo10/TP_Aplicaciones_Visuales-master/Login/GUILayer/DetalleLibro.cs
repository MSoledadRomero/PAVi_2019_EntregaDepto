using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Aplicaciones_Visuales.Entities;
using TP_Aplicaciones_Visuales.BusinessLayer;


namespace TP_Aplicaciones_Visuales.GUILayer
{
    public partial class frmDetalleLibro : Form
    {
        private FormMode formMode = FormMode.insert;
        private Libro oLibroSeleccionado;
        private string[] datosExtra;
        private List<Ejemplar> ejemplares;
        private readonly EjemplarService oEjemplarService;
        private readonly EstadoEjemplarService oEstadoEjemplarService;

       
        public string[] DatosExtra { get => datosExtra; set => datosExtra = value; }
        public FormMode FormMode1 { get => formMode; set => formMode = value; }
        internal Libro OLibroSeleccionado { get => oLibroSeleccionado; set => oLibroSeleccionado = value; }

        public frmDetalleLibro()
        {
            InitializeComponent();
            OLibroSeleccionado = new Libro();
            ejemplares = new List<Ejemplar>();
            oEjemplarService = new EjemplarService();
            oEstadoEjemplarService = new EstadoEjemplarService();

            
        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }

        private void cargarDatosLibro()
        {
            txtIdLibro.Text = OLibroSeleccionado.IdLibro.ToString();
            txtTitulo.Text = OLibroSeleccionado.Titulo;
            txtAño.Text = OLibroSeleccionado.AñoEdicion.ToString();
            txtSector.Text = OLibroSeleccionado.Sector;
            txtEstante.Text = OLibroSeleccionado.Estante.ToString();
            txtGenero.Text = DatosExtra[0];
            txtAutor.Text = DatosExtra[1];
            txtEditorial.Text = DatosExtra[2];
        }
        private void habilitarDeshabilitar(bool x)
        {
            txtTitulo.Enabled = x;
            txtAño.Enabled = x;
            txtGenero.Enabled = x;
            txtAutor.Enabled = x;
            txtEditorial.Enabled = x;
            txtSector.Enabled = x;
            txtEstante.Enabled = x;
        }
        private void frmDetalleLibro_Load(object sender, EventArgs e)
        {
            cargarDatosLibro();

            switch (formMode)
            {
                case FormMode.insert:
                    txtIdLibro.Enabled = false;
                    this.Text = "Nuevo Libro";
                    btnConfirmar.Text = "Confirmar registro";
                    cargarDatosLibro();
                    break;

                case FormMode.update:
                    this.Text = "Actualizar Libro";
                    btnConfirmar.Text = "Confirmar actualización";
                    cargarDatosLibro();
                    txtIdLibro.Enabled = false;                    
                    habilitarDeshabilitar(true);
                    break;

                case FormMode.delete:
                    this.Text = "Dar de baja libro";
                    btnConfirmar.Text = "Confirmar modificaciones";
                    cargarDatosLibro();
                    txtIdLibro.Enabled = false;                    
                    habilitarDeshabilitar(false);
                    break;
            }

        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            //ver como cerrar el form de abmLibro
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {            
            Ejemplar oNuevoEjemplar = new Ejemplar();
            oNuevoEjemplar.IdEjemplar = oEjemplarService.ObtenerProximoId();
            oNuevoEjemplar.IdLibro = OLibroSeleccionado.IdLibro;
            oNuevoEjemplar.IdEstadoEjemplar = oEstadoEjemplarService.obtenerEstadoEjemplarSinParametros("Disponible").IdEstadoEjemplar;
            ejemplares.Add(oNuevoEjemplar);
            grdEjemplares.DataSource = ejemplares;
            
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {

        }
    }
}
