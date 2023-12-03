namespace Formkontrollsystem.Commands;

public class ShowAll : Command
{
    public ShowAll(ShapeList shapeList, ConsoleKey character) : base(shapeList, character)
    {
        Description = "Show all";
    }

    public override void Run()
    {
        ShapeList.ShowAll();
    }
}