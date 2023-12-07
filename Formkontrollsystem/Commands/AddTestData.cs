using Formkontrollsystem.Shapes;

namespace Formkontrollsystem.Commands;

public class AddTestData : Command
{
    public AddTestData(ShapeList shapeList, ConsoleKey character) : base(shapeList, character)
    {
        Description = "Add test data";
    }

    public override void Run()
    {
        ShowDescription();
        ShapeList.AddTestData();
    }
}