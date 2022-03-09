namespace CapaPresentacion
{
    using CapaNegocio;
    using Entidades;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="frmConsultSales" />.
    /// </summary>
    public partial class frmConsultSales : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="frmConsultSales"/> class.
        /// </summary>
        public frmConsultSales()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The creargrid.
        /// </summary>
        private void creargrid()
        {
            try
            {
                dgvSaleHistory.Columns.Add("ColumnId", "Id");
                dgvSaleHistory.Columns.Add("ColumnCodigo", "Code");
                dgvSaleHistory.Columns.Add("ColumnEsrado", "Sale State");
                dgvSaleHistory.Columns.Add("ColumnComprobante", "Comprobante");
                dgvSaleHistory.Columns.Add("ColumnCorrelativo", "Number");
                dgvSaleHistory.Columns.Add("ColumnFecha", "Date");
                dgvSaleHistory.Columns.Add("ColumnHora", "Hour");
                dgvSaleHistory.Columns.Add("ColumnIgv", "IGV");
                dgvSaleHistory.Columns.Add("ColumnTotal", "Total");
                dgvSaleHistory.Columns.Add("ColumnUtilidades", "Utitlities");

                dgvSaleHistory.Columns[0].Visible = false;
                dgvSaleHistory.Columns[2].Width = 60;
                dgvSaleHistory.Columns[3].Visible = false;

                dgvSaleHistory.Columns[5].Width = 100;
                dgvSaleHistory.Columns[6].Width = 150;
                dgvSaleHistory.Columns[7].Visible = false;
                dgvSaleHistory.Columns[8].Width = 150;
                dgvSaleHistory.Columns[9].Width = 150;
                dgvSaleHistory.Columns[9].DefaultCellStyle.BackColor = Color.Lavender;
                dgvSaleHistory.Columns[9].Visible = false;

                DataGridViewCellStyle css = new DataGridViewCellStyle();
                css.Alignment = DataGridViewContentAlignment.TopCenter;
                dgvSaleHistory.ColumnHeadersDefaultCellStyle = css;
                dgvSaleHistory.AllowUserToAddRows = false;
                dgvSaleHistory.AllowUserToResizeColumns = false;
                dgvSaleHistory.AllowUserToResizeRows = false;
                dgvSaleHistory.ReadOnly = false;
                dgvSaleHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The Llenargrid.
        /// </summary>
        private void Llenargrid()
        {
            try
            {
                dgvSaleHistory.Rows.Clear();
                int idsucursal = 1;
                List<entSale> Lista = IBusinessSale.Instance.ListSalesByDates(dtpStart.Value.ToString("yyyy/MM/dd"), dtpEnd.Value.ToString("yyyy/MM/dd"), idsucursal);
                for (int i = 0; i < Lista.Count; i++)
                {
                    String[] fila = new String[] {
                        Lista[i].Id_Venta.ToString(), Lista[i].Codigo_Venta, Lista[i].Estado_Venta, Lista[i].tipocomprobante.Nombre_TipCom,
                        Lista[i].Correlativo_Venta, Lista[i].FechaVenta.ToString("dd-MM-yy"), Lista[i].FechaVenta.ToString("HH:mm:ss"), Lista[i].Igv_Venta.ToString(), (Lista[i].Total - Lista[i].Descuento_Venta).ToString("0.00"), (Lista[i].Utilidad).ToString("0.00")
                    };
                    dgvSaleHistory.Rows.Add(fila);
                    dgvSaleHistory.Rows[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
                    if (Lista[i].Estado_Venta == 'A'.ToString()) dgvSaleHistory.Rows[i].DefaultCellStyle.BackColor = Color.LightCoral;
                    Lista[i].tipocomprobante.Id_TipCom = 2;
                    Lista[i].tipopago.Id_TipPago = 1;
                    Lista[i].Utilidad = Lista[i].Total;

                }
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The frmConsultarVentas_Load.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void frmConsultarVentas_Load(object sender, EventArgs e)
        {

            try
            {
                creargrid();
                btnSaleDetails.Enabled = false;
                btnCancelSale.Enabled = false;
                dtpEnd.MaxDate = DateTime.Now;
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

        /// <summary>
        /// The btnDetVenta_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnDetVenta_Click(object sender, EventArgs e)
        {
            try
            {
                int idven = Convert.ToInt32(dgvSaleHistory.CurrentRow.Cells[0].Value);
                frmSaleDetails db = new frmSaleDetails(idven);
                db.ShowDialog();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// The btnBuscar_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
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

        /// <summary>
        /// The btnAnularVenta_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnAnularVenta_Click(object sender, EventArgs e)
        {
            try
            {
                int idventa = Convert.ToInt32(dgvSaleHistory.CurrentRow.Cells[0].Value);
                DialogResult resu = MessageBox.Show("¿Desean anular esta venta?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resu == DialogResult.Yes)
                {
                    int i = IBusinessSale.Instance.CancelSaleById(idventa);
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

        /// <summary>
        /// The dgvHisVentas_CellClick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="DataGridViewCellEventArgs"/>.</param>
        private void dgvHisVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSaleDetails.Enabled = true;
            btnCancelSale.Enabled = true;
        }

        /// <summary>
        /// The dgvHisVentas_CellContentClick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="DataGridViewCellEventArgs"/>.</param>
        private void dgvHisVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        /// <summary>
        /// The label1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void label1_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The btnSalesReports_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnSalesReports_Click(object sender, EventArgs e)
        {
            frmAdvancedSalesReport frmAdvancedSalesReport = new frmAdvancedSalesReport();
            frmAdvancedSalesReport.ShowDialog();
        }
    }
}
