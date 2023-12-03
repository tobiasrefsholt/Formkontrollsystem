namespace Formkontrollsystem.Commands;

public class AddCar : Command
{
    public AddCar(ShapeList shapeList, ConsoleKey character) : base(shapeList, character)
    {
        Description = "Add car";
    }

    public override void Run()
    {
        throw new NotImplementedException();
    }
}