public class Square : Shape
{
    private double _side = 0;


    public Square(string color, double side) : base(color)
    {
        _side = side;
        _color = color;
    }

    public override double GetArea()
    {
        double area = 0;
        area = _side * _side;
        return area;
    }




}