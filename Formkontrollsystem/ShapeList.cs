using System.Reflection.Metadata;

namespace Formkontrollsystem;

public class ShapeList
{
    private List<Shape> _shapes = new();

    public void AddShape(Shape shape)
    {
        _shapes.Add(shape);
    }

    public void ShowAll()
    {
        foreach (var shape in _shapes)
        {
            shape.Show();
            Console.WriteLine(new string('-', 30));
        }
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

    public void SortByArea()
    {
        _shapes = _shapes.OrderBy(shape => shape.Area).ToList();
    }
    
    public void SortByColor()
    {
        _shapes = _shapes.OrderBy(shape => shape.Color).ToList();
    }
}