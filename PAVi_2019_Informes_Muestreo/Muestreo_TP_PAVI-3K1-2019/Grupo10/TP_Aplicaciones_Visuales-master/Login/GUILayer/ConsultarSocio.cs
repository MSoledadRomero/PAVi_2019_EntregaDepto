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
    public partial class frmConsultarSocio : MetroFramework.Forms.MetroForm
    {
        private readonly UsuarioService oUsuarioService;
        private readonly TipoDocumentoService oTipoDocService;
        private readonly BarrioService oBarrioService;
        private readonly SocioService oSocioService;
        private Socio seleccionado;
        private readonly SoporteForm oSoporteForm;

        internal Socio Seleccionado { get => seleccionado; set => seleccionado = value; }

        public frmConsultarSocio()
        {
            InitializeComponent();
            oUsuarioService = new UsuarioService();
            oTipoDocService = new TipoDocumentoService();
            oBarrioService = new BarrioService();
            oSocioService = new SocioService();
            Seleccionado = new Socio();
            oSoporteForm = new SoporteForm();
            
        }


        private void InitializeDataGridView()
        {
            dgvSocios.DataSource = null;
            dgvSocios.ColumnCount = 10;
            dgvSocios.ColumnHeadersVisible = true;
            dgvSocios.AutoGenerateColumns = false;
              
            dgvSocios.Columns[0].Name = "Código";
            dgvSocios.Columns[0].DataPropertyName = "idSocio";
              
            dgvSocios.Columns[3].Name = "Tipo Doc.";
            dgvSocios.Columns[3].DataPropertyName = "nombre";

            dgvSocios.Columns[5].Name = "Barrio";
            dgvSocios.Columns[5].DataPropertyName = "nombre1";

            dgvSocios.Columns[4].Name = "Numero Documento";
            dgvSocios.Columns[4].DataPropertyName = "numeroDocumento";

            dgvSocios.Columns[1].Name = "Nombre";
            dgvSocios.Columns[1].DataPropertyName = "nombre2";

            dgvSocios.Columns[2].Name = "Apellido";
            dgvSocios.Columns[2].DataPropertyName = "apellido";

            dgvSocios.Columns[9].Name = "Mail";
            dgvSocios.Columns[9].DataPropertyName = "mail";

            dgvSocios.Columns[8].Name = "Teléfono";
            dgvSocios.Columns[8].DataPropertyName = "telefono";

            dgvSocios.Columns[6].Name = "Calle";
            dgvSocios.Columns[6].DataPropertyName = "calle";

            dgvSocios.Columns[7].Name = "Altura";
            dgvSocios.Columns[7].DataPropertyName = "nro";

        }

        private void frmConsultarSocio_Load(object sender, EventArgs e)
        {
           oSoporteForm.cargarCombo(cboTipoDocumento, oTipoDocService.obtenerTipoDocumentos("listarTipoDoc"));
           oSoporteForm.cargarCombo(cboUsuario, oUsuarioService.obtenerUsuarios("listarUsuarios"));
           oSoporteForm.cargarCombo(cboBarrio, oBarrioService.obtenerBarrios("listarBarrios"));        
           
            

        }
                                    
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNuevoSocio nuevoSocio = new frmNuevoSocio();
            nuevoSocio.FormMode1 = frmNuevoSocio.FormMode.insert;
            nuevoSocio.ShowDialog();
            oSoporteForm.limpiarGrid(dgvSocios);
            dgvSocios.DataSource = oSocioService.obtenerTodosPorTabla();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            frmNuevoSocio nuevoSocio = new frmNuevoSocio();            
            nuevoSocio.OSocioSeleccionado = seleccionado;
            nuevoSocio.FormMode1 = frmNuevoSocio.FormMode.delete;
            nuevoSocio.ShowDialog();
            oSoporteForm.limpiarGrid(dgvSocios);
            dgvSocios.DataSource = oSocioService.obtenerTodosPorTabla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmNuevoSocio nuevoSocio = new frmNuevoSocio();                    
            nuevoSocio.OSocioSeleccionado = seleccionado;
            nuevoSocio.FormMode1 = frmNuevoSocio.FormMode.update;
            nuevoSocio.ShowDialog();
            oSoporteForm.limpiarGrid(dgvSocios);
            dgvSocios.DataSource = oSocioService.obtenerTodosPorTabla();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Dictionary<String, Object> parametros = new Dictionary<string, object>();
            int id; //Todo: ver como controlar los tipos de datos
            if (!string.IsNullOrEmpty(txtIdSocio.Text) && Int32.TryParse(txtIdSocio.Text, out id))
            {               
                parametros.Add("idSocio", Convert.ToInt32(id));
            }
            if (!string.IsNullOrEmpty(cboTipoDocumento.Text))
            {
                parametros.Add("tipoD", cboTipoDocumento.SelectedValue);
            }
            if (!string.IsNullOrEmpty(cboBarrio.Text))
            {
                parametros.Add("barrio", cboBarrio.SelectedValue);
            }          
            if (!string.IsNullOrEmpty(txtNumeroDocumento.Text))
            {
                parametros.Add("numeroDoc", Convert.ToInt32(txtNumeroDocumento.Text));
            }
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                parametros.Add("nomb", txtNombre.Text);
            }
            if (!string.IsNullOrEmpty(txtApellido.Text))
            {
                parametros.Add("ape", txtApellido.Text);
            }
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                parametros.Add("email", txtEmail.Text);
            }
            if (!string.IsNullOrEmpty(txtTelefono.Text))
            {
                parametros.Add("tel", Convert.ToInt32(txtTelefono.Text));
            }
            if (!string.IsNullOrEmpty(txtCalle.Text))
            {
                parametros.Add("nombreCalle", txtCalle.Text);
            }
            if (!string.IsNullOrEmpty(txtNumeroCalle.Text))
            {
                parametros.Add("nroCalle", Convert.ToInt32(txtNumeroCalle.Text));
            }
            InitializeDataGridView();
            dgvSocios.DataSource=oSocioService.obtenerSocioConParametros(parametros);
            if (dgvSocios.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void grdSocios_SelectionChanged(object sender, EventArgs e)
        {         
            DataGridView temp = (DataGridView)sender;
            if (temp.CurrentRow == null)
            {
                return;
            }
            
            int idSocioSeleccionado= Convert.ToInt32(temp.CurrentRow.Cells[0].Value);
            seleccionado = oSocioService.obtenerSocioSinParametros(idSocioSeleccionado);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Close();
            this.Dispose();
        }

  
    }
}
