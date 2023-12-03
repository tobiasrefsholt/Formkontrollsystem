using System.ComponentModel.Design;
using Formkontrollsystem;
using Formkontrollsystem.Commands;

var shapes = new ShapeList();
var commands = new CommandSet(shapes);

while (true)
{
    Console.Clear();
    commands.Show();
    commands.Run(Console.ReadKey().Key);
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}