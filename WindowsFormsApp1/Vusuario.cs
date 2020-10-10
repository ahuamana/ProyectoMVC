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
    public partial class Vusuario : Form
    {

        string sexo = null;
        

        public Vusuario()
        {
            InitializeComponent();
            listarUsuarios();

        }

        public void mensajeError(string mensaje)
        {

            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        public void mensajeOK(string mensaje)
        {

            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //validacion del checkbox

            if (rbtnMasculino.Checked || rbtnFemenino.Checked)
            {
                

                if (rbtnMasculino.Checked) sexo = "M";
                if (rbtnFemenino.Checked) sexo = "F";
                    
                    

                //validacion de campos vacios

                if (txtDocumento.Text == string.Empty || txtDireccion.Text == string.Empty || txtApellidos.Text == string.Empty ||
                    txtEmail.Text == string.Empty || txtNombres.Text == string.Empty || txtPassword.Text == string.Empty ||
                    txtTelefono.Text == string.Empty)
                {


                    mensajeError("Todos los campos deben ser completados");



                }
                else {

                    //Agrega un usuario    

                    Cusuario agregar01 = new Cusuario();
                    agregar01.insertarUsuario(txtNombres.Text,txtApellidos.Text,sexo,txtDocumento.Text,txtDireccion.Text,txtTelefono.Text, txtEmail.Text,txtPassword.Text);
                    mensajeOK("DATOS AGREGADOS CORRECTAMENTE!");
                    listarUsuarios();
                    limpiarCampos();
                    }



            }
            else {

                mensajeError("Seleccione el SEXO");

                 }


        }


        public void listarUsuarios() {

            Cusuario listar01 = new Cusuario();
            tblUsuario.DataSource=listar01.listarUsuarios();
        
        }

        public void limpiarCampos() {
            
            //Metodo limpiar campos
            txtApellidos.Clear();
            txtCod.Clear();
            txtDireccion.Clear();
            txtDocumento.Clear();
            txtEmail.Clear();
            txtNombres.Clear();
            txtPassword.Clear();
            txtTelefono.Clear();
            txtNombres.Focus();
        
        
        }


        private void Vusuario_Load(object sender, EventArgs e)
        {


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {


            //validacion del checkbox

            if (rbtnMasculino.Checked || rbtnFemenino.Checked)
            {


                if (rbtnMasculino.Checked) sexo = "M";
                if (rbtnFemenino.Checked) sexo = "F";



                //validacion de campos vacios

                if (txtDocumento.Text == string.Empty || txtDireccion.Text == string.Empty || txtApellidos.Text == string.Empty ||
                    txtEmail.Text == string.Empty || txtNombres.Text == string.Empty || txtPassword.Text == string.Empty ||
                    txtTelefono.Text == string.Empty || txtCod.Text == string.Empty)
                {


                    mensajeError("No seleccionaste una fila");



                }
                else
                {

                    //Actualizar un usuario    

                    Cusuario actualizar01 = new Cusuario();
                    actualizar01.actualizarUsuario(txtNombres.Text, txtApellidos.Text, sexo, txtDocumento.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text, txtPassword.Text, Convert.ToInt32( txtCod.Text));
                    mensajeOK("DATOS ACTUALIZADOS CORRECTAMENTE!");
                    listarUsuarios();
                    limpiarCampos();
                }



            }
            else
            {

                mensajeError("Seleccione el SEXO");

            }



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {


            //eliminar cliente

            try
            {
                string txtCodigo = this.txtCod.Text;


                if (this.txtCod.Text == string.Empty)
                {

                    mensajeError("Error seleccione un CLIENTE a eliminar");

                }

                else
                {


                    Cusuario eliminar01 = new Cusuario();
                    eliminar01.eliminarUsuario( Convert.ToInt32( txtCod.Text));


                    mensajeOK("DATO ELIMINADO CORRECTAMENTE!");
                    listarUsuarios();

                }
            }
            catch (Exception ev)
            {

                MessageBox.Show(ev.Message);

            }







        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            limpiarCampos();
        }

        private void tblUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            txtCod.Text = tblUsuario.SelectedRows[0].Cells[0].Value.ToString();
            txtNombres.Text= tblUsuario.SelectedRows[0].Cells[1].Value.ToString();
            txtApellidos.Text= tblUsuario.SelectedRows[0].Cells[2].Value.ToString();
              
                string sex= tblUsuario.SelectedRows[0].Cells[3].Value.ToString();
                if (sex == "M")
                {
                    rbtnMasculino.Checked = true;

                } else rbtnFemenino.Checked = true;
               

                
                txtDocumento.Text= tblUsuario.SelectedRows[0].Cells[4].Value.ToString();
                txtDireccion.Text= tblUsuario.SelectedRows[0].Cells[5].Value.ToString();
                txtTelefono.Text = tblUsuario.SelectedRows[0].Cells[6].Value.ToString();
                txtEmail.Text= tblUsuario.SelectedRows[0].Cells[7].Value.ToString();
                txtPassword.Text= tblUsuario.SelectedRows[0].Cells[9].Value.ToString();

            } catch (Exception ev)
            {
                mensajeError(ev.Message);
            
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtCod.Text == string.Empty)
                {
                    Cusuario buscar01 = new Cusuario();
                    tblUsuario.DataSource = buscar01.buscarUsuario(txtBuscar.Text);
                }
            }
            catch (Exception ev)
            {

                MessageBox.Show(ev.Message);

            }

        }
    }
}
