namespace CapaPresentacion
{
    using CapaNegocio;
    using Entidades;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="frmFacturation" />.
    /// </summary>
    public partial class frmFacturation : Form
    {
        /// <summary>
        /// Defines the usu.
        /// </summary>
        internal entUser usu = null;

        /// <summary>
        /// Defines the iduser.
        /// </summary>
        internal int iduser = 0;

        /// <summary>
        /// Defines the ser, corr.
        /// </summary>
        internal String ser, corr;

        /// <summary>
        /// Defines the ac.
        /// </summary>
        internal controlsStates ac = new controlsStates();

        /// <summary>
        /// Defines the serie.
        /// </summary>
        internal entSerie serie = new entSerie();

        /// <summary>
        /// Initializes a new instance of the <see cref="frmFacturation"/> class.
        /// </summary>
        /// <param name="id_user">The id_user<see cref="int"/>.</param>
        public frmFacturation(int id_user)
        {
            InitializeComponent();
            this.iduser = id_user;
        }

        /// <summary>
        /// The controbo.
        /// </summary>
        /// <param name="nuevo">The nuevo<see cref="Boolean"/>.</param>
        /// <param name="guardar">The guardar<see cref="Boolean"/>.</param>
        /// <param name="quitaritems">The quitaritems<see cref="Boolean"/>.</param>
        private void controbo(Boolean nuevo, Boolean guardar, Boolean quitaritems)
        {
            try
            {
                btnNewInvoice.Enabled = nuevo;
                btnPrintInvoice.Enabled = guardar;
                btnRemove.Enabled = quitaritems;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The BuildProductToSaleGrid.
        /// </summary>
        private void BuildProductToSaleGrid()
        {
            try
            {
                dgvInvoice.Columns.Add("ColumnIdProd", "Idprod");
                dgvInvoice.Columns.Add("ColumnNombreProd", "Product");
                dgvInvoice.Columns.Add("ColumnCantidad", "Quantity");
                dgvInvoice.Columns.Add("ColumnPrecio", "Unit Price $");
                dgvInvoice.Columns.Add("ColumnItbis", "ITBIS");
                dgvInvoice.Columns.Add("ColumnTotal", "Total");

                dgvInvoice.Columns[0].Visible = false;
                dgvInvoice.Columns[1].Width = 315;
                dgvInvoice.Columns[2].Width = 70;
                dgvInvoice.Columns[3].Width = 70;
                dgvInvoice.Columns[4].Width = 70;
                dgvInvoice.Columns[5].Width = 100;


                dgvInvoice.Columns[1].ReadOnly = true;
                dgvInvoice.Columns[2].ReadOnly = false;
                dgvInvoice.Columns[3].ReadOnly = true;
                dgvInvoice.Columns[4].ReadOnly = true;
                dgvInvoice.Columns[5].ReadOnly = true;

                dgvInvoice.Columns[5].DefaultCellStyle.BackColor = Color.GreenYellow;

                DataGridViewCellStyle css = new DataGridViewCellStyle();
                css.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvInvoice.ColumnHeadersDefaultCellStyle = css;

                dgvInvoice.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
                dgvInvoice.DefaultCellStyle.Font = new Font("Arial", 9);

                dgvInvoice.AllowUserToAddRows = false;
                dgvInvoice.MultiSelect = false;
                dgvInvoice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The CountNumberOfItems.
        /// </summary>
        private void CountNumberOfItems()
        {
            try
            {
                int num = 0;
                foreach (DataGridViewRow row in dgvInvoice.Rows)
                {
                    num++;
                }
                lblItems.Text = "No. Items: " + num;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The FillProductToSaleGrid.
        /// </summary>
        /// <param name="Lista">The Lista<see cref="List{entProduct}"/>.</param>
        private void FillProductToSaleGrid(List<entProduct> Lista)
        {
            try
            {
                double itbis_producto = 0;
                dgvInvoice.Rows.Clear();
                for (int i = 0; i < Lista.Count; i++)
                {
                    if (Lista[i].ITBIS_Prod == 18)
                    {
                        itbis_producto = 0.18 * Lista[i].Precio_Prod;
                    }
                    if (Lista[i].ITBIS_Prod == 16)
                    {
                        itbis_producto = 0.16 * Lista[i].Precio_Prod;
                    }
                    if (Lista[i].ITBIS_Prod == 0)
                    {
                        itbis_producto = 0;
                    }
                    String[] fila = new string[] {
                        Lista[i].Id_Prod.ToString(), Lista[i].Nombre_Prod, Lista[i].Cantidad_.ToString(),
                        Lista[i].Precio_Prod.ToString(), itbis_producto.ToString("0.0")
                    };
                    dgvInvoice.Rows.Add(fila);
                }
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The UpdatAmountGrid.
        /// </summary>
        private void UpdatAmountGrid()
        {
            try
            {
                double subtotal = 0.0;
                double totalItbis = 0.0;
                foreach (DataGridViewRow row in dgvInvoice.Rows)
                {
                    if (row.Cells[2].Value == null) row.Cells[2].Value = 0;
                    row.Cells[5].Value = (Convert.ToDouble((row.Cells[2].Value)) * Convert.ToDouble((row.Cells[3].Value)));

                    if (row.Cells[3].Value == null) row.Cells[3].Value = 0;
                    row.Cells[5].Value = (Convert.ToDouble((row.Cells[2].Value)) * Convert.ToDouble((row.Cells[3].Value)));
                    subtotal += Convert.ToDouble(row.Cells[5].Value);
                    totalItbis += Convert.ToDouble(row.Cells[4].Value) * Convert.ToDouble(row.Cells[2].Value);


                    lblITBIS.Text = totalItbis.ToString("0.0");
                    lblNetTotal.Text = subtotal.ToString("0.00");
                    txtTotal.Text = (subtotal + totalItbis).ToString("0.0");


                }
                if (dgvInvoice.Rows.Count == 0)
                {
                    txtTotal.Text = "0";
                    lblITBIS.Text = "0";
                    lblNetTotal.Text = "0";
                }
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The WriteNewAmountGrid.
        /// </summary>
        private void WriteNewAmountGrid()
        {
            try
            {
                int idprod = 0, cantidad_ = 0;
                foreach (DataGridViewRow row in dgvInvoice.Rows)
                {
                    if (row.Cells[2].Value == null) row.Cells[2].Value = 0;
                    if (row.Cells[3].Value == null) row.Cells[3].Value = 0;
                    idprod = Convert.ToInt32(row.Cells[0].Value); cantidad_ = Convert.ToInt32(row.Cells[2].Value);

                    if (cantidad_ > 1)
                    {
                        List<entProduct> lista = localdatabase.Instancia.returnDetventa(1, idprod, cantidad_);
                    }
                }
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The OnlyNumberOnTheCell.
        /// </summary>
        private void OnlyNumberOnTheCell()
        {
            try
            {
                int i = 0; decimal j = 0; String valor, valor01; Boolean res = false;
                foreach (DataGridViewRow row in dgvInvoice.Rows)
                {
                    if (row.Cells[2].Value == null) row.Cells[2].Value = 0;
                    valor = row.Cells[2].Value.ToString();
                    res = int.TryParse(valor, out i);
                    if (res == false)
                    {
                        MessageBox.Show("You are trying to enter an invalid value in 'Quantity'", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        row.Cells[2].Value = i;
                    }
                    if (row.Cells[3].Value == null) row.Cells[3].Value = 0;
                    valor01 = row.Cells[3].Value.ToString().Replace(".", ".");
                    if (!Decimal.TryParse(valor01, out j))
                    {
                        MessageBox.Show("Hola", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        /// <summary>
        /// The cargarseriecore.
        /// </summary>
        private void cargarseriecore()
        {
            try
            {
                serie = IBusinessSale.Instance.ListSerie(2, 1);
                ser = serie.Numero_Serie;
                lblserie.Text = serie.Numero_Serie + "-";
                lblcorre.Text = "No. " + IBusinessSale.Instance.ListCorrelative(2, serie.Numero_Serie);
                corr = IBusinessSale.Instance.ListCorrelative(2, serie.Numero_Serie);



            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The label1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void label1_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The textBox1_TextChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void textBox1_TextChanged(object sender, EventArgs e)
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
        /// The button2_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void button2_Click(object sender, EventArgs e)
        {
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
        /// The label11_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void label11_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The frmFacturacion_Load.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            try
            {

                BuildProductToSaleGrid();
                CountNumberOfItems();
                ac.fillComboboxes(this.gbCliente);
                controbo(true, false, false); btnSearchDNI.Enabled = false;
                usu = IBusinessUser.Instance.SearchUserByValue("Id", this.iduser.ToString());
                this.iduser = usu.User_Id;
                txtCodoU.Text = usu.User_Code;
                cargarseriecore();
                btnCancelInvoice.Enabled = false;
                int idclien = localdatabase.Instancia.returnidcliente(0, 0);
                if (idclien != 0) { btnSearchDNI.Enabled = false; btnSearchById.Enabled = true; }
                lblserie.Visible = false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// The label9_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void label9_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The button4_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Do you what to make a new sale?", "Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int idcli = localdatabase.Instancia.returnidcliente(1, 0);
                    localdatabase.Instancia.limpiardetalleventa();
                    List<entProduct> Lista = localdatabase.Instancia.returnDetventa(0, 0, 0);
                    FillProductToSaleGrid(Lista);
                    ac.clearTextBox(this.gbCliente);
                    CountNumberOfItems();
                    UpdatAmountGrid();
                    cargarseriecore();
                    dgvInvoice.Enabled = true;
                    controbo(true, true, false);
                    ac.BlockTextBox(this.gbCliente, true);
                    ac.BlockTextBox(this.panel1, true);

                    btnCancelInvoice.Enabled = false;
                    btnAdd.Enabled = true;
                }
                else { }
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The btnAnular_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Do you want to cancel the current sale?", "Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int result = IBusinessSale.Instance.CancelCompro(ser, corr, 2);
                    MessageBox.Show("Sale was revoke succesfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCancelInvoice.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The label8_Click_1.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void label8_Click_1(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The btnBuscarCe_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnBuscarCe_Click(object sender, EventArgs e)
        {
            try
            {
                entCustomer c = null;
                String numdoc = txtDNI.Text;
                c = IBusinessCustomer.Instance.SearchCustomer(0, numdoc);
                txtCustomerName.Text = c.Customer_Name;
                int cedula = 6;
                cedula = c.tipodocumento.Id_TipDoc;
                txtDNI.Text = c.CustomerDoc_Number.Trim();
                int i = localdatabase.Instancia.returnidcliente(1, c.Customer_Id);
            }
            catch (ApplicationException)
            {
                DialogResult r = MessageBox.Show("There are no records, do you want to perform a more advanced search?",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    localdatabase.Instancia.invocar(1, 1);
                    frmCustomer buscarcliente = new frmCustomer(iduser);
                    buscarcliente.ShowDialog();
                    btnSearchDNI.Enabled = false; btnSearchById.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The btnBuscarxId_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnBuscarxId_Click(object sender, EventArgs e)
        {
            try
            {
                entCustomer c = null;
                int idcli = localdatabase.Instancia.returnidcliente(0, 0);
                c = IBusinessCustomer.Instance.SearchCustomer(idcli, 0.ToString());
                btnSearchById.Enabled = false; btnSearchDNI.Enabled = true;
                txtCustomerName.Text = c.Customer_Name;
                int cedula = 6;
                cedula = c.tipodocumento.Id_TipDoc;
                txtDNI.Text = c.CustomerDoc_Number.Trim();
            }
            catch (ApplicationException) { btnSearchById.Enabled = false; btnSearchDNI.Enabled = true; }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /// <summary>
        /// The btnAdd_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int intento = localdatabase.Instancia.Returnintento(0, 0);
                if (intento != 0)
                {
                    List<entProduct> Lista = localdatabase.Instancia.returnDetventa(0, 0, 0);
                    intento = localdatabase.Instancia.Returnintento(1, 0);
                    FillProductToSaleGrid(Lista);
                    CountNumberOfItems();
                    UpdatAmountGrid();
                }
                else
                {
                    localdatabase.Instancia.invocar(1, 1);
                    frmSearchProduct buscarprod = new frmSearchProduct(iduser);
                    buscarprod.ShowDialog();
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /// <summary>
        /// The dgvFactura_CellClick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="DataGridViewCellEventArgs"/>.</param>
        private void dgvFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                controbo(true, true, true);
                OnlyNumberOnTheCell();
                WriteNewAmountGrid();
                UpdatAmountGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /// <summary>
        /// The btnQuitar_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Are you sure you want to remove the selection?",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int idprod = Convert.ToInt32(dgvInvoice.CurrentRow.Cells[0].Value);
                    localdatabase.Instancia.Quitaritemproducto(idprod);
                    List<entProduct> lista = localdatabase.Instancia.returnDetventa(0, 0, 0);
                    if (lista.Count == 0) controbo(true, false, false);
                    FillProductToSaleGrid(lista);
                    CountNumberOfItems();
                    UpdatAmountGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The dgvFactura_KeyUp.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="KeyEventArgs"/>.</param>
        private void dgvFactura_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                OnlyNumberOnTheCell();
                WriteNewAmountGrid();
                UpdatAmountGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The btnAtras_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to exit?", "Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                localdatabase.Instancia.limpiardetalleventa();
                localdatabase.Instancia.returnidcliente(1, 0);
                this.Dispose();
            }
        }

        /// <summary>
        /// The txtCedula_KeyUp.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="KeyEventArgs"/>.</param>
        private void txtCedula_KeyUp(object sender, KeyEventArgs e)
        {
        }

        /// <summary>
        /// The ProductReduction.
        /// </summary>
        private void ProductReduction()
        {
            foreach (DataGridViewRow Row in dgvInvoice.Rows)
            {
                entProduct prod = new entProduct();
                int i = prod.Stock_Prod;
                int a = prod.Stock_Prod = i - Convert.ToInt32(Row.Cells[2].Value);
                prod.Stock_Prod = a;

            }
        }

        /// <summary>
        /// The printInvoice.
        /// </summary>
        private void printInvoice()
        {
            try
            {
                int idLatSale = IBusinessSale.Instance.GetLastIdSale();
                frmInvoicePrint frmInvoicePrint = new frmInvoicePrint(idLatSale);
                frmInvoicePrint.ShowDialog();
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The btnGuardar_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Are you sure to save the sale?",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    OnlyNumberOnTheCell();
                    WriteNewAmountGrid();
                    UpdatAmountGrid();
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
                    v.Igv_Venta = Convert.ToDouble(lblITBIS.Text.ToString());
                    v.Descuento_Venta = 0.0;
                    List<entDetalleVenta> detalle = new List<entDetalleVenta>();
                    foreach (DataGridViewRow row in dgvInvoice.Rows)
                    {
                        entDetalleVenta dt = new entDetalleVenta();
                        dt.Id_Prod_Det = Convert.ToInt32(row.Cells[0].Value);
                        dt.PrecProd_Det = Convert.ToDouble(row.Cells[3].Value);
                        dt.Cantidad_Det = Convert.ToInt32(row.Cells[2].Value);
                        dt.Itbis_Det = Convert.ToDouble(row.Cells[4].Value) * Convert.ToInt32(row.Cells[2].Value);
                        detalle.Add(dt);
                    }
                    ProductReduction();
                    v.detalleventa = detalle;
                    v.Desc_Venta = "";
                    cargarseriecore();
                    int resuta = IBusinessSale.Instance.SaveSale(v, 2, serie.Numero_Serie);
                    MessageBox.Show("The sale has been saved successfully", "Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvInvoice.Enabled = false; controbo(true, false, false);
                    btnAdd.Enabled = false; btnCancelInvoice.Enabled = true;
                    ac.BlockTextBox(this.gbCliente, false);
                    ac.BlockTextBox(this.panel1, false);

                    printInvoice();


                }
            }
            catch (ApplicationException ea)
            {
                MessageBox.Show(ea.Message, "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
