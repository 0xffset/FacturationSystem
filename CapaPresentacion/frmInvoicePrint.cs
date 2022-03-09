namespace CapaPresentacion
{
    using CapaNegocio.Reports;
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="frmInvoicePrint" />.
    /// </summary>
    public partial class frmInvoicePrint : Form
    {
        /// <summary>
        /// Defines the idSale.
        /// </summary>
        internal int idSale = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="frmInvoicePrint"/> class.
        /// </summary>
        /// <param name="idsale">The idsale<see cref="int"/>.</param>
        public frmInvoicePrint(int idsale)
        {
            this.idSale = idsale;
            InitializeComponent();
        }

        /// <summary>
        /// The frmInvoicePrint_Load.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void frmInvoicePrint_Load(object sender, EventArgs e)
        {
            InvoicePrintDomain invoicePrintDomain = new InvoicePrintDomain();
            invoicePrintDomain.loadCustomerData(this.idSale);
            invoicePrintDomain.createdSalesDetails(this.idSale);

            listingInvoiceSaleDetailsBindingSource.DataSource = invoicePrintDomain.ListingInvoiceSaleDetails;
            CustomerInvoiceDataBindingSource.DataSource = invoicePrintDomain.customerInvoiceData;
            InvoicePrintDomainBindingSource.DataSource = invoicePrintDomain;
            this.reportViewer1.RefreshReport();
        }
    }
}
