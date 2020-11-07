using Menu;
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

            //lista tabla cliente

            Ccliente lista01 = new Ccliente();

            tblCliente.DataSource = lista01.listarclientes2();
        
        
        }

        public void mensajeError(string mensaje) {

            //metodo mensaje error

            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
        }


        public void mensajeOK(string mensaje) {

            //metodo mensaje ok

            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        
        


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //agregar nuevo cliente


            try
            {


                if (txtApeCliente.Text == string.Empty || txtCodCliente.Text == string.Empty ||
                    txtDesCliente.Text == string.Empty || txtDireCliente.Text == string.Empty ||
                    txtDniCliente.Text == string.Empty || txtLotCliente.Text == string.Empty ||
                    txtManCliente.Text == string.Empty || txtNomCliente.Text == string.Empty ||
                    txtTelCliente.Text == string.Empty)


                {

                    mensajeError("Todos los campos deben estar rellenados");


                }
                else
                { 

                    Ccliente guardar01 = new Ccliente();
                    guardar01.insertarCliente(txtCodCliente.Text, txtDniCliente.Text, txtNomCliente.Text, txtApeCliente.Text, txtDireCliente.Text,
                                        txtManCliente.Text, Convert.ToInt32(txtLotCliente.Text), txtTelCliente.Text, txtDesCliente.Text);

                    mensajeOK("DATOS GUARDADOS CORRECTAMENTE!");
                    ListarTablaFinal();

                }
            }
            catch (Exception ev)
            {

                MessageBox.Show(ev.Message);

            }


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //actualizar cliente

            try
            {


                if (txtApeCliente.Text == string.Empty || txtCodCliente.Text == string.Empty ||
                    txtDesCliente.Text == string.Empty || txtDireCliente.Text == string.Empty ||
                    txtDniCliente.Text == string.Empty || txtLotCliente.Text == string.Empty ||
                    txtManCliente.Text == string.Empty || txtNomCliente.Text == string.Empty ||
                    txtTelCliente.Text == string.Empty)


                {

                    mensajeError("Todos los campos deben estar rellenados");


                }
                else
                {



                    Ccliente actualizar01 = new Ccliente();
                    actualizar01.actualizarCliente(txtDniCliente.Text, txtNomCliente.Text, txtApeCliente.Text, txtDireCliente.Text,
                                        txtManCliente.Text, Convert.ToInt32(txtLotCliente.Text), txtTelCliente.Text, txtDesCliente.Text, txtCodCliente.Text);

                    mensajeOK("DATOS ACTUALIZADO CORRECTAMENTE!");
                    ListarTablaFinal();


                }
            }
            catch (Exception ev)
            {

                MessageBox.Show(ev.Message);

            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //eliminar cliente

            try
            {
                string txtCodigo = this.txtCodCliente.Text;


                if (this.txtCodCliente.Text == string.Empty)
                {

                    mensajeError("Error seleccione un CLIENTE a eliminar");

                }

                else
                {


                    Ccliente eliminar01 = new Ccliente();
                    eliminar01.eliminarCliente(txtCodCliente.Text);


                    mensajeOK("CLIENTE ELIMINADO CORRECTAMENTE!");
                    ListarTablaFinal();

                }
            }
            catch (Exception ev)
            {

                MessageBox.Show(ev.Message);

            }

        }

        private void tblCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //pasar los datos de la tabla a los text box

            txtCodCliente.Text = tblCliente.SelectedRows[0].Cells[0].Value.ToString();
            txtDniCliente.Text = tblCliente.SelectedRows[0].Cells[1].Value.ToString();
            txtNomCliente.Text = tblCliente.SelectedRows[0].Cells[2].Value.ToString();
            txtApeCliente.Text = tblCliente.SelectedRows[0].Cells[3].Value.ToString();
            txtDireCliente.Text = tblCliente.SelectedRows[0].Cells[4].Value.ToString();

            txtManCliente.Text = tblCliente.SelectedRows[0].Cells[5].Value.ToString();
            txtLotCliente.Text = tblCliente.SelectedRows[0].Cells[6].Value.ToString();
            txtTelCliente.Text = tblCliente.SelectedRows[0].Cells[7].Value.ToString();
            txtDesCliente.Text = tblCliente.SelectedRows[0].Cells[8].Value.ToString();

        }

        public void nuevo() {

            //limpia todos los campos

            txtCodCliente.Clear();
            txtDniCliente.Clear();
            txtNomCliente.Clear();
            txtApeCliente.Clear();
            txtDireCliente.Clear();

            txtManCliente.Clear();
            txtLotCliente.Clear();
            txtTelCliente.Clear();
            txtDesCliente.Clear();


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {


        }

        private void tblCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Vventas ventanaSon = Owner as Vventas;

            try
            {

                ventanaSon.txtCodCliente.Text = tblCliente.SelectedRows[0].Cells[0].Value.ToString();
                ventanaSon.txtDNICliente.Text = tblCliente.SelectedRows[0].Cells[1].Value.ToString();
                ventanaSon.txtNomCliente.Text = tblCliente.SelectedRows[0].Cells[2].Value.ToString();
                ventanaSon.txtApeCliente.Text = tblCliente.SelectedRows[0].Cells[3].Value.ToString();
                ventanaSon.txtDirecCliente.Text = tblCliente.SelectedRows[0].Cells[4].Value.ToString();

                this.Close();
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);

            }

        }
    }
}
