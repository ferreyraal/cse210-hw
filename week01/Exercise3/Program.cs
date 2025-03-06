using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is Exercise 3 Project.");
        // Random number
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 100);
        int guess_number = 0;
        int track = 0;
        do 
        {
        Console.Write("What is your guess number? ");
        string str_number = Console.ReadLine();
        guess_number = Convert.ToInt32(str_number);
        track += 1;
        if (magic_number == guess_number)
            {
                Console.WriteLine($"You guessed it in {track} attempts.");
            }
        else if (magic_number > guess_number)
            {
                Console.WriteLine("Higher");
            }
        else
            {
                Console.WriteLine("Lower");
            }
        
        } while (magic_number != guess_number);

            
    }
}