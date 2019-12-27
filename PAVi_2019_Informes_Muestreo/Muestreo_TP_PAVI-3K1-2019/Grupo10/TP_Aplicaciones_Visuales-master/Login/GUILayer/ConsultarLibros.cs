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
    public partial class frmConsultarLibros : MetroFramework.Forms.MetroForm 
    {
        private Libro seleccionado;
        private LibroService oLibroService;
        private AutorService oAutorService;
        private GeneroService oGeneroService;
        private EditorialService oEditorialService;
        private readonly SoporteForm oSoporteForm;

        internal Libro Seleccionado { get => seleccionado; set => seleccionado = value; }

        public frmConsultarLibros()
        {
            InitializeComponent();
            seleccionado = new Libro();
            oLibroService = new LibroService();
            oAutorService = new AutorService();
            oGeneroService = new GeneroService();
            oEditorialService = new EditorialService();
            oSoporteForm = new SoporteForm();
                     
        }



        private void InitializeDataGridView()
        {
            dgvLibros.DataSource = null;
            dgvLibros.ColumnCount = 8;
            dgvLibros.ColumnHeadersVisible = true;
            dgvLibros.AutoGenerateColumns = false;
               
            dgvLibros.Columns[0].Name = "Código";
            dgvLibros.Columns[0].DataPropertyName = "idLibro";
               
            dgvLibros.Columns[1].Name = "Titulo";
            dgvLibros.Columns[1].DataPropertyName = "titulo";

            dgvLibros.Columns[2].Name = "Edición";
            dgvLibros.Columns[2].DataPropertyName = "añoEdicion";

            dgvLibros.Columns[3].Name = "Género";
            dgvLibros.Columns[3].DataPropertyName = "idGenero";

            dgvLibros.Columns[4].Name = "Autor";
            dgvLibros.Columns[4].DataPropertyName = "idAutor";

            dgvLibros.Columns[5].Name = "Editorial";
            dgvLibros.Columns[5].DataPropertyName = "idEditorial";
        
            dgvLibros.Columns[6].Name = "Sector";
            dgvLibros.Columns[6].DataPropertyName = "sector";

            dgvLibros.Columns[7].Name = "Estante";
            dgvLibros.Columns[7].DataPropertyName = "estante";



        }

        private void habilitar(bool x)
        {

            //btnNuevo.Enabled = !x;
            //btnEditar.Enabled = !x;
            //btnBorrar.Enabled = !x;
            btnSalir.Enabled = !x;
        }


        private void frmConsultarLibros_Load(object sender, EventArgs e)
        {
            
           oSoporteForm.cargarCombo(cboAutor, oAutorService.obtenerAutores("listarAutores"));
           oSoporteForm.cargarCombo(cboEditorial, oEditorialService.obtenerEditoriales("listarEditoriales"));
           oSoporteForm.cargarCombo(cboGenero, oGeneroService.obtenerGeneros("listarGeneros"));

            dgvLibros.DataSource = oLibroService.obtenerTodosPorTabla();
            
            
        }

                                    





       
        private void btnConsultar_Click(object sender, EventArgs e)
        {
                
                Dictionary<string, object> parametros = new Dictionary<string, object>();

                if (!string.IsNullOrEmpty(txtTitulo.Text))
                {
                   parametros.Add("tituloLibro", txtTitulo.Text);
                }
                if (!string.IsNullOrEmpty(txtAño.Text))
                {
                    var año = Convert.ToString(txtAño.Text);                    
                    parametros.Add("añoEdicion", año);
                }
                if (!string.IsNullOrEmpty(cboGenero.Text))
                {                             
                    parametros.Add("genero", cboGenero.SelectedValue);
                }
                if (!string.IsNullOrEmpty(cboAutor.Text))
                {                   
                    parametros.Add("autor", cboAutor.SelectedValue);
                }
                if (!string.IsNullOrEmpty(cboEditorial.Text))
                {                   
                    parametros.Add("editorial", cboEditorial.SelectedValue);
                }
                InitializeDataGridView();  
                dgvLibros.DataSource = oLibroService.obtenerLibrosConParametros(parametros);
                if (dgvLibros.Rows.Count==0)
                {
                    MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ABMLibro oABMLibro = new ABMLibro();
            oABMLibro.FormMode1 = ABMLibro.FormMode.insert;
            oABMLibro.ShowDialog();
            //No hace falta limpiar una grilla si la vas a actualizar
            //oSoporteForm.limpiarGrid(dgvLibros);
            dgvLibros.DataSource = oLibroService.obtenerTodosPorTabla();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            ABMLibro oABMLibro = new ABMLibro();
            oABMLibro.OLibroSeleccionado=seleccionado;
            oABMLibro.FormMode1 = ABMLibro.FormMode.update;
            oABMLibro.ShowDialog();
            oSoporteForm.limpiarGrid(dgvLibros);
            dgvLibros.DataSource = oLibroService.obtenerTodosPorTabla();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
           
            ABMLibro oABMLibro = new ABMLibro();
            oABMLibro.FormMode1 = ABMLibro.FormMode.delete;
            oABMLibro.OLibroSeleccionado = seleccionado;
            oABMLibro.ShowDialog();
            oSoporteForm.limpiarGrid(dgvLibros);
            dgvLibros.DataSource = oLibroService.obtenerTodosPorTabla();
        }

        private void grdLibros_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvLibros.SelectedColumns!=null && dgvLibros.SelectedRows!=null)
            {
                int idLibroSeleccionado = Convert.ToInt32(dgvLibros.CurrentRow.Cells[0].Value.ToString());
                seleccionado = oLibroService.obtenerLibrosConParametros(idLibroSeleccionado);
            }            
            
        }

      

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
