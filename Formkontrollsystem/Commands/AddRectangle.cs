namespace Formkontrollsystem.Commands;

public class AddRectangle : Command
{
    public AddRectangle(ShapeList shapeList, ConsoleKey character) : base(shapeList, character)
    {
        Description = "Add rectangle";
    }

    public override void Run()
    {
        throw new NotImplementedException();
    }
}