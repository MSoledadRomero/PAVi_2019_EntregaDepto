using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProyectoPAV1.Entities;
using ProyectoPAV1.BusinessLayer;

namespace ProyectoPAV1.GUILayer.Perfiles
{
    public partial class frmABMPerfil : Form
    {
        private FormMode formMode = FormMode.insert;
        private readonly PerfilService oPerfilService;
        private Perfil oPerfilSelected;


        public frmABMPerfil()
        {
            InitializeComponent();
            oPerfilService = new PerfilService();
        }
        public enum FormMode
        {
            insert,
            update,
            delete
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (ExisteMarca() == false)
                        {
                            if (ValidarCampos())
                            {
                                var oPerfil = new Perfil();
                                oPerfil.Nombre = txtNombre.Text;
                                

                                if (oPerfilService.CrearPerfil(oPerfil))
                                {
                                    MessageBox.Show("Perfil insertada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                        else
                            MessageBox.Show("Nombre de perfil encontrada!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case FormMode.update:
                    {
                        if (ValidarCampos())
                        {
                            oPerfilSelected.Nombre = txtNombre.Text;
                           

                            if (oPerfilService.ActualizarPerfil(oPerfilSelected))
                            {
                                MessageBox.Show("Perfil actualizada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar Perfil!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }

                case FormMode.delete:
                    {
                        if (MessageBox.Show("Seguro que desea habilitar/deshabilitar el perfil seleccionada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {

                            if (oPerfilService.ModificarEstadoPerfil(oPerfilSelected))
                            {
                                MessageBox.Show("Perfil Habilitado/Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al actualizar el perfil!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }

            }
        }

        private bool ExisteMarca()
        {
            return oPerfilService.ObtenerPerfil(txtNombre.Text) != null;
        }

        private bool ValidarCampos()
        {
            // campos obligatorios
            if (txtNombre.Text == string.Empty)
            {
                txtNombre.BackColor = Color.Red;
                txtNombre.Focus();
                return false;
            }
            else
                txtNombre.BackColor = Color.White;

            return true;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmABMPerfiles_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nueva Perfil";
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Actualizar Perfil";
                        // Recuperar usuario seleccionado en la grilla 
                        MostrarDatos();
                        //txtNombre.Enabled = true;
                        //txtEmail.Enabled = true;
                        //txtEmail.Enabled = true;
                        //txtPassword.Enabled = true;
                        //txtConfirmarPass.Enabled = true;
                        //cboPerfil.Enabled = true;
                        break;
                    }

                case FormMode.delete:
                    {
                        MostrarDatos();
                        this.Text = "Habilitar/Deshabilitar Perfil";
                        txtNombre.Enabled = false;
                        //txtEmail.Enabled = false;
                        //txtEmail.Enabled = false;
                        //txtPassword.Enabled = false;
                        //cboPerfil.Enabled = false;
                        //txtConfirmarPass.Enabled = false;
                        break;
                    }
            }
        }

        public void SeleccionarPerfil(FormMode op, Perfil PerfilSelected)
        {
          formMode = op;
          oPerfilSelected = PerfilSelected;
        }
 


        private void MostrarDatos()
        {
            if (oPerfilSelected != null)
            {
                txtNombre.Text = oPerfilSelected.Nombre;
               
            }
        }

    
    }
}
