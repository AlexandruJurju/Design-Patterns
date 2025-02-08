using Observer.PrintingOfficeDelegate.Publications;
using Observer.PrintingOfficeDelegate.Publishers;

namespace Observer.PrintingOfficeDelegate.Subscribers;

public class NewsHunter
{
    public string Name { get; set; }

    public NewsHunter(string name, PrintingOffice printingOffice)
    {
        Name = name;
        printingOffice.NewNewspaperEvent += HandleNewNewspaper;
    }

    private void HandleNewNewspaper(Newspaper newspaper)
    {
        Console.WriteLine($"NewsHunter: {Name} has been notified that a new newspaper with NUMBER: {newspaper.Number} and TITLE: {newspaper.Title} has been released");
    }
}