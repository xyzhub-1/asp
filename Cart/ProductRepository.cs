using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cart
{
    public class ProductRepository
    {
        public static List<Product> GetAllProducts()
        {
            return new List<Product>
            {
                new Product { ProductID = 1, ProductName = "Product 1", Price = 10.99M },
                new Product { ProductID = 2, ProductName = "Product 2", Price = 19.99M },
                new Product { ProductID = 3, ProductName = "Product 3", Price = 5.99M }
            };
        }
    }
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}

   