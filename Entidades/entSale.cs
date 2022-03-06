using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entSale
    {
        public int Id_Venta { get; set; }
        public String Codigo_Venta { get; set; }
        public int Serie_Venta { get; set; }
        public String Correlativo_Venta { get; set; }
        public Double  Igv_Venta { get; set; }
        public Double MontoIgv_Venta { get; set; }
        public DateTime FechaVenta { get; set; }
        public String Estado_Venta { get; set; }
        public Double Descuento_Venta { get; set; }
        public string Desc_Venta { get; set; }
        public double  Utilidad { get; set; }
        public double Inversion { get; set; }
        // Campo calculado 
        public double Total { get; set; }
        //Relaciones
        public entCustomer cliente { get; set; }
        public entUser usuario { get; set; }
        public entMoneda moneda { get; set; }
        public entSucursal sucursal { get; set; }
        public entTipComprobante tipocomprobante { get; set; }
        public entTipoPago tipopago { get; set; }
        public List<entDetalleVenta> detalleventa { get; set; }
    }
}
