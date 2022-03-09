namespace CapaNegocio.Reports
{
    using System;

    /// <summary>
    /// Defines the <see cref="SalesListing" />.
    /// </summary>
    public class SalesListing
    {
        /// <summary>
        /// Gets or sets the Id_Venta.
        /// </summary>
        public int Id_Venta { get; set; }

        /// <summary>
        /// Gets or sets the Codigo_Venta.
        /// </summary>
        public String Codigo_Venta { get; set; }

        /// <summary>
        /// Gets or sets the Nombre_Cliente.
        /// </summary>
        public String Nombre_Cliente { get; set; }

        /// <summary>
        /// Gets or sets the Fecha_Venta.
        /// </summary>
        public DateTime Fecha_Venta { get; set; }

        /// <summary>
        /// Gets or sets the Productos.
        /// </summary>
        public String Productos { get; set; }

        /// <summary>
        /// Gets or sets the Cantidad_Total.
        /// </summary>
        public Double Cantidad_Total { get; set; }
    }
}
