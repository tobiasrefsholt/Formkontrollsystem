namespace Formkontrollsystem.Commands;

public class ShowAllFilterByColor : Command
{
    public ShowAllFilterByColor(ShapeList shapeList, ConsoleKey character) : base(shapeList, character)
    {
        Description = "Show all and filter by color";
    }

    public override void Run()
    {
        Console.Write("Color to filter: ");
        var selectedColor = Console.ReadLine() ?? string.Empty;
        ShapeList.ShowFilterByColors(selectedColor);
    }
}