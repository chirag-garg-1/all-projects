using System;
using System.Linq;
using System.Collections.Generic;

class Product
{
    public string Category { get; set; }
    public int Quantity { get; set; }
}

class Program
{
    static void Main()
    {
        List<Product> productList = new List<Product>
        {
            new Product { Category = "Electronics", Quantity = 10 },
            new Product { Category = "Clothing", Quantity = 5 },
            new Product { Category = "Electronics", Quantity = 8 },
            new Product { Category = "Clothing", Quantity = 3 },
            new Product { Category = "Books", Quantity = 15 },
            new Product { Category = "Books", Quantity = 7 }
        };

        var categoryTotals = from p in productList
                             group p by p.Category into grouping
                             select new
                             {
                             Category = grouping.Key,
                             TotalQuantity = grouping.Sum(p => p.Quantity)
                             };

        foreach (var item in categoryTotals)
        {
            Console.WriteLine($"Category: {item.Category}, Total Quantity: {item.TotalQuantity}");
        }
    }
}
