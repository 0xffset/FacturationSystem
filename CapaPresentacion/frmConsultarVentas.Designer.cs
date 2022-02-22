namespace CapaPresentacion
{
    partial class frmConsultarVentas
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAnularVenta = new System.Windows.Forms.Button();
            this.btnDetVenta = new System.Windows.Forms.Button();
            this.dgvHisVentas = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHisVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(793, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "HISTORIAL DE VENTAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.dtpFinal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpInicio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 116);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(272, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(166, 48);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(99, 21);
            this.dtpFinal.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Final";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(18, 48);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(99, 21);
            this.dtpInicio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha de Inicio";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAnularVenta);
            this.groupBox2.Controls.Add(this.btnDetVenta);
            this.groupBox2.Location = new System.Drawing.Point(396, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 116);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btnAnularVenta
            // 
            this.btnAnularVenta.Image = global::CapaPresentacion.Properties.Resources.Unavailable_32px;
            this.btnAnularVenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAnularVenta.Location = new System.Drawing.Point(113, 38);
            this.btnAnularVenta.Name = "btnAnularVenta";
            this.btnAnularVenta.Size = new System.Drawing.Size(85, 49);
            this.btnAnularVenta.TabIndex = 20;
            this.btnAnularVenta.Text = "Anu. Venta";
            this.btnAnularVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnularVenta.UseVisualStyleBackColor = true;
            this.btnAnularVenta.Click += new System.EventHandler(this.btnAnularVenta_Click);
            // 
            // btnDetVenta
            // 
            this.btnDetVenta.Image = global::CapaPresentacion.Properties.Resources.Buying_24px1;
            this.btnDetVenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDetVenta.Location = new System.Drawing.Point(12, 38);
            this.btnDetVenta.Name = "btnDetVenta";
            this.btnDetVenta.Size = new System.Drawing.Size(85, 49);
            this.btnDetVenta.TabIndex = 19;
            this.btnDetVenta.Text = "Det. Venta";
            this.btnDetVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDetVenta.UseVisualStyleBackColor = true;
            this.btnDetVenta.Click += new System.EventHandler(this.btnDetVenta_Click);
            // 
            // dgvHisVentas
            // 
            this.dgvHisVentas.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvHisVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHisVentas.Location = new System.Drawing.Point(132, 190);
            this.dgvHisVentas.Name = "dgvHisVentas";
            this.dgvHisVentas.Size = new System.Drawing.Size(500, 370);
            this.dgvHisVentas.TabIndex = 6;
            this.dgvHisVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHisVentas_CellClick);
            this.dgvHisVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHisVentas_CellContentClick);
            // 
            // frmConsultarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(777, 648);
            this.Controls.Add(this.dgvHisVentas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmConsultarVentas";
            this.Text = "`";
            this.Load += new System.EventHandler(this.frmConsultarVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHisVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDetVenta;
        private System.Windows.Forms.Button btnAnularVenta;
        private System.Windows.Forms.DataGridView dgvHisVentas;
    }
}