using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Mlogin:Conexion
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataReader LectorFilas;

        public bool Login(string user, string pass)
        {
            //procedimiento para consultar si existe el usuario en la base de datos

            cmd.Connection = abrirConexion();
            cmd.CommandText = "SP_C_T_USUARIO_LOGIN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("USERNAME", user);
            cmd.Parameters.AddWithValue("PASSWORD",pass);

            LectorFilas = cmd.ExecuteReader();

            if (LectorFilas.HasRows)
            {

                while (LectorFilas.Read())
                {
                    //asigna los valores obtenidos del login para utilizarlo en las ventas

                    Mcache.Name=LectorFilas.GetString(1);
                    Mcache.Apellidos = LectorFilas.GetString(2);
                    Mcache.Posicion=LectorFilas.GetString(8);
                
                }

                return true;

            } else {

                return false;
            
            }

           
        
             
        
        }


    }
}
