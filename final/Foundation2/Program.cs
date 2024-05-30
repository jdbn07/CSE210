using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create some addresses
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");

        // Create some customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create some products
        Product product1 = new Product("Widget", "W123", 10.0, 2);
        Product product2 = new Product("Gadget", "G456", 20.0, 1);
        Product product3 = new Product("Thingamajig", "T789", 15.0, 3);

        // Create some orders and add products to them
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display the details of each order
        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.TotalCost()}\n");
        }
    }
}