using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        // Creating customer information
        Customer customer1 = new Customer("Sally May", new Address("1931 W 180 S St", "Orem", "UT", "USA"));
        Customer customer2 = new Customer("Polter Gheist", new Address("1922 12th st SW", "Calgary", "AB", "Canada"));

        // Create available products
        Product product1 = new Product("Fishing Pole", "F227", 175, 1);
        Product product2 = new Product("Lures", "F216", 35, 6);
        Product product3 = new Product("Tub of Worms", "F212", 12, 1);

        // Creates List of what is ordered 
        List<Product> productsOrder1 = new List<Product> {product1, product3};
        List<Product> productsorder2 = new List<Product> {product1, product2, product3};

        // Assigns orders to customers
        Order order1 = new Order(productsOrder1, customer1);
        Order order2 = new Order(productsorder2, customer2);

        // Lay out of packing and shipping labels pulling from other classes methods.
        Console.WriteLine("Order 1");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Order 1");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("\nOrder 1 Total Cost: $" + order1.GetTotalPrice());

        Console.WriteLine("\nOrder 2");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\nOrder 2");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("\nOrder 2 Total Cost: $" + order2.GetTotalPrice());
    }
}