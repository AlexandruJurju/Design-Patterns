using Observer.PrintingOfficeEvent.Publications;

namespace Observer.PrintingOfficeEvent.Publishers;

public class NewspaperPrintedEventArgs : EventArgs
{
    public NewspaperPrintedEventArgs(Newspaper newspaper)
    {
        Newspaper = newspaper;
    }

    public Newspaper Newspaper { get; set; }
}