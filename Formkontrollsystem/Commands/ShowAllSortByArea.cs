namespace Formkontrollsystem.Commands;

public class ShowAllSortByArea : Command
{
    public ShowAllSortByArea(ShapeList shapeList, ConsoleKey character) : base(shapeList, character)
    {
        Description = "Show all and sort by area";
    }

    public override void Run()
    {
        ShapeList.ShowByArea();
    }
}