namespace Formkontrollsystem.Shapes;

public class Triangle : Shape
{
    private readonly double _base;
    private readonly double _height;
    
    public Triangle(string name, string color, double @base, double height) : base(name, color)
    {
        _base = @base;
        _height = height;
    }

    public override double CalculateArea()
    {
        return _base * _height / 2;
    }
}