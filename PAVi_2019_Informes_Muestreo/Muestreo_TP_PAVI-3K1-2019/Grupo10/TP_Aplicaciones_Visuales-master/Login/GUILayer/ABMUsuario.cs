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

namespace TP_Aplicaciones_Visuales.GUILayer
{
    public partial class ABMUsuario : Form
    {
        private FormMode formMode = FormMode.insert;

        private readonly UsuarioService oUsuarioService;
        private readonly PerfilService oPerfilService;
        private Usuario oUsuarioSelected;

        internal Usuario OUsuarioSelected { get => oUsuarioSelected; set => oUsuarioSelected = value; }
        public FormMode FormMode1 { get => formMode; set => formMode = value; }

        public ABMUsuario()
        {
            InitializeComponent();
            oUsuarioService = new UsuarioService();
            oPerfilService = new PerfilService();
        }
        
        
        public enum FormMode
        {
            insert,
            update,
            delete
        }

        private void ABMUsuario_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboPerfil, oPerfilService.ObtenerTodos(), "Nombre", "IdPerfil");
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Usuario";
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Actualizar Usuario";
                        // Recuperar usuario seleccionado en la grilla 
                        MostrarDatos();
                        txtNombre.Enabled = true;
                        txtPassword.Enabled = true;
                        txtConfirmarPass.Enabled = true;
                        cboPerfil.Enabled = true;
                        break;
                    }

                case FormMode.delete:
                    {
                        MostrarDatos();
                        this.Text = "Habilitar/Deshabilitar Usuario";
                        txtNombre.Enabled = false;
                        txtPassword.Enabled = false;
                        cboPerfil.Enabled = false;
                        txtConfirmarPass.Enabled = false;
                        break;
                    }
            }
        }
        /*public void SeleccionarUsuario(FormMode op, Usuario usuarioSelected)
        {
            formMode = op;
           
            OUsuarioSelected = usuarioSelected;
        }*/
        private void MostrarDatos()
        {
            if (oUsuarioSelected != null)
            {
                txtNombre.Text = oUsuarioSelected.NombreUsuario;
                txtPassword.Text = oUsuarioSelected.Contraseña;
                txtConfirmarPass.Text = txtPassword.Text;
                cboPerfil.Text = oUsuarioSelected.Perfil.Nombre;
            }
        }
        private void btnAceptar_Click(System.Object sender, System.EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        var oUsuario = new Usuario();
                        oUsuario.NombreUsuario = txtNombre.Text;
                        oUsuario.Contraseña = txtPassword.Text;
                        oUsuario.Perfil = new Perfil();
                        oUsuario.Perfil.IdPerfil = (int)cboPerfil.SelectedValue;
                        oUsuario.Estado = "S";

                        if (oUsuarioService.existeUsuario(oUsuario) == false)
                        {
                            if (ValidarCampos())
                            {
                                if (oUsuarioService.InsertarUsuario(oUsuario))
                                {
                                    MessageBox.Show("Usuario insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                        else
                            MessageBox.Show("Nombre de usuario encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case FormMode.update:
                    {
                        if (ValidarCampos())
                        {
                            oUsuarioSelected.NombreUsuario = txtNombre.Text;
                            oUsuarioSelected.Contraseña = txtPassword.Text;
                            oUsuarioSelected.Perfil = new Perfil();
                            oUsuarioSelected.Perfil.IdPerfil = (int)cboPerfil.SelectedValue;

                            if (oUsuarioService.ActualizarUsuario(oUsuarioSelected))
                            {
                                MessageBox.Show("Usuario actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }

                case FormMode.delete:
                    {
                        if (MessageBox.Show("Seguro que desea habilitar/deshabilitar el usuario seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {

                            if (oUsuarioService.darDeBajaUsuario(oUsuarioSelected))
                            {
                                MessageBox.Show("Usuario Habilitado/Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al actualizar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }
            }
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

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        var oUsuario = new Usuario();
                        oUsuario.NombreUsuario = txtNombre.Text;
                        oUsuario.Contraseña = txtPassword.Text;
                        oUsuario.Perfil = new Perfil();
                        oUsuario.Perfil.IdPerfil = (int)cboPerfil.SelectedValue;
                        oUsuario.Estado = "S";
                        if (oUsuarioService.existeUsuario(oUsuario) == false)
                        {
                            if (ValidarCampos())
                            {                          
                                if (oUsuarioService.InsertarUsuario(oUsuario))
                                {
                                    MessageBox.Show("Usuario insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                        else
                            MessageBox.Show("Nombre de usuario encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case FormMode.update:
                    {
                        if (ValidarCampos())
                        {
                            oUsuarioSelected.NombreUsuario = txtNombre.Text;
                            oUsuarioSelected.Contraseña = txtPassword.Text;
                            oUsuarioSelected.Perfil = new Perfil();
                            oUsuarioSelected.Perfil.IdPerfil = (int)cboPerfil.SelectedValue;

                            if (oUsuarioService.ActualizarUsuario(oUsuarioSelected))
                            {
                                MessageBox.Show("Usuario actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }

                case FormMode.delete:
                    {
                        if (ValidarCampos())
                        {
                            oUsuarioSelected.NombreUsuario = txtNombre.Text;
                            oUsuarioSelected.Contraseña = txtPassword.Text;
                            oUsuarioSelected.Perfil = new Perfil();
                            oUsuarioSelected.Perfil.IdPerfil = (int)cboPerfil.SelectedValue;


                            if (MessageBox.Show("Seguro que desea habilitar/deshabilitar el usuario seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {

                                if (oUsuarioService.darDeBajaUsuario(oUsuarioSelected))
                                {
                                    MessageBox.Show("Usuario Habilitado/Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                    MessageBox.Show("Error al actualizar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        break;
                    }
            }
        }
    }
}
