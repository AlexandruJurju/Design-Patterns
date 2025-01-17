using System.Globalization;

namespace Template.FileParser.DT;

public abstract class FileParser
{
    public Dictionary<string, string> ParseFile(string filePath)
    {
        LogOperation($"Validating {filePath}");
        ValidateFile(filePath);

        LogOperation("Loading file");
        var content = File.ReadAllText(filePath);

        LogOperation("Parsing file");
        Dictionary<string, string> data = ParseContent(content);

        LogOperation("Enriching data");
        EnrichData(data);

        LogOperation("Validating data");
        ValidateData(data);

        return data;
    }

    protected virtual void EnrichData(Dictionary<string, string> data)
    {
        data["parsedAt"] = DateTime.UtcNow.ToString(CultureInfo.InvariantCulture);
    }

    protected virtual void ValidateData(Dictionary<string, string> data)
    {
        // default empty
    }

    protected abstract Dictionary<string, string> ParseContent(string content);

    private void ValidateFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("File not found", filePath);
        }

        if (new FileInfo(filePath).Length == 0)
        {
            throw new Exception("File is empty");
        }
    }

    protected virtual void LogOperation(string message)
    {
        Console.WriteLine($"{DateTime.UtcNow:HH:mm:ss} - {message}");
    }
}