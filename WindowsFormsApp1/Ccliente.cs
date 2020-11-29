using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

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


        public void insertarCliente(string codigo, string dni_ruc, string nombres, string apellidos, string direccion, string manzana, int lote, string celular, string referencia) {

            Mcliente ingresar01 = new Mcliente();
            ingresar01.insertarCliente(codigo, dni_ruc, nombres, apellidos,direccion, manzana, lote, celular, referencia);
                    
        }


        public void actualizarCliente(string dni_ruc, string nombres, string apellidos, string direccion, string manzana, int lote, string celular, string referencia, string codigo) {

            Mcliente actualizar01 = new Mcliente();
            actualizar01.actualizarCliente(dni_ruc, nombres, apellidos, direccion, manzana, lote, celular, referencia, codigo);


        }

        public void eliminarCliente(string codigo)
        {

            Mcliente eliminar01 = new Mcliente();
            eliminar01.eliminarCliente(codigo);


        }

        public DataTable buscarCliente(string codigo)
        {

            DataTable tblrecibir03;

            Mcliente buscar01 = new Mcliente();
            tblrecibir03 = buscar01.BuscarCliente(codigo);
            return tblrecibir03;

        }


    }
}
