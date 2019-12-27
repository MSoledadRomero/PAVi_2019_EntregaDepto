using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Aplicaciones_Visuales.BusinessLayer;
using TP_Aplicaciones_Visuales.Entities;
using TP_Aplicaciones_Visuales.Soporte;

namespace TP_Aplicaciones_Visuales.GUILayer
{
    public partial class ABMPrestamos : MetroFramework.Forms.MetroForm
    {
        
        private FormMode formMode;
        private EstadoPrestamoService oEstadoPrestamoService;
        private SoporteForm oSoporteForm;
        private LibroService oLibroService;
        private Prestamo oPrestamoSelected;
        private EjemplarService oEjemplarService;
        private PrestamoService oPrestamoService;
        private EstadoDetallePrestamoService oEstadoDetallePrestamoService;
        private DetallePrestamoService oDetallePrestamoService;
        public ABMPrestamos()
        {
            InitializeComponent();
            oEstadoDetallePrestamoService = new EstadoDetallePrestamoService();
            oDetallePrestamoService = new DetallePrestamoService();
            oPrestamoService = new PrestamoService();
            oEstadoPrestamoService = new EstadoPrestamoService();
            oLibroService = new LibroService();
            oSoporteForm = new SoporteForm();
            oPrestamoSelected = new Prestamo();
            oEjemplarService = new EjemplarService();
            
        }
        public void insetarPrestamoA(int idSocio)
        {
            formMode = FormMode.insert;
            oPrestamoSelected.IdSocio = idSocio;
        }
        public enum FormMode
        {
            insert,
            update,
        }
        public void SeleccionarPrestamo(FormMode op, Prestamo oPrestamo)
        {
            formMode = op;
            oPrestamoSelected = oPrestamo;
        }
        private void mostrarPrestamo()
        {
            int cantLibros = oPrestamoSelected.ListaDeDetalles.Count;
            cboEstado.SelectedValue     = oPrestamoSelected.IdEstadoPrestamo;
            cboCantLibros.SelectedItem  = cantLibros.ToString();
            dtFechaLimite.Value         = oPrestamoSelected.FechaLimite;
            //Dependiendo de la cantidad de libros, la cantidad de detallePrestamos a cargar en el control tab. Con el goto nos aseguramos que aunque entre en el case 2 tambien se cargue la pagina de el libro 1 
            switch (cantLibros)
            {
                case 1:
                    
                    txtCodigoLibro1.Text = oPrestamoSelected.ListaDeDetalles[0].IdLibro.ToString();
                    cboEstadoDetallePrestamo1.SelectedValue = oPrestamoSelected.ListaDeDetalles[0].IdEstadoDetallePrestamo;
                    cboNumeroDeEjemplar1.SelectedItem = oPrestamoSelected.ListaDeDetalles[0].IdEjemplar.ToString();
                    metroTabPage1.Text = oLibroService.obtenerLibroSinParametros(oPrestamoSelected.ListaDeDetalles[0].IdLibro).Titulo;
                    break;

                case 2:
                   
                    txtCodigoLibro2.Text = oPrestamoSelected.ListaDeDetalles[1].IdLibro.ToString();
                    cboEstadoDetallePrestamo2.SelectedValue = oPrestamoSelected.ListaDeDetalles[1].IdEstadoDetallePrestamo;
                    cboNumeroDeEjemplar2.SelectedItem = oPrestamoSelected.ListaDeDetalles[1].IdEjemplar.ToString();
                    metroTabPage2.Text = oLibroService.obtenerLibroSinParametros(oPrestamoSelected.ListaDeDetalles[1].IdLibro).Titulo;
                    goto case 1;

                case 3:
                    txtCodigoLibro3.Text = oPrestamoSelected.ListaDeDetalles[2].IdLibro.ToString();
                    cboEstadoDetallePrestamo3.SelectedValue = oPrestamoSelected.ListaDeDetalles[2].IdEstadoDetallePrestamo;
                    cboNumeroDeEjemplar3.SelectedItem = oPrestamoSelected.ListaDeDetalles[2].IdEjemplar.ToString();
                    metroTabPage3.Text = oLibroService.obtenerLibroSinParametros(oPrestamoSelected.ListaDeDetalles[2].IdLibro).Titulo;
                    goto case 2;

            }
            tabControlDetalles.SelectedIndex = 0;
        }

        private void cargarPrestamo()
        {
            oPrestamoSelected.FechaPrestamo = System.DateTime.Today;
            oPrestamoSelected.FechaLimite = dtFechaLimite.Value;
            oPrestamoSelected.IdEstadoPrestamo = Convert.ToInt32(cboEstado.SelectedValue);


            switch (Convert.ToInt32(cboCantLibros.SelectedItem))
            {
                case 1:
                    DetallePrestamo oDetallePrestamo1 = new DetallePrestamo();
                    oDetallePrestamo1.IdEjemplar = Convert.ToInt32(cboNumeroDeEjemplar1.SelectedItem.ToString());
                    oDetallePrestamo1.IdEstadoDetallePrestamo = Convert.ToInt32(cboEstadoDetallePrestamo1.SelectedValue.ToString());
                    oDetallePrestamo1.IdLibro = Convert.ToInt32(txtCodigoLibro1.Text);
                    oDetallePrestamo1.IdPrestamo = oPrestamoSelected.IdPrestamo;
                    oPrestamoSelected.ListaDeDetalles= new List<DetallePrestamo>();
                    oPrestamoSelected.ListaDeDetalles.Add(oDetallePrestamo1);
                    break;

                case 2:
                    DetallePrestamo oDetallePrestamo2 = new DetallePrestamo();
                    oDetallePrestamo2.IdEjemplar = Convert.ToInt32(cboNumeroDeEjemplar2.SelectedItem.ToString());
                    oDetallePrestamo2.IdEstadoDetallePrestamo = Convert.ToInt32(cboEstadoDetallePrestamo2.SelectedValue.ToString());
                    oDetallePrestamo2.IdLibro = Convert.ToInt32(txtCodigoLibro2.Text);
                    oDetallePrestamo2.IdPrestamo = oPrestamoSelected.IdPrestamo;
                    oPrestamoSelected.ListaDeDetalles.Add(oDetallePrestamo2);
                    goto case 1;

                case 3:
                    DetallePrestamo oDetallePrestamo3 = new DetallePrestamo();
                    oDetallePrestamo3.IdEjemplar = Convert.ToInt32(cboNumeroDeEjemplar3.SelectedItem.ToString());
                    oDetallePrestamo3.IdEstadoDetallePrestamo = Convert.ToInt32(cboEstadoDetallePrestamo3.SelectedValue.ToString());
                    oDetallePrestamo3.IdLibro = Convert.ToInt32(txtCodigoLibro3.Text);
                    oDetallePrestamo3.IdPrestamo = oPrestamoSelected.IdPrestamo;
                    oPrestamoSelected.ListaDeDetalles.Add(oDetallePrestamo3);
                    goto case 2;

            }
        }
        private void ABMPrestamos_Load(object sender, EventArgs e)
        {
            oSoporteForm.cargarCombo(cboEstado, oEstadoPrestamoService.obtenerTodos());
            oSoporteForm.cargarCombo(cboEstadoDetallePrestamo1, oEstadoDetallePrestamoService.obtenerTodos());
            oSoporteForm.cargarCombo(cboEstadoDetallePrestamo2, oEstadoDetallePrestamoService.obtenerTodos());
            oSoporteForm.cargarCombo(cboEstadoDetallePrestamo3, oEstadoDetallePrestamoService.obtenerTodos());

            cboCantLibros.SelectedValue = 1;


            switch (formMode)
            {
                case FormMode.insert:
                    this.Text = "Nuevo Prestamo";
                    cboEstado.SelectedValue = 1;
                    cboCantLibros.SelectedItem = "1";
                    //La fecha de devolucion es siempre 10 dias despues del inicio del prestamo
                    //En caso de querer renovar la fecha se debera ingresar en modo update 
                    dtFechaLimite.Value = System.DateTime.Today.AddDays(10);
                    dtFechaLimite.Enabled = false;
                    break;
                case FormMode.update:
                    this.Text = "Actualizar Prestamo";
                    cboNumeroDeEjemplar1.Enabled = false;
                    cboNumeroDeEjemplar2.Enabled = false;
                    cboNumeroDeEjemplar3.Enabled = false;
                    txtCodigoLibro1.Enabled = false;
                    txtCodigoLibro2.Enabled = false;
                    txtCodigoLibro3.Enabled = false;
                    cboCantLibros.Enabled = false;
                    mostrarPrestamo();
                    break;
            }

        }
        private void cboCantLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            int cantLibros = Convert.ToInt32(cbo.SelectedItem);

         
                switch (cantLibros)
                {
                    case 1:
                        //No se podia desactivar la tab page asi que tuve que desactivar uno por uno los elementos al final cree un panel y fui desactivando el panel
                        mPanel2.Enabled = false;
                        mPanel3.Enabled = false;
                        metroTabPage2.Text = "";
                        metroTabPage3.Text = "";
                        tabControlDetalles.SelectedIndex = 0;
                        break;

                    case 2:
                        mPanel2.Enabled = true;
                        metroTabPage2.Text = "Libro 2";
                        mPanel3.Enabled = false;
                        metroTabPage3.Text = "";
                        tabControlDetalles.SelectedIndex = 1;
                        break;

                    case 3:
                        mPanel2.Enabled = true;
                        metroTabPage2.Text = "Libro 2";
                        metroTabPage3.Text = "Libro 3";
                        mPanel3.Enabled = true;
                        tabControlDetalles.SelectedIndex = 2;
                        break;
                }
        }

        private void btnConsultarLibros_Click(object sender, EventArgs e)
        {
            frmConsultarLibros oFrmConsultarLibros = new frmConsultarLibros();
            oFrmConsultarLibros.ShowDialog();
            switch (tabControlDetalles.SelectedIndex)
            {
                case 0:
                    txtCodigoLibro1.Text = oFrmConsultarLibros.Seleccionado.IdLibro.ToString();
                    break;
                case 1:
                    txtCodigoLibro2.Text = oFrmConsultarLibros.Seleccionado.IdLibro.ToString();
                    break;
                case 2:
                    txtCodigoLibro3.Text = oFrmConsultarLibros.Seleccionado.IdLibro.ToString();
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        private void modificarEjemplares()
        {
            foreach (var oDetallePrestamo in oPrestamoSelected.ListaDeDetalles)
            {
                Ejemplar oEjemplar = oEjemplarService.obtenerEjemplarSinParametros(oDetallePrestamo.IdEjemplar);
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    cargarPrestamo();
                    oPrestamoService.insert(oPrestamoSelected);
                    this.Close();
                    break;
                case FormMode.update:
                    cargarPrestamo();
                    oPrestamoService.update(oPrestamoSelected);
                    
                    this.Close();
                    break;
                default:
                    break;
            }
        }
    }
}
