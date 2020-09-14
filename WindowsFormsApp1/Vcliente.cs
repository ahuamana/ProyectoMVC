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
    public partial class Vcliente : Form
    {
        public Vcliente()
        {
            InitializeComponent();
            ListarTablaFinal();
        }


        public void ListarTablaFinal() {

            Ccliente lista01 = new Ccliente();

            tblCliente.DataSource = lista01.listarclientes2();
        
        
        }
    }
}
