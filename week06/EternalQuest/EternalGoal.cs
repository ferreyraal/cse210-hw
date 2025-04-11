public class EternalGoal : Goal
{


    public EternalGoal(string shortName, string description, int points) :base (shortName, description, points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }
    public override string GetStringRepresentation()
    {
        string displayComplete = "[ ]";
        return $"{displayComplete} {_shortName} ({_description})";
    }

    public override string GetDetailsString()
    {
        return $"Eternal Goal: {_shortName}, {_description}, {_points}";
    }

   public override bool isComplete()
    {
        return false;
    }

        public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations you have earned {_points} points");
    }
        public  override int GetPoints()
    {
        return _points;
    }
}