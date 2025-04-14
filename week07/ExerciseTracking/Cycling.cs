public class Cycling : Activity
{
    protected double _speed = 0;  // km/h

    public Cycling(string date, int lenght, double speed): base (date, lenght)
    {
        _date = date;
        _lenght = lenght;
        _speed = speed;
    }

    public override double GetDistance()
    {
        return Math.Round(_speed * _lenght / 60,2);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return Math.Round(60 / _speed,2);
    }

}   