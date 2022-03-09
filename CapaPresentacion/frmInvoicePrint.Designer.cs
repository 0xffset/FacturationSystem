
namespace CapaPresentacion
{
    partial class frmInvoicePrint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.InvoicePrintDomainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustomerInvoiceDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoicePrintDomainBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.invoicePrintDomainBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listingInvoiceSaleDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.InvoicePrintDomainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerInvoiceDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicePrintDomainBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicePrintDomainBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listingInvoiceSaleDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // InvoicePrintDomainBindingSource
            // 
            this.InvoicePrintDomainBindingSource.DataMember = "ListingInvoiceSaleDetails";
            this.InvoicePrintDomainBindingSource.DataSource = typeof(CapaNegocio.Reports.InvoicePrintDomain);
            // 
            // CustomerInvoiceDataBindingSource
            // 
            this.CustomerInvoiceDataBindingSource.DataSource = typeof(CapaNegocio.Reports.CustomerInvoiceData);
            // 
            // invoicePrintDomainBindingSource2
            // 
            this.invoicePrintDomainBindingSource2.DataSource = typeof(CapaNegocio.Reports.InvoicePrintDomain);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "listingInvoiceSaleDetails";
            reportDataSource1.Value = this.InvoicePrintDomainBindingSource;
            reportDataSource2.Name = "customerInvoiceData";
            reportDataSource2.Value = this.CustomerInvoiceDataBindingSource;
            reportDataSource3.Name = "invoiceDomain";
            reportDataSource3.Value = this.InvoicePrintDomainBindingSource;
            reportDataSource4.Name = "totalInvoice";
            reportDataSource4.Value = this.invoicePrintDomainBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reports.invoiceReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1249, 586);
            this.reportViewer1.TabIndex = 0;
            // 
            // invoicePrintDomainBindingSource1
            // 
            this.invoicePrintDomainBindingSource1.DataSource = typeof(CapaNegocio.Reports.InvoicePrintDomain);
            // 
            // listingInvoiceSaleDetailsBindingSource
            // 
            this.listingInvoiceSaleDetailsBindingSource.DataSource = typeof(CapaNegocio.Reports.ListingInvoiceSaleDetails);
            // 
            // frmInvoicePrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 610);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1289, 649);
            this.MinimumSize = new System.Drawing.Size(1289, 649);
            this.Name = "frmInvoicePrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Invoice Print :.";
            this.Load += new System.EventHandler(this.frmInvoicePrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InvoicePrintDomainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerInvoiceDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicePrintDomainBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicePrintDomainBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listingInvoiceSaleDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource InvoicePrintDomainBindingSource;
        private System.Windows.Forms.BindingSource CustomerInvoiceDataBindingSource;
        private System.Windows.Forms.BindingSource invoicePrintDomainBindingSource1;
        private System.Windows.Forms.BindingSource invoicePrintDomainBindingSource2;
        private System.Windows.Forms.BindingSource listingInvoiceSaleDetailsBindingSource;
    }
}