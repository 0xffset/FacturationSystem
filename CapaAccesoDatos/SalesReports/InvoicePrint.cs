using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaAccesoDatos.SalesReports
{
   public class InvoicePrint
    {
        SqlConnection cn = Conexion.Instancia.sqlConnectionCursor();
        public DataTable getSaleDetailsByIdSale(int _IdSale)
        {
            using (var connection = cn)
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT dt.PrecProd_Det, dt.Itbis_Det, dt.Cantidad_Det, p.Codigo_Prod, p.Descuento_Prod, p.Nombre_Prod,  dt.Total_Det, u.Abreviatura_Umed
                        FROM DetalleVenta dt INNER JOIN Producto p ON 
                        dt.Id_Prod_Det = p.Id_Prod INNER JOIN UnidadMedida u ON
                        u.Id_Umed = p.Id_Umed_prod
                        WHERE dt.Id_Venta_Det = @idSale
                        GROUP BY dt.Id_Det, dt.PrecProd_Det, dt.Itbis_Det, dt.Cantidad_Det, p.Codigo_Prod, p.Descuento_Prod, p.Nombre_Prod, dt.Total_Det, u.Abreviatura_Umed
                        ORDER BY dt.Id_Det
                        ";
                    command.Parameters.Add("@idSale", SqlDbType.Int).Value = _IdSale;

                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();
                    return table;
                }
            }
        }

        public DataTable getCustomerDataBySaleId(int _idSale)
        {
            using (var connection = cn)
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT c.Correo_Cliente, c.Telefono_Cliente, c.Direccion_Cliente, c.NumeroDoc_Cliente, v.Codigo_Venta,  c.Nombre_Cliente FROM Cliente c INNER JOIN Venta v ON
                    c.Id_Cliente = v.Id_Cliente_Venta
                    WHERE v.Id_Venta = @idSale
                        ";
                    command.Parameters.Add("@idSale", SqlDbType.Int).Value = _idSale;

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
