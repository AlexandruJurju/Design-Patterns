using Observer.Publications;
using Observer.Subject;

namespace Observer.Observer;

public class NewsHunter
{
    private readonly string name;

    public NewsHunter(string name, PrintingOffice printingOffice)
    {
        this.name = name ?? throw new ArgumentNullException(nameof(name));

        if (printingOffice is null)
        {
            throw new ArgumentNullException(nameof(printingOffice));
        }

        printingOffice.NewNewspaperEvent += HandleNewNewspaper;
    }

    private void HandleNewNewspaper(Newspaper newspaper)
    {
        Console.WriteLine($"NewsHunter: {name} has been notified that a new newspaper with NUMBER: {newspaper.Number} and TITLE: {newspaper.Title} has been released");
    }
}