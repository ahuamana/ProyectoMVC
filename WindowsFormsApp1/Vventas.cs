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
    public partial class Vventas : Form
    {

        public DataTable dtDetalle;
        private double totalpagado=0;
        private int Numfactura;
        private double des=0;
        public int codProductoSelec;

        public Vventas()
        {
            InitializeComponent();
            txtDescuento.Text = "0";
            crearTabla();
            ObtenerFactura();
            listarBoletas();
            NumConCeros();
            obtenerImpresoras();


        }

        private DateTime fechaActual = DateTime.Now;


        private void NumConCeros()
        {
           string resultadoBoletas= null;

           int numeroOrig = ObtenerFactura();



            if (numeroOrig >= 1000000)
                resultadoBoletas = "0" + numeroOrig;
            else {

                if (numeroOrig >= 100000)
                    resultadoBoletas = "00" + numeroOrig;

                else {


                    if (numeroOrig >= 10000)
                        resultadoBoletas = "000" + numeroOrig;
                    else {


                        if (numeroOrig >= 1000)
                            resultadoBoletas = "0000" + numeroOrig;

                        else
                        {
                            if (numeroOrig >= 100)
                                resultadoBoletas = "00000" + numeroOrig;
                            else {

                                if (numeroOrig >= 10)
                                    resultadoBoletas = "000000" + numeroOrig;
                                else {

                                    if (numeroOrig >= 1)
                                        resultadoBoletas = "0000000" + numeroOrig;
                                }

                            }
                        }


                    }

                    

                }
                

            }



            lblNumFactura.Text = resultadoBoletas.ToString();




        }





        private void MensajeError(string mensaje) {

            MessageBox.Show(mensaje, "Sistema Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }

        public int ObtenerFactura() {

           Cventas objnumfactura = new Cventas();
           Numfactura = objnumfactura.obtenerNumFactura();




            if (Numfactura > 0)
            {
                Numfactura += 1;


               
            }

            else  {

                Numfactura = 1;
                            
                  }

            return Numfactura;
        
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFechaActual.Text = DateTime.Now.ToShortDateString();
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        

        private void button5_Click(object sender, EventArgs e)
        {

           
        }

        private void button11_Click(object sender, EventArgs e)
        {

            try {


                if (this.txtCantidad.Text == string.Empty || this.txtCodCliente.Text == string.Empty
                    || this.txtDescuento.Text == string.Empty || this.txtCodProducto.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    
                }
                else
                {

                    bool registrar = true;

                    foreach (DataRow row in dtDetalle.Rows)
                    {
                        if ( Convert.ToInt32(row["CProducto"]) ==  Convert.ToInt32( txtCodProducto.Text))
                        {
                            registrar = false;
                            this.MensajeError("Ya se encuentra un producto en el Detalle");
                        
                        }
                        
                    
                    }


                    if (registrar && Convert.ToInt32(txtCantidad.Text) <= Convert.ToInt32(txtProStock.Text))
                    {
                        double subTotal = Math.Round( (Convert.ToInt32(txtCantidad.Text) * Convert.ToDouble(txtProPrecio.Text)),  2);
                                        totalpagado = totalpagado + subTotal;

                         des += Convert.ToDouble(txtDescuento.Text) * Convert.ToInt32(txtCantidad.Text) ;

                                        DataRow row = dtDetalle.NewRow();

                                        row["CProducto"] = Convert.ToInt32(txtCodProducto.Text);
                                        row["Nombre Producto"] = txtNomProducto.Text;
                                        row["Presentacion"] = txtPresentacion.Text;
                                        row["Cantidad"] = Convert.ToInt32(txtCantidad.Text);
                                        row["Descuento"] = Convert.ToDouble(txtDescuento.Text) * Convert.ToInt32(txtCantidad.Text);
                                        row["Precio"] = Convert.ToDouble(txtProPrecio.Text);
                                        row["SubTotal"] = subTotal;

                                        this.dtDetalle.Rows.Add(row);

                                        //Asginar el descuento al campo txt
                                        txtDescuentoFinal.Text = des.ToString();

                                        //Asignar el subtotal
                                        txtSubtotalfinal.Text = totalpagado.ToString();

                                        //Asignar el Total
                                        txtTotalfinal.Text = (totalpagado - des).ToString();
                                        this.limpiarCamposProducto();

                                    }



                                    else if (Convert.ToInt32(txtCantidad.Text)  > Convert.ToInt32(txtProStock.Text))
                                    {

                                        MensajeError("No hay stock suficiente! en nuestro Almacen");


                                    }

                      

                }

             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

}


        public void crearTabla() {

            this.dtDetalle = new DataTable("Detalle");

            this.dtDetalle.Columns.Add("CProducto", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Nombre Producto", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Presentacion", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Cantidad", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Descuento", System.Type.GetType("System.Double"));
            this.dtDetalle.Columns.Add("Precio", System.Type.GetType("System.Double"));
            this.dtDetalle.Columns.Add("SubTotal", System.Type.GetType("System.Double"));

            tblVentas.DataSource = dtDetalle;
          

        }


        public void limpiarCamposProducto() {

            txtCodProducto.Clear();
            txtNomProducto.Clear();
            txtProPrecio.Clear();
            txtPresentacion.Clear();
            txtProStock.Clear();
            txtCantidad.Clear();
            txtDescuento.Text = "0";
            
        
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tblVentas.Rows.Count > 0)

                {

                    int indiceFila = this.tblVentas.CurrentCell.RowIndex;
                    DataRow row = this.dtDetalle.Rows[indiceFila];
                    //Disminuir el totalPAgado
                    this.totalpagado = this.totalpagado - Convert.ToDouble(row["subtotal"].ToString());
                    this.txtSubtotalfinal.Text = totalpagado.ToString();
                    

                    //Dismuir Descuento
                    this.des = this.des - Convert.ToDouble(row["Descuento"].ToString());
                    txtDescuentoFinal.Text = des.ToString();

                    //Dismiur Total
                    

                    //Removemos la fila
                    this.dtDetalle.Rows.Remove(row);

                }
                else {

                    MensajeError("No hay fila para remover");

                    }

            }
            
           

            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);
            }




        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
           

            if (tblVentas.Rows.Count != 0)
            {

                string tipodecomprobante = "Boleta";
                string txtVendedorDefecto = "73962071";

                Cventas venta01 = new Cventas();
                venta01.ingresarVentas(lblNumFactura.Text, txtCodCliente.Text, txtVendedorDefecto, lblFechaActual.Text, tipodecomprobante, dtDetalle);


                ObtenerFactura();
                
                //listar numero de boleta
                listarBoletas();

                
                


                MessageBox.Show("Se guardó correctamente la factura!", "Sistema Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //llamar a crear el ticket
                ////ObtenerTicket();

                //llamar a imprimir Boleta
                //ImprimirBoleta vtn01 = new ImprimirBoleta(dtDetalle, txtNomCliente.Text,txtApeCliente.Text,txtDirecCliente.Text, txtDNICliente.Text,fechaActual,
                //lblNumFactura.Text, Convert.ToDouble(txtSubtotalfinal.Text), Convert.ToDouble(txtDescuentoFinal.Text), Convert.ToDouble(txtTotalfinal.Text));                
                //vtn01.Show();

                //asigna el nuevo numero de boleta
                NumConCeros();

                //Limpiar todos los campos del datatable y los campos
                LimpiarTodosLosCampos();

                




            }
            else {

                MensajeError("Ningun producto para Guardar");
            
            }





        }

        public void LimpiarTodosLosCampos() {

            txtCodCliente.Clear();
            txtCantidad.Clear();
            txtCodProducto.Clear();
            txtDescuento.Clear();
            txtDescuento.Text = "0";
            txtNomCliente.Clear();
            txtNomProducto.Clear();
            txtProPrecio.Clear();
            txtProStock.Clear();
            txtVendedor.Clear();
            txtPresentacion.Clear();
            
            dtDetalle.Clear();
            
            tblVentas.DataSource = dtDetalle;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            LimpiarTodosLosCampos();

        }


        public void listarBoletas() {


           Cventas listar01 = new Cventas();
            
            //tblBoletas.DataSource = null;
            //tblBoletas.DataSource=listar01.ListarBoletas();

            


        }


        //metodo para llenar el combo box con las impresoras instalas actuales

        public void obtenerImpresoras() {

            cmbImpresoras.Text = "Microsoft Print to PDF";

            foreach (string name  in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                
                cmbImpresoras.Items.Add(name.ToString());
               
                
            }
            

        }

        //evento para que el combo box sea de solo lectura
        private void cmbImpresoras_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = true;

        }

        private void btnSeleccionarCliente(object sender, EventArgs e)
        {
            Vcliente ventana01 = new Vcliente();
            AddOwnedForm(ventana01);
            ventana01.Show();

        }

        private void btnSeleccionarProducto_Click(object sender, EventArgs e)
        {

            VstockYproductos ventana01 = new VstockYproductos();
            AddOwnedForm(ventana01);
            ventana01.Show();
        }

        //Crea el metodo para imprimir el ticket

        //public void ObtenerTicket() {

        //    clsimprimir.CreaTicket Ticket1 = new clsimprimir.CreaTicket();

        //    Ticket1.TextoCentro("Distribuidora Top Star Life "); //imprime una linea de descripcion
        //    Ticket1.TextoCentro("**********************************");

        //    Ticket1.TextoIzquierda("Direc: Av. Alameda N°311 Coop. Santa Isabel");
        //    Ticket1.TextoIzquierda("Tel: 064-624757");
        //    Ticket1.TextoIzquierda("Cel: 969368282");
        //    Ticket1.TextoIzquierda("Ruc: 20603591250");
        //    Ticket1.TextoIzquierda("");
        //    Ticket1.TextoCentro("Boleta de Venta"); //imprime una linea de descripcion
        //    Ticket1.TextoIzquierda("N° Boleta: " + lblNumFactura.Text.ToString());
        //    Ticket1.TextoIzquierda("Fecha: " + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
        //    Ticket1.TextoIzquierda("Le Atendio: xxxx");
        //    Ticket1.TextoIzquierda("");


        //    clsimprimir.CreaTicket.LineasGuion();//-------------------------
        //    clsimprimir.CreaTicket.EncabezadoVenta();
        //    clsimprimir.CreaTicket.LineasGuion();

        //Detalle de la factura

        //foreach (DataGridViewRow r in tblVentas.Rows)
        //{
        //    // Articulo                     //Precio                                    cantidad                            Subtotal
        //    Ticket1.AgregaArticulo(r.Cells[0].Value.ToString(), double.Parse(r.Cells[5].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[6].Value.ToString())); //imprime una linea de descripcion


        //}



        //Detalle de totales de la factura

        //clsimprimir.CreaTicket.LineasGuion();
        //        Ticket1.AgregaTotales("Sub-Total", double.Parse(txtSubtotalfinal.Text)); // imprime linea con Subtotal
        //        Ticket1.AgregaTotales("Descuento", double.Parse(txtDescuentoFinal.Text)); // imprime linea con decuento total
        //        Ticket1.AgregaTotales("Mas ITBIS", double.Parse("000")); // imprime linea con ITBis total
        //        Ticket1.TextoIzquierda(" ");
        //        Ticket1.AgregaTotales("Total", double.Parse(txtTotalfinal.Text)); // imprime linea con total
        //        Ticket1.TextoIzquierda(" ");

        //        Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(textBox3.Text));
        //        Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(lbldevolucion.Text));




        // Ticket1.LineasTotales(); // imprime linea 

        //Ticket1.TextoIzquierda(" ");
        //Ticket1.TextoCentro("**********************************");
        //Ticket1.TextoCentro("*     Gracias por su compra      *");
        //Ticket1.TextoCentro("**********************************");
        //Ticket1.TextoIzquierda(" ");

        ////Obtiene los datos de la impresora del combobox
        //Ticket1.ImprimirTiket(cmbImpresoras.Text); //Imprimir




        //}




    }
}
