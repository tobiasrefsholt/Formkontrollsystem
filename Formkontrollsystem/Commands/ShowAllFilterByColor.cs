namespace Formkontrollsystem.Commands;

public class ShowAllFilterByColor : Command
{
    public ShowAllFilterByColor(ShapeList shapeList, ConsoleKey character) : base(shapeList, character)
    {
        Description = "Filter by color";
    }

    public override void Run()
    {
        Console.Write("Color to filter: ");
        var selectedColor = Console.ReadLine() ?? string.Empty;
        ShapeList.ShowFilterByColors(selectedColor);
    }
}