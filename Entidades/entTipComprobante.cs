using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entTipComprobante
    {
        public int Id_TipCom { get; set; }
        public String Codigo_TipCom { get; set; }
        public String Nombre_TipCom { get; set; }
        public String Descrpcion_TipCom { get; set; }

        //Relaciones 

        public entTipoMovimiento tipomovimiento { get; set; }
    }
}
