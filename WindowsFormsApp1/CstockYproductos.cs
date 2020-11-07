using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CstockYproductos
    {

        public DataTable listarStockVsProductos() {
           
            
            MstockYproductos lista01 =new MstockYproductos();
            DataTable tabla01 = new DataTable();
            tabla01=lista01.ListarStockVsProductos();

            return tabla01;
        }

        public DataTable buscarStockVsProductos(string codigo)
        {


            MstockYproductos lista01 = new MstockYproductos();
            DataTable tabla01 = new DataTable();
            tabla01 = lista01.BuscarStockVsProductos(codigo);

            return tabla01;
        }

    }
}
