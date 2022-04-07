namespace CapaPresentacion
{
    partial class frmCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxocultar = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.txtindetifCard = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvcustomer = new System.Windows.Forms.DataGridView();
            this.BTNSell = new System.Windows.Forms.Button();
            this.BTNDelete = new System.Windows.Forms.Button();
            this.BTNNew = new System.Windows.Forms.Button();
            this.BTnExit = new System.Windows.Forms.Button();
            this.BTNEdit = new System.Windows.Forms.Button();
            this.btnUpdateCostumers = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-13, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1301, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = ".: CUSTOMERS :. ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxocultar);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtNameSearch);
            this.groupBox1.Controls.Add(this.txtindetifCard);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 107);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // cBoxocultar
            // 
            this.cBoxocultar.AutoSize = true;
            this.cBoxocultar.Location = new System.Drawing.Point(392, 81);
            this.cBoxocultar.Name = "cBoxocultar";
            this.cBoxocultar.Size = new System.Drawing.Size(15, 14);
            this.cBoxocultar.TabIndex = 5;
            this.cBoxocultar.UseVisualStyleBackColor = true;
            this.cBoxocultar.CheckedChanged += new System.EventHandler(this.cBoxocultar_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::CapaPresentacion.Properties.Resources.Search_24px;
            this.btnSearch.Location = new System.Drawing.Point(405, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(52, 35);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(94, 66);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(292, 26);
            this.txtNameSearch.TabIndex = 3;
            this.txtNameSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtnombre_KeyUp);
            // 
            // txtindetifCard
            // 
            this.txtindetifCard.Location = new System.Drawing.Point(144, 30);
            this.txtindetifCard.Name = "txtindetifCard";
            this.txtindetifCard.Size = new System.Drawing.Size(255, 26);
            this.txtindetifCard.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ident. Card:";
            // 
            // dgvcustomer
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcustomer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcustomer.Location = new System.Drawing.Point(23, 187);
            this.dgvcustomer.Name = "dgvcustomer";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcustomer.Size = new System.Drawing.Size(1120, 287);
            this.dgvcustomer.TabIndex = 4;
            this.dgvcustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcliente_CellClick);
            // 
            // btnSell
            // 
            this.BTNSell.Font = new System.Drawing.Font("Consolas", 14F);
            this.BTNSell.Image = global::CapaPresentacion.Properties.Resources.Buying_24px1;
            this.BTNSell.Location = new System.Drawing.Point(683, 120);
            this.BTNSell.Name = "btnSell";
            this.BTNSell.Size = new System.Drawing.Size(135, 48);
            this.BTNSell.TabIndex = 6;
            this.BTNSell.UseVisualStyleBackColor = true;
            this.BTNSell.Click += new System.EventHandler(this.BTNvender_Click);
            // 
            // BTneliminar
            // 
            this.BTNDelete.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDelete.Location = new System.Drawing.Point(1149, 327);
            this.BTNDelete.Name = "BTneliminar";
            this.BTNDelete.Size = new System.Drawing.Size(124, 64);
            this.BTNDelete.TabIndex = 16;
            this.BTNDelete.Text = "Remove";
            this.BTNDelete.UseVisualStyleBackColor = true;
            this.BTNDelete.Click += new System.EventHandler(this.BTneliminar_Click);
            // 
            // BTNnuevo
            // 
            this.BTNNew.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNNew.Location = new System.Drawing.Point(1149, 187);
            this.BTNNew.Name = "BTNnuevo";
            this.BTNNew.Size = new System.Drawing.Size(124, 64);
            this.BTNNew.TabIndex = 15;
            this.BTNNew.Text = "New";
            this.BTNNew.UseVisualStyleBackColor = true;
            this.BTNNew.Click += new System.EventHandler(this.BTNnuevo_Click);
            // 
            // BTNsalir
            // 
            this.BTnExit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTnExit.Location = new System.Drawing.Point(1149, 397);
            this.BTnExit.Name = "BTNsalir";
            this.BTnExit.Size = new System.Drawing.Size(124, 64);
            this.BTnExit.TabIndex = 14;
            this.BTnExit.Text = "Exit";
            this.BTnExit.UseVisualStyleBackColor = true;
            this.BTnExit.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // BTNeditar
            // 
            this.BTNEdit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEdit.Location = new System.Drawing.Point(1149, 257);
            this.BTNEdit.Name = "BTNeditar";
            this.BTNEdit.Size = new System.Drawing.Size(124, 64);
            this.BTNEdit.TabIndex = 12;
            this.BTNEdit.Text = "Edit";
            this.BTNEdit.UseVisualStyleBackColor = true;
            this.BTNEdit.Click += new System.EventHandler(this.BTNeditar_Click);
            // 
            // btnUpdateCostumers
            // 
            this.btnUpdateCostumers.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdateCostumers.Location = new System.Drawing.Point(824, 120);
            this.btnUpdateCostumers.Name = "btnUpdateCostumers";
            this.btnUpdateCostumers.Size = new System.Drawing.Size(174, 48);
            this.btnUpdateCostumers.TabIndex = 17;
            this.btnUpdateCostumers.Text = "Update List";
            this.btnUpdateCostumers.UseVisualStyleBackColor = true;
            this.btnUpdateCostumers.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1285, 516);
            this.Controls.Add(this.btnUpdateCostumers);
            this.Controls.Add(this.BTNSell);
            this.Controls.Add(this.BTNDelete);
            this.Controls.Add(this.BTNNew);
            this.Controls.Add(this.BTnExit);
            this.Controls.Add(this.BTNEdit);
            this.Controls.Add(this.dgvcustomer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1301, 555);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1301, 555);
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Customers :.";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.TextBox txtindetifCard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox cBoxocultar;
        private System.Windows.Forms.DataGridView dgvcustomer;
        private System.Windows.Forms.Button BTNNew;
        private System.Windows.Forms.Button BTnExit;
        private System.Windows.Forms.Button BTNEdit;
        private System.Windows.Forms.Button BTNDelete;
        private System.Windows.Forms.Button BTNSell;
        private System.Windows.Forms.Button btnUpdateCostumers;
    }
}