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
    public partial class frmCompra : MetroFramework.Forms.MetroForm
    {

        private DetalleCompraService oDetalleCompraService;
        private FormMode formMode = FormMode.insert;
        private Compra compraSeleccionada;
        private readonly SoporteForm oSoporteForm;
        private readonly ProveedorService oProveedorService;
        private readonly CompraService oCompraService;
        private LibroService oLibroService;
        private readonly EjemplarService oEjemplarService;
        private EstadoEjemplarService oEstadoEjemplarService;
        //Estos son los datos que voy a necesitar para registrar la compra pero que se registran en otros formularios
        private Proveedor oProveedor;
        private bool nuevo;
        public frmCompra()
        {
            InitializeComponent();
            compraSeleccionada = new Compra();
            oSoporteForm = new SoporteForm();
            oProveedorService = new ProveedorService();
            oLibroService = new LibroService();
            oCompraService = new CompraService();
            oEjemplarService = new EjemplarService();
            oEstadoEjemplarService = new EstadoEjemplarService();
            oProveedor = new Proveedor();
            oDetalleCompraService = new DetalleCompraService();
            formMode = FormMode.insert;
            nuevo = true;
        }


        private void frmCompra_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            txtIdCompra.Enabled = false;
            dgvDetalleCompra.DataSource = oDetalleCompraService.ConsultarPorIdCompra(compraSeleccionada.IdCompra);
            //oSoporteForm.cargarCombo(cboLibro, oLibroService.obtenerLibros("listarLibros"));
            oSoporteForm.cargarCombo(cboProveedor, oProveedorService.obtenerProveedores("listarProveedores"));

            switch (formMode)
            {
                case FormMode.insert:

                    this.Text = "Nueva Compra";
                    txtIdCompra.Text = oCompraService.ObtenerProximoId().ToString();
                    compraSeleccionada.IdCompra = Convert.ToInt32(txtIdCompra.Text.ToString());
                    habilitarDeshabilitar(true);
                    break;
                case FormMode.update:

                    txtIdCompra.Text = compraSeleccionada.IdCompra.ToString();
                    dgvDetalleCompra.DataSource = oDetalleCompraService.ConsultarPorIdCompra(compraSeleccionada.IdCompra);
                    this.Text = "Modificar Compra";
                   
                    habilitarDeshabilitar(true);
                    cargarDatosFrm();
                    break;
                case FormMode.delete:

                    this.Text = "Dar de baja Compra";
                    cargarDatosFrm();
                    habilitarDeshabilitar(false);
                    break;
            }
        }
        public void SeleccionarCompra(FormMode op, Compra compraSelected)
        {
            formMode = op;
            compraSeleccionada = compraSelected;
        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }
        private void cargarDatosFrm()
        {
            cboProveedor.SelectedValue = compraSeleccionada.OProveedor.IdProveedor.ToString();              
        }
        private void cargarDatosCompra()
        {
            compraSeleccionada.OProveedor.IdProveedor = Convert.ToInt32(cboProveedor.SelectedValue.ToString());
        }
        private void habilitarDeshabilitar(bool x)
        {         
            cboProveedor.Enabled = x;
        }
        private bool validarCampos()
        {
            bool t4 = oSoporteForm.validarCombo(cboProveedor);
            //Validamos que se alla cargado por lo menos un libro
            bool t5 = true;
            //if (dgvDetalleCompra.Rows.Count == 0)
            //{
            //    t5 = false;
            //}
            return t4 && t5;
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            
            dgvDetalleCompra.ColumnHeadersVisible = true;
            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvDetalleCompra.AutoGenerateColumns = false;
            dgvDetalleCompra.ColumnCount = 2;
            // Cambia el estilo de la cabecera de la grilla.
            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            // Definimos el ancho de la columna.
            dgvDetalleCompra.Columns[0].Name = "Nombre de libro";
            dgvDetalleCompra.Columns[0].DataPropertyName = "Libro";
            dgvDetalleCompra.Columns[0].Width = (dgvDetalleCompra.Width - 40) / 2;
            dgvDetalleCompra.Columns[1].Name = "Cantidad";
            dgvDetalleCompra.Columns[1].DataPropertyName = "Cantidad";
            dgvDetalleCompra.Columns[1].Width = (dgvDetalleCompra.Width - 40) / 2;
            // Cambia el tamaño de la altura de los encabezados de columna.
            //dgvDetalleCompra.AutoResizeColumnHeadersHeight();
            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            //dgvDetalleCompra.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvDetalleCompra.CurrentRow != null)
            {
                //Obtenemos el libro del detalleCompra
                DetalleCompra oDetalleCompra = (DetalleCompra)dgvDetalleCompra.CurrentRow.DataBoundItem;
                ABMDetalleCompra oABMDetalleCompra = new ABMDetalleCompra();
                
                oABMDetalleCompra.SeleccionarDetalleCompra(ABMDetalleCompra.FormMode.update, oDetalleCompra);
                oABMDetalleCompra.ShowDialog();
                dgvDetalleCompra.DataSource = null;
                dgvDetalleCompra.DataSource = oDetalleCompraService.ConsultarPorIdCompra(compraSeleccionada.IdCompra);
            }
        }

        private void btnEliminarDetalleCompra_Click(object sender, EventArgs e)
        {
            if (dgvDetalleCompra.CurrentRow != null)
            {
                DetalleCompra oDetalleCompra = (DetalleCompra)dgvDetalleCompra.CurrentRow.DataBoundItem;
               
                oDetalleCompraService.deleteForId(oDetalleCompra.IdDetalleCompra);
                dgvDetalleCompra.DataSource = null;
                dgvDetalleCompra.DataSource = oDetalleCompraService.ConsultarPorIdCompra(oDetalleCompra.IdCompra);
            }
        }
        private void btnAgregarDetalleCompra_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {

                if (nuevo)
                {
                    compraSeleccionada.OProveedor = new Proveedor();

                    compraSeleccionada.OProveedor.IdProveedor = Convert.ToInt32(cboProveedor.SelectedValue.ToString());
                    compraSeleccionada.IdCompra = Convert.ToInt32(txtIdCompra.Text.ToString());
                    oCompraService.insert(compraSeleccionada);
                    nuevo = false;
                }
                

                DetalleCompra oDetalleCompra = new DetalleCompra
                {
                    IdCompra = compraSeleccionada.IdCompra,

                };
                ABMDetalleCompra frmDetalleCompra = new ABMDetalleCompra();
                frmDetalleCompra.SeleccionarDetalleCompra(ABMDetalleCompra.FormMode.insert, oDetalleCompra);

                frmDetalleCompra.ShowDialog();
                // creamos un detalle compra 


                dgvDetalleCompra.DataSource = null;
                dgvDetalleCompra.DataSource = oDetalleCompraService.ConsultarPorIdCompra(compraSeleccionada.IdCompra);
                frmDetalleCompra.Dispose();
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            cargarDatosCompra();
            oCompraService.update(compraSeleccionada);
            if (oDetalleCompraService.ConsultarPorIdCompra(compraSeleccionada.IdCompra).Count == 0)
            {
                oCompraService.darDeBajaCompra(compraSeleccionada);
            }
            this.Close();
            this.Dispose();
        }
    }
}
