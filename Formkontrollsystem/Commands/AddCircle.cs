namespace Formkontrollsystem.Commands;

public class AddCircle : Command
{
    public AddCircle(ShapeList shapeList, ConsoleKey character) : base(shapeList, character)
    {
        Description = "Add circle";
    }

    public override void Run()
    {
        ShowDescription();
        var name = PromptUser.Ask("Name:");
        var color = PromptUser.Ask("Color:");
        var radius = PromptUser.AskForDouble("Radius:");
        ShapeList.AddShape(new Circle(name, color, radius));
    }
}