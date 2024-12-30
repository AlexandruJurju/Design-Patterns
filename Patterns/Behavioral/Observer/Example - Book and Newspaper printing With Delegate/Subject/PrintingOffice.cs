using Observer.Publications;
using Observer.Publications.Repositories;

namespace Observer.Subject;

public class PrintingOffice
{
    private readonly IBookRepository bookRepository;
    private readonly INewspaperRepository newspaperRepository;

    public event BookPrintedEventArgs NewBookEvent;
    public event NewspaperPrintedEventArgs NewNewspaperEvent;

    public PrintingOffice(IBookRepository bookRepository, INewspaperRepository newspaperRepository)
    {
        this.bookRepository = bookRepository ?? throw new ArgumentNullException(nameof(bookRepository));
        this.newspaperRepository = newspaperRepository ?? throw new ArgumentNullException(nameof(newspaperRepository));
    }

    public void PrintRandom(int bookCount, int newspaperCount)
    {
        for (int i = 0; i < bookCount; i++)
        {
            PrintOneBook();
        }

        for (int i = 0; i < newspaperCount; i++)
        {
            PrintOneNewspaper();
        }
    }

    private void PrintOneNewspaper()
    {
        Newspaper newspaper = newspaperRepository.GetRandom();
        OnNewspaperPrinted(newspaper);
    }

    protected virtual void OnNewspaperPrinted(Newspaper newspaper)
    {
        NewNewspaperEvent?.Invoke(newspaper);
    }

    private void PrintOneBook()
    {
        Book book = bookRepository.GetRandom();
        OnBookPrinted(book);
    }

    protected virtual void OnBookPrinted(Book book)
    {
        NewBookEvent?.Invoke(book);
    }
}