using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using Entidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
        
            try 
            {
                string user = txtUser.Text; 
                string password = txtPassword.Text;
                entUser u = null;
                u = IBusinessUser.Instancia.SystemAuthentication(user, password);
                frmPrincipal frmp = new frmPrincipal(u);
                frmp.Show();
                

            }
            catch (ApplicationException ea) {
                MessageBox.Show(ea.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception) { throw; }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else { txtPassword.UseSystemPasswordChar = true;  }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
            txtPassword.UseSystemPasswordChar = true;
           
            
        }

    }


}
