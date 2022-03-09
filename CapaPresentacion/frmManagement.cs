namespace CapaPresentacion
{
    using CapaNegocio;
    using Entidades;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="frmManagement" />.
    /// </summary>
    public partial class frmManagement : Form
    {
        /// <summary>
        /// Defines the _idUser.
        /// </summary>
        internal Int32 _idUser;

        /// <summary>
        /// Initializes a new instance of the <see cref="frmManagement"/> class.
        /// </summary>
        /// <param name="id_usu">The id_usu<see cref="Int32?"/>.</param>
        public frmManagement(Int32? id_usu)
        {
            InitializeComponent();
            _idUser = (Int32)id_usu;
        }

        /// <summary>
        /// Defines the acc.
        /// </summary>
        internal controlsStates acc = new controlsStates();

        /// <summary>
        /// The statusControls.
        /// </summary>
        /// <param name="screen">The screen<see cref="String"/>.</param>
        /// <param name="@new">The new<see cref="Boolean"/>.</param>
        /// <param name="edit">The edit<see cref="Boolean"/>.</param>
        /// <param name="save">The save<see cref="Boolean"/>.</param>
        /// <param name="delete">The delete<see cref="Boolean"/>.</param>
        /// <param name="cancel">The cancel<see cref="Boolean"/>.</param>
        /// <param name="exit">The exit<see cref="Boolean"/>.</param>
        public void statusControls(String screen, Boolean @new, Boolean edit, Boolean save, Boolean delete, Boolean cancel, Boolean exit)
        {
            try
            {
                if (screen == "PRODUCTO")
                {
                    BTNnewp.Enabled = @new;
                    BTNeditp.Enabled = edit;
                    BTNsavep.Enabled = save;
                    BTNdeletep.Enabled = delete;
                    BTNcancelp.Enabled = cancel;
                    BTNexitp.Enabled = exit;
                }


                else if (screen == "PRESENTACION_PROD")
                {
                    BTNnewpresent.Enabled = @new;
                    BTNeditpresent.Enabled = edit;
                    BTNsavepresent.Enabled = save;
                    BTNdeletepresent.Enabled = delete;
                    BTNcencelpresent.Enabled = cancel;
                    BTNexitpresent.Enabled = exit;
                }
                else if (screen == "PROVEEDOR")
                {
                    BTNnews.Enabled = @new;
                    BTNedits.Enabled = edit;
                    BTNsaves.Enabled = save;
                    BTNdeletes.Enabled = delete;
                    BTNcancels.Enabled = cancel;
                    BTNexits.Enabled = exit;
                }
                else
                {
                    BTNnewcategories.Enabled = @new;
                    BTNeditcategories.Enabled = edit;
                    BTNsavecategories.Enabled = save;
                    BTNdeletecategories.Enabled = delete;
                    BTNcancelcategories.Enabled = cancel;
                    BTNexitcategories.Enabled = exit;
                }

            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The BuildDataGridViewProduct.
        /// </summary>
        private void BuildDataGridViewProduct()
        {
            dgvproduct.Columns.Add("ColumnId", "Id");
            dgvproduct.Columns.Add("ColumnNumero", "#");
            dgvproduct.Columns.Add("ColumnCodigo", "Code");
            dgvproduct.Columns.Add("ColumnNombre", "Name");
            dgvproduct.Columns.Add("ColumnMarca", "Brand");
            dgvproduct.Columns.Add("ColumnCategoria", "Category");
            dgvproduct.Columns.Add("ColumnUnidMed", "UM");
            dgvproduct.Columns.Add("ColumnProveedor", "Supplier");

            dgvproduct.Columns[0].Visible = false;
            dgvproduct.Columns[1].Width = 30;
            dgvproduct.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvproduct.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvproduct.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvproduct.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvproduct.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewCellStyle css = new DataGridViewCellStyle();
            css.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvproduct.ColumnHeadersDefaultCellStyle = css;

            dgvproduct.AllowUserToAddRows = false;
            dgvproduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvproduct.MultiSelect = false;
        }

        /// <summary>
        /// The BuilDataGridViewCategory.
        /// </summary>
        private void BuilDataGridViewCategory()
        {
            dgvcategoria.Columns.Add("ColumnId", "Id");
            dgvcategoria.Columns.Add("ColumnNumero", "#");
            dgvcategoria.Columns.Add("ColumnCodigo", "Code");
            dgvcategoria.Columns.Add("ColumnNombre", "Name");
            dgvcategoria.Columns.Add("ColumnDescripcion", "Description");
            dgvcategoria.Columns[0].Visible = false;

            dgvcategoria.Columns[1].Width = 30;
            dgvcategoria.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvcategoria.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvcategoria.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewCellStyle css = new DataGridViewCellStyle();
            css.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvcategoria.ColumnHeadersDefaultCellStyle = css;

            dgvcategoria.AllowUserToAddRows = false;
            dgvcategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvcategoria.MultiSelect = false;
        }

        /// <summary>
        /// The BuildDataGridViewUnitMeasureProduct.
        /// </summary>
        private void BuildDataGridViewUnitMeasureProduct()
        {
            dgvpresent.Columns.Add("ColumnId", "Id");
            dgvpresent.Columns.Add("ColumnNumero", "#");
            dgvpresent.Columns.Add("ColumnCodigo", "Code");
            dgvpresent.Columns.Add("ColumnDescripcion", "Description");
            dgvpresent.Columns.Add("ColumnAbreviatura", "Abbreviation");

            dgvpresent.Columns[0].Visible = false;
            dgvpresent.Columns[1].Width = 30;
            dgvpresent.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvpresent.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvpresent.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewCellStyle css = new DataGridViewCellStyle();
            css.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvpresent.ColumnHeadersDefaultCellStyle = css;

            dgvpresent.AllowUserToAddRows = false;
            dgvpresent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// The BuildDataGridViewSuppliers.
        /// </summary>
        private void BuildDataGridViewSuppliers()
        {
            dgvsupplier.Columns.Add("ColumnId", "Id");
            dgvsupplier.Columns.Add("ColumnNumero", "#");
            dgvsupplier.Columns.Add("ColumnCodigo", "Code");
            dgvsupplier.Columns.Add("ColumnRazSocial", "Name/Bussines Name");
            dgvsupplier.Columns.Add("ColumnRuc", "RNC");

            dgvsupplier.Columns[0].Visible = false;
            dgvsupplier.Columns[1].Width = 30;
            dgvsupplier.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvsupplier.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvsupplier.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewCellStyle css = new DataGridViewCellStyle();
            css.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvsupplier.ColumnHeadersDefaultCellStyle = css;

            dgvsupplier.AllowUserToAddRows = false;
            dgvsupplier.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// The FIllComboBoxes.
        /// </summary>
        private void FIllComboBoxes()
        {
            try
            {
                cbocategories.ValueMember = "Id_Cat";
                cbocategories.DisplayMember = "Nombre_Cat";
                cbocategories.DataSource = IBusinessManagement.Instance.ListCategories();

                cboprodpresent.ValueMember = "Id_Umed";
                cboprodpresent.DisplayMember = "Descripcion_Umed";
                cboprodpresent.DataSource = IBusinessManagement.Instance.ListUnitMeasureProduct();

                cbosupplier.ValueMember = "Id_Proveedor";
                cbosupplier.DisplayMember = "RazSocial_Proveedor";
                cbosupplier.DataSource = IBusinessManagement.Instance.ListSupplier();
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The ShowRowSelected.
        /// </summary>
        /// <param name="idprod">The idprod<see cref="int"/>.</param>
        private void ShowRowSelected(int idprod)
        {
            try
            {
                entProduct prod = null;
                prod = IBusinessManagement.Instance.SearchProduct(idprod);
                txtidp.Text = prod.Id_Prod.ToString();
                TXTcodep.Text = prod.Codigo_Prod;
                txtnamep.Text = prod.Nombre_Prod;
                txtbrandp.Text = prod.Marca_Prod;
                txtpurchasep.Text = prod.PrecioCompra_Prod.ToString();
                txtDescuento.Text = prod.Descuento_Prod.ToString();
                txtsaleprocip.Text = prod.Precio_Prod.ToString();
                txtstockp.Text = prod.Stock_Prod.ToString();
                txtavaragep.Text = prod.StockProm_Prod.ToString();
                txtminstockp.Text = prod.StockMin_Prod.ToString();
                cbocategories.SelectedValue = prod.categoria.Id_Cat;
                cboprodpresent.SelectedValue = prod.unidmedida.Id_Umed;
                cbosupplier.SelectedValue = prod.proveedor.Id_Proveedor;
                if (prod.ITBIS_Prod == 18)
                {
                    rb18ITBIS.Checked = true;
                }
                else if (prod.ITBIS_Prod == 16)
                {
                    rb116ITBIS.Checked = true;
                }
                else if (prod.ITBIS_Prod == 0)
                {
                    rb0.Checked = true;
                }

                dtpduedate.Text = Convert.ToString(prod.FechVen_Pord.ToString());
                acc.BlockTextBox(this.tcpProducts, false);
                statusControls("PRODUCTO", true, true, false, true, false, true);

            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The tcpProducto_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void tcpProducto_Click(object sender, EventArgs e)
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
        /// The label11_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void label11_Click(object sender, EventArgs e)
        {
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
                acc.clearTextBox(this.tcpProducts);
                acc.BlockTextBox(this.tcpProducts, true);
                statusControls("PRODUCTO", false, false, true, false, true, false);

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
            DialogResult r = MessageBox.Show("Are you sure you want to go out?", "Exiting...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
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
                statusControls("PRODUCTO", true, false, false, false, false, true);
                acc.BlockTextBox(this.tcpProducts, false);
                dtpduedate.Enabled = false;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                entProduct p = new entProduct();
                entCategory c = new entCategory();
                entUnidadMedida pres = new entUnidadMedida();
                entSupplier prov = new entSupplier();
                p.Id_Prod = Convert.ToInt32(txtidp.Text);
                p.categoria = c;
                p.proveedor = prov;
                p.unidmedida = pres;
                DialogResult r = MessageBox.Show("Are you sure you want to delete the record?", "Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int i = IBusinessManagement.Instance.ProductManagement(p, 3);
                    MessageBox.Show("record deleted successfully", "Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                statusControls("PRODUCTO", true, false, false, false, false, true);
                acc.BlockTextBox(this.tcpProducts, false);
                LoadGridProduct();

            }
            catch (ApplicationException es)
            {
                MessageBox.Show(es.Message, "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                if (String.IsNullOrEmpty(Convert.ToString(cbocategories.SelectedValue))) throw new ApplicationException("You must select a category");
                else if (String.IsNullOrEmpty(Convert.ToString(cbosupplier.SelectedValue))) throw new ApplicationException("You must select a provider");
                else if (String.IsNullOrEmpty(Convert.ToString(cboprodpresent.SelectedValue))) throw new ApplicationException("You must select unit of measure.");

                entProduct prod = new entProduct();
                int tipoedicion = 1;
                if (txtidp.Text != "")
                {
                    tipoedicion = 2;
                    prod.Id_Prod = Convert.ToInt32(txtidp.Text);
                }
                if (rb18ITBIS.Checked)
                {
                    prod.ITBIS_Prod = 18;
                }
                else if (rb116ITBIS.Checked)
                {
                    prod.ITBIS_Prod = 16;
                }
                else if (rb0.Checked)
                {
                    prod.ITBIS_Prod = 0;
                }
                else
                {
                    prod.ITBIS_Prod = 0;
                }
                prod.Nombre_Prod = txtnamep.Text;
                prod.Marca_Prod = txtbrandp.Text;
                if (txtpurchasep.Text == "") prod.PrecioCompra_Prod = 0; else prod.PrecioCompra_Prod = Convert.ToDouble(txtpurchasep.Text);
                if (txtsaleprocip.Text == "") prod.Precio_Prod = 0; else prod.Precio_Prod = Convert.ToDouble(txtsaleprocip.Text);
                if (txtstockp.Text == "") prod.Stock_Prod = 0; else prod.Stock_Prod = Convert.ToInt32(txtstockp.Text);
                if (txtavaragep.Text == "") prod.StockProm_Prod = 0; else prod.StockProm_Prod = Convert.ToInt32(txtavaragep.Text);
                if (txtminstockp.Text == "") prod.StockMin_Prod = 0; else prod.StockMin_Prod = Convert.ToInt32(txtminstockp.Text);
                prod.FechVen_Pord = dtpduedate.Value.ToString("yyyy/MM/dd");

                entCategory cat = new entCategory();
                cat.Id_Cat = Convert.ToInt32(cbocategories.SelectedValue);
                prod.categoria = cat;
                entUnidadMedida pres = new entUnidadMedida();
                pres.Id_Umed = Convert.ToInt32(cboprodpresent.SelectedValue);
                prod.unidmedida = pres;
                entSupplier prove = new entSupplier();
                prove.Id_Proveedor = Convert.ToInt32(cbosupplier.SelectedValue);
                prod.proveedor = prove;

                prod.UsuarioCreacion_Prod = _idUser;
                prod.UsuarioUpdate_Prod = _idUser;
                int i = IBusinessManagement.Instance.ProductManagement(prod, tipoedicion);
                MessageBox.Show("Record saved successfully!", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                statusControls("PRODUCTO", true, false, false, false, false, true);
                acc.BlockTextBox(this.tcpProducts, false);
                LoadGridProduct();
                dtpduedate.Enabled = false;

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

                acc.BlockTextBox(this.tcpProducts, true);
                statusControls("PRODUCTO", false, false, true, false, true, false);
                dtpduedate.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The label12_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void label12_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The label15_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void label15_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The textBox2_TextChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The textBox3_TextChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The textBox4_TextChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The label13_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void label13_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The label14_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void label14_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The textBox1_TextChanged_1.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The dataGridView1_CellContentClick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="DataGridViewCellEventArgs"/>.</param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        /// <summary>
        /// The BTNcargarcategoria_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNcargarcategoria_Click(object sender, EventArgs e)
        {
            try
            {
                LoadGridCategories();
                BTNloadcategories.Visible = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /// <summary>
        /// The LoadGridCategories.
        /// </summary>
        private void LoadGridCategories()
        {
            dgvcategoria.Rows.Clear();
            List<entCategory> Lista = null;
            Lista = IBusinessManagement.Instance.ListCategories();
            int n = 0;
            for (int i = 0; i < Lista.Count; i++)
            {
                n++;
                String[] fila = new string[] {
                    Lista[i].Id_Cat.ToString(), n.ToString(), Lista[i].Codigo_Cat, Lista[i].Nombre_Cat, Lista[i].Descripcion_Cat

                };
                dgvcategoria.Rows.Add(fila);

            }
        }

        /// <summary>
        /// The LoadGridProduct.
        /// </summary>
        private void LoadGridProduct()
        {
            try
            {
                int n = 0;
                dgvproduct.Rows.Clear();
                List<entProduct> Lista = IBusinessManagement.Instance.ListProduct();

                for (int i = 0; i < Lista.Count(); i++)
                {
                    n++;
                    String[] fila = new String[] { Lista[i].Id_Prod.ToString(), n.ToString(), Lista[i].Codigo_Prod, Lista[i].Nombre_Prod, Lista[i].Marca_Prod,
                    Lista[i].categoria.Nombre_Cat, Lista[i].unidmedida.Descripcion_Umed, Lista[i].proveedor.RazSocial_Proveedor, Lista[i].FechVen_Pord.ToString()};
                    dgvproduct.Rows.Add(fila);
                }


            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The frmMantenimiento_Load.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void frmMantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                statusControls("PRODUCTO", true, false, false, false, false, true);
                statusControls("CATEGORIA", true, false, false, false, false, true);
                statusControls("PRESENTACION_PROD", true, false, false, false, false, true);
                statusControls("PROVEEDOR", true, false, false, false, false, true);

                acc.BlockTextBox(this.tcpProducts, false);
                acc.BlockTextBox(this.tbcCategories, false);
                acc.BlockTextBox(this.tbcProdPresentation, false);
                acc.BlockTextBox(this.tbcSuppliers, false);

                BuildDataGridViewProduct();
                BuildDataGridViewSuppliers();
                BuildDataGridViewUnitMeasureProduct();
                BuilDataGridViewCategory();
                FIllComboBoxes();
                LoadGridProduct();
                dtpduedate.Enabled = false;
                lblvenprod.Visible = false;





            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        /// <summary>
        /// The LoadGridSupplier.
        /// </summary>
        private void LoadGridSupplier()
        {
            try
            {
                int n = 0;
                dgvsupplier.Rows.Clear();
                List<entSupplier> p = null;
                p = IBusinessManagement.Instance.ListSupplier();
                for (int i = 0; i < p.Count; i++)
                {
                    n++;
                    String[] fila = new String[] {
                        p[i].Id_Proveedor.ToString(), n.ToString(),  p[i].Cod_Proveedor,  p[i].RazSocial_Proveedor,
                         p[i].Rnc_Proveedor

                    };
                    dgvsupplier.Rows.Add(fila);

                }

            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The BTNcargarprove_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNcargarprove_Click(object sender, EventArgs e)
        {
            try
            {
                LoadGridSupplier();
                BTNloads.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The BTNnuevoprove_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNnuevoprove_Click(object sender, EventArgs e)
        {
            try
            {
                acc.clearTextBox(this.tbcSuppliers);
                acc.BlockTextBox(this.tbcSuppliers, true);
                statusControls("PROVEEDOR", false, false, true, false, true, false);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The BTNeditarprove_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNeditarprove_Click(object sender, EventArgs e)
        {
            try
            {

                acc.BlockTextBox(this.tbcSuppliers, true);
                statusControls("PROVEEDOR", false, false, true, false, true, false);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The BTNguardarprove_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNguardarprove_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The BTNgrabarprove_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNgrabarprove_Click(object sender, EventArgs e)
        {
            try
            {
                entSupplier prove = new entSupplier();
                int tipoedicion = 1;
                if (txtids.Text != "") { tipoedicion = 2; prove.Id_Proveedor = Convert.ToInt32(txtids.Text); }
                prove.RazSocial_Proveedor = txtnamebussinesnames.Text;
                prove.Rnc_Proveedor = txtrncs.Text;
                prove.Direccion_Proveedor = txtaddresss.Text;
                prove.Telefono_Proveedor = txtphones.Text;
                prove.Celular_Proveedor = txtcellphones.Text;
                prove.Correo_Proveedor = txtemails.Text;
                int i = IBusinessManagement.Instance.SupplierManagement(prove, tipoedicion);
                MessageBox.Show("Record Saved Successfully!", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                statusControls("PROVEEDOR", true, false, false, false, false, true);
                acc.BlockTextBox(this.tbcSuppliers, false);
                LoadGridSupplier();
                FIllComboBoxes();
                BTNloads.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The BTNeliminarprove_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNeliminarprove_Click(object sender, EventArgs e)
        {
            try
            {
                entSupplier prove = new entSupplier();
                prove.Id_Proveedor = Convert.ToInt32(txtids.Text);
                DialogResult r = MessageBox.Show("Are you sure you want to delete the record?", "Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int i = IBusinessManagement.Instance.SupplierManagement(prove, 3);
                    MessageBox.Show("record deleted", "Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                statusControls("PRESENTACION_PROD", true, false, false, false, false, true);
                acc.BlockTextBox(this.tbcProdPresentation, false);
                LoadGridSupplier();
                FIllComboBoxes();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The BTNcancelarprove_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNcancelarprove_Click(object sender, EventArgs e)
        {
            try
            {
                statusControls("PROVEEDOR", true, true, false, true, false, true);
                acc.BlockTextBox(this.tbcSuppliers, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The BTNsalirprove_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNsalirprove_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you want to go out?", "Exiting...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// The dgvproveedor_CellContentClick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="DataGridViewCellEventArgs"/>.</param>
        private void dgvproveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        /// <summary>
        /// The dgvproveedor_CellClick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="DataGridViewCellEventArgs"/>.</param>
        private void dgvproveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idprove = Convert.ToInt32(dgvsupplier.CurrentRow.Cells[0].Value);
                entSupplier prove = null;
                prove = IBusinessManagement.Instance.SearchSupplier(idprove);
                txtids.Text = prove.Id_Proveedor.ToString();
                TXTcodes.Text = prove.Cod_Proveedor;
                txtnamebussinesnames.Text = prove.RazSocial_Proveedor;
                txtrncs.Text = prove.Rnc_Proveedor;
                txtaddresss.Text = prove.Direccion_Proveedor;
                txtphones.Text = prove.Telefono_Proveedor;
                txtcellphones.Text = prove.Celular_Proveedor;
                txtemails.Text = prove.Correo_Proveedor;
                statusControls("PROVEEDOR", true, true, false, true, false, true);
                acc.BlockTextBox(this.tbcSuppliers, false);
            }
            catch (ApplicationException es)
            {
                MessageBox.Show(es.Message, "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The LoadGridUnitMesaureProduct.
        /// </summary>
        private void LoadGridUnitMesaureProduct()
        {
            try
            {
                int n = 0;
                dgvpresent.Rows.Clear();
                List<entUnidadMedida> pres = null;
                pres = IBusinessManagement.Instance.ListUnitMeasureProduct();
                for (int i = 0; i < pres.Count; i++)
                {
                    n++;
                    String[] fila = new string[] {
                        pres[i].Id_Umed.ToString(), n.ToString(), pres[i].Codigo_Umed, pres[i].Descripcion_Umed, pres[i].Abreviatura_Umed };
                    dgvpresent.Rows.Add(fila);

                }
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The BTNcargarpresent_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNcargarpresent_Click(object sender, EventArgs e)
        {
            try
            {
                LoadGridUnitMesaureProduct();
                BTNloadpresent.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The BTNnuevopresent_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNnuevopresent_Click(object sender, EventArgs e)
        {
            try
            {
                acc.clearTextBox(this.tbcProdPresentation);
                acc.BlockTextBox(this.tbcProdPresentation, true);
                statusControls("PRESENTACION_PROD", false, false, true, false, true, false);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The BTNeditarpresent_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNeditarpresent_Click(object sender, EventArgs e)
        {
            try
            {

                acc.BlockTextBox(this.tbcProdPresentation, true);
                statusControls("PRESENTACION_PROD", false, false, true, false, true, false);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The BTNgrabarpresent_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNgrabarpresent_Click(object sender, EventArgs e)
        {
            try
            {
                entUnidadMedida pres = new entUnidadMedida();
                int tipoedicion = 1;
                if (txtidpresent.Text != "")
                {
                    tipoedicion = 2; pres.Id_Umed = Convert.ToInt32(txtidpresent.Text);
                }
                pres.Descripcion_Umed = txtdescriptionpresent.Text;
                pres.Abreviatura_Umed = txtabbrepresent.Text;
                int i = IBusinessManagement.Instance.UnitMeasureProductManagement(pres, tipoedicion);
                MessageBox.Show("record saved successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                acc.BlockTextBox(this.tbcProdPresentation, false);
                statusControls("PRESENTACION_PROD", true, false, true, false, false, false);
                FIllComboBoxes();
                BTNloadpresent.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The BTNeliminarpresent_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNeliminarpresent_Click(object sender, EventArgs e)
        {
            try
            {
                entUnidadMedida pres = new entUnidadMedida();
                pres.Id_Umed = Convert.ToInt32(txtidpresent.Text);
                DialogResult r = MessageBox.Show("Are you sure you want to delete the record?", "Message", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int i = IBusinessManagement.Instance.UnitMeasureProductManagement(pres, 3);
                    MessageBox.Show("Record deleted successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


                statusControls("PRESENTACION_PROD", true, false, false, false, false, true);
                FIllComboBoxes();
                acc.BlockTextBox(this.tbcProdPresentation, false);
                LoadGridUnitMesaureProduct();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The BTNcancelarpresent_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNcancelarpresent_Click(object sender, EventArgs e)
        {
            try
            {
                statusControls("PRESENTACION_PROD", true, true, false, true, false, true);
                acc.BlockTextBox(this.tbcProdPresentation, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The BTNsalirpresent_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNsalirpresent_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you want to go out?", "Exiting...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// The dgvpresentacionprod_CellClick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="DataGridViewCellEventArgs"/>.</param>
        private void dgvpresentacionprod_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idpres = Convert.ToInt32(dgvpresent.CurrentRow.Cells[0].Value);
                entUnidadMedida pres = null;
                pres = IBusinessManagement.Instance.SearchUnitMeasureProduct(idpres);
                txtidpresent.Text = pres.Id_Umed.ToString();
                txtcodepresent.Text = pres.Codigo_Umed;
                txtdescriptionpresent.Text = pres.Descripcion_Umed;
                txtabbrepresent.Text = pres.Abreviatura_Umed;
                statusControls("PRESENTACION_PROD", true, true, false, true, false, true);
                acc.BlockTextBox(this.tbcProdPresentation, false);
            }
            catch (ApplicationException es)
            {
                MessageBox.Show(es.Message, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The BTNnuevocat_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNnuevocat_Click(object sender, EventArgs e)
        {
            try
            {
                acc.clearTextBox(this.tbcCategories);
                acc.BlockTextBox(this.tbcCategories, true);
                statusControls("CATEGORIA", false, false, true, false, true, false);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The BTNeditarcat_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNeditarcat_Click(object sender, EventArgs e)
        {
            try
            {

                acc.BlockTextBox(this.tbcCategories, true);
                statusControls("CATEGORIA", false, false, true, false, true, false);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The BTNgrabarcat_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNgrabarcat_Click(object sender, EventArgs e)
        {
            try
            {
                entCategory c = new entCategory();
                int tipoedicion = 1;
                if (txtidcategories.Text != "")
                {
                    tipoedicion = 2; c.Id_Cat = Convert.ToInt32(txtidcategories.Text);
                }
                c.Nombre_Cat = txtnamecategories.Text;
                c.Descripcion_Cat = txtdescriptioncategories.Text;
                c.UsuarioCreacion_Cat = _idUser;
                c.UsuarioUpdate_Cat = _idUser;

                int i = IBusinessManagement.Instance.CategoryManagement(c, tipoedicion);
                MessageBox.Show("Record saved successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BTNloadpresent.Visible = true;
                acc.BlockTextBox(this.tbcCategories, false);
                statusControls("CATEGORIA", true, false, false, false, false, true);
                FIllComboBoxes();
                LoadGridCategories();
                BTNloadpresent.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The BTNeliminarcat_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNeliminarcat_Click(object sender, EventArgs e)
        {
            try
            {
                entCategory c = new entCategory();
                c.Id_Cat = Convert.ToInt32(txtidcategories.Text);
                DialogResult r = MessageBox.Show("Are you sure you want to delete the record?", "Message", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int i = IBusinessManagement.Instance.CategoryManagement(c, 3);
                    MessageBox.Show("Registry deleted successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


                statusControls("CATEGORIA", true, false, false, false, false, true);
                FIllComboBoxes();
                acc.BlockTextBox(this.tbcCategories, false);
                LoadGridCategories();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The BTNcancelarcat_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNcancelarcat_Click(object sender, EventArgs e)
        {
            try
            {
                statusControls("CATEGORIA", true, true, false, true, false, true);
                acc.BlockTextBox(this.tbcCategories, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The BTNsalircat_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNsalircat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you want to go out?", "Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// The dgvcategoria_CellClick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="DataGridViewCellEventArgs"/>.</param>
        private void dgvcategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idcat = Convert.ToInt32(dgvcategoria.CurrentRow.Cells[0].Value);
                entCategory c = null;
                c = IBusinessManagement.Instance.SearchCategories(idcat);
                txtidcategories.Text = c.Id_Cat.ToString();
                txtcodecategories.Text = c.Codigo_Cat;
                txtnamecategories.Text = c.Nombre_Cat;
                txtdescriptioncategories.Text = c.Descripcion_Cat;
                statusControls("CATEGORIA", true, true, false, true, false, true);
                acc.BlockTextBox(this.tbcCategories, false);
            }
            catch (ApplicationException es)
            {
                MessageBox.Show(es.Message, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The button2_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            LoadGridProduct();
        }

        /// <summary>
        /// The dgvproducto_CellClick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="DataGridViewCellEventArgs"/>.</param>
        private void dgvproducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idprod = Convert.ToInt32(dgvproduct.CurrentRow.Cells[0].Value);
                ShowRowSelected(idprod);

                if (dtpduedate.Value < DateTime.Today)
                {
                    lblvenprod.Visible = true;
                    lbldisplayven.BackColor = Color.Red;
                }

                else
                {
                    lblvenprod.Visible = false;
                    lbldisplayven.BackColor = Color.LightGreen;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                frmSearchProduct frmB = new frmSearchProduct(this._idUser);
                frmB.ShowDialog();
                int dop = localdatabase.Instance.ReturnIdProduct(0, 0);
                for (int i = 0; i < dgvproduct.RowCount; i++)
                {
                    if (Convert.ToInt32(dgvproduct.Rows[1].Cells[0].Value) == dop)
                    {
                        dgvproduct.Rows[i].Selected = true;
                        ShowRowSelected(dop);
                        localdatabase.Instance.ReturnIdProduct(1, 0);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The label26_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void label26_Click(object sender, EventArgs e)
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
        /// The txtnamep_KeyPress.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="KeyPressEventArgs"/>.</param>
        private void txtnamep_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        /// <summary>
        /// The txtnamebussinesnames_KeyPress.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="KeyPressEventArgs"/>.</param>
        private void txtnamebussinesnames_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        /// <summary>
        /// The txtbrandp_KeyPress.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="KeyPressEventArgs"/>.</param>
        private void txtbrandp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        /// <summary>
        /// The txtdescriptionpresent_KeyPress.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="KeyPressEventArgs"/>.</param>
        private void txtdescriptionpresent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        /// <summary>
        /// The txtabbrepresent_KeyPress.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="KeyPressEventArgs"/>.</param>
        private void txtabbrepresent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        /// <summary>
        /// The txtnamecategories_KeyPress.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="KeyPressEventArgs"/>.</param>
        private void txtnamecategories_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        /// <summary>
        /// The txtdescriptioncategories_KeyPress.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="KeyPressEventArgs"/>.</param>
        private void txtdescriptioncategories_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
