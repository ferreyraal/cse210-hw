public class Circle : Shape
{
    private double _radius = 0;


    public Circle(string color, double radius) : base(color)
    {   
        _radius = radius;
        _color = color;
    }

    public override double GetArea()
    {
        double area = 0;
        area = Math.PI * Math.Pow(_radius, 2);
        return area;
    }

}