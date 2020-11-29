using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Libreria para mover ventanas
using System.Runtime.InteropServices;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class formularioEnvio : Form
    {
        public formularioEnvio()
        {
            InitializeComponent();
        }

        //DLL para mover ventanas
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void formularioEnvio_Load(object sender, EventArgs e)
        {


            this.reportViewer1.RefreshReport();
        }



        private void getSalesReport(DateTime startDate, DateTime endDate)
        {

            SalesReport lrp = new SalesReport();
            lrp.createSalesOrderReport(startDate, endDate);


            ReportDataSource rds = new ReportDataSource("ListaProductos", lrp.salesListing);
            ReportDataSource netSalesbyPeriodo = new ReportDataSource("netSalesByPeriodo", lrp.netSalesByPeriod);

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.ReportInforme.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.DataSources.Add(netSalesbyPeriodo);


            this.reportViewer1.RefreshReport();



        }
                  
       
        private void btnLast7Days_Click_1(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-7);
            var toDate = DateTime.Now;
            getSalesReport(fromDate, toDate);
        }

        private void btnToday_Click_1(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today;
            var toDate = DateTime.Now;
            getSalesReport(fromDate, toDate);
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-30);
            var toDate = DateTime.Now;

            getSalesReport(fromDate, toDate);


        }

        private void btnThisYear_Click(object sender, EventArgs e)
        {
            var fromDate = new DateTime(DateTime.Now.Year, 1, 1);
            var toDate = DateTime.Now;

            getSalesReport(fromDate, toDate);

        }

        private void btnCustom_Click(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var fromDate = dateTimePickerFromDate.Value;
            var toDate = dateTimePickerToDate.Value;

            getSalesReport(fromDate, new DateTime(toDate.Year, toDate.Month, toDate.Day, 23, 59, 59));

        }

        private void btnthisMonth_Click(object sender, EventArgs e)
        {
            var fromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var toDate = DateTime.Now;
            getSalesReport(fromDate, toDate);

        }

        private void btnMininize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formularioEnvio_MouseDown(object sender, MouseEventArgs e)
        {
            //Evento Mouse Down para mover las ventanas
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //Evento Mouse Down para mover las ventanas
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        //private void btnThisMonth_Click(object sender, EventArgs e)
        //{

        //    var fromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        //    var toDate = DateTime.Now;

        //    getSalesReport(fromDate, toDate);

        //}




    }
}
