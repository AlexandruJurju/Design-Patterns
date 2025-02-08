using Observer.PrintingOfficeEvent.Publications;

namespace Observer.PrintingOfficeEvent.Publishers;

public class NewspaperPrintedEventArgs : EventArgs
{
    public Newspaper Newspaper { get; set; }

    public NewspaperPrintedEventArgs(Newspaper newspaper)
    {
        Newspaper = newspaper;
    }
}