using Observer.PrintingOfficeEvent.Publications;

namespace Observer.PrintingOfficeEvent.Publishers;

public class PrintingOffice
{
    public event EventHandler<BookPrintedEventArgs>? NewBookEvent;
    public event EventHandler<NewspaperPrintedEventArgs>? NewNewspaperEvent;

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
        var args = new BookPrintedEventArgs(book);
        NewBookEvent?.Invoke(this, args);
    }

    protected virtual void OnNewspaperPrinted(Newspaper newspaper)
    {
        var args = new NewspaperPrintedEventArgs(newspaper);
        NewNewspaperEvent?.Invoke(this, args);
    }
}