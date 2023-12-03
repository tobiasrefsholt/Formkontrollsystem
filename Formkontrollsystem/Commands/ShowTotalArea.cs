namespace Formkontrollsystem.Commands;

public class ShowTotalArea : Command
{
    public ShowTotalArea(ShapeList shapeList, ConsoleKey character) : base(shapeList, character)
    {
        Description = "Show total area";
    }

    public override void Run()
    {
        ShapeList.ShowTotalArea();
    }
}