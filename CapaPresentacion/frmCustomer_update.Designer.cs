namespace CapaPresentacion
{
    partial class frmCustomer_update
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
            this.Cédula = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtNoDoc = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dtpBorn = new System.Windows.Forms.DateTimePicker();
            this.cBoxM = new System.Windows.Forms.CheckBox();
            this.cBoxF = new System.Windows.Forms.CheckBox();
            this.txtCellphone = new System.Windows.Forms.MaskedTextBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtidCustomer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-4, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "UPDATE CUSTOMER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cédula
            // 
            this.Cédula.AutoSize = true;
            this.Cédula.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.Cédula.Location = new System.Drawing.Point(14, 61);
            this.Cédula.Name = "Cédula";
            this.Cédula.Size = new System.Drawing.Size(100, 22);
            this.Cédula.TabIndex = 3;
            this.Cédula.Text = "No. Doc.:";
            this.Cédula.Click += new System.EventHandler(this.Cédula_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(14, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(4, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cellphone:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(14, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(12, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(4, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 22);
            this.label8.TabIndex = 10;
            this.label8.Text = "Born. Date.:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(14, 332);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(80, 22);
            this.label9.TabIndex = 11;
            this.label9.Text = "Gender:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(95, 395);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 30);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnGuardaa_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(203, 395);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 30);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // txtNoDoc
            // 
            this.txtNoDoc.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtNoDoc.Location = new System.Drawing.Point(140, 57);
            this.txtNoDoc.Name = "txtNoDoc";
            this.txtNoDoc.Size = new System.Drawing.Size(214, 26);
            this.txtNoDoc.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtName.Location = new System.Drawing.Point(140, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(214, 26);
            this.txtName.TabIndex = 15;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtEmail.Location = new System.Drawing.Point(140, 185);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 26);
            this.txtEmail.TabIndex = 18;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtAddress.Location = new System.Drawing.Point(140, 217);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(214, 77);
            this.txtAddress.TabIndex = 19;
            // 
            // dtpBorn
            // 
            this.dtpBorn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.dtpBorn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBorn.Location = new System.Drawing.Point(140, 299);
            this.dtpBorn.Name = "dtpBorn";
            this.dtpBorn.Size = new System.Drawing.Size(200, 21);
            this.dtpBorn.TabIndex = 20;
            this.dtpBorn.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cBoxM
            // 
            this.cBoxM.AutoSize = true;
            this.cBoxM.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.cBoxM.Location = new System.Drawing.Point(120, 333);
            this.cBoxM.Name = "cBoxM";
            this.cBoxM.Size = new System.Drawing.Size(64, 23);
            this.cBoxM.TabIndex = 21;
            this.cBoxM.Text = "Male";
            this.cBoxM.UseVisualStyleBackColor = true;
            this.cBoxM.CheckedChanged += new System.EventHandler(this.cBoxM_CheckedChanged);
            // 
            // cBoxF
            // 
            this.cBoxF.AutoSize = true;
            this.cBoxF.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.cBoxF.Location = new System.Drawing.Point(203, 333);
            this.cBoxF.Name = "cBoxF";
            this.cBoxF.Size = new System.Drawing.Size(82, 23);
            this.cBoxF.TabIndex = 22;
            this.cBoxF.Text = "Famale";
            this.cBoxF.UseVisualStyleBackColor = true;
            this.cBoxF.CheckedChanged += new System.EventHandler(this.cBoxF_CheckedChanged);
            // 
            // txtCellphone
            // 
            this.txtCellphone.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.txtCellphone.Location = new System.Drawing.Point(140, 152);
            this.txtCellphone.Mask = "(999) 000-0000";
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(214, 26);
            this.txtCellphone.TabIndex = 23;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.txtPhone.Location = new System.Drawing.Point(140, 120);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(214, 26);
            this.txtPhone.TabIndex = 24;
            // 
            // txtidCustomer
            // 
            this.txtidCustomer.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.txtidCustomer.Location = new System.Drawing.Point(360, 57);
            this.txtidCustomer.Name = "txtidCustomer";
            this.txtidCustomer.Size = new System.Drawing.Size(22, 26);
            this.txtidCustomer.TabIndex = 25;
            // 
            // frmCustomer_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(404, 455);
            this.Controls.Add(this.txtidCustomer);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCellphone);
            this.Controls.Add(this.cBoxF);
            this.Controls.Add(this.cBoxM);
            this.Controls.Add(this.dtpBorn);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNoDoc);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cédula);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold);
            this.Name = "frmCustomer_update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Update Customer :.";
            this.Load += new System.EventHandler(this.frmCliente_modificar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Cédula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtNoDoc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dtpBorn;
        private System.Windows.Forms.CheckBox cBoxM;
        private System.Windows.Forms.CheckBox cBoxF;
        private System.Windows.Forms.MaskedTextBox txtCellphone;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.TextBox txtidCustomer;
    }
}