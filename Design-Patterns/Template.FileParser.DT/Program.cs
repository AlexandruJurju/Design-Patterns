using Template.FileParser.DT;

FileParser csvParser = new CsvParser();
FileParser jsonParser = new JsonParser();

var csvData = csvParser.ParseFile(@".\config.csv");
foreach (var pair in csvData)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}

Console.WriteLine();

var jsonData = jsonParser.ParseFile(@".\config.json");
foreach (var pair in jsonData)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}

Console.WriteLine();