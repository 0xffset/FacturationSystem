namespace CapaPresentacion
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.incicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MSIseguridad = new System.Windows.Forms.ToolStripMenuItem();
            this.MSIcliente = new System.Windows.Forms.ToolStripMenuItem();
            this.MSImatenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MSILogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.MSIsalir = new System.Windows.Forms.ToolStripMenuItem();
            this.efecturarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MSIventa = new System.Windows.Forms.ToolStripMenuItem();
            this.MSIQueries = new System.Windows.Forms.ToolStripMenuItem();
            this.MSIproducts = new System.Windows.Forms.ToolStripMenuItem();
            this.MSsales = new System.Windows.Forms.ToolStripMenuItem();
            this.MSIreportes = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVentasPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MSIayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineLearningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresionLinearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LBLusuario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblclientes = new System.Windows.Forms.Label();
            this.lblproductos = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelControllers = new System.Windows.Forms.Panel();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelControllers.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incicioToolStripMenuItem,
            this.efecturarToolStripMenuItem,
            this.MSIQueries,
            this.MSIreportes,
            this.MSIayuda,
            this.machineLearningToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1232, 44);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // incicioToolStripMenuItem
            // 
            this.incicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSIseguridad,
            this.MSIcliente,
            this.MSImatenimientos,
            this.toolStripMenuItem1,
            this.MSILogOut,
            this.MSIsalir});
            this.incicioToolStripMenuItem.Name = "incicioToolStripMenuItem";
            this.incicioToolStripMenuItem.Size = new System.Drawing.Size(62, 40);
            this.incicioToolStripMenuItem.Text = "&Home";
            this.incicioToolStripMenuItem.Click += new System.EventHandler(this.incicioToolStripMenuItem_Click);
            // 
            // MSIseguridad
            // 
            this.MSIseguridad.Name = "MSIseguridad";
            this.MSIseguridad.ShortcutKeyDisplayString = "";
            this.MSIseguridad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.MSIseguridad.Size = new System.Drawing.Size(240, 26);
            this.MSIseguridad.Text = "&Users";
            this.MSIseguridad.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // MSIcliente
            // 
            this.MSIcliente.Name = "MSIcliente";
            this.MSIcliente.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.MSIcliente.Size = new System.Drawing.Size(240, 26);
            this.MSIcliente.Text = "&Customers";
            this.MSIcliente.Click += new System.EventHandler(this.MSIcliente_Click);
            // 
            // MSImatenimientos
            // 
            this.MSImatenimientos.Name = "MSImatenimientos";
            this.MSImatenimientos.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.MSImatenimientos.Size = new System.Drawing.Size(240, 26);
            this.MSImatenimientos.Text = "&Management";
            this.MSImatenimientos.Click += new System.EventHandler(this.mantenimientosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(237, 6);
            // 
            // MSILogOut
            // 
            this.MSILogOut.Name = "MSILogOut";
            this.MSILogOut.Size = new System.Drawing.Size(240, 26);
            this.MSILogOut.Text = "Log Out";
            this.MSILogOut.Click += new System.EventHandler(this.MSILogOut_Click);
            // 
            // MSIsalir
            // 
            this.MSIsalir.Name = "MSIsalir";
            this.MSIsalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MSIsalir.Size = new System.Drawing.Size(240, 26);
            this.MSIsalir.Text = "Exit";
            this.MSIsalir.Click += new System.EventHandler(this.MSIsalir_Click);
            // 
            // efecturarToolStripMenuItem
            // 
            this.efecturarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSIventa});
            this.efecturarToolStripMenuItem.Name = "efecturarToolStripMenuItem";
            this.efecturarToolStripMenuItem.Size = new System.Drawing.Size(132, 40);
            this.efecturarToolStripMenuItem.Text = "&Facturation";
            // 
            // MSIventa
            // 
            this.MSIventa.Name = "MSIventa";
            this.MSIventa.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.MSIventa.Size = new System.Drawing.Size(240, 26);
            this.MSIventa.Text = "&Make Sale";
            this.MSIventa.Click += new System.EventHandler(this.MSIventa_Click);
            // 
            // MSIQueries
            // 
            this.MSIQueries.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSIproducts,
            this.MSsales});
            this.MSIQueries.Name = "MSIQueries";
            this.MSIQueries.Size = new System.Drawing.Size(92, 40);
            this.MSIQueries.Text = "&Queries";
            // 
            // MSIproducts
            // 
            this.MSIproducts.Name = "MSIproducts";
            this.MSIproducts.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.MSIproducts.Size = new System.Drawing.Size(220, 26);
            this.MSIproducts.Text = "&Products";
            this.MSIproducts.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // MSsales
            // 
            this.MSsales.Name = "MSsales";
            this.MSsales.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.MSsales.Size = new System.Drawing.Size(220, 26);
            this.MSsales.Text = "&Sales";
            this.MSsales.Click += new System.EventHandler(this.MSIventas_Click);
            // 
            // MSIreportes
            // 
            this.MSIreportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeVentasPorClienteToolStripMenuItem});
            this.MSIreportes.Name = "MSIreportes";
            this.MSIreportes.Size = new System.Drawing.Size(92, 40);
            this.MSIreportes.Text = "&Reports";
            this.MSIreportes.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // reporteDeVentasPorClienteToolStripMenuItem
            // 
            this.reporteDeVentasPorClienteToolStripMenuItem.Name = "reporteDeVentasPorClienteToolStripMenuItem";
            this.reporteDeVentasPorClienteToolStripMenuItem.Size = new System.Drawing.Size(320, 26);
            this.reporteDeVentasPorClienteToolStripMenuItem.Text = "Sale Report By Customers";
            this.reporteDeVentasPorClienteToolStripMenuItem.Click += new System.EventHandler(this.reporteDeVentasPorClienteToolStripMenuItem_Click);
            // 
            // MSIayuda
            // 
            this.MSIayuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.MSIayuda.Name = "MSIayuda";
            this.MSIayuda.Size = new System.Drawing.Size(92, 40);
            this.MSIayuda.Text = "&Support";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.acercaDeToolStripMenuItem.Text = "About";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // machineLearningToolStripMenuItem
            // 
            this.machineLearningToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresionLinearToolStripMenuItem});
            this.machineLearningToolStripMenuItem.Name = "machineLearningToolStripMenuItem";
            this.machineLearningToolStripMenuItem.Size = new System.Drawing.Size(32, 40);
            this.machineLearningToolStripMenuItem.Text = " ";
            this.machineLearningToolStripMenuItem.Click += new System.EventHandler(this.MachineLearningToolStripMenuItem_Click);
            // 
            // regresionLinearToolStripMenuItem
            // 
            this.regresionLinearToolStripMenuItem.Name = "regresionLinearToolStripMenuItem";
            this.regresionLinearToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.regresionLinearToolStripMenuItem.Text = "Regresion Linear";
            this.regresionLinearToolStripMenuItem.Click += new System.EventHandler(this.RegresionLinearToolStripMenuItem_Click);
            // 
            // LBLusuario
            // 
            this.LBLusuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LBLusuario.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLusuario.Location = new System.Drawing.Point(0, 696);
            this.LBLusuario.Name = "LBLusuario";
            this.LBLusuario.Size = new System.Drawing.Size(1232, 29);
            this.LBLusuario.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblclientes);
            this.groupBox1.Controls.Add(this.lblproductos);
            this.groupBox1.Controls.Add(this.lblVentas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(4, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 156);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lblclientes
            // 
            this.lblclientes.AutoSize = true;
            this.lblclientes.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclientes.Location = new System.Drawing.Point(567, 71);
            this.lblclientes.Name = "lblclientes";
            this.lblclientes.Size = new System.Drawing.Size(36, 40);
            this.lblclientes.TabIndex = 5;
            this.lblclientes.Text = "0";
            // 
            // lblproductos
            // 
            this.lblproductos.AutoSize = true;
            this.lblproductos.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductos.Location = new System.Drawing.Point(328, 71);
            this.lblproductos.Name = "lblproductos";
            this.lblproductos.Size = new System.Drawing.Size(36, 40);
            this.lblproductos.TabIndex = 4;
            this.lblproductos.Text = "0";
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.Location = new System.Drawing.Point(67, 71);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(36, 40);
            this.lblVentas.TabIndex = 3;
            this.lblVentas.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(508, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 40);
            this.label4.TabIndex = 2;
            this.label4.Text = "Customers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 40);
            this.label3.TabIndex = 1;
            this.label3.Text = "Products";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sales";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelControllers
            // 
            this.panelControllers.Controls.Add(this.btnSales);
            this.panelControllers.Controls.Add(this.btnProducts);
            this.panelControllers.Controls.Add(this.btnCustomers);
            this.panelControllers.Controls.Add(this.btnUsers);
            this.panelControllers.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelControllers.Location = new System.Drawing.Point(4, 47);
            this.panelControllers.Name = "panelControllers";
            this.panelControllers.Size = new System.Drawing.Size(886, 185);
            this.panelControllers.TabIndex = 5;
            // 
            // btnSales
            // 
            this.btnSales.Image = global::CapaPresentacion.Properties.Resources.sales;
            this.btnSales.Location = new System.Drawing.Point(406, 3);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(126, 108);
            this.btnSales.TabIndex = 3;
            this.btnSales.Text = "Sales";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Image = global::CapaPresentacion.Properties.Resources.box;
            this.btnProducts.Location = new System.Drawing.Point(274, 3);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(126, 108);
            this.btnProducts.TabIndex = 2;
            this.btnProducts.Text = "Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Image = global::CapaPresentacion.Properties.Resources.rating;
            this.btnCustomers.Location = new System.Drawing.Point(141, 3);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(126, 108);
            this.btnCustomers.TabIndex = 1;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Image = global::CapaPresentacion.Properties.Resources.User_64;
            this.btnUsers.Location = new System.Drawing.Point(9, 3);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(126, 108);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1232, 725);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelControllers);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LBLusuario);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1248, 764);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturation System 1.0 release";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelControllers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem incicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MSIseguridad;
        private System.Windows.Forms.ToolStripMenuItem MSIcliente;
        private System.Windows.Forms.ToolStripMenuItem MSImatenimientos;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MSIsalir;
        private System.Windows.Forms.ToolStripMenuItem efecturarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MSIQueries;
        private System.Windows.Forms.ToolStripMenuItem MSIproducts;
        private System.Windows.Forms.ToolStripMenuItem MSsales;
        private System.Windows.Forms.ToolStripMenuItem MSIreportes;
        private System.Windows.Forms.ToolStripMenuItem MSIayuda;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MSIventa;
        private System.Windows.Forms.Label LBLusuario;
        private System.Windows.Forms.ToolStripMenuItem machineLearningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regresionLinearToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblclientes;
        private System.Windows.Forms.Label lblproductos;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentasPorClienteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panelControllers;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.ToolStripMenuItem MSILogOut;
    }
}