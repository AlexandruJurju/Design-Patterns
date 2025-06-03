using Observer.PrintingOfficeEvent.Publishers;

namespace Observer.PrintingOfficeEvent.Subscribers;

public class BookLover
{
    public BookLover(string name, PrintingOffice printingOffice)
    {
        Name = name;
        printingOffice.NewBookEvent += HandleNewBook;
    }

    public string Name { get; set; }

    private void HandleNewBook(object sender, BookPrintedEventArgs args)
    {
        Console.WriteLine($"BookLover: {Name} has been notified that a new book with TITLE: {args.Book.Title} AUTHOR: {args.Book.Author} and YEAR: {args.Book.Year} has been released");
    }
}