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
    public partial class frmBuscarProd : Form
    {
        int idusu = 0;
        public frmBuscarProd(int? idusua)
        {
            InitializeComponent();
            this.idusu = (int)idusua;
        }

        private void creargrid()
        {
            dgvproducto.Columns.Add("ColumnId", "Id");
            dgvproducto.Columns.Add("ColumnNumero", "#");
            dgvproducto.Columns.Add("ColumnCodigo", "Codigo");
            dgvproducto.Columns.Add("ColumnNombre", "Nombre");
            dgvproducto.Columns.Add("ColumnMarca", "Marca");
            dgvproducto.Columns.Add("ColumnCategoria", "Categoria");
            dgvproducto.Columns.Add("ColumnUnidMed", "Pres. Prod");
            dgvproducto.Columns.Add("ColumnPrecio", "Precio");
            dgvproducto.Columns.Add("ColumnFechVencimiento", "Fech. Ven");
            dgvproducto.Columns.Add("ColumnStock", "Stock");

            dgvproducto.Columns[0].Visible = false;
            dgvproducto.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvproducto.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvproducto.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvproducto.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvproducto.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvproducto.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            
            dgvproducto.Columns[8].Width = 70;

            DataGridViewCellStyle css = new DataGridViewCellStyle();
            css.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvproducto.ColumnHeadersDefaultCellStyle = css;
               
            dgvproducto.AllowUserToAddRows = false;
            dgvproducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
             try
            {
                tipbusqueda = 1;
                dgvproducto.Rows.Clear();
                BTNvender.Enabled = false;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ; }

            
        }

        private void rbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                tipbusqueda = 2;
                dgvproducto.Rows.Clear();
                BTNvender.Enabled = false;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ; }

        }

        private void BTNvender_Click(object sender, EventArgs e)
        {
            int inten = localdatabase.Instancia.Returnintento(1, 1);
            int invoca = localdatabase.Instancia.invocar(0, 0);
            
            if (invoca == 1)
            {
                int idprod = Convert.ToInt32(dgvproducto.CurrentRow.Cells[0].Value);
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
                
                BTNvender.Enabled = false;
                int n = 0;
                List<entProduct> lista = IBusinessManagement.Instancia.BuscarproAvanzada(tipbusqueda, "");
                dgvproducto.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    n++;
                    String[] fila = new string[] {
                                lista[i].Id_Prod.ToString(), n.ToString(), lista[i].Codigo_Prod, lista[i].Nombre_Prod, lista[i].Marca_Prod,
                                lista[i].categoria.Nombre_Cat, lista[i].unidmedida.Descripcion_Umed, lista[i].Precio_Prod.ToString(), lista[i].FechVen_Pord.ToString(), 
                                lista[i].Stock_Prod.ToString()
                            };
                    dgvproducto.Rows.Add(fila);

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ; }

            
        }

        private void frmBuscarProd_Load(object sender, EventArgs e)
        {
            try 
            {
                creargrid();
                rbNombre.Checked = true; tipbusqueda = 1;
                BTNvender.Enabled = false;
                BTNmantenimiento.Enabled = false;
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
                    String valentrada = txtBuscarProd.Text;
                    int n = 0;
                    List<entProduct> lista = IBusinessManagement.Instancia.BuscarproAvanzada(tipbusqueda, valentrada);
                    dgvproducto.Rows.Clear();
                    for (int i = 0; i < lista.Count; i++)
                    {
                        n++;
                        String[] fila = new string[] {
                                lista[i].Id_Prod.ToString(), n.ToString(), lista[i].Codigo_Prod, lista[i].Nombre_Prod, lista[i].Marca_Prod,
                                lista[i].categoria.Nombre_Cat, lista[i].unidmedida.Descripcion_Umed, lista[i].Precio_Prod.ToString(), lista[i].FechVen_Pord.ToString(),
                                lista[i].Stock_Prod.ToString()
                            };
                        dgvproducto.Rows.Add(fila);
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
                dgvproducto.Rows.Clear();
                BTNvender.Enabled = false;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ; }


        }

        private void dgvproducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BTNvender.Enabled = true;
            BTNmantenimiento.Enabled = true;
        }

        private void BTNmantenimiento_Click(object sender, EventArgs e)
        {
            try
            {
                int idprod = Convert.ToInt32(dgvproducto.CurrentRow.Cells[0].Value);
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
