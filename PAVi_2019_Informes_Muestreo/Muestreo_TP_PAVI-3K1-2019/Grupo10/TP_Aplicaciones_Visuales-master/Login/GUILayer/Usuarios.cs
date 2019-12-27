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



namespace TP_Aplicaciones_Visuales.GUILayer
{
    public partial class Usuarios : Form
    {
        private UsuarioService oUsuarioService;
        private PerfilService oPerfilService;
        public Usuarios()
        {
            InitializeComponent();
            InitializeDataGridView();
            oUsuarioService = new UsuarioService();
            oPerfilService = new PerfilService();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
           Dictionary<string, object> parametros = new Dictionary<string, object>();
            if (!chkTodos.Checked)
            {
                if (cboPerfiles.Text != string.Empty)
                {
                    parametros.Add("idPerfil", cboPerfiles.SelectedValue);

                }                
                if (txtNombre.Text != string.Empty)
                {                    
                    parametros.Add("usuario", txtNombre.Text);                    
                }
                if (parametros.Count > 0)
                {
                    dgvUsers.DataSource = oUsuarioService.obtenerUsuarioConParametros(parametros);   
                }
                else
                {
                    MessageBox.Show("Debe ingresar al menos un criterio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }               
            }
            else
                dgvUsers.DataSource = oUsuarioService.obtenerTodos();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboPerfiles, oPerfilService.ObtenerTodos(), "Nombre", "IdPerfil");
            this.CenterToParent();
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }
        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvUsers.ColumnCount = 3;
            dgvUsers.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvUsers.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvUsers.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            dgvUsers.Columns[0].Name = "Usuario";
            dgvUsers.Columns[0].DataPropertyName = "NombreUsuario";
            // Definimos el ancho de la columna.

            dgvUsers.Columns[1].Name = "Estado";
            dgvUsers.Columns[1].DataPropertyName = "estado";

            dgvUsers.Columns[2].Name = "Perfil";
            dgvUsers.Columns[2].DataPropertyName = "Perfil";

            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvUsers.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvUsers.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }
        


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void chkTodos_CheckedChanged_1(object sender, EventArgs e)
        {
            {
                if (chkTodos.Checked)
                {
                    txtNombre.Enabled = false;
                    cboPerfiles.Enabled = false;
                }
                else
                {
                    txtNombre.Enabled = true;
                    cboPerfiles.Enabled = true;
                }
            }

        }
       

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ABMUsuario formulario = new ABMUsuario();
            var usuario = (Usuario)dgvUsers.CurrentRow.DataBoundItem;
            formulario.FormMode1 = ABMUsuario.FormMode.update;
            formulario.OUsuarioSelected = usuario;
            //formulario.SeleccionarUsuario(ABMUsuario.FormMode.update, usuario);
            formulario.ShowDialog();
            btnConsultar_Click(sender, e);
        }
        private void dgvUsers_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnQuitar.Enabled = true;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            ABMUsuario formulario = new ABMUsuario();
            var usuario = (Usuario)dgvUsers.CurrentRow.DataBoundItem;
            formulario.FormMode1 = ABMUsuario.FormMode.delete;
            formulario.OUsuarioSelected = usuario;
            formulario.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ABMUsuario formulario = new ABMUsuario();
            
            formulario.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        
    }
}

