using System;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        string user_entry = "";
        do{
            // Start menu options
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Start gratitud activity");
            // I will add a new activity and change quit to 5 option.
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu:");

            user_entry = Console.ReadLine();
            option = Convert.ToInt32(user_entry);
            if (option == 1)
            {
                BreathingActivity activity1 = new BreathingActivity();
                activity1.Run();
                
            }   
            if (option == 2)
            {
                ReflectingActivity activity2 = new ReflectingActivity();
                activity2.Run();
            }   
            if (option == 3)
            {
                ListingActivity activity3 = new ListingActivity();
                activity3.Run();
            }

            if (option == 4)
            {
                GratitudeActivity activity4 = new GratitudeActivity();
                activity4.Run();
            }

        } while (option != 5);

    }
}