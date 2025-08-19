using Decorator.LowercaseStream;

var filePath = "input.txt";

using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))

using (var lowerCaseStream = new LowerCaseStream(fileStream))

using (var reader = new StreamReader(lowerCaseStream))
{
    var result = reader.ReadToEnd();

    Console.WriteLine(result);
}