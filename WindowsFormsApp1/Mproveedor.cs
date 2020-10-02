using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Mproveedor :Conexion
    {


        
        SqlCommand cmd = new SqlCommand();
        SqlDataReader LectorFilas;



        public DataTable consultarProveedores()
        {

            DataTable tabla01 = new DataTable();

            cmd.Connection = abrirConexion();
            cmd.CommandText = "SP_C_T_PROVEEDORES";
            cmd.CommandType = CommandType.StoredProcedure;

            LectorFilas = cmd.ExecuteReader();
            tabla01.Load(LectorFilas);
            LectorFilas.Close();

            cerrarConexion();

            return tabla01;
        }


        public void agregarProveedores(string ruc_dni, string nombre, string direccion, string email, string casa, string oficina, string referencia)
        {



            cmd.Connection = abrirConexion();
            cmd.CommandText = "SP_A_T_PROVEEDORES";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("PROV_RUC_DNI", ruc_dni);
            cmd.Parameters.AddWithValue("PROV_NOM", nombre);
            cmd.Parameters.AddWithValue("PROV_DIRECC", direccion);
            cmd.Parameters.AddWithValue("PROV_EMAIL", email);
            cmd.Parameters.AddWithValue("PROV_TELEF_CASA", casa);
            cmd.Parameters.AddWithValue("PROV_TELEF_OFICINA", oficina);
            cmd.Parameters.AddWithValue("PROV_REFERENCIA ", referencia);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cerrarConexion();



        }


        public void modificarProveedores(string ruc_dni, string nombre, string direccion, string email, string casa, string oficina, string referencia, int codigo)
        {

            cmd.Connection = abrirConexion();
            cmd.CommandText = "SP_M_T_PROVEEDORES";
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("PROV_RUC_DNI", ruc_dni);
            cmd.Parameters.AddWithValue("PROV_NOM", nombre);
            cmd.Parameters.AddWithValue("PROV_DIRECC", direccion);
            cmd.Parameters.AddWithValue("PROV_EMAIL", email);
            cmd.Parameters.AddWithValue("PROV_TELEF_CASA", casa);
            cmd.Parameters.AddWithValue("PROV_TELEF_OFICINA", oficina);
            cmd.Parameters.AddWithValue("PROV_REFERENCIA ", referencia);

            cmd.Parameters.AddWithValue("PROV_COD", codigo);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cerrarConexion();

        }

        public void eliminarProveedores(int codigo)
        {

            cmd.Connection = abrirConexion();
            cmd.CommandText = "SP_E_T_PROVEEDORES";
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("PROV_COD", codigo);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cerrarConexion();
        }







    }
}
