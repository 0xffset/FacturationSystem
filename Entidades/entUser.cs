using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entUser
    {
        public int User_Id { get; set; }
        public String User_Code { get; set; }
        public String User_Name { get; set; }
        public String User_Login { get; set; }
        public String User_Password { get; set; }
        public String User_Phone { get; set; }
        public String User_Cellphone { get; set; }
        public String User_Email { get; set; }
        public Boolean User_State { get; set; }
        public String User_Expiration { get; set; }
        public int UserCreated_User { get; set; }
        public int UserUpdated_User { get; set; }
        public String User_DomainEmail { get; set; }
        // Relacion -------------------------------------
        public entAccessLevel access_level { get; set; }
        public entSucursal sucursal { get; set; } 
        

    }
}
