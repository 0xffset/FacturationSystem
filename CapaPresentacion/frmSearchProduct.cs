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
    public partial class frmSearchProduct : Form
    {
        int idusu = 0;
        public frmSearchProduct(int? idusua)
        {
            InitializeComponent();
            this.idusu = (int)idusua;
        }

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

        private void BTNvender_Click(object sender, EventArgs e)
        {
            int inten = localdatabase.Instancia.Returnintento(1, 1);
            int invoca = localdatabase.Instancia.invocar(0, 0);
            
            if (invoca == 1)
            {
                int idprod = Convert.ToInt32(dgvproduct.CurrentRow.Cells[0].Value);
                localdatabase.Instancia.returnDetventa(1, idprod, 1);
            }
          
            else
            {
                localdatabase.Instancia.invocar(1, 0);
            }
            this.Close();

                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                BTNSale.Enabled = false;
                int n = 0;
                List<entProduct> lista = IBusinessManagement.Instancia.BuscarproAvanzada(tipbusqueda, "");
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

        int tipbusqueda = 0;

        private void txtBuscarProd_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Back)
                {
                    String valentrada = txtSearchProduct.Text;
                    int n = 0;
                    List<entProduct> lista = IBusinessManagement.Instancia.BuscarproAvanzada(tipbusqueda, valentrada);
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

        private void dgvproducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BTNSale.Enabled = true;
            BTNEditProduct.Enabled = true;
        }

        private void BTNmantenimiento_Click(object sender, EventArgs e)
        {
            try
            {
                int idprod = Convert.ToInt32(dgvproduct.CurrentRow.Cells[0].Value);
                localdatabase.Instancia.returnidprod(1, idprod);
                this.Dispose();
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ; }

        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Esta seguro de que quiere salir?", "Saliendo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            {
                if (r==DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void txtBuscarProd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
