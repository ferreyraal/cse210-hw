public class Activity
{

    protected string _name = "";
    protected string _description = "";
    protected int _duration = 0;

    public Activity()

    {
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine("");
        Console.WriteLine($"{_description}");
        string time_str = "";
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        time_str = Console.ReadLine();
        _duration = Convert.ToInt32(time_str);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("");
        Console.WriteLine($"Well done!!");
        Console.WriteLine("");
        ShowSpinner(2);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");

        DateTime startTime  = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int count = 0;

        while (DateTime.Now < endTime)
        {
            string x = spinner[count];
            Console.Write(x);
            Thread.Sleep(500);
            Console.Write("\b \b");
            count++;

            if (count >= spinner.Count)
            {
                count = 0;
            }
        }
        
    } 

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b"); 
        }
    }
}