using Observer.Publications;
using Observer.Subject;

namespace Observer.Observer;

public class BookLover
{
    private readonly string name;

    public BookLover(string name, PrintingOffice printingOffice)
    {
        this.name = name ?? throw new ArgumentNullException(nameof(name));

        if (printingOffice is null)
        {
            throw new ArgumentNullException(nameof(printingOffice));
        }

        printingOffice.NewBookEvent += HandleNewBook;
    }

    private void HandleNewBook(Book book)
    {
        Console.WriteLine($"BookLover: {name} has been notified that a new book with TITLE: {book.Title} GENRE: {book.Genre} and PAGES: {book.Pages} has been released");
    }
}