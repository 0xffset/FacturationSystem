namespace CapaPresentacion
{
    using CapaNegocio.Reports;
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="frmAdvancedSalesReport" />.
    /// </summary>
    public partial class frmAdvancedSalesReport : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="frmAdvancedSalesReport"/> class.
        /// </summary>
        public frmAdvancedSalesReport()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The frmAdvancedSalesReport_Load.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void frmAdvancedSalesReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        /// <summary>
        /// The getSalesReport.
        /// </summary>
        /// <param name="startDate">The startDate<see cref="DateTime"/>.</param>
        /// <param name="endDate">The endDate<see cref="DateTime"/>.</param>
        private void getSalesReport(DateTime startDate, DateTime endDate)
        {
            SalesReports salesReports = new SalesReports();
            salesReports.createdSalesReport(startDate, endDate);
            SalesListingBindingSource.DataSource = salesReports.salesListing;
            NetSalesByPeriodBindingSource.DataSource = salesReports.netSalesByPeriod;
            SalesReportsBindingSource.DataSource = salesReports;
            this.reportViewer1.RefreshReport();
        }

        /// <summary>
        /// The button1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today;

            var toDate = DateTime.Now;


            getSalesReport(fromDate, toDate);
        }

        /// <summary>
        /// The button2_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-7);
            var toDate = DateTime.Now;


            getSalesReport(fromDate, toDate);
        }

        /// <summary>
        /// The button3_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void button3_Click(object sender, EventArgs e)
        {
            var fromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var toDate = DateTime.Now;


            getSalesReport(fromDate, toDate);
        }

        /// <summary>
        /// The button4_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void button4_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-30);
            var toDate = DateTime.Now;


            getSalesReport(fromDate, toDate);
        }

        /// <summary>
        /// The button5_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void button5_Click(object sender, EventArgs e)
        {
            var fromDate = new DateTime(DateTime.Now.Year, 1, 1);
            var toDate = DateTime.Now;


            getSalesReport(fromDate, toDate);
        }

        /// <summary>
        /// The btnApplyCustom_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnApplyCustom_Click(object sender, EventArgs e)
        {
            var fromDate = dateTimePicker1.Value;
            var toDate = dateTimePicker2.Value;


            getSalesReport(fromDate, new DateTime(toDate.Year, toDate.Month, toDate.Day, 23, 59, 59));
        }
    }
}
