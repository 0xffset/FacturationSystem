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
    public partial class frmConsultarVentas : Form
    {
        public frmConsultarVentas()
        {
            InitializeComponent();
        }
        private void creargrid()
        {
            try 
            {
                dgvHisVentas.Columns.Add("ColumnId", "Id");
                dgvHisVentas.Columns.Add("ColumnCodigo", "Codigo");
                dgvHisVentas.Columns.Add("ColumnEsrado", "Estado Vent.");
                dgvHisVentas.Columns.Add("ColumnComprobante", "Comprobante");
                dgvHisVentas.Columns.Add("ColumnCorrelativo", "Numero");
                dgvHisVentas.Columns.Add("ColumnFecha", "Fecha");
                dgvHisVentas.Columns.Add("ColumnHora", "Hora");
                dgvHisVentas.Columns.Add("ColumnIgv", "Igv");
                dgvHisVentas.Columns.Add("ColumnTotal", "Total");
                dgvHisVentas.Columns.Add("ColumnUtilidades", "Utilidades");

                dgvHisVentas.Columns[0].Visible = false;
                dgvHisVentas.Columns[2].Width = 60;
                dgvHisVentas.Columns[3].Visible = false;

                dgvHisVentas.Columns[5].Width = 60;
                dgvHisVentas.Columns[6].Width = 58;
                dgvHisVentas.Columns[7].Visible = false;
                dgvHisVentas.Columns[8].Width = 70;
                dgvHisVentas.Columns[9].Width = 70;
                dgvHisVentas.Columns[9].DefaultCellStyle.BackColor = Color.Lavender;
                dgvHisVentas.Columns[9].Visible = false;

                DataGridViewCellStyle css = new DataGridViewCellStyle();
                css.Alignment = DataGridViewContentAlignment.TopCenter;
                dgvHisVentas.ColumnHeadersDefaultCellStyle = css;
                dgvHisVentas.AllowUserToAddRows = false;
                dgvHisVentas.AllowUserToResizeColumns = false;
                dgvHisVentas.AllowUserToResizeRows = false;
                dgvHisVentas.ReadOnly = false;
                dgvHisVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
            catch (Exception) { throw; }
        }

        private void Llenargrid()
        {
            try
            {
                dgvHisVentas.Rows.Clear();
                int idsucursal = 1;
                List<entSale> Lista = IBusinessSale.Instancia.listarventa(dtpInicio.Value.ToString("yyyy/MM/dd"), dtpFinal.Value.ToString("yyyy/MM/dd"), idsucursal);
                for (int i = 0; i<Lista.Count; i++)
                {
                    String[] fila = new String[] {
                        Lista[i].Id_Venta.ToString(), Lista[i].Codigo_Venta, Lista[i].Estado_Venta, Lista[i].tipocomprobante.Nombre_TipCom,
                        Lista[i].Correlativo_Venta, Lista[i].FechaVenta.ToString("dd-MM-yy"), Lista[i].FechaVenta.ToString("HH:mm:ss"), Lista[i].Igv_Venta.ToString(), (Lista[i].Total - Lista[i].Descuento_Venta).ToString("0.00"), (Lista[i].Utilidad).ToString("0.00")
                    };
                    dgvHisVentas.Rows.Add(fila);
                    dgvHisVentas.Rows[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
                    if (Lista[i].Estado_Venta == 'A'.ToString()) dgvHisVentas.Rows[i].DefaultCellStyle.BackColor = Color.LightCoral;
                    Lista[i].tipocomprobante.Id_TipCom = 2;
                    Lista[i].tipopago.Id_TipPago = 1;
                    Lista[i].Utilidad = Lista[i].Total;
                    
                }
            }
            catch (Exception) { throw; }
        }

        private void frmConsultarVentas_Load(object sender, EventArgs e)
        {

            try
            {
                creargrid();
                btnDetVenta.Enabled = false;
                btnAnularVenta.Enabled = false;
                dtpFinal.MaxDate = DateTime.Now;
            }
            catch (ApplicationException ea)
            {
                MessageBox.Show(ea.Message, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDetVenta_Click(object sender, EventArgs e)
        {
            try
            {
                int idven = Convert.ToInt32(dgvHisVentas.CurrentRow.Cells[0].Value);
                frmDetalleV db =  new frmDetalleV(idven);
                db.ShowDialog();
            }
            catch (Exception)
            {
                throw;
            }
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Llenargrid();
            }
            catch (ApplicationException ea)
            {
                MessageBox.Show(ea.Message, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAnularVenta_Click(object sender, EventArgs e)
        {
            try
            {
                int idventa = Convert.ToInt32(dgvHisVentas.CurrentRow.Cells[0].Value);
                DialogResult resu = MessageBox.Show("¿Desean anular esta venta?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resu==DialogResult.Yes)
                {
                    int i = IBusinessSale.Instancia.anularventaxId(idventa);
                    MessageBox.Show("La venta fue anulada", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ApplicationException ea)
            {
                MessageBox.Show(ea.Message, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvHisVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDetVenta.Enabled = true;
            btnAnularVenta.Enabled = true;
        }

        private void dgvHisVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
