public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 0;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine($"Get Ready...");
        ShowSpinner(3);

        int remaining = _duration;
        int breath_in = 0;
        int breath_out = 0; 
        DateTime startTime  = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            if (remaining >= 10)
            {
                breath_in = 4;
                breath_out = 6;
            }
            else 
            {
                breath_in = (int)Math.Round(remaining * 0.4);
                breath_out = (int)Math.Round(remaining + 0.6);
            }
            Console.WriteLine("");
            Console.Write ("Breathe in... ");
            ShowCountDown(breath_in);
            Console.WriteLine("");
            Console.Write ("Now breathe out... ");
            ShowCountDown(breath_out);
            Console.WriteLine("");
            remaining = remaining - breath_in - breath_out;
        }

        DisplayEndingMessage();
    }
}