namespace Formkontrollsystem.Commands;

public class ShowAllSortByColor : Command
{
    public ShowAllSortByColor(ShapeList shapeList, ConsoleKey character) : base(shapeList, character)
    {
        Description = "Show all and sort by color";
    }

    public override void Run()
    {
        ShapeList.ShowByArea();
    }
}