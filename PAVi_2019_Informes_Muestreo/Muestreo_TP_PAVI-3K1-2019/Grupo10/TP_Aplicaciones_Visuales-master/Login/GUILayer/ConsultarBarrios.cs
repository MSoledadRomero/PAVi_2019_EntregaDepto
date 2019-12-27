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
    public partial class ConsultarBarrios : MetroFramework.Forms.MetroForm
    {
        private BarrioService oBarrioService = new BarrioService();
        private CiudadService oCiudadService = new CiudadService();
        private Barrio oBarrio = new Barrio();
        private SoporteForm oSoporteForm = new SoporteForm();
        public ConsultarBarrios()
        {
            InitializeComponent();
            
        }
        
        private void InitializeDataGridView()
        {
            dgvBarrios.DataSource = null;
            dgvBarrios.ColumnCount = 3;
            dgvBarrios.ColumnHeadersVisible = true;
            dgvBarrios.AutoGenerateColumns = false;
            
            dgvBarrios.Columns[0].Name = "Código Barrio";
            dgvBarrios.Columns[0].DataPropertyName = "idBarrio";

            dgvBarrios.Columns[1].Name = "Barrio";
            dgvBarrios.Columns[1].DataPropertyName = "nombre";
            
            dgvBarrios.Columns[2].Name = "Ciudad";
            dgvBarrios.Columns[2].DataPropertyName = "nombre1";

        } 
    
        private void ConsultarBarrios_Load(object sender, EventArgs e)
        {
            oSoporteForm.cargarCombo(cboCiudad, oCiudadService.obtenerCiudades("listarCiudades"));
            dgvBarrios.DataSource = oBarrioService.obtenerTodosPorTabla(); 
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ABMBarrios oABMBarrios = new ABMBarrios();
            oABMBarrios.FormMode1 = ABMBarrios.FormMode.insert;
            oABMBarrios.OBarrio = oBarrio;           
            oABMBarrios.ShowDialog();
            oSoporteForm.limpiarGrid(dgvBarrios);
            dgvBarrios.DataSource = oBarrioService.obtenerTodosPorTabla();
            oABMBarrios.Dispose();
        }
       
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ABMBarrios oABMBarrios = new ABMBarrios();
            oABMBarrios.FormMode1 = ABMBarrios.FormMode.delete;
            oABMBarrios.OBarrio = oBarrio;            
            oABMBarrios.ShowDialog();
            oSoporteForm.limpiarGrid(dgvBarrios);
            dgvBarrios.DataSource = oBarrioService.obtenerTodosPorTabla();
            oABMBarrios.Dispose();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ABMBarrios oABMBarrios = new ABMBarrios();
            oABMBarrios.FormMode1 = ABMBarrios.FormMode.update;
            oABMBarrios.OBarrio = oBarrio;           
            oABMBarrios.ShowDialog();
            oSoporteForm.limpiarGrid(dgvBarrios);
            dgvBarrios.DataSource = oBarrioService.obtenerTodosPorTabla();
            oABMBarrios.Dispose();
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
                parametros.Add("idBarrio", Convert.ToInt32(txtId.Text));
            }
            if (!string.IsNullOrEmpty(cboCiudad.Text))
            {
                parametros.Add("idCiudad", Convert.ToInt32(cboCiudad.SelectedValue));
            }
            InitializeDataGridView();
            dgvBarrios.DataSource = oBarrioService.obtenerBarriosConParametros(parametros);
            if (dgvBarrios.Rows.Count == 0)
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
            oBarrio = oBarrioService.obtenerBarriosConParametros(id);
            
        }

       
    }
}
