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
    public partial class frmABMAutor : MetroFramework.Forms.MetroForm
    {
        private FormMode formMode;
        private Autor oAutor;
        private SoporteForm oSoporteForm = new SoporteForm();
        private AutorService oAutorService = new AutorService();

        public FormMode FormMode1 { get => formMode; set => formMode = value; }

        internal Autor OAutor { get => oAutor; set => oAutor = value; }

     
        public frmABMAutor()
        {
            InitializeComponent();
            oAutor = new Autor();
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }
        public void cargarAutor()
        {

            txtID.Text = oAutor.IdAutor.ToString();
            txtNombre.Text = oAutor.Nombre;

        }
        public enum FormMode
        {
            update,
            insert,
            delete
        }
        private void ABMDocumentos_Load(object sender, EventArgs e)
        {
            switch (FormMode1)
            {

                case (FormMode.insert):
                    this.Text = "Insertar Autor";
                    txtID.Text = oAutorService.obtenerProximoId().ToString();
                    break;
                case (FormMode.update):
                    this.Text = "Actualizar Autor";
                    cargarAutor();
                    break;
                case (FormMode.delete):
                    this.Text = "Dar de baja Autor";
                    cargarAutor();
                    txtNombre.Enabled = false;
                    break;

            }
        }
        private void actualizarAutor()
        {
            OAutor.Nombre = txtNombre.Text;
            OAutor.IdAutor = Convert.ToInt32(txtID.Text);
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
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


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            switch (FormMode1)
            {

                case (FormMode.insert):
                    actualizarAutor();
                    if (validarCampos())
                    {

                        if (!oAutorService.existeAutor(oAutor))
                        {
                            if (oAutorService.insertarAutor(oAutor))
                            {
                                MessageBox.Show("Se ha registrado correctamente el autor");
                            }
                            else
                            {
                                MessageBox.Show("Ha ocurrido un error durante la registración.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El autor ya se encuentra registrado.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hay campos vacíos, por favor completelos");
                    }


                    this.Close();
                    break;
                case (FormMode.update):
                    actualizarAutor();

                    if (validarCampos())
                    {
                        if (oAutorService.actualizarAutor(oAutor))
                        {
                            MessageBox.Show("Se ha actualizado correctamente el autor");
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
                    if (MessageBox.Show("Seguro que desea dar de baja el autor seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (oAutorService.darDeBajaAutor(oAutor))
                        {
                            MessageBox.Show("El autor seleccionado ha sido dado de baja correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error al intentar dar de baja el autor seleccionado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    this.Close();
                    break;


            }
        }
   


    }
}
