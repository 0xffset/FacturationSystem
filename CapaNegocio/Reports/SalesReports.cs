using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos.SalesReports;
namespace CapaNegocio.Reports
{
    public class SalesReports
    {
        //Attributes-Properties
        public DateTime reportDate { get; private set; }
        public DateTime startDate { get; private set; }
        public DateTime endDate { get; set; }
        public List<SalesListing> salesListing { get; private set; }
        public List<NetSalesByPeriod> netSalesByPeriod { get; private set; }
       public double totalNetSales { get; private set; }

     public void createdSalesReport (DateTime fromDate, DateTime toDate)
        {
            reportDate = DateTime.Now;
            startDate = fromDate;
            endDate = toDate;

            var salesOrd = new SalesDataAccesReport();
            var result = salesOrd.getSales(fromDate, toDate);

            salesListing = new List<SalesListing>();
            foreach (System.Data.DataRow rows in result.Rows)
            {
                var salesModel = new SalesListing()
                {
                    Id_Venta = Convert.ToInt32(rows[0]),
                    Codigo_Venta = Convert.ToString(rows[1]),
                    Nombre_Cliente = Convert.ToString(rows[2]),
                    Fecha_Venta = Convert.ToDateTime(rows[3]),
                    Productos = Convert.ToString(rows[4]),
                    Cantidad_Total = Convert.ToDouble(rows[5])

                };
                salesListing.Add(salesModel);

                totalNetSales += Convert.ToDouble(rows[5]);
            }

            var listSalesByDate = (from sales in salesListing
                                   group sales by sales.Fecha_Venta
                                   into listSales
                                   select new
                                   {
                                       date = listSales.Key,
                                       amount = listSales.Sum(item => item.Cantidad_Total)
                                   }).AsEnumerable();

            int totalDays = Convert.ToInt32((toDate - fromDate).Days);

            if (totalDays <= 7)
            {
                netSalesByPeriod = (from sales in listSalesByDate
                                    group sales by sales.date.ToString("dd-MMM-yyyy")
                                      into listSales
                                    select new NetSalesByPeriod
                                    {
                                        period = listSales.Key,
                                        netSale = listSales.Sum(item => item.amount)
                                    }).ToList();
            }

            else if (totalDays <=30)
            {
                netSalesByPeriod = (from sales in listSalesByDate
                                    group sales by
                                    System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                        sales.date,System.Globalization.CalendarWeekRule.FirstDay,DayOfWeek.Monday)
                                      into listSales
                                    select new NetSalesByPeriod
                                    {
                                        period = "Week" +listSales.Key,
                                        netSale = listSales.Sum(item => item.amount)
                                    }).ToList();
            }

            else if (totalDays <= 365)
            {
                netSalesByPeriod = (from sales in listSalesByDate
                                    group sales by sales.date.ToString("MMM-yyyy")
                                 
                                    into listSales
                                    select new NetSalesByPeriod
                                    {
                                        period =  listSales.Key,
                                        netSale = listSales.Sum(item => item.amount)
                                    }).ToList();
            }

            else 
            {
                netSalesByPeriod = (from sales in listSalesByDate
                                    group sales by sales.date.ToString("yyyy")

                                    into listSales
                                    select new NetSalesByPeriod
                                    {
                                        period = listSales.Key,
                                        netSale = listSales.Sum(item => item.amount)
                                    }).ToList();
            }

        }
    }
}
