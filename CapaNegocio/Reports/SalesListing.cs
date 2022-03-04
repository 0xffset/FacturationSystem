using System;
namespace CapaNegocio.Reports
{
    public class SalesListing
    {
        public int Id_Venta { get; set; }
        public String Codigo_Venta { get; set; }
        public String Nombre_Cliente { get; set; }
        public DateTime Fecha_Venta { get; set; }
        public String Productos { get; set; }
        public Double Cantidad_Total { get; set; }
    }
}