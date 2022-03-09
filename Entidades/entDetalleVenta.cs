namespace Entidades
{
    using System;

    /// <summary>
    /// Defines the <see cref="entDetalleVenta" />.
    /// </summary>
    public class entDetalleVenta
    {
        /// <summary>
        /// Gets or sets the Id_Det.
        /// </summary>
        public int Id_Det { get; set; }

        /// <summary>
        /// Gets or sets the Id_Prod_Det.
        /// </summary>
        public int Id_Prod_Det { get; set; }

        /// <summary>
        /// Gets or sets the PrecProd_Det.
        /// </summary>
        public Double PrecProd_Det { get; set; }

        /// <summary>
        /// Gets or sets the Cantidad_Det.
        /// </summary>
        public int Cantidad_Det { get; set; }

        /// <summary>
        /// Gets or sets the Itbis_Det.
        /// </summary>
        public Double Itbis_Det { get; set; }

        /// <summary>
        /// Gets or sets the Descuento_det.
        /// </summary>
        public Double Descuento_det { get; set; }

        //Relacion
        /// <summary>
        /// Gets or sets the venta.
        /// </summary>
        public entSale venta { get; set; }

        /// <summary>
        /// Gets or sets the producto.
        /// </summary>
        public entProduct producto { get; set; }

        /// <summary>
        /// Gets or sets the usurio.
        /// </summary>
        public entUser usurio { get; set; }

        /// <summary>
        /// Gets or sets the cliete.
        /// </summary>
        public entCustomer cliete { get; set; }
    }
}
