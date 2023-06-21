// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for using Regex to find patterns
using System.Text.RegularExpressions;

string teststr1 = "The quick brown Fox jumps over the lazy Dog";
string teststr2 = "the quick brown fox jumps over the lazy dog";

// TODO: The IsMatch function is used to determine if the content of a string
// results in a match with the given Regex
Regex capWords = new(@"[A-Z]\w+");
Console.WriteLine(capWords.IsMatch(teststr1));
Console.WriteLine(capWords.IsMatch(teststr2));

// TODO: The RegexOptions argument can be used to perform
// case-insensitive searches
Regex noCase = new("fox", RegexOptions.IgnoreCase);
Console.WriteLine(noCase.IsMatch(teststr1));
Console.WriteLine(noCase.IsMatch(teststr2));

// Use the Match and Matches methods to get information about
// specific Regex matches for a given pattern

// TODO: The Match method returns a single match at a time
Match m = capWords.Match(teststr1);
while (m.Success)
{
    Console.WriteLine($"'{m.Value}' found at position {m.Index}");
    m = m.NextMatch();
}

// TODO: The Matches method returns a collection of Match objects
MatchCollection mc = capWords.Matches(teststr1);
Console.WriteLine($"Found {mc.Count} matches:");

foreach (Match value in mc.Cast<Match>())
{
    Console.WriteLine($"{value.Value} found at position {value.Index}");
}
