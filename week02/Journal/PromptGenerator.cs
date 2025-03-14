public class PromptGenerator
{
    public List<string> _prompts;

    public PromptGenerator()
    {
    }

    public string GetRandomPrompt()
    {
        _prompts = new List<string>
        {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something I learned today?",
        "How did I express kindness or gratitude today?",
        "What is one moment I am grateful for today?",
        "How did I take care of myself today, mentally, physically, or emotionally?",
        "What is one thing I am proud of accomplishing today?",
        };

        Random randomGenerator = new Random();
        int prompt_number = randomGenerator.Next(0, 9);
        string prompt = _prompts[prompt_number];
        return prompt;
    }
}