using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaAccesoDatos;
using CapaNegocio.Reports;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class frmSalesReport : Form
    {
        public frmSalesReport()
        {
            InitializeComponent();
        }

        private void frmSalesReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            
        }
        private void getSalesReport(DateTime startDate, DateTime endDate)
        {
            SalesReports salesReports = new SalesReports();
            salesReports.createdSalesReport(startDate, endDate);

            SalesReport.DataSource = salesReports;
            bindingSourceSalesListing.DataSource = salesReports.salesListing;
            bindingSourceNetSalesByPeriod.DataSource = salesReports.netSalesByPeriod;
            this.reportViewer1.RefreshReport();
            

            
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today;
            var toDate = DateTime.Now;


            getSalesReport(fromDate, toDate);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-7);
            var toDate = DateTime.Now;


            getSalesReport(fromDate, toDate);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var fromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var toDate = DateTime.Now;


            getSalesReport(fromDate, toDate);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var fromDate = new DateTime(DateTime.Now.Year,1,1);
            var toDate = DateTime.Now;


            getSalesReport(fromDate, toDate);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-30);
            var toDate = DateTime.Now;


            getSalesReport(fromDate, toDate);
        }

        private void btnApplyCustom_Click(object sender, EventArgs e)
        {
            var fromDate = dateTimePicker1.Value;
            var toDate = dateTimePicker2.Value;


            getSalesReport(fromDate, new DateTime(toDate.Year, toDate.Month, toDate.Day,23,59,59));
        }
    }
}
