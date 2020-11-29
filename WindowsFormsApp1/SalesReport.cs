using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class SalesReport
    {


        //Atributos - Propiedades

        public DateTime reportDate { get; private set; }
        public DateTime startDate { get; private set; }
        public DateTime endDate { get; private set; }
        public List<SalesListing> salesListing { get; private set; }
        public List<NetSalesByPeriod> netSalesByPeriod { get; private set; }
        public double totalNetSales { get; private set; }



        public void createSalesOrderReport(DateTime fromDate, DateTime toDate)
        {

            //implementar fechas
            reportDate = DateTime.Now;
            startDate = fromDate;
            endDate = toDate;

            //create lista de ventas

            var clsReportes = new Mreportes();
            var result = clsReportes.getSalesOrder(fromDate, toDate);

            salesListing = new List<SalesListing>();

            foreach (DataRow rows in result.Rows)
            {
                var salesModel = new SalesListing()
                {
                    orderID = Convert.ToInt32(rows[0]),
                    orderDate = Convert.ToDateTime(rows[1]),
                    customer = Convert.ToString(rows[2]),
                    productos = Convert.ToString(rows[3]),
                    totalAmount = Convert.ToDouble(rows[4])
                };
                salesListing.Add(salesModel);

                //Calcular el monto total de las ventas
                totalNetSales += Convert.ToDouble(rows[4]);

            }



            //crear ventas pro periodo
            ////crear una lista temporal de las bentas por periodo


            var listSalesBydate = (from sales in salesListing
                                   group sales by sales.orderDate
                                    into listSales
                                   select new
                                   {
                                       date = listSales.Key,
                                       amount = listSales.Sum(item => item.totalAmount)
                                   }).AsEnumerable();

            ////Obtener el numero de dias

            int totalDays = Convert.ToInt32((toDate - fromDate).Days);




            ////Agrupar periodos por dias
            if (totalDays <= 7)
            {
                netSalesByPeriod = (from sales in listSalesBydate
                                    group sales by sales.date.ToString("dd-MMM-yyyy")
                                    into listSales
                                    select new NetSalesByPeriod
                                    {
                                        period = listSales.Key,
                                        netSales = listSales.Sum(item => item.amount)
                                    }).ToList();

            }


            ////Agrupar periodos por semanas
            else if (totalDays <= 30)
            {

                netSalesByPeriod = (from sales in listSalesBydate
                                    group sales by
                                    CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(sales.date, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                    into listSales
                                    select new NetSalesByPeriod
                                    {
                                        period = "Semana " + listSales.Key.ToString(),
                                        netSales = listSales.Sum(item => item.amount)
                                    }).ToList();


            }


            ////Agrupar periodos por meses

            else if (totalDays <= 365)
            {

                netSalesByPeriod = (from sales in listSalesBydate
                                    group sales by sales.date.ToString("MMM-yyyy")
                                       into listSales
                                    select new NetSalesByPeriod
                                    {
                                        period = listSales.Key,
                                        netSales = listSales.Sum(item => item.amount)
                                    }).ToList();


            }



            ////Agrupar ´periodos por años

            else
            {

                netSalesByPeriod = (from sales in listSalesBydate
                                    group sales by sales.date.ToString("yyyy")
                                   into listSales
                                    select new NetSalesByPeriod
                                    {
                                        period = listSales.Key,
                                        netSales = listSales.Sum(item => item.amount)
                                    }).ToList();

            }


        }

    }
}
