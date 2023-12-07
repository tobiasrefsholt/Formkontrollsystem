namespace Formkontrollsystem.Commands;

public class AddCircle : Command
{
    public AddCircle(ShapeList shapeList, ConsoleKey character) : base(shapeList, character)
    {
        Description = "Add circle";
    }

    public override void Run()
    {
        throw new NotImplementedException();
    }
}