using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Reports
{
    public class ListingInvoiceSaleDetails
    {
        public String Code_Product { get;  set; }
        public Double PriceProd_Det { get;  set; }
        public Double Itbis_Det { get;  set; }
        public int Amount_Det { get;  set; }
        public Double Discount_Det { get;  set; }
        public String Name_Product { get;  set; }
        public Double Total_Det { get;  set; }

        public String Unit_Product { get; set; }

    }
}
