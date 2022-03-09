namespace CapaPresentacion
{
    using CapaNegocio;
    using Entidades;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="frmSaleDetails" />.
    /// </summary>
    public partial class frmSaleDetails : Form
    {
        /// <summary>
        /// Defines the _IdSale.
        /// </summary>
        internal int _IdSale;

        /// <summary>
        /// Initializes a new instance of the <see cref="frmSaleDetails"/> class.
        /// </summary>
        /// <param name="idven">The idven<see cref="int"/>.</param>
        public frmSaleDetails(int idven)
        {
            InitializeComponent();
            this._IdSale = idven;
        }

        /// <summary>
        /// The BuildGrid.
        /// </summary>
        private void BuildGrid()
        {
            try
            {
                listDetails.View = View.Details;
                listDetails.Columns.Add("CODE", 80, HorizontalAlignment.Center);
                listDetails.Columns.Add("PRODUCT", 180, HorizontalAlignment.Center);
                listDetails.Columns.Add("PRICE", 70, HorizontalAlignment.Center);
                listDetails.Columns.Add("AMOUNT", 80, HorizontalAlignment.Center);
                //   listDetalles.Columns.Add("CLIENTE", 80, HorizontalAlignment.Center);
                listDetails.Columns.Add("TOTAL", 70, HorizontalAlignment.Center);


                listDetails.Columns[1].Width = 200;

                listDetails.FullRowSelect = true;
                listDetails.AllowColumnReorder = false;
                listDetails.MultiSelect = true;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Defines the v.
        /// </summary>
        internal entSale v;

        /// <summary>
        /// The CreateGrid.
        /// </summary>
        private void CreateGrid()
        {
            double total = 0.0;
            try
            {
                v = IBusinessSale.Instance.ListSaleDetails(this._IdSale);
                List<entDetalleVenta> dt = v.detalleventa;

                for (int i = 0; i < dt.Count; i++)
                {
                    String[] fila = new String[] {dt[i].producto.Codigo_Prod, dt[i].producto.Nombre_Prod, dt[i].producto.Precio_Prod.ToString("0.00"),
                    dt[i].Cantidad_Det.ToString(), (dt[i].Cantidad_Det * dt[i].producto.Precio_Prod).ToString("0.00") };
                    ListViewItem ite = new ListViewItem(fila);
                    listDetails.Items.Add(ite);
                    total += (dt[i].Cantidad_Det * dt[i].PrecProd_Det);

                }
                lblTotal.Text = "$" + total.ToString("0.00");
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The FillGrid.
        /// </summary>
        private void FillGrid()
        {
            try
            {
                lblSeller.Text = v.usuario.User_Name;
                lblState.Text = v.Estado_Venta;

                if (v.Estado_Venta == "A") lblState.BackColor = Color.Red;
                lblCodeSale.Text = v.Codigo_Venta;
                lblNoInvoice.Text = v.Correlativo_Venta;
                lblCustomer.Text = v.cliente.Customer_Name;
                dtpDate.Value = Convert.ToDateTime(v.FechaVenta.ToShortDateString());
                lblDNI.Text = v.cliente.CustomerDoc_Number.Trim();
                lblHour.Text = (v.FechaVenta.AddHours(3)).ToString("HH:mm:ss");

            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The label2_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void label2_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The frmDetalleV_Load.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void frmDetalleV_Load(object sender, EventArgs e)
        {
            try
            {
                BuildGrid();
                CreateGrid();
                FillGrid();

            }
            catch (ApplicationException ex) { MessageBox.Show(ex.Message, "Warning"); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        /// <summary>
        /// The label4_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}
