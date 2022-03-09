namespace Entidades
{
    using System;

    /// <summary>
    /// Defines the <see cref="entProduct" />.
    /// </summary>
    public class entProduct
    {
        /// <summary>
        /// Gets or sets the Id_Prod.
        /// </summary>
        public int Id_Prod { get; set; }

        /// <summary>
        /// Gets or sets the Codigo_Prod.
        /// </summary>
        public String Codigo_Prod { get; set; }

        /// <summary>
        /// Gets or sets the Nombre_Prod.
        /// </summary>
        public String Nombre_Prod { get; set; }

        /// <summary>
        /// Gets or sets the Marca_Prod.
        /// </summary>
        public String Marca_Prod { get; set; }

        /// <summary>
        /// Gets or sets the PrecioCompra_Prod.
        /// </summary>
        public Double PrecioCompra_Prod { get; set; }

        /// <summary>
        /// Gets or sets the Descuento_Prod.
        /// </summary>
        public Double Descuento_Prod { get; set; }

        /// <summary>
        /// Gets or sets the Precio_Prod.
        /// </summary>
        public Double Precio_Prod { get; set; }

        /// <summary>
        /// Gets or sets the ITBIS_Prod.
        /// </summary>
        public int ITBIS_Prod { get; set; }

        /// <summary>
        /// Gets or sets the Stock_Prod.
        /// </summary>
        public int Stock_Prod { get; set; }

        /// <summary>
        /// Gets or sets the StockProm_Prod.
        /// </summary>
        public int StockProm_Prod { get; set; }

        /// <summary>
        /// Gets or sets the StockMin_Prod.
        /// </summary>
        public int StockMin_Prod { get; set; }

        /// <summary>
        /// Gets or sets the UsuarioCreacion_Prod.
        /// </summary>
        public int UsuarioCreacion_Prod { get; set; }

        /// <summary>
        /// Gets or sets the UsuarioUpdate_Prod.
        /// </summary>
        public int UsuarioUpdate_Prod { get; set; }

        /// <summary>
        /// Gets or sets the FechVen_Pord.
        /// </summary>
        public String FechVen_Pord { get; set; }

        //Relacion
        /// <summary>
        /// Gets or sets the categoria.
        /// </summary>
        public entCategory categoria { get; set; }

        /// <summary>
        /// Gets or sets the unidmedida.
        /// </summary>
        public entUnidadMedida unidmedida { get; set; }

        /// <summary>
        /// Gets or sets the proveedor.
        /// </summary>
        public entSupplier proveedor { get; set; }

        /// <summary>
        /// Defines the _material.
        /// </summary>
        private entMaterial _material;

        /// <summary>
        /// Gets or sets the material.
        /// </summary>
        public entMaterial material
        {
            get { if (_material == null) { _material = new entMaterial(); } return _material; }
            set { _material = value; }
        }

        //guardar vriable para detalle_venta
        /// <summary>
        /// Gets or sets the Cantidad_.
        /// </summary>
        public int Cantidad_ { get; set; }
    }
}
