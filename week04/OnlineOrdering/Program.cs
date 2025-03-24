using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Address address1 = new Address("221 Backer St ", "SLC", "UT", "USA");
        Customer customer1 = new Customer("Cory Kenneth", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("133888", "Bed dog large black", 15.70, 1));
        order1.AddProduct(new Product("230116", "long pink dog leash", 3.20, 1));
        order1.AddProduct(new Product("501401", "Canvas premiun dog food", 9.00, 2));

        Address address2 = new Address("Manuel Dorrego 337", "Florencio Varela", "BA", "Argentina");
        Customer customer2 = new Customer("Alejandro Ferreyra", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("501401", "Canvas premiun dog food", 9.00, 2));
        order2.AddProduct(new Product("702883", "Doy Toy mouse with sound", 2.11, 1));

        Console.WriteLine("Shipping Label");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("");
        Console.WriteLine("Packing Label");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Total order: {order1.GettotalOrder()}");

        Console.WriteLine("");
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("");

        Console.WriteLine("Shipping Label");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("");
        Console.WriteLine("Packing Label");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Total order: {order2.GettotalOrder()}");

    }
}