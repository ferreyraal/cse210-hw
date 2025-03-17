public class Fraction
{
    private int _top = 0;
    private int _bottom = 0;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetTop(int value)
    {
        _top = value;
    }
    public void SetBottom(int value)
    {
        _bottom = value;
    }

    public string GetFractionString()
    {
        string fraction = $" {_top} / {_bottom}";
        return fraction;
    }

    public double GetDecimalValue()
    {
        double result = (double)_top / (double)_bottom;
        return result;
    }
}