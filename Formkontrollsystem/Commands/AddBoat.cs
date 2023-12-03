namespace Formkontrollsystem.Commands;

public class AddBoat : Command
{
    public AddBoat(ShapeList shapeList, ConsoleKey character) : base(shapeList, character)
    {
        Description = "Add boat";
    }

    public override void Run()
    {
        throw new NotImplementedException();
    }
}