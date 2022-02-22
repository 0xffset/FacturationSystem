using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmCustomer : Form
    {
        int IdUsuario = 0;
        public frmCustomer(int? Id_Usuario)
        {
            InitializeComponent();
            this.IdUsuario = (int)Id_Usuario;
        }
        private void controlb(Boolean nuevo, Boolean editar, Boolean eliminar, Boolean salir, Boolean vender)
        {
            try
            {
                BTNnuevo.Enabled = nuevo;
                BTNeditar.Enabled = editar;
                BTneliminar.Enabled = eliminar;
                BTNsalir.Enabled = salir;
                btnSell.Enabled = vender;
            }
            catch (Exception)
            { throw; }
        }

        private void creargrid()
        {
            try
            {
                dgvcustomer.Columns.Add("ColumnId", "Id");
                dgvcustomer.Columns.Add("ColumnNro", "#");
                dgvcustomer.Columns.Add("ColumnNombre", "Name");
                dgvcustomer.Columns.Add("ColumnTipoDoc", "Type Doc.");
                dgvcustomer.Columns.Add("ColumnNroDoc", "Identif. Card");
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

        private void llenargrid()
        {
            try
            {
                int num = 0;
                dgvcustomer.Rows.Clear();
                dgvcustomer.Rows.Clear();
                List<entCustomer> Lista = IBusinessCustomer.Instancia.listCustomers();
                for (int i = 0; i < Lista.Count; i++)
                {
                    num++;
                    String[] fila = new string[] {Lista[i].Customer_Id.ToString(), num.ToString(), Lista[i].Customer_Name,
                    Lista[i].tipodocumento.Nombre_TipDoc, Lista[i].CustomerDoc_Number, Lista[i].Customer_Phone, Lista[i].Customer_Cellphone,
                    Lista[i].Customer_Email, Lista[i].Customer_Address};
                    dgvcustomer.Rows.Add(fila);
                }
            }
            catch (ApplicationException ae) { MessageBox.Show(ae.Message, "Algo ocurre", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            catch (Exception) { throw; }

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            try
            {
                creargrid();
                controlb(true, false, false, true, false);
                txtNameSearch.Enabled = false;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void BTNnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmCliente_modificar frmx = new frmCliente_modificar(IdUsuario, 0);
                frmx.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvcliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                controlb(true, true, true, true, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
                frmCliente_modificar frm = new frmCliente_modificar(IdUsuario, id_cliente);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                entCustomer cliente = new entCustomer();
                entTipoDocumento td = new entTipoDocumento();
                cliente.Customer_Id = Convert.ToInt32(dgvcustomer.CurrentRow.Cells[0].Value);
                cliente.tipodocumento = td;
                DialogResult i = MessageBox.Show("¿Desea elimnar el registro seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(i == DialogResult.Yes) {
                    int resultado = IBusinessCustomer.Instancia.CustomersManagement(cliente, 3);
                    MessageBox.Show("El registro fue elimnado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    llenargrid();
                }

            }
            catch (ApplicationException ea)
            { MessageBox.Show(ea.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                entCustomer c = new entCustomer();
                String Nro_doc = txtindetifCard.Text;
                c = IBusinessCustomer.Instancia.searchCustomer(0, Nro_doc);
                dgvcustomer.Rows.Clear();
                String[] fila = new String[] {c.Customer_Id.ToString(),1.ToString(), c.Customer_Name,
                c.tipodocumento.Nombre_TipDoc, c.CustomerDoc_Number, c.Customer_Phone, c.Customer_Cellphone,
                c.Customer_Email, c.Customer_Address};
                dgvcustomer.Rows.Add(fila);

            }
            catch (ApplicationException ea)
            {
                MessageBox.Show(ea.Message, "Informacion", MessageBoxButtons.OK,
                MessageBoxIcon.Information); dgvcustomer.Rows.Clear(); controlb(true, false, false, true, false);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void txtnombre_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                dgvcustomer.Rows.Clear();
                int numero = 0;
                String Nom_cli = txtNameSearch.Text;
                List<entCustomer> Lista = IBusinessCustomer.Instancia.AdvancedSearchCustomer(Nom_cli);
                for (int i = 0; i < Lista.Count; i++)
                {
                    numero++;
                    String[] row = new String[] {Lista[i].Customer_Id.ToString(), numero.ToString(), Lista[i].Customer_Name,
                    Lista[i].tipodocumento.Nombre_TipDoc, Lista[i].CustomerDoc_Number, Lista[i].Customer_Phone, Lista[i].Customer_Cellphone,
                    Lista[i].Customer_Email, Lista[i].Customer_Address};
                    dgvcustomer.Rows.Add(row);
                } controlb(true, false, false, true, false);
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

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Desea cerrar la ventana actual?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void BTNvender_Click(object sender, EventArgs e)
        {
            try 

            {
                int id_cli = Convert.ToInt32(dgvcustomer.CurrentRow.Cells[0].Value);
                localdatabase.Instancia.returnidcliente(1, id_cli);
                int frminvocador = localdatabase.Instancia.invocar(0, 0);
                if(frminvocador == 1)
                {
                    localdatabase.Instancia.returnidcliente(1, id_cli);
                }
                else if (frminvocador == 2)
                {
                    localdatabase.Instancia.returnidclientenv(1, id_cli);
                }
                else
                {
                    localdatabase.Instancia.invocar(1, 0);
                }
                this.Close();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                if (dgvcustomer.Rows.Count > 0)
                {
                    int idcli = Convert.ToInt32(dgvcustomer.CurrentRow.Cells[0].Value);
                    llenargrid();
                    foreach (DataGridViewRow fila in dgvcustomer.Rows)
                    {
                        if (Convert.ToInt32(fila.Cells[0].Value) == idcli)
                        {
                            fila.Selected = true;
                            return;
                        }
                    }
                }
                else llenargrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cBoxocultar_CheckedChanged(object sender, EventArgs e)
        {
            controlb(true, false, false, true, false);
            if (cBoxocultar.CheckState == CheckState.Checked)
            {
                txtindetifCard.Enabled = false; btnSearch.Enabled = false;
                txtNameSearch.Enabled = true; 
            }
            else { txtNameSearch.Enabled = true; btnSearch.Enabled = true; txtNameSearch.Enabled = false; }
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}  
        


        
  