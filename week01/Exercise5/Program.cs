using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        DisplayResult(name, number);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string str_name = Console.ReadLine();
        return str_name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string str_number = Console.ReadLine();
        int number = Convert.ToInt32(str_number);
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int number)
    {
        int square = SquareNumber(number); 
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}