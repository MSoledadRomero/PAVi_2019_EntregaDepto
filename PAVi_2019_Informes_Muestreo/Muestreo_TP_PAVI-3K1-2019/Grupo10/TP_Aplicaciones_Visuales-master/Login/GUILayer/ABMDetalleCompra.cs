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
using TP_Aplicaciones_Visuales.Soporte;
using TP_Aplicaciones_Visuales.BusinessLayer;

namespace TP_Aplicaciones_Visuales.GUILayer
{
    public partial class ABMDetalleCompra : MetroFramework.Forms.MetroForm
    {
        private FormMode formMode = FormMode.insert;
        private DetalleCompra detalleSelected;        
        private readonly SoporteForm oSoporteForm;
        private readonly AutorService oAutorService;
        private readonly EditorialService oEditorialService;
        private readonly GeneroService oGeneroService;
        private LibroService oLibroService;
        private EjemplarService oEjemplarService;
        private DetalleCompraService oDetalleCompraService;

        internal DetalleCompra DetalleSelected { get => detalleSelected; set => detalleSelected = value; }

        public ABMDetalleCompra()
        {
            InitializeComponent();
            oSoporteForm = new SoporteForm();
            oAutorService = new AutorService();
            oEditorialService = new EditorialService();
            oGeneroService = new GeneroService();
            oLibroService = new LibroService();
            oEjemplarService = new EjemplarService();
            detalleSelected = new DetalleCompra();
            oDetalleCompraService = new DetalleCompraService();
            formMode = FormMode.insert;
            
        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }

        public void SeleccionarDetalleCompra(FormMode op, DetalleCompra detalleSelected)
        {
            formMode = op;
            DetalleSelected = detalleSelected;
        }
        private void cargarLosDatosAlFrm(DetalleCompra oDetalleCompra)
        {  
            cboCantidad.SelectedItem = oDetalleCompra.Cantidad.ToString();
            txtIdLibro.Text = oDetalleCompra.Libro.IdLibro.ToString();
            txtTitulo.Text = oDetalleCompra.Libro.Titulo.ToString();
            txtAño.Text = oDetalleCompra.Libro.AñoEdicion.ToString();
            cboGenero.SelectedValue = oDetalleCompra.Libro.IdGenero;
            cboAutor.SelectedValue = oDetalleCompra.Libro.IdAutor;
            cboEditorial.SelectedValue = oDetalleCompra.Libro.IdEditorial;
            txtSector.Text = oDetalleCompra.Libro.Sector;
            txtEstante.Text = oDetalleCompra.Libro.Estante.ToString();
        }
        private void cargarDatosDetalle()
        {
            detalleSelected.Cantidad = Convert.ToInt32(cboCantidad.SelectedItem);
            detalleSelected.Libro = new Libro();
            detalleSelected.Libro.IdLibro = Convert.ToInt32(txtIdLibro.Text);
            detalleSelected.Libro.Titulo = txtTitulo.Text;
            detalleSelected.Libro.AñoEdicion = Convert.ToInt32(txtAño.Text);
            detalleSelected.Libro.IdGenero = Convert.ToInt32(cboGenero.SelectedValue);
            detalleSelected.Libro.IdAutor = Convert.ToInt32(cboAutor.SelectedValue);
            detalleSelected.Libro.IdEditorial = Convert.ToInt32(cboEditorial.SelectedValue);
            detalleSelected.Libro.Sector = txtSector.Text;
            detalleSelected.Libro.Estante = Convert.ToInt32(txtEstante.Text);
           
        }

        private void habilitarDeshabilitar(bool x)
        {
            txtTitulo.Enabled = x;
            txtAño.Enabled = x;
            cboGenero.Enabled = x;
            cboAutor.Enabled = x;
            cboEditorial.Enabled = x;
            txtSector.Enabled = x;
            txtEstante.Enabled = x;
        }

        private void ABMLibro_Load(object sender, EventArgs e)
        {
            oSoporteForm.cargarCombo(cboAutor, oAutorService.obtenerAutores("listarAutores"));
            oSoporteForm.cargarCombo(cboEditorial, oEditorialService.obtenerEditoriales("listarEditoriales"));
            oSoporteForm.cargarCombo(cboGenero, oGeneroService.obtenerGeneros("listarGeneros"));
            
            switch (formMode)
            {
                case FormMode.insert:
                    txtIdLibro.Enabled = false;
                    this.Text = "Nuevo Libro";
                    txtIdLibro.Text = (oLibroService.ObtenerProximoId()).ToString();                    
                    break;

                case FormMode.update:
                    this.Text = "Actualizar Libro";                    
                    cargarLosDatosAlFrm(detalleSelected);
                    txtIdLibro.Enabled = false;
                    cboCantidad.Enabled = false;
                    habilitarDeshabilitar(true);
                    break;

                case FormMode.delete:
                    this.Text = "Dar de baja libro";
                    cargarLosDatosAlFrm(DetalleSelected);
                    txtIdLibro.Enabled = false;                    
                    habilitarDeshabilitar(false);
                    break;
            }
        }

        private bool validarCampos()
        {
            //true: valido , false: invalido

            //Todo: ver bien cuales campos son obligatorios y cuales no
            bool t1 = oSoporteForm.validarText(txtTitulo);
            bool t2 = oSoporteForm.validarText(txtAño);
            bool t3 = oSoporteForm.validarText(txtSector);
            bool t4 = oSoporteForm.validarText(txtEstante);
            bool t5 = oSoporteForm.validarCombo(cboEditorial);
            bool t6 = oSoporteForm.validarCombo(cboAutor);
            bool t7 = oSoporteForm.validarCombo(cboGenero);
            bool t8 = oSoporteForm.validarCombo(cboCantidad);

            if (t1 && t2 && t3 && t4 && t5 && t6 && t7 && t8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                
                switch (formMode)
                {
                    case FormMode.insert:

                        cargarDatosDetalle();
                        detalleSelected.Libro.Ejemplares = new List<Ejemplar>();
                        for (int i = 0; i < detalleSelected.Cantidad; i++)
                        {
                            
                            detalleSelected.Libro.Ejemplares.Add(new Ejemplar()
                            {
                                IdEjemplar = i,
                            });
                        }
                        oDetalleCompraService.insert(detalleSelected);
                    
                        break;
                    case FormMode.update:
                        cargarDatosDetalle();
                        oDetalleCompraService.update(detalleSelected);
                        
                        break;
                
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Hay campos vacíos, por favor completelos");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

    }
}
