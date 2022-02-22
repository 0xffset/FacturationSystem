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

        private void creargrid()
        {
            try
            {
                dgvproducto.Columns.Add("ColumnId", "Id");
                dgvproducto.Columns.Add("ColumnCodigo", "Codigo");
                dgvproducto.Columns.Add("ColumnNombre", "Nombre");
                dgvproducto.Columns.Add("ColumnPrecioCompra", "Precio Compra");
                dgvproducto.Columns.Add("ColumnPrecio", "Precio Venta");
                dgvproducto.Columns.Add("ColumnStock", "Stock");
                dgvproducto.Columns.Add("ColumnFechVen", "Fech. Ven");
                dgvproducto.Columns.Add("ColumnUnidMedida", "Categoria");
                dgvproducto.Columns.Add("ColumnMateridida", "Pre. Producto");
      
                DataGridViewImageColumn dgvImagen = new DataGridViewImageColumn();
                dgvImagen.HeaderText = "Estado";
                dgvImagen.Name = "ColumnEstado";
                dgvproducto.Columns.Add(dgvImagen);

                dgvproducto.Columns[0].Visible = false;
                dgvproducto.Columns[2].Width = 300;
                dgvproducto.Columns[3].Width = 88;
                dgvproducto.Columns[4].Width = 88;
                dgvproducto.Columns[5].Width = 88;
                dgvproducto.Columns[6].Width = 70;
                dgvproducto.Columns[7].Width = 100;
                dgvproducto.Columns[8].Width = 110;
                dgvproducto.Columns[9].Width = 120;
              
                DataGridViewCellStyle css = new DataGridViewCellStyle();
                css.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvproducto.ColumnHeadersDefaultCellStyle = css;

                dgvproducto.AllowUserToAddRows = false;
                dgvproducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvproducto.AllowUserToResizeColumns = false;

            }
            catch (Exception) { throw; }
        }

        private void llenarcomox()
        {
            try
            {
                cboCategoriap.ValueMember = "Id_Cat";
                cboCategoriap.DisplayMember = "Nombre_Cat";
                cboCategoriap.DataSource = IBusinessManagement.Instancia.listarcategoria();
                rbStock.Checked = true;
            }
            catch (Exception) { throw; }
        }
        private void llenargrid(String name)
        {
            try
            {
                int cat = 0;
                if (name == null)
                {
                    if (cboCategoriap.SelectedValue == null) throw new ApplicationException("Debe seleccionar una categoria");
                }
                if (!String.IsNullOrEmpty(Convert.ToString(cboCategoriap.SelectedValue))) cat = (int)cboCategoriap.SelectedValue;
                dgvproducto.Rows.Clear();
                int rango = 0; Image img = null;
                if (rbStock.Checked == true) rango = 3;
                else if (rbStockPro.Checked == true) rango = 2;
                else if (rbStockMin.Checked == true) rango =1;
                else if (rbStockMin.Checked == true) rango =0;
                List<entProduct> Lista = null;
                if (name ==null) 
                {
                    Lista = IBusinessManagement.Instancia.ListarProdIndicador(txtCodigop.Text,(int)cat, rango); }
                    else { Lista = IBusinessManagement.Instancia.BuscarprodAvanzadaIndicador(name);}
                    for (int i =0; i <Lista.Count; i++)
                    {
                        if (Lista[i].Stock_Prod >= 0 && Lista[i].Stock_Prod <= Lista[i].StockMin_Prod)
                        {
                            img = Properties.Resources.circulorojo_24x24;
                        }
                        else if (Lista[i].Stock_Prod > Lista[i].StockMin_Prod && Lista[i].Stock_Prod <= Lista[i].StockProm_Prod)
                        {
                            img = Properties.Resources.CirculoNaranja24x24;
                        }
                        else if (Lista[i].Stock_Prod  > Lista[i].StockProm_Prod)
                        {
                            img = Properties.Resources.circulo_verde24x24;
                        }

                       //DateTime DT = DateTime.TryParseExact(Lista[i].FechVen_Pord.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.CurrentUICulture.DateTimeFormat);
                        //DateTime date1l; String date2;
                        //date1l = Convert.ToDateTime(Lista[i].FechVen_Pord.ToString());

                        //if (DT < DateTime.Today)
                        //{
                        //    DataGridViewCellStyle css = new DataGridViewCellStyle();
                        //    css.BackColor = Color.Red;
                        //    dgvproducto.RowsDefaultCellStyle = css;
                        //}

                        String[] fila = new String[] {
                            Lista[i].Id_Prod.ToString(), Lista[i].Codigo_Prod, Lista[i].Nombre_Prod, Lista[i].PrecioCompra_Prod.ToString(), Lista[i].Precio_Prod.ToString(),
                            Lista[i].Stock_Prod.ToString(),Lista[i].FechVen_Pord.ToString(), Lista[i].categoria.Nombre_Cat, Lista[i].unidmedida.Abreviatura_Umed };
                            dgvproducto.Rows.Add(fila);
                            dgvproducto.Rows[i].Cells[9].Value = img;
                        
                        //    DateTime date = Convert.ToDateTime(Lista[i].FechVen_Pord.ToString(), System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat);


                        //if ( date < DateTime.Today)
                        //{
                        //    DataGridViewCellStyle css = new DataGridViewCellStyle();
                        //    css.BackColor = Color.Red;
                        //    dgvproducto.RowsDefaultCellStyle = css;
                        //}
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
                creargrid();
                llenarcomox();
            }
            catch (ApplicationException es)
            {
                MessageBox.Show(es.Message, "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                llenargrid(null);
            }
            catch (ApplicationException es)
            {
                MessageBox.Show(es.Message, "Mensaje",
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
               llenargrid(txtCodigop.Text);
            }
            catch (ApplicationException es)
            {
                MessageBox.Show(es.Message, "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);} 
        
        
        }

        private void txtNombrePro_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                llenargrid(txtNombrePro.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
