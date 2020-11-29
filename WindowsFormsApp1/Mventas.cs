using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Mventas: Conexion
    {
        public List<listaProductoVentas> listaproducto { get; private set; }
        public List<listaClientesyTotales> listacliente { get; private set; }

        SqlCommand cmd = new SqlCommand();
        SqlDataReader LectorFilas;

        DataTable tblGeneral = new DataTable();


        public List<listaProductoVentas> ObtenerLista(DataTable DTDETALLE)
        {

            //Rellenar la lista de items para mostrar en la Boleta
            if (listaproducto != null)
            {
                listaproducto.Clear();

            }
            listaproducto = new List<listaProductoVentas>();

            foreach (DataRow row in DTDETALLE.Rows)
            {

                var molde = new listaProductoVentas()
                {

                    CPRODUCTO = Convert.ToInt32(row[0]),
                    NOMBRE = Convert.ToString(row[1]),
                    PRESENTACION = Convert.ToString(row[2]),
                    CANTIDAD = Convert.ToInt32(row[3]),
                    DESCUENTO = Convert.ToDouble(row[4]),
                    PRECIO = Convert.ToDouble(row[5]),
                    SUBTOTAL = Convert.ToDouble(row[6])

                };

                listaproducto.Add(molde);
            }



            return listaproducto;
        }


        public List<listaClientesyTotales> ObtenerDatosCliente(string nameCliente, string apecliente, string direccliente, string dnicliente, DateTime fechahoy, string numBoletas, double subtotal, double total, double descuento)
        {


            if (listacliente != null)
            {
                listacliente.Clear();

            }

            listacliente = new List<listaClientesyTotales>();

            var moldecliente = new listaClientesyTotales()
            {
                ClienteName = Convert.ToString(nameCliente),
                ClienteApe = Convert.ToString(apecliente),
                ClienteDirecc = Convert.ToString(direccliente),
                ClienteDNI = Convert.ToString(dnicliente),
                FechaHoy = Convert.ToDateTime(fechahoy),

                NumBoletas = numBoletas,
                subtotal = subtotal,
                descuento = descuento,
                total = total

            };

            listacliente.Add(moldecliente);



            return listacliente;

        }


        public void IngresarVentas(string numFactura, string codigoCliente, string Vendedor, string fechaActual, string comprobante, DataTable DTDETALLE)
        {


            DateTime fechaActual2 = Convert.ToDateTime(fechaActual);



            cmd.Connection = abrirConexion();

            cmd.Parameters.Clear();
            cmd.CommandText = "SP_A_TB_VENTA";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("IDVENTA", Convert.ToInt32(numFactura));
            cmd.Parameters.AddWithValue("IDCLIENTE", codigoCliente);
            cmd.Parameters.AddWithValue("NUMTRABAJADOR", Vendedor);
            cmd.Parameters.AddWithValue("FECHA", fechaActual2);
            cmd.Parameters.AddWithValue("TIPO_COMPROBANTE", comprobante);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

            IngresarDetalleVenta(numFactura, DTDETALLE);

            //Limpiar los campos

        }


        public void IngresarDetalleVenta(string numFactura2, DataTable DTDETALLE2)
        {

            cmd.Connection = abrirConexion();
            cmd.CommandText = "SP_A_TB_DETALLEVENTA";
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (DataRow row in DTDETALLE2.Rows)
            {

                cmd.Parameters.AddWithValue("IDVENTA", Convert.ToInt32(numFactura2));
                cmd.Parameters.AddWithValue("COD_PRODUCTO", Convert.ToInt32(row["CProducto"].ToString()));
                cmd.Parameters.AddWithValue("CANTIDAD", Convert.ToInt32(row["Cantidad"].ToString()));
                cmd.Parameters.AddWithValue("PRECIO_VENTA", Convert.ToDouble(row["Precio"].ToString()));
                cmd.Parameters.AddWithValue("DESCUENTO", Convert.ToDouble(row["Descuento"].ToString()));
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

            }


            ActualizarStock(DTDETALLE2);


        }




        public int ObtenertblFactura()
        {

            int resultado;
            cmd.Connection = abrirConexion();
            cmd.CommandText = "SP_C_TB_NUMFACTURAS";
            cmd.CommandType = CommandType.StoredProcedure;

            LectorFilas = cmd.ExecuteReader();
            tblGeneral.Load(LectorFilas);

            resultado = tblGeneral.Rows.Count;
            LectorFilas.Close();

            cerrarConexion();

            return resultado;
        }

        public void ActualizarStock(DataTable DTDETALLE2)
        {


            cmd.Parameters.Clear();
            cmd.Connection = abrirConexion();
            cmd.CommandText = "SP_M_STOCK_VENTAS";
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (DataRow row in DTDETALLE2.Rows)
            {
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("COD", Convert.ToInt32(row["CProducto"].ToString()));
                cmd.Parameters.AddWithValue("CANTIDAD_PRODUCTO", Convert.ToInt32(row["Cantidad"].ToString()));
                cmd.ExecuteNonQuery();


            }

            cerrarConexion();

        }


        public DataTable ListarBoletas()
        {

            DataTable tabla = new DataTable();

            cmd.Connection = abrirConexion();
            cmd.CommandText = "SP_C_T_Boletas";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataAdapter sdt = new SqlDataAdapter(cmd);

            sdt.Fill(tabla);

            cerrarConexion();

            return tabla;

        }





    }
}
