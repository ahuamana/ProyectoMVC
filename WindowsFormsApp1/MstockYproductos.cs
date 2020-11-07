using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class MstockYproductos: Conexion
    {

        SqlCommand cmd = new SqlCommand();
        SqlDataReader LectorFilas;


        public DataTable ListarStockVsProductos()
        {

            DataTable Tabla1 = new DataTable();
            cmd.Connection = abrirConexion();
            cmd.CommandText = "SP_C_T_STOCKYPRODUCTOS";
            cmd.CommandType = CommandType.StoredProcedure;


            LectorFilas = cmd.ExecuteReader();
            Tabla1.Load(LectorFilas);
            LectorFilas.Close();
            cerrarConexion();

            return Tabla1;


        }

        public DataTable BuscarStockVsProductos(string codigo)
        {

            DataTable Tabla2 = new DataTable();
            cmd.Connection = abrirConexion();
            cmd.CommandText = "SP_B_T_STOCKYPRODUCTOS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("BUSCAR", codigo);

            LectorFilas = cmd.ExecuteReader();
            Tabla2.Load(LectorFilas);
            LectorFilas.Close();
            cerrarConexion();

            return Tabla2;


        }

    }
}
