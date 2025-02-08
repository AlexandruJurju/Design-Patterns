using Observer.PrintingOfficeEvent.Publishers;

namespace Observer.PrintingOfficeEvent.Subscribers;

public class NewsHunter
{
    public string Name { get; set; }

    public NewsHunter(string name, PrintingOffice printingOffice)
    {
        Name = name;
        printingOffice.NewNewspaperEvent += HandleNewNewspaper;
    }

    private void HandleNewNewspaper(object sender, NewspaperPrintedEventArgs args)
    {
        Console.WriteLine($"NewsHunter: {Name} has been notified that a new newspaper with NUMBER: {args.Newspaper.Number} and TITLE: {args.Newspaper.Title} has been released");
    }
}