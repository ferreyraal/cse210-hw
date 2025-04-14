public class Running : Activity
{
    protected double _distance = 0;  // km

    public Running(string date, int lenght, double distance): base (date, lenght)
    {
        _date = date;
        _lenght = lenght;
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return Math.Round((_distance / _lenght) * 60,2);
    }

    public override double GetPace()
    {
        return Math.Round(60 / GetSpeed(),2);
    }
}

