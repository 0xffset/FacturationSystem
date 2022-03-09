namespace CapaNegocio
{
    using CapaAccesoDatos;
    using Entidades;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="IBusinessCustomer" />.
    /// </summary>
    public class IBusinessCustomer
    {
        /// <summary>
        /// Defines the _instancia.
        /// </summary>
        private static readonly IBusinessCustomer _instance = new IBusinessCustomer();

        /// <summary>
        /// Gets the Instancia.
        /// </summary>
        public static IBusinessCustomer Instance
        {
            get { return IBusinessCustomer._instance; }
        }

        /// <summary>
        /// The AdvancedSearchCustomer.
        /// </summary>
        /// <param name="nameCli">The nameCli<see cref="String"/>.</param>
        /// <returns>The <see cref="List{entCustomer}"/>.</returns>
        public List<entCustomer> AdvancedSearchCustomer(String nameCli)
        {
            try
            {
                List<entCustomer> Lista = null;
                Lista = IDataAccessCustomer.Instance.IAdvancedSearchCustomer(nameCli);
                if (Lista == null) throw new ApplicationException("Error in the search");
                return Lista;
            }
            catch (Exception)
            { throw; }
        }

        /// <summary>
        /// The SearchCustomer.
        /// </summary>
        /// <param name="id_cli">The id_cli<see cref="int"/>.</param>
        /// <param name="nro_Doc">The nro_Doc<see cref="string"/>.</param>
        /// <returns>The <see cref="entCustomer"/>.</returns>
        public entCustomer SearchCustomer(int id_cli, string nro_Doc)
        {
            try
            {
                entCustomer c = null;
                c = IDataAccessCustomer.Instance.ISearchCustomer(id_cli, nro_Doc);
                if (c == null) throw new ApplicationException("El registro no existe");
                return c;
            }
            catch (Exception)
            { throw; }
        }

        /// <summary>
        /// The ListCustomer.
        /// </summary>
        /// <returns>The <see cref="List{entCustomer}"/>.</returns>
        public List<entCustomer> ListCustomer()
        {
            try
            {
                List<entCustomer> Lista = IDataAccessCustomer.Instance.IListCustomer();
                if (Lista.Count <= 0) throw new ApplicationException("Customer list is emplty");
                else if (Lista == null) throw new ApplicationException("Error to load customer list");
                return Lista;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The CustomersManagement.
        /// </summary>
        /// <param name="c">The c<see cref="entCustomer"/>.</param>
        /// <param name="tipoedicion">The tipoedicion<see cref="int"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public int CustomersManagement(entCustomer c, int tipoedicion)
        {
            try
            {
                string CadXml = "";
                CadXml += "<cliente ";
                CadXml += "idcliente='" + c.Customer_Id + "' ";
                CadXml += "idtipdoc='" + c.tipodocumento.Id_TipDoc + "' ";
                CadXml += "nrodoc='" + c.CustomerDoc_Number + "' ";
                CadXml += "nombre='" + c.Customer_Name + "' ";
                CadXml += "telefono='" + c.Customer_Phone + "' ";
                CadXml += "celular='" + c.Customer_Cellphone + "' ";
                CadXml += "correo='" + c.Customer_Email + "' ";
                CadXml += "direccion='" + c.Customer_Address + "' ";
                CadXml += "usuariocreacion='" + c.CustomerCreated_User + "' ";
                CadXml += "usuarioupdate='" + c.CustomerUpdated_User + "' ";
                CadXml += "tipoedicion='" + tipoedicion + "' />";

                CadXml = "<root>" + CadXml + "</root>";
                int resultado = IDataAccessCustomer.Instance.ICustomerMagament(CadXml);
                if (resultado <= 0) throw new ApplicationException("Error al registrar");
                return resultado;

            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The ListTipDocument.
        /// </summary>
        /// <returns>The <see cref="List{entTipoDocumento}"/>.</returns>
        public List<entTipoDocumento> ListTipDocument()
        {
            try
            {
                List<entTipoDocumento> Lista = IDataAccessCustomer.Instance.IListTipDocument();
                if (Lista.Count <= 0) throw new ApplicationException("Lista Vacia");
                else if (Lista == null) throw new ApplicationException("Error al cargar lista");
                return Lista;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The ShowNumCustomers.
        /// </summary>
        /// <returns>The <see cref="int"/>.</returns>
        public int ShowNumCustomers()
        {
            try
            {
                int i = IDataAccessCustomer.Instance.IShowNumCustomers();
                return i;
            }
            catch (Exception) { throw; }
        }
    }
}
