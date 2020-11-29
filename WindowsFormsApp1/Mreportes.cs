using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Mreportes:Conexion
    {

        SqlCommand cmd = new SqlCommand();

        public DataTable getSalesOrder(DateTime fromDate, DateTime toDate)
        {
            DataTable tabla = new DataTable();

            string fromDates = fromDate.ToString("yyyy/MM/dd");
            string toDates = toDate.ToString("yyyy/MM/dd");

            //fromDates = "2020/09/22";
            //toDates = "2020/10/22";

            Convert.ToDateTime(toDates);
            Convert.ToDateTime(fromDates);

            cmd.Connection = abrirConexion();
            cmd.CommandText = "SP_R_T_Boletas";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fromDate", fromDates);
            cmd.Parameters.AddWithValue("@toDate", toDates);
            cmd.ExecuteNonQuery();

            SqlDataAdapter lectorFilas = new SqlDataAdapter(cmd);
            lectorFilas.Fill(tabla);
            return tabla;
        }

    }
}
