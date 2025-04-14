using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Clear();

        List<Activity> _act = new List<Activity>();

        Running activity1 = new Running("14 apr 2025", 33, 4.8);    // Date, minutes, distance
        _act.Add(activity1);
        Cycling activity2 = new Cycling("15 apr 2025", 49, 27);    // Date, minutes, speed
        _act.Add(activity2);
        Swimming activity3 = new Swimming("16 apr 2025", 65, 190);  // Date, minutes, laps
        _act.Add(activity3);


        foreach (Activity x in _act)
        {
            Console.WriteLine(x.GetSummary());
        }
   




    }
}