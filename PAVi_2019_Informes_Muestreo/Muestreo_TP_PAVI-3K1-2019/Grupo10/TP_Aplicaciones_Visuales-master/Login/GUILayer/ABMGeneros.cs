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
    public partial class ABMGeneros : MetroFramework.Forms.MetroForm
    {
        private FormMode formMode;
        private Genero oGenero = new Genero();
        private GeneroService oGeneroService = new GeneroService();
        private readonly SoporteForm oSoporteForm = new SoporteForm();

        public FormMode FormMode1 { get => formMode; set => formMode = value; }
        internal Genero OGenero { get => oGenero; set => oGenero = value; }

        public ABMGeneros()
        {
            InitializeComponent();
        }

        public enum FormMode
        {
            update,
            insert,
            delete
        }

        private void ABMGeneros_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case (FormMode.insert):
                    this.Text = "Insertar Genero";
                    txtID.Text = oGeneroService.obtenerProximoId().ToString();
                    break;
                case (FormMode.update):
                    this.Text = "Actualizar Genero";
                    cargarGenero();
                    break;
                case (FormMode.delete):
                    this.Text = "Dar de baja Genero";
                    cargarGenero();
                    txtNombre.Enabled = false;
                    break;
            }
        }
        public void cargarGenero()
        {

            txtID.Text = OGenero.IdGenero.ToString();
            txtNombre.Text = OGenero.Nombre;
            
        }
       
        private void actualizarGenero()
        {
            OGenero.Nombre = txtNombre.Text;
            OGenero.IdGenero = Convert.ToInt32(txtID.Text);

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
                    actualizarGenero();
                    if (validarCampos())
                    {

                        if (!oGeneroService.existeGenero(oGenero))
                        {
                            if (oGeneroService.insertarGenero(oGenero))
                            {
                                MessageBox.Show("Se ha registrado correctamente el genero");
                            }
                            else
                            {
                                MessageBox.Show("Ha ocurrido un error durante la registración.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El genero ya se encuentra registrado.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hay campos vacíos, por favor completelos");
                    }

                    this.Close();
                    break;

                case (FormMode.update):
                    actualizarGenero();
                    if (validarCampos())
                    {
                        if (oGeneroService.actualizarGenero(oGenero))
                        {
                            MessageBox.Show("Se ha actualizado correctamente el genero");
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
                    if (MessageBox.Show("Seguro que desea dar de baja el genero seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (oGeneroService.darDeBajaGenero(oGenero))
                        {
                            MessageBox.Show("El genero seleccionado ha sido dado de baja correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error al intentar dar de baja el genero seleccionado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    this.Close();
                    break;
            }
        }
       
    }
}
