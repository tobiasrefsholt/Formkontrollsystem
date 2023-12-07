namespace Formkontrollsystem.Shapes;

public class Circle : Shape
{
    private readonly double _radius;

    public Circle(string name, string color, double radius) : base(name, color)
    {
        _radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}