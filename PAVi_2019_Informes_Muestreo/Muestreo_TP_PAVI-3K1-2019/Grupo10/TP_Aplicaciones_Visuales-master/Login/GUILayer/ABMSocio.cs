using System;
using TP_Aplicaciones_Visuales.BusinessLayer;
using TP_Aplicaciones_Visuales.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using TP_Aplicaciones_Visuales.Soporte;



namespace TP_Aplicaciones_Visuales.GUILayer
{
    public partial class frmNuevoSocio : MetroFramework.Forms.MetroForm
    {
        private FormMode formMode = FormMode.insert;
        private readonly SocioService oSocioService; //Porque son solo lectura?
        private readonly TipoDocumentoService oTipoDocumentoService;
        private readonly BarrioService oBarrioService;
        private Socio oSocioSeleccionado;
        private readonly SoporteForm oSoporteForm;

        internal Socio OSocioSeleccionado { get => oSocioSeleccionado; set => oSocioSeleccionado = value; }
        public FormMode FormMode1 { get => formMode; set => formMode = value; }

        public frmNuevoSocio()
        {
            InitializeComponent();
            oSocioService = new SocioService();
            oTipoDocumentoService = new TipoDocumentoService();
            oBarrioService = new BarrioService();
            oSoporteForm = new SoporteForm();
        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }

        
       
        private void cargarDatosSocio(Socio oSocio)
        {
            
            txtSocio.Text =oSocio.IdSocio.ToString();
            txtNombre.Text = oSocio.Nombre;
            txtApellido.Text = oSocio.Apellido;
            cboTipoDoc.SelectedValue = oSocio.IdTipoDoc;
            txtNumero.Text = oSocio.NumeroDocumento.ToString();
            txtTelefono.Text = oSocio.Telefono.ToString();
            txtEmail.Text = oSocio.Mail;
            txtCalle.Text = oSocio.Calle;
            txtNumeroCalle.Text = oSocio.Nro.ToString();
            cboBarrio.SelectedValue = oSocio.IdBarrio;

        }

        private void habilitarDeshabilitar(bool x)
        {
            txtNombre.Enabled=x;
            txtApellido.Enabled=x;
            txtNumero.Enabled=x;           
            txtEmail.Enabled=x;
            txtTelefono.Enabled=x;
            txtCalle.Enabled=x;
            txtNumeroCalle.Enabled=x;
            cboBarrio.Enabled=x;
            cboTipoDoc.Enabled = x;
        }

        private void NuevoSocio_Load(object sender, EventArgs e)
        {


            oSoporteForm.cargarCombo(cboBarrio,oBarrioService.obtenerBarrios("listarBarrios"));
            oSoporteForm.cargarCombo(cboTipoDoc,oTipoDocumentoService.obtenerTipoDocumentos("listarTipoDoc"));

            switch (FormMode1)
            {
                case FormMode.insert:
                    this.Text = "Nuevo Socio";
                    txtFecha.Text = DateTime.Today.ToShortDateString();
                    txtSocio.Text = (oSocioService.ObtenerProximoId()).ToString();
                     break;

                case FormMode.update:
                    this.Text = "Actualizar Socio";
                    cargarDatosSocio(OSocioSeleccionado);
                    txtSocio.Enabled = false;                    
                    habilitarDeshabilitar(true);
                    break;
                case FormMode.delete:
                    this.Text = "Dar de Baja Socio";
                    cargarDatosSocio(OSocioSeleccionado);
                    txtSocio.Enabled = false;
                    habilitarDeshabilitar(false);
                    break;
            }     

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       
        private bool validarCampos()
        {
            //true: valido , false: invalido
         
            //Todo: ver bien cuales campos son obligatorios y cuales no
            bool t1= oSoporteForm.validarText(txtApellido);
            bool t2 = oSoporteForm.validarText(txtNombre);
            bool t3 = oSoporteForm.validarText(txtNumero);
            bool t4 = oSoporteForm.validarText(txtTelefono);
            bool t5 = oSoporteForm.validarText(txtEmail);
            bool t6 = oSoporteForm.validarText(txtCalle);
            bool t7 = oSoporteForm.validarText(txtNumeroCalle);
            bool t8 = oSoporteForm.validarCombo(cboTipoDoc);
            bool t9 = oSoporteForm.validarCombo(cboBarrio);
            
            if( t1 && t2 && t3 && t4 && t5 && t6 && t7 && t8 && t9)
            {
                return true;
            }
            else {
                return false;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            switch(FormMode1)
            {
                case FormMode.insert:
                    if (validarCampos())
                    {
                        Socio oSocio = new Socio();
                        oSocio.Apellido = txtApellido.Text;
                        oSocio.Nombre = txtNombre.Text;
                        oSocio.IdTipoDoc = (int) cboTipoDoc.SelectedValue;
                        oSocio.NumeroDocumento = Convert.ToInt32(txtNumero.Text);
                        oSocio.Telefono = Convert.ToInt32(txtTelefono.Text);
                        oSocio.Mail = txtEmail.Text;
                        oSocio.Calle = txtCalle.Text;
                        oSocio.Nro = Convert.ToInt32(txtNumeroCalle.Text);
                        oSocio.IdBarrio = Convert.ToInt32(cboBarrio.SelectedValue);
                        
                        if (!oSocioService.existeSocio(oSocio))
                        {
                            if (oSocioService.insertarNuevoSocio(oSocio))
                            {
                                MessageBox.Show("Se ha registrado correctamente el socio");
                            }
                            else
                            {
                                MessageBox.Show("Ha ocurrido un error durante la registración.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El socio ya se encuentra registrado.");
                        }


                    }
                    else
                    {
                        MessageBox.Show("Hay campos vacíos, por favor completelos");
                    }
                    this.Close();
                    break;

                case FormMode.update:
                    
                    if (validarCampos())
                    {                        
                        oSocioSeleccionado.Apellido = txtApellido.Text;
                        oSocioSeleccionado.Nombre = txtNombre.Text;
                        oSocioSeleccionado.IdTipoDoc = Convert.ToInt32(cboTipoDoc.SelectedValue);
                        oSocioSeleccionado.NumeroDocumento = Convert.ToInt32(txtNumero.Text);
                        oSocioSeleccionado.Telefono = Convert.ToInt32(txtTelefono.Text);
                        oSocioSeleccionado.Mail = txtEmail.Text;
                        oSocioSeleccionado.Calle = txtCalle.Text;
                        oSocioSeleccionado.Nro = Convert.ToInt32(txtNumeroCalle.Text);
                        oSocioSeleccionado.IdBarrio = Convert.ToInt32(cboBarrio.SelectedValue);
                        if (oSocioService.actualizarSocio(oSocioSeleccionado))
                        {
                            MessageBox.Show("Se han actualizado correctamente los datos del socio.");
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error durante la actualizacion.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hay campos vacíos, por favor completelos");
                    }
                    this.Close();
                    break;
                    

                case FormMode.delete:
                                       
                    if (MessageBox.Show("Seguro que desea dar de baja al socio seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {

                        if (oSocioService.darDeBajaSocio(OSocioSeleccionado))
                        {
                            MessageBox.Show("El socio seleccionado ha sido dado de baja correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error al intentar dar de baja el socio seleccionado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    this.Close();
                    break;

            }
        }
    }
}
