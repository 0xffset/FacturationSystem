namespace CapaPresentacion
{
    partial class frmSearchProduct
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
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPrice = new System.Windows.Forms.CheckBox();
            this.rbCategory = new System.Windows.Forms.CheckBox();
            this.rbName = new System.Windows.Forms.CheckBox();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.dgvproduct = new System.Windows.Forms.DataGridView();
            this.BTNUpdate = new System.Windows.Forms.Button();
            this.BTNSale = new System.Windows.Forms.Button();
            this.BTNEditProduct = new System.Windows.Forms.Button();
            this.BTNExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label12.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(-9, -1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1331, 32);
            this.label12.TabIndex = 3;
            this.label12.Text = ".: SEARCH PRODUCT :.";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.rbPrice);
            this.groupBox1.Controls.Add(this.rbCategory);
            this.groupBox1.Controls.Add(this.rbName);
            this.groupBox1.Controls.Add(this.txtSearchProduct);
            this.groupBox1.Location = new System.Drawing.Point(86, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 93);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by:";
            // 
            // rbPrice
            // 
            this.rbPrice.AutoSize = true;
            this.rbPrice.Location = new System.Drawing.Point(240, 59);
            this.rbPrice.Name = "rbPrice";
            this.rbPrice.Size = new System.Drawing.Size(61, 18);
            this.rbPrice.TabIndex = 3;
            this.rbPrice.Text = "Price";
            this.rbPrice.UseVisualStyleBackColor = true;
            this.rbPrice.CheckedChanged += new System.EventHandler(this.rbPrecio_CheckedChanged);
            // 
            // rbCategory
            // 
            this.rbCategory.AutoSize = true;
            this.rbCategory.Location = new System.Drawing.Point(137, 60);
            this.rbCategory.Name = "rbCategory";
            this.rbCategory.Size = new System.Drawing.Size(82, 18);
            this.rbCategory.TabIndex = 2;
            this.rbCategory.Text = "Category";
            this.rbCategory.UseVisualStyleBackColor = true;
            this.rbCategory.CheckedChanged += new System.EventHandler(this.rbCategoria_CheckedChanged);
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Location = new System.Drawing.Point(43, 60);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(54, 18);
            this.rbName.TabIndex = 1;
            this.rbName.Text = "Name";
            this.rbName.UseVisualStyleBackColor = true;
            this.rbName.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Location = new System.Drawing.Point(43, 34);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(283, 22);
            this.txtSearchProduct.TabIndex = 0;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtBuscarProd_TextChanged);
            this.txtSearchProduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarProd_KeyUp);
            // 
            // dgvproduct
            // 
            this.dgvproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduct.Location = new System.Drawing.Point(86, 153);
            this.dgvproduct.Name = "dgvproduct";
            this.dgvproduct.Size = new System.Drawing.Size(1029, 337);
            this.dgvproduct.TabIndex = 5;
            this.dgvproduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproducto_CellClick);
            // 
            // BTNUpdate
            // 
            this.BTNUpdate.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.BTNUpdate.Location = new System.Drawing.Point(732, 105);
            this.BTNUpdate.Name = "BTNUpdate";
            this.BTNUpdate.Size = new System.Drawing.Size(80, 37);
            this.BTNUpdate.TabIndex = 19;
            this.BTNUpdate.Text = "Update";
            this.BTNUpdate.UseVisualStyleBackColor = true;
            this.BTNUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNSale
            // 
            this.BTNSale.Image = global::CapaPresentacion.Properties.Resources.Buying_24px1;
            this.BTNSale.Location = new System.Drawing.Point(648, 105);
            this.BTNSale.Name = "BTNSale";
            this.BTNSale.Size = new System.Drawing.Size(80, 37);
            this.BTNSale.TabIndex = 18;
            this.BTNSale.UseVisualStyleBackColor = true;
            this.BTNSale.Click += new System.EventHandler(this.BTNvender_Click);
            // 
            // BTNEditProduct
            // 
            this.BTNEditProduct.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.BTNEditProduct.Location = new System.Drawing.Point(818, 106);
            this.BTNEditProduct.Name = "BTNEditProduct";
            this.BTNEditProduct.Size = new System.Drawing.Size(101, 37);
            this.BTNEditProduct.TabIndex = 20;
            this.BTNEditProduct.Text = "Edit Prod...";
            this.BTNEditProduct.UseVisualStyleBackColor = true;
            this.BTNEditProduct.Click += new System.EventHandler(this.BTNmantenimiento_Click);
            // 
            // BTNExit
            // 
            this.BTNExit.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.BTNExit.Location = new System.Drawing.Point(925, 106);
            this.BTNExit.Name = "BTNExit";
            this.BTNExit.Size = new System.Drawing.Size(80, 37);
            this.BTNExit.TabIndex = 21;
            this.BTNExit.Text = "Exit";
            this.BTNExit.UseVisualStyleBackColor = true;
            this.BTNExit.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // frmSearchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1284, 535);
            this.Controls.Add(this.BTNExit);
            this.Controls.Add(this.BTNEditProduct);
            this.Controls.Add(this.BTNUpdate);
            this.Controls.Add(this.BTNSale);
            this.Controls.Add(this.dgvproduct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 574);
            this.MinimumSize = new System.Drawing.Size(1300, 574);
            this.Name = "frmSearchProduct";
            this.Text = ".: Search Products :.";
            this.Load += new System.EventHandler(this.frmBuscarProd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox rbPrice;
        private System.Windows.Forms.CheckBox rbCategory;
        private System.Windows.Forms.CheckBox rbName;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.DataGridView dgvproduct;
        private System.Windows.Forms.Button BTNUpdate;
        private System.Windows.Forms.Button BTNSale;
        private System.Windows.Forms.Button BTNEditProduct;
        private System.Windows.Forms.Button BTNExit;
    }
}