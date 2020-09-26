using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    class Mstock
    {

        Conexion newConexion = new Conexion();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader LectorFilas;



        public DataTable consultarStock()
        {

            DataTable tabla01 = new DataTable();

            cmd.Connection = newConexion.abrirConexion();
            cmd.CommandText = "SP_C_STOCK";
            cmd.CommandType = CommandType.StoredProcedure;

            LectorFilas = cmd.ExecuteReader();
            tabla01.Load(LectorFilas);
            LectorFilas.Close();

            newConexion.cerrarConexion();

            return tabla01;
        }



        public void agregarStock(int codigo_producto, int cantidad, int stock_inicial)
        {



            cmd.Connection = newConexion.abrirConexion();
            cmd.CommandText = "SP_A_STOCK";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("STOC_COD_PRODUCTO", codigo_producto);
            cmd.Parameters.AddWithValue("CANTIDAD", cantidad);
            cmd.Parameters.AddWithValue("STOC_INICIAL", stock_inicial );
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            newConexion.cerrarConexion();



        }

        public void disminuirStock(int codigo_producto, int cantidad, int stock_inicial)
        {



            cmd.Connection = newConexion.abrirConexion();
            cmd.CommandText = "SP_M_STOCK";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("STOC_COD_PRODUCTO", codigo_producto);
            cmd.Parameters.AddWithValue("CANTIDAD", cantidad);
            cmd.Parameters.AddWithValue("STOC_INICIAL", stock_inicial);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            newConexion.cerrarConexion();



        }











    }
}
