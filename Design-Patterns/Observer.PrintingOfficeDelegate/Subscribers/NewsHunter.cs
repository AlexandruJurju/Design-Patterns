using Observer.PrintingOfficeDelegate.Publications;
using Observer.PrintingOfficeDelegate.Publishers;

namespace Observer.PrintingOfficeDelegate.Subscribers;

public class NewsHunter
{
    public NewsHunter(string name, PrintingOffice printingOffice)
    {
        Name = name;
        printingOffice.NewNewspaperEvent += HandleNewNewspaper;
    }

    public string Name { get; set; }

    private void HandleNewNewspaper(Newspaper newspaper)
    {
        Console.WriteLine($"NewsHunter: {Name} has been notified that a new newspaper with NUMBER: {newspaper.Number} and TITLE: {newspaper.Title} has been released");
    }
}