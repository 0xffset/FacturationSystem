using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entCustomer
    {
        public int Customer_Id { get; set; }
        public String CustomerDoc_Number { get; set; }
        public String Customer_Name { get; set; }
        public String CustomeDate_Born { get; set; }
        public String Customer_Sex { get; set; }
        public String Customer_Phone { get; set; }
        public String Customer_Cellphone { get; set; }
        public String Customer_Email { get; set; }
        public String Customer_Address { get; set; }
        public Boolean Customer_State { get; set; }
        public int CustomerCreated_User { get; set; }
        public int CustomerUpdated_User { get; set; }

        //Relacion
        public entTipoDocumento tipodocumento {get; set;}

        public static implicit operator entCustomer(entProduct v)
        {
            throw new NotImplementedException();
        }
    }
}
