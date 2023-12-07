using Formkontrollsystem.Shapes;

namespace Formkontrollsystem.Commands;

public class ShowAllSortByColor : Command
{
    public ShowAllSortByColor(ShapeList shapeList, ConsoleKey character) : base(shapeList, character)
    {
        Description = "Sort by color";
    }

    public override void Run()
    {
        ShapeList.ShowByArea();
    }
}