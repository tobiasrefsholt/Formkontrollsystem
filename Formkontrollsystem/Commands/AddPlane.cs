namespace Formkontrollsystem.Commands;

public class AddPlane : Command
{
    public AddPlane(ShapeList shapeList, ConsoleKey character) : base(shapeList, character)
    {
        Description = "Add plane";
    }

    public override void Run()
    {
        throw new NotImplementedException();
    }
}