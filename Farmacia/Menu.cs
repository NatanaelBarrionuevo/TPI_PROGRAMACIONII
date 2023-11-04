using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class Menu : Form
    {
        ABMC abmc;
        DatosPersonales ventanaDatos;
        public Menu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abmc = new ABMC();
            abmc.ShowDialog();
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventanaDatos = new DatosPersonales();
            ventanaDatos.ShowDialog();
        }
    }
}
