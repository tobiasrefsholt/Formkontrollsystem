using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace Formkontrollsystem;

public class ShapeList
{
    private readonly List<Shape> _shapes = new();

    public void AddShape(Shape shape)
    {
        _shapes.Add(shape);
    }

    public void ShowAll(List<Shape> shapes)
    {
        foreach (var shape in shapes)
        {
            shape.Show();
            Console.WriteLine(new string('-', 30));
        }
    }

    public void ShowAll()
    {
        ShowAll(_shapes);
    }

    public void ShowByArea()
    {
        ShowAll(_shapes.OrderBy(shape => shape.Area).ToList());
    }

    public void ShowByColor()
    {
        ShowAll(_shapes.OrderBy(shape => shape.Color).ToList());
    }

    public void ShowFilterByColors(string color)
    {
        var filteredList = new List<Shape>();
        foreach (var shape in _shapes)
        {
            if (string.Equals(shape.Color, color, StringComparison.CurrentCultureIgnoreCase))
                filteredList.Add(shape);
        }
        ShowAll(filteredList);
    }

    public void ShowTotalArea()
    {
        Console.WriteLine("Total area of shapes: " + CalculateTotalArea() + " m^2");
    }

    private double CalculateTotalArea()
    {
        var totalArea = (double)0;
        foreach (var shape in _shapes)
        {
            totalArea += shape.CalculateArea();
        }

        return totalArea;
    }
}