using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class Conexion
    {
        #region singleton
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get
            {
                return Conexion._instancia;
            }
        }
        #endregion

        #region metodos
        public SqlConnection sqlConnectionCursor()
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = "Data Source=DESKTOP-3QR4NTR\\SQLEXPRESS;Initial Catalog=BDsistemaROLEY;Integrated Security=True";
                return cn;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
        #endregion
}


   
   

