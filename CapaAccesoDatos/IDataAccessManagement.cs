namespace CapaAccesoDatos
{
    using Entidades;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;

    /// <summary>
    /// Defines the <see cref="IDataAccessManagement" />.
    /// </summary>
    public class IDataAccessManagement
    {
        /// <summary>
        /// Defines the _instance.
        /// </summary>
        private static readonly IDataAccessManagement _instance = new IDataAccessManagement();

        /// <summary>
        /// Gets the Instance.
        /// </summary>
        public static IDataAccessManagement Instance
        {
            get { return IDataAccessManagement._instance; }
        }

        /// <summary>
        /// The IListProductByName.
        /// </summary>
        /// <param name="nam">The nam<see cref="String"/>.</param>
        /// <returns>The <see cref="List{entProduct}"/>.</returns>
        public List<entProduct> IListProductByName(String nam)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<entProduct> Lista = null;

            try
            {
                SqlConnection cn = Conexion.Instance.sqlConnectionCursor();
                cmd = new SqlCommand("splistarProdIndicador", cn);
                cmd.Parameters.AddWithValue("@prmname", nam);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<entProduct>();
                while (dr.Read())
                {
                    entProduct prod = new entProduct();
                    prod.Id_Prod = Convert.ToInt32(dr["Id_Prod"]);
                    prod.Codigo_Prod = dr["Codigo_Prod"].ToString();
                    prod.Nombre_Prod = dr["Nombre_Prod"].ToString();
                    prod.PrecioCompra_Prod = Convert.ToDouble(dr["PrecioCompra_Prod"]);
                    prod.Precio_Prod = Convert.ToDouble(dr["Precio_Prod"]);
                    prod.Stock_Prod = Convert.ToInt32(dr["Stock_Prod"]);
                    prod.FechVen_Pord = dr["FechVen_Pord"].ToString();
                    prod.StockProm_Prod = Convert.ToInt32(dr["StockProm_Prod"]);
                    prod.StockMin_Prod = Convert.ToInt32(dr["StockMin_Prod"]);

                    entCategory cat = new entCategory();
                    cat.Nombre_Cat = dr["Nombre_Cat"].ToString();
                    prod.categoria = cat;

                    entUnidadMedida pres = new entUnidadMedida();
                    pres.Abreviatura_Umed = dr["Abreviatura_Umed"].ToString();
                    prod.unidmedida = pres;
                    Lista.Add(prod);


                }

            }
            catch (Exception) { throw; }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

        /// <summary>
        /// The IListProductByCodeCatRan.
        /// </summary>
        /// <param name="codigo">The codigo<see cref="String"/>.</param>
        /// <param name="idcat">The idcat<see cref="int"/>.</param>
        /// <param name="rango">The rango<see cref="int"/>.</param>
        /// <returns>The <see cref="List{entProduct}"/>.</returns>
        public List<entProduct> IListProductByCodeCatRan(String codigo, int idcat, int rango)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<entProduct> Lista = null;

            try
            {
                SqlConnection cn = Conexion.Instance.sqlConnectionCursor();
                cmd = new SqlCommand("spListarProdStatus", cn);
                cmd.Parameters.AddWithValue("@prmCodigo", codigo);
                cmd.Parameters.AddWithValue("@prmcat", idcat);
                cmd.Parameters.AddWithValue("@prmstockrango", rango);

                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<entProduct>();
                while (dr.Read())
                {
                    entProduct prod = new entProduct();
                    prod.Id_Prod = Convert.ToInt32(dr["Id_Prod"]);
                    prod.Codigo_Prod = dr["Codigo_Prod"].ToString();
                    prod.Nombre_Prod = dr["Nombre_Prod"].ToString();
                    prod.PrecioCompra_Prod = Convert.ToDouble(dr["PrecioCompra_Prod"]);
                    prod.Precio_Prod = Convert.ToDouble(dr["Precio_Prod"]);
                    prod.Stock_Prod = Convert.ToInt32(dr["Stock_Prod"]);
                    prod.FechVen_Pord = dr["FechVen_Prod"].ToString();
                    prod.StockProm_Prod = Convert.ToInt32(dr["StockProm_Prod"]);
                    prod.StockMin_Prod = Convert.ToInt32(dr["StockMin_Prod"]);

                    entCategory cat = new entCategory();
                    cat.Nombre_Cat = dr["Nombre_Cat"].ToString();
                    prod.categoria = cat;
                    entUnidadMedida pres = new entUnidadMedida();
                    pres.Abreviatura_Umed = dr["Abreviatura_Umed"].ToString();
                    prod.unidmedida = pres;
                    Lista.Add(prod);

                }


            }
            catch (Exception) { throw; }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

        /// <summary>
        /// The IAvancedSearchProduct.
        /// </summary>
        /// <param name="tipentrada">The tipentrada<see cref="int"/>.</param>
        /// <param name="valor_entrada">The valor_entrada<see cref="String"/>.</param>
        /// <returns>The <see cref="List{entProduct}"/>.</returns>
        public List<entProduct> IAvancedSearchProduct(int tipentrada, String valor_entrada)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<entProduct> Lista = null;
            try
            {
                SqlConnection cn = Conexion.Instance.sqlConnectionCursor();
                cmd = new SqlCommand("spBuscarProdAvanzada", cn);
                cmd.Parameters.AddWithValue("@prmTipEntrada", tipentrada);
                cmd.Parameters.AddWithValue("@prmValorEntrada", valor_entrada);

                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<entProduct>();
                while (dr.Read())
                {
                    entProduct prod = new entProduct();
                    prod.Id_Prod = Convert.ToInt32(dr["Id_Prod"]);
                    prod.Codigo_Prod = dr["Codigo_Prod"].ToString();
                    prod.Nombre_Prod = dr["Nombre_Prod"].ToString();
                    prod.Marca_Prod = dr["Marca_Prod"].ToString();

                    prod.Precio_Prod = Convert.ToDouble(dr["Precio_Prod"]);
                    prod.FechVen_Pord = dr["FechVen_Prod"].ToString();
                    prod.Stock_Prod = Convert.ToInt32(dr["Stock_Prod"]);


                    entCategory cat = new entCategory();
                    cat.Nombre_Cat = dr["Nombre_Cat"].ToString();
                    prod.categoria = cat;
                    entUnidadMedida pres = new entUnidadMedida();
                    pres.Descripcion_Umed = dr["Descripcion_Umed"].ToString();
                    prod.unidmedida = pres;
                    Lista.Add(prod);

                }
            }
            catch (Exception) { throw; }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

        /// <summary>
        /// The ISearchProduct.
        /// </summary>
        /// <param name="idpo">The idpo<see cref="int"/>.</param>
        /// <returns>The <see cref="entProduct"/>.</returns>
        public entProduct ISearchProduct(int idpo)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            entProduct prod = null;
            try
            {
                SqlConnection cn = Conexion.Instance.sqlConnectionCursor();
                cmd = new SqlCommand("spBuscarProducto", cn);
                cmd.Parameters.AddWithValue("@prmId_Prod", idpo);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    prod = new entProduct();
                    prod.Id_Prod = Convert.ToInt32(dr["Id_Prod"]);
                    prod.Codigo_Prod = dr["Codigo_Prod"].ToString();
                    prod.Nombre_Prod = dr["Nombre_Prod"].ToString();
                    prod.Marca_Prod = dr["Marca_Prod"].ToString();
                    prod.PrecioCompra_Prod = Convert.ToDouble(dr["PrecioCompra_Prod"].ToString());
                    prod.Descuento_Prod = Convert.ToDouble(dr["Descuento_Prod"].ToString());
                    prod.Precio_Prod = Convert.ToDouble(dr["Precio_Prod"]);
                    prod.Stock_Prod = Convert.ToInt32(dr["Stock_Prod"]);
                    prod.StockProm_Prod = Convert.ToInt32(dr["StockProm_Prod"]);
                    prod.StockMin_Prod = Convert.ToInt32(dr["StockMin_Prod"]);
                    prod.FechVen_Pord = dr["FechVen_Prod"].ToString();
                    prod.ITBIS_Prod = Convert.ToInt32(dr["Itbis_Prod"]);


                    entCategory cat = new entCategory();
                    cat.Id_Cat = Convert.ToInt32(dr["Id_Cat"]);
                    prod.categoria = cat;

                    entUnidadMedida pres = new entUnidadMedida();
                    pres.Id_Umed = Convert.ToInt32(dr["Id_Umed"]);
                    prod.unidmedida = pres;
                    entSupplier prov = new entSupplier();
                    prov.Id_Proveedor = Convert.ToInt32(dr["Id_Proveedor"]);
                    prod.proveedor = prov;


                }

            }
            catch (Exception) { throw; }
            finally { cmd.Connection.Close(); }
            return prod;
        }

        /// <summary>
        /// The IListProduct.
        /// </summary>
        /// <returns>The <see cref="List{entProduct}"/>.</returns>
        public List<entProduct> IListProduct()
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<entProduct> Lista = null;
            try
            {
                SqlConnection cn = Conexion.Instance.sqlConnectionCursor();
                cmd = new SqlCommand("spListarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<entProduct>();
                while (dr.Read())
                {
                    entProduct prod = new entProduct();
                    prod.Id_Prod = Convert.ToInt32(dr["Id_Prod"]);
                    prod.Codigo_Prod = dr["Codigo_Prod"].ToString();
                    prod.Nombre_Prod = dr["Nombre_Prod"].ToString();
                    prod.Marca_Prod = dr["Marca_Prod"].ToString();
                    prod.FechVen_Pord = dr["FechVen_Prod"].ToString();
                    entCategory cat = new entCategory();
                    cat.Nombre_Cat = dr["Nombre_Cat"].ToString();
                    prod.categoria = cat;
                    entUnidadMedida pres = new entUnidadMedida();
                    pres.Descripcion_Umed = dr["Descripcion_Umed"].ToString();
                    prod.unidmedida = pres;
                    entSupplier prov = new entSupplier();
                    prov.RazSocial_Proveedor = dr["RazSocial_Proveedor"].ToString();

                    prod.proveedor = prov;
                    Lista.Add(prod);
                }
            }
            catch (Exception) { throw; }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

        /// <summary>
        /// The IProductManagement.
        /// </summary>
        /// <param name="CadXml">The CadXml<see cref="String"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public int IProductManagement(String CadXml)
        {
            SqlCommand cmd = null;
            var resu = 0;
            try
            {
                SqlConnection cn = Conexion.Instance.sqlConnectionCursor();
                cmd = new SqlCommand("spInsEditElimProducto", cn);
                cmd.Parameters.AddWithValue("@prmCadXml", CadXml);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                resu = cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { cmd.Connection.Close(); }
            return resu;
        }

        /// <summary>
        /// The ISupplierManagement.
        /// </summary>
        /// <param name="CadXml">The CadXml<see cref="String"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public int ISupplierManagement(String CadXml)
        {
            SqlCommand cmd = null;
            var resu = 0;
            try
            {
                SqlConnection cn = Conexion.Instance.sqlConnectionCursor();
                cmd = new SqlCommand("spInsEditElimProveedor", cn);
                cmd.Parameters.AddWithValue("@prmCadXml", CadXml);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                resu = cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { cmd.Connection.Close(); }
            return resu;
        }

        /// <summary>
        /// The IUnitMeasureProductManagement.
        /// </summary>
        /// <param name="CadXml">The CadXml<see cref="String"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public int IUnitMeasureProductManagement(String CadXml)
        {
            SqlCommand cmd = null;
            var resu = 0;
            try
            {
                SqlConnection cn = Conexion.Instance.sqlConnectionCursor();
                cmd = new SqlCommand("spInsEditElimUnidMed", cn);
                cmd.Parameters.AddWithValue("@prmCadXml", CadXml);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                resu = cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { cmd.Connection.Close(); }
            return resu;
        }

        /// <summary>
        /// The ISearchSupplier.
        /// </summary>
        /// <param name="idprove">The idprove<see cref="int"/>.</param>
        /// <returns>The <see cref="entSupplier"/>.</returns>
        public entSupplier ISearchSupplier(int idprove)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            entSupplier prov = null;
            try
            {
                SqlConnection cn = Conexion.Instance.sqlConnectionCursor();
                cmd = new SqlCommand("spBuscarProveedor", cn);
                cmd.Parameters.AddWithValue("@prmid_Proveedor", idprove);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    prov = new entSupplier();
                    prov.Id_Proveedor = Convert.ToInt32(dr["Id_Proveedor"]);
                    prov.Cod_Proveedor = dr["Cod_Proveedor"].ToString();
                    prov.RazSocial_Proveedor = dr["RazSocial_Proveedor"].ToString();
                    prov.Rnc_Proveedor = dr["Ruc_Proveedor"].ToString();
                    prov.Direccion_Proveedor = dr["Direccion_Proveedor"].ToString();
                    prov.Telefono_Proveedor = dr["Telefono_Proveedor"].ToString();
                    prov.Celular_Proveedor = dr["Celular_Proveedor"].ToString();
                    prov.Correo_Proveedor = dr["Correo_Proveedor"].ToString();
                }
            }
            catch (Exception) { throw; }
            finally { cmd.Connection.Close(); }
            return prov;
        }

        /// <summary>
        /// The ISearchUnitMeasureProduct.
        /// </summary>
        /// <param name="idpres">The idpres<see cref="int"/>.</param>
        /// <returns>The <see cref="entUnidadMedida"/>.</returns>
        public entUnidadMedida ISearchUnitMeasureProduct(int idpres)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            entUnidadMedida pres = null;
            try
            {
                SqlConnection cn = Conexion.Instance.sqlConnectionCursor();
                cmd = new SqlCommand("spBuscarUnMedida", cn);
                cmd.Parameters.AddWithValue("@prmidUniMed", idpres);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    pres = new entUnidadMedida();
                    pres.Id_Umed = Convert.ToInt32(dr["Id_Umed"]);
                    pres.Codigo_Umed = dr["Codigo_Umed"].ToString();
                    pres.Descripcion_Umed = dr["Descripcion_Umed"].ToString();
                    pres.Abreviatura_Umed = dr["Abreviatura_Umed"].ToString();
                }
            }
            catch (Exception) { throw; }
            finally { cmd.Connection.Close(); }
            return pres;
        }

        /// <summary>
        /// The IListSupplier.
        /// </summary>
        /// <returns>The <see cref="List{entSupplier}"/>.</returns>
        public List<entSupplier> IListSupplier()
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<entSupplier> Lista = null;
            try
            {
                SqlConnection cn = Conexion.Instance.sqlConnectionCursor();
                cmd = new SqlCommand("spListarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<entSupplier>();
                while (dr.Read())
                {
                    entSupplier prov = new entSupplier();
                    prov.Id_Proveedor = Convert.ToInt32(dr["Id_Proveedor"]);
                    prov.Cod_Proveedor = dr["Cod_Proveedor"].ToString();
                    prov.RazSocial_Proveedor = dr["RazSocial_Proveedor"].ToString();
                    prov.Rnc_Proveedor = dr["Ruc_Proveedor"].ToString();
                    Lista.Add(prov);
                }
            }
            catch (Exception) { throw; }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

        /// <summary>
        /// The IListUnitMeasureProduct.
        /// </summary>
        /// <returns>The <see cref="List{entUnidadMedida}"/>.</returns>
        public List<entUnidadMedida> IListUnitMeasureProduct()
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<entUnidadMedida> Lista = null;
            try
            {
                SqlConnection cn = Conexion.Instance.sqlConnectionCursor();
                cmd = new SqlCommand("spListarUnidMed", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<entUnidadMedida>();
                while (dr.Read())
                {
                    entUnidadMedida pres = new entUnidadMedida();
                    pres.Id_Umed = Convert.ToInt32(dr["Id_Umed"]);
                    pres.Codigo_Umed = dr["Codigo_Umed"].ToString();
                    pres.Descripcion_Umed = dr["Descripcion_Umed"].ToString();
                    pres.Abreviatura_Umed = dr["Abreviatura_Umed"].ToString();
                    pres.Estado_Umed = Convert.ToInt32(dr["Estado_Umed"]);
                    Lista.Add(pres);
                }
            }
            catch (Exception) { throw; }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

        /// <summary>
        /// The ISearchCategory.
        /// </summary>
        /// <param name="catid">The catid<see cref="int"/>.</param>
        /// <returns>The <see cref="entCategory"/>.</returns>
        public entCategory ISearchCategory(int catid)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            entCategory cat = null;
            try
            {
                SqlConnection cn = Conexion.Instance.sqlConnectionCursor();
                cmd = new SqlCommand("spBuscarCategoria", cn);
                cmd.Parameters.AddWithValue("@prmidCat", catid);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    cat = new entCategory();
                    cat.Id_Cat = Convert.ToInt32(dr["Id_Cat"]);
                    cat.Codigo_Cat = dr["Codigo_Cat"].ToString();
                    cat.Nombre_Cat = dr["Nombre_Cat"].ToString();
                    cat.Descripcion_Cat = dr["Descripcion_Cat"].ToString();
                }
            }
            catch (Exception) { throw; }
            finally { cmd.Connection.Close(); }
            return cat;
        }

        /// <summary>
        /// The IShowNumProducts.
        /// </summary>
        /// <returns>The <see cref="int"/>.</returns>
        public int IShowNumProducts()
        {
            SqlCommand cmd = null;
            var result = 0;

            try
            {

                SqlConnection cn = Conexion.Instance.sqlConnectionCursor();
                cmd = new SqlCommand("spNumProductos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                result = (Int32)cmd.ExecuteScalar();
                return result;

            }
            catch (Exception) { throw; }
            finally { cmd.Connection.Close(); }
        }

        /// <summary>
        /// The ICategoryManagement.
        /// </summary>
        /// <param name="cadXml">The cadXml<see cref="String"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public int ICategoryManagement(String cadXml)
        {
            SqlCommand cmd = null;
            var resulta = 0;
            try
            {
                SqlConnection cn = Conexion.Instance.sqlConnectionCursor();
                cmd = new SqlCommand("spInsEditElimCategoria", cn);
                cmd.Parameters.AddWithValue("@prmCadXml", cadXml);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                resulta = cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { cmd.Connection.Close(); }
            return resulta;
        }

        /// <summary>
        /// The IListCategories.
        /// </summary>
        /// <returns>The <see cref="List{entCategory}"/>.</returns>
        public List<entCategory> IListCategories()
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<entCategory> Lista = null;
            try
            {
                SqlConnection cn = Conexion.Instance.sqlConnectionCursor();
                cmd = new SqlCommand("spListarCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<entCategory>();
                while (dr.Read())
                {
                    entCategory cat = new entCategory();
                    cat.Id_Cat = Convert.ToInt32(dr["Id_Cat"]);
                    cat.Codigo_Cat = dr["Codigo_Cat"].ToString();
                    cat.Nombre_Cat = dr["Nombre_Cat"].ToString();
                    cat.Descripcion_Cat = dr["Descripcion_Cat"].ToString();
                    Lista.Add(cat);
                }
            }
            catch (Exception) { throw; }
            finally { cmd.Connection.Close(); }
            return Lista;
        }
    }
}
