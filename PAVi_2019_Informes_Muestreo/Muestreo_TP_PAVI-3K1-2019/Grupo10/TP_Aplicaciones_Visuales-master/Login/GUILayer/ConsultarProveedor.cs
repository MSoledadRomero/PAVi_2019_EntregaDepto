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
    public partial class ConsultarProveedor : MetroFramework.Forms.MetroForm
    {

        private ProveedorService oProveedorService = new ProveedorService();
        private BarrioService oBarrioService = new BarrioService();
        private Proveedor oProveedor = new Proveedor();
        SoporteForm oSoporteForm = new SoporteForm();
        public ConsultarProveedor()
        {
            InitializeComponent();
            
        }

        private void InitializeDataGridView()
        {
            dgvProveedor.DataSource = null;
            dgvProveedor.ColumnCount = 7;
            dgvProveedor.ColumnHeadersVisible = true;
            dgvProveedor.AutoGenerateColumns = false;
               
            dgvProveedor.Columns[0].Name = "Código";
            dgvProveedor.Columns[0].DataPropertyName = "idProveedor";
               
            dgvProveedor.Columns[4].Name = "Barrio";
            dgvProveedor.Columns[4].DataPropertyName = "nombre";

            dgvProveedor.Columns[1].Name = "Razón Social";
            dgvProveedor.Columns[1].DataPropertyName = "razonSocial";

            dgvProveedor.Columns[2].Name = "Teléfono";
            dgvProveedor.Columns[2].DataPropertyName = "telefono";

            dgvProveedor.Columns[3].Name = "Mail";
            dgvProveedor.Columns[3].DataPropertyName = "mail";

            dgvProveedor.Columns[5].Name = "Calle";
            dgvProveedor.Columns[5].DataPropertyName = "calle";

            dgvProveedor.Columns[6].Name = "Altura";
            dgvProveedor.Columns[6].DataPropertyName = "nro";

        }

        private void ConsultarProveedor_Load(object sender, EventArgs e)
        {            
            oSoporteForm.cargarCombo(cboBarrio, oBarrioService.obtenerBarrios("listarBarrios"));
            dgvProveedor.DataSource = oProveedorService.obtenerTodosPorTabla();     
            
        }

        private void dgvProveedor_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView tmp = (DataGridView)sender;
            if (tmp.CurrentRow == null)
            {
                return;
            }
            int id = Convert.ToInt32(tmp.CurrentRow.Cells[0].Value);
            oProveedor = oProveedorService.obtenerProveedorSinParametros(id);            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ABMProveedor oABMProveedor = new ABMProveedor();
            oABMProveedor.FormMode1 = ABMProveedor.FormMode.insert;
            oABMProveedor.OProveedor = oProveedor;            
            oABMProveedor.ShowDialog();
            oSoporteForm.limpiarGrid(dgvProveedor);
            dgvProveedor.DataSource = oProveedorService.obtenerTodosPorTabla();
            oABMProveedor.Dispose();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ABMProveedor oABMProveedor = new ABMProveedor();
            oABMProveedor.FormMode1 = ABMProveedor.FormMode.delete;
            oABMProveedor.OProveedor = oProveedor;            
            oABMProveedor.ShowDialog();
            oSoporteForm.limpiarGrid(dgvProveedor);
            dgvProveedor.DataSource = oProveedorService.obtenerTodosPorTabla();
            oABMProveedor.Dispose();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ABMProveedor oABMProveedor = new ABMProveedor();
            oABMProveedor.FormMode1 = ABMProveedor.FormMode.update;
            oABMProveedor.OProveedor = oProveedor;            
            oABMProveedor.ShowDialog();
            oSoporteForm.limpiarGrid(dgvProveedor);
            dgvProveedor.DataSource = oProveedorService.obtenerTodosPorTabla();
            oABMProveedor.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            Dictionary<String, object> parametros = new Dictionary<String, object>();
            if (!string.IsNullOrEmpty(txtCalle.Text))
            {
                parametros.Add("calle", txtCalle.Text);
            }
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                var id = Convert.ToInt32(txtId.Text);
                parametros.Add("idProveedor", id);
            }
            if (!string.IsNullOrEmpty(txtMail.Text))
            {
                parametros.Add("mail", txtMail.Text);
            }
            if (!string.IsNullOrEmpty(txtNumero.Text))
            {
                var numero = Convert.ToInt32(txtNumero.Text);
                parametros.Add("nro", numero);
            }
            if (!string.IsNullOrEmpty(txtRazonSocial.Text))
            {
                parametros.Add("razonSocial", txtRazonSocial.Text);
            }
            if (!string.IsNullOrEmpty(txtTelefono.Text))
            {
                var telefono = Convert.ToInt32(txtTelefono.Text);
                parametros.Add("telefono", telefono);
            }
            if (!string.IsNullOrEmpty(cboBarrio.Text))
            {
                var idBarrio = Convert.ToInt32(cboBarrio.SelectedValue);
                parametros.Add("idBarrio", idBarrio);
            }
            InitializeDataGridView();
            dgvProveedor.DataSource = oProveedorService.obtenerProveedoresConParametros(parametros);
            if (dgvProveedor.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
