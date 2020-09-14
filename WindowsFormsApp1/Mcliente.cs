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


        public void insertarCliente( string codigo, string dni_ruc, string nombres, string apellidos, string direccion, string manzana, int lote, string celular, string referencia) {


            cmd.Connection = newConexion.abrirConexion();
            cmd.CommandText = "SP_INSERTARCLIENTE";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("CODIGO",codigo);
            cmd.Parameters.AddWithValue("DNI_RUC",dni_ruc);
            cmd.Parameters.AddWithValue("NOMBRES",nombres);
            cmd.Parameters.AddWithValue("APELLIDOS",apellidos);
            cmd.Parameters.AddWithValue("DIRECCION",direccion);
            cmd.Parameters.AddWithValue("MANZANA",manzana);
            cmd.Parameters.AddWithValue("LOTE",lote);
            cmd.Parameters.AddWithValue("CELULAR",celular);
            cmd.Parameters.AddWithValue("REFERENCIA",referencia);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            newConexion.cerrarConexion();



        }


        public void actualizarCliente(string dni_ruc, string nombres, string apellidos, string direccion, string manzana, int lote, string celular, string referencia, string codigo)
        {

            cmd.Connection = newConexion.abrirConexion();
            cmd.CommandText = "SP_EDITARCLIENTE";
            cmd.CommandType = CommandType.StoredProcedure;

            
            cmd.Parameters.AddWithValue("DNI_RUC", dni_ruc);
            cmd.Parameters.AddWithValue("NOMBRES", nombres);
            cmd.Parameters.AddWithValue("APELLIDOS", apellidos);
            cmd.Parameters.AddWithValue("DIRECCION", direccion);
            cmd.Parameters.AddWithValue("MANZANA", manzana);
            cmd.Parameters.AddWithValue("LOTE", lote);
            cmd.Parameters.AddWithValue("CELULAR", celular);
            cmd.Parameters.AddWithValue("REFERENCIA", referencia);
            cmd.Parameters.AddWithValue("COD", codigo);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            newConexion.cerrarConexion();

        }

        public void eliminarCliente(string codigo) {

            cmd.Connection = newConexion.abrirConexion();
            cmd.CommandText = "SP_ELIMINARCLIENTE";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("CODIGO",codigo);
         
        }





    }
}
