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
    public partial class frmFacturacion : Form
    {
        entUser usu = null;
        int iduser = 0;
        String ser, corr;
        AccEnControles ac = new AccEnControles();
        entSerie serie = new entSerie();

        public frmFacturacion(int id_user)
        {
            InitializeComponent();
            this.iduser = id_user;
        }

        private void controbo(Boolean nuevo, Boolean guardar,  Boolean quitaritems)
        {
            try
            {
                btnNuevo.Enabled = nuevo;
                btnGuardar.Enabled = guardar;
                btnQuitar.Enabled = quitaritems;
            }
            catch (Exception) {throw;}
        }

        private void creargrid()
        {
            try
            {
                dgvFactura.Columns.Add("ColumnIdProd", "Idprod");
                dgvFactura.Columns.Add("ColumnNombreProd", "Producto");
                dgvFactura.Columns.Add("ColumnCantidad", "Cantidad");
                dgvFactura.Columns.Add("ColumnPrecio", "Precio");
                dgvFactura.Columns.Add("ColumnTotal", "Total");

                dgvFactura.Columns[0].Visible = false;
                dgvFactura.Columns[1].Width = 315;
                dgvFactura.Columns[2].Width = 70;
                dgvFactura.Columns[3].Width = 70;
                dgvFactura.Columns[4].Width = 100;
             

                dgvFactura.Columns[1].ReadOnly = true;
                 dgvFactura.Columns[2].ReadOnly = false;
                 dgvFactura.Columns[3].ReadOnly = true;
                 dgvFactura.Columns[4].ReadOnly = true;

                dgvFactura.Columns[4].DefaultCellStyle.BackColor = Color.GreenYellow;

                DataGridViewCellStyle css = new DataGridViewCellStyle();
                css.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvFactura.ColumnHeadersDefaultCellStyle = css;

                dgvFactura.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
                dgvFactura.DefaultCellStyle.Font = new Font("Arial", 9);

                dgvFactura.AllowUserToAddRows = false;
                dgvFactura.MultiSelect = false;
                dgvFactura.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            }
            catch (Exception) {throw;}
        }

        private void contaritems()
        {
            try
            {
                int num = 0;
                foreach (DataGridViewRow row in dgvFactura.Rows)
                {
                    num++;
                }
                lblItems.Text  = "No. Items: " + num;
            }
            catch (Exception) {throw;}
        }

        private void cargargrid(List<entProduct> Lista)
        {
            try 
            {
                dgvFactura.Rows.Clear();
                for (int i = 0; i < Lista.Count; i++)
                {
                    String[] fila = new string[] {
                        Lista[i].Id_Prod.ToString(), Lista[i].Nombre_Prod, Lista[i].Cantidad_.ToString(),
                        Lista[i].Precio_Prod.ToString(),
                        (Lista[i].Precio_Prod * 5).ToString()
                    };
                    dgvFactura.Rows.Add(fila);
                }
            }
            catch (Exception) {throw;}
        }

        private void actualizarmontodgv()
        {
            try
            {
                double subtotal = 0.0;
                foreach (DataGridViewRow row in dgvFactura.Rows)
                {
                     if (row.Cells[2].Value == null) row.Cells[2].Value = 0;
                     row.Cells[4].Value = (Convert.ToDouble((row.Cells[2].Value)) * Convert.ToDouble((row.Cells[3].Value)));

                    if (row.Cells[3].Value == null) row.Cells[3].Value = 0;
                     row.Cells[4].Value = (Convert.ToDouble((row.Cells[2].Value)) * Convert.ToDouble((row.Cells[3].Value)));
                    subtotal += Convert.ToDouble(row.Cells[4].Value);

                    txtTotal.Text = subtotal.ToString("0.00");

                    
                }
                if(dgvFactura.Rows.Count == 0) {
                    txtTotal.Text = "0";
                }
            }
            catch (Exception) {throw;}
        }

        private void escribirnuevomonto()
        {
            try
            {
                int idprod = 0, cantidad_ = 0;
                foreach (DataGridViewRow row in dgvFactura.Rows)
                {
                    if (row.Cells[2].Value == null) row.Cells[2].Value = 0;
                    if (row.Cells[3].Value == null) row.Cells[3].Value = 0;
                    idprod = Convert.ToInt32(row.Cells[0].Value); cantidad_ = Convert.ToInt32(row.Cells[2].Value);

                    if (cantidad_ > 1)
                    {
                        List<entProduct> lista =  localdatabase.Instancia.returnDetventa(1,idprod, cantidad_);
                    }
                }
            }
            catch (Exception) {throw;}
        }

        private void solonumceldagrid()
        {
            try
            {
                int i = 0; decimal j=0; String valor, valor01; Boolean res = false;
                foreach (DataGridViewRow row in dgvFactura.Rows)
                {
                    if (row.Cells[2].Value == null) row.Cells[2].Value = 0;
                    valor = row.Cells[2].Value.ToString();
                    res = int.TryParse(valor, out i);
                    if (res == false)
                    {
                        MessageBox.Show("Esta tratando de ingresar un valor invalido ne 'Cantidad '", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        row.Cells[2].Value = i;
                    }
                    if (row.Cells[3].Value == null) row.Cells[3].Value = 0;
                    valor01 = row.Cells[3].Value.ToString().Replace(".",".");
                    if (!Decimal.TryParse(valor01, out j))
                    {
                        MessageBox.Show("Hola","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        row.Cells[3].Value = 0;
                    }
                    else 
                    {
                        row.Cells[3].Value = valor01;
                    }
                }
            }
        
            catch (Exception)
            {
                throw;  
            }
    }

        private void cargarseriecore()
        {
            try
            {
                serie = IBusinessSale.Instancia.cargarserie(2, 1);
                ser = serie.Numero_Serie;
                lblserie.Text =  serie.Numero_Serie + "-";
                lblcorre.Text = "No. " + IBusinessSale.Instancia.cargarcorrelativo(2, serie.Numero_Serie);
                corr = IBusinessSale.Instancia.cargarcorrelativo(2, serie.Numero_Serie);



            }
            catch(Exception) {throw;}
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            try
            {
                
                creargrid();
                contaritems();
                ac.LlenarCboTipDoc(this.gbCliente);
                controbo(true, false, false); btnBuscarCe.Enabled = false;
                usu = IBusinessUser.Instancia.BuscarUsuario("Id", this.iduser.ToString());
                this.iduser = usu.User_Id;
                txtCodigou.Text = usu.User_Code;
                cargarseriecore();
                btnAnular.Enabled = false;
                int idclien = localdatabase.Instancia.returnidcliente(0, 0);
                if (idclien != 0) { btnBuscarCe.Enabled = false; btnBuscarxId.Enabled = true; }
                lblserie.Visible = false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea hacer una nueva venta?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int idcli = localdatabase.Instancia.returnidcliente(1, 0);
                    localdatabase.Instancia.limpiardetalleventa();
                    List<entProduct> Lista = localdatabase.Instancia.returnDetventa(0, 0, 0);
                    cargargrid(Lista);
                    ac.limtext(this.gbCliente);
                    contaritems();
                    actualizarmontodgv();
                    cargarseriecore();
                    dgvFactura.Enabled = true;
                    controbo(true, true, false);
                    ac.bloqueartxt(this.gbCliente, true);
                    ac.bloqueartxt(this.panel1, true);
                    
                    btnAnular.Enabled = false;
                    btnAdd.Enabled = true;
                }
                else { }
            }
            catch (Exception) { throw; }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("¿Desea anular la factura?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr==DialogResult.Yes)
                {
                    int result = IBusinessSale.Instancia.anularcomprobante(ser, corr, 2);
                    MessageBox.Show("Fatura Anulada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAnular.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBuscarCe_Click(object sender, EventArgs e)
        {
            try
            {
                entCustomer c = null;
                String numdoc = txtCedula.Text;
                c = IBusinessCustomer.Instancia.searchCustomer(0, numdoc);
                txtNo.Text = c.Customer_Name;
                txtDireccion.Text = c.Customer_Address;
                int cedula = 6;
                cedula = c.tipodocumento.Id_TipDoc;
                txtCedula.Text = c.CustomerDoc_Number.Trim();
                int i = localdatabase.Instancia.returnidcliente(1, c.Customer_Id);
            }
            catch (ApplicationException)
            {
                DialogResult r = MessageBox.Show("No hay registros, ¿desea realizar una busqueda mas avanzada?",
                    "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    localdatabase.Instancia.invocar(1, 1);
                    frmCustomer buscarcliente = new frmCustomer(iduser);
                    buscarcliente.ShowDialog();
                    btnBuscarCe.Enabled = false; btnBuscarxId.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarxId_Click(object sender, EventArgs e)
        {
            try
            {
                entCustomer c = null;
                int idcli = localdatabase.Instancia.returnidcliente(0, 0);
                c = IBusinessCustomer.Instancia.searchCustomer(idcli, 0.ToString());
                btnBuscarxId.Enabled = false; btnBuscarCe.Enabled = true;
                txtNo.Text = c.Customer_Name;
                txtDireccion.Text = c.Customer_Address;
                int cedula = 6;
                cedula = c.tipodocumento.Id_TipDoc;
                txtCedula.Text = c.CustomerDoc_Number.Trim();
            }
            catch (ApplicationException) { btnBuscarxId.Enabled = false; btnBuscarCe.Enabled = true; }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int intento = localdatabase.Instancia.Returnintento(0, 0);
                if (intento != 0)
                {
                    List<entProduct> Lista = localdatabase.Instancia.returnDetventa(0, 0, 0);
                    intento = localdatabase.Instancia.Returnintento(1, 0);
                    cargargrid(Lista);
                    contaritems();
                    actualizarmontodgv();
                }
                else
                {
                    localdatabase.Instancia.invocar(1, 1);
                    frmBuscarProd buscarprod = new frmBuscarProd(iduser);
                    buscarprod.ShowDialog();
                }
               
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dgvFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                controbo(true, true, true);
                solonumceldagrid();
                escribirnuevomonto();
                actualizarmontodgv();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Esta seguro de que quiere quitar lo seleccionado?",
                    "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r== DialogResult.Yes)
                {
                    int idprod = Convert.ToInt32(dgvFactura.CurrentRow.Cells[0].Value);
                    localdatabase.Instancia.Quitaritemproducto(idprod);
                    List<entProduct> lista = localdatabase.Instancia.returnDetventa(0, 0, 0);
                    if (lista.Count == 0) controbo(true, false, false);
                    cargargrid(lista);
                    contaritems();
                    actualizarmontodgv();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFactura_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                solonumceldagrid();
                escribirnuevomonto();
                actualizarmontodgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Desea salir", "mensaje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r== DialogResult.Yes)
            {
                localdatabase.Instancia.limpiardetalleventa();
                localdatabase.Instancia.returnidcliente(1, 0);
                this.Dispose();
            }
        }

        private void txtCedula_KeyUp(object sender, KeyEventArgs e)
        {
                 
            
        }

        private void ReducirProd()
        {
           foreach (DataGridViewRow Row in dgvFactura.Rows)
           {
               entProduct prod = new entProduct();
               int i = prod.Stock_Prod;
               int a = prod.Stock_Prod = i - Convert.ToInt32(Row.Cells[2].Value) ;
               prod.Stock_Prod = a;

           }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea guardar la venta?",
                    "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r==DialogResult.Yes)
                {
                    solonumceldagrid();
                    escribirnuevomonto();
                    actualizarmontodgv();
                    entSale v = new entSale();
                    entCustomer c = new entCustomer();
                    c.Customer_Id = localdatabase.Instancia.returnidcliente(0, 0);
                    v.cliente = c;
                    entUser u = new entUser();
                    u = usu;
                    v.usuario = u;
                    entSucursal s = new entSucursal();
                    s.Id_Suc = 1;
                    v.sucursal = s;

                    entTipComprobante tc = new entTipComprobante();
                    tc.Id_TipCom = 3;
                    v.tipocomprobante = tc;

                    entMoneda m = new entMoneda();
                    m.Id_Moneda = 1;
                    v.moneda = m;
                    entTipoPago tp = new entTipoPago();
                    tp.Id_TipPago = 2;
                    v.tipopago = tp;
                    v.Igv_Venta = 0;
                    v.Descuento_Venta = 0.0;
                    List<entDetalleVenta> detalle = new List<entDetalleVenta>();
                    foreach (DataGridViewRow row in dgvFactura.Rows)
                    {
                        entDetalleVenta dt = new entDetalleVenta();
                        dt.Id_Prod_Det = Convert.ToInt32(row.Cells[0].Value);
                        dt.PrecProd_Det = Convert.ToDouble(row.Cells[3].Value);
                        dt.Cantidad_Det = Convert.ToInt32(row.Cells[2].Value);
                        detalle.Add(dt);
                    }
                    ReducirProd();
                    v.detalleventa = detalle;
                    v.Desc_Venta = "";
                    cargarseriecore();
                    int resuta = IBusinessSale.Instancia.guardarventa(v, 2, serie.Numero_Serie);
                    MessageBox.Show("Se guardo correctamente!", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvFactura.Enabled = false; controbo(true, false, false);
                    btnAdd.Enabled = false; btnAnular.Enabled = true;
                    ac.bloqueartxt(this.gbCliente, false);
                    ac.bloqueartxt(this.panel1, false);
                    

                }
            }
            catch (ApplicationException ea)
            {
                MessageBox.Show(ea.Message, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
