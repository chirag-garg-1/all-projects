using System.Collections.Generic;
using System;
using System.Linq;

namespace LINQDemo
{
    public class Product
    {
        public string Category { get; set; }
        public int Quantity { get; set; }


        public static List<Product> GetAllProducts()
        {
            List<Product> ProductList = new List<Product>()
            {
            new Product { Category = "Electronics", Quantity = 10 },
            new Product { Category = "Clothing", Quantity = 5 },
            new Product { Category = "Electronics", Quantity = 8 },
            new Product { Category = "Clothing", Quantity = 3 },
            new Product { Category = "Books", Quantity = 15 },
            new Product { Category = "Books", Quantity = 7 }
            };
            return ProductList;
        }
    }
}
