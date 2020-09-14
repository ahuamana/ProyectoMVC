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

        public void mensajeError(string mensaje) {

            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
        }


        public void mensajeOK(string mensaje) {

            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }






        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Ccliente guardar01 = new Ccliente();
            guardar01.insertarCliente(txtCodCliente.Text, txtDniCliente.Text, txtNomCliente.Text, txtApeCliente.Text, txtDireCliente.Text,
                                        txtManCliente.Text, Convert.ToInt32(txtLotCliente.Text), txtTelCliente.Text, txtDesCliente.Text);

            mensajeOK("DATOS GUARDADOS CORRECTAMENTE!");
            ListarTablaFinal();


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            Ccliente actualizar01 = new Ccliente();
            actualizar01.actualizarCliente(txtDniCliente.Text, txtNomCliente.Text, txtApeCliente.Text, txtDireCliente.Text,
                                        txtManCliente.Text, Convert.ToInt32(txtLotCliente.Text), txtTelCliente.Text, txtDesCliente.Text, txtCodCliente.Text);

            mensajeOK("CLIENTE ACTUALIZADO CORRECTAMENTE!");
            ListarTablaFinal();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            Ccliente eliminar01 = new Ccliente();
            eliminar01.eliminarCliente(txtCodCliente.Text);


            mensajeOK("CLIENTE ELIMINADO CORRECTAMENTE!");
            ListarTablaFinal();

        }

        private void tblCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
    }
}
