namespace CapaPresentacion
{
    using CapaNegocio;
    using Entidades;
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="frmCustomer_update" />.
    /// </summary>
    public partial class frmCustomer_update : Form
    {
        /// <summary>
        /// Defines the IdUsuario, IdCliente.
        /// </summary>
        internal int IdUsuario = 0, IdCliente = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="frmCustomer_update"/> class.
        /// </summary>
        /// <param name="id_Usuario">The id_Usuario<see cref="int?"/>.</param>
        /// <param name="id_Cliente">The id_Cliente<see cref="int?"/>.</param>
        public frmCustomer_update(int? id_Usuario, int? id_Cliente)
        {
            InitializeComponent();
            IdCliente = (int)id_Cliente;
            IdUsuario = (int)id_Usuario;
        }

        /// <summary>
        /// Defines the acc.
        /// </summary>
        internal controlsStates acc = new controlsStates();

        /// <summary>
        /// The buscarcliente.
        /// </summary>
        private void buscarcliente()
        {
            try
            {
                if (IdCliente != 0)
                {
                    entCustomer cliente = new entCustomer();
                    cliente = IBusinessCustomer.Instance.SearchCustomer(IdCliente, 0.ToString());
                    txtNoDoc.Text = cliente.CustomerDoc_Number;
                    txtName.Text = cliente.Customer_Name;
                    txtPhone.Text = cliente.Customer_Phone;
                    txtCellphone.Text = cliente.Customer_Cellphone;
                    txtEmail.Text = cliente.Customer_Email;
                    txtAddress.Text = cliente.Customer_Address;
                    
                }
            }
            catch (ApplicationException) { throw; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The Cédula_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void Cédula_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The label6_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void label6_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The label5_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void label5_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The label4_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void label4_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The label3_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void label3_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The label2_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void label2_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The frmCliente_modificar_Load.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void frmCliente_modificar_Load(object sender, EventArgs e)
        {
            try
            {
                acc.fillComboboxes(this);



                txtidCustomer.Text = IdCliente.ToString();
                buscarcliente();
            }
            catch (ApplicationException ea) { MessageBox.Show(ea.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /// <summary>
        /// The btnGuardaa_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnGuardaa_Click(object sender, EventArgs e)
        {
            try
            {
                entCustomer cliente = new entCustomer();
                entTipoDocumento td = new entTipoDocumento();
                int tipoedicion = 1;
                if (txtidCustomer.Text != "0") { tipoedicion = 2; cliente.Customer_Id = Convert.ToInt32(txtidCustomer.Text); }
                td.Id_TipDoc = 1;
                cliente.tipodocumento = td;
                cliente.CustomerDoc_Number = txtNoDoc.Text;
                cliente.Customer_Name = txtName.Text;
                cliente.Customer_Phone = txtPhone.Text;
                cliente.Customer_Cellphone = txtCellphone.Text;
                cliente.Customer_Email = txtEmail.Text;
                cliente.Customer_Address = txtAddress.Text;
                cliente.CustomerCreated_User = IdUsuario;
                cliente.CustomerUpdated_User = IdUsuario;
                int r = IBusinessCustomer.Instance.CustomersManagement(cliente, tipoedicion);
                MessageBox.Show("Successfully registered customer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();


            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /// <summary>
        /// The btnRegresar_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// The cBoxM_CheckedChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void cBoxM_CheckedChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The txtNombre_KeyPress.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="KeyPressEventArgs"/>.</param>
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        /// <summary>
        /// The label8_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void label8_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The dateTimePicker1_ValueChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The cBoxF_CheckedChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void cBoxF_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
