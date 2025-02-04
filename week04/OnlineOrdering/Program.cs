using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        // Creating addresses
        var address1 = new Address("2 Radar Street", "Aerodrome", "IB", "NIGERIA");
        var address2 = new Address("7 Rumens Street", "Victoria Island", "Lagos", "Nigeria");

        // Creating customers
        var customer1 = new Customer("Oluwaseun Aremu", address1);
        var customer2 = new Customer("Israel Obasohan", address2);

        // Creating products
        var product1 = new Product("Laptop", "A128", 1026.99, 1);
        var product2 = new Product("Mouse", "B182", 30.99, 2);
        var product3 = new Product("Keyboard", "C142", 59.99, 1);
        var product4 = new Product("Monitor", "D124", 279.99, 1);

        // Creating orders
        var order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        var order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Displaying order information
        DisplayOrderInfo(order1);
        DisplayOrderInfo(order2);
    }

    private static void DisplayOrderInfo(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}");
        Console.WriteLine();
    }
}
