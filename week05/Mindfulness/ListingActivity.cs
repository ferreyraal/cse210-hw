public class ListingActivity : Activity
{
        private int _count = 0;
        private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 0;
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("WWho are some of your personal heroes?");
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine($"Get Ready...");
        ShowSpinner(3);
        Console.WriteLine("");
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine("");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("");
        _count = GetListFromUser().Count;
        Console.WriteLine($"You listed {_count} items! ");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        DateTime startTime  = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        List<string> _responses = new List<string>();
        while (DateTime.Now < endTime)
        {
            string response = "";
            Console.Write("> ");
            response = Console.ReadLine();
            _responses.Add(response);
        }
        return _responses;
    }



}