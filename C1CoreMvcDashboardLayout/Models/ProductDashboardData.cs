using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C1CoreMvcDashboardLayout.Models
{
    public class ProductDashboardData
    {
        private IEnumerable<ProductData> _productDetails = null;
        public IEnumerable<ProductData> ProductDetails
        {
            get
            {
                if (_productDetails == null)
                {
                    _productDetails = GetProductData();
                }
                return _productDetails;
            }
        }

        public static IEnumerable<ProductData> GetProductData()
        {
            var rand = new Random(0);
            var productID = new[] { "PR001", "PR002", "PR003", "PR004", "PR005" };
            var products = new[] { "Ipoh Coffee", "Vegie-Spread", "Ikura", "Filo Mix", "Geitost" };
            var categories = new[] { "Beverages", "Confections", "Seafood", "Cereals", "Dairy Products" };

            var list = products.Select((p, i) =>
            {
                int stockunits = rand.Next(1, 6);
                int orderunits = rand.Next(1, 9);
                int sales = rand.Next(1, 6);
                return new ProductData { ProductID = productID[i], ProductName = p, Category = categories[i], UnitsInStock = stockunits, UnitsOnOrder = orderunits, Sales = sales, ReorderLevel = true };
            });

            return list;
        }
    }

    public class ProductData
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int Sales { get; set; }
        public bool ReorderLevel { get; set; }
    }
}
