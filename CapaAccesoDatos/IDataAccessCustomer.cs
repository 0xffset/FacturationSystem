using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace CapaAccesoDatos
{
    public class IDataAccessCustomer
    {
        #region singleton
        private static readonly IDataAccessCustomer _instancia = new IDataAccessCustomer();
        public static IDataAccessCustomer Instancia
        {
            get { return IDataAccessCustomer._instancia; }
        }
        #endregion singleton

        #region metodos
        public List<entCustomer> AdvSearchCustomer(String nom_cli)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<entCustomer> list = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.sqlConnectionCursor();
                cmd = new SqlCommand("spSearchCustomerByName", cn);
                cmd.Parameters.AddWithValue("@prmName_Customer", nom_cli);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                list = new List<entCustomer>();
                while (dr.Read())
                {
                    entCustomer cliente = new entCustomer();
                    cliente.Customer_Id = Convert.ToInt32(dr["Id_Cliente"]);
                    entTipoDocumento td = new entTipoDocumento();
                    td.Id_TipDoc = Convert.ToInt32(dr["Id_TipDoc_Cliente"].ToString());
                    td.Nombre_TipDoc = dr["Nombre_TipDoc"].ToString();
                    cliente.tipodocumento = td;
                    cliente.CustomerDoc_Number = dr["NumeroDoc_Cliente"].ToString();
                    cliente.Customer_Phone = dr["Telefono_Cliente"].ToString();
                    cliente.Customer_Cellphone = dr["Celular_Cliente"].ToString();
                    cliente.Customer_Email = dr["Telefono_Cliente"].ToString();
                    cliente.Customer_Address = dr["Direccion_Cliente"].ToString();
                    cliente.CustomeDate_Born = dr["FechaNac_Cliente"].ToString();
                    list.Add(cliente);


                    
                }
            }
            catch (Exception) { throw; }
            finally { cmd.Connection.Close(); }
            return list;
        }

        public entCustomer SearchClient(int id_cli, String nro_Doc)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            entCustomer cliente = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.sqlConnectionCursor();
                cmd = new SqlCommand("spBuscarCliente", cn);
                cmd.Parameters.AddWithValue("@prmidCliente", id_cli);
                cmd.Parameters.AddWithValue("@prmNroDoc", nro_Doc);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    cliente = new entCustomer();
                    cliente.Customer_Id = Convert.ToInt32(dr["Id_Cliente"]);
                    entTipoDocumento td = new entTipoDocumento();
                    td.Id_TipDoc = Convert.ToInt32(dr["Id_TipDoc_Cliente"].ToString());
                    td.Nombre_TipDoc = dr["Nombre_TipDoc"].ToString();
                    cliente.tipodocumento = td;
                    cliente.CustomerDoc_Number = dr["NumeroDoc_Cliente"].ToString();
                    cliente.Customer_Name = dr["Nombre_Cliente"].ToString();
                    cliente.Customer_Phone = dr["Telefono_Cliente"].ToString();
                    cliente.Customer_Cellphone = dr["Celular_Cliente"].ToString();
                    cliente.Customer_Email = dr["Correo_Cliente"].ToString();
                    cliente.Customer_Address = dr["Direccion_Cliente"].ToString();
                    cliente.CustomeDate_Born = dr["FechaNac_Cliente"].ToString();
                    cliente.Customer_Sex = dr["Sexo_Cliente"].ToString();

                }
            }

            catch (Exception) { throw; }
            finally { cmd.Connection.Close(); }
            return cliente;
        }

        public List<entCustomer> ListCustomers()
        {
            SqlCommand cmd  = null;
            SqlDataReader dr = null;
            List<entCustomer> Lista = null;
            try 
            {
                SqlConnection cn = Conexion.Instancia.sqlConnectionCursor();
                cmd = new SqlCommand("spCustomerList", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<entCustomer>();
                while (dr.Read())
                {
                    entCustomer customer = new entCustomer();
                    customer.Customer_Id = Convert.ToInt32(dr["Id_Cliente"]);
                    entTipoDocumento td = new entTipoDocumento();
                    td.Nombre_TipDoc = dr["Nombre_TipDoc"].ToString();
                    customer.tipodocumento = td;
                    customer.CustomerDoc_Number = dr["NumeroDoc_Cliente"].ToString();
                    customer.Customer_Name = dr["Nombre_Cliente"].ToString();
                    customer.Customer_Phone = dr["Telefono_Cliente"].ToString();
                    customer.Customer_Cellphone = dr["Celular_Cliente"].ToString();
                    customer.Customer_Email = dr["Correo_Cliente"].ToString();
                    customer.Customer_Address = dr["Direccion_Cliente"].ToString();
                    Lista.Add(customer);
                }
                

            }
            catch (Exception) { throw; }
            finally { cmd.Connection.Close(); }
            return Lista;
        }
        
        public int numCliente()
        {
            SqlCommand cmd = null;
            var resultado = 0;
            try 
            {
                SqlConnection cnd = Conexion.Instancia.sqlConnectionCursor();

                cmd = new SqlCommand("spNumClientes", cnd);
                cnd.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                resultado = (Int32)cmd.ExecuteScalar();
                return resultado;

            }

            catch (Exception) { throw; }
            finally { cmd.Connection.Close(); }
        }

        public int customerManagement(String cadXml)
        {
            SqlCommand cmd = null;
            var resultado = 0;

            try 
            {
                SqlConnection cn = Conexion.Instancia.sqlConnectionCursor();
                cmd = new SqlCommand("spInsEditElimCliente", cn);
                cmd.Parameters.AddWithValue("@prmCadXml", cadXml);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                resultado = cmd.ExecuteNonQuery();
                return resultado;
            }
            catch (Exception) { throw; }
            finally { cmd.Connection.Close(); }
        }

        public List<entTipoDocumento> listartipdoc(){
    
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        List<entTipoDocumento> Lista = null;
        try
        {
            SqlConnection cn = Conexion.Instancia.sqlConnectionCursor();
            cmd = new SqlCommand("spListarTipDoc", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            dr = cmd.ExecuteReader();
            Lista = new List<entTipoDocumento>();
            while (dr.Read())
            {
                entTipoDocumento td = new entTipoDocumento();
                td.Id_TipDoc = Convert.ToInt32(dr["Id_TipDoc"]);
                td.Abreviatura_TipDoc = dr["Abreviatura_TipDoc"].ToString();
                Lista.Add(td);
            }
         


        }
        catch (Exception) { throw; }
        finally { cmd.Connection.Close(); }

        return Lista;




       
        
        
    }


        #endregion
    }
}
