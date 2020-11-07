using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Mproducto: Conexion
    {

        
        SqlCommand cmd = new SqlCommand();
        SqlDataReader LectorFilas;



        public DataTable consultarProducto()
        {

            DataTable tabla01 = new DataTable();

            cmd.Connection = abrirConexion();
            cmd.CommandText = "SP_C_T_PRODUCTOS";
            cmd.CommandType = CommandType.StoredProcedure;

            LectorFilas = cmd.ExecuteReader();
            tabla01.Load(LectorFilas);
            LectorFilas.Close();

            cerrarConexion();

            return tabla01;
        }


        public DataTable consultarPresentacion()
        {

            DataTable tabla02 = new DataTable();

            cmd.Connection = abrirConexion();
            cmd.CommandText = "SP_C_T_PRESENTACION";
            cmd.CommandType = CommandType.StoredProcedure;

            LectorFilas = cmd.ExecuteReader();
            tabla02.Load(LectorFilas);
            LectorFilas.Close();

            cerrarConexion();

            return tabla02;
        }


        public void agregarProducto(string nombre, string descripcion, int codigo_proveedor, double pcompra, double pventa, int codigo_presentacion)
        {
            cmd.Connection = abrirConexion();
            cmd.CommandText = "SP_A_T_PRODUCTOS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("PROD_NOMBRE",nombre);
            cmd.Parameters.AddWithValue("PROD_DESCRIPCION", descripcion);
            cmd.Parameters.AddWithValue("PROD_COD_PROVEEDOR", codigo_proveedor);
            cmd.Parameters.AddWithValue("PROD_PCOMPRA", pcompra);
            cmd.Parameters.AddWithValue("PROD_PVENTA", pventa);
            cmd.Parameters.AddWithValue("PROD_COD_PRESEN", codigo_presentacion);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cerrarConexion();
        }

        public void modificarProducto(string nombre, string descripcion, int codigo_proveedor, double pcompra, double pventa, int codigo_presentacion, int codigo_producto)
        {

            cmd.Connection = abrirConexion();
            cmd.CommandText = "SP_M_T_PRODUCTOS";
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
            cerrarConexion();

        }

        public void eliminarProducto(int codigo)
        {

            cmd.Connection = abrirConexion();
            cmd.CommandText = "SP_E_T_PRODUCTOS";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("PROD_COD", codigo);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cerrarConexion();
        }

        public DataTable BuscarProducto(string codigo)
        {

            DataTable tabla01 = new DataTable();

            cmd.Connection = abrirConexion();
            cmd.CommandText = "SP_B_T_PRODUCTO";
            cmd.Parameters.AddWithValue("BUSCAR", codigo);
            cmd.CommandType = CommandType.StoredProcedure;

            LectorFilas = cmd.ExecuteReader();
            tabla01.Load(LectorFilas);
            LectorFilas.Close();

            cerrarConexion();

            return tabla01;
        }


        public DataTable mostrarProductoYstock()
        {

            DataTable tabla01 = new DataTable();

            cmd.Connection = abrirConexion();
            cmd.CommandText = "SP_C_T_PRODUCTOS";
            cmd.CommandType = CommandType.StoredProcedure;

            LectorFilas = cmd.ExecuteReader();
            tabla01.Load(LectorFilas);
            LectorFilas.Close();

            cerrarConexion();

            return tabla01;
        }


    }
}
