using System;
using System.Linq;
using System.Collections.Generic;

class Customer
{
    public string Name { get; set; }
    public List<Order> Orders { get; set; }
}

class Order
{
    public int OrderID { get; set; }
    public int TotalValue { get; set; }
}

class Program
{
    static void Main()
    {      
        List<Customer> customers = new List<Customer>
        {
            new Customer
            {
                Name = "CHIRAG",
                Orders = new List<Order>
                {
                    new Order { OrderID = 1, TotalValue = 100 },
                    new Order { OrderID = 2, TotalValue = 150 },
                    new Order { OrderID = 3, TotalValue = 200 }
                }
            },
            new Customer
            {
                Name = "AAYUSH",
                Orders = new List<Order>
                {
                    new Order { OrderID = 4, TotalValue = 50 },
                    new Order { OrderID = 5, TotalValue = 500 },
                    new Order { OrderID = 6, TotalValue = 40 }
                }
            }
        };

        int threshold = 150;

        var selectedCustomers = from customer in customers
                                where customer.Orders.Sum(order => order.TotalValue) > threshold
                                select new
                                {
                                    customer.Name,
                                    Orders = customer.Orders.Select(order => new { order.OrderID, order.TotalValue }),
                                    TotalOrderValue = customer.Orders.Sum(order => order.TotalValue)
                                };

        foreach (var customer in selectedCustomers)
        {
            Console.WriteLine($"Customer Name: {customer.Name}, Total Order Value: {customer.TotalOrderValue}");
            foreach (var order in customer.Orders)
            {
                Console.WriteLine($"    Order ID: {order.OrderID}, Total Value: {order.TotalValue}");
            }
            Console.WriteLine();
        }
    }
}
