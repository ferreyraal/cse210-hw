public class ChecklistGoal : Goal
{
    protected int _amountCompleted = 0;
    protected int _target = 0;
    protected int _bonus = 0;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus, int amountcompleted) :base (shortName, description, points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountcompleted;
    }
    public override string GetStringRepresentation()
    {
        string displayComplete = "[ ]";
        if (isComplete() == true)
        {
            displayComplete = "[X]";
        }
        return $"{displayComplete} {_shortName} ({_description}) -- Currently completed: {_amountCompleted} / {_target}";
    }

    public override string GetDetailsString()
    {
        return $"Checklist Goal: {_shortName}, {_description}, {_points}, {_amountCompleted}, {_target} , {_bonus}";
    }

   public override bool isComplete()
    {
        if (_target == _amountCompleted)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    public override void RecordEvent()
    {
        _amountCompleted ++;
        if (isComplete() == true)
        {
            Console.WriteLine($"Congratulations you have earned {_points + _bonus} points");
        }
        else
        {
            Console.WriteLine($"Congratulations you have earned {_points} points");
        }
    }
    public  override int GetPoints()
    {
        if (isComplete() == true)
        {
            int pointsEarn = _points + _bonus;
            return pointsEarn;
        }
        else
        {
            return _points;
        }
    }
}