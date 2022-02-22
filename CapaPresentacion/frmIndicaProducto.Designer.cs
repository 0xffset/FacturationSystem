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
            this.button1 = new System.Windows.Forms.Button();
            this.rbStockCero = new System.Windows.Forms.RadioButton();
            this.rbStockMin = new System.Windows.Forms.RadioButton();
            this.rbStockPro = new System.Windows.Forms.RadioButton();
            this.rbStock = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCategoriap = new System.Windows.Forms.ComboBox();
            this.txtCodigop = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNombrePro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvproducto = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.Highlight;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(-72, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1244, 40);
            this.label12.TabIndex = 4;
            this.label12.Text = "STOCK DE PRODUCTO";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rbStockCero);
            this.groupBox1.Controls.Add(this.rbStockMin);
            this.groupBox1.Controls.Add(this.rbStockPro);
            this.groupBox1.Controls.Add(this.rbStock);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboCategoriap);
            this.groupBox1.Controls.Add(this.txtCodigop);
            this.groupBox1.Location = new System.Drawing.Point(15, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 126);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbStockCero
            // 
            this.rbStockCero.AutoSize = true;
            this.rbStockCero.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStockCero.Location = new System.Drawing.Point(227, 95);
            this.rbStockCero.Name = "rbStockCero";
            this.rbStockCero.Size = new System.Drawing.Size(88, 19);
            this.rbStockCero.TabIndex = 7;
            this.rbStockCero.TabStop = true;
            this.rbStockCero.Text = "Stock Cero";
            this.rbStockCero.UseVisualStyleBackColor = true;
            // 
            // rbStockMin
            // 
            this.rbStockMin.AutoSize = true;
            this.rbStockMin.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStockMin.Location = new System.Drawing.Point(227, 70);
            this.rbStockMin.Name = "rbStockMin";
            this.rbStockMin.Size = new System.Drawing.Size(102, 19);
            this.rbStockMin.TabIndex = 6;
            this.rbStockMin.TabStop = true;
            this.rbStockMin.Text = "Stock Minimo\r\n";
            this.rbStockMin.UseVisualStyleBackColor = true;
            // 
            // rbStockPro
            // 
            this.rbStockPro.AutoSize = true;
            this.rbStockPro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStockPro.Location = new System.Drawing.Point(227, 45);
            this.rbStockPro.Name = "rbStockPro";
            this.rbStockPro.Size = new System.Drawing.Size(116, 19);
            this.rbStockPro.TabIndex = 5;
            this.rbStockPro.TabStop = true;
            this.rbStockPro.Text = "Stock Promedio";
            this.rbStockPro.UseVisualStyleBackColor = true;
            // 
            // rbStock
            // 
            this.rbStock.AutoSize = true;
            this.rbStock.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStock.Location = new System.Drawing.Point(227, 20);
            this.rbStock.Name = "rbStock";
            this.rbStock.Size = new System.Drawing.Size(59, 19);
            this.rbStock.TabIndex = 4;
            this.rbStock.TabStop = true;
            this.rbStock.Text = "Todos";
            this.rbStock.UseVisualStyleBackColor = true;
            this.rbStock.CheckedChanged += new System.EventHandler(this.rbStock_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo";
            // 
            // cboCategoriap
            // 
            this.cboCategoriap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoriap.FormattingEnabled = true;
            this.cboCategoriap.Location = new System.Drawing.Point(12, 76);
            this.cboCategoriap.Name = "cboCategoriap";
            this.cboCategoriap.Size = new System.Drawing.Size(178, 23);
            this.cboCategoriap.TabIndex = 1;
            // 
            // txtCodigop
            // 
            this.txtCodigop.Location = new System.Drawing.Point(12, 36);
            this.txtCodigop.Name = "txtCodigop";
            this.txtCodigop.Size = new System.Drawing.Size(178, 21);
            this.txtCodigop.TabIndex = 0;
            this.txtCodigop.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigop_KeyUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNombrePro);
            this.groupBox2.Location = new System.Drawing.Point(518, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 126);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nombre";
            // 
            // txtNombrePro
            // 
            this.txtNombrePro.Location = new System.Drawing.Point(45, 52);
            this.txtNombrePro.Name = "txtNombrePro";
            this.txtNombrePro.Size = new System.Drawing.Size(285, 21);
            this.txtNombrePro.TabIndex = 0;
            this.txtNombrePro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNombrePro_KeyUp);
            // 
            // label3
            // 
            this.label3.Image = global::CapaPresentacion.Properties.Resources.circulo_verde24x242;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(890, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 35);
            this.label3.TabIndex = 10;
            this.label3.Text = "Stock Suficiente";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Image = global::CapaPresentacion.Properties.Resources.CirculoNaranja24x241;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(890, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 35);
            this.label4.TabIndex = 11;
            this.label4.Text = "Stock Promedio";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Image = global::CapaPresentacion.Properties.Resources.circulorojo_24x24;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(890, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 35);
            this.label5.TabIndex = 12;
            this.label5.Text = "Stock Minimo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvproducto
            // 
            this.dgvproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproducto.Location = new System.Drawing.Point(15, 195);
            this.dgvproducto.Name = "dgvproducto";
            this.dgvproducto.Size = new System.Drawing.Size(1075, 368);
            this.dgvproducto.TabIndex = 13;
            // 
            // frmIndicaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1171, 648);
            this.Controls.Add(this.dgvproducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmIndicaProducto";
            this.Text = "Stock de Productos";
            this.Load += new System.EventHandler(this.frmIndicaProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCategoriap;
        private System.Windows.Forms.TextBox txtCodigop;
        private System.Windows.Forms.RadioButton rbStock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbStockCero;
        private System.Windows.Forms.RadioButton rbStockMin;
        private System.Windows.Forms.RadioButton rbStockPro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNombrePro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvproducto;
    }
}