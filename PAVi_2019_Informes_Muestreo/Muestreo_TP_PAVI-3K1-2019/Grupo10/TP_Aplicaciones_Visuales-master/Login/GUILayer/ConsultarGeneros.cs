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
    public partial class ConsultarGeneros : MetroFramework.Forms.MetroForm
    {
        GeneroService oGeneroService = new GeneroService();
        Genero oGenero = new Genero();
        private readonly SoporteForm oSoporteForm = new SoporteForm();
        public ConsultarGeneros()
        {
            InitializeComponent();
            
        }

        private void InitializeDataGridView()
        {
            dgvGenero.DataSource = null;
            dgvGenero.ColumnCount = 2;
            dgvGenero.ColumnHeadersVisible = true;
            dgvGenero.AutoGenerateColumns = false;
               
            dgvGenero.Columns[0].Name = "Código Genero";
            dgvGenero.Columns[0].DataPropertyName = "idGenero";
               
            dgvGenero.Columns[1].Name = "Nombre";
            dgvGenero.Columns[1].DataPropertyName = "nombre";


        }
        private void ConsultarGeneros_Load(object sender, EventArgs e)
        {
            dgvGenero.DataSource = oGeneroService.obtenerTodosPorTabla();
        }

        private void dgvAutor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ABMGeneros oABMGeneros = new ABMGeneros();
            oABMGeneros.FormMode1 = ABMGeneros.FormMode.insert;
            oABMGeneros.OGenero = oGenero;            
            oABMGeneros.ShowDialog();
            oSoporteForm.limpiarGrid(dgvGenero);
            dgvGenero.DataSource = oGeneroService.obtenerTodosPorTabla();
            oABMGeneros.Dispose();
        }

        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ABMGeneros oABMGeneros = new ABMGeneros();
            oABMGeneros.FormMode1 = ABMGeneros.FormMode.update;
            oABMGeneros.OGenero = oGenero;            
            oABMGeneros.ShowDialog();
            oSoporteForm.limpiarGrid(dgvGenero);
            dgvGenero.DataSource = oGeneroService.obtenerTodosPorTabla();
            oABMGeneros.Dispose();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ABMGeneros oABMGeneros = new ABMGeneros();
            oABMGeneros.FormMode1 = ABMGeneros.FormMode.delete;
            oABMGeneros.OGenero = oGenero;
            oABMGeneros.ShowDialog();
            oSoporteForm.limpiarGrid(dgvGenero);
            dgvGenero.DataSource = oGeneroService.obtenerTodosPorTabla();
            oABMGeneros.Dispose();
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
                parametros.Add("idGenero", Convert.ToInt32(txtId.Text));
            }

            InitializeDataGridView();
            dgvGenero.DataSource = oGeneroService.obtenerGenerosConParametros(parametros);
            if (dgvGenero.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void dgvBarrios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView tmp = (DataGridView)sender;
            if (tmp.CurrentRow == null)
            {
                return;
            }
            int id = Convert.ToInt32(tmp.CurrentRow.Cells[0].Value);
            oGenero = oGeneroService.obtenerGeneroConParametros(id);
            
        }

    }
}
