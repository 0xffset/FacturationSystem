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
    public partial class frmCustomer_update : Form
    {
        int IdUsuario = 0, IdCliente = 0;

        public frmCustomer_update(int?  id_Usuario, int? id_Cliente)
        {
            InitializeComponent();
            IdCliente = (int)id_Cliente;
            IdUsuario = (int)id_Usuario;

        }
        AccEnControles acc = new AccEnControles();
        private void buscarcliente()
        {
            try 
            {
             if (IdCliente != 0)
             {
                 entCustomer cliente = new entCustomer();
                 cliente = IBusinessCustomer.Instancia.searchCustomer(IdCliente, 0.ToString());
                 txtNoDoc.Text = cliente.CustomerDoc_Number;
                 txtName.Text = cliente.Customer_Name;
                 txtPhone.Text = cliente.Customer_Phone;
                 txtCellphone.Text = cliente.Customer_Cellphone;
                 txtEmail.Text = cliente.Customer_Email;
                 txtAddress.Text = cliente.Customer_Address;
                 dtpBorn.Value = Convert.ToDateTime(cliente.CustomeDate_Born);
                 if (cliente.Customer_Sex == "M") cBoxM.Checked = true; else cBoxF.Checked = true;
             }
            }
            catch (ApplicationException) { throw; }
            catch (Exception) { throw;  }
        }
        private void Cédula_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmCliente_modificar_Load(object sender, EventArgs e)
        {
             try {
                acc.LlenarCboTipDoc(this); cBoxM.Checked = true;
            
      
                
            txtidCustomer.Text = IdCliente.ToString();
            buscarcliente();
            }
             catch (ApplicationException ea) { MessageBox.Show(ea.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void btnGuardaa_Click(object sender, EventArgs e)
        {
            try
            {
                entCustomer cliente = new entCustomer();
                entTipoDocumento td= new entTipoDocumento();
                int tipoedicion=1;
                if(txtidCustomer.Text != "0") {tipoedicion=2; cliente.Customer_Id = Convert.ToInt32(txtidCustomer.Text);}
                td.Id_TipDoc = 1;
                cliente.tipodocumento = td;
                cliente.CustomerDoc_Number = txtNoDoc.Text;
                cliente.Customer_Name = txtName.Text;
                cliente.CustomeDate_Born=dtpBorn.Value.ToString("yyy/MM/dd");
                if(cBoxM.Checked == true) cliente.Customer_Sex = "M"; else cliente.Customer_Sex = "F";
                cliente.Customer_Phone = txtPhone.Text;
                cliente.Customer_Cellphone=txtCellphone.Text;
                cliente.Customer_Email = txtEmail.Text;
                cliente.Customer_Address = txtAddress.Text;
                cliente.CustomerCreated_User = IdUsuario;
                cliente.CustomerUpdated_User = IdUsuario;
                int r = IBusinessCustomer.Instancia.CustomersManagement(cliente, tipoedicion);
                MessageBox.Show("Cliente registrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();


            }
            catch (Exception ex) {MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cBoxM_CheckedChanged(object sender, EventArgs e)
        {
          
            
           
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cBoxF_CheckedChanged(object sender, EventArgs e)
        {


            
        }
    }
}
