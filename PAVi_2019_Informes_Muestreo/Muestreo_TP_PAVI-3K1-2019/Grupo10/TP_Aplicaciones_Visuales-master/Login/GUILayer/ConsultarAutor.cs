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
using TP_Aplicaciones_Visuales.Soporte;
using TP_Aplicaciones_Visuales.Entities;


namespace TP_Aplicaciones_Visuales.GUILayer
{
    public partial class frmConsultarAutor : MetroFramework.Forms.MetroForm
    {
        private readonly AutorService oAutorService = new AutorService();
        private Autor oAutor = new Autor();
        private readonly SoporteForm oSoporteForm = new SoporteForm();

        public frmConsultarAutor()
        {
            InitializeComponent();
            
        }
        private void InitializeDataGridView()
        {
            dgvAutor.DataSource = null;
            dgvAutor.ColumnCount = 2;
            dgvAutor.ColumnHeadersVisible = true;            
            dgvAutor.AutoGenerateColumns = false; 
            
            dgvAutor.Columns[0].Name = "Código Autor";
            dgvAutor.Columns[0].DataPropertyName = "idAutor";          

            dgvAutor.Columns[1].Name = "Nombre";
            dgvAutor.Columns[1].DataPropertyName = "nombre";
            
        }

      
        private void frmConsultarAutor_Load(object sender, EventArgs e)
        {
            
            dgvAutor.DataSource = oAutorService.obtenerTodosPorTabla();
            
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmABMAutor oABMOAutor = new frmABMAutor();
            oABMOAutor.FormMode1 = frmABMAutor.FormMode.insert;       
            
            oABMOAutor.ShowDialog();
            oSoporteForm.limpiarGrid(dgvAutor);
            dgvAutor.DataSource = oAutorService.obtenerTodosPorTabla();
            oABMOAutor.Dispose();
        }

        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmABMAutor oABMOAutor = new frmABMAutor();
            oABMOAutor.FormMode1 = frmABMAutor.FormMode.update;
            oABMOAutor.OAutor = oAutor;
            
            oABMOAutor.ShowDialog();
            oSoporteForm.limpiarGrid(dgvAutor);
            dgvAutor.DataSource = oAutorService.obtenerTodosPorTabla();
            oABMOAutor.Dispose();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            frmABMAutor oABMOAutor = new frmABMAutor();
            oABMOAutor.FormMode1 = frmABMAutor.FormMode.delete;
            oABMOAutor.OAutor = oAutor;
            oABMOAutor.ShowDialog();
            oSoporteForm.limpiarGrid(dgvAutor);
            dgvAutor.DataSource = oAutorService.obtenerTodosPorTabla();
            oABMOAutor.Dispose();
        }

     

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Dictionary<String, object> parametros = new Dictionary<String, object>();

            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                parametros.Add("nombre", txtNombre.Text);
            }
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                parametros.Add("idAutor", Convert.ToInt32(txtId.Text));
            }
            InitializeDataGridView();
            dgvAutor.DataSource = oAutorService.obtenerAutoresConParametros(parametros);
            if (dgvAutor.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void dgvAutor_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView tmp = (DataGridView)sender;
            if (tmp.CurrentRow == null)
            {
                return;
            }
            int id = Convert.ToInt32(tmp.CurrentRow.Cells[0].Value);
            oAutor = oAutorService.obtenerAutoresConParametros(id);
        }
    }
}
