using Formkontrollsystem.Shapes;

namespace Formkontrollsystem.Commands;

public abstract class Command
{
    protected readonly ShapeList ShapeList;
    protected string Description = string.Empty;
    public ConsoleKey Character { get; protected init; }

    protected Command(ShapeList shapeList, ConsoleKey character)
    {
        ShapeList = shapeList;
        Character = character;
    }

    public void Show()
    {
        Console.WriteLine($"({Character}) {Description}");
    }

    protected void ShowDescription()
    {
        Console.Clear();
        Console.WriteLine(Description);
    }

    public abstract void Run();
}