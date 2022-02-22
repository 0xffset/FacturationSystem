using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaAccesoDatos;


namespace CapaNegocio
{
    public class IBusinessUser
    {
        #region singleton
        private static readonly IBusinessUser _instancia = new IBusinessUser();
        public static IBusinessUser Instancia
        {
            get
            {
                return IBusinessUser._instancia;
            }
        }
        #endregion

        public int MatenimientoUsuario(entUser u, int tipoedicion)
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
                int result = IDataAccessUser.Instancia.MatenimientoUsuario(CadXml);
                if (result == 0) throw new ApplicationException("Ocurrio un error al registrar, intentalo de nuevo");

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public entUser BuscarUsuario(String por, String valor)
        {
            try
            {
                if (por.Equals("<<<<< Selecionar >>>>>"))
                {
                    throw new ApplicationException("Seleccione un campo de búsqueda");
                }
                entUser u = null;
                u = IDataAccessUser.Instancia.BuscarUsuario(por, valor);
                if (u == null)
                {
                    throw new ApplicationException("No se encontraron registros");
                }
                return u;
            }
            catch (Exception) { throw; }
        }

     
        public entAccessLevel ListarNivelAcceDesc(Int32 idnivel)
        {
            try
            {
                return IDataAccessUser.Instancia.ListarNivelAccesoDesc(idnivel);
            }
            catch (Exception) { throw; }
        }
        public List<entAccessLevel> ListarNivelAcceso()
        {
            try
            {
                return IDataAccessUser.Instancia.ListarNivelAcceso();
            }
            catch (Exception) { throw; }
        }

   
        
        public entUser SystemAuthentication(String usu, String pass)
        {
            try
            {
                if (usu == "") throw new ApplicationException("Enter a proper user");
                if (pass == "") throw new ApplicationException("Enter a proper password");
                entUser u = null;
                u = IDataAccessUser.Instancia.AccessVerification(usu , pass);
               if (u == null)
                {
                    throw new ApplicationException("User or password invalid");
                }
                else if (u != null)
                {
                    if (u.User_State == false)
                    {
                        throw new ApplicationException("Usuario Inactivo");

                    }
                    else if (Convert.ToDateTime(u.User_Expiration) < DateTime.Now)
                    {
                        throw new ApplicationException("El Usuario ha expirado");
                    }
                }
                return u;

            }
            catch (Exception) { throw; }

        }

    }
}
