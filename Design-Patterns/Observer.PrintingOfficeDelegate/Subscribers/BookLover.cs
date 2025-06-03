using Observer.PrintingOfficeDelegate.Publications;
using Observer.PrintingOfficeDelegate.Publishers;

namespace Observer.PrintingOfficeDelegate.Subscribers;

public class BookLover
{
    public BookLover(string name, PrintingOffice printingOffice)
    {
        Name = name;
        printingOffice.NewBookEvent += HandleNewBook;
    }

    public string Name { get; set; }

    private void HandleNewBook(Book book)
    {
        Console.WriteLine($"BookLover: {Name} has been notified that a new book with TITLE: {book.Title} AUTHOR: {book.Author} and YEAR: {book.Year} has been released");
    }
}