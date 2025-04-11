public class SimpleGoal : Goal
{
    protected bool _isComplete = false;

    public SimpleGoal(string shortName, string description, int points, bool isComplete) :base (shortName, description, points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    public override string GetStringRepresentation()
    {
        string displayComplete = "[ ]";
        if (isComplete() == true)
        {
            displayComplete = "[X]";
        }

        return $"{displayComplete} {_shortName} ({_description})";
        
    }

    public override string GetDetailsString()
    {
        return $"Simple Goal: {_shortName}, {_description}, {_points}, {_isComplete}";
    }
    public override bool isComplete()
    {
        return _isComplete;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations you have earned {_points} points");
        _isComplete = true;
    }

    public  override int GetPoints()
    {
        return _points;
    }
}