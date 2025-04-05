public class GratitudeActivity : Activity
{
    public GratitudeActivity()
    {
        _name = "Gratitude Activity";
        _description = "This activity will help you focus on things you are grateful for.";
        _duration = 0;
    }


public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine($"Get Ready...");
        ShowSpinner(3);

        DateTime startTime  = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("");
            Console.Write ("Think of three things you’re grateful for today.");
            ShowSpinner(_duration);

        }

        DisplayEndingMessage();
    }

}