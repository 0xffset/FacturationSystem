namespace CapaAccesoDatos.SalesReports
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

    /// <summary>
    /// Defines the <see cref="SalesDataAccesReport" />.
    /// </summary>
    public class SalesDataAccesReport
    {
        /// <summary>
        /// Defines the cn.
        /// </summary>
        internal SqlConnection cn = Conexion.Instance.sqlConnectionCursor();

        /// <summary>
        /// The getSales.
        /// </summary>
        /// <param name="fromDate">The fromDate<see cref="DateTime"/>.</param>
        /// <param name="toDate">The toDate<see cref="DateTime"/>.</param>
        /// <returns>The <see cref="DataTable"/>.</returns>
        public DataTable getSales(DateTime fromDate, DateTime toDate)
        {
            using (var connection = cn)
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"select v.Id_Venta, v.Codigo_Venta, c.Nombre_Cliente, v.FechaVenta, 
                        Productos = stuff((select ' - ' + 'x'+convert(varchar (10),vt2.Cantidad_Det)+' '+ Producto.Nombre_Prod
	                        from DetalleVenta vt2 inner join Producto on Producto.Id_Prod = vt2.Id_Prod_Det
	                        where vt2.Id_Venta_Det = v.Id_Venta  for xml path('')), 1, 2, ''),
                        SUM((vt.Cantidad_Det)* p.Precio_Prod - v.Descuento_Venta) as Cantidad_Total
                        from venta v inner join DetalleVenta vt
                        on v.Id_Venta = vt.Id_Venta_Det inner join Cliente c
                        on c.Id_Cliente = v.Id_Cliente_Venta inner join Producto p
                        on p.Id_Prod = vt.Id_Prod_Det
                        where v.FechaVenta between @fromDate AND @toDate
                        group by v.Id_Venta,v.Codigo_Venta,  c.Nombre_Cliente, v.FechaVenta
                        order by v.Id_Venta asc";
                    command.Parameters.Add("@fromDate", SqlDbType.Date).Value = fromDate;
                    command.Parameters.Add("@toDate", SqlDbType.DateTime).Value = toDate;

                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();
                    return table;


                }
            }
        }
    }
}
