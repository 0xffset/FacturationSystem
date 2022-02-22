namespace CapaPresentacion
{
    partial class frmVentasClienteXId
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreCli = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CodigoVendedor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombreVen = new System.Windows.Forms.Label();
            this.lblFechVenta = new System.Windows.Forms.Label();
            this.EstadoVenta = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCodigoFac = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblNombreCli);
            this.groupBox1.Location = new System.Drawing.Point(14, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 14);
            this.label2.TabIndex = 1;
            // 
            // lblNombreCli
            // 
            this.lblNombreCli.AutoSize = true;
            this.lblNombreCli.Location = new System.Drawing.Point(7, 30);
            this.lblNombreCli.Name = "lblNombreCli";
            this.lblNombreCli.Size = new System.Drawing.Size(113, 14);
            this.lblNombreCli.TabIndex = 0;
            this.lblNombreCli.Text = "Nombre Del Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CodigoVendedor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblNombreVen);
            this.groupBox2.Location = new System.Drawing.Point(367, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 85);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vendedor";
            // 
            // CodigoVendedor
            // 
            this.CodigoVendedor.AutoSize = true;
            this.CodigoVendedor.Location = new System.Drawing.Point(7, 53);
            this.CodigoVendedor.Name = "CodigoVendedor";
            this.CodigoVendedor.Size = new System.Drawing.Size(100, 14);
            this.CodigoVendedor.TabIndex = 2;
            this.CodigoVendedor.Text = "CodigoVendedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 14);
            this.label3.TabIndex = 1;
            // 
            // lblNombreVen
            // 
            this.lblNombreVen.AutoSize = true;
            this.lblNombreVen.Location = new System.Drawing.Point(7, 30);
            this.lblNombreVen.Name = "lblNombreVen";
            this.lblNombreVen.Size = new System.Drawing.Size(128, 14);
            this.lblNombreVen.TabIndex = 0;
            this.lblNombreVen.Text = "Nombre del Vendedor";
            // 
            // lblFechVenta
            // 
            this.lblFechVenta.AutoSize = true;
            this.lblFechVenta.Location = new System.Drawing.Point(650, 22);
            this.lblFechVenta.Name = "lblFechVenta";
            this.lblFechVenta.Size = new System.Drawing.Size(73, 14);
            this.lblFechVenta.TabIndex = 2;
            this.lblFechVenta.Text = "Fecha Venta";
            // 
            // EstadoVenta
            // 
            this.EstadoVenta.AutoSize = true;
            this.EstadoVenta.Location = new System.Drawing.Point(381, 22);
            this.EstadoVenta.Name = "EstadoVenta";
            this.EstadoVenta.Size = new System.Drawing.Size(78, 14);
            this.EstadoVenta.TabIndex = 3;
            this.EstadoVenta.Text = "Estado Venta";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 152);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(903, 302);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(777, 100);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(73, 14);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Fecha Venta";
            // 
            // lblCodigoFac
            // 
            this.lblCodigoFac.AutoSize = true;
            this.lblCodigoFac.Location = new System.Drawing.Point(21, 9);
            this.lblCodigoFac.Name = "lblCodigoFac";
            this.lblCodigoFac.Size = new System.Drawing.Size(78, 14);
            this.lblCodigoFac.TabIndex = 6;
            this.lblCodigoFac.Text = "Estado Venta";
            // 
            // frmVentasClienteXId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.Controls.Add(this.lblCodigoFac);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.EstadoVenta);
            this.Controls.Add(this.lblFechVenta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmVentasClienteXId";
            this.Text = "frmVentasClienteXId";
            this.Load += new System.EventHandler(this.frmVentasClienteXId_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreCli;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label CodigoVendedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombreVen;
        private System.Windows.Forms.Label lblFechVenta;
        private System.Windows.Forms.Label EstadoVenta;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCodigoFac;
    }
}