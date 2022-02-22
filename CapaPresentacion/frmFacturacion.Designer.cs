namespace CapaPresentacion
{
    partial class frmFacturacion
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
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscarxId = new System.Windows.Forms.Button();
            this.btnBuscarCe = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigou = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblserie = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Almacen G.L.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(452, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "FACTURA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblcorre
            // 
            this.lblcorre.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcorre.Location = new System.Drawing.Point(470, 82);
            this.lblcorre.Name = "lblcorre";
            this.lblcorre.Size = new System.Drawing.Size(135, 26);
            this.lblcorre.TabIndex = 5;
            this.lblcorre.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.label8);
            this.gbCliente.Controls.Add(this.dtFechaFac);
            this.gbCliente.Controls.Add(this.txtDireccion);
            this.gbCliente.Controls.Add(this.label7);
            this.gbCliente.Controls.Add(this.btnBuscarxId);
            this.gbCliente.Controls.Add(this.btnBuscarCe);
            this.gbCliente.Controls.Add(this.txtCedula);
            this.gbCliente.Controls.Add(this.label6);
            this.gbCliente.Controls.Add(this.txtNo);
            this.gbCliente.Controls.Add(this.label5);
            this.gbCliente.Controls.Add(this.txtCodigou);
            this.gbCliente.Controls.Add(this.label4);
            this.gbCliente.Location = new System.Drawing.Point(28, 143);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(570, 170);
            this.gbCliente.TabIndex = 4;
            this.gbCliente.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Fecha de realizacion";
            // 
            // dtFechaFac
            // 
            this.dtFechaFac.Enabled = false;
            this.dtFechaFac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFac.Location = new System.Drawing.Point(403, 90);
            this.dtFechaFac.Name = "dtFechaFac";
            this.dtFechaFac.Size = new System.Drawing.Size(92, 21);
            this.dtFechaFac.TabIndex = 10;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(27, 134);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(320, 21);
            this.txtDireccion.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "DIreccion";
            // 
            // btnBuscarxId
            // 
            this.btnBuscarxId.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarxId.Image = global::CapaPresentacion.Properties.Resources.Accept_16px;
            this.btnBuscarxId.Location = new System.Drawing.Point(491, 53);
            this.btnBuscarxId.Name = "btnBuscarxId";
            this.btnBuscarxId.Size = new System.Drawing.Size(37, 34);
            this.btnBuscarxId.TabIndex = 7;
            this.btnBuscarxId.UseVisualStyleBackColor = true;
            this.btnBuscarxId.Click += new System.EventHandler(this.btnBuscarxId_Click);
            // 
            // btnBuscarCe
            // 
            this.btnBuscarCe.Image = global::CapaPresentacion.Properties.Resources.Search_24px;
            this.btnBuscarCe.Location = new System.Drawing.Point(448, 53);
            this.btnBuscarCe.Name = "btnBuscarCe";
            this.btnBuscarCe.Size = new System.Drawing.Size(37, 34);
            this.btnBuscarCe.TabIndex = 6;
            this.btnBuscarCe.UseVisualStyleBackColor = true;
            this.btnBuscarCe.Click += new System.EventHandler(this.btnBuscarCe_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(276, 60);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(166, 21);
            this.txtCedula.TabIndex = 5;
            this.txtCedula.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCedula_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cedula";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(27, 81);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(241, 21);
            this.txtNo.TabIndex = 3;
            this.txtNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCodigou
            // 
            this.txtCodigou.Enabled = false;
            this.txtCodigou.Location = new System.Drawing.Point(27, 39);
            this.txtCodigou.Name = "txtCodigou";
            this.txtCodigou.ReadOnly = true;
            this.txtCodigou.Size = new System.Drawing.Size(85, 21);
            this.txtCodigou.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Usuario";
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
            this.panel1.Controls.Add(this.dgvFactura);
            this.panel1.Controls.Add(this.btnQuitar);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(21, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 356);
            this.panel1.TabIndex = 5;
            // 
            // btnAnular
            // 
            this.btnAnular.Image = global::CapaPresentacion.Properties.Resources.Unavailable_32px;
            this.btnAnular.Location = new System.Drawing.Point(337, 302);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(50, 40);
            this.btnAnular.TabIndex = 16;
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::CapaPresentacion.Properties.Resources.Save_32px;
            this.btnGuardar.Location = new System.Drawing.Point(281, 302);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(50, 40);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::CapaPresentacion.Properties.Resources.Add_List_32px;
            this.btnNuevo.Location = new System.Drawing.Point(225, 302);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 40);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Image = global::CapaPresentacion.Properties.Resources.Back_24px;
            this.btnAtras.Location = new System.Drawing.Point(17, 302);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(56, 40);
            this.btnAtras.TabIndex = 13;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(492, 275);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(97, 23);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtTotal.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(442, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Total $";
            // 
            // lblItems
            // 
            this.lblItems.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblItems.Location = new System.Drawing.Point(18, 272);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(101, 23);
            this.lblItems.TabIndex = 10;
            this.lblItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblItems.Click += new System.EventHandler(this.label8_Click);
            // 
            // dgvFactura
            // 
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Location = new System.Drawing.Point(17, 29);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.Size = new System.Drawing.Size(576, 239);
            this.dgvFactura.TabIndex = 2;
            this.dgvFactura.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactura_CellClick);
            this.dgvFactura.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvFactura_KeyUp);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.Azure;
            this.btnQuitar.Image = global::CapaPresentacion.Properties.Resources.Delete_24px1;
            this.btnQuitar.Location = new System.Drawing.Point(548, 3);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(45, 25);
            this.btnQuitar.TabIndex = 1;
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Azure;
            this.btnAdd.Image = global::CapaPresentacion.Properties.Resources.icons8_Add_File_16;
            this.btnAdd.Location = new System.Drawing.Point(17, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 25);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblserie
            // 
            this.lblserie.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblserie.Location = new System.Drawing.Point(354, 117);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(82, 26);
            this.lblserie.TabIndex = 4;
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(634, 683);
            this.Controls.Add(this.lblserie);
            this.Controls.Add(this.lblcorre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigou;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarCe;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscarxId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.DataGridView dgvFactura;
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