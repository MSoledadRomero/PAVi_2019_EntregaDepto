using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //Todo: ver si esta bien
using System.Data;
using System.Drawing;

namespace TP_Aplicaciones_Visuales.Soporte
{
    class SoporteForm
    {
        public void cargarCombo(ComboBox cbo, DataTable tabla)
        {
            cbo.DataSource = tabla;
            cbo.DisplayMember = tabla.Columns[1].ColumnName;
            cbo.ValueMember = tabla.Columns[0].ColumnName;
            cbo.SelectedIndex = -1;
        }

        public void limpiarGrid(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.AutoGenerateColumns = true;
            dgv.Columns.Clear();
            dgv.Rows.Clear();
        }

        public void cargarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }
        public bool validarText(TextBox nombreText)
        {
            if (string.IsNullOrEmpty(nombreText.Text))
            {
                nombreText.BackColor = Color.Red;
                return false;
            }
            else
            {
                nombreText.BackColor = Color.White;
                return true;
            }
        }
        public bool validarCombo(ComboBox combo)
        {
            if (combo.SelectedIndex == -1)
            {
                combo.BackColor = Color.Red;
                return false;
            }
            else
            {
                combo.BackColor = Color.White;
                return true;
            }


        }
      
    }
}
