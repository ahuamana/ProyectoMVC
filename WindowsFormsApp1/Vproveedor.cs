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
    public partial class Vproveedor : Form
    {
        public Vproveedor()
        {
            InitializeComponent();
            consultar();
        }


        public void mensajeError(string mensaje)
        {
            //mensaje error

            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        public void mensajeOK(string mensaje)
        {
            //mensaje ok
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        public void consultar() {

            //consulta datos de la tabla proveedor

            Cproveedor consultar01 = new Cproveedor();
            tblProveedores.DataSource=consultar01.ConsultarProveedores();
        
        
        }


        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //agregar proveedor

            try
            {


                if (txtCasa.Text == string.Empty || txtDireccion.Text == string.Empty ||
                    txtEmail.Text == string.Empty || txtNombre.Text == string.Empty ||
                    txtOficina.Text == string.Empty || txtReferencia.Text == string.Empty ||
                    txtRUC_DNI.Text == string.Empty )


                {

                    mensajeError("Todos los campos deben estar rellenados");


                }
                else
                {



                    Cproveedor agregar01 = new Cproveedor();
                    agregar01.AgregarProveedores(txtRUC_DNI.Text, txtNombre.Text, txtDireccion.Text, txtEmail.Text,
                        txtCasa.Text, txtOficina.Text, txtReferencia.Text);

                    mensajeOK("Operacion Exitosa!");
                    limpiar();
                    consultar();

                }
            }
            catch (Exception ev)
            {

                MessageBox.Show(ev.Message);

            }

        }

      

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //actualizar proveedor

            try
            {


                if (txtCasa.Text == string.Empty || txtDireccion.Text == string.Empty ||
                    txtEmail.Text == string.Empty || txtNombre.Text == string.Empty ||
                    txtOficina.Text == string.Empty || txtReferencia.Text == string.Empty ||
                    txtRUC_DNI.Text == string.Empty)


                {

                    mensajeError("Todos los campos deben estar rellenados");


                }
                else
                {

                    Cproveedor actualizar01 = new Cproveedor();
                    actualizar01.ModificarProveedores(txtRUC_DNI.Text, txtNombre.Text, txtDireccion.Text, txtEmail.Text,
                        txtCasa.Text, txtOficina.Text, txtReferencia.Text,Convert.ToInt32(txtCod.Text));

                    mensajeOK("Operacion Exitosa!");
                    limpiar();
                    consultar();

                }
            }
            catch (Exception ev)
            {

                MessageBox.Show(ev.Message);

            }





        }

        private void button3_Click(object sender, EventArgs e)
        {
            //eliminar proveedor
          
            try
            {
                string txtCodigo = this.txtCod.Text;


                if (this.txtCod.Text == string.Empty)
                {

                    mensajeError("Error seleccione una fila a eliminar");

                }

                else
                {

                    Cproveedor eliminar01 = new Cproveedor();
            eliminar01.EliminarProveedores(Convert.ToInt32(txtCod.Text));

            mensajeOK("Operacion Exitosa!");
            limpiar();
            consultar();

                }
            }
            catch (Exception ev)
            {

                MessageBox.Show(ev.Message);

            }

        }


        private void tblProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pasar a los text box

            txtCod.Text = tblProveedores.SelectedRows[0].Cells[0].Value.ToString();
            txtRUC_DNI.Text = tblProveedores.SelectedRows[0].Cells[1].Value.ToString();
            txtNombre.Text = tblProveedores.SelectedRows[0].Cells[2].Value.ToString();
            txtDireccion.Text = tblProveedores.SelectedRows[0].Cells[3].Value.ToString();
            txtEmail.Text = tblProveedores.SelectedRows[0].Cells[4].Value.ToString();
            txtCasa.Text = tblProveedores.SelectedRows[0].Cells[5].Value.ToString();
            txtOficina.Text = tblProveedores.SelectedRows[0].Cells[6].Value.ToString();
            txtReferencia.Text = tblProveedores.SelectedRows[0].Cells[7].Value.ToString();




        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();

        }

        public void limpiar() {

            //metodo para limpiar los text box

            txtRUC_DNI.Clear();
            txtCasa.Clear();
            txtCod.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            txtNombre.Clear();
            txtOficina.Clear();
            txtReferencia.Clear();
            txtRUC_DNI.Focus();


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cproveedor buscar01 = new Cproveedor();
            tblProveedores.DataSource = buscar01.BuscarProveedor(txtRUC_DNI.Text);


        }
    }
}
