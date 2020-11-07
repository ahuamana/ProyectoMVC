using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Menu
{
    public partial class VstockYproductos : Form
    {
        public VstockYproductos()
        {
            InitializeComponent();
            listarStockProductos();
        }


        public void listarStockProductos() {

            CstockYproductos listar = new CstockYproductos();
            tblStock_Productos.DataSource = listar.listarStockVsProductos();
        
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {

            CstockYproductos listar2 = new CstockYproductos();
            tblStock_Productos.DataSource=listar2.buscarStockVsProductos(txtBuscar.Text);


        }

        private void tblStock_Productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {



            try
            {

                Vventas ventanaSon = Owner as Vventas;

                ventanaSon.txtPresentacion.Text = tblStock_Productos.SelectedRows[0].Cells[0].Value.ToString();
                ventanaSon.txtNomProducto.Text = tblStock_Productos.SelectedRows[0].Cells[1].Value.ToString();
                ventanaSon.txtProPrecio.Text = tblStock_Productos.SelectedRows[0].Cells[3].Value.ToString();
                ventanaSon.txtProStock.Text = tblStock_Productos.SelectedRows[0].Cells[4].Value.ToString();
                ventanaSon.txtCodProducto.Text = tblStock_Productos.SelectedRows[0].Cells[5].Value.ToString();
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }
    }
}
