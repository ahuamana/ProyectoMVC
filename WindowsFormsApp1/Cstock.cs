using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace WindowsFormsApp1
{
    class Cstock
    {


        public DataTable ConsultarStock()
        {

            DataTable tblrecibir01;

            Mstock consultar01 = new Mstock();
            tblrecibir01 = consultar01.consultarStock();
            return tblrecibir01;

        }


        public void AgregarStock(int codigo_producto, int cantidad, int stock_inicial)
        {

            Mstock agregar01 = new Mstock();
            agregar01.agregarStock(codigo_producto, cantidad, stock_inicial);

        }


        public void ModificarStock(int codigo_producto, int cantidad, int stock_inicial)
        {

            Mstock modificar01 = new Mstock();
            modificar01.disminuirStock(codigo_producto, cantidad, stock_inicial);

        }





    }
}
