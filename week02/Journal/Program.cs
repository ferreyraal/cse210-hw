using System;

class Program
{
    static void Main(string[] args)
    {

        // Showing Creativity and Exceeding Requirements
        // I will create a new option (6) to enter a new prompt (given by the user) and the response 
        //  The user will be able to create their own and unique use prompt and response to create an entry.

        int option = 0;
        string user_entry = "";
        // Creat an intance of Journal 
        Journal theJournal = new Journal();
        string filename = "";
        do
        {
            // Display menu
            Console.WriteLine("");
            Console.WriteLine("Please Select one the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("6. Extra (Write your own prompt)");
            Console.Write("What would you like to do? ");

            // Enter option 
            user_entry = Console.ReadLine();
            option = Convert.ToInt32(user_entry);
            if (option == 1)            // New entry to the journal
            {
                // Get a prompt from Class PromptGenerator
                PromptGenerator newprompt = new PromptGenerator();
                string prompt = newprompt.GetRandomPrompt();

                // Print promt on screen and aks user a response
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                string todayText = theCurrentTime.ToShortDateString();

                // Creat an instance of 
                Entry newEntry = new Entry();
                newEntry._date = todayText;
                newEntry._prompt = prompt;
                newEntry._response = response;

                theJournal.AddEntry(newEntry);
            }
            if (option == 2)        // Display Journal
            {
                theJournal.DisplayAll();
            }

            if (option == 3)        // Load file
            {
                Console.Write("What is the name of the file? ");
                filename = Console.ReadLine();
                if (filename != "")
                {
                    theJournal.LoadFromFile(filename);
                }

            }

            if (option == 4)        // Save file 
            {
                Console.Write("What is the name of the file? ");
                filename = Console.ReadLine();
                if (filename != "")
                {
                    theJournal.SaveToFile(filename);
                }

            }

            if (option == 6)         // Write an entry with the user prompt 
            {
                Console.WriteLine("What is your own prompt to response today? ");
                Console.Write("> ");
                string prompt = Console.ReadLine();
                // Print promt on screen and aks user a response
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                string todayText = theCurrentTime.ToShortDateString();

                // Creat an instance of 
                Entry newEntry = new Entry();
                newEntry._date = todayText;
                newEntry._prompt = prompt;
                newEntry._response = response;

                theJournal.AddEntry(newEntry);
            }
        } while (option != 5);



    }
}