using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace WindowsFormsApp1
{
    class Cproducto
    {


        public DataTable ConsultarProducto()
        {

            DataTable tblrecibir01;

            Mproducto consultar01 = new Mproducto();
            tblrecibir01 = consultar01.consultarProducto();
            return tblrecibir01;

        }

        public DataTable ConsultarPresentacion()
        {

            DataTable tblrecibir02;

            Mproducto consultar02 = new Mproducto();
            tblrecibir02 = consultar02.consultarPresentacion();
            return tblrecibir02;

        }



        public void AgregarProducto(string nombre, string descripcion, int codigo_proveedor, double pcompra, double pventa, int codigo_presentacion)
        {

            Mproducto agregar01 = new Mproducto();
            agregar01.agregarProducto(nombre, descripcion, codigo_proveedor, pcompra, pventa, codigo_presentacion);

        }


        public void ModificarProducto(string nombre, string descripcion, int codigo_proveedor, double pcompra, double pventa, int codigo_presentacion, int codigo_producto)
        {

            Mproducto modificar01 = new Mproducto();
            modificar01.modificarProducto(nombre, descripcion, codigo_proveedor, pcompra, pventa, codigo_presentacion, codigo_producto);


        }

        public void EliminarProducto(int codigo)
        {

            Mproducto eliminar01 = new Mproducto();
            eliminar01.eliminarProducto(codigo);


        }





    }
}
