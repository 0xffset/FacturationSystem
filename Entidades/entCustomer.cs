namespace Entidades
{
    using System;

    /// <summary>
    /// Defines the <see cref="entCustomer" />.
    /// </summary>
    public class entCustomer
    {
        /// <summary>
        /// Gets or sets the Customer_Id.
        /// </summary>
        public int Customer_Id { get; set; }

        /// <summary>
        /// Gets or sets the CustomerDoc_Number.
        /// </summary>
        public String CustomerDoc_Number { get; set; }

        /// <summary>
        /// Gets or sets the Customer_Name.
        /// </summary>
        public String Customer_Name { get; set; }

        /// <summary>
        /// Gets or sets the CustomeDate_Born.
        /// </summary>
        public String CustomeDate_Born { get; set; }

        /// <summary>
        /// Gets or sets the Customer_Sex.
        /// </summary>
        public String Customer_Sex { get; set; }

        /// <summary>
        /// Gets or sets the Customer_Phone.
        /// </summary>
        public String Customer_Phone { get; set; }

        /// <summary>
        /// Gets or sets the Customer_Cellphone.
        /// </summary>
        public String Customer_Cellphone { get; set; }

        /// <summary>
        /// Gets or sets the Customer_Email.
        /// </summary>
        public String Customer_Email { get; set; }

        /// <summary>
        /// Gets or sets the Customer_Address.
        /// </summary>
        public String Customer_Address { get; set; }

        /// <summary>
        /// Gets or sets the Customer_State.
        /// </summary>
        public Boolean Customer_State { get; set; }

        /// <summary>
        /// Gets or sets the CustomerCreated_User.
        /// </summary>
        public int CustomerCreated_User { get; set; }

        /// <summary>
        /// Gets or sets the CustomerUpdated_User.
        /// </summary>
        public int CustomerUpdated_User { get; set; }

        //Relacion
        /// <summary>
        /// Gets or sets the tipodocumento.
        /// </summary>
        public entTipoDocumento tipodocumento { get; set; }


        public static implicit operator entCustomer(entProduct v)
        {
            throw new NotImplementedException();
        }
    }
}
