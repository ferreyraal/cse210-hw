public class Rectangle : Shape
{
    private double _lenght = 0;
    private double _width = 0;

    public Rectangle(string color, double lenght, double width) : base(color)
    {
        _lenght = lenght;
        _width   = width;
    }

    public override double GetArea()
    {
        double area = 0;
        area = _lenght * _width;
        return area;
    }




}