using System.Text.RegularExpressions;

Regex dates = new(@"\d{2,}+");
bool programIsRunning = true;

while (programIsRunning)
{
    Console.WriteLine("Date to Convert? (Use mm/dd/yyy), or 'exit' to quit)");
    string? result = Console.ReadLine();

    if (result == null || !dates.IsMatch(result))
    {
        Console.WriteLine("Invalid Entry, try again");
        continue;
    }
}
