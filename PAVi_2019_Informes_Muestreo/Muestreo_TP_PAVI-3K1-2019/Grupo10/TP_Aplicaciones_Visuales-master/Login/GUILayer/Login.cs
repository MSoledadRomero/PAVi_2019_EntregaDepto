using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Aplicaciones_Visuales.BusinessLayer;
using TP_Aplicaciones_Visuales.Entities;

namespace TP_Aplicaciones_Visuales.GUILayer
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        private UsuarioService oUsuarioService = new UsuarioService();

        public frmLogin()
        {
            InitializeComponent();
            txtUsuario.Focus();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == ""))
            {
                MessageBox.Show("Se debe ingresar un usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Validamos que se haya ingresado una password
            if ((txtPassword.Text == ""))
            {
                MessageBox.Show("Se debe ingresar una contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Controlamos que las creadenciales sean las correctas. 
            if (oUsuarioService.validarUsuario(txtUsuario.Text, txtPassword.Text))
            {
                // NO Mostramos NADAAAA.
                
                frmMain oFrmMain = new frmMain();
                oFrmMain.ShowDialog();
                this.Close();
                

            }
            else
            {
                //Limpiamos el campo password, para que el usuario intente ingresar un usuario distinto.
                txtPassword.Text = "";
                // Enfocamos el cursor en el campo password para que el usuario complete sus datos.
                txtPassword.Focus();
                //Mostramos un mensaje indicando que el usuario/password es invalido.
                MessageBox.Show("Debe ingresar usuario y/o contraseña válidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
