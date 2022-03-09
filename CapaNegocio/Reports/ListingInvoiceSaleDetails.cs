namespace CapaNegocio.Reports
{
    using System;

    /// <summary>
    /// Defines the <see cref="ListingInvoiceSaleDetails" />.
    /// </summary>
    public class ListingInvoiceSaleDetails
    {
        /// <summary>
        /// Gets or sets the Code_Product.
        /// </summary>
        public String Code_Product { get; set; }

        /// <summary>
        /// Gets or sets the PriceProd_Det.
        /// </summary>
        public Double PriceProd_Det { get; set; }

        /// <summary>
        /// Gets or sets the Itbis_Det.
        /// </summary>
        public Double Itbis_Det { get; set; }

        /// <summary>
        /// Gets or sets the Amount_Det.
        /// </summary>
        public int Amount_Det { get; set; }

        /// <summary>
        /// Gets or sets the Discount_Det.
        /// </summary>
        public Double Discount_Det { get; set; }

        /// <summary>
        /// Gets or sets the Name_Product.
        /// </summary>
        public String Name_Product { get; set; }

        /// <summary>
        /// Gets or sets the Total_Det.
        /// </summary>
        public Double Total_Det { get; set; }

        /// <summary>
        /// Gets or sets the Unit_Product.
        /// </summary>
        public String Unit_Product { get; set; }
    }
}
