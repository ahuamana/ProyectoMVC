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
    }
}
