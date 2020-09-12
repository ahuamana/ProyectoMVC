using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Conexion
    {

        private static string cadena = @"Server=.\SQLEXPRESS;Initial Catalog = ProyectoMVC; Integrated Security = True";
        SqlConnection nconexion = new SqlConnection(cadena);

        public SqlConnection abrirConexion()
        {

            if (nconexion.State == ConnectionState.Closed)
            {

                nconexion.Open();

            }

            return nconexion;

        }
            
        public SqlConnection cerrarConexion() 
        {


            if (nconexion.State == ConnectionState.Open)
            {
                nconexion.Close();

            }

            return nconexion;

         }

    }
}
