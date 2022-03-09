namespace Entidades
{
    using System;

    /// <summary>
    /// Defines the <see cref="entSerie" />.
    /// </summary>
    public class entSerie
    {
        /// <summary>
        /// Gets or sets the Id_Serie.
        /// </summary>
        public int Id_Serie { get; set; }

        /// <summary>
        /// Gets or sets the Numero_Serie.
        /// </summary>
        public String Numero_Serie { get; set; }

        /// <summary>
        /// Gets or sets the Id_Sucursal_Serie.
        /// </summary>
        public int Id_Sucursal_Serie { get; set; }

        //relacion
        /// <summary>
        /// Gets or sets the sucursal.
        /// </summary>
        public entSucursal sucursal { get; set; }

        /// <summary>
        /// Gets or sets the tipcom.
        /// </summary>
        public entTipComprobante tipcom { get; set; }
    }
}
