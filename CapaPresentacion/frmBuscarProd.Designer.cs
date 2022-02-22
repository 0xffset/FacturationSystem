namespace CapaPresentacion
{
    partial class frmBuscarProd
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
            this.rbPrecio = new System.Windows.Forms.CheckBox();
            this.rbCategoria = new System.Windows.Forms.CheckBox();
            this.rbNombre = new System.Windows.Forms.CheckBox();
            this.txtBuscarProd = new System.Windows.Forms.TextBox();
            this.dgvproducto = new System.Windows.Forms.DataGridView();
            this.BTNactualizar = new System.Windows.Forms.Button();
            this.BTNvender = new System.Windows.Forms.Button();
            this.BTNmantenimiento = new System.Windows.Forms.Button();
            this.BTNsalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.Highlight;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(-9, -1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1331, 34);
            this.label12.TabIndex = 3;
            this.label12.Text = "BUSCAR PRODUCTO";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.rbPrecio);
            this.groupBox1.Controls.Add(this.rbCategoria);
            this.groupBox1.Controls.Add(this.rbNombre);
            this.groupBox1.Controls.Add(this.txtBuscarProd);
            this.groupBox1.Location = new System.Drawing.Point(86, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por";
            // 
            // rbPrecio
            // 
            this.rbPrecio.AutoSize = true;
            this.rbPrecio.Location = new System.Drawing.Point(240, 63);
            this.rbPrecio.Name = "rbPrecio";
            this.rbPrecio.Size = new System.Drawing.Size(63, 19);
            this.rbPrecio.TabIndex = 3;
            this.rbPrecio.Text = "Precio";
            this.rbPrecio.UseVisualStyleBackColor = true;
            this.rbPrecio.CheckedChanged += new System.EventHandler(this.rbPrecio_CheckedChanged);
            // 
            // rbCategoria
            // 
            this.rbCategoria.AutoSize = true;
            this.rbCategoria.Location = new System.Drawing.Point(137, 64);
            this.rbCategoria.Name = "rbCategoria";
            this.rbCategoria.Size = new System.Drawing.Size(81, 19);
            this.rbCategoria.TabIndex = 2;
            this.rbCategoria.Text = "Categoria";
            this.rbCategoria.UseVisualStyleBackColor = true;
            this.rbCategoria.CheckedChanged += new System.EventHandler(this.rbCategoria_CheckedChanged);
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(43, 64);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(71, 19);
            this.rbNombre.TabIndex = 1;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            this.rbNombre.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtBuscarProd
            // 
            this.txtBuscarProd.Location = new System.Drawing.Point(43, 36);
            this.txtBuscarProd.Name = "txtBuscarProd";
            this.txtBuscarProd.Size = new System.Drawing.Size(283, 21);
            this.txtBuscarProd.TabIndex = 0;
            this.txtBuscarProd.TextChanged += new System.EventHandler(this.txtBuscarProd_TextChanged);
            this.txtBuscarProd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarProd_KeyUp);
            // 
            // dgvproducto
            // 
            this.dgvproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproducto.Location = new System.Drawing.Point(86, 164);
            this.dgvproducto.Name = "dgvproducto";
            this.dgvproducto.Size = new System.Drawing.Size(1029, 361);
            this.dgvproducto.TabIndex = 5;
            this.dgvproducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproducto_CellClick);
            // 
            // BTNactualizar
            // 
            this.BTNactualizar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.BTNactualizar.Location = new System.Drawing.Point(732, 113);
            this.BTNactualizar.Name = "BTNactualizar";
            this.BTNactualizar.Size = new System.Drawing.Size(80, 40);
            this.BTNactualizar.TabIndex = 19;
            this.BTNactualizar.Text = "Actualizar";
            this.BTNactualizar.UseVisualStyleBackColor = true;
            this.BTNactualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNvender
            // 
            this.BTNvender.Image = global::CapaPresentacion.Properties.Resources.Buying_24px1;
            this.BTNvender.Location = new System.Drawing.Point(648, 113);
            this.BTNvender.Name = "BTNvender";
            this.BTNvender.Size = new System.Drawing.Size(80, 40);
            this.BTNvender.TabIndex = 18;
            this.BTNvender.UseVisualStyleBackColor = true;
            this.BTNvender.Click += new System.EventHandler(this.BTNvender_Click);
            // 
            // BTNmantenimiento
            // 
            this.BTNmantenimiento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.BTNmantenimiento.Location = new System.Drawing.Point(818, 114);
            this.BTNmantenimiento.Name = "BTNmantenimiento";
            this.BTNmantenimiento.Size = new System.Drawing.Size(80, 40);
            this.BTNmantenimiento.TabIndex = 20;
            this.BTNmantenimiento.Text = "Manten...";
            this.BTNmantenimiento.UseVisualStyleBackColor = true;
            this.BTNmantenimiento.Click += new System.EventHandler(this.BTNmantenimiento_Click);
            // 
            // BTNsalir
            // 
            this.BTNsalir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.BTNsalir.Location = new System.Drawing.Point(904, 114);
            this.BTNsalir.Name = "BTNsalir";
            this.BTNsalir.Size = new System.Drawing.Size(80, 40);
            this.BTNsalir.TabIndex = 21;
            this.BTNsalir.Text = "Salir";
            this.BTNsalir.UseVisualStyleBackColor = true;
            this.BTNsalir.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // frmBuscarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1284, 573);
            this.Controls.Add(this.BTNsalir);
            this.Controls.Add(this.BTNmantenimiento);
            this.Controls.Add(this.BTNactualizar);
            this.Controls.Add(this.BTNvender);
            this.Controls.Add(this.dgvproducto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBuscarProd";
            this.Text = "Buscar Producto";
            this.Load += new System.EventHandler(this.frmBuscarProd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox rbPrecio;
        private System.Windows.Forms.CheckBox rbCategoria;
        private System.Windows.Forms.CheckBox rbNombre;
        private System.Windows.Forms.TextBox txtBuscarProd;
        private System.Windows.Forms.DataGridView dgvproducto;
        private System.Windows.Forms.Button BTNactualizar;
        private System.Windows.Forms.Button BTNvender;
        private System.Windows.Forms.Button BTNmantenimiento;
        private System.Windows.Forms.Button BTNsalir;
    }
}