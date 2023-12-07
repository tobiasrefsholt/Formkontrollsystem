namespace Formkontrollsystem.Commands;

public class AddTriangle : Command
{
    public AddTriangle(ShapeList shapeList, ConsoleKey character) : base(shapeList, character)
    {
        Description = "Add triangle";
    }

    public override void Run()
    {
        throw new NotImplementedException();
    }
}