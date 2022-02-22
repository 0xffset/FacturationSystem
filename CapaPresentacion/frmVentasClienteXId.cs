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
    public partial class frmVentasClienteXId : Form
    {
        int id;
        public frmVentasClienteXId(int id)
        {
            
            InitializeComponent();
            this.id = id; 
        }

        private void loadDates()
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
        entSale v;
        private void upload()
        {
            
            double total = 0.0;
            try
            {
                v = IBusinessSale.Instancia.ventadetalle(this.id);
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
            catch(Exception) { throw;  }
        }

       

        private void frmVentasClienteXId_Load(object sender, EventArgs e)
        {
            upload();
            loadDates();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
