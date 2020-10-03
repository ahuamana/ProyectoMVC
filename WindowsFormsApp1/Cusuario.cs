using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace WindowsFormsApp1
{
    class Cusuario
    {
        public DataTable listarUsuarios()
        {

            DataTable tblrecibir01 = new DataTable();

            Musuario listar01 = new Musuario();
            tblrecibir01 = listar01.listarUsuarios();

            return tblrecibir01;

        }


        public void insertarUsuario(string nombres, string apellidos, string sexo, string documento, string direccion, string telefono, string email, string password)
        {

            Musuario ingresar01 = new Musuario();
            ingresar01.insertarUsuarios(nombres, apellidos, sexo, documento, direccion, telefono, email, password);

        }


        public void actualizarUsuario(string nombres, string apellidos, string sexo,string documento, string direccion, string telefono, string email, string password, int codigo)
        {

            Musuario actualizar01 = new Musuario();
            actualizar01.actualizarUsuarios(nombres, apellidos, sexo, documento, direccion, telefono, email, password, codigo);


        }

        public void eliminarUsuario(int codigo)
        {

            Musuario eliminar01 = new Musuario();
            eliminar01.eliminarUsuarios(codigo);


        }
    }
}
