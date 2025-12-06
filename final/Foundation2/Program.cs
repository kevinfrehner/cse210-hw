using System;

class Program
{
    static void Main(string[] args)
    {
         Address addr1 = new Address("123 Maple St", "Denver", "CO", "USA");
        Customer cust1 = new Customer("Sarah Johnson", addr1);

        Address addr2 = new Address("55 King Street", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Michael Stevens", addr2);

        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Wireless Mouse", "WM100", 25.99, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "MK200", 89.99, 1));

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Noise-Canceling Headphones", "NC500", 199.99, 1));
        order2.AddProduct(new Product("USB-C Hub", "USB300", 34.99, 3));

        Console.WriteLine("---------------------------------------");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():0.00}");
        Console.WriteLine("---------------------------------------\n");

        Console.WriteLine("---------------------------------------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():0.00}");
        Console.WriteLine("---------------------------------------");
    }
}
