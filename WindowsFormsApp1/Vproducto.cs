﻿using System;
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
    public partial class Vproducto : Form
    {
        public Vproducto()
        {
            InitializeComponent();
            consultarProveedores();
            consultarPresentacion();
            consultarProducto();
            consultarStock();

        }

        public void mensajeError(string mensaje)
        {

            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        public void mensajeOK(string mensaje)
        {

            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }




        public void consultarProveedores() {

            //consulta tabla proveedores y lo envia al combobox

            Cproveedor consulta01 = new Cproveedor();
            cmbProd_Proveedor.DataSource=consulta01.ConsultarProveedores();
            cmbProd_Proveedor.DisplayMember = "NOMBRE_PROVEEDOR";
            cmbProd_Proveedor.ValueMember = "PROV_COD";
        
        }

        public void consultarPresentacion()
        {
            //consulta tabla presentacion y lo envia al combobox

            Cproducto consulta02 = new Cproducto();
            cmbProd_Presentacion.DataSource = consulta02.ConsultarPresentacion();
            cmbProd_Presentacion.DisplayMember = "PRES_DESCRIPCION";
            cmbProd_Presentacion.ValueMember = "PRES_COD";

        }

        public void consultarProducto() { 
        
            //consulta los productos

            Cproducto consulta03 = new Cproducto();
            tblProductos.DataSource=consulta03.ConsultarProducto();
                
        }



        private void btnProd_Agregar_Click(object sender, EventArgs e)
        {
            //Agregar producto

            Cproducto agregar01 = new Cproducto();
            agregar01.AgregarProducto(txtProd_Nombre.Text,txtProd_Descripcion.Text,
                                    Convert.ToInt32(cmbProd_Proveedor.SelectedValue), Convert.ToDouble(txtProd_Pcompra.Text),
                                    Convert.ToDouble(txtProd_Pventa.Text), Convert.ToInt32( cmbProd_Presentacion.SelectedValue));

            mensajeOK("Operacion Exitosa!");
            limpiar();
            consultarProducto();
            consultarStock();

        }

        private void btnProd_Actualizar_Click(object sender, EventArgs e)
        {
            //Actualiza un producto

            Cproducto modificar01 = new Cproducto();
            modificar01.ModificarProducto(txtProd_Nombre.Text, txtProd_Descripcion.Text,
                                    Convert.ToInt32(cmbProd_Proveedor.SelectedValue), Convert.ToDouble(txtProd_Pcompra.Text),
                                    Convert.ToDouble(txtProd_Pventa.Text), Convert.ToInt32(cmbProd_Presentacion.SelectedValue),
                                    Convert.ToInt32(txtProd_Codigo.Text));



            mensajeOK("Operacion Exitosa!");
            limpiar();
            consultarProducto();
            consultarStock();
        }

        private void btnProd_Eliminar_Click(object sender, EventArgs e)
        {

            //Eliminar un producto

            Cproducto eliminar01 = new Cproducto();
            eliminar01.EliminarProducto(Convert.ToInt32(txtProd_Codigo.Text));

            mensajeOK("Operacion Exitosa!");
            limpiar();
            consultarProducto();
            consultarStock();

        }

        private void btnProd_Nuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            //limpia todos los campos

            txtProd_Descripcion.Clear();
            txtProd_Nombre.Clear();
            txtProd_Pcompra.Clear();
            txtProd_Pventa.Clear();
        }

        private void tblProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //pasar a los text box

            txtProd_Codigo.Text = tblProductos.SelectedRows[0].Cells[0].Value.ToString();
            txtProd_Nombre.Text = tblProductos.SelectedRows[0].Cells[1].Value.ToString();
            txtProd_Pcompra.Text = tblProductos.SelectedRows[0].Cells[2].Value.ToString();
            txtProd_Pventa.Text = tblProductos.SelectedRows[0].Cells[3].Value.ToString();
            txtProd_Descripcion.Text = tblProductos.SelectedRows[0].Cells[4].Value.ToString();

            cmbProd_Proveedor.Text = tblProductos.SelectedRows[0].Cells[6].Value.ToString();
            cmbProd_Presentacion.Text = tblProductos.SelectedRows[0].Cells[8].Value.ToString();
            


        }

        private void btnStock_Agregar_Click(object sender, EventArgs e)
        {
            //agregar stock

            Cstock agregar01 = new Cstock();
            agregar01.AgregarStock( Convert.ToInt32(txtStock_Cod.Text), Convert.ToInt32( txtStock_Cantidad.Text), Convert.ToInt32( txtStock_Actual.Text ));

        }

        private void btnStock_Disminuir_Click(object sender, EventArgs e)
        {
            //disminuir stock

            Cstock disminuir01 = new Cstock();
            disminuir01.ModificarStock(Convert.ToInt32(txtStock_Cod.Text), Convert.ToInt32(txtStock_Cantidad.Text), Convert.ToInt32(txtStock_Actual.Text));


        }


        public void consultarStock() {

            //consultar stock

            Cstock consultar01 = new Cstock();
            tblStock.DataSource=consultar01.ConsultarStock();
        
        }

        private void tblStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //pasar datos a los tex box

            txtStock_Cod.Text = tblProductos.SelectedRows[0].Cells[0].Value.ToString();
            txtStock_Nom.Text = tblProductos.SelectedRows[0].Cells[1].Value.ToString();
            txtStock_Actual.Text = tblProductos.SelectedRows[0].Cells[3].Value.ToString();


        }
    }
}