using Observer.PrintingOfficeDelegate.Publications;

namespace Observer.PrintingOfficeDelegate.Publishers;

public class PrintingOffice
{
    public event BookPrintedEventArgs? NewBookEvent;
    public event NewspaperPrintedEventArgs? NewNewspaperEvent;

    public void PrintBook(Book book)
    {
        OnBookPrinted(book);
    }

    public void PrintNewspaper(Newspaper newspaper)
    {
        OnNewspaperPrinted(newspaper);
    }

    protected virtual void OnBookPrinted(Book book)
    {
        NewBookEvent?.Invoke(book);
    }

    protected virtual void OnNewspaperPrinted(Newspaper newspaper)
    {
        NewNewspaperEvent?.Invoke(newspaper);
    }
}