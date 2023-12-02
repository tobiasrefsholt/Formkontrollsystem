namespace Formkontrollsystem;

public class ShapeList
{
    private readonly List<Shape> _shapes = new();

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
}