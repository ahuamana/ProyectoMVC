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

namespace WindowsFormsApp1
{
    public partial class Vlogin : Form
    {
        public Vlogin()
        {
            InitializeComponent();
        }

        //DLL para mover ventanas
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;

        }

        private void txtUser_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "EMAIL")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.White;
            }

        }

        private void txtUser_Leave(object sender, EventArgs e)
        {

            if (txtUser.Text == "")
            {
                txtUser.Text = "EMAIL";

            }

        }

        private void txtxPassword_Enter(object sender, EventArgs e)
        {

            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
            }

        }

        private void txtxPassword_Leave(object sender, EventArgs e)
        {

            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.UseSystemPasswordChar = false;
            }

        }

        private void Vlogin_MouseDown(object sender, MouseEventArgs e)
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

        private void btnAcceder_Click(object sender, EventArgs e)
        {

            Clogin login01 = new Clogin();
            bool resultado = login01.login(txtUser.Text, txtPass.Text);



            if (txtUser.Text == "EMAIL")
            {
                errormessage("Ingrese su email");

            }
            else
            {
                if (txtPass.Text == "CONTRASEÑA")

                {
                    errormessage("Ingrese su contraseña");
                }
                else
                {
                    if (txtUser.Text == string.Empty || txtPass.Text == string.Empty)
                    {

                        errormessage("Complete los campos requeridos");


                    }
                    else

                    {
                        if (resultado)
                        {
                            MainPrincipal vtnprincipal = new MainPrincipal();
                            vtnprincipal.Show();
                            this.Hide();

                        }
                        else { errormessage("Usuario y/o contraseña invalidos"); }
                    }
                }

            }


        }


        private void errormessage(string msg)
        {

            lblErrorMessage.Text = "     " + msg;
            lblErrorMessage.Visible = true;


        }



    }
}
