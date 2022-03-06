using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos.SalesReports;

namespace CapaNegocio.Reports
{
    public class InvoicePrintDomain
    {
        // Attributes-Properties
        public List<ListingInvoiceSaleDetails> ListingInvoiceSaleDetails { get; private set; }
        public List<CustomerInvoiceData> customerInvoiceData { get; private set; }

        public double totalNetSales { get; private set; }
        public double totaItbisSales { get; private set; }
        public double totalDiscountSales { get; private set; }
        public double totalPriceSale { get; private set; }

        public void loadCustomerData(int _idSale)
        {
            var data = new InvoicePrint();
            var result = data.getCustomerDataBySaleId(_idSale);

             customerInvoiceData = new List<CustomerInvoiceData>();
                var dataModel = new CustomerInvoiceData()
                {
                    Email_Customer = result.Rows[0].ItemArray[0].ToString(),
                    Phone_Customer = result.Rows[0].ItemArray[1].ToString(),
                    Address_Customer = result.Rows[0].ItemArray[2].ToString(),
                    DNI_Customer = result.Rows[0].ItemArray[3].ToString(),
                    Code_Sale = result.Rows[0].ItemArray[4].ToString(),
                    Name_Customer = result.Rows[0].ItemArray[5].ToString()
                    
                };
                customerInvoiceData.Add(dataModel);
            
        }
        public void createdSalesDetails(int _idSale)
        {
            var salesDetails = new InvoicePrint();
            var result = salesDetails.getSaleDetailsByIdSale(_idSale);
            ListingInvoiceSaleDetails = new List<ListingInvoiceSaleDetails>();
            foreach (System.Data.DataRow rows in result.Rows)
            {
                var saleModel = new ListingInvoiceSaleDetails()
                {
                    PriceProd_Det = Convert.ToDouble(rows[0]),
                    Itbis_Det = Convert.ToDouble(rows[1]),
                    Amount_Det = Convert.ToInt32(rows[2]),
                    Code_Product = rows[3].ToString(),
                    Discount_Det = Convert.ToDouble(rows[4]),
                    Name_Product = rows[5].ToString(),
                    Total_Det = Convert.ToDouble(rows[6])

                };
                ListingInvoiceSaleDetails.Add(saleModel);

                totalNetSales += Convert.ToDouble(rows[0]);
                totaItbisSales += Convert.ToDouble(rows[1]);
                totalDiscountSales += Convert.ToDouble(rows[4]);
                totalPriceSale += Convert.ToDouble(rows[6]);
            }
        }
    }
}
