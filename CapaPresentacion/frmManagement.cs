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
    public partial class frmManagement : Form
    {
        Int32 idUsuario;
        public frmManagement(Int32? id_usu)
        {
            InitializeComponent();
            idUsuario = (Int32)id_usu;
        }

        controlsStates acc = new controlsStates();

        public void controlb(String pantalla, Boolean nuevo, Boolean editar, Boolean grabar,Boolean eliminar, Boolean cancelar, Boolean salir)
        {
            try
            { 
                if (pantalla == "PRODUCTO")
                {
                    BTNnewp.Enabled = nuevo;
                    BTNeditp.Enabled = editar;
                    BTNsavep.Enabled = grabar;
                    BTNdeletep.Enabled = eliminar;
                    BTNcancelp.Enabled = cancelar;
                    BTNexitp.Enabled = salir;
                }
              

                else if (pantalla == "PRESENTACION_PROD")
                {
                    BTNnewpresent.Enabled = nuevo;
                    BTNeditpresent.Enabled = editar;
                    BTNsavepresent.Enabled = grabar;
                    BTNdeletepresent.Enabled = eliminar;
                    BTNcencelpresent.Enabled = cancelar;
                    BTNexitpresent.Enabled = salir;
                }
                else if (pantalla == "PROVEEDOR")
                {
                    BTNnews.Enabled = nuevo;
                    BTNedits.Enabled = editar;
                    BTNsaves.Enabled = grabar;
                    BTNdeletes.Enabled = eliminar;
                    BTNcancels.Enabled = cancelar;
                    BTNexits.Enabled = salir;
                }
                else
                {
                    BTNnewcategories.Enabled = nuevo;
                    BTNeditcategories.Enabled = editar;
                    BTNsavecategories.Enabled = grabar;
                    BTNdeletecategories.Enabled = eliminar;
                    BTNcancelcategories.Enabled = cancelar;
                    BTNexitcategories.Enabled = salir;
                }
                
            }
            catch (Exception) { throw; }
        }

        private void creagrid()
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

        private void creargridcat()
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

        private void creargridpresentacion()
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

        private void creargridprovee()
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

        private void llenarcombox()
        {
            try
            {
                cbocategories.ValueMember = "Id_Cat";
                cbocategories.DisplayMember = "Nombre_Cat";
                cbocategories.DataSource = IBusinessManagement.Instancia.listarcategoria();

                cboprodpresent.ValueMember = "Id_Umed";
                cboprodpresent.DisplayMember = "Descripcion_Umed";
                cboprodpresent.DataSource = IBusinessManagement.Instancia.listarpresentacion();

                cbosupplier.ValueMember = "Id_Proveedor";
                cbosupplier.DisplayMember = "RazSocial_Proveedor";
                cbosupplier.DataSource = IBusinessManagement.Instancia.ListarProve();
            }
            catch (Exception) { throw; }
        }

        private void mostrarfilaselect (int idprod)
        {
            try
            {
                entProduct prod = null;
                prod = IBusinessManagement.Instancia.BuscarProd(idprod);
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
                acc.bloqueartxt(this.tcpProducts, false);
                controlb("PRODUCTO", true, true, false, true, false, true);

            }
            catch (Exception) { throw; }
        }
            


        

        private void tcpProducto_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void BTNnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                acc.limtext(this.tcpProducts);
                acc.bloqueartxt(this.tcpProducts, true);
                controlb("PRODUCTO", false, false, true, false, true, false);

            }
            catch (Exception ex ) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Esta seguro de que quiere salir", "Saliendo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BTNcancelar_Click(object sender, EventArgs e)
        {
            try
            {
                controlb("PRODUCTO", true, false, false, false, false, true);
                acc.bloqueartxt(this.tcpProducts, false);
                dtpduedate.Enabled = false;
               
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 

        }

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
                DialogResult r = MessageBox.Show("¿Esta seguro de que quiere eliminar el registro?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int i = IBusinessManagement.Instancia.mantenimeintoProd(p, 3);
                    MessageBox.Show("Regsitro eliminado exitosamente", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                controlb("PRODUCTO", true, false, false, false, false, true);
                acc.bloqueartxt(this.tcpProducts, false);
                cargarproducto();

            }
            catch (ApplicationException es)
            {
                MessageBox.Show(es.Message, "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        }

        private void BTNgrabar_Click(object sender, EventArgs e)
        {
            try 
            {
                if (String.IsNullOrEmpty(Convert.ToString(cbocategories.SelectedValue))) throw new ApplicationException("You must select a category");
                else if  (String.IsNullOrEmpty(Convert.ToString(cbosupplier.SelectedValue))) throw new ApplicationException("You must select a provider");
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
                } else if (rb0.Checked)
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

                prod.UsuarioCreacion_Prod = idUsuario;
                prod.UsuarioUpdate_Prod = idUsuario;
                int i = IBusinessManagement.Instancia.mantenimeintoProd(prod, tipoedicion);
                MessageBox.Show("Record saved successfully!", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                controlb("PRODUCTO", true, false, false, false, false, true);
                acc.bloqueartxt(this.tcpProducts, false);
             cargarproducto();
             dtpduedate.Enabled = false;

            }
           catch (Exception ex ) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNeditar_Click(object sender, EventArgs e)
        {
            try
            {
             
                acc.bloqueartxt(this.tcpProducts, true);
                controlb("PRODUCTO", false, false, true, false, true, false);
                dtpduedate.Enabled = true;

            }
            catch (Exception ex ) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTNcargarcategoria_Click(object sender, EventArgs e)
        {
            try
            {
                cargargridcat();
                BTNloadcategories.Visible = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }
        private void cargargridcat()
        {
            dgvcategoria.Rows.Clear();
            List<entCategory> Lista = null;
            Lista = IBusinessManagement.Instancia.listarcategoria();
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
        private void cargarproducto()
        {
            try
            {
                int n = 0;
                dgvproduct.Rows.Clear();
                List<entProduct>  Lista = IBusinessManagement.Instancia.ListarProd();
           
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

        private void frmMantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                controlb("PRODUCTO", true, false, false, false, false, true);
                controlb("CATEGORIA", true, false, false, false, false, true);
                controlb("PRESENTACION_PROD", true, false, false, false, false, true);
                controlb("PROVEEDOR", true, false, false, false, false, true);

                acc.bloqueartxt(this.tcpProducts, false);
                acc.bloqueartxt(this.tbcCategories, false);
                acc.bloqueartxt(this.tbcProdPresentation, false);
                acc.bloqueartxt(this.tbcSuppliers, false);

                creagrid();
              creargridprovee();
               creargridpresentacion();
               creargridcat();
              llenarcombox();
              cargarproducto();
              dtpduedate.Enabled = false;
              lblvenprod.Visible = false;
               
              

                
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void  cargargridprove()
        {
            try 
            {
                int n = 0;
                dgvsupplier.Rows.Clear();
                List<entSupplier> p = null;
                p = IBusinessManagement.Instancia.ListarProve();
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

        private void BTNcargarprove_Click(object sender, EventArgs e)
        {
            try 
            {
                cargargridprove();
                BTNloads.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNnuevoprove_Click(object sender, EventArgs e)
        {
            try
            {
                acc.limtext(this.tbcSuppliers);
                acc.bloqueartxt(this.tbcSuppliers, true);
                controlb("PROVEEDOR", false, false, true, false, true, false);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNeditarprove_Click(object sender, EventArgs e)
        {
            try
            {
              
                acc.bloqueartxt(this.tbcSuppliers, true);
                controlb("PROVEEDOR", false, false, true, false, true, false);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNguardarprove_Click(object sender, EventArgs e)
        {

        }

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
                int i = IBusinessManagement.Instancia.MantenimientoProvee(prove, tipoedicion);
                MessageBox.Show("Registro Guardado Correctamente!", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                controlb("PROVEEDOR", true, false, false, false, false, true);
                     acc.bloqueartxt(this.tbcSuppliers, false);
                     cargargridprove();
                     llenarcombox();
                     BTNloads.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNeliminarprove_Click(object sender, EventArgs e)
        {
            try
            {
                entSupplier prove = new entSupplier();
                prove.Id_Proveedor = Convert.ToInt32(txtids.Text);
                DialogResult r = MessageBox.Show("¿Esta seguro de que quiere elimimar el registro?", "Mesanje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int i = IBusinessManagement.Instancia.MantenimientoProvee(prove, 3);
                    MessageBox.Show("Registro eliminado", "Mensaje", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                controlb("PRESENTACION_PROD", true, false, false, false, false, true);
                acc.bloqueartxt(this.tbcProdPresentation, false);
                cargargridprove();
                llenarcombox();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNcancelarprove_Click(object sender, EventArgs e)
        {
            try
            {
                controlb("PROVEEDOR", true, true, false, true, false, true);
                acc.bloqueartxt(this.tbcSuppliers, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNsalirprove_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Esta seguro de que quiere salir", "Saliendo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvproveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvproveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idprove = Convert.ToInt32(dgvsupplier.CurrentRow.Cells[0].Value);
                entSupplier prove = null;
                prove = IBusinessManagement.Instancia.buscarproveedor(idprove);
                txtids.Text = prove.Id_Proveedor.ToString();
                TXTcodes.Text = prove.Cod_Proveedor;
                txtnamebussinesnames.Text = prove.RazSocial_Proveedor;
                txtrncs.Text = prove.Rnc_Proveedor;
                txtaddresss.Text = prove.Direccion_Proveedor;
                txtphones.Text = prove.Telefono_Proveedor;
                txtcellphones.Text = prove.Celular_Proveedor;
                txtemails.Text = prove.Correo_Proveedor;
                controlb("PROVEEDOR", true, true, false, true, false, true);
                acc.bloqueartxt(this.tbcSuppliers, false);
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

        private void cargarpresentaciones()
        {
            try 
            {
                int n = 0;
                dgvpresent.Rows.Clear();
                List<entUnidadMedida> pres = null;
                pres = IBusinessManagement.Instancia.listarpresentacion();
                for (int i = 0; i< pres.Count; i++)
                {
                    n++;
                    String[] fila = new string[] {
                        pres[i].Id_Umed.ToString(), n.ToString(), pres[i].Codigo_Umed, pres[i].Descripcion_Umed, pres[i].Abreviatura_Umed };
                        dgvpresent.Rows.Add(fila);
                    
                }
        }
       catch (Exception) { throw; } 
        }
        
        
        
    
        private void BTNcargarpresent_Click(object sender, EventArgs e)
        {
            try
            {
                cargarpresentaciones();
                BTNloadpresent.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BTNnuevopresent_Click(object sender, EventArgs e)
        {
            try
            {
                acc.limtext(this.tbcProdPresentation);
                acc.bloqueartxt(this.tbcProdPresentation, true);
                controlb("PRESENTACION_PROD", false, false, true, false, true, false);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNeditarpresent_Click(object sender, EventArgs e)
        {
            try
            {
              
                acc.bloqueartxt(this.tbcProdPresentation, true);
                controlb("PRESENTACION_PROD", false, false, true, false, true, false);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNgrabarpresent_Click(object sender, EventArgs e)
        {
            try
            {
                entUnidadMedida pres = new entUnidadMedida();
                int tipoedicion = 1;
                if (txtidpresent.Text != "")
                {
                    tipoedicion = 2;  pres.Id_Umed = Convert.ToInt32(txtidpresent.Text);
                }
                pres.Descripcion_Umed = txtdescriptionpresent.Text;
                pres.Abreviatura_Umed = txtabbrepresent.Text;
                int i = IBusinessManagement.Instancia.MantenimientoPresentacion(pres, tipoedicion);
                MessageBox.Show("Registro guardado correctamente","Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Information);
                acc.bloqueartxt(this.tbcProdPresentation, false);
                controlb("PRESENTACION_PROD", true, false, true, false, false, false);
                llenarcombox();
                BTNloadpresent.Visible = true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void BTNeliminarpresent_Click(object sender, EventArgs e)
        {
             try
            {
                entUnidadMedida pres = new entUnidadMedida();
                pres.Id_Umed = Convert.ToInt32(txtidpresent.Text);
                DialogResult r = MessageBox.Show("¿Esta seguro de que quiere eliminar el registro","Mensaje", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                 if (r == DialogResult.Yes)
                 {
                     int i = IBusinessManagement.Instancia.MantenimientoPresentacion(pres, 3);
                     MessageBox.Show("Registro eliminado existosamente!","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                 }


                 controlb("PRESENTACION_PROD", true, false, false, false, false, true);
                llenarcombox();
                acc.bloqueartxt(this.tbcProdPresentation, false);
                 cargarpresentaciones();
                   
                 
     
            
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNcancelarpresent_Click(object sender, EventArgs e)
        {
            try
            {
                controlb("PRESENTACION_PROD", true, true, false, true, false, true);
                acc.bloqueartxt(this.tbcProdPresentation, false);
            }
          catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNsalirpresent_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Esta segruo de que quiere salir?","Saliendo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (r== DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvpresentacionprod_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idpres = Convert.ToInt32(dgvpresent.CurrentRow.Cells[0].Value);
                entUnidadMedida pres = null;
                pres = IBusinessManagement.Instancia.buscarpresentacion(idpres);
                txtidpresent.Text = pres.Id_Umed.ToString();
                txtcodepresent.Text = pres.Codigo_Umed;
                txtdescriptionpresent.Text = pres.Descripcion_Umed;
                txtabbrepresent.Text = pres.Abreviatura_Umed;
                controlb("PRESENTACION_PROD", true, true, false, true, false, true);
                acc.bloqueartxt(this.tbcProdPresentation, false);
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

        private void BTNnuevocat_Click(object sender, EventArgs e)
        {
            try
            {
                acc.limtext(this.tbcCategories);
                acc.bloqueartxt(this.tbcCategories, true);
                controlb("CATEGORIA", false, false, true, false, true, false);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNeditarcat_Click(object sender, EventArgs e)
        {
            try
            {

                acc.bloqueartxt(this.tbcCategories, true);
                controlb("CATEGORIA", false, false, true, false, true, false);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
                c.UsuarioCreacion_Cat = idUsuario;
                c.UsuarioUpdate_Cat = idUsuario;
              
                int i = IBusinessManagement.Instancia.mantenimientocategoria(c, tipoedicion);
                MessageBox.Show("Registro guardado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BTNloadpresent.Visible = true;
                acc.bloqueartxt(this.tbcCategories, false);
                controlb("CATEGORIA", true, false, false, false, false, true);
                llenarcombox();
                cargargridcat();
                BTNloadpresent.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNeliminarcat_Click(object sender, EventArgs e)
        {
            try
            {
                entCategory c = new entCategory();
                c.Id_Cat = Convert.ToInt32(txtidcategories.Text);
                DialogResult r = MessageBox.Show("¿Esta seguro de que quiere eliminar el registro", "Mensaje", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int i = IBusinessManagement.Instancia.mantenimientocategoria(c, 3);
                    MessageBox.Show("Registro eliminado existosamente!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


                controlb("CATEGORIA", true, false, false, false, false, true);
                llenarcombox();
                acc.bloqueartxt(this.tbcCategories, false);
                cargargridcat();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNcancelarcat_Click(object sender, EventArgs e)
        {
            try
            {
                controlb("CATEGORIA", true, true, false, true, false, true);
                acc.bloqueartxt(this.tbcCategories, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNsalircat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Esta seguro de que quiere salir?","Mensaje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r== DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvcategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idcat = Convert.ToInt32(dgvcategoria.CurrentRow.Cells[0].Value);
                entCategory c   = null;
                c = IBusinessManagement.Instancia.buscarcategoria(idcat);
                txtidcategories.Text = c.Id_Cat.ToString();
                txtcodecategories.Text = c.Codigo_Cat;
                txtnamecategories.Text = c.Nombre_Cat;
                txtdescriptioncategories.Text = c.Descripcion_Cat;
                controlb("CATEGORIA", true, true, false, true, false, true);
                acc.bloqueartxt(this.tbcCategories, false);
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

        private void button2_Click(object sender, EventArgs e)
        {
            cargarproducto();
        }

        private void dgvproducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idprod = Convert.ToInt32(dgvproduct.CurrentRow.Cells[0].Value);
                mostrarfilaselect(idprod);
                
                if (dtpduedate.Value < DateTime.Today )
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

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                frmSearchProduct frmB = new frmSearchProduct(this.idUsuario);
                frmB.ShowDialog();
                int dop = localdatabase.Instancia.returnidprod(0, 0);
                for (int i = 0; i < dgvproduct.RowCount; i++)
                {
                    if (Convert.ToInt32(dgvproduct.Rows[1].Cells[0].Value) == dop)
                    {
                        dgvproduct.Rows[i].Selected = true;
                        mostrarfilaselect(dop);
                        localdatabase.Instancia.returnidprod(1, 0);
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

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtnamep_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtnamebussinesnames_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtbrandp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtdescriptionpresent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtabbrepresent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtnamecategories_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtdescriptioncategories_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
