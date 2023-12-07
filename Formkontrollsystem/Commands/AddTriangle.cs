using Formkontrollsystem.Shapes;

namespace Formkontrollsystem.Commands;

public class AddTriangle : Command
{
    public AddTriangle(ShapeList shapeList, ConsoleKey character) : base(shapeList, character)
    {
        Description = "Add triangle";
    }

    public override void Run()
    {
        ShowDescription();
        var name = PromptUser.Ask("Name:");
        var color = PromptUser.Ask("Color:");
        var @base = PromptUser.AskForDouble("Base:");
        var height = PromptUser.AskForDouble("Height:");
        ShapeList.AddShape(new Triangle(name, color, @base, height));
    }
}