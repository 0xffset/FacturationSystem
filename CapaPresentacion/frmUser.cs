namespace CapaPresentacion
{
    using CapaNegocio;
    using Entidades;
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="frmUser" />.
    /// </summary>
    public partial class frmUser : Form
    {
        //Accinones que controlaran todos acciones en algunos controles
        /// <summary>
        /// Defines the acc.
        /// </summary>
        internal controlsStates acc = new controlsStates();

        /// <summary>
        /// Defines the Id_Usuario.
        /// </summary>
        internal int Id_Usuario;

        /// <summary>
        /// Initializes a new instance of the <see cref="frmUser"/> class.
        /// </summary>
        /// <param name="idusuario">The idusuario<see cref="int?"/>.</param>
        public frmUser(int? idusuario)
        {
            Id_Usuario = (int)idusuario;
            InitializeComponent();
        }

        /// <summary>
        /// The statusControls.
        /// </summary>
        /// <param name="nuevo">The nuevo<see cref="Boolean"/>.</param>
        /// <param name="editar">The editar<see cref="Boolean"/>.</param>
        /// <param name="eliminar">The eliminar<see cref="Boolean"/>.</param>
        /// <param name="grabar">The grabar<see cref="Boolean"/>.</param>
        /// <param name="cancelar">The cancelar<see cref="Boolean"/>.</param>
        /// <param name="salir">The salir<see cref="Boolean"/>.</param>
        public void statusControls(Boolean nuevo, Boolean editar, Boolean eliminar, Boolean grabar, Boolean cancelar, Boolean salir)
        {
            try
            {
                BTNnuevo.Enabled = nuevo;
                BTNeditar.Enabled = editar;
                BTneliminar.Enabled = grabar;
                BTNcancelar.Enabled = cancelar;
                BTNsalir.Enabled = salir;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The frmUsuario_Load.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                String[] arrybuscar = new String[] { "<< Seleccionar >>", "Codigo", "Login" };
                CBObuscar.Items.AddRange(arrybuscar);
                CBObuscar.SelectedIndex = 0;


                CBOnivelacceso.ValueMember = "Id_NivelAcc";
                CBOnivelacceso.DisplayMember = "Numero_NivelAcc";
                CBOnivelacceso.DataSource = IBusinessUser.Instance.ListarNivelAcceso();

                statusControls(true, false, false, false, false, true);
                acc.BlockTextBox(this.panel1, false);

                TXTDESC.ScrollBars = ScrollBars.Vertical;
                TXTDESC.AcceptsReturn = true;
                TXTDESC.AcceptsTab = true;
                TXTDESC.WordWrap = true;

                txtpass.UseSystemPasswordChar = true;


            }
            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The CBOnivelacceso_SelectedIndexChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void CBOnivelacceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Int32 i = Convert.ToInt32(CBOnivelacceso.SelectedValue.ToString());
                entAccessLevel na = null;
                na = IBusinessUser.Instance.ListAccessLevel(i);
                TXTDESC.Text = na.Descripcion_NivelAcc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The BTNnuevo_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                TXTidusuario.Enabled = false;
                TXTcodusuario.Enabled = false;
                acc.clearTextBox(this.panel1);
                acc.BlockTextBox(this.panel1, true);
                statusControls(false, false, true, false, true, false);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /// <summary>
        /// The BTNeditar_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNeditar_Click(object sender, EventArgs e)
        {
            try
            {
                statusControls(false, false, true, false, true, false);
                acc.BlockTextBox(this.panel1, true);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /// <summary>
        /// The BTNgrabar_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNgrabar_Click(object sender, EventArgs e)
        {
            try
            {
                int tipoedicion = 1;
                entUser u = new entUser();

                entAccessLevel na = new entAccessLevel();
                na.Id_NivelAcc = Convert.ToInt32(CBOnivelacceso.SelectedValue);
                u.access_level = na;
                u.User_Name = TXTnombre.Text;
                u.User_Login = TXTlogin.Text;

                u.User_Password = txtpass.Text;
                u.User_Phone = TXTtelefono.Text;
                u.User_Cellphone = TXTCelular.Text;
                u.User_Email = TXTcorreo.Text;
                if (RBactivo.Checked == true) u.User_State = true;
                u.User_Expiration = DTPexpiracion.Value.ToString("yyyy/MM/dd");
                u.UserCreated_User = Id_Usuario;

                if (TXTidusuario.Text != "") { tipoedicion = 2; u.User_Id = Convert.ToInt32(TXTidusuario.Text); }
                int i = IBusinessUser.Instance.UserManagement(u, tipoedicion);
                MessageBox.Show("The record was saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                statusControls(true, false, false, false, false, true);
                acc.BlockTextBox(this.panel1, false);

            }

            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
                String por = CBObuscar.SelectedItem.ToString();
                String valor = TXTSearch.Text;
                entUser u = null;
                u = IBusinessUser.Instance.SearchUserByValue(por, valor);
                TXTidusuario.Text = u.User_Id.ToString();
                TXTcodusuario.Text = u.User_Code;
                TXTnombre.Text = u.User_Name;
                TXTlogin.Text = u.User_Login;
                txtpass.Text = u.User_Password;
                TXTtelefono.Text = u.User_Phone;
                TXTCelular.Text = u.User_Cellphone;
                TXTcorreo.Text = u.User_Email;
                DTPexpiracion.Text = u.User_Expiration;
                if (u.User_State == true) RBactivo.Checked = true;
                else RBInactivo.Checked = true;

                CBOnivelacceso.SelectedValue = u.access_level.Id_NivelAcc;

                statusControls(true, true, false, true, false, true);
                acc.BlockTextBox(this.panel1, false);

            }
            catch (ApplicationException ex) { MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            catch (Exception p) { MessageBox.Show(p.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /// <summary>
        /// The BTneliminar_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTneliminar_Click(object sender, EventArgs e)
        {
            if (TXTnombre.Text == "") { MessageBox.Show("You must enter a user firstly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {
                try
                {
                    entUser u = new entUser();
                    u.User_State = true;
                    if (!TXTidusuario.Equals("")) u.User_Id = Convert.ToInt32(TXTidusuario.Text);
                    entAccessLevel na = new entAccessLevel();
                    u.access_level = na;
                    DialogResult dialog = MessageBox.Show("Are you sure you want to delete this user?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        int resultado = IBusinessUser.Instance.UserManagement(u, 3);
                        MessageBox.Show("The user was deleted. Now it is inactive.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    statusControls(true, false, false, false, false, true);
                    acc.BlockTextBox(this.panel1, false);

                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        /// <summary>
        /// The BTNcancelar_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNcancelar_Click(object sender, EventArgs e)
        {
            try
            {
                statusControls(true, true, false, true, false, true);
                acc.BlockTextBox(this.panel1, false);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /// <summary>
        /// The TXTbuscar_TextChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void TXTbuscar_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The BTNsalir_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNsalir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult re = MessageBox.Show("Are you sure you want to exit?", "Exit...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    this.Close();
                }

            }
            catch (Exception)
            { throw; }
        }

        /// <summary>
        /// The label11_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void label11_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The label10_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void label10_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The RBactivo_CheckedChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void RBactivo_CheckedChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The RBInactivo_CheckedChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void RBInactivo_CheckedChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The DTPexpiracion_ValueChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void DTPexpiracion_ValueChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The TXTnombre_TextChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void TXTnombre_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The TXTnombre_KeyPress.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="KeyPressEventArgs"/>.</param>
        private void TXTnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
