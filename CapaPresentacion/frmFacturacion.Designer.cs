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
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblserie = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Almacen G.L.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(452, 11);
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
            this.label3.Text = "INVOICE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblcorre
            // 
            this.lblcorre.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcorre.Location = new System.Drawing.Point(470, 77);
            this.lblcorre.Name = "lblcorre";
            this.lblcorre.Size = new System.Drawing.Size(135, 24);
            this.lblcorre.TabIndex = 5;
            this.lblcorre.Click += new System.EventHandler(this.label8_Click_1);
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
            this.gbCliente.Location = new System.Drawing.Point(28, 133);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(570, 159);
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
            this.btnSearchById.Location = new System.Drawing.Point(491, 49);
            this.btnSearchById.Name = "btnSearchById";
            this.btnSearchById.Size = new System.Drawing.Size(37, 32);
            this.btnSearchById.TabIndex = 7;
            this.btnSearchById.UseVisualStyleBackColor = true;
            this.btnSearchById.Click += new System.EventHandler(this.btnBuscarxId_Click);
            // 
            // btnSearchDNI
            // 
            this.btnSearchDNI.Image = global::CapaPresentacion.Properties.Resources.Search_24px;
            this.btnSearchDNI.Location = new System.Drawing.Point(448, 49);
            this.btnSearchDNI.Name = "btnSearchDNI";
            this.btnSearchDNI.Size = new System.Drawing.Size(37, 32);
            this.btnSearchDNI.TabIndex = 6;
            this.btnSearchDNI.UseVisualStyleBackColor = true;
            this.btnSearchDNI.Click += new System.EventHandler(this.btnBuscarCe_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(276, 56);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(166, 22);
            this.txtDNI.TabIndex = 5;
            this.txtDNI.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCedula_KeyUp);
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
            this.txtCustomerName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "Customer Name: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
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
            this.panel1.Controls.Add(this.btnAnular);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblItems);
            this.panel1.Controls.Add(this.dgvInvoice);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(21, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 332);
            this.panel1.TabIndex = 5;
            // 
            // btnAnular
            // 
            this.btnAnular.Image = global::CapaPresentacion.Properties.Resources.Unavailable_32px;
            this.btnAnular.Location = new System.Drawing.Point(337, 282);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(50, 37);
            this.btnAnular.TabIndex = 16;
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::CapaPresentacion.Properties.Resources.Save_32px;
            this.btnGuardar.Location = new System.Drawing.Point(281, 282);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(50, 37);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::CapaPresentacion.Properties.Resources.Add_List_32px;
            this.btnNuevo.Location = new System.Drawing.Point(225, 282);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 37);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Image = global::CapaPresentacion.Properties.Resources.Back_24px;
            this.btnAtras.Location = new System.Drawing.Point(17, 282);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(56, 37);
            this.btnAtras.TabIndex = 13;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(492, 257);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(97, 21);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtTotal.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(442, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 14);
            this.label10.TabIndex = 10;
            this.label10.Text = "Total $";
            // 
            // lblItems
            // 
            this.lblItems.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblItems.Location = new System.Drawing.Point(18, 254);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(101, 21);
            this.lblItems.TabIndex = 10;
            this.lblItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblItems.Click += new System.EventHandler(this.label8_Click);
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Location = new System.Drawing.Point(17, 27);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.Size = new System.Drawing.Size(576, 223);
            this.dgvInvoice.TabIndex = 2;
            this.dgvInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactura_CellClick);
            this.dgvInvoice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvFactura_KeyUp);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Azure;
            this.btnRemove.Image = global::CapaPresentacion.Properties.Resources.Delete_24px1;
            this.btnRemove.Location = new System.Drawing.Point(548, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(45, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Azure;
            this.btnAdd.Image = global::CapaPresentacion.Properties.Resources.icons8_Add_File_16;
            this.btnAdd.Location = new System.Drawing.Point(17, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 23);
            this.btnAdd.TabIndex = 0;
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
            // frmFacturation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(634, 637);
            this.Controls.Add(this.lblserie);
            this.Controls.Add(this.lblcorre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblcorre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtFechaFac;
        private System.Windows.Forms.Label lblserie;
    }
}