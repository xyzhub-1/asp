using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.ComponentModel;
namespace API.Controllers
{
    public class ProductController : ApiController
    {
        static List<Product> products = new List<Product>
        {
            new Product { ProductId=1, ProductName="Laptop",Price=50000, Quantity= 5 },
            new Product { ProductId=2, ProductName="Mouse", Price=500, Quantity= 10 }
        };
        // GET api/<controller>
        public IEnumerable<Product> Get()
        {
            return products;
        }

        // GET api/<controller>/5
        public Product Get(int id)
        {
            return products.FirstOrDefault(p => p.ProductId == id);
        }

        // POST api/<controller>
        public void Post(Product product)
        {
            products.Add(product);
        }
        public void Put(int id, Product product)
        {
            var existing = products.FirstOrDefault(p => p.ProductId == id);
            if (existing != null)
            {
                existing.ProductName = product.ProductName;
                existing.Price = product.Price;
                existing.Quantity = product.Quantity;
            }
        }

        public void Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.ProductId == id);
            if (product != null) products.Remove(product);
        }
    }
}
