namespace CapaPresentacion
{
    partial class frmUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNnuevo = new System.Windows.Forms.Button();
            this.BTNsalir = new System.Windows.Forms.Button();
            this.BTNcancelar = new System.Windows.Forms.Button();
            this.BTneliminar = new System.Windows.Forms.Button();
            this.BTNgrabar = new System.Windows.Forms.Button();
            this.BTNeditar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TXTDESC = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CBOnivelacceso = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TXTCelular = new System.Windows.Forms.MaskedTextBox();
            this.TXTtelefono = new System.Windows.Forms.MaskedTextBox();
            this.DTPexpiracion = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.RBInactivo = new System.Windows.Forms.RadioButton();
            this.RBactivo = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.TXTcorreo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTlogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTidusuario = new System.Windows.Forms.TextBox();
            this.TXTcodusuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CBObuscar = new System.Windows.Forms.ComboBox();
            this.TXTSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1330, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "USERS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTNnuevo);
            this.panel1.Controls.Add(this.BTNsalir);
            this.panel1.Controls.Add(this.BTNcancelar);
            this.panel1.Controls.Add(this.BTneliminar);
            this.panel1.Controls.Add(this.BTNgrabar);
            this.panel1.Controls.Add(this.BTNeditar);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1999, 535);
            this.panel1.TabIndex = 2;
            // 
            // BTNnuevo
            // 
            this.BTNnuevo.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNnuevo.Image = global::CapaPresentacion.Properties.Resources.New_24px;
            this.BTNnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNnuevo.Location = new System.Drawing.Point(1144, 207);
            this.BTNnuevo.Name = "BTNnuevo";
            this.BTNnuevo.Size = new System.Drawing.Size(123, 45);
            this.BTNnuevo.TabIndex = 11;
            this.BTNnuevo.Text = "New";
            this.BTNnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNnuevo.UseVisualStyleBackColor = true;
            this.BTNnuevo.Click += new System.EventHandler(this.BTNnuevo_Click);
            // 
            // BTNsalir
            // 
            this.BTNsalir.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNsalir.Image = global::CapaPresentacion.Properties.Resources.Exit_24px;
            this.BTNsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNsalir.Location = new System.Drawing.Point(1144, 468);
            this.BTNsalir.Name = "BTNsalir";
            this.BTNsalir.Size = new System.Drawing.Size(123, 45);
            this.BTNsalir.TabIndex = 10;
            this.BTNsalir.Text = "Exit";
            this.BTNsalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNsalir.UseVisualStyleBackColor = true;
            this.BTNsalir.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // BTNcancelar
            // 
            this.BTNcancelar.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNcancelar.Image = global::CapaPresentacion.Properties.Resources.Cancel_24px;
            this.BTNcancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNcancelar.Location = new System.Drawing.Point(1144, 414);
            this.BTNcancelar.Name = "BTNcancelar";
            this.BTNcancelar.Size = new System.Drawing.Size(123, 45);
            this.BTNcancelar.TabIndex = 9;
            this.BTNcancelar.Text = "Cancel";
            this.BTNcancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNcancelar.UseVisualStyleBackColor = true;
            this.BTNcancelar.Click += new System.EventHandler(this.BTNcancelar_Click);
            // 
            // BTneliminar
            // 
            this.BTneliminar.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTneliminar.Image = global::CapaPresentacion.Properties.Resources.Delete_24px;
            this.BTneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTneliminar.Location = new System.Drawing.Point(1144, 363);
            this.BTneliminar.Name = "BTneliminar";
            this.BTneliminar.Size = new System.Drawing.Size(123, 45);
            this.BTneliminar.TabIndex = 8;
            this.BTneliminar.Text = "Delete";
            this.BTneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTneliminar.UseVisualStyleBackColor = true;
            this.BTneliminar.Click += new System.EventHandler(this.BTneliminar_Click);
            // 
            // BTNgrabar
            // 
            this.BTNgrabar.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNgrabar.Image = global::CapaPresentacion.Properties.Resources.Ok_24px;
            this.BTNgrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNgrabar.Location = new System.Drawing.Point(1144, 312);
            this.BTNgrabar.Name = "BTNgrabar";
            this.BTNgrabar.Size = new System.Drawing.Size(123, 45);
            this.BTNgrabar.TabIndex = 7;
            this.BTNgrabar.Text = "Save";
            this.BTNgrabar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNgrabar.UseVisualStyleBackColor = true;
            this.BTNgrabar.Click += new System.EventHandler(this.BTNgrabar_Click);
            // 
            // BTNeditar
            // 
            this.BTNeditar.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNeditar.Image = global::CapaPresentacion.Properties.Resources.Modify_24px;
            this.BTNeditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNeditar.Location = new System.Drawing.Point(1144, 258);
            this.BTNeditar.Name = "BTNeditar";
            this.BTNeditar.Size = new System.Drawing.Size(123, 45);
            this.BTNeditar.TabIndex = 6;
            this.BTNeditar.Text = "Edit";
            this.BTNeditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNeditar.UseVisualStyleBackColor = true;
            this.BTNeditar.Click += new System.EventHandler(this.BTNeditar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TXTDESC);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.CBOnivelacceso);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(722, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 172);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Access Level: ";
            // 
            // TXTDESC
            // 
            this.TXTDESC.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTDESC.Location = new System.Drawing.Point(20, 100);
            this.TXTDESC.Multiline = true;
            this.TXTDESC.Name = "TXTDESC";
            this.TXTDESC.Size = new System.Drawing.Size(284, 48);
            this.TXTDESC.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 22);
            this.label13.TabIndex = 21;
            this.label13.Text = "Description: ";
            // 
            // CBOnivelacceso
            // 
            this.CBOnivelacceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOnivelacceso.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOnivelacceso.FormattingEnabled = true;
            this.CBOnivelacceso.Location = new System.Drawing.Point(93, 31);
            this.CBOnivelacceso.Name = "CBOnivelacceso";
            this.CBOnivelacceso.Size = new System.Drawing.Size(100, 30);
            this.CBOnivelacceso.TabIndex = 20;
            this.CBOnivelacceso.SelectedIndexChanged += new System.EventHandler(this.CBOnivelacceso_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 22);
            this.label12.TabIndex = 20;
            this.label12.Text = "Level";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TXTCelular);
            this.groupBox2.Controls.Add(this.TXTtelefono);
            this.groupBox2.Controls.Add(this.DTPexpiracion);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.RBInactivo);
            this.groupBox2.Controls.Add(this.RBactivo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TXTcorreo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtpass);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TXTlogin);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TXTnombre);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TXTidusuario);
            this.groupBox2.Controls.Add(this.TXTcodusuario);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(699, 429);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User";
            // 
            // TXTCelular
            // 
            this.TXTCelular.Location = new System.Drawing.Point(145, 228);
            this.TXTCelular.Mask = "(999) 000-0000";
            this.TXTCelular.Name = "TXTCelular";
            this.TXTCelular.Size = new System.Drawing.Size(317, 32);
            this.TXTCelular.TabIndex = 21;
            // 
            // TXTtelefono
            // 
            this.TXTtelefono.Location = new System.Drawing.Point(145, 189);
            this.TXTtelefono.Mask = "(999) 000-0000";
            this.TXTtelefono.Name = "TXTtelefono";
            this.TXTtelefono.Size = new System.Drawing.Size(317, 32);
            this.TXTtelefono.TabIndex = 20;
            // 
            // DTPexpiracion
            // 
            this.DTPexpiracion.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPexpiracion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPexpiracion.Location = new System.Drawing.Point(235, 366);
            this.DTPexpiracion.Name = "DTPexpiracion";
            this.DTPexpiracion.Size = new System.Drawing.Size(146, 29);
            this.DTPexpiracion.TabIndex = 19;
            this.DTPexpiracion.ValueChanged += new System.EventHandler(this.DTPexpiracion_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 372);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 22);
            this.label11.TabIndex = 18;
            this.label11.Text = "Expiration Data:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // RBInactivo
            // 
            this.RBInactivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RBInactivo.AutoSize = true;
            this.RBInactivo.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBInactivo.Location = new System.Drawing.Point(245, 335);
            this.RBInactivo.Name = "RBInactivo";
            this.RBInactivo.Size = new System.Drawing.Size(108, 26);
            this.RBInactivo.TabIndex = 17;
            this.RBInactivo.Text = "Inactive";
            this.RBInactivo.UseVisualStyleBackColor = true;
            this.RBInactivo.CheckedChanged += new System.EventHandler(this.RBInactivo_CheckedChanged);
            // 
            // RBactivo
            // 
            this.RBactivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RBactivo.AutoSize = true;
            this.RBactivo.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBactivo.Location = new System.Drawing.Point(127, 339);
            this.RBactivo.Name = "RBactivo";
            this.RBactivo.Size = new System.Drawing.Size(88, 26);
            this.RBactivo.TabIndex = 16;
            this.RBactivo.Text = "Active";
            this.RBactivo.UseVisualStyleBackColor = true;
            this.RBactivo.CheckedChanged += new System.EventHandler(this.RBactivo_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 22);
            this.label10.TabIndex = 15;
            this.label10.Text = "State: ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // TXTcorreo
            // 
            this.TXTcorreo.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTcorreo.Location = new System.Drawing.Point(145, 265);
            this.TXTcorreo.Name = "TXTcorreo";
            this.TXTcorreo.Size = new System.Drawing.Size(527, 29);
            this.TXTcorreo.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 22);
            this.label9.TabIndex = 13;
            this.label9.Text = "Email: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-5, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 22);
            this.label8.TabIndex = 11;
            this.label8.Text = "Cellphone: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Phone:";
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(145, 151);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(317, 29);
            this.txtpass.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password: ";
            // 
            // TXTlogin
            // 
            this.TXTlogin.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTlogin.Location = new System.Drawing.Point(145, 111);
            this.TXTlogin.Name = "TXTlogin";
            this.TXTlogin.Size = new System.Drawing.Size(317, 29);
            this.TXTlogin.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Login: ";
            // 
            // TXTnombre
            // 
            this.TXTnombre.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTnombre.Location = new System.Drawing.Point(145, 74);
            this.TXTnombre.Name = "TXTnombre";
            this.TXTnombre.Size = new System.Drawing.Size(527, 29);
            this.TXTnombre.TabIndex = 4;
            this.TXTnombre.TextChanged += new System.EventHandler(this.TXTnombre_TextChanged);
            this.TXTnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTnombre_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name: ";
            // 
            // TXTidusuario
            // 
            this.TXTidusuario.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTidusuario.Location = new System.Drawing.Point(251, 36);
            this.TXTidusuario.Name = "TXTidusuario";
            this.TXTidusuario.Size = new System.Drawing.Size(211, 29);
            this.TXTidusuario.TabIndex = 2;
            // 
            // TXTcodusuario
            // 
            this.TXTcodusuario.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTcodusuario.Location = new System.Drawing.Point(141, 36);
            this.TXTcodusuario.Name = "TXTcodusuario";
            this.TXTcodusuario.Size = new System.Drawing.Size(260, 29);
            this.TXTcodusuario.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Code: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.CBObuscar);
            this.groupBox1.Controls.Add(this.TXTSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // button1
            // 
            this.button1.Image = global::CapaPresentacion.Properties.Resources.Search_24px;
            this.button1.Location = new System.Drawing.Point(647, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 35);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CBObuscar
            // 
            this.CBObuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBObuscar.FormattingEnabled = true;
            this.CBObuscar.Location = new System.Drawing.Point(336, 30);
            this.CBObuscar.Name = "CBObuscar";
            this.CBObuscar.Size = new System.Drawing.Size(302, 31);
            this.CBObuscar.TabIndex = 2;
            // 
            // TXTSearch
            // 
            this.TXTSearch.Location = new System.Drawing.Point(104, 30);
            this.TXTSearch.Name = "TXTSearch";
            this.TXTSearch.Size = new System.Drawing.Size(226, 31);
            this.TXTSearch.TabIndex = 1;
            this.TXTSearch.TextChanged += new System.EventHandler(this.TXTbuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Type: ";
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1322, 620);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: User :. ";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CBObuscar;
        private System.Windows.Forms.TextBox TXTSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNnuevo;
        private System.Windows.Forms.Button BTNsalir;
        private System.Windows.Forms.Button BTNcancelar;
        private System.Windows.Forms.Button BTneliminar;
        private System.Windows.Forms.Button BTNgrabar;
        private System.Windows.Forms.Button BTNeditar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TXTDESC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CBOnivelacceso;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker DTPexpiracion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton RBInactivo;
        private System.Windows.Forms.RadioButton RBactivo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TXTcorreo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXTlogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTidusuario;
        private System.Windows.Forms.TextBox TXTcodusuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox TXTCelular;
        private System.Windows.Forms.MaskedTextBox TXTtelefono;
    }
}