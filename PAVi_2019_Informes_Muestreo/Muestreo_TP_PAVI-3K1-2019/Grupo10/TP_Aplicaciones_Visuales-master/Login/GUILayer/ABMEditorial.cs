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
    public partial class ABMEditorial : MetroFramework.Forms.MetroForm
    {
        private FormMode formMode;
        private Editorial oEditorial;
        private EditorialService oEditorialService = new EditorialService();
        private readonly SoporteForm oSoporteForm = new SoporteForm();

        public FormMode FormMode1 { get => formMode; set => formMode = value; }
        internal Editorial OEditorial { get => oEditorial; set => oEditorial = value; }

        public ABMEditorial()
        {
            InitializeComponent();
            oEditorial = new Editorial();
        }
        public enum FormMode
        {
            update,
            insert,
            delete
        }
        private void ABMEditorial_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {

                case (FormMode.insert):
                    this.Text = "Insertar Editorial";
                    txtID.Text = oEditorialService.obtenerProximoId().ToString();
                    break;
                case (FormMode.update):
                    this.Text = "Actualizar Editorial";
                    cargarEditorial();
                    break;
                case (FormMode.delete):
                    this.Text = "Dar de baja Editorial";
                    txtNombre.Enabled = false;
                    cargarEditorial();
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

        public void cargarEditorial()
        {

            txtID.Text = OEditorial.IdEditorial.ToString();
            txtNombre.Text = OEditorial.NombreEditorial;

        }
        
      
        private void actualizarDocumento()
        {
            OEditorial.NombreEditorial = txtNombre.Text;
            OEditorial.IdEditorial = Convert.ToInt32(txtID.Text);

        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            switch (FormMode1)
            {

                case (FormMode.insert):
                    actualizarDocumento();
                    if (validarCampos())
                    {
                        if (!oEditorialService.existeEditorial(oEditorial))
                        {
                            if (oEditorialService.insertarEditorial(oEditorial))
                            {
                                MessageBox.Show("Se ha registrado correctamente la editorial");
                            }
                            else
                            {
                                MessageBox.Show("Ha ocurrido un error durante la registración.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("La editorial ya se encuentra registrada.");
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
                        if (oEditorialService.actualizarEditorial(oEditorial))
                        {
                            MessageBox.Show("Se ha actualizado correctamente la editorial");
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
                    if (MessageBox.Show("Seguro que desea dar de baja a  la editorial seleccionada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (oEditorialService.darDeBajaEditorial(oEditorial))
                        {
                            MessageBox.Show("La editorial seleccionado ha sido dado de baja correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error al intentar dar de baja la editorial seleccionado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    this.Close();
                    break;
            }
        }

    }
}
