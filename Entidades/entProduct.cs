using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class entProduct
    {
       public int Id_Prod { get; set; }
       public String Codigo_Prod { get; set; }
       public String Nombre_Prod { get; set; }
       public String Marca_Prod { get; set; }
       public Double PrecioCompra_Prod { get; set; }
        public Double Descuento_Prod { get; set; }
       public Double Precio_Prod { get; set; }
   
       public int  ITBIS_Prod { get; set; }
       public int Stock_Prod { get; set; }
       public int StockProm_Prod { get; set; }
       public int StockMin_Prod { get; set; }
       public int UsuarioCreacion_Prod { get; set; }
       public int UsuarioUpdate_Prod { get; set; }
       public String FechVen_Pord { get; set; }

       //Relacion
       public entCategory categoria { get; set; }
       public entUnidadMedida unidmedida {get; set;}
       public entSupplier proveedor { get; set; }
       
       private entMaterial _material;
       public entMaterial material
       {
           get { if (_material == null) { _material = new entMaterial(); } return _material; }
           set { _material = value; }
       }
       //guardar vriable para detalle_venta
       public int Cantidad_ { get; set; }
       
    }
}
