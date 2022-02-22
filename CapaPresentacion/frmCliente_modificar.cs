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
    public partial class frmCliente_modificar : Form
    {
        int IdUsuario = 0, IdCliente = 0;

        public frmCliente_modificar(int?  id_Usuario, int? id_Cliente)
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
                 txtCedula.Text = cliente.CustomerDoc_Number;
                 txtNombre.Text = cliente.Customer_Name;
                 txtTelefono.Text = cliente.Customer_Phone;
                 txtCelular.Text = cliente.Customer_Cellphone;
                 txtCorreo.Text = cliente.Customer_Email;
                 txtDireccion.Text = cliente.Customer_Address;
                 dateTimePicker1.Value = Convert.ToDateTime(cliente.CustomeDate_Born);
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
            
      
                
            txtIdCliente.Text = IdCliente.ToString();
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
                if(txtIdCliente.Text != "0") {tipoedicion=2; cliente.Customer_Id = Convert.ToInt32(txtIdCliente.Text);}
                td.Id_TipDoc = 1;
                cliente.tipodocumento = td;
                cliente.CustomerDoc_Number = txtCedula.Text;
                cliente.Customer_Name = txtNombre.Text;
                cliente.CustomeDate_Born=dateTimePicker1.Value.ToString("yyy/MM/dd");
                if(cBoxM.Checked == true) cliente.Customer_Sex = "M"; else cliente.Customer_Sex = "F";
                cliente.Customer_Phone = txtTelefono.Text;
                cliente.Customer_Cellphone=txtCedula.Text;
                cliente.Customer_Email = txtCorreo.Text;
                cliente.Customer_Address = txtDireccion.Text;
                cliente.CustomerCreated_User = IdUsuario;
                cliente.CustomerUpdated_User = IdUsuario;
                int r = IBusinessCustomer.Instancia.CustomersManagement(cliente, tipoedicion);
                MessageBox.Show("Cliente registrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();


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

        private void cBoxF_CheckedChanged(object sender, EventArgs e)
        {


            
        }
    }
}
