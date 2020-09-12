using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    class Mcliente
    {

        Conexion newConexion = new Conexion();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader LectorFilas;

    

        public DataTable listarClientes() {

            DataTable tabla01 = new DataTable();

            cmd.Connection = newConexion.abrirConexion();
            cmd.CommandText = "SP_LISTARCLIENTES";
            cmd.CommandType = CommandType.StoredProcedure;

            LectorFilas = cmd.ExecuteReader();
            tabla01.Load(LectorFilas);
            LectorFilas.Close();

            newConexion.cerrarConexion();

            return tabla01;
        }


    }
}
