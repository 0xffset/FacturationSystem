namespace Entidades
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="entSale" />.
    /// </summary>
    public class entSale
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
        /// Gets or sets the Serie_Venta.
        /// </summary>
        public int Serie_Venta { get; set; }

        /// <summary>
        /// Gets or sets the Correlativo_Venta.
        /// </summary>
        public String Correlativo_Venta { get; set; }

        /// <summary>
        /// Gets or sets the Igv_Venta.
        /// </summary>
        public Double Igv_Venta { get; set; }

        /// <summary>
        /// Gets or sets the MontoIgv_Venta.
        /// </summary>
        public Double MontoIgv_Venta { get; set; }

        /// <summary>
        /// Gets or sets the FechaVenta.
        /// </summary>
        public DateTime FechaVenta { get; set; }

        /// <summary>
        /// Gets or sets the Estado_Venta.
        /// </summary>
        public String Estado_Venta { get; set; }

        /// <summary>
        /// Gets or sets the Descuento_Venta.
        /// </summary>
        public Double Descuento_Venta { get; set; }

        /// <summary>
        /// Gets or sets the Desc_Venta.
        /// </summary>
        public string Desc_Venta { get; set; }

        /// <summary>
        /// Gets or sets the Utilidad.
        /// </summary>
        public double Utilidad { get; set; }

        /// <summary>
        /// Gets or sets the Inversion.
        /// </summary>
        public double Inversion { get; set; }

        // Campo calculado
        /// <summary>
        /// Gets or sets the Total.
        /// </summary>
        public double Total { get; set; }

        //Relaciones
        /// <summary>
        /// Gets or sets the cliente.
        /// </summary>
        public entCustomer cliente { get; set; }

        /// <summary>
        /// Gets or sets the usuario.
        /// </summary>
        public entUser usuario { get; set; }

        /// <summary>
        /// Gets or sets the moneda.
        /// </summary>
        public entMoneda moneda { get; set; }

        /// <summary>
        /// Gets or sets the sucursal.
        /// </summary>
        public entSucursal sucursal { get; set; }

        /// <summary>
        /// Gets or sets the tipocomprobante.
        /// </summary>
        public entTipComprobante tipocomprobante { get; set; }

        /// <summary>
        /// Gets or sets the tipopago.
        /// </summary>
        public entTipoPago tipopago { get; set; }

        /// <summary>
        /// Gets or sets the detalleventa.
        /// </summary>
        public List<entDetalleVenta> detalleventa { get; set; }
    }
}
