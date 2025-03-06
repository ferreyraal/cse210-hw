using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the Exercise 4 Project.");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 1;
        List<int> numbers = new List<int>();

        do
            {
                Console.Write("Enter number: ");
                string str_number = Console.ReadLine();
                number = Convert.ToInt32(str_number);
                if (number == 0)
                    {
                        // Don´t add number to list
                    }
                else
                    {
                        numbers.Add(number);
                    }
                

            } while (number != 0);
        int total = 0;
        float avg = 0;
        int largest = 0;
        int quantity = 0;
        foreach (int numb in numbers)
            {
                total += numb;
                if (numb > largest)
                    {
                        largest = numb;
                    }
            }
        quantity = numbers.Count;
        Console.WriteLine($"The sum is: {total}");
        avg = ((float)total) / quantity;
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largest}");

    }
}