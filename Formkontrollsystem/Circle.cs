namespace Formkontrollsystem;

public class Circle : Shape
{
    private readonly double _radius;

    public Circle(string name, string color, double radius) : base(name, color)
    {
        _radius = radius;
    }

    protected override double CalculateArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}