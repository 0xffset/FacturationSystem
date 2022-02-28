using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using Entidades;

namespace CapaNegocio
{
   
   public  class IBusinessCustomer
    { 
        #region singleton
        private static readonly IBusinessCustomer _instancia = new IBusinessCustomer();
        public static IBusinessCustomer Instancia
        {
            get { return IBusinessCustomer._instancia;  }
        }
    #endregion singleto

        #region metodos

        public List<entCustomer> AdvancedSearchCustomer(String nameCli)
        {
            try 
            {
                List<entCustomer> Lista = null;
                Lista = IDataAccessCustomer.Instancia.AdvSearchCustomer(nameCli);
                if (Lista == null) throw new ApplicationException("Error in the search");
                return Lista;
            }
            catch (Exception)
            { throw; }

        }
        public entCustomer searchCustomer(int id_cli, string nro_Doc)
        {
            try 
            {
                entCustomer c = null;
                c = IDataAccessCustomer.Instancia.SearchClient(id_cli, nro_Doc);
                if (c == null) throw new ApplicationException("El registro no existe");
                return c;
            }
            catch (Exception)
            { throw; }
        }
        public List<entCustomer> listCustomers()
        {
            try
            {
                List<entCustomer> Lista = IDataAccessCustomer.Instancia.ListCustomers();
                if (Lista.Count <= 0) throw new ApplicationException("Customer list is emplty");
                else if (Lista == null) throw new ApplicationException("Error to load customer list");
                return Lista;
            }
            catch (Exception) { throw; }
        }
    public int CustomersManagement(entCustomer c, int tipoedicion)
        {
            try
            {
                string CadXml = "";
                CadXml += "<cliente ";
                CadXml +=  "idcliente='"+c.Customer_Id+"' ";
                CadXml += "idtipdoc='" + c.tipodocumento.Id_TipDoc + "' ";
                CadXml += "nrodoc='" + c.CustomeDate_Born + "' ";
                CadXml += "nombre='" + c.Customer_Name + "' ";
                CadXml += "fechanac='" + c.CustomeDate_Born + "' ";
                CadXml += "sexo='" + c.Customer_Sex + "' ";
                CadXml += "telefono='" + c.Customer_Phone + "' ";
                CadXml += "celular='" + c.Customer_Cellphone + "' ";
                CadXml += "correo='" + c.Customer_Email + "' ";
                CadXml += "direccion='" + c.Customer_Address + "' ";
                CadXml += "usuariocreacion='" + c.CustomerCreated_User + "' ";
                CadXml += "usuarioupdate='" + c.CustomerUpdated_User + "' ";
                CadXml += "tipoedicion='" + tipoedicion + "' />";

                CadXml = "<root>" + CadXml + "</root>";
                int resultado = IDataAccessCustomer.Instancia.customerManagement(CadXml);
                if (resultado <= 0) throw new ApplicationException("Error al registrar");
                return resultado;

            }
            catch (Exception) { throw; }
        }
    public List<entTipoDocumento> listartipdoc()
    {
        try
        {
            List<entTipoDocumento> Lista = IDataAccessCustomer.Instancia.listartipdoc();
            if (Lista.Count <= 0) throw new ApplicationException("Lista Vacia");
            else if (Lista == null) throw new ApplicationException("Error al cargar lista");
            return Lista;
        }
        catch (Exception) { throw; }
    }
   public int numClientes()
        {
            try
            {
                int i = IDataAccessCustomer.Instancia.numCliente();
                return i;
            }
            catch (Exception) { throw; }
        }
        #endregion

    }
}
