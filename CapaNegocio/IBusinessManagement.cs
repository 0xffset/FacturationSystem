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
        /// <param name="code">The codigo<see cref="String"/>.</param>
        /// <param name="idcat">The idcat<see cref="int"/>.</param>
        /// <param name="range">The rango<see cref="int"/>.</param>
        /// <returns>The <see cref="List{entProduct}"/>.</returns>
        public List<entProduct> ListProductByCodeCatRan(String code, int idcat, int range)
        {
            try
            {
                List<entProduct> Lista = null;
                Lista = IDataAccessManagement.Instance.IListProductByCodeCatRan(code, idcat, range);
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
        /// <param name="supplier">The prov<see cref="entSupplier"/>.</param>
        /// <param name="tipoedi">The tipoedi<see cref="int"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public int SupplierManagement(entSupplier supplier, int tipoedi)
        {
            try
            {
                String cadXml = "";
                cadXml += "<proveedor ";
                cadXml += "idprove='" + supplier.Id_Proveedor + "' ";
                cadXml += "razonsocial='" + supplier.RazSocial_Proveedor + "' ";
                cadXml += "ruc='" + supplier.Rnc_Proveedor + "' ";
                cadXml += "direccion='" + supplier.Direccion_Proveedor + "' ";
                cadXml += "telefono='" + supplier.Telefono_Proveedor + "' ";
                cadXml += "celular='" + supplier.Celular_Proveedor + "' ";
                cadXml += "correo='" + supplier.Correo_Proveedor + "' ";
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
        /// <param name="UnitMeasureProduct">The presentac<see cref="entUnidadMedida"/>.</param>
        /// <param name="editTyped">The tipoedi<see cref="int"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public int UnitMeasureProductManagement(entUnidadMedida UnitMeasureProduct, int editTyped)
        {

            try
            {
                entUnidadMedida UnitMe = new entUnidadMedida();
                UnitMe = UnitMeasureProduct;
                String cadXml = "";
                cadXml += "<unmedida ";
                cadXml += "idunmedida='" + UnitMe.Id_Umed + "' ";
                cadXml += "descripcion='" + UnitMe.Descripcion_Umed + "' ";
                cadXml += "abreviatura='" + UnitMe.Abreviatura_Umed + "' ";
                cadXml += "tipoedicion='" + editTyped + "' />";
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
        /// <param name="idSupplier">The prove<see cref="int"/>.</param>
        /// <returns>The <see cref="entSupplier"/>.</returns>
        public entSupplier SearchSupplier(int idSupplier)
        {
            try
            {
                entSupplier prov = null;
                prov = IDataAccessManagement.Instance.ISearchSupplier(idSupplier);
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
        /// <param name="idUnitMeasure">The idpre<see cref="int"/>.</param>
        /// <returns>The <see cref="entUnidadMedida"/>.</returns>
        public entUnidadMedida SearchUnitMeasureProduct(int idUnitMeasure)
        {
            try
            {
                entUnidadMedida pres = null;
                pres = IDataAccessManagement.Instance.ISearchUnitMeasureProduct(idUnitMeasure);
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
        /// <param name="idCategory">The catid<see cref="int"/>.</param>
        /// <returns>The <see cref="entCategory"/>.</returns>
        public entCategory SearchCategories(int idCategory)
        {
            try
            {
                if (idCategory.ToString() == "") throw new ApplicationException("You must select a record");
                entCategory cat = null;
                cat = IDataAccessManagement.Instance.ISearchCategory(idCategory);
                if (cat == null) throw new ApplicationException("No records");
                return cat;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The CategoryManagement.
        /// </summary>
        /// <param name="category">The categoria<see cref="entCategory"/>.</param>
        /// <param name="editTyped">The tipoedicion<see cref="int"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public int CategoryManagement(entCategory category, int editTyped)
        {
            try
            {
                entCategory eCategory = new entCategory();
                eCategory = category;
                String CadXml = "";
                CadXml += "<categoria ";
                CadXml += "idcategoria='" + eCategory.Id_Cat + "' ";
                CadXml += "nombre='" + eCategory.Nombre_Cat + "' ";
                CadXml += "descripcion='" + eCategory.Descripcion_Cat + "' ";
                CadXml += "usuariocreacion='" + eCategory.UsuarioCreacion_Cat + "' ";
                CadXml += "usuarioupdate='" + eCategory.UsuarioUpdate_Cat + "' ";
                CadXml += "tipoedicion='" + editTyped + "'/>";
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
