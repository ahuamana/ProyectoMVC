using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainPrincipal : Form
    {
        public MainPrincipal()
        {
            InitializeComponent();
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {

            Vcliente vtn01 = new Vcliente();
            vtn01.Show();


        }

        private void menuProveedores_Click(object sender, EventArgs e)
        {
            Vproveedor vtn02 = new Vproveedor();
            vtn02.Show();


        }

        private void menuProductos_Click(object sender, EventArgs e)
        {

            Vproducto vtn03 = new Vproducto();
            vtn03.Show();

        }

        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Vusuario vtn04 = new Vusuario();
            vtn04.Show();


        }
    }
}
