namespace CapaPresentacion
{
    using CapaNegocio;
    using Entidades;
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="frmLogin" />.
    /// </summary>
    public partial class frmLogin : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="frmLogin"/> class.
        /// </summary>
        public frmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The button1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string user = txtUser.Text;
                string password = txtPassword.Text;
                entUser u = null;
                u = IBusinessUser.Instance.SystemAuthentication(user, password);
                frmPrincipal frmp = new frmPrincipal(u);
                frmp.Show();


            }
            catch (ApplicationException ea)
            {
                MessageBox.Show(ea.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The checkBox1_CheckedChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else { txtPassword.UseSystemPasswordChar = true; }
        }

        /// <summary>
        /// The label3_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>



        /// <summary>
        /// The btnSalir_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// The label4_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>


        /// <summary>
        /// The frmLogin_Load.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}
