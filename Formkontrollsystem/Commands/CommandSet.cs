namespace Formkontrollsystem.Commands;

public class CommandSet
{
    private readonly Command[] _commands;

    public CommandSet(ShapeList shapeList)
    {
        _commands = new Command[]
        {
            new ShowAll(shapeList, ConsoleKey.D1),
            new ShowAllSortByArea(shapeList, ConsoleKey.D2),
            new ShowAllSortByColor(shapeList, ConsoleKey.D3),
            new ShowAllFilterByColor(shapeList, ConsoleKey.D4),
            new ShowTotalArea(shapeList, ConsoleKey.D5),
            new AddCar(shapeList, ConsoleKey.D6),
            new AddPlane(shapeList, ConsoleKey.D7),
            new AddBoat(shapeList, ConsoleKey.D8),
            new AddTestData(shapeList, ConsoleKey.D9)
        };
    }

    public void Show()
    {
        foreach (var command in _commands)
        {
            command.Show();
        }
    }

    public void Run(ConsoleKey character)
    {
        var command = FindCommand(character);
        command?.Run();
    }

    private Command? FindCommand(ConsoleKey character)
    {
        return _commands.FirstOrDefault(command => command.Character == character);
    }
}