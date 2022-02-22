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
    public partial class frmMantenimiento : Form
    {
        Int32 idUsuario;
        public frmMantenimiento(Int32? id_usu)
        {
            InitializeComponent();
            idUsuario = (Int32)id_usu;
        }

        AccEnControles acc = new AccEnControles();

        public void controlb(String pantalla, Boolean nuevo, Boolean editar, Boolean grabar,Boolean eliminar, Boolean cancelar, Boolean salir)
        {
            try
            { 
                if (pantalla == "PRODUCTO")
                {
                    BTNnuevoprod.Enabled = nuevo;
                    BTNeditarprod.Enabled = editar;
                    BTNgrabarprod.Enabled = grabar;
                    BTneliminarprod.Enabled = eliminar;
                    BTNcancelarprod.Enabled = cancelar;
                    BTNsalirprod.Enabled = salir;
                }
              

                else if (pantalla == "PRESENTACION_PROD")
                {
                    BTNnuevopresent.Enabled = nuevo;
                    BTNeditarpresent.Enabled = editar;
                    BTNgrabarpresent.Enabled = grabar;
                    BTNeliminarpresent.Enabled = eliminar;
                    BTNcancelarpresent.Enabled = cancelar;
                    BTNsalirpresent.Enabled = salir;
                }
                else if (pantalla == "PROVEEDOR")
                {
                    BTNnuevoprove.Enabled = nuevo;
                    BTNeditarprove.Enabled = editar;
                    BTNgrabarprove.Enabled = grabar;
                    BTNeliminarprove.Enabled = eliminar;
                    BTNcancelarprove.Enabled = cancelar;
                    BTNsalirprove.Enabled = salir;
                }
                else
                {
                    BTNnuevocat.Enabled = nuevo;
                    BTNeditarcat.Enabled = editar;
                    BTNgrabarcat.Enabled = grabar;
                    BTNeliminarcat.Enabled = eliminar;
                    BTNcancelarcat.Enabled = cancelar;
                    BTNsalircat.Enabled = salir;
                }
                
            }
            catch (Exception) { throw; }
        }

        private void creagrid()
        {
            dgvproducto.Columns.Add("ColumnId", "Id");
            dgvproducto.Columns.Add("ColumnNumero", "#");
            dgvproducto.Columns.Add("ColumnCodigo", "Codigo");
            dgvproducto.Columns.Add("ColumnNombre", "Nombre");
            dgvproducto.Columns.Add("ColumnMarca", "Marca");
            dgvproducto.Columns.Add("ColumnCategoria", "Categoria");
            dgvproducto.Columns.Add("ColumnUnidMed", "Pres. Prod");
            dgvproducto.Columns.Add("ColumnProveedor", "Proveedor");

            dgvproducto.Columns[0].Visible = false;
            dgvproducto.Columns[1].Width = 30;
            dgvproducto.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvproducto.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvproducto.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvproducto.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvproducto.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewCellStyle css = new DataGridViewCellStyle();
            css.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvproducto.ColumnHeadersDefaultCellStyle = css;

            dgvproducto.AllowUserToAddRows = false;
            dgvproducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvproducto.MultiSelect = false;
        }

        private void creargridcat()
        {
            dgvcategoria.Columns.Add("ColumnId", "Id");
            dgvcategoria.Columns.Add("ColumnNumero", "#");
            dgvcategoria.Columns.Add("ColumnCodigo", "Codigo");
            dgvcategoria.Columns.Add("ColumnNombre", "Nombre");
            dgvcategoria.Columns.Add("ColumnDescripcion", "Descripcion");
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
            dgvpresentacionprod.Columns.Add("ColumnId", "Id");
            dgvpresentacionprod.Columns.Add("ColumnNumero", "#");
            dgvpresentacionprod.Columns.Add("ColumnCodigo", "Codigo");
            dgvpresentacionprod.Columns.Add("ColumnDescripcion", "Descripcion");
            dgvpresentacionprod.Columns.Add("ColumnAbreviatura", "Abreviatura");

            dgvpresentacionprod.Columns[0].Visible = false;
            dgvpresentacionprod.Columns[1].Width = 30;
            dgvpresentacionprod.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvpresentacionprod.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvpresentacionprod.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewCellStyle css = new DataGridViewCellStyle();
            css.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvpresentacionprod.ColumnHeadersDefaultCellStyle = css;
            
            dgvpresentacionprod.AllowUserToAddRows = false;
            dgvpresentacionprod.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
          
        }

        private void creargridprovee()
        {
            dgvproveedor.Columns.Add("ColumnId", "Id");
            dgvproveedor.Columns.Add("ColumnNumero", "#");
            dgvproveedor.Columns.Add("ColumnCodigo", "Codigo");
            dgvproveedor.Columns.Add("ColumnRazSocial", "Nombre/Raz.Social");
            dgvproveedor.Columns.Add("ColumnRuc", "RNC");
              
            dgvproveedor.Columns[0].Visible = false;
            dgvproveedor.Columns[1].Width = 30;
            dgvproveedor.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvproveedor.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvproveedor.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewCellStyle css = new DataGridViewCellStyle();
            css.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvproveedor.ColumnHeadersDefaultCellStyle = css;
              
            dgvproveedor.AllowUserToAddRows = false;
            dgvproveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void llenarcombox()
        {
            try
            {
                cbocategoriap.ValueMember = "Id_Cat";
                cbocategoriap.DisplayMember = "Nombre_Cat";
                cbocategoriap.DataSource = IBusinessManagement.Instancia.listarcategoria();

                cbopresentacionprodp.ValueMember = "Id_Umed";
                cbopresentacionprodp.DisplayMember = "Descripcion_Umed";
                cbopresentacionprodp.DataSource = IBusinessManagement.Instancia.listarpresentacion();

                cboproveedorp.ValueMember = "Id_Proveedor";
                cboproveedorp.DisplayMember = "RazSocial_Proveedor";
                cboproveedorp.DataSource = IBusinessManagement.Instancia.ListarProve();
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
                TXTcodigop.Text = prod.Codigo_Prod;
                txtnombrep.Text = prod.Nombre_Prod;
                txtmarcap.Text = prod.Marca_Prod;
                txtpreciocomprap.Text = prod.PrecioCompra_Prod.ToString();
                txtprecioventap.Text = prod.Precio_Prod.ToString();
                txtstockp.Text = prod.Stock_Prod.ToString();
                txtstockpromediop.Text = prod.StockProm_Prod.ToString();
                txtstockminimop.Text = prod.StockMin_Prod.ToString();
                cbocategoriap.SelectedValue = prod.categoria.Id_Cat;
                cbopresentacionprodp.SelectedValue = prod.unidmedida.Id_Umed;
                cboproveedorp.SelectedValue = prod.proveedor.Id_Proveedor;
                dtpFechVen.Text = Convert.ToString(prod.FechVen_Pord.ToString());
                acc.bloqueartxt(this.tcpProducto, false);
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
                acc.limtext(this.tcpProducto);
                acc.bloqueartxt(this.tcpProducto, true);
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
                acc.bloqueartxt(this.tcpProducto, false);
                dtpFechVen.Enabled = false;
               
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
                acc.bloqueartxt(this.tcpProducto, false);
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
                if (String.IsNullOrEmpty(Convert.ToString(cbocategoriap.SelectedValue))) throw new ApplicationException("Debe seleccionar una categoria");
                else if  (String.IsNullOrEmpty(Convert.ToString(cboproveedorp.SelectedValue))) throw new ApplicationException("Debe seleccionar un proveedor");
                else if (String.IsNullOrEmpty(Convert.ToString(cbopresentacionprodp.SelectedValue))) throw new ApplicationException("Debe seleccionar una Presentacion Prod.");

                entProduct prod = new entProduct();
                int tipoedicion = 1;
                if (txtidp.Text != "")
                {
                    tipoedicion = 2;
                    prod.Id_Prod = Convert.ToInt32(txtidp.Text);
                }
                prod.Nombre_Prod = txtnombrep.Text;
                prod.Marca_Prod = txtmarcap.Text;
                if (txtpreciocomprap.Text == "") prod.PrecioCompra_Prod = 0; else prod.PrecioCompra_Prod = Convert.ToDouble(txtpreciocomprap.Text);
                if (txtprecioventap.Text == "") prod.Precio_Prod = 0; else prod.Precio_Prod = Convert.ToDouble(txtprecioventap.Text);
                if (txtstockp.Text == "") prod.Stock_Prod = 0; else prod.Stock_Prod = Convert.ToInt32(txtstockp.Text);
                if (txtstockpromediop.Text == "") prod.StockProm_Prod = 0; else prod.StockProm_Prod = Convert.ToInt32(txtstockpromediop.Text);
                if (txtstockminimop.Text == "") prod.StockMin_Prod = 0; else prod.StockMin_Prod = Convert.ToInt32(txtstockminimop.Text);
                prod.FechVen_Pord = dtpFechVen.Value.ToString("yyyy/MM/dd");

                entCategory cat = new entCategory();
                cat.Id_Cat = Convert.ToInt32(cbocategoriap.SelectedValue);
                prod.categoria = cat;
                entUnidadMedida pres = new entUnidadMedida();
                pres.Id_Umed = Convert.ToInt32(cbopresentacionprodp.SelectedValue);
                prod.unidmedida = pres;
                entSupplier prove = new entSupplier();
                prove.Id_Proveedor = Convert.ToInt32(cboproveedorp.SelectedValue);
                prod.proveedor = prove;

                prod.UsuarioCreacion_Prod = idUsuario;
                prod.UsuarioUpdate_Prod = idUsuario;
                int i = IBusinessManagement.Instancia.mantenimeintoProd(prod, tipoedicion);
                MessageBox.Show("Registro guardado correctamente!", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                controlb("PRODUCTO", true, false, false, false, false, true);
                acc.bloqueartxt(this.tcpProducto, false);
             cargarproducto();
             dtpFechVen.Enabled = false;

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
             
                acc.bloqueartxt(this.tcpProducto, true);
                controlb("PRODUCTO", false, false, true, false, true, false);
                dtpFechVen.Enabled = true;

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
                BTNcargarcategoria.Visible = false;
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
                dgvproducto.Rows.Clear();
                List<entProduct>  Lista = IBusinessManagement.Instancia.ListarProd();
           
                for (int i = 0; i < Lista.Count(); i++)
                {
                    n++;
                    String[] fila = new String[] { Lista[i].Id_Prod.ToString(), n.ToString(), Lista[i].Codigo_Prod, Lista[i].Nombre_Prod, Lista[i].Marca_Prod,
                    Lista[i].categoria.Nombre_Cat, Lista[i].unidmedida.Descripcion_Umed, Lista[i].proveedor.RazSocial_Proveedor, Lista[i].FechVen_Pord.ToString()};
                    dgvproducto.Rows.Add(fila);
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

                acc.bloqueartxt(this.tcpProducto, false);
                acc.bloqueartxt(this.tbcCategoria, false);
                acc.bloqueartxt(this.tbcPresentaProducto, false);
                acc.bloqueartxt(this.tbcproveedor, false);

                creagrid();
              creargridprovee();
               creargridpresentacion();
               creargridcat();
              llenarcombox();
              cargarproducto();
              dtpFechVen.Enabled = false;
              lblvenprod.Visible = false;
               
              

                
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void  cargargridprove()
        {
            try 
            {
                int n = 0;
                dgvproveedor.Rows.Clear();
                List<entSupplier> p = null;
                p = IBusinessManagement.Instancia.ListarProve();
                for (int i = 0; i < p.Count; i++)
                {
                    n++;
                    String[] fila = new String[] {
                        p[i].Id_Proveedor.ToString(), n.ToString(),  p[i].Cod_Proveedor,  p[i].RazSocial_Proveedor,
                         p[i].Rnc_Proveedor
                        
                    };
                dgvproveedor.Rows.Add(fila);

                }

            }
            catch (Exception) { throw; }
        }

        private void BTNcargarprove_Click(object sender, EventArgs e)
        {
            try 
            {
                cargargridprove();
                BTNcargarprove.Visible = false;
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
                acc.limtext(this.tbcproveedor);
                acc.bloqueartxt(this.tbcproveedor, true);
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
              
                acc.bloqueartxt(this.tbcproveedor, true);
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
                if (txtidprove.Text != "") { tipoedicion = 2; prove.Id_Proveedor = Convert.ToInt32(txtidprove.Text); }
                prove.RazSocial_Proveedor = txtrazsocialprove.Text;
                prove.Rnc_Proveedor = txtrncprove.Text;
                prove.Direccion_Proveedor = txtdireccionprove.Text;
                prove.Telefono_Proveedor = txttelefonoprove.Text;
                prove.Celular_Proveedor = txtcelularprove.Text;
                prove.Correo_Proveedor = txtcorreoprove.Text;
                int i = IBusinessManagement.Instancia.MantenimientoProvee(prove, tipoedicion);
                MessageBox.Show("Registro Guardado Correctamente!", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                controlb("PROVEEDOR", true, false, false, false, false, true);
                     acc.bloqueartxt(this.tbcproveedor, false);
                     cargargridprove();
                     llenarcombox();
                     BTNcargarprove.Visible = true;

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
                prove.Id_Proveedor = Convert.ToInt32(txtidprove.Text);
                DialogResult r = MessageBox.Show("¿Esta seguro de que quiere elimimar el registro?", "Mesanje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int i = IBusinessManagement.Instancia.MantenimientoProvee(prove, 3);
                    MessageBox.Show("Registro eliminado", "Mensaje", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                controlb("PRESENTACION_PROD", true, false, false, false, false, true);
                acc.bloqueartxt(this.tbcPresentaProducto, false);
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
                acc.bloqueartxt(this.tbcproveedor, false);
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
                int idprove = Convert.ToInt32(dgvproveedor.CurrentRow.Cells[0].Value);
                entSupplier prove = null;
                prove = IBusinessManagement.Instancia.buscarproveedor(idprove);
                txtidprove.Text = prove.Id_Proveedor.ToString();
                TXTcodigopr.Text = prove.Cod_Proveedor;
                txtrazsocialprove.Text = prove.RazSocial_Proveedor;
                txtrncprove.Text = prove.Rnc_Proveedor;
                txtdireccionprove.Text = prove.Direccion_Proveedor;
                txttelefonoprove.Text = prove.Telefono_Proveedor;
                txtcelularprove.Text = prove.Celular_Proveedor;
                txtcorreoprove.Text = prove.Correo_Proveedor;
                controlb("PROVEEDOR", true, true, false, true, false, true);
                acc.bloqueartxt(this.tbcproveedor, false);
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
                dgvpresentacionprod.Rows.Clear();
                List<entUnidadMedida> pres = null;
                pres = IBusinessManagement.Instancia.listarpresentacion();
                for (int i = 0; i< pres.Count; i++)
                {
                    n++;
                    String[] fila = new string[] {
                        pres[i].Id_Umed.ToString(), n.ToString(), pres[i].Codigo_Umed, pres[i].Descripcion_Umed, pres[i].Abreviatura_Umed };
                        dgvpresentacionprod.Rows.Add(fila);
                    
                }
        }
       catch (Exception) { throw; } 
        }
        
        
        
    
        private void BTNcargarpresent_Click(object sender, EventArgs e)
        {
            try
            {
                cargarpresentaciones();
                BTNcargarpresent.Visible = false;
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
                acc.limtext(this.tbcPresentaProducto);
                acc.bloqueartxt(this.tbcPresentaProducto, true);
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
              
                acc.bloqueartxt(this.tbcPresentaProducto, true);
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
                pres.Descripcion_Umed = txtdescripcionpresent.Text;
                pres.Abreviatura_Umed = txtabreviaturapresent.Text;
                int i = IBusinessManagement.Instancia.MantenimientoPresentacion(pres, tipoedicion);
                MessageBox.Show("Registro guardado correctamente","Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Information);
                acc.bloqueartxt(this.tbcPresentaProducto, false);
                controlb("PRESENTACION_PROD", true, false, true, false, false, false);
                llenarcombox();
                BTNcargarpresent.Visible = true;
                
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
                acc.bloqueartxt(this.tbcPresentaProducto, false);
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
                acc.bloqueartxt(this.tbcPresentaProducto, false);
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
                int idpres = Convert.ToInt32(dgvpresentacionprod.CurrentRow.Cells[0].Value);
                entUnidadMedida pres = null;
                pres = IBusinessManagement.Instancia.buscarpresentacion(idpres);
                txtidpresent.Text = pres.Id_Umed.ToString();
                txtcodigopresent.Text = pres.Codigo_Umed;
                txtdescripcionpresent.Text = pres.Descripcion_Umed;
                txtabreviaturapresent.Text = pres.Abreviatura_Umed;
                controlb("PRESENTACION_PROD", true, true, false, true, false, true);
                acc.bloqueartxt(this.tbcPresentaProducto, false);
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
                acc.limtext(this.tbcCategoria);
                acc.bloqueartxt(this.tbcCategoria, true);
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

                acc.bloqueartxt(this.tbcCategoria, true);
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
                if (txtidcat.Text != "")
                {
                    tipoedicion = 2; c.Id_Cat = Convert.ToInt32(txtidcat.Text);
                }
                c.Nombre_Cat = txtnombrecat.Text;
                c.Descripcion_Cat = txtdescripcion.Text;
                c.UsuarioCreacion_Cat = idUsuario;
                c.UsuarioUpdate_Cat = idUsuario;
              
                int i = IBusinessManagement.Instancia.mantenimientocategoria(c, tipoedicion);
                MessageBox.Show("Registro guardado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BTNcargarpresent.Visible = true;
                acc.bloqueartxt(this.tbcCategoria, false);
                controlb("CATEGORIA", true, false, false, false, false, true);
                llenarcombox();
                cargargridcat();
                BTNcargarpresent.Visible = true;

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
                c.Id_Cat = Convert.ToInt32(txtidcat.Text);
                DialogResult r = MessageBox.Show("¿Esta seguro de que quiere eliminar el registro", "Mensaje", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int i = IBusinessManagement.Instancia.mantenimientocategoria(c, 3);
                    MessageBox.Show("Registro eliminado existosamente!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


                controlb("CATEGORIA", true, false, false, false, false, true);
                llenarcombox();
                acc.bloqueartxt(this.tbcCategoria, false);
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
                acc.bloqueartxt(this.tbcCategoria, false);
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
                txtidcat.Text = c.Id_Cat.ToString();
                txtcodigocat.Text = c.Codigo_Cat;
                txtnombrecat.Text = c.Nombre_Cat;
                txtdescripcion.Text = c.Descripcion_Cat;
                controlb("CATEGORIA", true, true, false, true, false, true);
                acc.bloqueartxt(this.tbcCategoria, false);
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
                int idprod = Convert.ToInt32(dgvproducto.CurrentRow.Cells[0].Value);
                mostrarfilaselect(idprod);
                
                if (dtpFechVen.Value < DateTime.Today )
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
                frmBuscarProd frmB = new frmBuscarProd(this.idUsuario);
                frmB.ShowDialog();
                int dop = localdatabase.Instancia.returnidprod(0, 0);
                for (int i = 0; i < dgvproducto.RowCount; i++)
                {
                    if (Convert.ToInt32(dgvproducto.Rows[1].Cells[0].Value) == dop)
                    {
                        dgvproducto.Rows[i].Selected = true;
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
    }
}
