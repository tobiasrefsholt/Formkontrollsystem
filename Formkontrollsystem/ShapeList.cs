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
        Console.Clear();
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
        Console.Clear();
        Console.WriteLine("Total area of shapes: " + CalculateTotalArea() + " m^2");
    }

    public void AddTestData()
    {
        AddShape(new Circle("Big", "red", 2654));
        AddShape(new Circle("Small", "red", 12));
        AddShape(new Rectangle("Some house", "yellow", 30.5, 23));
        AddShape(new Rectangle("Really big house", "pink", 637.5, 9001.2));
        AddShape(new Triangle("Christmas Tree", "green", 3, 12));
        AddShape(new Triangle("Triangle (instrument)", "green", 0.1, 0.1));
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