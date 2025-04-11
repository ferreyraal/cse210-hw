public abstract class Goal
{

    protected string _shortName = "";
    protected string _description = "";
    protected int _points = 0;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }
    public abstract int GetPoints();

    public abstract string GetStringRepresentation();

    public abstract string GetDetailsString();

    public abstract bool isComplete();

    public abstract void RecordEvent();

}

    