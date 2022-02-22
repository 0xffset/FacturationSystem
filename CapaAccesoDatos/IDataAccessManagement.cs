using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
   public  class IDataAccessManagement
   {
       #region singleton
       private static readonly IDataAccessManagement _instancia = new IDataAccessManagement();
       public static IDataAccessManagement Instancia
       {
           get { return IDataAccessManagement._instancia; }
       }

       #endregion

       #region metodos
       public List<entProduct>LstProdIndicadorAvanzada(String nam)
       {
           SqlCommand cmd = null;
           SqlDataReader dr = null;
           List<entProduct> Lista = null;

           try
           {
               SqlConnection cn = Conexion.Instancia.sqlConnectionCursor();
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

       public List<entProduct> ListarProdIndicador(String codigo, int idcat, int rango)
       {
           SqlCommand cmd = null;
           SqlDataReader dr = null;
           List<entProduct> Lista = null;

           try
           {
               SqlConnection cn = Conexion.Instancia.sqlConnectionCursor();
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

           public List<entProduct> BuscarProdAvanzada(int tipentrada, String valor_entrada)
           {
               SqlCommand cmd = null;
               SqlDataReader dr = null;
               List<entProduct> Lista = null;
               try
               {
                   SqlConnection cn = Conexion.Instancia.sqlConnectionCursor();
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
       public entProduct buscarprod(int idpo)
       {
           SqlCommand cmd = null;
           SqlDataReader dr = null;
           entProduct prod = null;
           try
           {
               SqlConnection cn = Conexion.Instancia.sqlConnectionCursor();
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
                       prod.Precio_Prod = Convert.ToDouble(dr["Precio_Prod"]);
                       prod.Stock_Prod = Convert.ToInt32(dr["Stock_Prod"]);
                       prod.StockProm_Prod = Convert.ToInt32(dr["StockProm_Prod"]);
                       prod.StockMin_Prod = Convert.ToInt32(dr["StockMin_Prod"]);
                       prod.FechVen_Pord = dr["FechVen_Prod"].ToString();
                       

                       entCategory cat = new entCategory();
                       cat.Id_Cat = Convert.ToInt32(dr["Id_Cat"]);
                       prod.categoria = cat;
                       
                       entUnidadMedida pres = new entUnidadMedida();
                       pres.Id_Umed = Convert.ToInt32(dr["Id_Umed"]);
                       prod.unidmedida = pres;
                       entSupplier prov = new entSupplier();
                        prov.Id_Proveedor = Convert.ToInt32(dr["Id_Proveedor"]);
                        prod.proveedor= prov;
                      
                       
               }

           }
           catch (Exception) {throw;}
           finally {cmd.Connection.Close();}
           return prod;

       }

       public List<entProduct> listarproducto()
       {
           SqlCommand cmd =null;
           SqlDataReader dr= null;
           List<entProduct> Lista = null;
           try 
           {
               SqlConnection cn = Conexion.Instancia.sqlConnectionCursor();
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
                   entUnidadMedida pres = new  entUnidadMedida();
                   pres.Descripcion_Umed = dr["Descripcion_Umed"].ToString();
                   prod.unidmedida = pres;
                   entSupplier prov = new entSupplier();
                   prov.RazSocial_Proveedor = dr["RazSocial_Proveedor"].ToString();
                    
                   prod.proveedor = prov;
                   Lista.Add(prod);
               }
           }
           catch (Exception) {throw;}
           finally {cmd.Connection.Close();}
           return Lista;
       }

       public int mantenimeintoprod(String CadXml)
       {
           SqlCommand cmd = null;
           var resu = 0;
           try
           {
               SqlConnection cn = Conexion.Instancia.sqlConnectionCursor();
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

       public int mantenimeintoprovee(String CadXml)
       {
           SqlCommand cmd = null;
           var resu = 0;
           try
           {
               SqlConnection cn = Conexion.Instancia.sqlConnectionCursor();
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

       public int mantenimeintopresentacionprod(String CadXml)
       {
           SqlCommand cmd = null;
           var resu = 0;
           try
           {
               SqlConnection cn = Conexion.Instancia.sqlConnectionCursor();
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
            
             
              
      public entSupplier buscarprov(int idprove)
       {
           SqlCommand cmd = null;
           SqlDataReader dr = null;
           entSupplier prov = null;
           try
           {
               SqlConnection cn = Conexion.Instancia.sqlConnectionCursor();
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

       public entUnidadMedida BuscarPresentacion(int idpres)
      {
          SqlCommand cmd = null;
          SqlDataReader dr = null;
          entUnidadMedida pres = null;
          try
          {
              SqlConnection cn = Conexion.Instancia.sqlConnectionCursor();
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

       public List<entSupplier> ListarProveedor()
       {
           SqlCommand cmd = null;
           SqlDataReader dr = null;
           List<entSupplier> Lista = null;
           try
           {
               SqlConnection cn = Conexion.Instancia.sqlConnectionCursor();
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

       public List<entUnidadMedida> ListarPresentacion()
       {
           SqlCommand cmd = null;
           SqlDataReader dr = null;
           List<entUnidadMedida> Lista = null;
           try
           {
               SqlConnection cn = Conexion.Instancia.sqlConnectionCursor();
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

       public entCategory BuscarCat(int catid)
       {
           SqlCommand cmd = null;
           SqlDataReader dr = null;
          entCategory cat   = null;
           try
           {
               SqlConnection cn = Conexion.Instancia.sqlConnectionCursor();
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
        public int numProductos()
        {
            SqlCommand cmd = null;
            var result = 0;

            try
            {

                SqlConnection cn = Conexion.Instancia.sqlConnectionCursor();
                cmd = new SqlCommand("spNumProductos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                result = (Int32)cmd.ExecuteScalar();
                return result;
                
            }
            catch (Exception) { throw; }
            finally { cmd.Connection.Close(); }
        }

       public int Mantenimeintocategoria(String cadXml)
       {
           SqlCommand cmd = null;
           var resulta = 0;
           try
           {
               SqlConnection cn = Conexion.Instancia.sqlConnectionCursor();
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

       public List<entCategory> ListarCategoria()
       {
           SqlCommand cmd = null;
           SqlDataReader dr = null;
           List<entCategory> Lista = null;
           try
           {
               SqlConnection cn = Conexion.Instancia.sqlConnectionCursor();
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

       #endregion
   }

