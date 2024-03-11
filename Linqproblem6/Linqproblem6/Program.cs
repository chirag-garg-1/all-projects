using System;
using System.Linq;
using System.Collections.Generic;

namespace Linqproblem6
{
    class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
    }

    class Order
    {
        public int CustomerID { get; set; }
        public int OrderID { get; set; }
        public int Total { get; set; }
    }

    class Program
    {
        static void Main()
        {
            List<Customer> customers = new List<Customer>
        {
            new Customer { CustomerID = 1, Name = "Chirag" },
            new Customer { CustomerID = 2, Name = "Aayush" }
        };

            List<Order> orders = new List<Order>
        {
            new Order { CustomerID = 1, OrderID = 101, Total = 50 },
            new Order { CustomerID = 1, OrderID = 102, Total = 75 },
            new Order { CustomerID = 2, OrderID = 103, Total = 100 },
            new Order { CustomerID = 2, OrderID = 104, Total = 125 }
        };

            var query = from customer in customers
                        join order in orders on customer.CustomerID equals order.CustomerID
                        select new
                        {
                            CustomerName = customer.Name,
                            OrderID = order.OrderID,
                            OrderTotal = order.Total
                        };

            foreach (var item in query)
            {
                Console.WriteLine($"Customer Name: {item.CustomerName}, Order ID: {item.OrderID}, Order Total: {item.OrderTotal}");
            }
        }
    }
}