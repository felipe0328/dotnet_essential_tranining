string dirName = "FileCollection";
string filename = "Results.txt";

DirectoryInfo workingDirectory = new(dirName);
Console.WriteLine(workingDirectory.FullName);
Dictionary<string, FileSummary> summary = new();

List<string> validExtentions = new() { ".xlsx", ".pptx", ".docx" };

summary.Add("Summary", new());

foreach (FileInfo file in workingDirectory.EnumerateFiles())
{
    if (validExtentions.Contains(file.Extension))
    {
        summary["Summary"].NumberOfFiles++;
        summary["Summary"].Size += file.Length;

        if (!summary.ContainsKey(file.Extension))
        {
            summary.Add(file.Extension, new());
        }

        summary[file.Extension].NumberOfFiles++;
        summary[file.Extension].Size += file.Length;
    }
}

using (StreamWriter sw = File.CreateText(filename))
{
    sw.WriteLine("Summary");
    sw.WriteLine("----------");
    sw.WriteLine($"Number of Files: {summary["Summary"].NumberOfFiles}");
    sw.WriteLine($"Number of Docx: {summary[".docx"].NumberOfFiles}");
    sw.WriteLine($"Number of Pptx: {summary[".pptx"].NumberOfFiles}");
    sw.WriteLine($"Number of Xlsx: {summary[".xlsx"].NumberOfFiles}");
    sw.WriteLine();
    sw.WriteLine("----------");
    sw.WriteLine($"Total Size: {summary["Summary"].Size, 15:N0} bytes");
    sw.WriteLine($"Size of Docx: {summary[".docx"].Size, 15:N0} bytes");
    sw.WriteLine($"Size of Pptx: {summary[".pptx"].Size, 15:N0} bytes");
    sw.WriteLine($"Size of Xlsx: {summary[".xlsx"].Size, 15:N0} bytes");
}

class FileSummary
{
    public int NumberOfFiles;
    public long Size;
}
