using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaNegocio;

namespace CapaNegocio
{
    public class localdatabase
    {
        #region singleton
        private static readonly localdatabase _instancia = new localdatabase();
        public static localdatabase Instancia
        {
            get { return localdatabase._instancia;  }
        }
        #endregion
#region metodos
        int Iidcliente = 0, idClienteNV=0;
        int IdProd =0;
        int internto = 0;

        int invocador = 0;

        List<entProduct> detFactura = new List<entProduct>();


        public int invocar(int getset, int frm)
        {
            try
            {
                if (getset == 1) invocador = frm;
            }
            catch (Exception)
            {
                throw;
            } return invocador;
        }

        public void Quitaritemproducto(int idprod)
        {
            try
            {
                foreach (entProduct p in detFactura)
                {
                    if (p.Id_Prod == idprod)
                    {
                        detFactura.Remove(p);
                        return;
                    }
                }
            }
            catch (Exception) { throw; }
        }

        public void limpiardetalleventa()
        {
            try
            {
                detFactura.RemoveRange(0, detFactura.Count);
            }
            catch (Exception) { throw; }
        }

        public int Returnintento (int getset, int intent)
        {
            try
            {
                if (getset == 1)
                {
                    internto = intent;
                }
                return internto;
            }
            catch (Exception) { throw; }
        }
        public int returnidcliente(int getset, int idCliente)
        {
            try
            {
                if (getset == 1)
                {
                    Iidcliente = idCliente;
                }
                return Iidcliente;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int returnidclientenv(int getset, int idcliente)
        {
            try
            { 
                if (getset == 1)
                {
                    Iidcliente = idcliente;
                }
                return Iidcliente;
            }
            catch (Exception) { throw; }
        }
             public List<entProduct> returnDetventa(int getsetm, int idprod, int canti)
    {
        try
        {
            if (getsetm == 1)
            {
                if (canti >1)
                {
                    for (int i = 0; i < detFactura.Count; i++)
                    {
                        if (detFactura[i].Id_Prod ==idprod)
                        {
                            detFactura[i].Cantidad_ = canti;
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < detFactura.Count; i++)
                    {
                        if (detFactura[i].Id_Prod == idprod)
                        {
                            throw new ApplicationException("Ya fue agregado este producto");
                        }
                    }
                    entProduct p = IBusinessManagement.Instance.SearchProduct(idprod);
                    p.Cantidad_ = canti;
                    detFactura.Add(p);
                }
            }

            return detFactura;

        }
        catch (Exception) { throw; }
    }

       public int returnidprod(int getset, int idprodu)
             {
                 try
                 {
                     if (getset == 1)
                     {
                         IdProd = idprodu;
                     }
                     return IdProd;
                 }

                 catch (Exception) { throw; }
             }

   
   
        
#endregion
    }
}
