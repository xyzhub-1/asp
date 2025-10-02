using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cart
{
    public class ShoppingCart
    {
        public List<Product> ProductsInCart { get; set; }

        public ShoppingCart()
        {
            ProductsInCart = new List<Product>();
        }

    }
}