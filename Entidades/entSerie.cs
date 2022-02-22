using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public  class entSerie
    {
       public int Id_Serie { get; set; }
       public String Numero_Serie { get; set; }

        public int Id_Sucursal_Serie { get; set; }
       //relacion
       public entSucursal sucursal { get; set; }
       public entTipComprobante tipcom { get; set; }
    }
}
