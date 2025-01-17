using System.Text.Json;

namespace Template.FileParser.DT;

public class JsonParser : FileParser
{
    protected override Dictionary<string, string> ParseContent(string content)
    {
        return JsonSerializer.Deserialize<Dictionary<string, string>>(content)!;
    }
}