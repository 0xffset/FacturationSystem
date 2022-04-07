namespace CapaPresentacion
{
    using CapaNegocio;
    using Entidades;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="frmIndicaProducto" />.
    /// </summary>
    public partial class frmIndicaProducto : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="frmIndicaProducto"/> class.
        /// </summary>
        public frmIndicaProducto()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The BuildProductGrid.
        /// </summary>
        private void BuildProductGrid()
        {
            try
            {
                dgvProduct.Columns.Add("ColumnId", "Id");
                dgvProduct.Columns.Add("ColumnCodigo", "Code");
                dgvProduct.Columns.Add("ColumnNombre", "Name");
                dgvProduct.Columns.Add("ColumnPrecioCompra", "Purchase Price $");
                dgvProduct.Columns.Add("ColumnPrecio", "Sale Price $");
                dgvProduct.Columns.Add("ColumnStock", "Stock");
                dgvProduct.Columns.Add("ColumnFechVen", "Due Date");
                dgvProduct.Columns.Add("ColumnUnidMedida", "Category");
                dgvProduct.Columns.Add("ColumnMateridida", "UM");
                dgvProduct.Columns.Add("ColumnStatus", "Status");


                dgvProduct.Columns[0].Visible = false;
                dgvProduct.Columns[2].Width = 300;
                dgvProduct.Columns[3].Width = 200;
                dgvProduct.Columns[4].Width = 200;
                dgvProduct.Columns[5].Width = 70;
                dgvProduct.Columns[6].Width = 200;
                dgvProduct.Columns[7].Width = 100;
                dgvProduct.Columns[8].Width = 120;
                dgvProduct.Columns[9].Width = 120;

                DataGridViewCellStyle css = new DataGridViewCellStyle();
                css.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProduct.ColumnHeadersDefaultCellStyle = css;

                dgvProduct.AllowUserToAddRows = false;
                dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvProduct.AllowUserToResizeColumns = true;

            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The FillComboBox.
        /// </summary>
        private void FillComboBox()
        {
            try
            {
                cboCategory.ValueMember = "Id_Cat";
                cboCategory.DisplayMember = "Nombre_Cat";
                cboCategory.DataSource = IBusinessManagement.Instance.ListCategories();
                rbStock.Checked = true;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The FillProductGrid.
        /// </summary>
        /// <param name="name">The name<see cref="String"/>.</param>
        private void FillProductGrid(String name)
        {
            try
            {
                int cat = 0;
                if (name == null)
                {
                    if (cboCategory.SelectedValue == null) throw new ApplicationException("You must to select a category");
                }
                if (!String.IsNullOrEmpty(Convert.ToString(cboCategory.SelectedValue))) cat = (int)cboCategory.SelectedValue;
                dgvProduct.Rows.Clear();
                int rango = 0; String img = null;
                if (rbStock.Checked == true) rango = 3;
                else if (rbStockPro.Checked == true) rango = 2;
                else if (rbStockMin.Checked == true) rango = 1;
                else if (rbStockMin.Checked == true) rango = 0;
                List<entProduct> Lista = null;
                if (name == null)
                {
                    Lista = IBusinessManagement.Instance.ListProductByCodeCatRan(txtCodeProduct.Text, (int)cat, rango);
                }
                else { Lista = IBusinessManagement.Instance.SearchAvancedProductByName(name); }
                for (int i = 0; i < Lista.Count; i++)
                {
                    if (Lista[i].Stock_Prod >= 0 && Lista[i].Stock_Prod <= Lista[i].StockMin_Prod)
                    {
                        img = "Minimun";

                    }
                    else if (Lista[i].Stock_Prod > Lista[i].StockMin_Prod && Lista[i].Stock_Prod <= Lista[i].StockProm_Prod)
                    {
                        img = "Avarage";

                    }
                    else if (Lista[i].Stock_Prod > Lista[i].StockProm_Prod)
                    {

                        img = "Enough";
                    }

                    String[] fila = new String[] {
                            Lista[i].Id_Prod.ToString(), Lista[i].Codigo_Prod, Lista[i].Nombre_Prod, Lista[i].PrecioCompra_Prod.ToString(), Lista[i].Precio_Prod.ToString(),
                            Lista[i].Stock_Prod.ToString(),Lista[i].FechVen_Pord.ToString(), Lista[i].categoria.Nombre_Cat, Lista[i].unidmedida.Abreviatura_Umed };
                    dgvProduct.Rows.Add(fila);
                    dgvProduct.Rows[i].Cells[9].Value = img;

                }
            }

            catch (Exception) { throw; }
        }

        /// <summary>
        /// The rbStock_CheckedChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>


        /// <summary>
        /// The frmIndicaProducto_Load.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void frmIndicaProducto_Load(object sender, EventArgs e)
        {
            try
            {
                BuildProductGrid();
                FillComboBox();

            }
            catch (ApplicationException es)
            {
                MessageBox.Show(es.Message, "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The addDataGridViewCellColors.
        /// </summary>
        private void addDataGridViewCellColors()
        {

            foreach (DataGridViewRow dgvr in dgvProduct.Rows)
            {


                if (dgvr.Cells["ColumnStatus"].Value.ToString() == "Enough")
                {
                    dgvr.DefaultCellStyle.BackColor = Color.LightGreen;

                }

                if (dgvr.Cells["ColumnStatus"].Value.ToString() == "Avarage")
                {
                    dgvr.DefaultCellStyle.BackColor = Color.Orange;
                }

                if (dgvr.Cells["ColumnStatus"].Value.ToString() == "Minimun")
                {
                    dgvr.DefaultCellStyle.BackColor = Color.LightCoral;
                }

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
                FillProductGrid(null);
                addDataGridViewCellColors();
            }
            catch (ApplicationException es)
            {
                MessageBox.Show(es.Message, "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// The txtCodigop_KeyUp.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="KeyEventArgs"/>.</param>
        private void txtCodigop_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {
                FillProductGrid(txtCodeProduct.Text);
            }
            catch (ApplicationException es)
            {
                MessageBox.Show(es.Message, "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The txtNombrePro_KeyUp.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="KeyEventArgs"/>.</param>
        private void txtNombrePro_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                FillProductGrid(txtNameProduct.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
