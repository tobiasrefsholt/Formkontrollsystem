using System.ComponentModel.Design;
using Formkontrollsystem;
using Formkontrollsystem.Commands;

var shapes = new ShapeList();
var commands = new CommandSet(shapes);

while (true)
{
    Console.Clear();
    commands.Show();
    var key = PromptUser.AskForConsoleKey("Velg fra menyen: ");
    commands.Run(key);
    PromptUser.Continue();
}