using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Mproducto
    {

        Conexion newConexion = new Conexion();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader LectorFilas;



        public DataTable consultarProducto()
        {

            DataTable tabla01 = new DataTable();

            cmd.Connection = newConexion.abrirConexion();
            cmd.CommandText = "SP_C_PRODUCTOS";
            cmd.CommandType = CommandType.StoredProcedure;

            LectorFilas = cmd.ExecuteReader();
            tabla01.Load(LectorFilas);
            LectorFilas.Close();

            newConexion.cerrarConexion();

            return tabla01;
        }


        public DataTable consultarPresentacion()
        {

            DataTable tabla02 = new DataTable();

            cmd.Connection = newConexion.abrirConexion();
            cmd.CommandText = "SP_C_PRESENTACION";
            cmd.CommandType = CommandType.StoredProcedure;

            LectorFilas = cmd.ExecuteReader();
            tabla02.Load(LectorFilas);
            LectorFilas.Close();

            newConexion.cerrarConexion();

            return tabla02;
        }


        public void agregarProducto(string nombre, string descripcion, int codigo_proveedor, double pcompra, double pventa, int codigo_presentacion)
        {



            cmd.Connection = newConexion.abrirConexion();
            cmd.CommandText = "SP_A_PRODUCTOS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("PROD_NOMBRE",nombre);
            cmd.Parameters.AddWithValue("PROD_DESCRIPCION", descripcion);
            cmd.Parameters.AddWithValue("PROD_COD_PROVEEDOR", codigo_proveedor);
            cmd.Parameters.AddWithValue("PROD_PCOMPRA", pcompra);
            cmd.Parameters.AddWithValue("PROD_PVENTA", pventa);
            cmd.Parameters.AddWithValue("PROD_COD_PRESEN", codigo_presentacion);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            newConexion.cerrarConexion();



        }


        public void modificarProducto(string nombre, string descripcion, int codigo_proveedor, double pcompra, double pventa, int codigo_presentacion, int codigo_producto)
        {

            cmd.Connection = newConexion.abrirConexion();
            cmd.CommandText = "SP_M_PRODUCTOS";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("PROD_NOMBRE", nombre);
            cmd.Parameters.AddWithValue("PROD_DESCRIPCION", descripcion);
            cmd.Parameters.AddWithValue("PROD_COD_PROVEEDOR", codigo_proveedor);
            cmd.Parameters.AddWithValue("PROD_PCOMPRA", pcompra);
            cmd.Parameters.AddWithValue("PROD_PVENTA", pventa);
            cmd.Parameters.AddWithValue("PROD_COD_PRESEN", codigo_presentacion);

            cmd.Parameters.AddWithValue("PROD_COD", codigo_producto);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            newConexion.cerrarConexion();

        }

        public void eliminarProducto(int codigo)
        {

            cmd.Connection = newConexion.abrirConexion();
            cmd.CommandText = "SP_E_PRODUCTOS";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("PROD_COD", codigo);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            newConexion.cerrarConexion();
        }



    }
}
