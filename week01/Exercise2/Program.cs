using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the Exercise 2 Project.");
        string letter = "";
        int grade = 0;
        Console.Write("What is your percentage grade? ");
        string grade_str = Console.ReadLine();
        grade = Convert.ToInt32(grade_str);
        if (grade >= 90)
            {
                letter = "A";
            }
        else if (grade >= 80)
            {
                letter = "B";
            }
        else if (grade >= 70)
            {
                letter = "C";
            }
        else if (grade >= 60)
            {
                letter = "D";
            }
        else 
            {
                letter = "F";
            }
        
        Console.WriteLine($"Your letter grade is: {letter}");
        if (grade >=70)
            {
                Console.WriteLine("Congratulations!  You pass the course.");
            }
        else
            {
                Console.WriteLine("You fail the course. You will have another opportunity");
            }

    }
}