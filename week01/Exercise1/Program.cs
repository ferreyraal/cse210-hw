using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user first name, and last name
        Console.Write("What is your first name? ");
        string name = Console.ReadLine();
        
        Console.Write("What is your last name?? ");
        string lastname = Console.ReadLine();
        
        // Print name in a specific format
        Console.WriteLine($"Your name is {lastname}, {name} {lastname}");
    }
}