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
    public partial class frmPrestamo : MetroFramework.Forms.MetroForm
    {
        private readonly PrestamoService oPrestamoService;
        private EstadoPrestamoService oEstadoPrestamoService;
        private Prestamo oPrestamoSeleccionado;
        private Socio oSocio;
        private SocioService oSocioService = new SocioService();
        private SoporteForm oSoporteForm = new SoporteForm();

        internal Socio OSocio { get => oSocio; set => oSocio = value; }
        
        public frmPrestamo()
        {
            InitializeComponent();
            oPrestamoService = new PrestamoService();
            oEstadoPrestamoService = new EstadoPrestamoService();

    }

        private void frmPrestamo_Load(object sender, EventArgs e)
        {
            //LlenarCombo(cboSocio, oSocioService.obtenerTodos(), "idSocio", "idSocio");
            //LlenarCombo(cboLibro, oLibroService.obtenerTodos(), "idLibro", "idLibro");
            //dgvPrestamos.DataSource = oPrestamoService.obtenerPorID(OSocio.IdSocio);
            // CARGAR CLASE ESTADO PRESTAMO
            oSoporteForm.cargarCombo(cboEstado, oEstadoPrestamoService.obtenerTodos());

            //DateTime dt1 = new DateTime();

            //dt1 = Convert.ToDateTime(dt1.ToString("MM/dd/yyyy"));

        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvPrestamo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Enabled = true;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //InicializarFormulario()
        }

        public bool validarSocio()
        {
            if (dgvPrestamos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un socio", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Dictionary<String, Object> parametros = new Dictionary<string, object>();
            DateTime fechaLimite;
            DateTime fechaPrestamo;
            if (DateTime.TryParse(txtFechaPrestamo.Text, out fechaPrestamo))
            {
                parametros.Add("fechaPrestamo", fechaPrestamo);
            }
            if(DateTime.TryParse(txtFechaLimite.Text, out fechaLimite)){
                parametros.Add("fechaLimite", fechaLimite);
            }
            if (!string.IsNullOrEmpty(cboEstado.Text))
            {
                parametros.Add("idEstadoPrestamo", cboEstado.SelectedValue);
            }
            if (!string.IsNullOrEmpty(txtIDSocio.Text))
            {
                parametros.Add("idSocio", txtIDSocio.Text);
            }
            if (!string.IsNullOrEmpty(txtIDPrestamo.Text))
            {
                parametros.Add("idPrestamo", Convert.ToInt32(txtIDPrestamo.Text));
            }

            dgvPrestamos.DataSource = oPrestamoService.obtenerPrestamoConParametros(parametros);
            if (dgvPrestamos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            frmConsultarSocio oFrmConsultarSocio = new frmConsultarSocio();
            oFrmConsultarSocio.ShowDialog();
            
            txtIDSocio.Text = oFrmConsultarSocio.Seleccionado.IdSocio.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (validarSocio())
            {
                int idPrestamo = Convert.ToInt32(dgvPrestamos.CurrentRow.Cells[0].Value);
                
                oPrestamoSeleccionado = oPrestamoService.obtenerPorIDPrestamo(idPrestamo);
                ABMPrestamos oABMPrestamos = new ABMPrestamos();
                oABMPrestamos.SeleccionarPrestamo(ABMPrestamos.FormMode.update, oPrestamoSeleccionado);
                oABMPrestamos.ShowDialog();
                dgvPrestamos.DataSource = oPrestamoService.obtenerPrestamoConParametros(new Dictionary<string, object>());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validarSocio())
            {

                int idPrestamo = Convert.ToInt32(dgvPrestamos.CurrentRow.Cells[0].Value);
                oPrestamoSeleccionado = oPrestamoService.obtenerPorIDPrestamo(idPrestamo);
                int idSocio = oPrestamoSeleccionado.IdSocio;
                ABMPrestamos oABMPrestamos = new ABMPrestamos();
                
                oABMPrestamos.insetarPrestamoA(idSocio);
                oABMPrestamos.ShowDialog();   
                
            }
            

        }
    }
}
