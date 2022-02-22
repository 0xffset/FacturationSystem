using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaAccesoDatos;

namespace CapaNegocio
{
    public class IBusinessManagement
    {
        #region singleton
        private static readonly IBusinessManagement _instancia = new IBusinessManagement();
        public static IBusinessManagement Instancia
        {
            get { return IBusinessManagement._instancia; }
        }
        #endregion

        #region metodos
        public List<entProduct> BuscarprodAvanzadaIndicador(String na)
        {
            try
            {
                List<entProduct> Lista = null;
                Lista = IDataAccessManagement.Instancia.LstProdIndicadorAvanzada(na);
                return Lista;
            }
            catch (Exception) { throw; }
        }

        public List<entProduct> ListarProdIndicador(String codigo, int idcat, int rango)
        {
            try
            {
                List<entProduct> Lista = null;
                Lista = IDataAccessManagement.Instancia.ListarProdIndicador(codigo, idcat, rango);
                if (Lista.Count == 0) throw new ApplicationException("No se encontro registro");
                else if (Lista == null) throw new ApplicationException("Hay un error en los productos");
                return Lista;
            }
            catch (Exception) { throw; }
        }

        public List<entProduct> BuscarproAvanzada(int tipbus, String valbu)
        {
            try
            {
                List<entProduct> Lista = null;
                Lista = IDataAccessManagement.Instancia.BuscarProdAvanzada(tipbus, valbu);
                return Lista;

            }
            catch (Exception) { throw; }

        }

        public entProduct BuscarProd(int idpro)
        {
            try
            {
                entProduct pro = null;
                pro = IDataAccessManagement.Instancia.buscarprod(idpro);
                if (pro == null) throw new ApplicationException("No se encontro ningun producto");
                return pro;
            }
            catch (Exception) { throw; }
        }

        public List<entProduct> ListarProd()
        {
            try
            {
                List<entProduct> Lista = null;
                Lista = IDataAccessManagement.Instancia.listarproducto();
                if (Lista.Count == 0) throw new ApplicationException("Productos vacios");
                else if (Lista == null) throw new ApplicationException("Hay un error en la carga de los productos");
                return Lista;
            }

            catch (Exception) { throw; }
        }

           public int mantenimeintoProd(entProduct prop, int tied)
           {
               try 
               {
                   String cadXml ="";
                   cadXml += "<producto ";
                   cadXml += "idproducto='" + prop.Id_Prod + "' ";
                   cadXml += "idcat='" + prop.categoria.Id_Cat + "' ";
                   cadXml += "idunmed='" + prop.unidmedida.Id_Umed + "' ";
                   cadXml += "idprov='" + prop.proveedor.Id_Proveedor + "' ";
                   cadXml += "nombre='" + prop.Nombre_Prod + "' ";
                   cadXml += "marca='" + prop.Marca_Prod + "' ";
                   cadXml += "preciocompra='" + prop.PrecioCompra_Prod.ToString().Replace(",",".") + "' ";
                   cadXml += "precio='" + prop.Precio_Prod.ToString().Replace(",",".") + "' ";
                   cadXml += "stock='" + prop.Stock_Prod + "' ";
                   cadXml += "stockprom='" + prop.StockProm_Prod + "' ";
                   cadXml += "stockmin='" + prop.StockMin_Prod + "' ";
                   cadXml += "usuariocreacion='" + prop.UsuarioCreacion_Prod + "' ";
                   cadXml += "usuarioupdate='" + prop.UsuarioUpdate_Prod + "' ";
                   cadXml += "tipoedicion='" + tied + "' ";
                   cadXml += "idmaterial='" + prop.material.Id + "' ";
                   cadXml += "fechvenpro='" + prop.FechVen_Pord + "'/>";

                   cadXml = "<root>" + cadXml + "</root>";
                   int i = IDataAccessManagement.Instancia.mantenimeintoprod(cadXml);
                   if (i <= 0)
                   {
                       throw new ApplicationException("Error al ejecutar la accion, Intentelo de nuevo");

                   }
                   return i;

               }
               catch (Exception) {throw;}
           }
           public int MantenimientoProvee(entSupplier prov, int tipoedi)
           {
               try 
               {
                   String cadXml = "";
                   cadXml += "<proveedor ";
                   cadXml += "idprove='" + prov.Id_Proveedor + "' ";
                   cadXml += "razonsocial='" + prov.RazSocial_Proveedor + "' ";
                   cadXml += "ruc='" + prov.Rnc_Proveedor + "' ";
                   cadXml += "direccion='" + prov.Direccion_Proveedor + "' ";
                   cadXml += "telefono='" + prov.Telefono_Proveedor + "' ";
                   cadXml += "celular='" + prov.Celular_Proveedor + "' ";
                   cadXml += "correo='" + prov.Correo_Proveedor + "' ";
                   cadXml += "tipoedicion='" + tipoedi + "'/>";
                   cadXml = "<root>" + cadXml + "</root>";
                   int i = IDataAccessManagement.Instancia.mantenimeintoprovee(cadXml);
                   if (i <=0 )
                   {
                       throw new ApplicationException("Error al ejecutar la accion, Intentelo de nuevo");

                   }
                   return i;
               }
               catch (Exception) { throw; }
           }

        public int MantenimientoPresentacion(entUnidadMedida presentac, int tipoedi)
           {

               try
               {
                   entUnidadMedida pres = new entUnidadMedida();
                   pres = presentac;
                   String cadXml = "";
                   cadXml += "<unmedida ";
                   cadXml += "idunmedida='" + pres.Id_Umed + "' ";
                   cadXml += "descripcion='" + pres.Descripcion_Umed + "' ";
                   cadXml += "abreviatura='" + pres.Abreviatura_Umed + "' ";
                   cadXml += "tipoedicion='" + tipoedi + "' />";
                   cadXml = "<root>" + cadXml + "</root>";
                   int i = IDataAccessManagement.Instancia.mantenimeintopresentacionprod(cadXml);
                   if (i <=0 )
                   {
                       throw new ApplicationException("Error al completar la accion, intentelo de nuevo");

                   }
                   return i;

                   
               }
               catch (Exception) { throw; }

           }
        public entSupplier buscarproveedor(int prove)
        {
            try
            {
                entSupplier prov = null;
                prov = IDataAccessManagement.Instancia.buscarprov(prove);
                if (prov == null) throw new ApplicationException("No hay registros");
                return prov;
            }
            catch (Exception) { throw; }
            
        }

        public int numProductos()
        {
            int i = IDataAccessManagement.Instancia.numProductos();
            return i;
        }
                   

        public entUnidadMedida buscarpresentacion(int idpre)
        {
            try
            {
                entUnidadMedida pres = null;
                pres = IDataAccessManagement.Instancia.BuscarPresentacion(idpre);
                if (pres == null) throw new ApplicationException("No hay registros");
                return pres;
            }
            catch (Exception) { throw; }
        }

        public List<entSupplier> ListarProve()
        {
            try 
            {
                List<entSupplier> Lista = null;
                Lista = IDataAccessManagement.Instancia.ListarProveedor();
                return Lista;
            }
            catch (Exception) { throw; }
        }

        public List<entUnidadMedida> listarpresentacion()
        {
            try
            {
                List<entUnidadMedida> Lista = null;
                Lista = IDataAccessManagement.Instancia.ListarPresentacion();
                return Lista;
            }
            catch (Exception) { throw; }
        }

        public entCategory buscarcategoria(int catid)
        {
            try
            {
                if (catid.ToString() == "") throw new ApplicationException("Debe seleccionar un registro");
                entCategory cat = null;
                cat = IDataAccessManagement.Instancia.BuscarCat(catid);
                if (cat == null) throw new ApplicationException("No hay registros");
                return cat;
            }
            catch (Exception) { throw; }
        }

        public int mantenimientocategoria(entCategory categoria, int tipoedicion)
        {
            try
            {
                entCategory cat = new entCategory();
                cat = categoria;
                String CadXml = "";
                CadXml += "<categoria ";
                CadXml += "idcategoria='" + cat.Id_Cat + "' ";
                CadXml += "nombre='" + cat.Nombre_Cat + "' ";
                CadXml += "descripcion='" + cat.Descripcion_Cat + "' ";
                CadXml += "usuariocreacion='" + cat.UsuarioCreacion_Cat + "' ";
                CadXml += "usuarioupdate='" + cat.UsuarioUpdate_Cat + "' ";
                CadXml += "tipoedicion='" + tipoedicion + "'/>";
                CadXml = "<root>" + CadXml + "</root>";
                int i = IDataAccessManagement.Instancia.Mantenimeintocategoria(CadXml);
                if (i <= 0)
                {
                    throw new  ApplicationException("Error al ejecutar la accion, Intentelo de nuevo");

                }
                return i;
            }
            catch (Exception) { throw; }
        }

        public List<entCategory> listarcategoria()
        {
            try
            {
                return IDataAccessManagement.Instancia.ListarCategoria();
            }
            catch (Exception) { throw; }
        }

        #endregion

        }
    
}
