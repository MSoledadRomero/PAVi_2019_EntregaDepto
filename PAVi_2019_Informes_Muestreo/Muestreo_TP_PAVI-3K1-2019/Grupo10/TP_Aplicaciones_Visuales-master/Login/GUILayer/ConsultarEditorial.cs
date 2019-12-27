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
    public partial class ConsultarEditorial : MetroFramework.Forms.MetroForm
    {
        EditorialService oEditorialService = new EditorialService();
        Editorial oEditorial = new Editorial();
        private readonly SoporteForm oSoporteForm = new SoporteForm();

        public ConsultarEditorial()
        {
            InitializeComponent();
           
        }

        private void InitializeDataGridView()
        {
            dgvEditorial.DataSource = null;
            dgvEditorial.ColumnCount = 2;
            dgvEditorial.ColumnHeadersVisible = true;
            dgvEditorial.AutoGenerateColumns = false;
            
            dgvEditorial.Columns[0].Name = "Código Editorial";
            dgvEditorial.Columns[0].DataPropertyName = "idEditorial";
            
            dgvEditorial.Columns[1].Name = "Nombre";
            dgvEditorial.Columns[1].DataPropertyName = "nombreEditorial";


        }

        private void ConsultarEditorial_Load(object sender, EventArgs e)
        {
            dgvEditorial.DataSource = oEditorialService.obtenerTodosPorTabla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ABMEditorial oABMEditorial = new ABMEditorial();
            oABMEditorial.FormMode1 = ABMEditorial.FormMode.insert;            
            oABMEditorial.cargarEditorial();
            oABMEditorial.ShowDialog();
            oSoporteForm.limpiarGrid(dgvEditorial);
            dgvEditorial.DataSource = oEditorialService.obtenerTodos();
            oABMEditorial.Dispose();
        }

  
        private void btnEditar_Click(object sender, EventArgs e)
        {
            ABMEditorial oABMEditorial = new ABMEditorial();
            oABMEditorial.FormMode1 = ABMEditorial.FormMode.update;            
            oABMEditorial.OEditorial = oEditorial;            
            oABMEditorial.ShowDialog();
            oSoporteForm.limpiarGrid(dgvEditorial);
            dgvEditorial.DataSource = oEditorialService.obtenerTodosPorTabla();
            oABMEditorial.Dispose();
        }



        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ABMEditorial oABMEditorial = new ABMEditorial();
            oABMEditorial.FormMode1 = ABMEditorial.FormMode.delete;
            oABMEditorial.OEditorial = oEditorial;
            oABMEditorial.ShowDialog();
            oSoporteForm.limpiarGrid(dgvEditorial);
            dgvEditorial.DataSource = oEditorialService.obtenerTodosPorTabla();
            oABMEditorial.Dispose();
        }



        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Dictionary<String, object> parametros = new Dictionary<String, object>();

            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                parametros.Add("nombreEditorial", txtNombre.Text);
            }
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                parametros.Add("idEditorial", Convert.ToInt32(txtId.Text));
            }
            InitializeDataGridView();
            dgvEditorial.DataSource = oEditorialService.obtenerEditorialConParametros(parametros);
            if (dgvEditorial.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void dgvEditorial_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView tmp = (DataGridView)sender;
            if (tmp.CurrentRow == null)
            {
                return;
            }
            int id = Convert.ToInt32(tmp.CurrentRow.Cells[0].Value);
            oEditorial = oEditorialService.obtenerEditorialConParametros(id);            

        }

    }
}
