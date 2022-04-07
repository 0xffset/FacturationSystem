namespace CapaPresentacion
{
    partial class frmConsultSales
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalesReports = new System.Windows.Forms.Button();
            this.btnCancelSale = new System.Windows.Forms.Button();
            this.btnSaleDetails = new System.Windows.Forms.Button();
            this.dgvSaleHistory = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(793, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = ".: SALES HISTORY :.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 108);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(272, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 21);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(166, 45);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(99, 22);
            this.dtpEnd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "End Date:";
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(18, 45);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(99, 22);
            this.dtpStart.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Start Date: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalesReports);
            this.groupBox2.Controls.Add(this.btnCancelSale);
            this.groupBox2.Controls.Add(this.btnSaleDetails);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(396, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 108);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
            // 
            // btnSalesReports
            // 
            this.btnSalesReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalesReports.Location = new System.Drawing.Point(204, 35);
            this.btnSalesReports.Name = "btnSalesReports";
            this.btnSalesReports.Size = new System.Drawing.Size(85, 46);
            this.btnSalesReports.TabIndex = 21;
            this.btnSalesReports.Text = "Sale Reports";
            this.btnSalesReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalesReports.UseVisualStyleBackColor = true;
            this.btnSalesReports.Click += new System.EventHandler(this.btnSalesReports_Click);
            // 
            // btnCancelSale
            // 
            this.btnCancelSale.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelSale.Location = new System.Drawing.Point(113, 35);
            this.btnCancelSale.Name = "btnCancelSale";
            this.btnCancelSale.Size = new System.Drawing.Size(85, 46);
            this.btnCancelSale.TabIndex = 20;
            this.btnCancelSale.Text = "Cancel Sale";
            this.btnCancelSale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelSale.UseVisualStyleBackColor = true;
            this.btnCancelSale.Click += new System.EventHandler(this.btnAnularVenta_Click);
            // 
            // btnSaleDetails
            // 
            this.btnSaleDetails.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaleDetails.Location = new System.Drawing.Point(12, 35);
            this.btnSaleDetails.Name = "btnSaleDetails";
            this.btnSaleDetails.Size = new System.Drawing.Size(85, 46);
            this.btnSaleDetails.TabIndex = 19;
            this.btnSaleDetails.Text = "Sale Details";
            this.btnSaleDetails.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaleDetails.UseVisualStyleBackColor = true;
            this.btnSaleDetails.Click += new System.EventHandler(this.btnDetVenta_Click);
            // 
            // dgvSaleHistory
            // 
            this.dgvSaleHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleHistory.Location = new System.Drawing.Point(12, 177);
            this.dgvSaleHistory.Name = "dgvSaleHistory";
            this.dgvSaleHistory.Size = new System.Drawing.Size(749, 345);
            this.dgvSaleHistory.TabIndex = 6;
            this.dgvSaleHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHisVentas_CellClick);
            // 
            // frmConsultSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(772, 542);
            this.Controls.Add(this.dgvSaleHistory);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(788, 581);
            this.MinimumSize = new System.Drawing.Size(788, 581);
            this.Name = "frmConsultSales";
            this.Text = ".: Sales History :.";
            this.Load += new System.EventHandler(this.frmConsultarVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaleDetails;
        private System.Windows.Forms.Button btnCancelSale;
        private System.Windows.Forms.DataGridView dgvSaleHistory;
        private System.Windows.Forms.Button btnSalesReports;
    }
}