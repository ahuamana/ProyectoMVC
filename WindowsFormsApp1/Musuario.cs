using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    class Musuario:Conexion
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataReader LectorFilas;


        public DataTable listarUsuarios()
        {

            DataTable tabla01 = new DataTable();

            cmd.Connection = abrirConexion();
            cmd.CommandText = "SP_C_T_USUARIO";
            cmd.CommandType = CommandType.StoredProcedure;

            LectorFilas = cmd.ExecuteReader();
            tabla01.Load(LectorFilas);
            LectorFilas.Close();

            cerrarConexion();

            return tabla01;
        }


        public void insertarUsuarios(string nombres, string apellidos, string sexo, string documento, string direccion, string telefono, string email, string password)
        {



            cmd.Connection = abrirConexion();
            cmd.CommandText = "SP_A_T_USUARIO";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("NOMBRES", nombres);
            cmd.Parameters.AddWithValue("APELLIDOS", apellidos);
            cmd.Parameters.AddWithValue("SEXO", sexo);
            cmd.Parameters.AddWithValue("DOCUMENTO", documento);
            cmd.Parameters.AddWithValue("DIRECCION", direccion);
            cmd.Parameters.AddWithValue("TELEFONO", telefono);
            cmd.Parameters.AddWithValue("EMAIL", email);
            cmd.Parameters.AddWithValue("PASSWORD", password);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cerrarConexion();



        }


        public void actualizarUsuarios(string nombres, string apellidos, string sexo, string documento, string direccion, string telefono, string email, string password, int codigo)
        {

            cmd.Connection = abrirConexion();
            cmd.CommandText = "SP_M_T_USUARIO";
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("NOMBRES", nombres);
            cmd.Parameters.AddWithValue("APELLIDOS", apellidos);
            cmd.Parameters.AddWithValue("SEXO", sexo);
            cmd.Parameters.AddWithValue("DOCUMENTO", documento);
            cmd.Parameters.AddWithValue("DIRECCION", direccion);
            cmd.Parameters.AddWithValue("TELEFONO", telefono);
            cmd.Parameters.AddWithValue("EMAIL", email);
            cmd.Parameters.AddWithValue("PASSWORD", password);


            cmd.Parameters.AddWithValue("COD", codigo);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cerrarConexion();

        }

        public void eliminarUsuarios(int codigo)
        {

            cmd.Connection = abrirConexion();
            cmd.CommandText = "SP_E_T_USUARIO";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("CODIGO", codigo);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cerrarConexion();

        }




    }
}
