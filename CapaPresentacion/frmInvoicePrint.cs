using CapaNegocio.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmInvoicePrint : Form
    {
        int idSale = 0;
        public frmInvoicePrint(int idsale)
        {
            this.idSale = idsale;
            InitializeComponent();
        }

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
