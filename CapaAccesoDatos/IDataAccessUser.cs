namespace CapaAccesoDatos
{
    using Entidades;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;

    /// <summary>
    /// Defines the <see cref="IDataAccessUser" />.
    /// </summary>
    public class IDataAccessUser
    {
        /// <summary>
        /// Defines the _instance.
        /// </summary>
        private static readonly IDataAccessUser _instance = new IDataAccessUser();

        /// <summary>
        /// Gets the Instance.
        /// </summary>
        public static IDataAccessUser Instance
        {
            get { return IDataAccessUser._instance; }
        }

        /// <summary>
        /// The IUserManagement.
        /// </summary>
        /// <param name="cadxml">The cadxml<see cref="String"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public int IUserManagement(String cadxml)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instance.sqlConnectionCursor();
                cmd = new SqlCommand("spInsEditElimUsario", cn);
                cmd.Parameters.AddWithValue("@Cadxml", cadxml);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@retorno", DbType.Int32);
                p.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(p);
                cn.Open();
                var resultado = cmd.ExecuteNonQuery();
                return resultado;

            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// The ISearchUserByValue.
        /// </summary>
        /// <param name="por">The por<see cref="String"/>.</param>
        /// <param name="valor">The valor<see cref="String"/>.</param>
        /// <returns>The <see cref="entUser"/>.</returns>
        public entUser ISearchUserByValue(String por, String valor)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            entUser u = null;
            try
            {
                SqlConnection cn = Conexion.Instance.sqlConnectionCursor();
                cmd = new SqlCommand("spBuscarUsuario", cn);
                cmd.Parameters.AddWithValue("@prmBusqueda", por);
                cmd.Parameters.AddWithValue("@prmValor", valor);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    u = new entUser();
                    u.User_Id = Convert.ToInt32(dr["Id_Usuario"]);
                    u.User_Code = dr["Codigo_Usuario"].ToString();
                    u.User_Name = dr["Nombre_Usuario"].ToString();
                    u.User_Login = dr["Login_Usuario"].ToString();
                    u.User_Password = dr["Password_Usuario"].ToString();
                    u.User_Phone = dr["Telefono_Usuario"].ToString();
                    u.User_Cellphone = dr["Celular_Usuario"].ToString();
                    u.User_Email = dr["Correo_Usuario"].ToString();
                    u.User_State = Convert.ToBoolean(dr["Estado_Usuario"]);
                    u.User_Expiration = dr["Expiracion_Usuario"].ToString();
                    entAccessLevel na = new entAccessLevel();
                    na.Id_NivelAcc = Convert.ToInt32(dr["Id_NivelAcc"]);
                    u.access_level = na;



                }

            }
            catch (Exception)
            { throw; }
            finally { cmd.Connection.Close(); }
            return u;
        }

        /// <summary>
        /// The IListDescAccessLevel.
        /// </summary>
        /// <param name="idnivel">The idnivel<see cref="Int32"/>.</param>
        /// <returns>The <see cref="entAccessLevel"/>.</returns>
        public entAccessLevel IListDescAccessLevel(Int32 idnivel)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            entAccessLevel na = null;

            try
            {
                SqlConnection cn = Conexion.Instance.sqlConnectionCursor();
                cmd = new SqlCommand("SpMostrarDescNivel", cn);
                cmd.Parameters.AddWithValue("@prmNivelAcceso", idnivel);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    na = new entAccessLevel();
                    na.Descripcion_NivelAcc = dr["Descripcion_NivelAcc"].ToString();
                }
            }
            catch (Exception)
            { throw; }
            finally { cmd.Connection.Close(); }
            return na;
        }

        /// <summary>
        /// The IListAccessLevel.
        /// </summary>
        /// <returns>The <see cref="List{entAccessLevel}"/>.</returns>
        public List<entAccessLevel> IListAccessLevel()
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<entAccessLevel> Lista = null;

            try
            {
                SqlConnection cn = Conexion.Instance.sqlConnectionCursor();
                cmd = new SqlCommand("spListaNivelAcceso", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open(); /* AQUI TENIA UN ERROR xD! */
                dr = cmd.ExecuteReader();
                Lista = new List<entAccessLevel>();
                while (dr.Read())
                {
                    entAccessLevel na = new entAccessLevel();
                    na.Id_NivelAcc = Convert.ToInt32(dr["Id_NivelAcc"]);
                    na.Numero_NivelAcc = Convert.ToInt32(dr["Numero_NivelAcc"]);
                    na.Descripcion_NivelAcc = dr["Descripcion_NivelAcc"].ToString();
                    Lista.Add(na);
                }
            }
            catch (Exception)
            { throw; }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

        /// <summary>
        /// The ISystemAuthentication.
        /// </summary>
        /// <param name="user">The user<see cref="String"/>.</param>
        /// <param name="password">The password<see cref="String"/>.</param>
        /// <returns>The <see cref="entUser"/>.</returns>
        public entUser ISystemAuthentication(String user, String password)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            entUser u = null;

            try
            {
                SqlConnection cn = Conexion.Instance.sqlConnectionCursor();
                cmd = new SqlCommand("spVerifyAccess", cn);
                cmd.Parameters.AddWithValue("@prmUser", user);
                cmd.Parameters.AddWithValue("@prmPassword", password);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    u = new entUser();
                    u.User_Id = Convert.ToInt32(dr["Id_Usuario"]);
                    u.User_Name = dr["Nombre_Usuario"].ToString();
                    u.User_Expiration = dr["Expiracion_Usuario"].ToString();
                    u.User_State = Convert.ToBoolean(dr["Estado_Usuario"]);
                    entAccessLevel na = new entAccessLevel();
                    na.Id_NivelAcc = Convert.ToInt32(dr["Id_NivelAcc"]);
                    na.Numero_NivelAcc = Convert.ToInt32(dr["Numero_NivelAcc"]);
                    u.access_level = na;

                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return u;
        }
    }
}
