namespace CapaPresentacion
{
    partial class frmSaleDetails
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
            this.lblSeller = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCodeSale = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNoInvoice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listDetails = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seller";
            // 
            // lblSeller
            // 
            this.lblSeller.BackColor = System.Drawing.SystemColors.Control;
            this.lblSeller.Location = new System.Drawing.Point(16, 41);
            this.lblSeller.Name = "lblSeller";
            this.lblSeller.Size = new System.Drawing.Size(266, 21);
            this.lblSeller.TabIndex = 1;
            this.lblSeller.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblState
            // 
            this.lblState.BackColor = System.Drawing.SystemColors.Control;
            this.lblState.Location = new System.Drawing.Point(30, 111);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(57, 21);
            this.lblState.TabIndex = 3;
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sale Code";
            // 
            // lblCodeSale
            // 
            this.lblCodeSale.BackColor = System.Drawing.SystemColors.Control;
            this.lblCodeSale.Location = new System.Drawing.Point(29, 168);
            this.lblCodeSale.Name = "lblCodeSale";
            this.lblCodeSale.Size = new System.Drawing.Size(189, 21);
            this.lblCodeSale.TabIndex = 5;
            this.lblCodeSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCodeSale.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblDNI
            // 
            this.lblDNI.BackColor = System.Drawing.SystemColors.Control;
            this.lblDNI.Location = new System.Drawing.Point(224, 168);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(189, 21);
            this.lblDNI.TabIndex = 7;
            this.lblDNI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(345, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "DNI";
            // 
            // lblCustomer
            // 
            this.lblCustomer.BackColor = System.Drawing.SystemColors.Control;
            this.lblCustomer.Location = new System.Drawing.Point(31, 230);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(273, 21);
            this.lblCustomer.TabIndex = 9;
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(245, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Customer";
            // 
            // lblHour
            // 
            this.lblHour.BackColor = System.Drawing.SystemColors.Control;
            this.lblHour.Location = new System.Drawing.Point(579, 111);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(103, 21);
            this.lblHour.TabIndex = 11;
            this.lblHour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Hora
            // 
            this.Hora.AutoSize = true;
            this.Hora.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.Location = new System.Drawing.Point(517, 113);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(43, 18);
            this.Hora.TabIndex = 10;
            this.Hora.Text = "Hour";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(582, 87);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(100, 21);
            this.dtpDate.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(517, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Date";
            // 
            // lblNoInvoice
            // 
            this.lblNoInvoice.BackColor = System.Drawing.SystemColors.Control;
            this.lblNoInvoice.Location = new System.Drawing.Point(416, 230);
            this.lblNoInvoice.Name = "lblNoInvoice";
            this.lblNoInvoice.Size = new System.Drawing.Size(167, 21);
            this.lblNoInvoice.TabIndex = 15;
            this.lblNoInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(489, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "No. Commertial Invoice";
            // 
            // listDetails
            // 
            this.listDetails.HideSelection = false;
            this.listDetails.Location = new System.Drawing.Point(32, 284);
            this.listDetails.Name = "listDetails";
            this.listDetails.Size = new System.Drawing.Size(579, 328);
            this.listDetails.TabIndex = 16;
            this.listDetails.UseCompatibleStateImageBehavior = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Details";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotal.Location = new System.Drawing.Point(617, 546);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(118, 21);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(683, 521);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 18);
            this.label12.TabIndex = 18;
            this.label12.Text = "Total ";
            // 
            // frmSaleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(740, 644);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listDetails);
            this.Controls.Add(this.lblNoInvoice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCodeSale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSeller);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(756, 683);
            this.MinimumSize = new System.Drawing.Size(756, 683);
            this.Name = "frmSaleDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Sale Details :.";
            this.Load += new System.EventHandler(this.frmDetalleV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSeller;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCodeSale;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNoInvoice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listDetails;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label12;
    }
}