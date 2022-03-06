using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entidades;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class frmIndicaProducto : Form
    {
        public frmIndicaProducto()
        {
            InitializeComponent();
        }

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

        private void FillComboBox()
        {
            try
            {
                cboCategory.ValueMember = "Id_Cat";
                cboCategory.DisplayMember = "Nombre_Cat";
                cboCategory.DataSource = IBusinessManagement.Instancia.listarcategoria();
                rbStock.Checked = true;
            }
            catch (Exception) { throw; }
        }
       
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
                else if (rbStockMin.Checked == true) rango =1;
                else if (rbStockMin.Checked == true) rango =0;
                List<entProduct> Lista = null;
                if (name ==null) 
                {
                    Lista = IBusinessManagement.Instancia.ListarProdIndicador(txtCodeProduct.Text,(int)cat, rango); }
                    else { Lista = IBusinessManagement.Instancia.BuscarprodAvanzadaIndicador(name);}
                    for (int i =0; i <Lista.Count; i++)
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

        private void rbStock_CheckedChanged(object sender, EventArgs e)
        {

        }

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
        private void addDataGridViewCellColors()
        {
           
            foreach (DataGridViewRow dgvr in dgvProduct.Rows)
            {

              
                if (dgvr.Cells["ColumnStatus"].Value.ToString() == "Enough")
                {
                    dgvr.DefaultCellStyle.BackColor = Color.Green;
                   
                }

                if (dgvr.Cells["ColumnStatus"].Value.ToString() == "Avarage")
                {
                    dgvr.DefaultCellStyle.BackColor = Color.Orange;
                }

                if (dgvr.Cells["ColumnStatus"].Value.ToString() == "Minimun")
                {
                    dgvr.DefaultCellStyle.BackColor = Color.Red;
                }

            }
        }
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
            catch (Exception ex) { MessageBox.Show(ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);} 
        
        
        }

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
