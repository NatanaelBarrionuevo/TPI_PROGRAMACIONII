using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class DatosPersonales : Form
    {
        private List<String> listPersonal;
        public DatosPersonales()
        {
            InitializeComponent();
            listPersonal = new List<String>();
            listPersonal.Insert(0, "Medico");
            listPersonal.Insert(1, "Cliente");
            listPersonal.Insert(2, "Empleado");
            listPersonal.Insert(3, "Proveedor");
        }

        private void gbMedico_Enter(object sender, EventArgs e)
        {

        }

        private void DatosPersonales_Load(object sender, EventArgs e)
        {
            cboPersonal.DataSource = listPersonal;
            cboPersonal.DropDownStyle = ComboBoxStyle.DropDownList;
            LimpiarPantalla();
            LimpiarDatos();
            cboPersonal.SelectedIndex = -1;
        }

        private void LimpiarDatos()
        {
            foreach (Control control in this.gbDatos.Controls)
            {
                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }

                if (control is TextBox)
                {
                    control.Text = String.Empty;
                }

                if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }

                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
            }
        }

        private void LimpiarPantalla()
        {
            gbMedico.Visible.Equals(false);
            gbCliente.Visible.Equals(false);
            gbEmpleado.Visible.Equals(false);
            gbProveedor.Visible.Equals(false);
        }

        private void cboPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seleccion = cboPersonal.SelectedIndex;
            if (seleccion != 1)
            {
                switch (cboPersonal.ValueMember)
                {
                    case "Medico":
                        LimpiarPantalla();
                        gbMedico.Visible = true;
                        break;
                    case "Cliente":
                        LimpiarPantalla();
                        gbCliente.Visible = true;
                        break;
                    case "Empleado":
                        LimpiarPantalla();
                        gbEmpleado.Visible = true;
                        break;
                    case "Proveedor":
                        LimpiarPantalla();
                        gbProveedor.Visible = true;
                        break;
                }
                
            }

        }

    }
}
