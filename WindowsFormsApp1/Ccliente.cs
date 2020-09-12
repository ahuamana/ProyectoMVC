using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Ccliente
    {


        public DataTable listarclientes2() {

            DataTable tblrecibir01 = new DataTable();

            Mcliente listar01 = new Mcliente();
            tblrecibir01=listar01.listarClientes();

            return tblrecibir01;
        
        }


    }
}
