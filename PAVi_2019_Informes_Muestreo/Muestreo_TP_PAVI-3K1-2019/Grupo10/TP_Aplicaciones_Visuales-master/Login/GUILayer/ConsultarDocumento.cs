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
    public partial class ConsultarDocumento : MetroFramework.Forms.MetroForm
    {

        TipoDocumentoService oDocumentoService = new TipoDocumentoService();
        TipoDocumento ODocumento = new TipoDocumento();
        private readonly SoporteForm oSoporteForm = new SoporteForm();

        public ConsultarDocumento()
        {
            InitializeComponent();
            
        }


        private void InitializeDataGridView()
        {
            dgvDocumentos.DataSource = null;
            dgvDocumentos.ColumnCount = 2;
            dgvDocumentos.ColumnHeadersVisible = true;
            dgvDocumentos.AutoGenerateColumns = false;
            
            dgvDocumentos.Columns[0].Name = "Código Tipo Doc.";
            dgvDocumentos.Columns[0].DataPropertyName = "idTipoDoc";
            
            dgvDocumentos.Columns[1].Name = "Nombre";
            dgvDocumentos.Columns[1].DataPropertyName = "nombre";            

        }
        public void limpiarGrid()
        {
            dgvDocumentos.DataSource = null;
            dgvDocumentos.AutoGenerateColumns = true;
            dgvDocumentos.Columns.Clear();
            dgvDocumentos.Rows.Clear();
        }
        private void ConsultarDocumentos_Load(object sender, EventArgs e)
        {
            dgvDocumentos.DataSource = oDocumentoService.obtenerTodosPorTabla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ABMDocumento oABMDocumento = new ABMDocumento();
            oABMDocumento.FormMode1 = ABMDocumento.FormMode.insert;
            oABMDocumento.OTipoDocumento = ODocumento;            
            oABMDocumento.ShowDialog();
            limpiarGrid();
            dgvDocumentos.DataSource = oDocumentoService.obtenerTodosPorTabla();
            oABMDocumento.Dispose();
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            ABMDocumento oABMDocumento = new ABMDocumento();
            oABMDocumento.FormMode1 = ABMDocumento.FormMode.update;
            oABMDocumento.OTipoDocumento = ODocumento;
            oABMDocumento.ShowDialog();
            limpiarGrid();
            dgvDocumentos.DataSource = oDocumentoService.obtenerTodosPorTabla();
            oABMDocumento.Dispose();
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ABMDocumento oABMDocumento = new ABMDocumento();
            oABMDocumento.FormMode1 = ABMDocumento.FormMode.delete;
            oABMDocumento.OTipoDocumento = ODocumento;
            oABMDocumento.ShowDialog();
            limpiarGrid();
            dgvDocumentos.DataSource = oDocumentoService.obtenerTodosPorTabla();
            oABMDocumento.Dispose();
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
                parametros.Add("idTipoDoc", Convert.ToInt32(txtId.Text));
            }
            InitializeDataGridView();
            dgvDocumentos.DataSource = oDocumentoService.obtenerTipoDocumentoConParametros(parametros);
            if (dgvDocumentos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void dgvDocumentos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView tmp = (DataGridView)sender;
            if (tmp.CurrentRow == null)
            {
                return;
            }
            int id = Convert.ToInt32(tmp.CurrentRow.Cells[0].Value);
            ODocumento = oDocumentoService.obtenerTipoDocumentoConParametros(id);
            
        }

    }
}
