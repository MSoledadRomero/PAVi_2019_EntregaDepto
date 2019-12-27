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
using TP_Aplicaciones_Visuales.BusinessLayer;
using TP_Aplicaciones_Visuales.Soporte;

namespace TP_Aplicaciones_Visuales.GUILayer
{
    public partial class ConsultarCompra : MetroFramework.Forms.MetroForm
    {
        private readonly LibroService oLibroService;
        private readonly ProveedorService oProveedorService;
        private readonly CompraService oCompraService;
        private readonly DetalleCompraService oDetalleCompraService;
        private Compra oCompraSeleccionada;
        SoporteForm oSoporteForm = new SoporteForm();

        public ConsultarCompra()
        {
            InitializeComponent();
            oProveedorService = new ProveedorService();
            oLibroService = new LibroService();
            oCompraService = new CompraService();
            oCompraSeleccionada = new Compra();
        }
        private void ConsultarCompra_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            oSoporteForm.cargarCombo(cboProveedor, oProveedorService.obtenerProveedores("listarProveedores"));
            dgvCompras.DataSource = oCompraService.obtenerTodos();
        }

        private void InitializeDataGridView()
        {
            dgvCompras.DataSource = null;
            dgvCompras.ColumnCount = 3;
            dgvCompras.ColumnHeadersVisible = true;
            dgvCompras.AutoGenerateColumns = false;
            
            dgvCompras.Columns[0].Name = "Código Compra";
            dgvCompras.Columns[0].DataPropertyName = "IdCompra";

            dgvCompras.Columns[1].Name = "Fecha";
            dgvCompras.Columns[1].DataPropertyName = "FechaDeCompra";

                dgvCompras.Columns[2].Name = "Proveedor";
                dgvCompras.Columns[2].DataPropertyName = "OProveedor";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Dictionary<String, object> parametros = new Dictionary<String, object>();
            if (!string.IsNullOrEmpty(txtIdCompra.Text))
            {
                parametros.Add("idCompra", txtIdCompra.Text);
            }
            if (!string.IsNullOrEmpty(cboProveedor.Text))
            {             
                parametros.Add("idProveedor", Convert.ToInt32(cboProveedor.SelectedValue));
            
            }

            DateTime fecha;
            if (DateTime.TryParse(dtFecha.Text, out fecha))
            {

                parametros.Add("fechaCompra", fecha);
            }

            dgvCompras.DataSource = oCompraService.obtenerCompraConParametros(parametros);
            if (dgvCompras.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmCompra oFrmCompra = new frmCompra();
            oFrmCompra.ShowDialog();
            dgvCompras.DataSource = oCompraService.obtenerTodos();
            oFrmCompra.Dispose();
        }

        private Compra obtenerCompraSeleccionada()
        {
             if (dgvCompras.CurrentRow != null)
             {
                int id = Convert.ToInt32(dgvCompras.CurrentRow.Cells[0].Value);
                return oCompraService.obtenerCompraSinParametros(id);
             }
            return null;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmCompra oFrmCompra = new frmCompra();
            oFrmCompra.SeleccionarCompra(frmCompra.FormMode.update, obtenerCompraSeleccionada());
            oFrmCompra.ShowDialog();
            dgvCompras.DataSource = oCompraService.obtenerTodos();
            oFrmCompra.Dispose();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //oSoporteForm.limpiarGrid(dgvCompras);
            if (dgvCompras.CurrentRow != null)
            {
                Compra Compra = (Compra)dgvCompras.CurrentRow.DataBoundItem;
                oCompraService.darDeBajaCompra(Compra);
                dgvCompras.DataSource = oCompraService.obtenerTodos();
            }
          
        }
    }
}
