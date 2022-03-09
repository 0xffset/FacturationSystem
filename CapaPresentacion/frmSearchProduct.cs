namespace CapaPresentacion
{
    using CapaNegocio;
    using Entidades;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="frmSearchProduct" />.
    /// </summary>
    public partial class frmSearchProduct : Form
    {
        /// <summary>
        /// Defines the idusu.
        /// </summary>
        internal int idusu = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="frmSearchProduct"/> class.
        /// </summary>
        /// <param name="idusua">The idusua<see cref="int?"/>.</param>
        public frmSearchProduct(int? idusua)
        {
            InitializeComponent();
            this.idusu = (int)idusua;
        }

        /// <summary>
        /// The BuildProductGrid.
        /// </summary>
        private void BuildProductGrid()
        {
            dgvproduct.Columns.Add("ColumnId", "Id");
            dgvproduct.Columns.Add("ColumnNumber", "#");
            dgvproduct.Columns.Add("ColumnCode", "Code");
            dgvproduct.Columns.Add("ColumnName", "Name");
            dgvproduct.Columns.Add("ColumnBrand", "Brand");
            dgvproduct.Columns.Add("ColumnCategory", "Category");
            dgvproduct.Columns.Add("ColumnProdPresent", "Prod. Present.");
            dgvproduct.Columns.Add("ColumnPrice", "Price $");
            dgvproduct.Columns.Add("ColumnDueDate", "Due Date");
            dgvproduct.Columns.Add("ColumnStock", "Stock");

            dgvproduct.Columns[0].Visible = false;
            dgvproduct.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvproduct.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvproduct.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvproduct.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvproduct.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvproduct.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvproduct.Columns[8].Width = 70;

            DataGridViewCellStyle css = new DataGridViewCellStyle();
            css.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvproduct.ColumnHeadersDefaultCellStyle = css;

            dgvproduct.AllowUserToAddRows = false;
            dgvproduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// The checkBox1_CheckedChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                tipbusqueda = 1;
                dgvproduct.Rows.Clear();
                BTNSale.Enabled = false;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ; }
        }

        /// <summary>
        /// The rbCategoria_CheckedChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void rbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                tipbusqueda = 2;
                dgvproduct.Rows.Clear();
                BTNSale.Enabled = false;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ; }
        }

        /// <summary>
        /// The BTNvender_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNvender_Click(object sender, EventArgs e)
        {
            int inten = localdatabase.Instance.ReturnTried(1, 1);
            int invoca = localdatabase.Instance.Invoke(0, 0);

            if (invoca == 1)
            {
                int idprod = Convert.ToInt32(dgvproduct.CurrentRow.Cells[0].Value);
                localdatabase.Instance.ReturnDetailsSale(1, idprod, 1);
            }

            else
            {
                localdatabase.Instance.Invoke(1, 0);
            }
            this.Close();
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

                BTNSale.Enabled = false;
                int n = 0;
                List<entProduct> lista = IBusinessManagement.Instance.SearchProductAvanced(tipbusqueda, "");
                dgvproduct.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    n++;
                    String[] fila = new string[] {
                                lista[i].Id_Prod.ToString(), n.ToString(), lista[i].Codigo_Prod, lista[i].Nombre_Prod, lista[i].Marca_Prod,
                                lista[i].categoria.Nombre_Cat, lista[i].unidmedida.Descripcion_Umed, lista[i].Precio_Prod.ToString(), lista[i].FechVen_Pord.ToString(),
                                lista[i].Stock_Prod.ToString()
                            };
                    dgvproduct.Rows.Add(fila);

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ; }
        }

        /// <summary>
        /// The frmBuscarProd_Load.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void frmBuscarProd_Load(object sender, EventArgs e)
        {
            try
            {
                BuildProductGrid();
                rbName.Checked = true; tipbusqueda = 1;
                BTNSale.Enabled = false;
                BTNEditProduct.Enabled = false;
            }
            catch (ApplicationException es)
            {
                MessageBox.Show(es.Message, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ; }
        }

        /// <summary>
        /// Defines the tipbusqueda.
        /// </summary>
        internal int tipbusqueda = 0;

        /// <summary>
        /// The txtBuscarProd_KeyUp.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="KeyEventArgs"/>.</param>
        private void txtBuscarProd_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Back)
                {
                    String valentrada = txtSearchProduct.Text;
                    int n = 0;
                    List<entProduct> lista = IBusinessManagement.Instance.SearchProductAvanced(tipbusqueda, valentrada);
                    dgvproduct.Rows.Clear();
                    for (int i = 0; i < lista.Count; i++)
                    {
                        n++;
                        String[] fila = new string[] {
                                lista[i].Id_Prod.ToString(), n.ToString(), lista[i].Codigo_Prod, lista[i].Nombre_Prod, lista[i].Marca_Prod,
                                lista[i].categoria.Nombre_Cat, lista[i].unidmedida.Descripcion_Umed, lista[i].Precio_Prod.ToString(), lista[i].FechVen_Pord.ToString(),
                                lista[i].Stock_Prod.ToString()
                            };
                        dgvproduct.Rows.Add(fila);
                    }


                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ; }
        }

        /// <summary>
        /// The rbPrecio_CheckedChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void rbPrecio_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                tipbusqueda = 3;
                dgvproduct.Rows.Clear();
                BTNSale.Enabled = false;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ; }
        }

        /// <summary>
        /// The dgvproducto_CellClick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="DataGridViewCellEventArgs"/>.</param>
        private void dgvproducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BTNSale.Enabled = true;
            BTNEditProduct.Enabled = true;
        }

        /// <summary>
        /// The BTNmantenimiento_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNmantenimiento_Click(object sender, EventArgs e)
        {
            try
            {
                int idprod = Convert.ToInt32(dgvproduct.CurrentRow.Cells[0].Value);
                localdatabase.Instance.ReturnIdProduct(1, idprod);
                this.Dispose();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ; }
        }

        /// <summary>
        /// The BTNsalir_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BTNsalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Esta seguro de que quiere salir?", "Saliendo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            {
                if (r == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        /// <summary>
        /// The txtBuscarProd_TextChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void txtBuscarProd_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
