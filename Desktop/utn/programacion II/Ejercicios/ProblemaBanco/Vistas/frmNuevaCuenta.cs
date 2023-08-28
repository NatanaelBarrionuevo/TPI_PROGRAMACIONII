using ProblemaBanco.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProblemaBanco
{
    public partial class frmNuevaCuenta : Form
    {
        AccesoDatos oBd;
      

        public frmNuevaCuenta()
        {
            InitializeComponent();
            oBd = new AccesoDatos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmNuevaCuenta_Load(object sender, EventArgs e)
        {
            CargarCombo();
            InicializarComponentes();
     
        }

        private void InicializarComponentes()
        {
            int clave = oBd.ProximoCodigo();
            lblClaveCuenta.Text = "Proximo Codigo: " + clave;
            txtApellido.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDni.Text = string.Empty;
            cboTipoCuenta.Text = string.Empty;
        }

     

        private void CargarCombo()
        {
            cboTipoCuenta.DropDownStyle= ComboBoxStyle.DropDownList;
            DataTable tabla = new DataTable();
            tabla = oBd.CargarTabla(tabla);
           cboTipoCuenta.DataSource = tabla;

            cboTipoCuenta.ValueMember = "id_tipo_cuenta";
            cboTipoCuenta.DisplayMember = "tipo_cuenta";
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (cboTipoCuenta.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar un valor para el tipo de cuenta");
                cboTipoCuenta.Focus();
            }
            if (txtNombre.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe incluir un nombre");
                txtNombre.Focus();
            }
            if (txtApellido.Text.Equals(String.Empty))
            {
               MessageBox.Show("Debe incluir un Apellido");
                txtApellido.Focus();
            }
            if (txtDni.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe incluir un documento");
                txtDni.Focus();
            }

            int codigo = 1;
            string nombre=Convert.ToString(txtNombre.Text);
            string apellido =Convert.ToString(txtApellido.Text);
            string dni=Convert.ToString(txtDni.Text);
            

            Cliente c = new Cliente(codigo,nombre,apellido,dni);
           
            int respuestaBD= oBd.CargarCliente(c);

            if (respuestaBD>0)
            {
                MessageBox.Show("Se ingreso el registro con exito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error en la carga!");
            }

           
        }
    }
}
