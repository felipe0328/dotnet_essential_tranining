// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Creating and Deleting Directories

const string dirname = "TestDir";

// TODO: Create a Directory if it doesn't already exist
if (!Directory.Exists(dirname))
{
    Directory.CreateDirectory(dirname);
}
else
{
    Directory.Delete(dirname);
}

// TODO: Get the path for the current directory
string currentPath = Directory.GetCurrentDirectory();
Console.WriteLine($"Current Directory is {currentPath}");

// TODO: Just like with files, you can retrieve info about a directory
DirectoryInfo di = new(currentPath);
Console.WriteLine($"{di.Name}");
Console.WriteLine($"{di.Parent}");
Console.WriteLine($"{di.CreationTime}");

// TODO: Enumerate the contents of directories

Console.WriteLine("Just directories:");
List<string> thedirs = new(Directory.EnumerateDirectories(currentPath));
foreach (string dir in thedirs)
{
    Console.WriteLine(dir);
}
Console.WriteLine("---------------");

Console.WriteLine("Just files:");
List<string> files = new(Directory.EnumerateFiles(currentPath));
foreach (string file in files)
{
    Console.WriteLine(file);
}
Console.WriteLine("---------------");

Console.WriteLine("All directory contents:");
List<string> filesSystem = new(Directory.EnumerateFileSystemEntries(currentPath));
foreach (string fileSystem in filesSystem)
{
    Console.WriteLine(fileSystem);
}

