using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;


namespace WindowsFormsApp1
{
    class Cproveedor
    {


        public DataTable ConsultarProveedores()
        {

            DataTable tblrecibir01;

            Mproveedor consultar01 = new Mproveedor();
            tblrecibir01 = consultar01.consultarProveedores();
            return tblrecibir01;

        }


        public void AgregarProveedores(string ruc_dni, string nombre, string direccion, string email, string casa, string oficina, string referencia)
        {

            Mproveedor agregar01 = new Mproveedor();
            agregar01.agregarProveedores(ruc_dni, nombre, direccion, email, casa, oficina, referencia);

        }


        public void ModificarProveedores(string ruc_dni, string nombre, string direccion, string email, string casa, string oficina, string referencia, int codigo)
        {

            Mproveedor modificar01 = new Mproveedor();
            modificar01.modificarProveedores(ruc_dni, nombre, direccion, email, casa, oficina, referencia, codigo);


        }

        public void EliminarProveedores(int codigo)
        {

            Mproveedor eliminar01 = new Mproveedor();
            eliminar01.eliminarProveedores(codigo);


        }



        public DataTable BuscarProveedor(string codigo)
        {

            DataTable tblrecibir03;

            Mproveedor buscar01 = new Mproveedor();
            tblrecibir03 = buscar01.buscarProveedor(codigo);
            return tblrecibir03;

        }









    }
}
