using System;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Order order1 = new Order(1);
        Order order2 = new Order(2);
        orders.Add(order1);
        orders.Add(order2);

        int counter = 1;

        foreach (var order in orders)
        {
            Console.WriteLine($"Order {counter}:");
            Console.WriteLine();
            order.DisplayOrder();
            Console.WriteLine();
            counter += 1;
        }
    }
}