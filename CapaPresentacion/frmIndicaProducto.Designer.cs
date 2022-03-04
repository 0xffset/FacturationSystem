namespace CapaPresentacion
{
    partial class frmIndicaProducto
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.rbStockCero = new System.Windows.Forms.RadioButton();
            this.rbStockMin = new System.Windows.Forms.RadioButton();
            this.rbStockPro = new System.Windows.Forms.RadioButton();
            this.rbStock = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txtCodeProduct = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label12.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(-72, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1244, 37);
            this.label12.TabIndex = 4;
            this.label12.Text = ".: STOCK DE PRODUCTO :.";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.rbStockCero);
            this.groupBox1.Controls.Add(this.rbStockMin);
            this.groupBox1.Controls.Add(this.rbStockPro);
            this.groupBox1.Controls.Add(this.rbStock);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboCategory);
            this.groupBox1.Controls.Add(this.txtCodeProduct);
            this.groupBox1.Location = new System.Drawing.Point(15, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 118);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(387, 86);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 21);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbStockCero
            // 
            this.rbStockCero.AutoSize = true;
            this.rbStockCero.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStockCero.Location = new System.Drawing.Point(227, 89);
            this.rbStockCero.Name = "rbStockCero";
            this.rbStockCero.Size = new System.Drawing.Size(95, 18);
            this.rbStockCero.TabIndex = 7;
            this.rbStockCero.TabStop = true;
            this.rbStockCero.Text = "Stock Cero";
            this.rbStockCero.UseVisualStyleBackColor = true;
            // 
            // rbStockMin
            // 
            this.rbStockMin.AutoSize = true;
            this.rbStockMin.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStockMin.Location = new System.Drawing.Point(227, 65);
            this.rbStockMin.Name = "rbStockMin";
            this.rbStockMin.Size = new System.Drawing.Size(116, 18);
            this.rbStockMin.TabIndex = 6;
            this.rbStockMin.TabStop = true;
            this.rbStockMin.Text = "Minimun Stock";
            this.rbStockMin.UseVisualStyleBackColor = true;
            // 
            // rbStockPro
            // 
            this.rbStockPro.AutoSize = true;
            this.rbStockPro.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStockPro.Location = new System.Drawing.Point(227, 42);
            this.rbStockPro.Name = "rbStockPro";
            this.rbStockPro.Size = new System.Drawing.Size(116, 18);
            this.rbStockPro.TabIndex = 5;
            this.rbStockPro.TabStop = true;
            this.rbStockPro.Text = "Avarage Stock";
            this.rbStockPro.UseVisualStyleBackColor = true;
            // 
            // rbStock
            // 
            this.rbStock.AutoSize = true;
            this.rbStock.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStock.Location = new System.Drawing.Point(227, 19);
            this.rbStock.Name = "rbStock";
            this.rbStock.Size = new System.Drawing.Size(46, 18);
            this.rbStock.TabIndex = 4;
            this.rbStock.TabStop = true;
            this.rbStock.Text = "All";
            this.rbStock.UseVisualStyleBackColor = true;
            this.rbStock.CheckedChanged += new System.EventHandler(this.rbStock_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code";
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(12, 75);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(178, 22);
            this.cboCategory.TabIndex = 1;
            // 
            // txtCodeProduct
            // 
            this.txtCodeProduct.Location = new System.Drawing.Point(12, 34);
            this.txtCodeProduct.Name = "txtCodeProduct";
            this.txtCodeProduct.Size = new System.Drawing.Size(178, 22);
            this.txtCodeProduct.TabIndex = 0;
            this.txtCodeProduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigop_KeyUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNameProduct);
            this.groupBox2.Location = new System.Drawing.Point(518, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 118);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Name";
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Location = new System.Drawing.Point(45, 49);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(285, 22);
            this.txtNameProduct.TabIndex = 0;
            this.txtNameProduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNombrePro_KeyUp);
            // 
            // label3
            // 
            this.label3.Image = global::CapaPresentacion.Properties.Resources.circulo_verde24x242;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(890, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enough Stock";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Image = global::CapaPresentacion.Properties.Resources.CirculoNaranja24x241;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(890, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Avarage Stock";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Image = global::CapaPresentacion.Properties.Resources.circulorojo_24x24;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(890, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 33);
            this.label5.TabIndex = 12;
            this.label5.Text = "Minimun Stock";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(15, 182);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(1075, 343);
            this.dgvProduct.TabIndex = 13;
            // 
            // frmIndicaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1171, 605);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1187, 644);
            this.Name = "frmIndicaProducto";
            this.Text = ".: Product Invetary :.";
            this.Load += new System.EventHandler(this.frmIndicaProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.TextBox txtCodeProduct;
        private System.Windows.Forms.RadioButton rbStock;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rbStockCero;
        private System.Windows.Forms.RadioButton rbStockMin;
        private System.Windows.Forms.RadioButton rbStockPro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvProduct;
    }
}