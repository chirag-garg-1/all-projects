using System;
using System.Linq;
using System.Collections.Generic;


namespace Linqproblem5
{

    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Program
    {
        static void Main()
        {
            List<Product> products = new List<Product>
        {
            new Product { Name = "Product 1", Price = 50 },
            new Product { Name = "Product 2", Price = 120 },
            new Product { Name = "Product 3", Price = 50 },
            new Product { Name = "Product 4", Price = 20 },
            new Product { Name = "Product 5", Price = 150 },
            new Product { Name = "Product 6", Price = 500 },
            new Product { Name = "Product 7", Price = 12 },
            new Product { Name = "Product 8", Price = 5 },
            new Product { Name = "Product 9", Price = 210 },
            new Product { Name = "Product 10", Price = 1050 }
        };

            Console.WriteLine("enter the n number");
            int n = Convert.ToInt32(Console.ReadLine());

            //var top3ExpensiveProductsMS = products.OrderByDescending(p => p.Price).Take(n);

            var top3ExpensiveProductsQR = (from p in products
                                         orderby p.Price descending
                                         select p).Take(n);

            Console.WriteLine("Top 3 Most Expensive Products:");

            foreach (var product in top3ExpensiveProductsQR)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
            }
        }
    }
}
