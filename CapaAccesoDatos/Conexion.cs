

namespace CapaAccesoDatos
{
    using System;
    using System.Data.SqlClient;

    /// <summary>
    /// Defines the SQL Conexion class <see cref="Conexion" />. 
    /// </summary>
    public class Conexion
    {
        /// <summary>
        /// Defines the _instance.
        /// </summary>
        private static readonly Conexion _instance = new Conexion();

        /// <summary>
        /// Gets the Instance.
        /// </summary>
        public static Conexion Instance
        {
            get
            {
                return Conexion._instance;
            }
        }

        /// <summary>
        /// Yield a SqlConnection with the proper connection established.
        /// </summary>
        /// <returns>The <see cref="SqlConnection"/>.</returns>
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
}
