using Observer.PrintingOfficeEvent.Publications;

namespace Observer.PrintingOfficeEvent.Publishers;

public class BookPrintedEventArgs : EventArgs
{
    public Book Book { get; set; }

    public BookPrintedEventArgs(Book book)
    {
        Book = book;
    }
}