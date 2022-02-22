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
    public partial class frmDetalleV : Form
    {
        int idventa;
        public frmDetalleV(int idven)
        {
            InitializeComponent();
            this.idventa = idven;
        }

        private void creargrid()
        {
            try
            {
                listDetalles.View = View.Details;
                listDetalles.Columns.Add("CODIGO", 80, HorizontalAlignment.Center);
                listDetalles.Columns.Add("PRODUCTO", 180, HorizontalAlignment.Center);
                listDetalles.Columns.Add("PRECIO", 70, HorizontalAlignment.Center);
                listDetalles.Columns.Add("CANTIDAD", 80, HorizontalAlignment.Center);
             //   listDetalles.Columns.Add("CLIENTE", 80, HorizontalAlignment.Center);
                listDetalles.Columns.Add("TOTAL", 70, HorizontalAlignment.Center);
               

                listDetalles.Columns[1].Width = 200;
                
                listDetalles.FullRowSelect = true;
                listDetalles.AllowColumnReorder = false;
                listDetalles.MultiSelect = true;
            }
            catch (Exception) { throw; }
        }
        entSale v;
        private void llenargrid()
        {
            double total = 0.0;
            try
            {
                v = IBusinessSale.Instancia.ventadetalle(this.idventa);
                List<entDetalleVenta> dt = v.detalleventa;
              
                for (int i = 0; i < dt.Count; i++)
                {
                    String[] fila = new String[] {dt[i].producto.Codigo_Prod, dt[i].producto.Nombre_Prod, dt[i].producto.Precio_Prod.ToString("0.00"),
                    dt[i].Cantidad_Det.ToString(), (dt[i].Cantidad_Det * dt[i].producto.Precio_Prod).ToString("0.00") };
                    ListViewItem ite = new ListViewItem(fila);
                    listDetalles.Items.Add(ite);
                    total += (dt[i].Cantidad_Det * dt[i].PrecProd_Det);
                   
                }
                lbltota.Text = "$" + total.ToString("0.00");
            }
            catch (Exception) { throw; }
        }

        private void llenardatos()
        {
            try
            {
                lblvende.Text = v.usuario.User_Name;
                lblestadoven.Text = v.Estado_Venta;
                
                if (v.Estado_Venta == "A") lblestadoven.BackColor = Color.Red;
                lblcodigo.Text = v.Codigo_Venta;
                lblnofac.Text = v.Correlativo_Venta;
                lblclien.Text = v.cliente.Customer_Name;
                dtpfecha.Value = Convert.ToDateTime(v.FechaVenta.ToShortDateString());
                lblnumero.Text = v.cliente.CustomerDoc_Number.Trim();
                lblhora.Text = (v.FechaVenta.AddHours(3)).ToString("HH:mm:ss");

            }
            catch (Exception) { throw; }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmDetalleV_Load(object sender, EventArgs e)
        {
            try
            {
                creargrid();
               llenargrid();
                llenardatos();
            }
            catch (ApplicationException ex) { MessageBox.Show(ex.Message, "Aviso"); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
