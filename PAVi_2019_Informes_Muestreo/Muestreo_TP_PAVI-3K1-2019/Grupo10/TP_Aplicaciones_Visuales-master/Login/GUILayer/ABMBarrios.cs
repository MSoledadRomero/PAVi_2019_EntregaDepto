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
    public partial class ABMBarrios : MetroFramework.Forms.MetroForm
    {
        private FormMode formMode;
        private Barrio oBarrio;
        private BarrioService oBarrioService = new BarrioService();
        private SoporteForm oSoporteForm = new SoporteForm();
        private CiudadService oCiudadService = new CiudadService();
        

        public FormMode FormMode1 { get => formMode; set => formMode = value; }
        internal Barrio OBarrio { get => oBarrio; set => oBarrio = value; }

        public ABMBarrios()
        {
            InitializeComponent();
            oBarrio = new Barrio(); 
        }
        public void cargarBarrio()
        {
            oSoporteForm.cargarCombo(cboCiudad, oCiudadService.obtenerCiudades("listarCiudades"));
            txtID.Text = oBarrio.IdBarrio.ToString();
            txtNombre.Text = oBarrio.Nombre;
            cboCiudad.SelectedValue = oBarrio.IdCiudad;
        }
        public enum FormMode
        {
            update,
            delete,
            insert
        }
        private void ABMBarrios_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case (FormMode.insert):
                    this.Text = "Insertar Barrio";
                    txtID.Text = oBarrioService.obtenerProximoId().ToString();
                    break;
                case (FormMode.update):
                    this.Text = "Actualizar Barrio";
                    cargarBarrio();
                    break;
                case (FormMode.delete):
                    this.Text = "Dar de baja barrio";
                    cargarBarrio();
                    txtNombre.Enabled = false;
                    cboCiudad.Enabled = false;
                    break;
            }
        }
        private void actualizarBarrio()
        {
            oBarrio.Nombre = txtNombre.Text;
            oBarrio.IdCiudad = Convert.ToInt32(cboCiudad.SelectedValue);
            oBarrio.IdBarrio = Convert.ToInt32(txtID.Text);

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
                    actualizarBarrio();
                    if (validarCampos())
                    {
                        if (!oBarrioService.existeBarrio(oBarrio))
                        {
                            if (oBarrioService.insertarBarrio(oBarrio))
                            {
                                MessageBox.Show("Se ha registrado correctamente el barrio");
                            }
                            else
                            {
                                MessageBox.Show("Ha ocurrido un error durante la registración.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El barrio ya se encuentra registrado.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hay campos vacíos, por favor completelos");
                    }
                    this.Close();
                    break;

                case (FormMode.update):
                    actualizarBarrio();
                    if(validarCampos())
                    {                        
                         if (oBarrioService.actualizarBarrio(oBarrio))
                         {
                             MessageBox.Show("Se ha actualizado correctamente el barrio");
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
                    if (MessageBox.Show("Seguro que desea dar de baja al barrio seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (oBarrioService.darDeBajaBarrio(oBarrio))
                        {
                            MessageBox.Show("El barrio seleccionado ha sido dado de baja correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error al intentar dar de baja el barrio seleccionado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    this.Close();
                    break;
            }
        }






        private bool validarCampos()
        {
            bool t1 = oSoporteForm.validarText(txtNombre);
            bool t2 = oSoporteForm.validarCombo(cboCiudad);
            
            if (t1 && t2)
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

