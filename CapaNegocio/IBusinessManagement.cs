namespace CapaNegocio
{
    using CapaAccesoDatos;
    using Entidades;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="IBusinessManagement" />.
    /// </summary>
    public class IBusinessManagement
    {
        /// <summary>
        /// Defines the _instance.
        /// </summary>
        private static readonly IBusinessManagement _instance = new IBusinessManagement();

        /// <summary>
        /// Gets the Instance.
        /// </summary>
        public static IBusinessManagement Instance
        {
            get { return IBusinessManagement._instance; }
        }

        /// <summary>
        /// The SearchAvancedProductByName.
        /// </summary>
        /// <param name="na">The na<see cref="String"/>.</param>
        /// <returns>The <see cref="List{entProduct}"/>.</returns>
        public List<entProduct> SearchAvancedProductByName(String na)
        {
            try
            {
                List<entProduct> Lista = null;
                Lista = IDataAccessManagement.Instance.IListProductByName(na);
                return Lista;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The ListProductByCodeCatRan.
        /// </summary>
        /// <param name="codigo">The codigo<see cref="String"/>.</param>
        /// <param name="idcat">The idcat<see cref="int"/>.</param>
        /// <param name="rango">The rango<see cref="int"/>.</param>
        /// <returns>The <see cref="List{entProduct}"/>.</returns>
        public List<entProduct> ListProductByCodeCatRan(String codigo, int idcat, int rango)
        {
            try
            {
                List<entProduct> Lista = null;
                Lista = IDataAccessManagement.Instance.IListProductByCodeCatRan(codigo, idcat, rango);
                if (Lista.Count == 0) throw new ApplicationException("No record found");
                else if (Lista == null) throw new ApplicationException("Hay un error en los productos");
                return Lista;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The SearchProductAvanced.
        /// </summary>
        /// <param name="tipbus">The tipbus<see cref="int"/>.</param>
        /// <param name="valbu">The valbu<see cref="String"/>.</param>
        /// <returns>The <see cref="List{entProduct}"/>.</returns>
        public List<entProduct> SearchProductAvanced(int tipbus, String valbu)
        {
            try
            {
                List<entProduct> Lista = null;
                Lista = IDataAccessManagement.Instance.IAvancedSearchProduct(tipbus, valbu);
                return Lista;

            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The SearchProduct.
        /// </summary>
        /// <param name="idpro">The idpro<see cref="int"/>.</param>
        /// <returns>The <see cref="entProduct"/>.</returns>
        public entProduct SearchProduct(int idpro)
        {
            try
            {
                entProduct pro = null;
                pro = IDataAccessManagement.Instance.ISearchProduct(idpro);
                if (pro == null) throw new ApplicationException("No product was found");
                return pro;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The ListProduct.
        /// </summary>
        /// <returns>The <see cref="List{entProduct}"/>.</returns>
        public List<entProduct> ListProduct()
        {
            try
            {
                List<entProduct> Lista = null;
                Lista = IDataAccessManagement.Instance.IListProduct();
                if (Lista.Count == 0) throw new ApplicationException("Empty products");
                else if (Lista == null) throw new ApplicationException("There is an error loading empty products");
                return Lista;
            }

            catch (Exception) { throw; }
        }

        /// <summary>
        /// The ProductManagement.
        /// </summary>
        /// <param name="prop">The prop<see cref="entProduct"/>.</param>
        /// <param name="tied">The tied<see cref="int"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public int ProductManagement(entProduct prop, int tied)
        {
            try
            {
                String cadXml = "";
                cadXml += "<producto ";
                cadXml += "idproducto='" + prop.Id_Prod + "' ";
                cadXml += "idcat='" + prop.categoria.Id_Cat + "' ";
                cadXml += "idunmed='" + prop.unidmedida.Id_Umed + "' ";
                cadXml += "idprov='" + prop.proveedor.Id_Proveedor + "' ";
                cadXml += "nombre='" + prop.Nombre_Prod + "' ";
                cadXml += "marca='" + prop.Marca_Prod + "' ";
                cadXml += "preciocompra='" + prop.PrecioCompra_Prod.ToString().Replace(",", ".") + "' ";
                cadXml += "descuento='" + prop.Descuento_Prod.ToString().Replace(",", ".") + "' ";
                cadXml += "precio='" + prop.Precio_Prod.ToString().Replace(",", ".") + "' ";
                cadXml += "stock='" + prop.Stock_Prod + "' ";
                cadXml += "stockprom='" + prop.StockProm_Prod + "' ";
                cadXml += "stockmin='" + prop.StockMin_Prod + "' ";
                cadXml += "itbis='" + prop.ITBIS_Prod + "' ";
                cadXml += "usuariocreacion='" + prop.UsuarioCreacion_Prod + "' ";
                cadXml += "usuarioupdate='" + prop.UsuarioUpdate_Prod + "' ";
                cadXml += "tipoedicion='" + tied + "' ";
                cadXml += "idmaterial='" + prop.material.Id + "' ";
                cadXml += "fechvenpro='" + prop.FechVen_Pord + "'/>";

                cadXml = "<root>" + cadXml + "</root>";
                int i = IDataAccessManagement.Instance.IProductManagement(cadXml);
                if (i <= 0)
                {
                    throw new ApplicationException("Error executing action, please try again");

                }
                return i;

            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The SupplierManagement.
        /// </summary>
        /// <param name="prov">The prov<see cref="entSupplier"/>.</param>
        /// <param name="tipoedi">The tipoedi<see cref="int"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public int SupplierManagement(entSupplier prov, int tipoedi)
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
                int i = IDataAccessManagement.Instance.ISupplierManagement(cadXml);
                if (i <= 0)
                {
                    throw new ApplicationException("Error executing action, please try again");

                }
                return i;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The UnitMeasureProductManagement.
        /// </summary>
        /// <param name="presentac">The presentac<see cref="entUnidadMedida"/>.</param>
        /// <param name="tipoedi">The tipoedi<see cref="int"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public int UnitMeasureProductManagement(entUnidadMedida presentac, int tipoedi)
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
                int i = IDataAccessManagement.Instance.IUnitMeasureProductManagement(cadXml);
                if (i <= 0)
                {
                    throw new ApplicationException("Error completing the action, please try again");

                }
                return i;


            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The SearchSupplier.
        /// </summary>
        /// <param name="prove">The prove<see cref="int"/>.</param>
        /// <returns>The <see cref="entSupplier"/>.</returns>
        public entSupplier SearchSupplier(int prove)
        {
            try
            {
                entSupplier prov = null;
                prov = IDataAccessManagement.Instance.ISearchSupplier(prove);
                if (prov == null) throw new ApplicationException("no records");
                return prov;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The ShowNumProducts.
        /// </summary>
        /// <returns>The <see cref="int"/>.</returns>
        public int ShowNumProducts()
        {
            int i = IDataAccessManagement.Instance.IShowNumProducts();
            return i;
        }

        /// <summary>
        /// The SearchUnitMeasureProduct.
        /// </summary>
        /// <param name="idpre">The idpre<see cref="int"/>.</param>
        /// <returns>The <see cref="entUnidadMedida"/>.</returns>
        public entUnidadMedida SearchUnitMeasureProduct(int idpre)
        {
            try
            {
                entUnidadMedida pres = null;
                pres = IDataAccessManagement.Instance.ISearchUnitMeasureProduct(idpre);
                if (pres == null) throw new ApplicationException("No records");
                return pres;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The ListSupplier.
        /// </summary>
        /// <returns>The <see cref="List{entSupplier}"/>.</returns>
        public List<entSupplier> ListSupplier()
        {
            try
            {
                List<entSupplier> Lista = null;
                Lista = IDataAccessManagement.Instance.IListSupplier();
                return Lista;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The ListUnitMeasureProduct.
        /// </summary>
        /// <returns>The <see cref="List{entUnidadMedida}"/>.</returns>
        public List<entUnidadMedida> ListUnitMeasureProduct()
        {
            try
            {
                List<entUnidadMedida> Lista = null;
                Lista = IDataAccessManagement.Instance.IListUnitMeasureProduct();
                return Lista;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The SearchCategories.
        /// </summary>
        /// <param name="catid">The catid<see cref="int"/>.</param>
        /// <returns>The <see cref="entCategory"/>.</returns>
        public entCategory SearchCategories(int catid)
        {
            try
            {
                if (catid.ToString() == "") throw new ApplicationException("You must select a record");
                entCategory cat = null;
                cat = IDataAccessManagement.Instance.ISearchCategory(catid);
                if (cat == null) throw new ApplicationException("No records");
                return cat;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The CategoryManagement.
        /// </summary>
        /// <param name="categoria">The categoria<see cref="entCategory"/>.</param>
        /// <param name="tipoedicion">The tipoedicion<see cref="int"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public int CategoryManagement(entCategory categoria, int tipoedicion)
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
                int i = IDataAccessManagement.Instance.ICategoryManagement(CadXml);
                if (i <= 0)
                {
                    throw new ApplicationException("Error executing action, please try again");

                }
                return i;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The ListCategories.
        /// </summary>
        /// <returns>The <see cref="List{entCategory}"/>.</returns>
        public List<entCategory> ListCategories()
        {
            try
            {
                return IDataAccessManagement.Instance.IListCategories();
            }
            catch (Exception) { throw; }
        }
    }
}
