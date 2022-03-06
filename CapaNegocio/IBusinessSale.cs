using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaAccesoDatos;
namespace CapaNegocio
{
    public class IBusinessSale
    {
        #region singleton
        private static readonly IBusinessSale _instancia = new IBusinessSale();
        public static IBusinessSale Instancia
        {
            get { return IBusinessSale._instancia; }
        }
        #endregion

        #region metodos
        public entSale ventadetalle(int idventa)
        {
            try
            {
                entSale ven = IDataAccessSale.Instancia.LstventaDetalle(idventa);
                if (ven == null) throw new ApplicationException("Error al mostrar los detalles");
                return ven;
            }
            catch (Exception) { throw; }
        }

        public String cargarcorrelativo(int idtipcom, String serie)
        {
            try
            {
                String correlativo = IDataAccessSale.Instancia.cargarcorrelativo(idtipcom, serie);
                if (correlativo == null) throw new ApplicationException("Error al cargar numero de factura");
                return correlativo;

            }
            catch (Exception) { throw; }
        }
        public int anularventaxId(int idventa)
        {
            try
            {
                int retorn = IDataAccessSale.Instancia.anularventaxid(idventa);
                if (retorn == 0) throw new AccessViolationException("Error no se puedo ejecutar la accion");
                return retorn;
            }
            catch (Exception) { throw; }
        }

        public List<entSale> listarventa(String fdesde, String fhasta, int sucu)
        {
            try
            {
                List<entSale> listar = IDataAccessSale.Instancia.listarventa(fdesde, fhasta, sucu);
                if (listar == null) throw new ApplicationException("Error al cargar las ventas");
                else if (listar.Count == 0) throw new ApplicationException("La lista de ventas esta vacia");
                return listar;
            }
            catch (Exception) { throw; }
        }

        public List<entDetalleVenta> CargarVentaXId(int id)
        {
            try
            {
                List<entDetalleVenta> lista = IDataAccessSale.Instancia.CargarProductoClienteXId(id);
                if (lista == null) throw new ApplicationException("Error al cargar lista");
                else if (lista.Count == 0) throw new ApplicationException("La lista esta vacia");
                return lista;
            }
            catch (Exception) { throw; }
        }

    public List<entSale> listarVentasXnombreClie(string name)
        {
            try
            {
                List<entSale> l = IDataAccessSale.Instancia.CargarVentasProductos(name);
                if (l == null) throw new ApplicationException("Error");
                else if (l.Count == 0) throw new ApplicationException("Lista vacia");
                return l;

            } catch (Exception) { throw; }
        }

      public int anularcomprobante(String serie, String correla, int tipcom)
      {
          try
          {
              int result = IDataAccessSale.Instancia.AnularCompro(serie, correla, tipcom);
              if (result <= 0) throw new ApplicationException("No se puedo anular");
              return result;
          }
          catch(Exception) {throw;}
      }

      public String crgarcorrelativo(int idtipcom, String serie)
      {
          try
          {
              String correlativo = IDataAccessSale.Instancia.cargarcorrelativo(idtipcom, serie);
              if (correlativo == null) throw new ApplicationException("Error al cargar");
              return correlativo;
          }
          catch (Exception) { throw; }
      }

      public entSerie cargarserie( int idtipcom, int suc)
      {
          try
          {
              entSerie s = IDataAccessSale.Instancia.cargarserie(idtipcom, suc);
              if (s == null) throw new ApplicationException("Error al cargar serie");
              return s;
          }
          catch (Exception) { throw; }
      }

        public int numVenta()
        {
            try
            {
                int i = IDataAccessSale.Instancia.numVentas();
                return i;
            }
            catch (Exception) { throw; }
        }

        public int getLastIdSale()
        {
            try
            {
                int i = IDataAccessSale.Instancia.getLastIdSale();
                return i;
            }
            catch (Exception) { throw; }
        }

      public int guardarventa(entSale ven, int idtipdoventa, String serie)
      {
          try 
          {
              if (ven.cliente.Customer_Id == 0) throw new ApplicationException("Debe tener un cliente seleccionado");
              if (ven.detalleventa.Count == 0) throw new ApplicationException("Debe seleccionar un producto");

              String Cadxml = "";
              Cadxml += "<venta ";
              Cadxml += "idcliente='" + ven.cliente.Customer_Id + "' ";
              Cadxml += "idusuario='" + ven.usuario.User_Id + "' ";
              Cadxml += "idsucursal='" + ven.sucursal.Id_Suc + "' ";
              Cadxml += "istipcom='" + ven.tipocomprobante.Id_TipCom + "' ";
              Cadxml += "idmoneda='" + ven.moneda.Id_Moneda + "' ";
              Cadxml += "idtipopago='" + ven.tipopago.Id_TipPago + "' ";
              Cadxml += "igv='" + ven.Igv_Venta + "' ";
              Cadxml += "serie='" + serie + "' ";
              Cadxml += "descuento='" + ven.Descuento_Venta.ToString().Replace(",",".") + "' ";
              Cadxml += "descripcion='" + ven.Desc_Venta.ToString() + "'> ";

              foreach (entDetalleVenta dt in ven.detalleventa)
              {
                  Cadxml += "<detalle ";
                  Cadxml += "idproducto='" + dt.Id_Prod_Det + "' ";
                  Cadxml += "precioprod='" + dt.PrecProd_Det.ToString().Replace(",", ".") + "' ";
                  Cadxml += "itbis='" + dt.Itbis_Det + "' ";
                  Cadxml += "cantidad='" + dt.Cantidad_Det + "'/>";
              }
              Cadxml += "</venta>";
              Cadxml = "<root>" + Cadxml + "</root>";
              int i = IDataAccessSale.Instancia.guardarventa(Cadxml, idtipdoventa);
              if (i <= 0) throw new ApplicationException("Error al guardar los datos");
              return i;


          }
          catch (Exception) { throw; }
      }

      #endregion 
  }
}
