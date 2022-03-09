namespace CapaNegocio
{
    using CapaAccesoDatos;
    using Entidades;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="IBusinessSale" />.
    /// </summary>
    public class IBusinessSale
    {
        /// <summary>
        /// Defines the _instance.
        /// </summary>
        private static readonly IBusinessSale _instance = new IBusinessSale();

        /// <summary>
        /// Gets the Instance.
        /// </summary>
        public static IBusinessSale Instance
        {
            get { return IBusinessSale._instance; }
        }

        /// <summary>
        /// The ListSaleDetails.
        /// </summary>
        /// <param name="idSale">The idventa<see cref="int"/>.</param>
        /// <returns>The <see cref="entSale"/>.</returns>
        public entSale ListSaleDetails(int idSale)
        {
            try
            {
                entSale ven = IDataAccessSale.Instance.IListSaleDetails(idSale);
                if (ven == null) throw new ApplicationException("Error displaying details");
                return ven;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The ListCorrelative.
        /// </summary>
        /// <param name="idtipcom">The idtipcom<see cref="int"/>.</param>
        /// <param name="serie">The serie<see cref="String"/>.</param>
        /// <returns>The <see cref="String"/>.</returns>
        public String ListCorrelative(int idtipcom, String serie)
        {
            try
            {
                String correlativo = IDataAccessSale.Instance.IListCorrelative(idtipcom, serie);
                if (correlativo == null) throw new ApplicationException("Error loading invoice number");
                return correlativo;

            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The CancelSaleById.
        /// </summary>
        /// <param name="idSale">The idventa<see cref="int"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public int CancelSaleById(int idSale)
        {
            try
            {
                int retorn = IDataAccessSale.Instance.ICancelSaleById(idSale);
                if (retorn == 0) throw new AccessViolationException("Error could not execute action");
                return retorn;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The ListSalesByDates.
        /// </summary>
        /// <param name="fromDate">The fdesde<see cref="String"/>.</param>
        /// <param name="toDate">The fhasta<see cref="String"/>.</param>
        /// <param name="sucu">The sucu<see cref="int"/>.</param>
        /// <returns>The <see cref="List{entSale}"/>.</returns>
        public List<entSale> ListSalesByDates(String fromDate, String toDate, int sucu)
        {
            try
            {
                List<entSale> listar = IDataAccessSale.Instance.IListSale(fromDate, toDate, sucu);
                if (listar == null) throw new ApplicationException("Error loading sales");
                else if (listar.Count == 0) throw new ApplicationException("The sales list is empty");
                return listar;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The ListSaleById.
        /// </summary>
        /// <param name="idSale">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="List{entDetalleVenta}"/>.</returns>
        public List<entDetalleVenta> ListSaleById(int idSale)
        {
            try
            {
                List<entDetalleVenta> lista = IDataAccessSale.Instance.IListProductCustomerById(idSale);
                if (lista == null) throw new ApplicationException("Error loading list");
                else if (lista.Count == 0) throw new ApplicationException("The list is empty");
                return lista;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The ListSalesByCustomerName.
        /// </summary>
        /// <param name="customerName">The name<see cref="string"/>.</param>
        /// <returns>The <see cref="List{entSale}"/>.</returns>
        public List<entSale> ListSalesByCustomerName(string customerName)
        {
            try
            {
                List<entSale> l = IDataAccessSale.Instance.IListSalesProducts(customerName);
                if (l == null) throw new ApplicationException("Error");
                else if (l.Count == 0) throw new ApplicationException("List empty");
                return l;

            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The CancelCompro.
        /// </summary>
        /// <param name="serie">The serie<see cref="String"/>.</param>
        /// <param name="correla">The correla<see cref="String"/>.</param>
        /// <param name="tipcom">The tipcom<see cref="int"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public int CancelCompro(String serie, String correla, int tipcom)
        {
            try
            {
                int result = IDataAccessSale.Instance.ICancelCompro(serie, correla, tipcom);
                if (result <= 0) throw new ApplicationException("cannot be overridden");
                return result;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The listCorrelative.
        /// </summary>
        /// <param name="idtipcom">The idtipcom<see cref="int"/>.</param>
        /// <param name="serie">The serie<see cref="String"/>.</param>
        /// <returns>The <see cref="String"/>.</returns>
        public String listCorrelative(int idtipcom, String serie)
        {
            try
            {
                String correlativo = IDataAccessSale.Instance.IListCorrelative(idtipcom, serie);
                if (correlativo == null) throw new ApplicationException("Failed to load");
                return correlativo;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The ListSerie.
        /// </summary>
        /// <param name="idtipcom">The idtipcom<see cref="int"/>.</param>
        /// <param name="suc">The suc<see cref="int"/>.</param>
        /// <returns>The <see cref="entSerie"/>.</returns>
        public entSerie ListSerie(int idtipcom, int suc)
        {
            try
            {
                entSerie s = IDataAccessSale.Instance.IListSerie(idtipcom, suc);
                if (s == null) throw new ApplicationException("Failed to load serial");
                return s;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The ShowNumSales.
        /// </summary>
        /// <returns>The <see cref="int"/>.</returns>
        public int ShowNumSales()
        {
            try
            {
                int i = IDataAccessSale.Instance.IShowNumSales();
                return i;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The GetLastIdSale.
        /// </summary>
        /// <returns>The <see cref="int"/>.</returns>
        public int GetLastIdSale()
        {
            try
            {
                int i = IDataAccessSale.Instance.IGetLastIdSale();
                return i;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The SaveSale.
        /// </summary>
        /// <param name="ven">The ven<see cref="entSale"/>.</param>
        /// <param name="idtipdoventa">The idtipdoventa<see cref="int"/>.</param>
        /// <param name="serie">The serie<see cref="String"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public int SaveSale(entSale ven, int idtipdoventa, String serie)
        {
            try
            {
                if (ven.cliente.Customer_Id == 0) throw new ApplicationException("You must have a selected customer");
                if (ven.detalleventa.Count == 0) throw new ApplicationException("You must select a product");

                String Cadxml = "";
                Cadxml += "<venta ";
                Cadxml += "idcliente='" + ven.cliente.Customer_Id + "' ";
                Cadxml += "idusuario='" + ven.usuario.User_Id + "' ";
                Cadxml += "idsucursal='" + ven.sucursal.Id_Suc + "' ";
                Cadxml += "istipcom='" + ven.tipocomprobante.Id_TipCom + "' ";
                Cadxml += "idmoneda='" + ven.moneda.Id_Moneda + "' ";
                Cadxml += "idtipopago='" + ven.tipopago.Id_TipPago + "' ";
                Cadxml += "igv='" + ven.Igv_Venta + "' ";
                Cadxml += "serie='" + serie + "' ";
                Cadxml += "descuento='" + ven.Descuento_Venta.ToString().Replace(",", ".") + "' ";
                Cadxml += "descripcion='" + ven.Desc_Venta.ToString() + "'> ";

                foreach (entDetalleVenta dt in ven.detalleventa)
                {
                    Cadxml += "<detalle ";
                    Cadxml += "idproducto='" + dt.Id_Prod_Det + "' ";
                    Cadxml += "precioprod='" + dt.PrecProd_Det.ToString().Replace(",", ".") + "' ";
                    Cadxml += "itbis='" + dt.Itbis_Det + "' ";
                    Cadxml += "cantidad='" + dt.Cantidad_Det + "'/>";
                }
                Cadxml += "</venta>";
                Cadxml = "<root>" + Cadxml + "</root>";
                int i = IDataAccessSale.Instance.ISaveSale(Cadxml, idtipdoventa);
                if (i <= 0) throw new ApplicationException("Error saving data");
                return i;


            }
            catch (Exception) { throw; }
        }
    }
}
