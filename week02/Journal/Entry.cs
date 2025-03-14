public class Entry
{
    public string _prompt = "";
    public string _response = "";
    public string _date = "";

    public Entry()
    {

    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"{_response}");
        Console.WriteLine("");
    }
}