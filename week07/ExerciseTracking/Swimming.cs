public class Swimming : Activity
{
    protected int _laps = 0;

    public Swimming(string date, int lenght, int laps): base (date, lenght)
    {
        _date = date;
        _lenght = lenght;
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return Math.Round((GetDistance() / _lenght) * 60,2);
    }

    public override double GetPace()
    {
        return Math.Round(60 / GetSpeed(),2);
    }

}