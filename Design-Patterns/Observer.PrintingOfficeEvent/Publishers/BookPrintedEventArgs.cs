using Observer.PrintingOfficeEvent.Publications;

namespace Observer.PrintingOfficeEvent.Publishers;

public class BookPrintedEventArgs : EventArgs
{
    public BookPrintedEventArgs(Book book)
    {
        Book = book;
    }

    public Book Book { get; set; }
}