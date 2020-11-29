using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Libreria para mover ventanas
using System.Runtime.InteropServices;
using Menu;

namespace WindowsFormsApp1
{
    public partial class MainPrincipal : Form
    {
        public MainPrincipal()
        {
            InitializeComponent();
        }

        //DLL para mover ventanas
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            //Evento Mouse Down para mover las ventanas
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void MainPrincipal_MouseDown(object sender, MouseEventArgs e)
        {

            //Evento Mouse Down para mover las ventanas
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            //Evento Mouse Down para mover las ventanas
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            //Evento Mouse Down para mover las ventanas
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);


        }

        private void fACTURASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vventas vtn01 = new Vventas();
            vtn01.Show();


        }

        private void cPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {

            VstockYproductos vtn01 = new VstockYproductos();
            vtn01.Show();

        }

        private void rEPORTESToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Hace referencia al formulario VreporteVentas
            formularioEnvio vtn01 = new formularioEnvio();
            vtn01.Show();
           

        }
    }
}
