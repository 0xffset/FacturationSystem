
namespace CapaPresentacion
{
    partial class frmAdvancedSalesReport
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
            this.SalesListingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalesReportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NetSalesByPeriodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApplyCustom = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SalesListingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NetSalesByPeriodBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalesListingBindingSource
            // 
            this.SalesListingBindingSource.DataSource = typeof(CapaNegocio.Reports.SalesListing);
            // 
            // SalesReportsBindingSource
            // 
            this.SalesReportsBindingSource.DataSource = typeof(CapaNegocio.Reports.SalesReports);
            // 
            // NetSalesByPeriodBindingSource
            // 
            this.NetSalesByPeriodBindingSource.DataSource = typeof(CapaNegocio.Reports.NetSalesByPeriod);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "salesListing";
            reportDataSource1.Value = this.SalesListingBindingSource;
            reportDataSource2.Name = "SalesReports";
            reportDataSource2.Value = this.SalesReportsBindingSource;
            reportDataSource3.Name = "netSalesByPeriod";
            reportDataSource3.Value = this.NetSalesByPeriodBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reports.salesAvancedReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(258, 11);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1484, 754);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnApplyCustom);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 568);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "From: ";
            // 
            // btnApplyCustom
            // 
            this.btnApplyCustom.Location = new System.Drawing.Point(23, 383);
            this.btnApplyCustom.Name = "btnApplyCustom";
            this.btnApplyCustom.Size = new System.Drawing.Size(184, 46);
            this.btnApplyCustom.TabIndex = 8;
            this.btnApplyCustom.Text = "Apply";
            this.btnApplyCustom.UseVisualStyleBackColor = true;
            this.btnApplyCustom.Click += new System.EventHandler(this.btnApplyCustom_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(84, 357);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(123, 26);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 331);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 26);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(23, 279);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(184, 46);
            this.button6.TabIndex = 5;
            this.button6.Text = "Custom";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(23, 227);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(184, 46);
            this.button5.TabIndex = 4;
            this.button5.Text = "This Year";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "Lasta 30 Days";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "This Month";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Last 7 Days";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Today";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAdvancedSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1754, 777);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1770, 816);
            this.Name = "frmAdvancedSalesReport";
            this.Text = ".: Avanced Sales Report :.";
            this.Load += new System.EventHandler(this.frmAdvancedSalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesListingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NetSalesByPeriodBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SalesListingBindingSource;
        private System.Windows.Forms.BindingSource SalesReportsBindingSource;
        private System.Windows.Forms.BindingSource NetSalesByPeriodBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApplyCustom;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}