namespace CapaPresentacion
{
    partial class frmDetalleV
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
            this.lblvende = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblestadoven = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblnumero = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblclien = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.lblnofac = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listDetalles = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.lbltota = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendedor";
            // 
            // lblvende
            // 
            this.lblvende.BackColor = System.Drawing.SystemColors.Control;
            this.lblvende.Location = new System.Drawing.Point(16, 41);
            this.lblvende.Name = "lblvende";
            this.lblvende.Size = new System.Drawing.Size(266, 21);
            this.lblvende.TabIndex = 1;
            this.lblvende.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblestadoven
            // 
            this.lblestadoven.BackColor = System.Drawing.SystemColors.Control;
            this.lblestadoven.Location = new System.Drawing.Point(30, 111);
            this.lblestadoven.Name = "lblestadoven";
            this.lblestadoven.Size = new System.Drawing.Size(57, 21);
            this.lblestadoven.TabIndex = 3;
            this.lblestadoven.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Codigo Venta";
            // 
            // lblcodigo
            // 
            this.lblcodigo.BackColor = System.Drawing.SystemColors.Control;
            this.lblcodigo.Location = new System.Drawing.Point(29, 168);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(189, 21);
            this.lblcodigo.TabIndex = 5;
            this.lblcodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblcodigo.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblnumero
            // 
            this.lblnumero.BackColor = System.Drawing.SystemColors.Control;
            this.lblnumero.Location = new System.Drawing.Point(224, 168);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(189, 21);
            this.lblnumero.TabIndex = 7;
            this.lblnumero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(345, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cedula";
            // 
            // lblclien
            // 
            this.lblclien.BackColor = System.Drawing.SystemColors.Control;
            this.lblclien.Location = new System.Drawing.Point(31, 230);
            this.lblclien.Name = "lblclien";
            this.lblclien.Size = new System.Drawing.Size(273, 21);
            this.lblclien.TabIndex = 9;
            this.lblclien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(245, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Cliente ";
            // 
            // lblhora
            // 
            this.lblhora.BackColor = System.Drawing.SystemColors.Control;
            this.lblhora.Location = new System.Drawing.Point(579, 111);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(74, 21);
            this.lblhora.TabIndex = 11;
            this.lblhora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Hora
            // 
            this.Hora.AutoSize = true;
            this.Hora.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.Location = new System.Drawing.Point(517, 113);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(46, 18);
            this.Hora.TabIndex = 10;
            this.Hora.Text = "Hora ";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.Location = new System.Drawing.Point(582, 87);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(100, 21);
            this.dtpfecha.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(517, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha";
            // 
            // lblnofac
            // 
            this.lblnofac.BackColor = System.Drawing.SystemColors.Control;
            this.lblnofac.Location = new System.Drawing.Point(416, 230);
            this.lblnofac.Name = "lblnofac";
            this.lblnofac.Size = new System.Drawing.Size(167, 21);
            this.lblnofac.TabIndex = 15;
            this.lblnofac.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(489, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "No. Factura ";
            // 
            // listDetalles
            // 
            this.listDetalles.HideSelection = false;
            this.listDetalles.Location = new System.Drawing.Point(32, 284);
            this.listDetalles.Name = "listDetalles";
            this.listDetalles.Size = new System.Drawing.Size(579, 328);
            this.listDetalles.TabIndex = 16;
            this.listDetalles.UseCompatibleStateImageBehavior = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Detalles";
            // 
            // lbltota
            // 
            this.lbltota.BackColor = System.Drawing.SystemColors.Control;
            this.lbltota.Location = new System.Drawing.Point(617, 546);
            this.lbltota.Name = "lbltota";
            this.lbltota.Size = new System.Drawing.Size(118, 21);
            this.lbltota.TabIndex = 19;
            this.lbltota.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // frmDetalleV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(740, 644);
            this.Controls.Add(this.lbltota);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listDetalles);
            this.Controls.Add(this.lblnofac);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.lblclien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblestadoven);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblvende);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDetalleV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle Venta";
            this.Load += new System.EventHandler(this.frmDetalleV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblvende;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblestadoven;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblclien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblnofac;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listDetalles;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbltota;
        private System.Windows.Forms.Label label12;
    }
}