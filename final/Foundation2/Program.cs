using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "Phoenix", "AZ", "USA");
        Customer customer1 = new Customer("Boston Wyatt", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Culinary knife", "KN001", 20.99, 1));
        order1.AddProduct(new Product("Monster Energy Drink", "MN039", 3.58, 1));

        Console.WriteLine("Order 1:");
        Console.WriteLine("PackingLabel:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine();

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Cost: ${order1.TotalCost()}");
        Console.WriteLine();


        Address address2 = new Address("456 W Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Ryan Reynolds", address2);

        Order order2 = new Order(customer2);

        order1.AddProduct(new Product("Monitor", "M129", 129.99, 1));
        order1.AddProduct(new Product("HDMI Cable", "CBL01", 10.00, 2));

        Console.WriteLine("Order 2:");
        Console.WriteLine("PackingLabe2:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine();

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Cost: ${order2.TotalCost()}");
        Console.WriteLine();
    
    }
}