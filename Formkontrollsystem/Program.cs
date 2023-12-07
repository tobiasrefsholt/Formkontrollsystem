using Formkontrollsystem;
using Formkontrollsystem.Commands;

var shapes = new ShapeList();
var commands = new CommandSet(shapes);

while (true)
{
    Console.Clear();
    commands.Show();
    var key = PromptUser.AskForConsoleKey("Choose an option: ");
    commands.Run(key);
    PromptUser.Continue();
}