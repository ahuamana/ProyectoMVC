using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Cventas
    {

        private int num = 0;

        public void ingresarVentas(string numFactura, string codigoCliente, string Vendedor, string fechaActual, string comprobante, DataTable DTDETALLE)
        {

            Mventas venta = new Mventas();
            venta.IngresarVentas(numFactura, codigoCliente, Vendedor, fechaActual, comprobante, DTDETALLE);


        }


        public int obtenerNumFactura()
        {
            Mventas numerofactura = new Mventas();
            num=numerofactura.ObtenertblFactura();
            
        return num;
        }


    }
}
