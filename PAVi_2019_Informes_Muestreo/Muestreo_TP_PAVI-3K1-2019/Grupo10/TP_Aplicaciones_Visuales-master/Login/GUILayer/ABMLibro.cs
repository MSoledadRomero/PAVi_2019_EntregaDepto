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
    public partial class ABMLibro : MetroFramework.Forms.MetroForm
    {
        private FormMode formMode = FormMode.insert;
        private Libro oLibroSeleccionado;        
        private readonly SoporteForm oSoporteForm;
        private readonly AutorService oAutorService;
        private readonly EditorialService oEditorialService;
        private readonly GeneroService oGeneroService;
        private LibroService oLibroService;
        private EjemplarService oEjemplarService;
        private EstadoEjemplarService oEstadoEjemplarService;
        private List<Ejemplar> ejemplares;



        internal Libro OLibroSeleccionado { get => oLibroSeleccionado; set => oLibroSeleccionado = value; }
        public FormMode FormMode1 { get => formMode; set => formMode = value; }

        public ABMLibro()
        {
            InitializeComponent();
            oLibroSeleccionado = new Libro();
            oSoporteForm = new SoporteForm();
            oAutorService = new AutorService();
            oEditorialService = new EditorialService();
            oGeneroService = new GeneroService();
            oLibroService = new LibroService();
            oEjemplarService = new EjemplarService();
            oEstadoEjemplarService = new EstadoEjemplarService();
            ejemplares = new List<Ejemplar>();

            
        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }

        private void InitializeDataGridView(DataGridView oDGV)
        {
            
            oDGV.ColumnCount = 2;
            oDGV.ColumnHeadersVisible = true;
            oDGV.AutoGenerateColumns = false;
            
            oDGV.Columns[0].Name = "Código";
            oDGV.Columns[0].DataPropertyName = "idEjemplar";
           
            oDGV.Columns[1].Name = "Estado";
            oDGV.Columns[1].DataPropertyName = "nombre";
        }

        private void cargarDatosLibro(Libro oLibro)
        {
            txtIdLibro.Text = oLibro.IdLibro.ToString();
            txtTitulo.Text = oLibro.Titulo.ToString();
            txtAño.Text = oLibro.AñoEdicion.ToString();
            cboGenero.SelectedValue = oLibro.IdGenero;
            cboAutor.SelectedValue = oLibro.IdAutor;
            cboEditorial.SelectedValue = oLibro.IdEditorial;
            txtSector.Text = oLibro.Sector;
            txtEstante.Text = oLibro.Estante.ToString();
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
            dgvEjemplaresRegistrados.DataSource = oEjemplarService.obtenerEjemplaresPorLibro(oLibroSeleccionado.IdLibro);
            InitializeDataGridView(dgvEjemplaresNuevos);
            switch (formMode)
            {
                case FormMode.insert:
                    txtIdLibro.Enabled = false;
                    this.Text = "Nuevo Libro";
                    txtIdLibro.Text = (oLibroService.ObtenerProximoId() + 1).ToString();                    
                    break;

                case FormMode.update:
                    this.Text = "Actualizar Libro";                    
                    cargarDatosLibro(OLibroSeleccionado);
                    txtIdLibro.Enabled = false;                    
                    habilitarDeshabilitar(true);
                    break;

                case FormMode.delete:
                    this.Text = "Dar de baja libro";
                    btnConfirmar.Text = "Dar de baja";
                    cargarDatosLibro(OLibroSeleccionado);
                    pnlEjemplares.Enabled = false;
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

            if (t1 && t2 && t3 && t4 && t5 && t6 && t7)
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
            switch (formMode)
            {
                case FormMode.insert:
                    if (validarCampos())
                    {

                        oLibroSeleccionado.IdLibro = Convert.ToInt32(txtIdLibro.Text);
                        oLibroSeleccionado.Titulo = txtTitulo.Text;
                        oLibroSeleccionado.AñoEdicion = Convert.ToInt32(txtAño.Text);
                        oLibroSeleccionado.IdGenero = Convert.ToInt32(cboGenero.SelectedValue);
                        oLibroSeleccionado.IdAutor = Convert.ToInt32(cboAutor.SelectedValue);
                        oLibroSeleccionado.IdEditorial = Convert.ToInt32(cboEditorial.SelectedValue);
                        oLibroSeleccionado.Sector = txtSector.Text;
                        oLibroSeleccionado.Estante = Convert.ToInt32(txtEstante.Text);
                                               
                       if(oLibroService.insertarNuevoLibro(ejemplares, oLibroSeleccionado))                        
                            {
                                MessageBox.Show("Se ha registrado correctamente el libro");
                                oSoporteForm.limpiarGrid(dgvEjemplaresRegistrados);
                                oSoporteForm.limpiarGrid(dgvEjemplaresNuevos);
                                dgvEjemplaresRegistrados.DataSource = oEjemplarService.obtenerEjemplaresPorLibro(OLibroSeleccionado.IdLibro);                                
                            }
                 
                        else
                        {
                            MessageBox.Show("El libro ya se encuentra registrado.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hay campos vacíos, por favor completelos");
                    }
                    break;

                case FormMode.update:
                    if (validarCampos())
                    {
                        OLibroSeleccionado.Titulo = txtTitulo.Text;
                        OLibroSeleccionado.AñoEdicion = Convert.ToInt32(txtAño.Text);
                        OLibroSeleccionado.IdGenero = Convert.ToInt32(cboGenero.SelectedValue);
                        OLibroSeleccionado.IdAutor = Convert.ToInt32(cboAutor.SelectedValue);
                        OLibroSeleccionado.IdEditorial = Convert.ToInt32(cboEditorial.SelectedValue);
                        OLibroSeleccionado.Sector = txtSector.Text;
                        OLibroSeleccionado.Estante = Convert.ToInt32(txtEstante.Text);
                        if (oLibroService.actualizarLibro(ejemplares, oLibroSeleccionado))
                        {
                            MessageBox.Show("Se ha registrado correctamente el libro");
                            oSoporteForm.limpiarGrid(dgvEjemplaresRegistrados);
                            oSoporteForm.limpiarGrid(dgvEjemplaresNuevos);
                            dgvEjemplaresRegistrados.DataSource = oEjemplarService.obtenerEjemplaresPorLibro(OLibroSeleccionado.IdLibro);
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error durante la registración.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hay campos vacíos, por favor completelos");
                    }
                    break;


                case FormMode.delete:
                   

                    if (MessageBox.Show("Seguro que desea dar de baja al libro seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {

                        if (oLibroService.darDeBajaLibro(OLibroSeleccionado.IdLibro))
                        {
                            MessageBox.Show("El libro seleccionado ha sido dado de baja correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error al intentar dar de baja el libro seleccionado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    break;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            int id = 0;
            //Sumamos tanto los ejemplares que ya agregamos como los que estamos agregando
            id += dgvEjemplaresRegistrados.Rows.Count + dgvEjemplaresNuevos.Rows.Count;    
            Ejemplar oEjemplar = new Ejemplar();
            oEjemplar.IdEjemplar = id+1;
            //Modifique el id libro ya que cuando no se creo ningun libro no sabemos a que id libro vamos a insertar SERIA el
            //caso del insert pero si es un update si sabemos 
            if (formMode == FormMode.insert)
            {
                oEjemplar.IdLibro = oLibroService.ObtenerProximoId();
            }
            else
            {
                oEjemplar.IdLibro = Convert.ToInt32(txtIdLibro.Text);
            }

            oEjemplar.IdEstadoEjemplar = oEstadoEjemplarService.obtenerEstadoEjemplarSinParametros("Disponible").IdEstadoEjemplar;
            ejemplares.Add(oEjemplar);
            dgvEjemplaresNuevos.Rows.Add(oEjemplar.IdEjemplar, oEstadoEjemplarService.obtenerEstadoEjemplarSinParametros("Disponible").Nombre);
        }

        

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            
            Ejemplar oEjemplar = new Ejemplar();

            //Para los ejemplares que todavia no estan registrados en la base de datos
            if (dgvEjemplaresNuevos.CurrentRow != null)
            {
                dgvEjemplaresNuevos.Rows.Remove(dgvEjemplaresNuevos.CurrentRow); //Que se elimine la fila seleccionada
                ejemplares.Remove(oEjemplar); //Lo saco de la lista
            }


            //Para los ejemplares ya registrados en la base de datos
            if (dgvEjemplaresRegistrados.CurrentRow!= null)
            {
                oEjemplar.IdEjemplar = Convert.ToInt32(dgvEjemplaresRegistrados.CurrentRow.Cells[0].Value); //Obtengo el id del seleccionado
                oEjemplar.IdLibro = Convert.ToInt32(txtIdLibro.Text); //Obtengo el id del libro al que pertenece
                string estado = dgvEjemplaresRegistrados.CurrentRow.Cells[1].Value.ToString(); //Obtengo el estado del ejemplar
                oEjemplar.IdEstadoEjemplar = oEstadoEjemplarService.obtenerEstadoEjemplarSinParametros(estado).IdEstadoEjemplar;//Busco el id del estado correspondiente
                if (estado == "Disponible") //Si no esta prestado lo puedo remover
                {
                    //Lo doy de baja en la base de datos
                    if (MessageBox.Show("Seguro que desea dar de baja al ejemplar seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {

                        if (oEjemplarService.darDeBajaEjemplar(oEjemplar))
                        {
                            MessageBox.Show("El ejemplar seleccionado ha sido dado de baja correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            oSoporteForm.limpiarGrid(dgvEjemplaresRegistrados);
                            oSoporteForm.limpiarGrid(dgvEjemplaresNuevos);

                            dgvEjemplaresRegistrados.DataSource = oEjemplarService.obtenerEjemplaresPorLibro(OLibroSeleccionado.IdLibro);

                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error al intentar dar de baja el ejemplar seleccionado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    //Lo saco del grid
                    dgvEjemplaresRegistrados.Rows.Remove(dgvEjemplaresRegistrados.CurrentRow);
                    
                    
                }
                else
                {
                    MessageBox.Show("Solo puede remover los ejemplares que se encuentren en estado disponible");
                }


            }
                
                
                
                


            

            
            

        }

    }
}
