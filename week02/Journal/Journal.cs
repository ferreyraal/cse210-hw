public class Journal
{

    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.DisplayEntry();
        }

    }

    public void SaveToFile(string file)
    {
        using(StreamWriter outputFile = new StreamWriter(file))
        {
            foreach(var entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}, {entry._prompt}, {entry._response}");
            }
        }

    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            
            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._prompt = parts[1];
            newEntry._response = parts[2];
            _entries.Add(newEntry);

        }

    }

}