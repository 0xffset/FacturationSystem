using CapaAccesoDatos;
using CapaNegocio;
using Entidades;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace CapaPresentacion
{

    public partial class frmPrincipal : Form
    {
        entUser u = new entUser();
        SendReports SendReports = new SendReports();
     
        public frmPrincipal(entUser usu)
        {
            InitializeComponent();
            u = usu;
        }

        private void RestrincionUsuario()
        {
            if (u.access_level.Numero_NivelAcc == 1)
            {
                efecturarToolStripMenuItem.Enabled = false;
                
            }

            if (u.access_level.Numero_NivelAcc == 2)
            {
                MSIseguridad.Enabled = false;
                MSIcliente.Enabled = true;
                btnCustomers.Enabled = true;
                MSIproducts.Enabled = false;
                MSIsalir.Enabled = true;
                MSIventa.Enabled = true;
                MSIQueries.Enabled = false;
                MSIreportes.Enabled = false;
                groupBox1.Visible = false;
                MSImatenimientos.Enabled = false;
                btnProducts.Enabled = false;
                btnSales.Enabled = false;
                btnUsers.Enabled = false;
                machineLearningToolStripMenuItem.Enabled = false;


            }
        }
        private void MSILogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void MSILogIn_Click(object sender, EventArgs e)
        { 
            
        }
        public async Task set()
        {
            await Task.Run(async () =>
            {
                while (true)
                {
                    
                    await Task.Delay(1000);

                }

            });
           
            }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            RestrincionUsuario();
            try 
            { 
                //buscar formularios abiertos
                Form frmlogin = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmLogin);
                //si exite una instancia en frmlogin visible FALSE
                if (frmlogin != null)
                {
                    frmlogin.Visible = false;
                }
                LBLusuario.Text = "Welcome: " + u.User_Name + " with access level:  " + u.access_level.Numero_NivelAcc;
                
            }
            catch (ArgumentNullException ne) 
            {
                MessageBox.Show(ne.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception nx)
            {
                MessageBox.Show(nx.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try 
            {
                frmUser frmusuario = new frmUser(u.User_Id);
              //  frmusuario.MdiParent = frmusuario;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmUser)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                        
                }
                frmusuario.Show();
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmMantenimiento frmmante = new frmMantenimiento(u.User_Id);
                //frmmante.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmMantenimiento)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmmante.Show();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmIndicaProducto frmpo = new frmIndicaProducto();
               // frmpo.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmIndicaProducto)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmpo.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void incicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MSIsalir_Click(object sender, EventArgs e)
        {
            DialogResult anwer = new DialogResult();
            anwer = MessageBox.Show("¿Está seguro de qué quiere salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (anwer == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void MSIcliente_Click(object sender, EventArgs e)
        {
            try 
            {
                frmCustomer frmc = new frmCustomer(u.User_Id);
               // frmc.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmCustomer)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmc.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reporteGenerarDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void MSIventa_Click(object sender, EventArgs e)
        {
            try
            {
                frmFacturacion frmFac = new frmFacturacion(u.User_Id);
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmFacturacion)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmFac.Show();
            }
            catch (Exception) { throw; }
        }

        private void MSIventas_Click(object sender, EventArgs e)
        {
            try 
            {
                frmConsultarVentas frmVenta = new frmConsultarVentas();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmConsultarVentas)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmVenta.Show();
            }
            catch (Exception) { throw;}
        }

        private void MachineLearningToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RegresionLinearToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = IBusinessSale.Instancia.numVenta();
            lblVentas.Text = i.ToString();

            int a = IBusinessCustomer.Instancia.numClientes();
            lblclientes.Text = a.ToString();
           

            int p = IBusinessManagement.Instancia.numProductos();
            lblproductos.Text = p.ToString();
        }

        private void reporteGenerarDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            SqlConnection cn = new SqlConnection("Data Source=A19A74354\\rolEYder;Initial Catalog=BDsistemaROLEY;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();
            string sqlQuery = "select Codigo_Venta, FechaVenta, Estado_Venta from Venta";
            int i = 0;
            int ypoint = 0;
            int ylintes = 100;

            string CodigoVenta;
            string FechaVenta;
            string EstadoVenta;
            cn.Open();
            cmd = new SqlCommand(sqlQuery, cn);
            sqlDataAdapter.SelectCommand = cmd;
            sqlDataAdapter.Fill(dataSet);
            cn.Close();

            PdfDocument pdf = new PdfDocument();
            pdf.Info.Title = "Reporte Generar sobre las ventas";
            PdfPage pdfpage = pdf.AddPage();
            XGraphics graphics = XGraphics.FromPdfPage(pdfpage);
            XFont font = new XFont("Arial", 14, XFontStyle.Bold);
            
            ypoint = ypoint + 100;

            graphics.DrawString("Codigo de venta", font, XBrushes.Black, new XRect(20, 70, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
            graphics.DrawString("Fecha Venta", font, XBrushes.Black, new XRect(190, 70, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
            graphics.DrawString("Estado Venta", font, XBrushes.Black, new XRect(400, 70, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
            for (i = 0; i < dataSet.Tables[0].Rows.Count - 1; i++)
            {
                CodigoVenta = dataSet.Tables[0].Rows[i].ItemArray[0].ToString();
                FechaVenta = dataSet.Tables[0].Rows[i].ItemArray[1].ToString();
                EstadoVenta = dataSet.Tables[0].Rows[i].ItemArray[2].ToString();

                graphics.DrawString(CodigoVenta, font, XBrushes.Black, new XRect(40, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                graphics.DrawString("------------------------------------------------------------------------------------------------------------------------", font, XBrushes.Black, new XRect(40, ylintes, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                graphics.DrawString(FechaVenta, font, XBrushes.Black, new XRect(190, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                graphics.DrawString(EstadoVenta, font, XBrushes.Black, new XRect(400, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);

                ypoint = ypoint + 20;
                ylintes = ylintes +20 ;


            }

            string pdfilename = "report.pdf";
            pdf.Save(pdfilename);
            MessageBox.Show("Reporte creado", "Mensaje", MessageBoxButtons.OK);




            SendReports.sendReports_Attachment("roleyder02@gmail.com", "zoekendallwalsh@gmail.com");






        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void reporteDeVentasPorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportVentasXClientes fmt = new reportVentasXClientes();
            fmt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                frmCustomer frmc = new frmCustomer(u.User_Id);
                // frmc.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmCustomer)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmc.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            try
            {
                frmUser frmUser = new frmUser(u.User_Id);
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmUser)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmUser.Show();
            }
            catch (Exception) { throw; }
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            try
            {
                frmFacturacion frmFac = new frmFacturacion(u.User_Id);
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmFacturacion)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmFac.Show();
            }
            catch (Exception) { throw; }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            try
            {
                frmIndicaProducto frmpo = new frmIndicaProducto();
                // frmpo.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmIndicaProducto)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmpo.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
