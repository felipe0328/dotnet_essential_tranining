// Some Description
using System.Text.RegularExpressions;

Regex dates = new(@"\d+");
bool programIsRunning = true;

while (programIsRunning)
{
    Console.WriteLine("Date to Convert? (Use mm/dd/yyy), or 'exit' to quit)");
    string? result = Console.ReadLine();

    if (result == "exit")
    {
        programIsRunning = false;
        break;
    }

    if (result == null || !dates.IsMatch(result))
    {
        Console.WriteLine("Invalid Entry, try again");
        continue;
    }

    MatchCollection mc = dates.Matches(result);
    Console.WriteLine($"Found {mc.Count} matches:");

    if (mc.Count < 3)
    {
        Console.WriteLine("Invalid Entry, try again");
        continue;
    }

    Console.WriteLine($"{mc[2].Value}-{mc[0].Value}-{mc[1].Value}");
}
