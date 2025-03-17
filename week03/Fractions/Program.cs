using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction newFraction = new Fraction();

        Fraction sample1 = new Fraction();
        Console.WriteLine(sample1.GetDecimalValue());
        Console.WriteLine(sample1.GetFractionString());

        Fraction sample2 = new Fraction(5);
        Console.WriteLine(sample2.GetDecimalValue());
        Console.WriteLine(sample2.GetFractionString());

        Fraction sample3 = new Fraction(3,4);
        Console.WriteLine(sample3.GetDecimalValue());
        Console.WriteLine(sample3.GetFractionString());

        Fraction sample4 = new Fraction(1,3);
        Console.WriteLine(sample4.GetDecimalValue());
        Console.WriteLine(sample4.GetFractionString());
    }
}