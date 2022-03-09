namespace Entidades
{
    using System;

    /// <summary>
    /// Defines the <see cref="entTipComprobante" />.
    /// </summary>
    public class entTipComprobante
    {
        /// <summary>
        /// Gets or sets the Id_TipCom.
        /// </summary>
        public int Id_TipCom { get; set; }

        /// <summary>
        /// Gets or sets the Codigo_TipCom.
        /// </summary>
        public String Codigo_TipCom { get; set; }

        /// <summary>
        /// Gets or sets the Nombre_TipCom.
        /// </summary>
        public String Nombre_TipCom { get; set; }

        /// <summary>
        /// Gets or sets the Descrpcion_TipCom.
        /// </summary>
        public String Descrpcion_TipCom { get; set; }

        //Relaciones
        /// <summary>
        /// Gets or sets the tipomovimiento.
        /// </summary>
        public entTipoMovimiento tipomovimiento { get; set; }
    }
}
