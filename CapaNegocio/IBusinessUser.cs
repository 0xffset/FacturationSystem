namespace CapaNegocio
{
    using CapaAccesoDatos;
    using Entidades;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="IBusinessUser" />.
    /// </summary>
    public class IBusinessUser
    {
        /// <summary>
        /// Defines the _instancia.
        /// </summary>
        private static readonly IBusinessUser _instance = new IBusinessUser();

        /// <summary>
        /// Gets the Instancia.
        /// </summary>
        public static IBusinessUser Instance
        {
            get
            {
                return IBusinessUser._instance;
            }
        }

        /// <summary>
        /// The UserManagement.
        /// </summary>
        /// <param name="u">The u<see cref="entUser"/>.</param>
        /// <param name="tipoedicion">The tipoedicion<see cref="int"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public int UserManagement(entUser u, int tipoedicion)
        {

            try
            {
                String CadXml = "";
                CadXml += "<usuario ";
                CadXml += "idusuario='" + u.User_Id + "' ";
                CadXml += "idnivelacceso='" + u.access_level.Id_NivelAcc + "' ";

                CadXml += "nombre='" + u.User_Name + "' ";
                CadXml += "logeo='" + u.User_Login + "' ";
                CadXml += "pass='" + u.User_Password + "' ";
                CadXml += "telefono='" + u.User_Phone + "' ";
                CadXml += "celular='" + u.User_Cellphone + "' ";
                CadXml += "correo='" + u.User_Email + "' ";
                CadXml += "estado='" + u.User_State + "' ";
                CadXml += "usuariocreacion='" + u.UserCreated_User + "' ";
                CadXml += "expiracion='" + u.User_Expiration + "' ";
                CadXml += "tipoedicion='" + tipoedicion + "'/>";

                CadXml = "<root>" + CadXml + "</root>";
                int result = IDataAccessUser.Instance.IUserManagement(CadXml);
                if (result == 0) throw new ApplicationException("Ocurrio un error al registrar, intentalo de nuevo");

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// The SearchUserByValue.
        /// </summary>
        /// <param name="por">The por<see cref="String"/>.</param>
        /// <param name="valor">The valor<see cref="String"/>.</param>
        /// <returns>The <see cref="entUser"/>.</returns>
        public entUser SearchUserByValue(String por, String valor)
        {
            try
            {
                if (por.Equals("<<<<< Selecionar >>>>>"))
                {
                    throw new ApplicationException("You must enter a search parameter");
                }
                entUser u = null;
                u = IDataAccessUser.Instance.ISearchUserByValue(por, valor);
                if (u == null)
                {
                    throw new ApplicationException("No records found.");
                }
                return u;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The ListAccessLevel.
        /// </summary>
        /// <param name="idnivel">The idnivel<see cref="Int32"/>.</param>
        /// <returns>The <see cref="entAccessLevel"/>.</returns>
        public entAccessLevel ListAccessLevel(Int32 idnivel)
        {
            try
            {
                return IDataAccessUser.Instance.IListDescAccessLevel(idnivel);
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The ListarNivelAcceso.
        /// </summary>
        /// <returns>The <see cref="List{entAccessLevel}"/>.</returns>
        public List<entAccessLevel> ListarNivelAcceso()
        {
            try
            {
                return IDataAccessUser.Instance.IListAccessLevel();
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The SystemAuthentication.
        /// </summary>
        /// <param name="usu">The usu<see cref="String"/>.</param>
        /// <param name="pass">The pass<see cref="String"/>.</param>
        /// <returns>The <see cref="entUser"/>.</returns>
        public entUser SystemAuthentication(String usu, String pass)
        {
            try
            {
                if (usu == "") throw new ApplicationException("Enter a proper user");
                if (pass == "") throw new ApplicationException("Enter a proper password");
                entUser u = null;
                u = IDataAccessUser.Instance.ISystemAuthentication(usu, pass);
                if (u == null)
                {
                    throw new ApplicationException("User or password invalid");
                }
                else if (u != null)
                {
                    if (u.User_State == false)
                    {
                        throw new ApplicationException("User inactive");

                    }
                    else if (Convert.ToDateTime(u.User_Expiration) < DateTime.Now)
                    {
                        throw new ApplicationException("User has been expired.");
                    }
                }
                return u;

            }
            catch (Exception) { throw; }
        }
    }
}
