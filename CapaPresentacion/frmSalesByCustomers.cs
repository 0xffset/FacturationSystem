namespace CapaPresentacion
{
    using CapaNegocio;
    using Entidades;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="frmSalesByCustomers" />.
    /// </summary>
    public partial class frmSalesByCustomers : Form
    {
        /// <summary>
        /// Defines the id.
        /// </summary>
        internal int id;

        /// <summary>
        /// Initializes a new instance of the <see cref="frmSalesByCustomers"/> class.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        public frmSalesByCustomers(int id)
        {

            InitializeComponent();
            this.id = id;
        }

        /// <summary>
        /// The BuildGridSalesCustomers.
        /// </summary>
        private void BuildGridSalesCustomers()
        {
            try

            {
                listView1.View = View.Details;
                listView1.Columns.Add("CODIGO PRODUCTO", 80, HorizontalAlignment.Center);
                listView1.Columns.Add("PRODUCTO", 180, HorizontalAlignment.Center);
                listView1.Columns.Add("PRECIO", 80, HorizontalAlignment.Center);
                listView1.Columns.Add("CANTIDAD", 80, HorizontalAlignment.Center);
                listView1.Columns.Add("TOTAL", 80, HorizontalAlignment.Center);

            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Defines the v.
        /// </summary>
        internal entSale v;

        /// <summary>
        /// The LoadSaleCustomer.
        /// </summary>
        private void LoadSaleCustomer()
        {

            double total = 0.0;
            try
            {
                v = IBusinessSale.Instance.ListSaleDetails(this.id);
                List<entDetalleVenta> Lista = v.detalleventa;
                entDetalleVenta l = new entDetalleVenta();
                for (int i = 0; i < Lista.Count; i++)
                {
                    String[] fila = new String[] { Lista[i].producto.Codigo_Prod, Lista[i].producto.Nombre_Prod,
                    Lista[i].producto.Precio_Prod.ToString(), Lista[i].Cantidad_Det.ToString(), (Lista[i].Cantidad_Det * Lista[i].producto.Precio_Prod).ToString("0.00")
                    };
                    total += (Lista[i].Cantidad_Det * Lista[i].producto.Precio_Prod);

                    ListViewItem it = new ListViewItem(fila);
                    listView1.Items.Add(it);
                    lblNombreCli.Text = v.cliente.Customer_Name;
                    lblNombreVen.Text = v.usuario.User_Name;
                    lblFechVenta.Text = v.FechaVenta.ToString("dd-MM-yyyy");
                    lblCodigoFac.Text = v.Correlativo_Venta;
                    EstadoVenta.Text = v.Estado_Venta;
                    if (EstadoVenta.Text == "A") EstadoVenta.BackColor = Color.Red;




                }
                lblTotal.Text = total.ToString();


            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The frmVentasClienteXId_Load.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void frmVentasClienteXId_Load(object sender, EventArgs e)
        {
            LoadSaleCustomer();
            BuildGridSalesCustomers();
        }

        /// <summary>
        /// The listView1_SelectedIndexChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
