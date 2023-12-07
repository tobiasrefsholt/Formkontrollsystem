namespace Formkontrollsystem.Commands;

public class AddRectangle : Command
{
    public AddRectangle(ShapeList shapeList, ConsoleKey character) : base(shapeList, character)
    {
        Description = "Add rectangle";
    }

    public override void Run()
    {
        ShowDescription();
        var name = PromptUser.Ask("Name:");
        var color = PromptUser.Ask("Color:");
        var length = PromptUser.AskForDouble("Length:");
        var width = PromptUser.AskForDouble("Width:");
        ShapeList.AddShape(new Rectangle(name, color, length, width));
    }
}