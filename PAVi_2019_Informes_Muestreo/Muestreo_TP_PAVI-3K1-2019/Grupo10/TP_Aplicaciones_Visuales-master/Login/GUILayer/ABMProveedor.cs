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
    public partial class ABMProveedor : MetroFramework.Forms.MetroForm
    {
        private Proveedor oProveedor;
        private BarrioService oBarrioService = new BarrioService();
        private ProveedorService oProveedorService = new ProveedorService();
        private FormMode formMode;
        private SoporteForm oSoporteForm = new SoporteForm();
        internal Proveedor OProveedor { get => oProveedor; set => oProveedor = value; }
        public FormMode FormMode1 { get => formMode; set => formMode = value; }

        public ABMProveedor()
        {
            InitializeComponent();
        }

        private void ABMProveedor_Load(object sender, EventArgs e)
        {
            oSoporteForm.cargarCombo(cboBarrio, oBarrioService.obtenerBarrios("listarBarrios"));

            switch (formMode)
            {
                case (FormMode.insert):
                    this.Text = "Insertar Proveedor";
                    txtNumeroProveedor.Text = oProveedorService.obtenerProximoId().ToString();
                    this.habilitar(true);
                    break;
                case (FormMode.update):
                    this.Text = "Actualizar Proveedor";
                    cargarProveedor();
                    this.habilitar(true);
                    break;
                case (FormMode.delete):
                    this.Text = "Eliminar Proveedor";
                    cargarProveedor();
                    this.habilitar(false);
                    break;
            }
        }
        public void cargarProveedor()
        {            
            txtEmail.Text = oProveedor.Mail;
            txtNumeroCalle.Text = oProveedor.NroCalle.ToString();
            txtNumeroProveedor.Text = oProveedor.IdProveedor.ToString();
            txtRazonSocial.Text = oProveedor.RazonSocial;
            txtTelefono.Text = oProveedor.Telefono.ToString();
            cboBarrio.SelectedValue = oProveedor.IdBarrio;
            txtCalle.Text = oProveedor.Calle;
        }

        
        public enum FormMode
        {
            update,
            delete,
            insert
        }
        private void habilitar(bool x)
        {

            txtCalle.Enabled = x;
            txtEmail.Enabled = x;
            txtNumeroCalle.Enabled = x;
            txtNumeroProveedor.Enabled = x;
            txtRazonSocial.Enabled = x;
            txtTelefono.Enabled = x;
            cboBarrio.Enabled = x;

        }
      

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        private void actualizarProveedor()
        {
            oProveedor.Calle = txtCalle.Text;
            oProveedor.IdBarrio = Convert.ToInt32(cboBarrio.SelectedValue);
            oProveedor.Mail = txtEmail.Text;
            oProveedor.NroCalle = Convert.ToInt32(txtNumeroCalle.Text);
            oProveedor.RazonSocial = txtRazonSocial.Text;
            oProveedor.Telefono = Convert.ToInt32(txtTelefono.Text);
        }


        private bool validarCampos()
        {
            bool t1 = oSoporteForm.validarText(txtRazonSocial);
            bool t2 = oSoporteForm.validarText(txtCalle);
            bool t3 = oSoporteForm.validarText(txtTelefono);
            bool t4 = oSoporteForm.validarText(txtNumeroCalle);
            bool t5 = oSoporteForm.validarText(txtEmail);
            bool t6 = oSoporteForm.validarCombo(cboBarrio);


            if (t1 && t2 && t3 && t4 && t5 && t6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case (FormMode.insert):                    
                    actualizarProveedor();
                    if (validarCampos())
                    {
                        if (!oProveedorService.existeProveedor(oProveedor))
                        {
                            if (oProveedorService.insertarProveedor(oProveedor))
                            {
                                MessageBox.Show("Se ha registrado correctamente el proveedor");
                            }
                            else
                            {
                                MessageBox.Show("Ha ocurrido un error durante la registración.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El proveedor ya se encuentra registrado.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hay campos vacíos, por favor completelos");
                    }


                    this.Close();

                    break;
                case (FormMode.update):                 
                    actualizarProveedor();
                    if (validarCampos())
                    {
                        if (oProveedorService.actualizarProveedor(oProveedor))
                        {
                            MessageBox.Show("Se ha actualizado correctamente el proveedor");
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error durante la actualización.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hay campos vacíos, por favor completelos");
                    }

                    this.Close();
                    break;

                case (FormMode.delete):

                    if (MessageBox.Show("Seguro que desea dar de baja el proveedor seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (oProveedorService.darDeBajaProveedor(oProveedor))
                        {
                            MessageBox.Show("El proveedor seleccionado ha sido dado de baja correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error al intentar dar de baja el proveedor seleccionado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    this.Close();
                    break;
            }
        }
    }
}
