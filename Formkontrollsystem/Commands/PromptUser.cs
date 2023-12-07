namespace Formkontrollsystem.Commands;

public class PromptUser
{
    public static string Ask(string question)
    {
        Console.Write(question + " ");
        var answer = Console.ReadLine();
        return answer ?? string.Empty;
    }

    public static string? Ask(string question, bool isRequired)
    {
        while (true)
        {
            var answer = Ask(question);
            if (answer != string.Empty || !isRequired) return answer;
            Console.WriteLine("This field is required.");
        }
    }

    public static double AskForDouble(string question)
    {
        while (true)
        {
            var answer = AskForDoubleOrNull(question);
            if (answer != null) return (double)answer;
            Console.WriteLine("Invalid input. Must be a number.");
        }
    }

    public static double? AskForDoubleOrNull(string question)
    {
        while (true)
        {
            var answer = Ask(question);
            if (answer == string.Empty) return null;
            if (double.TryParse(answer, out var number)) return number;
            Console.WriteLine("Invalid input. Must be a number.");
        }
    }

    public static ConsoleKey AskForConsoleKey(string question)
    {
        Console.Write(question);
        var key = Console.ReadKey().Key;
        Console.WriteLine();
        return key;
    }

    public static void Continue()
    {
        Console.Write("Press any key to continue...");
        Console.ReadKey();
        Console.WriteLine();
    }
}