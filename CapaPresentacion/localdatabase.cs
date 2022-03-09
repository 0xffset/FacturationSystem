namespace CapaNegocio
{
    using Entidades;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="localdatabase" />.
    /// </summary>
    public class localdatabase
    {
        /// <summary>
        /// Defines the _instance.
        /// </summary>
        private static readonly localdatabase _instance = new localdatabase();

        /// <summary>
        /// Gets the Instance.
        /// </summary>
        public static localdatabase Instance
        {
            get { return localdatabase._instance; }
        }

        /// <summary>
        /// Defines the _IdCustomer.
        /// </summary>
        internal int _IdCustomer = 0;

        /// <summary>
        /// Defines the _IdProduct.
        /// </summary>
        internal int _IdProduct = 0;

        /// <summary>
        /// Defines the _Tried.
        /// </summary>
        internal int _Tried = 0;

        /// <summary>
        /// Defines the _Invoke.
        /// </summary>
        internal int _Invoke = 0;

        /// <summary>
        /// Defines the detInvoice.
        /// </summary>
        internal List<entProduct> detInvoice = new List<entProduct>();

        /// <summary>
        /// The invocar.
        /// </summary>
        /// <param name="getset">The getset<see cref="int"/>.</param>
        /// <param name="frm">The frm<see cref="int"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public int Invoke(int getset, int frm)
        {
            try
            {
                if (getset == 1) _Invoke = frm;
            }
            catch (Exception)
            {
                throw;
            }
            return _Invoke;
        }

        /// <summary>
        /// The Quitaritemproducto.
        /// </summary>
        /// <param name="idprod">The idprod<see cref="int"/>.</param>
        public void RemoveProduct(int idprod)
        {
            try
            {
                foreach (entProduct p in detInvoice)
                {
                    if (p.Id_Prod == idprod)
                    {
                        detInvoice.Remove(p);
                        return;
                    }
                }
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The limpiardetalleventa.
        /// </summary>
        public void ClearSaleDetails()
        {
            try
            {
                detInvoice.RemoveRange(0, detInvoice.Count);
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The Returnintento.
        /// </summary>
        /// <param name="getset">The getset<see cref="int"/>.</param>
        /// <param name="intent">The intent<see cref="int"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public int ReturnTried(int getset, int intent)
        {
            try
            {
                if (getset == 1)
                {
                    _Tried = intent;
                }
                return _Tried;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The returnidcliente.
        /// </summary>
        /// <param name="getset">The getset<see cref="int"/>.</param>
        /// <param name="idCustomer">The idCliente<see cref="int"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public int ReturnIdCustomer(int getset, int idCustomer)
        {
            try
            {
                if (getset == 1)
                {
                    _IdCustomer = idCustomer;
                }
                return _IdCustomer;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// The returnidclientenv.
        /// </summary>
        /// <param name="getset">The getset<see cref="int"/>.</param>
        /// <param name="idCustomer">The idcliente<see cref="int"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public int ReturnIdCustomerEnv(int getset, int idCustomer)
        {
            try
            {
                if (getset == 1)
                {
                    _IdCustomer = idCustomer;
                }
                return _IdCustomer;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The returnDetventa.
        /// </summary>
        /// <param name="getsetm">The getsetm<see cref="int"/>.</param>
        /// <param name="idprod">The idprod<see cref="int"/>.</param>
        /// <param name="canti">The canti<see cref="int"/>.</param>
        /// <returns>The <see cref="List{entProduct}"/>.</returns>
        public List<entProduct> ReturnDetailsSale(int getsetm, int idprod, int canti)
        {
            try
            {
                if (getsetm == 1)
                {
                    if (canti > 1)
                    {
                        for (int i = 0; i < detInvoice.Count; i++)
                        {
                            if (detInvoice[i].Id_Prod == idprod)
                            {
                                detInvoice[i].Cantidad_ = canti;
                                break;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < detInvoice.Count; i++)
                        {
                            if (detInvoice[i].Id_Prod == idprod)
                            {
                                throw new ApplicationException("This product has already been added");
                            }
                        }
                        entProduct p = IBusinessManagement.Instance.SearchProduct(idprod);
                        p.Cantidad_ = canti;
                        detInvoice.Add(p);
                    }
                }

                return detInvoice;

            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The returnidprod.
        /// </summary>
        /// <param name="getset">The getset<see cref="int"/>.</param>
        /// <param name="idprodu">The idprodu<see cref="int"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public int ReturnIdProduct(int getset, int idprodu)
        {
            try
            {
                if (getset == 1)
                {
                    _IdProduct = idprodu;
                }
                return _IdProduct;
            }

            catch (Exception) { throw; }
        }
    }
}
