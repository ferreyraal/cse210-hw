public abstract class Activity
{
    protected string _date = "";
    protected int _lenght = 0;  // minutes

    public Activity(string date, int lenght)
    {
        _date = date;
        _lenght = lenght;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();

    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_lenght} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}