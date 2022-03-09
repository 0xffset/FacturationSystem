namespace Entidades
{
    using System;

    /// <summary>
    /// Defines the <see cref="entUser" />.
    /// </summary>
    public class entUser
    {
        /// <summary>
        /// Gets or sets the User_Id.
        /// </summary>
        public int User_Id { get; set; }

        /// <summary>
        /// Gets or sets the User_Code.
        /// </summary>
        public String User_Code { get; set; }

        /// <summary>
        /// Gets or sets the User_Name.
        /// </summary>
        public String User_Name { get; set; }

        /// <summary>
        /// Gets or sets the User_Login.
        /// </summary>
        public String User_Login { get; set; }

        /// <summary>
        /// Gets or sets the User_Password.
        /// </summary>
        public String User_Password { get; set; }

        /// <summary>
        /// Gets or sets the User_Phone.
        /// </summary>
        public String User_Phone { get; set; }

        /// <summary>
        /// Gets or sets the User_Cellphone.
        /// </summary>
        public String User_Cellphone { get; set; }

        /// <summary>
        /// Gets or sets the User_Email.
        /// </summary>
        public String User_Email { get; set; }

        /// <summary>
        /// Gets or sets the User_State.
        /// </summary>
        public Boolean User_State { get; set; }

        /// <summary>
        /// Gets or sets the User_Expiration.
        /// </summary>
        public String User_Expiration { get; set; }

        /// <summary>
        /// Gets or sets the UserCreated_User.
        /// </summary>
        public int UserCreated_User { get; set; }

        /// <summary>
        /// Gets or sets the UserUpdated_User.
        /// </summary>
        public int UserUpdated_User { get; set; }

        /// <summary>
        /// Gets or sets the User_DomainEmail.
        /// </summary>
        public String User_DomainEmail { get; set; }

        // Relacion -------------------------------------
        /// <summary>
        /// Gets or sets the access_level.
        /// </summary>
        public entAccessLevel access_level { get; set; }

        /// <summary>
        /// Gets or sets the sucursal.
        /// </summary>
        public entSucursal sucursal { get; set; }
    }
}
