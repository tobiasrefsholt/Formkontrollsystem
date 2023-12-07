namespace Formkontrollsystem.Shapes;

public abstract class Shape
{
    public string Name { get; }
    public string Color { get; }
    public double Area => CalculateArea();

    protected Shape(string name, string color)
    {
        Name = name;
        Color = color;
    }

    public void Show()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Color: " + Color);
        Console.WriteLine("Area: " + CalculateArea() + "m^2");
    }

    public abstract double CalculateArea();
}