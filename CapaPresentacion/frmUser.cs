using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using Entidades;

namespace CapaPresentacion
{
    public partial class frmUser : Form
    {
        //Accinones que controlaran todos acciones en algunos controles
       controlsStates acc = new controlsStates();
        int Id_Usuario;
        public frmUser(int? idusuario)
        {
           Id_Usuario = (int)idusuario;
             InitializeComponent();
        }

        public void controlb(Boolean nuevo, Boolean editar, Boolean eliminar, Boolean grabar, Boolean cancelar, Boolean salir)
        {
            try 
            {
                BTNnuevo.Enabled = nuevo;
                BTNeditar.Enabled = editar;
                BTneliminar.Enabled = grabar;
                BTNcancelar.Enabled = cancelar;
                BTNsalir.Enabled = salir;
            }
            catch (Exception) { throw;  }
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                String[] arrybuscar = new String[] { "<< Seleccionar >>", "Codigo", "Login" };
                CBObuscar.Items.AddRange(arrybuscar);
                CBObuscar.SelectedIndex = 0;
              

               CBOnivelacceso.ValueMember = "Id_NivelAcc";
                CBOnivelacceso.DisplayMember = "Numero_NivelAcc";
                CBOnivelacceso.DataSource = IBusinessUser.Instancia.ListarNivelAcceso();

                controlb(true, false, false, false, false, true);
                 acc.bloqueartxt(this.panel1, false);

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

        private void CBOnivelacceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Int32 i = Convert.ToInt32(CBOnivelacceso.SelectedValue.ToString());
                entAccessLevel na = null;
                na = IBusinessUser.Instancia.ListarNivelAcceDesc(i);
                TXTDESC.Text = na.Descripcion_NivelAcc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNnuevo_Click(object sender, EventArgs e)
        {
            try 
            {
                TXTidusuario.Enabled = false;
                TXTcodusuario.Enabled = false;
                acc.limtext(this.panel1);
                acc.bloqueartxt(this.panel1, true);
                controlb(false, false, true, false, true, false);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void BTNeditar_Click(object sender, EventArgs e)
        {
            try
            {
                controlb(false, false, true, false, true, false);
                acc.bloqueartxt(this.panel1, true);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  }
        }

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
                int i = IBusinessUser.Instancia.MatenimientoUsuario(u, tipoedicion);
                MessageBox.Show("¡El registro se a guardado correctamente!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                controlb(true, false, false, false, false, true);
                acc.bloqueartxt(this.panel1, false);
               
            }

            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String por = CBObuscar.SelectedItem.ToString();
                String valor = TXTSearch.Text;
                entUser u = null;
                u = IBusinessUser.Instancia.BuscarUsuario(por, valor);
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

                controlb(true, true, false, true, false, true);
                acc.bloqueartxt(this.panel1, false);

            }
            catch (ApplicationException ex) { MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            
            catch (Exception p) { MessageBox.Show(p.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }

        private void BTneliminar_Click(object sender, EventArgs e)
        {
            if (TXTnombre.Text == "") { MessageBox.Show("Primero debe buscar un usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {
                try
                {
                    entUser u = new entUser();
                    u.User_State = true;
                    if (!TXTidusuario.Equals("")) u.User_Id = Convert.ToInt32(TXTidusuario.Text);
                    entAccessLevel na = new entAccessLevel();
                    u.access_level = na;
                    DialogResult dialog = MessageBox.Show("¿Está seguro de que quiere elimminar el usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        int resultado = IBusinessUser.Instancia.MatenimientoUsuario(u, 3);
                        MessageBox.Show("Se elimino el correctamente. Ahora esta Inactivo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    controlb(true, false, false, false, false, true);
                    acc.bloqueartxt(this.panel1, false);

                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void BTNcancelar_Click(object sender, EventArgs e)
        {
            try 
            {
                controlb(true, true, false, true, false, true);
                acc.bloqueartxt(this.panel1, false);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void TXTbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            try 
            {
                DialogResult re = MessageBox.Show("¿Está seguro de qué quiere salir?", "Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    this.Close();
                }

            }
            catch (Exception)
            { throw;  }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void RBactivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBInactivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DTPexpiracion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TXTnombre_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TXTnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
