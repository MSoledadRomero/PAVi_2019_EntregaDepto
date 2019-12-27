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
    public partial class ABMDocumento : MetroFramework.Forms.MetroForm
    {
        private FormMode formMode;
        private TipoDocumento oTipoDocumento;
        private  TipoDocumentoService oTipoDocumentoService = new TipoDocumentoService();
        private SoporteForm oSoporteForm = new SoporteForm();
        public FormMode FormMode1 { get => formMode; set => formMode = value; }
        internal TipoDocumento OTipoDocumento { get => oTipoDocumento; set => oTipoDocumento = value; }

        public ABMDocumento()
        {
            InitializeComponent();
            oTipoDocumento = new TipoDocumento();
        }

      
        public void cargarDocumento()
        {
            txtID.Text = oTipoDocumento.IdTipoDoc.ToString();
            txtNombre.Text = oTipoDocumento.Nombre;
        }
        public enum FormMode
        {
            update,
            insert,
            delete
        }
        private void ABMDocumentos_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case (FormMode.insert):
                    this.Text = "Insertar Documento";                    
                    txtID.Text = oTipoDocumentoService.obtenerProximoId().ToString();
                    break;
                case (FormMode.update):
                    this.Text = "Actualizar Documento";
                    cargarDocumento();
                    break;
                case (FormMode.delete):
                    this.Text = "Dar de Baja Documento";
                    cargarDocumento();
                    txtNombre.Enabled = false;
                    break;
            }
        }
        private void actualizarDocumento()
        {
            oTipoDocumento.Nombre = txtNombre.Text;
            oTipoDocumento.IdTipoDoc = Convert.ToInt32(txtID.Text);

        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {

                case (FormMode.insert):
                    actualizarDocumento();
                    if (validarCampos())
                    {
                        if (!oTipoDocumentoService.existeTipoDocumento(oTipoDocumento))
                        {
                            if (oTipoDocumentoService.insertarTipoDocumento(oTipoDocumento))
                            {
                                MessageBox.Show("Se ha registrado correctamente el tipo de documento");
                            }
                            else
                            {
                                MessageBox.Show("Ha ocurrido un error durante la registración.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El tipo de documento ya se encuentra registrado.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hay campos vacíos, por favor completelos");
                    }
                    this.Close();
                    break;
                case (FormMode.update):
                    actualizarDocumento();
                    if (validarCampos())
                    {
                        if (oTipoDocumentoService.actualizarTipoDocumento(oTipoDocumento))
                        {
                            MessageBox.Show("Se ha actualizado correctamente el tipo de documento");
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
                    if (MessageBox.Show("Seguro que desea dar de baja al tipo de documento seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (oTipoDocumentoService.darDeBajaTipoDocumento(oTipoDocumento))
                        {
                            MessageBox.Show("El tipo de documento seleccionado ha sido dado de baja correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error al intentar dar de baja el tipo de documento seleccionado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    this.Close();
                    break;
            }
        }




        private bool validarCampos()
        {
            bool t1 = oSoporteForm.validarText(txtNombre);
            

            if (t1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
