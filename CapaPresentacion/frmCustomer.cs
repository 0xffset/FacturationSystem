namespace CapaPresentacion
{
    using CapaNegocio;
    using Entidades;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="frmCustomer" />.
    /// </summary>
    public partial class frmCustomer : Form
    {
        /// <summary>
        /// Defines the IdUsuario.
        /// </summary>
        internal int _idUser = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="frmCustomer"/> class.
        /// </summary>
        /// <param name="Id_User">The Id_Usuario<see cref="int?"/>.</param>
        public frmCustomer(int? Id_User)
        {
            InitializeComponent();
            this._idUser = (int)Id_User;
        }

        /// <summary>
        /// The controlb.
        /// </summary>
        /// <param name="new">The nuevo<see cref="Boolean"/>.</param>
        /// <param name="edit">The editar<see cref="Boolean"/>.</param>
        /// <param name="delete">The eliminar<see cref="Boolean"/>.</param>
        /// <param name="exit">The salir<see cref="Boolean"/>.</param>
        /// <param name="sell">The vender<see cref="Boolean"/>.</param>
        private void statusControllers(Boolean @new, Boolean edit, Boolean delete, Boolean exit, Boolean sell)
        {
            try
            {
                BTNNew.Enabled = @new;
                BTNEdit.Enabled = edit;
                BTNDelete.Enabled = delete;
                BTnExit.Enabled = exit;
                BTNSell.Enabled = sell;
            }
            catch (Exception)
            { throw; }
        }

        /// <summary>
        /// The creargrid.
        /// </summary>
        private void BuildDataGridViewCustomers()
        {
            try
            {
                dgvcustomer.Columns.Add("ColumnId", "Id");
                dgvcustomer.Columns.Add("ColumnNro", "#");
                dgvcustomer.Columns.Add("ColumnNombre", "Name");
                dgvcustomer.Columns.Add("ColumnTipoDoc", "Type Doc.");
                dgvcustomer.Columns.Add("ColumnNroDoc", "DNI");
                dgvcustomer.Columns.Add("ColumnTelefono", "Phone");
                dgvcustomer.Columns.Add("ColumnCelular", "Cell phone");
                dgvcustomer.Columns.Add("ColumnCorreo", "Email");
                dgvcustomer.Columns.Add("ColumnDiereccion", "Address");

                dgvcustomer.Columns[0].Visible = false;
                dgvcustomer.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvcustomer.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvcustomer.Columns[3].Visible = false;
                dgvcustomer.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvcustomer.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvcustomer.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvcustomer.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvcustomer.Columns[8].Width = 250;

                DataGridViewCellStyle css = new DataGridViewCellStyle();
                css.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvcustomer.Font = new Font("Consolas", 12, FontStyle.Bold);
                dgvcustomer.ColumnHeadersDefaultCellStyle = css;

                dgvcustomer.AllowUserToAddRows = false;
                dgvcustomer.MultiSelect = false;
                dgvcustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
            catch (Exception)
            { throw; }
        }

        /// <summary>
        /// The llenargrid.
        /// </summary>
        private void FillDataGridViewCustomers()
        {
            try
            {
                int num = 0;
                dgvcustomer.Rows.Clear();
                dgvcustomer.Rows.Clear();
                List<entCustomer> Lista = IBusinessCustomer.Instance.ListCustomer();
                for (int i = 0; i < Lista.Count; i++)
                {
                    num++;
                    String[] fila = new string[] {Lista[i].Customer_Id.ToString(), num.ToString(), Lista[i].Customer_Name,
                    Lista[i].tipodocumento.Nombre_TipDoc, Lista[i].CustomerDoc_Number, Lista[i].Customer_Phone, Lista[i].Customer_Cellphone,
                    Lista[i].Customer_Email, Lista[i].Customer_Address};
                    dgvcustomer.Rows.Add(fila);
                }
            }
            catch (ApplicationException ae) { MessageBox.Show(ae.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The frmCliente_Load.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void frmCliente_Load(object sender, EventArgs e)
        {
            try
            {
                BuildDataGridViewCustomers();
                statusControllers(true, false, false, true, false);
                txtNameSearch.Enabled = false;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
                frmCustomer_update frmx = new frmCustomer_update(_idUser, 0);
                frmx.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The dgvcliente_CellClick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="DataGridViewCellEventArgs"/>.</param>
        private void dgvcliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                statusControllers(true, true, true, true, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                int id_cliente = Convert.ToInt32(dgvcustomer.CurrentRow.Cells[0].Value);
                if (id_cliente.ToString() == "" || id_cliente.ToString() == null)
                {
                    MessageBox.Show("Tiene que selecionar un cliente", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                frmCustomer_update frm = new frmCustomer_update(_idUser, id_cliente);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The BTneliminar_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                entCustomer cliente = new entCustomer();
                entTipoDocumento td = new entTipoDocumento();
                cliente.Customer_Id = Convert.ToInt32(dgvcustomer.CurrentRow.Cells[0].Value);
                cliente.tipodocumento = td;
                DialogResult i = MessageBox.Show("Do you want to delete the selected record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (i == DialogResult.Yes)
                {
                    int resultado = IBusinessCustomer.Instance.CustomersManagement(cliente, 3);
                    MessageBox.Show("The record was deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillDataGridViewCustomers();
                }

            }
            catch (ApplicationException ea)
            { MessageBox.Show(ea.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /// <summary>
        /// The btnBuscar_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                entCustomer c = new entCustomer();
                String Nro_doc = txtindetifCard.Text;
                c = IBusinessCustomer.Instance.SearchCustomer(0, Nro_doc);
                dgvcustomer.Rows.Clear();
                String[] fila = new String[] {c.Customer_Id.ToString(),1.ToString(), c.Customer_Name,
                c.tipodocumento.Nombre_TipDoc, c.CustomerDoc_Number, c.Customer_Phone, c.Customer_Cellphone,
                c.Customer_Email, c.Customer_Address};
                dgvcustomer.Rows.Add(fila);

            }
            catch (ApplicationException ea)
            {
                MessageBox.Show(ea.Message, "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information); dgvcustomer.Rows.Clear(); statusControllers(true, false, false, true, false);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The txtnombre_KeyUp.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="KeyEventArgs"/>.</param>
        private void txtnombre_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                dgvcustomer.Rows.Clear();
                int numero = 0;
                String Nom_cli = txtNameSearch.Text;
                List<entCustomer> Lista = IBusinessCustomer.Instance.AdvancedSearchCustomer(Nom_cli);
                for (int i = 0; i < Lista.Count; i++)
                {
                    numero++;
                    String[] row = new String[] {Lista[i].Customer_Id.ToString(), numero.ToString(), Lista[i].Customer_Name,
                    Lista[i].tipodocumento.Nombre_TipDoc, Lista[i].CustomerDoc_Number, Lista[i].Customer_Phone, Lista[i].Customer_Cellphone,
                    Lista[i].Customer_Email, Lista[i].Customer_Address};
                    dgvcustomer.Rows.Add(row);
                }
                statusControllers(true, false, false, true, false);
            }
            catch (ApplicationException ea)
            {
                MessageBox.Show(ea.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The BTNsalir_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNsalir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Desea cerrar la ventana actual?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        /// <summary>
        /// The BTNvender_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNvender_Click(object sender, EventArgs e)
        {
            try

            {
                int id_cli = Convert.ToInt32(dgvcustomer.CurrentRow.Cells[0].Value);
                localdatabase.Instance.ReturnIdCustomer(1, id_cli);
                int frminvocador = localdatabase.Instance.Invoke(0, 0);
                if (frminvocador == 1)
                {
                    localdatabase.Instance.ReturnIdCustomer(1, id_cli);
                }
                else if (frminvocador == 2)
                {
                    localdatabase.Instance.ReturnIdCustomerEnv(1, id_cli);
                }
                else
                {
                    localdatabase.Instance.Invoke(1, 0);
                }
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                if (dgvcustomer.Rows.Count > 0)
                {
                    int idcli = Convert.ToInt32(dgvcustomer.CurrentRow.Cells[0].Value);
                    FillDataGridViewCustomers();
                    foreach (DataGridViewRow fila in dgvcustomer.Rows)
                    {
                        if (Convert.ToInt32(fila.Cells[0].Value) == idcli)
                        {
                            fila.Selected = true;
                            return;
                        }
                    }
                }
                else FillDataGridViewCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The cBoxocultar_CheckedChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void cBoxocultar_CheckedChanged(object sender, EventArgs e)
        {
            statusControllers(true, false, false, true, false);
            if (cBoxocultar.CheckState == CheckState.Checked)
            {
                txtindetifCard.Enabled = false; btnSearch.Enabled = false;
                txtNameSearch.Enabled = true;
            }
            else { txtNameSearch.Enabled = true; btnSearch.Enabled = true; txtNameSearch.Enabled = false; }
        }

        /// <summary>
        /// The txtnombre_TextChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
