using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class entDetalleVenta
    {
       public int Id_Det { get; set; }
       public int Id_Prod_Det { get; set; }
       public Double PrecProd_Det { get; set; }
       public int Cantidad_Det { get; set; }
       public Double Itbis_Det { get; set; }
       public Double Descuento_det { get; set; }
       
       //Relacion 

       public entSale venta { get; set; }
       public entProduct producto { get; set; }
       public entUser usurio { get; set; }
        public entCustomer cliete { get; set; }

    }
}
