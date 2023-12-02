namespace Formkontrollsystem;

public abstract class Shape
{
    private readonly string _name;
    private readonly string _color;

    protected Shape(string name, string color)
    {
        _name = name;
        _color = color;
    }

    public void Show()
    {
        Console.WriteLine("Name: " + _name);
        Console.WriteLine("Color: " + _color);
        Console.WriteLine("Area: " + CalculateArea() + "m^2");
    }

    public abstract double CalculateArea();
}