namespace CapaPresentacion
{
    partial class frmFacturation
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblcorre = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtFechaFac = new System.Windows.Forms.DateTimePicker();
            this.btnSearchById = new System.Windows.Forms.Button();
            this.btnSearchDNI = new System.Windows.Forms.Button();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodoU = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNetTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblITBIS = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelInvoice = new System.Windows.Forms.Button();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.btnNewInvoice = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblserie = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.txtPriceProduct = new System.Windows.Forms.TextBox();
            this.txtQuanityProduct = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "Billing System";
        
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(746, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 92);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "BILL";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblcorre
            // 
            this.lblcorre.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcorre.Location = new System.Drawing.Point(470, 77);
            this.lblcorre.Name = "lblcorre";
            this.lblcorre.Size = new System.Drawing.Size(135, 24);
            this.lblcorre.TabIndex = 5;
    
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.label8);
            this.gbCliente.Controls.Add(this.dtFechaFac);
            this.gbCliente.Controls.Add(this.btnSearchById);
            this.gbCliente.Controls.Add(this.btnSearchDNI);
            this.gbCliente.Controls.Add(this.txtDNI);
            this.gbCliente.Controls.Add(this.label6);
            this.gbCliente.Controls.Add(this.txtCustomerName);
            this.gbCliente.Controls.Add(this.label5);
            this.gbCliente.Controls.Add(this.txtCodoU);
            this.gbCliente.Controls.Add(this.label4);
            this.gbCliente.Location = new System.Drawing.Point(21, 77);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(586, 115);
            this.gbCliente.TabIndex = 4;
            this.gbCliente.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(325, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 14);
            this.label8.TabIndex = 11;
            this.label8.Text = "Currect Date: ";
            // 
            // dtFechaFac
            // 
            this.dtFechaFac.Enabled = false;
            this.dtFechaFac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFac.Location = new System.Drawing.Point(436, 84);
            this.dtFechaFac.Name = "dtFechaFac";
            this.dtFechaFac.Size = new System.Drawing.Size(92, 22);
            this.dtFechaFac.TabIndex = 10;
            // 
            // btnSearchById
            // 
            this.btnSearchById.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearchById.Image = global::CapaPresentacion.Properties.Resources.Accept_16px;
            this.btnSearchById.Location = new System.Drawing.Point(527, 48);
            this.btnSearchById.Name = "btnSearchById";
            this.btnSearchById.Size = new System.Drawing.Size(37, 32);
            this.btnSearchById.TabIndex = 7;
            this.btnSearchById.UseVisualStyleBackColor = true;
            this.btnSearchById.Click += new System.EventHandler(this.btnBuscarxId_Click);
            // 
            // btnSearchDNI
            // 
            this.btnSearchDNI.Location = new System.Drawing.Point(448, 49);
            this.btnSearchDNI.Name = "btnSearchDNI";
            this.btnSearchDNI.Size = new System.Drawing.Size(73, 32);
            this.btnSearchDNI.TabIndex = 6;
            this.btnSearchDNI.Text = "Search";
            this.btnSearchDNI.UseVisualStyleBackColor = true;
            this.btnSearchDNI.Click += new System.EventHandler(this.btnBuscarCe_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(276, 56);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(166, 22);
            this.txtDNI.TabIndex = 5;
 
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 14);
            this.label6.TabIndex = 4;
            this.label6.Text = "DNI: ";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(27, 76);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(241, 22);
            this.txtCustomerName.TabIndex = 3;

            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "Customer Name: ";

            // 
            // txtCodoU
            // 
            this.txtCodoU.Enabled = false;
            this.txtCodoU.Location = new System.Drawing.Point(27, 36);
            this.txtCodoU.Name = "txtCodoU";
            this.txtCodoU.ReadOnly = true;
            this.txtCodoU.Size = new System.Drawing.Size(85, 22);
            this.txtCodoU.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "User";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNetTotal);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblITBIS);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnCancelInvoice);
            this.panel1.Controls.Add(this.btnPrintInvoice);
            this.panel1.Controls.Add(this.btnNewInvoice);
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblItems);
            this.panel1.Controls.Add(this.dgvInvoice);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(21, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 401);
            this.panel1.TabIndex = 5;
            // 
            // lblNetTotal
            // 
            this.lblNetTotal.BackColor = System.Drawing.Color.White;
            this.lblNetTotal.Location = new System.Drawing.Point(794, 254);
            this.lblNetTotal.Name = "lblNetTotal";
            this.lblNetTotal.Size = new System.Drawing.Size(97, 21);
            this.lblNetTotal.TabIndex = 20;
            this.lblNetTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(712, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 14);
            this.label11.TabIndex = 19;
            this.label11.Text = "Net Total $";
            // 
            // lblITBIS
            // 
            this.lblITBIS.BackColor = System.Drawing.Color.White;
            this.lblITBIS.Location = new System.Drawing.Point(793, 289);
            this.lblITBIS.Name = "lblITBIS";
            this.lblITBIS.Size = new System.Drawing.Size(97, 21);
            this.lblITBIS.TabIndex = 18;
            this.lblITBIS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(722, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 14);
            this.label7.TabIndex = 17;
            this.label7.Text = "ITBIS 18%";
            // 
            // btnCancelInvoice
            // 
            this.btnCancelInvoice.Location = new System.Drawing.Point(497, 355);
            this.btnCancelInvoice.Name = "btnCancelInvoice";
            this.btnCancelInvoice.Size = new System.Drawing.Size(68, 37);
            this.btnCancelInvoice.TabIndex = 16;
            this.btnCancelInvoice.Text = "Cancel bill";
            this.btnCancelInvoice.UseVisualStyleBackColor = true;
            this.btnCancelInvoice.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.Location = new System.Drawing.Point(422, 355);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(69, 37);
            this.btnPrintInvoice.TabIndex = 15;
            this.btnPrintInvoice.Text = "Print bill";
            this.btnPrintInvoice.UseVisualStyleBackColor = true;
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNewInvoice
            // 
            this.btnNewInvoice.Location = new System.Drawing.Point(352, 355);
            this.btnNewInvoice.Name = "btnNewInvoice";
            this.btnNewInvoice.Size = new System.Drawing.Size(64, 37);
            this.btnNewInvoice.TabIndex = 14;
            this.btnNewInvoice.Text = "New bill";
            this.btnNewInvoice.UseVisualStyleBackColor = true;
            this.btnNewInvoice.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(7, 355);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(56, 37);
            this.btnAtras.TabIndex = 13;
            this.btnAtras.Text = "Exit";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(791, 320);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(97, 21);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
 
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(723, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 14);
            this.label10.TabIndex = 10;
            this.label10.Text = "Total $";
            // 
            // lblItems
            // 
            this.lblItems.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblItems.Location = new System.Drawing.Point(18, 254);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(101, 21);
            this.lblItems.TabIndex = 10;
            this.lblItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Location = new System.Drawing.Point(17, 27);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.Size = new System.Drawing.Size(873, 223);
            this.dgvInvoice.TabIndex = 2;
            this.dgvInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactura_CellClick);
            this.dgvInvoice.SelectionChanged += new System.EventHandler(this.dgvInvoice_SelectionChanged);
            this.dgvInvoice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvFactura_KeyUp);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Location = new System.Drawing.Point(796, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(97, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove item";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Location = new System.Drawing.Point(17, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add...";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblserie
            // 
            this.lblserie.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblserie.Location = new System.Drawing.Point(354, 109);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(82, 24);
            this.lblserie.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtQuanityProduct);
            this.groupBox2.Controls.Add(this.txtPriceProduct);
            this.groupBox2.Controls.Add(this.txtNameProduct);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(21, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(826, 90);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 14);
            this.label9.TabIndex = 1;
            this.label9.Text = "Price: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(381, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 14);
            this.label12.TabIndex = 2;
            this.label12.Text = "Quantity:";
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Enabled = false;
            this.txtNameProduct.Location = new System.Drawing.Point(52, 21);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(300, 22);
            this.txtNameProduct.TabIndex = 3;
            // 
            // txtPriceProduct
            // 
            this.txtPriceProduct.Enabled = false;
            this.txtPriceProduct.Location = new System.Drawing.Point(52, 49);
            this.txtPriceProduct.Name = "txtPriceProduct";
            this.txtPriceProduct.Size = new System.Drawing.Size(84, 22);
            this.txtPriceProduct.TabIndex = 4;
            // 
            // txtQuanityProduct
            // 
            this.txtQuanityProduct.Location = new System.Drawing.Point(457, 21);
            this.txtQuanityProduct.Name = "txtQuanityProduct";
            this.txtQuanityProduct.Size = new System.Drawing.Size(84, 22);
            this.txtQuanityProduct.TabIndex = 5;
            this.txtQuanityProduct.TextChanged += new System.EventHandler(this.txtQuanityProduct_TextChanged);
            // 
            // frmFacturation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(926, 720);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblserie);
            this.Controls.Add(this.lblcorre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(942, 759);
            this.MinimumSize = new System.Drawing.Size(942, 759);
            this.Name = "frmFacturation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Invoice :.";
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodoU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearchDNI;
        private System.Windows.Forms.Button btnSearchById;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnNewInvoice;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnCancelInvoice;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Label lblcorre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtFechaFac;
        private System.Windows.Forms.Label lblserie;
        private System.Windows.Forms.Label lblNetTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblITBIS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtQuanityProduct;
        private System.Windows.Forms.TextBox txtPriceProduct;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
    }
}