using Formkontrollsystem.Shapes;

namespace Formkontrollsystem.Commands;

public class ShowAllSortByArea : Command
{
    public ShowAllSortByArea(ShapeList shapeList, ConsoleKey character) : base(shapeList, character)
    {
        Description = "Sort by area";
    }

    public override void Run()
    {
        ShapeList.ShowByArea();
    }
}