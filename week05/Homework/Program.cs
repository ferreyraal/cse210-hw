using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("This is the Homework Project.");
        Console.WriteLine("");
        Assignment assigment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assigment1.GetSummary());
        Console.WriteLine("");        

        MathAssignment math1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());
        Console.WriteLine("");

        WritingAssignment writing1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());

    }
}