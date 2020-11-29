using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    class Mcliente:Conexion
    {

       
        SqlCommand cmd = new SqlCommand();
        SqlDataReader LectorFilas;

    

        public DataTable listarClientes() {

            DataTable tabla01 = new DataTable();

            cmd.Connection = abrirConexion();
            cmd.CommandText = "SP_C_T_CLIENTE";
            cmd.CommandType = CommandType.StoredProcedure;

            LectorFilas = cmd.ExecuteReader();
            tabla01.Load(LectorFilas);
            LectorFilas.Close();

            cerrarConexion();

            return tabla01;
        }


        public void insertarCliente( string codigo, string dni_ruc, string nombres, string apellidos, string direccion, string manzana, int lote, string celular, string referencia) {



            cmd.Connection = abrirConexion();
            cmd.CommandText = "SP_A_T_CLIENTE";
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
            cerrarConexion();



        }


        public void actualizarCliente(string dni_ruc, string nombres, string apellidos, string direccion, string manzana, int lote, string celular, string referencia, string codigo)
        {

            cmd.Connection = abrirConexion();
            cmd.CommandText = "SP_M_T_CLIENTE";
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
            cerrarConexion();

        }

        public void eliminarCliente(string codigo) {

            cmd.Connection =abrirConexion();
            cmd.CommandText = "SP_E_T_CLIENTE";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("CODIGO",codigo);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cerrarConexion();

        }

        public DataTable BuscarCliente(string codigo)
        {

            DataTable tabla01 = new DataTable();

            cmd.Connection = abrirConexion();
            cmd.CommandText = "SP_B_T_CLIENTE";
            cmd.Parameters.AddWithValue("BUSCAR", codigo);
            cmd.CommandType = CommandType.StoredProcedure;

            LectorFilas = cmd.ExecuteReader();
            tabla01.Load(LectorFilas);
            LectorFilas.Close();

            cerrarConexion();

            return tabla01;
        }



    }
}
