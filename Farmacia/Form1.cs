namespace Farmacia
{
    public partial class Form1 : Form
    {
        Menu menu;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == string.Empty)
            {
                //Validacion 
                MessageBox.Show("Escribir un Usuario", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (txtUsuario.Text != "admin")
                {
                    //Usuario no encontrado
                    MessageBox.Show("Usuario no encontrado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    if (txtPassword.Text == string.Empty)
                    {
                        //Escribir contraseña
                        MessageBox.Show("Escriba una contraseña lpm", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (txtPassword.Text != "1234")
                        {
                            //Password Incorrecta
                            MessageBox.Show("La contraseña es incorrecta", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            menu = new Menu();
                            menu.Show();
                            this.Hide();
                        }
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}