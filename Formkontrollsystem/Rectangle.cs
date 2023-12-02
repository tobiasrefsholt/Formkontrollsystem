namespace Formkontrollsystem;

public class Rectangle : Shape
{
    private readonly double _length;
    private readonly double _width;

    public Rectangle(string name, string color, double length, double width) : base(name, color)
    {
        _length = length;
        _width = width;
    }

    protected override double CalculateArea()
    {
        return _length * _width;
    }
}